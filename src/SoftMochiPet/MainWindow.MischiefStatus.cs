using Brush = System.Windows.Media.Brush;
using SoftMochiPet.Core;
using SoftMochiPet.Services;

namespace SoftMochiPet;

public partial class MainWindow
{
    private Brush? _mischiefActiveBrush;
    private Brush MischiefActiveBrush => _mischiefActiveBrush ??= MischiefBarFill.Background;
    private bool _mischiefWaitingForTarget;
    private string? _lastMischiefStatusReason;
    private double _nextMischiefStatusLog;

    private void UpdateMischiefStatus()
    {
        var now = _clock.Elapsed.TotalSeconds;
        var reason = !_settings.AllowMischief ? "disabled"
            : _sessionLocked ? "session_locked"
            : _settings.QuietMode ? "quiet"
            : _state is PetState.Sleeping or PetState.Waking ? "sleeping"
            : _prankPhase != PrankPhase.None ? "performing"
            : _mischief.CooldownRemainingSeconds > 0 ? "cooldown"
            : _isDragging ? "dragging"
            : _animator.Hatless ? "hat_recovery"
            : _prankArtwork is null || _windowPranks is null ? "assets_unavailable"
            : HasHeldPrank && _mischief.Value >= 100 ? "hat_occupied_full"
            : _mischiefWaitingForTarget ? "no_eligible_window"
            : _enclosureHandle != IntPtr.Zero ? "enclosed"
            : _mischief.AutonomousActionDue && _state is not (PetState.Idle or PetState.Curious or PetState.Running)
                ? "pet_busy" : "charging";
        var cooldown = (int)Math.Ceiling(_mischief.CooldownRemainingSeconds);
        var attempt = _mischief.SecondsUntilNextAttempt is { } seconds
            ? Math.Max(seconds, _nextPrankSearch - now) : (double?)null;
        var countdown = (int)Math.Ceiling(Math.Max(0, attempt ?? 0));
        var text = reason switch
        {
            "disabled" => LocalizationManager.Get("Mischief_Disabled"),
            "session_locked" => LocalizationManager.Get("Mischief_SessionLocked"),
            "quiet" => LocalizationManager.Get("Mischief_Quiet"),
            "sleeping" => LocalizationManager.Get("Mischief_Sleeping"),
            "performing" => _manualRestoreInProgress ? LocalizationManager.Get("Mischief_Restoring") : LocalizationManager.Get("Mischief_Performing"),
            "cooldown" => LocalizationManager.Get("Mischief_Cooldown", cooldown),
            "dragging" => LocalizationManager.Get("Mischief_Dragging"),
            "hat_recovery" => LocalizationManager.Get("Mischief_HatRecovery"),
            "assets_unavailable" => LocalizationManager.Get("Mischief_AssetsUnavailable"),
            "hat_occupied_full" => LocalizationManager.Get("Mischief_HatOccupiedFull"),
            "no_eligible_window" => LocalizationManager.Get("Mischief_NoEligibleWindow", countdown),
            "enclosed" => LocalizationManager.Get("Mischief_Enclosed"),
            "pet_busy" => LocalizationManager.Get("Mischief_PetBusy"),
            _ => LocalizationManager.Get("Mischief_ChargingProgress", (int)Math.Floor(_mischief.Value)) + (HasHeldPrank ? LocalizationManager.Get("Mischief_HatOccupied") : ""),
        };
        _trayIcon.SetMischiefStatus(text);
        if (reason == _lastMischiefStatusReason && now < _nextMischiefStatusLog) return;
        _lastMischiefStatusReason = reason;
        _nextMischiefStatusLog = now + 30;
        DiagnosticsLog.WriteEvent("MischiefStatus", ("Reason", reason),
            ("Value", Math.Round(_mischief.Value, 2)), ("CooldownSeconds", cooldown),
            ("NextAttemptSeconds", attempt is { } remaining ? Math.Round(Math.Max(0, remaining), 2) : null),
            ("AutonomyEnabled", _settings.AllowMischief), ("HatOccupied", HasHeldPrank), ("State", _state));
    }
}
