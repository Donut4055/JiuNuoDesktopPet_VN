namespace SoftMochiPet.Core;

public static class LocalizationManager
{
    public const string Vietnamese = "vi-VN";
    public const string Chinese = "zh-CN";

    private static string _currentLanguage = Chinese;

    public static event Action? LanguageChanged;

    public static string CurrentLanguage
    {
        get => _currentLanguage;
        set => SetLanguage(value);
    }

    public static bool IsVietnamese => string.Equals(_currentLanguage, Vietnamese, StringComparison.OrdinalIgnoreCase);

    public static void SetLanguage(string? language)
    {
        var target = string.Equals(language, Chinese, StringComparison.OrdinalIgnoreCase) ? Chinese : Vietnamese;
        if (string.Equals(_currentLanguage, target, StringComparison.Ordinal))
        {
            return;
        }

        _currentLanguage = target;
        LanguageChanged?.Invoke();
    }

    public static string Get(string key, params object[] args)
    {
        var dict = IsVietnamese ? VietnameseStrings : ChineseStrings;
        if (!dict.TryGetValue(key, out var template) && !ChineseStrings.TryGetValue(key, out template))
        {
            template = key;
        }

        return args.Length == 0 ? template : string.Format(template, args);
    }

    public static string GetCharacterName(string id, string fallback)
    {
        if (IsVietnamese)
        {
            return id.ToLowerInvariant() switch
            {
                "nuonuo" => "Nhu Nhu",
                "feibijiubi" => "Phi Bỉ",
                _ => fallback,
            };
        }

        return fallback;
    }

    private static readonly Dictionary<string, string> VietnameseStrings = new(StringComparer.Ordinal)
    {
        ["Tray_Mute"] = "Tắt tiếng",
        ["Tray_StartWithWindows"] = "Khởi động cùng Windows",
        ["Tray_FastingMode"] = "Chế độ nhịn ăn (không đói)",
        ["Tray_InfiniteMode"] = "Chế độ vô hạn (ẩn thanh trạng thái)",
        ["Tray_CoexistenceMode"] = "Song thú đồng hành (xuất hiện cả hai)",
        ["Tray_SpeechBubbles"] = "Hiện bong bóng thoại",
        ["Tray_QuietMode"] = "Chế độ yên tĩnh (chỉ đứng yên / ngủ)",
        ["Tray_AllowMischief"] = "Cho phép Phi Bỉ nghịch ngợm",
        ["Tray_MischiefStatus"] = "Trạng thái nghịch ngợm: {0}",
        ["Tray_MischiefCharging"] = "Đang tích năng lượng",
        ["Tray_MischiefClosed"] = "Đã tắt",
        ["Tray_PrankOnce"] = "Nghịch ngợm một phát",
        ["Tray_Tease"] = "Trêu chọc bé",
        ["Tray_ReturnWindows"] = "Bắt Phi Bỉ trả lại cửa sổ",
        ["Tray_CharacterSelect"] = "Chọn nhân vật",
        ["Tray_BringHome"] = "Gọi bé về nhà",
        ["Tray_PairMenu"] = "Diễn tập tương tác đôi",
        ["Tray_PairCheek"] = "Phi Bỉ véo má Nhu Nhu",
        ["Tray_PairSleep"] = "Tựa vào nhau ngủ",
        ["Tray_PairFeed"] = "Móc đồ ăn trong mũ ra đút",
        ["Tray_PairFollow"] = "Đeo bám như kẹo kéo",
        ["Tray_PairNuzzle"] = "Đi ngang cọ cọ má",
        ["Tray_PairBall"] = "Cùng nhau chơi bóng",
        ["Tray_PairWatch"] = "Cùng hóng hớt",
        ["Tray_PairDialogue"] = "Để hai bé trò chuyện",
        ["Tray_Exit"] = "Thoát ứng dụng",
        ["Tray_Language"] = "Ngôn ngữ / 语言",
        ["Tray_LanguageVi"] = "Tiếng Việt",
        ["Tray_LanguageZh"] = "中文",
        ["Tray_SizeFormat"] = "Kích thước {0}  {1}%",
        ["Tray_SizeBoth"] = "Cả hai bé",
        ["Tray_TitleBase"] = "JiuNuo Thú Cưng Bàn Làm Việc",
        ["Tray_TitleCoexist"] = "JiuNuo Thú Cưng · Song Thú Đồng Hành",
        ["Tray_TitleBehavior"] = "JiuNuo Thú Cưng · Điều Khiển Hành Vi",
        ["Tray_FeatureTestStatus"] = "Đang chuẩn bị kiểm thử tính năng…",
        ["Tray_FeatureTestStop"] = "Dừng kiểm thử tính năng",
        ["Tray_FeatureTestRetry"] = "Thử lại mục này",
        ["Behavior_StatusDefault"] = "Điều khiển hành vi: Vui lòng chọn hành động",
        ["Behavior_StatusFormat"] = "Điều khiển hành vi: {0}",
        ["Behavior_Actions"] = "Kích hoạt hành động trực tiếp",
        ["Behavior_Stop"] = "Dừng hành động hiện tại",
        ["Behavior_Autonomy"] = "Tự do hoạt động thường ngày (bản điều khiển)",
        ["Behavior_AutonomyTooltip"] = "Bật để cho phép bé tự đi dạo, nghỉ ngơi; chỉ áp dụng cho phiên điều khiển hiện tại.",
    };

