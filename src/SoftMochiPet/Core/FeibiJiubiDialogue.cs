namespace SoftMochiPet.Core;

internal static class FeibiJiubiDialogue
{
    private static readonly IReadOnlyDictionary<DialogueCue, IReadOnlyList<string>> Lines =
        new Dictionary<DialogueCue, IReadOnlyList<string>>
        {
            [DialogueCue.Startup] = ["啾，你来啦！", "嗨，陪我玩！", "今天去哪呀？", "嘿嘿，见面啦。"],
            [DialogueCue.IconsHidden] = ["咦，都躲啦？", "在玩捉迷藏？", "出来玩嘛！", "我明明看见啦。"],
            [DialogueCue.PlatformLaunch] = ["芜湖——！", "帽子抓紧我！", "哇，脚轻轻！", "还能更高吗？"],
            [DialogueCue.HardLanding] = ["哎哟，弹一下！", "鞋鞋先到啦！", "嘿，还能蹦！", "啾，没摔扁！"],
            [DialogueCue.ConfidentClimb] = ["嘿，看我爬！", "上面有啥呀？", "小脚很有劲！", "冲呀冲呀！"],
            [DialogueCue.CarefulClimb] = ["鞋鞋别滑呀。", "再够高一点！", "我抓得住嘛？", "帽子别挡眼呀。"],
            [DialogueCue.ClimbSlip] = ["哎呀，手滑滑！", "差一小点嘛！", "墙墙好滑呀。", "不服，再爬！"],
            [DialogueCue.ClimbSuccess] = ["看，我在这儿！", "嘿嘿，够高吧！", "风吹帽子啦！", "下面变小啦！"],
            [DialogueCue.Exploration] = ["那边亮亮的！", "嘿，去瞅瞅！", "还有哪儿没玩？", "跟小脚走嘛！"],
            [DialogueCue.Sleep] = ["眼皮好重呀。", "再玩……一会。", "啾，借我靠靠。", "梦里也有你？"],
            [DialogueCue.WakeNormally] = ["嘿，又见面啦！", "梦里跑好远呀。", "睡翘一撮毛！", "啾，还想出去！"],
            [DialogueCue.PickedUp] = ["举高高耶！", "啾，带我去哪？", "小脚够不到啦。", "晃晃还挺好玩！"],
            [DialogueCue.Released] = ["哇，地板来啦！", "小脚找地板！", "等等我的帽子！", "啾，轻轻一点！"],
            [DialogueCue.DragThrow] = ["咻——好快呀！", "帽子追不上啦！", "哇，风呼呼的！", "再飞一小会！"],
            [DialogueCue.TerrainHop] = ["蹦高一点嘛！", "嘿，小脚弹弹！", "啾，够得着！", "一下就过去呀！"],
            [DialogueCue.TerrainJumpDown] = ["下面也想逛！", "嘿，接住帽子！", "往下蹦蹦嘛！", "啾，那儿好玩！"],
            [DialogueCue.EdgeSlide] = ["哧溜，好滑呀！", "小手抓牢嘛！", "鞋鞋蹭痒痒。", "再溜一小段！"],
            [DialogueCue.WindowMaximized] = ["哇，挤到我啦！", "窗窗长好快！", "帽子吓歪啦！", "怎么突然飞啦！"],
            [DialogueCue.Home] = ["窝窝真舒服！", "嘿，还是这里！", "回来看你啦！", "帽子也歇歇。"],
            [DialogueCue.VoiceEnabled] = ["啾，在这里！", "嘿，看看我！", "哈喽小伙伴！", "想我了没呀？"],
            [DialogueCue.VoiceDisabled] = ["嘘，悄悄的。", "蹑手蹑脚走。", "啾……小小声。", "偷偷陪着你。"],
        };

