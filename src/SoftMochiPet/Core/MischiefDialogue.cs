namespace SoftMochiPet.Core;

public enum MischiefCue
{
    Teased,
    Sneak,
    Kick,
    Punch,
    Charge,
    Recoil,
    HideWindow,
    HoldingWindow,
    ReturnWindow,
    Burst,
    Smash,
    Tear,
    Finished,
    Interrupted,
    NoTarget,
}

public sealed class MischiefDialogueSelector
{
    private static readonly IReadOnlyDictionary<MischiefCue, IReadOnlyList<string>> Lines =
        new Dictionary<MischiefCue, IReadOnlyList<string>>
        {
            [MischiefCue.Teased] = ["嘿嘿，再来！", "痒痒！", "又逗我！", "啾！抓住你！"],
            [MischiefCue.Sneak] = ["嘘——", "没看见我哦。", "悄悄来。", "嘿嘿，等着！"],
            [MischiefCue.Kick] = ["看脚！", "嘿呀！", "走你咯！", "踢一下下！"],
            [MischiefCue.Punch] = ["咚！", "小拳拳！", "嘿！", "接招啦！"],
            [MischiefCue.Charge] = ["让一让嘛！", "冲呀——！", "我来咯！", "帽子抓稳！"],
            [MischiefCue.Recoil] = ["哎哟哟。", "屁股墩！", "装没看见嘛。", "我站稳啦！"],
            [MischiefCue.HideWindow] = ["借我藏一下！", "帽子装得下！", "嘿嘿，归我啦。", "不许偷看哦！"],
            [MischiefCue.HoldingWindow] = ["没有藏呀。", "帽子乖一点！", "嗯？什么窗？", "嘿嘿……"],
            [MischiefCue.ReturnWindow] = ["还你啦！", "当当——！", "在这儿呢！", "好啦，不藏啦。"],
            [MischiefCue.Burst] = ["忍不住啦！", "帽子先歇着！", "我要来真的咯！", "嘿嘿，看好啦！"],
            [MischiefCue.Smash] = ["飞咯——！", "啾！大脚脚！", "哇，散开啦！", "我好厉害呀！"],
            [MischiefCue.Tear] = ["嘿——咻！", "怎么这么韧呀！", "再拉一点点！", "哎，粘手啦！"],
            [MischiefCue.Finished] = ["好玩！", "帽子回来啦！", "嘿嘿，没事呀。", "我很乖的！"],
            [MischiefCue.Interrupted] = ["被逮到啦！", "好嘛好嘛。", "我松手啦。", "下次再玩嘛。"],
            [MischiefCue.NoTarget] = ["玩具躲哪啦？", "等会儿再玩！", "先蹦两下！", "那我歇一下。"],
        };

    private static readonly IReadOnlyDictionary<MischiefCue, IReadOnlyList<string>> VietnameseLines =
        new Dictionary<MischiefCue, IReadOnlyList<string>>
        {
            [MischiefCue.Teased] = ["Hehe, chọc nữa đi!", "Nhột quá à!", "Lại ghẹo tui gòi!", "Chiu! Bắt quả tang nha!"],
            [MischiefCue.Sneak] = ["Suỵt——", "Hổng có thấy tui đâu nha.", "Rón rén tới gần nè.", "Hehe, chờ đó coi!"],
            [MischiefCue.Kick] = ["Ăn một cú sút nè!", "Hây a!", "Bay đi nha cưng!", "Đá nhẹ một cái thui!"],
            [MischiefCue.Punch] = ["Bốp!", "Đấm một phát nè!", "Hây!", "Đỡ chiêu nè!"],
            [MischiefCue.Charge] = ["Tránh đường tránh đường mau!", "Xông lên nào——!", "Tui tới đây nè!", "Mũ ơi bám cho chặt!"],
            [MischiefCue.Recoil] = ["Ái cha cha.", "Đập mông xuống đất rùi!", "Coi như hổng thấy gì đi nha.", "Tui đứng vững lại gòi nè!"],
            [MischiefCue.HideWindow] = ["Mượn giấu xíu nha!", "Mũ này chứa vừa in à!", "Hehe, giờ là của tui!", "Hổng được nhìn lén đâu á!"],
            [MischiefCue.HoldingWindow] = ["Đâu có giấu gì đâu nè.", "Mũ ơi ngoan nào!", "Ủa? Cửa sổ nào dợ?", "Hehe..."],
            [MischiefCue.ReturnWindow] = ["Trả lại cho bạn nè!", "Ta-da——!", "Nó ở đây nè!", "Được gòi, hổng giấu nữa đâu."],
            [MischiefCue.Burst] = ["Hết chịu nổi gòi!", "Mũ ơi nghỉ xíu nha!", "Lần này tui chơi thật á!", "Hehe, mở to mắt ra nhìn nè!"],
            [MischiefCue.Smash] = ["Bay tung tóe gòi——!", "Chiu! Cú đá siêu cấp!", "Oa, vỡ vụn rùi!", "Tui đỉnh quá trời quá đất!"],
            [MischiefCue.Tear] = ["Hây——dô!", "Sao mà dai nhách vậy nè!", "Kéo mạnh thêm tí nữa!", "Ái chà, dính chặt tay gòi!"],
            [MischiefCue.Finished] = ["Vui quá xá!", "Mũ bay về lại gòi nè!", "Hehe, hổng có sao hết trơn.", "Tui ngoan lắm á nha!"],
            [MischiefCue.Interrupted] = ["Bị bắt quả tang gòi!", "Dạ dạ biết gòi mà.", "Tui buông tay ra liền nè.", "Lần sau lại chơi tiếp nha."],
            [MischiefCue.NoTarget] = ["Đồ chơi trốn đâu mất tiêu gòi?", "Lát nữa quậy tiếp!", "Nhún nhảy đôi ba cái đã!", "Thế thì tui nghỉ ngơi xíu."],
        };

    private readonly Random _random;
    private readonly Dictionary<MischiefCue, int> _previous = [];

    public MischiefDialogueSelector(Random? random = null) => _random = random ?? Random.Shared;

    public static IReadOnlyList<string> GetLines(MischiefCue cue) =>
        LocalizationManager.IsVietnamese && VietnameseLines.TryGetValue(cue, out var viLines) ? viLines : Lines[cue];

    public string Choose(MischiefCue cue)
    {
        var lines = GetLines(cue);
        var index = _random.Next(lines.Count);
        if (_previous.TryGetValue(cue, out var previous) && index == previous)
        {
            index = (index + 1) % lines.Count;
        }
        _previous[cue] = index;
        return lines[index];
    }
}