    private static readonly Dictionary<string, string> ChineseStrings = new(StringComparer.Ordinal)
    {
        ["Tray_Mute"] = "禁音",
        ["Tray_StartWithWindows"] = "开机自启",
        ["Tray_FastingMode"] = "禁食模式（永不饥饿）",
        ["Tray_InfiniteMode"] = "无限模式（隐藏双方进度条）",
        ["Tray_CoexistenceMode"] = "双宠共存",
        ["Tray_SpeechBubbles"] = "显示头顶对话气泡",
        ["Tray_QuietMode"] = "安静模式（只站立或睡觉）",
        ["Tray_AllowMischief"] = "允许自主捣蛋",
        ["Tray_MischiefStatus"] = "捣蛋状态：{0}",
        ["Tray_MischiefCharging"] = "蓄力中",
        ["Tray_MischiefClosed"] = "已关闭",
        ["Tray_PrankOnce"] = "捣蛋一下",
        ["Tray_Tease"] = "逗逗她",
        ["Tray_ReturnWindows"] = "把窗口还回来",
        ["Tray_CharacterSelect"] = "桌宠角色",
        ["Tray_BringHome"] = "让她回家",
        ["Tray_PairMenu"] = "双人互动演示",
        ["Tray_PairCheek"] = "菲比揪糯糯的脸",
        ["Tray_PairSleep"] = "靠在一起睡觉",
        ["Tray_PairFeed"] = "从帽子里掏零食投喂",
        ["Tray_PairFollow"] = "小跟屁虫",
        ["Tray_PairNuzzle"] = "路过蹭一下",
        ["Tray_PairBall"] = "一起玩小球",
        ["Tray_PairWatch"] = "一起看热闹",
        ["Tray_PairDialogue"] = "让她们聊两句",
        ["Tray_Exit"] = "退出桌宠",
        ["Tray_Language"] = "语言 / Language",
        ["Tray_LanguageVi"] = "Tiếng Việt",
        ["Tray_LanguageZh"] = "中文",
        ["Tray_SizeFormat"] = "{0}大小  {1}%",
        ["Tray_SizeBoth"] = "两人",
        ["Tray_TitleBase"] = "啾糯桌宠",
        ["Tray_TitleCoexist"] = "啾糯桌宠 · 双宠共存",
        ["Tray_TitleBehavior"] = "啾糯桌宠 · 行为控制版",
        ["Tray_FeatureTestStatus"] = "准备专属功能测试…",
        ["Tray_FeatureTestStop"] = "停止专属功能测试",
        ["Tray_FeatureTestRetry"] = "重试本项",
        ["Behavior_StatusDefault"] = "行为控制版：请选择行为",
        ["Behavior_StatusFormat"] = "行为控制版：{0}",
        ["Behavior_Actions"] = "直接触发行为",
        ["Behavior_Stop"] = "停止当前行为",
        ["Behavior_Autonomy"] = "自动日常活动（行为控制版）",
        ["Behavior_AutonomyTooltip"] = "开启后允许自行散步、休息等日常活动；此选项仅用于当前行为控制会话。",
    };
}
