namespace SoftMochiPet.Core;

public readonly record struct PairDialogue(bool FeibiFirst, string First, string Reply);

public static class PairDialogueCatalog
{
    private static readonly IReadOnlyList<PairDialogue> ChineseExchanges =
    [
        new(true, "糯糯，猜我帽里有啥？", "蛋糕……？"),
        new(true, "去那边看看嘛！", "等我一下呀。"),
        new(true, "我跳得高不高？", "好高呀。"),
        new(true, "帽子里有惊喜！", "能吃吗？"),
        new(true, "糯糯，醒醒嘛。", "再睡一小会儿……"),
        new(false, "你又在笑什么？", "嘿嘿，秘密！"),
        new(false, "帽子借我躺躺。", "好呀，钻进来！"),
        new(false, "你跑慢一点呀。", "那你牵着我！"),
        new(false, "今天有蛋糕吗？", "我找找看！"),
        new(false, "不要捣蛋啦。", "就一下下嘛！"),
    ];

    private static readonly IReadOnlyList<PairDialogue> VietnameseExchanges =
    [
        new(true, "Nhu Nhu, đoán xem trong mũ có gì nè?", "Bánh kem hả...?"),
        new(true, "Qua đằng kia xem đi mà!", "Chờ tui một chút coi."),
        new(true, "Tui nhảy có cao hông nè?", "Cao ơi là cao luôn á."),
        new(true, "Trong mũ có quà bất ngờ nè!", "Ăn được hông dợ?"),
        new(true, "Nhu Nhu ơi, dậy đi mà~", "Cho ngủ thêm xíu nữa..."),
        new(false, "Bồ lại cười cái gì đó?", "Hehe, bí mật!"),
        new(false, "Cho tui mượn mũ nằm xíu đi.", "Được chứ, chui vô nè!"),
        new(false, "Bồ chạy chậm lại xíu coi.", "Thế thì dắt tay tui đi!"),
        new(false, "Hôm nay có bánh kem hông?", "Để tui tìm thử xem!"),
        new(false, "Đừng có nghịch ngợm nữa mà.", "Nghịch một xíu xiu thui!"),
    ];

    public static IReadOnlyList<PairDialogue> Exchanges =>
        LocalizationManager.IsVietnamese ? VietnameseExchanges : ChineseExchanges;
}