    private static readonly IReadOnlyDictionary<DialogueCue, IReadOnlyList<string>> VietnameseLines =
        new Dictionary<DialogueCue, IReadOnlyList<string>>
        {
            [DialogueCue.Startup] = ["Chiu, bạn tới rồi hả!", "Nè, chơi với tui đi!", "Hôm nay đi đâu quậy ta?", "Hehe, gặp lại gòi nha~"],
            [DialogueCue.IconsHidden] = ["Ủa, trốn hết trơn gòi?", "Chơi trốn tìm hả?", "Ra đây chơi nè!", "Rõ ràng tui thấy mà ta!"],
            [DialogueCue.PlatformLaunch] = ["Bay lên nào vù vù!", "Cái mũ giữ chặt tui coi!", "Oa, chân nhẹ tênh à!", "Bay cao hơn nữa được hông?"],
            [DialogueCue.HardLanding] = ["Ái chà, tưng một cái!", "Giày chạm đất trước rùi!", "Hê, vẫn còn nhún nhảy được!", "Chiu, hông có bị bẹp dí đâu nha!"],
            [DialogueCue.ConfidentClimb] = ["Hehe, xem tui trèo nè!", "Trên đó có gì vui hông ta?", "Chân tui khỏe lắm á!", "Tiến lên tiến lên nào!"],
            [DialogueCue.CarefulClimb] = ["Giày ơi đừng có trượt nha.", "Vươn cao thêm tí nữa!", "Tui với tới hông ta?", "Mũ đừng che mắt tui chứ!"],
            [DialogueCue.ClimbSlip] = ["Ái cha, trượt tay gòi!", "Còn xíu xiu nữa thui mà!", "Tường trơn như bôi mỡ á.", "Hổng chịu đâu, leo lại!"],
            [DialogueCue.ClimbSuccess] = ["Nhìn nè, tui lên tới rùi!", "Hehe, cao ghê chưa!", "Gió thổi bay cả mũ!", "Bên dưới bé tí tẹo à!"],
            [DialogueCue.Exploration] = ["Bên kia sáng loáng kìa!", "Hê, qua nghía thử coi!", "Còn chỗ nào chưa quậy hông?", "Chân ơi dẫn đường nà!"],
            [DialogueCue.Sleep] = ["Mí mắt nặng trĩu gòi...", "Chơi thêm... một xíu nữa thui...", "Chiu, cho tui mượn vai dựa xíu...", "Trong mơ cũng có bạn hông ta?"],
            [DialogueCue.WakeNormally] = ["Hê, lại gặp nhau rùi!", "Trong mơ tui chạy xa xôi lắm á.", "Ngủ dậy tóc chổng ngược luôn!", "Chiu, lại muốn ra ngoài chơi!"],
            [DialogueCue.PickedUp] = ["Được nhấc lên cao kìa!", "Chiu, bế tui đi đâu dợ?", "Chân hổng với tới đất rùi.", "Đung đưa qua lại vui ghê!"],
            [DialogueCue.Released] = ["Oa, sàn nhà tới rùi!", "Chân chạm đất cái cộp!", "Chờ cái mũ của tui với!", "Chiu, nhẹ tay thôi nha!"],
            [DialogueCue.DragThrow] = ["Vèo——nhanh quá trời!", "Cái mũ đuổi theo hổng kịp luôn!", "Oa gió rít vù vù bên tai!", "Cho tui bay thêm xíu nữa!"],
            [DialogueCue.TerrainHop] = ["Nhảy cao thêm xíu nào!", "Hê, đôi chân đàn hồi nhún nhún!", "Chiu, với tới liền á!", "Vèo một cái qua luôn!"],
            [DialogueCue.TerrainJumpDown] = ["Bên dưới cũng muốn ghé chơi!", "Hê, hứng cái mũ giùm tui nha!", "Nhảy tưng tưng xuống nè!", "Chiu, chỗ đó vui lắm á!"],
            [DialogueCue.EdgeSlide] = ["Trượt cái vèo, trơn ghê!", "Tay bám cho chắc coi!", "Giày cọ cọ nhột quá trời.", "Trượt thêm một đoạn nữa đi!"],
            [DialogueCue.WindowMaximized] = ["Oa, đè bẹp tui gòi!", "Cửa sổ phình to nhanh dữ dội!", "Hú hồn bay cả mũ!", "Sao tự nhiên tui bị bay lên dợ!"],
            [DialogueCue.Home] = ["Tổ ấm êm ái quá chừng!", "Hê, vẫn là chỗ này tuyệt nhất!", "Về ngắm bạn nè!", "Mũ ơi cũng nghỉ ngơi xíu đi."],
            [DialogueCue.VoiceEnabled] = ["Chiu, tui ở đây nè!", "Hê, nhìn tui coi!", "Hé lô người bạn nhỏ!", "Nhớ tui hông dợ ta?"],
            [DialogueCue.VoiceDisabled] = ["Suỵt, bí mật nha.", "Đi rón rén từng bước một.", "Chiu... nói nhỏ thui.", "Lén lút đồng hành cùng bạn nè."],
        };

    private static readonly IReadOnlyList<string> PlayLines = ["嘿，玩什么呀？", "陪我蹦一下！", "我有小主意！", "帽子藏好啦。"];
    private static readonly IReadOnlyList<string> VietnamesePlayLines = ["Hê, chơi trò gì ta?", "Nhún nhảy với tui một cái nào!", "Tui có ý tưởng này hay lắm!", "Giấu cái mũ đi gòi nha."];

    public static IReadOnlyList<string> GetLines(DialogueCue cue)
    {
        if (LocalizationManager.IsVietnamese)
        {
            return VietnameseLines.TryGetValue(cue, out var viLines) ? viLines : VietnamesePlayLines;
        }

        return Lines.TryGetValue(cue, out var lines) ? lines : PlayLines;
    }
}
