namespace SoftMochiPet.Core;

public enum DialogueCue
{
    Startup,
    Buffet,
    MealSpotted,
    MealQueueContinues,
    IconsHidden,
    ManualIconLick,
    CuriousIconLick,
    PlatformLaunch,
    HardLanding,
    VeryHungry,
    ABitHungry,
    ConfidentClimb,
    CarefulClimb,
    ClimbSlip,
    ClimbSuccess,
    HungryRoll,
    Suction,
    Exploration,
    Sleep,
    WakeForFood,
    WakeNormally,
    ComfortablyFull,
    IconTaste,
    FeastContinues,
    AnotherBite,
    Stuffed,
    TastedItem,
    PickedUp,
    Released,
    DragThrow,
    TerrainHop,
    TerrainJumpDown,
    EdgeSlide,
    WindowMaximized,
    HungryRequestQueued,
    Home,
    DeleteReactionEnabled,
    DeleteReactionDisabled,
    VoiceEnabled,
    VoiceDisabled,
}

/// <summary>
/// Short reactions selected from each character's own dialogue catalog.
/// </summary>
public static class PetDialogueCatalog
{
    private static readonly IReadOnlyDictionary<DialogueCue, IReadOnlyList<string>> Lines =
        new Dictionary<DialogueCue, IReadOnlyList<string>>
        {
            [DialogueCue.Startup] =
            [
                "早呀。",
                "我醒啦。",
                "今天吃什么？",
                "先发会儿呆。",
            ],
            [DialogueCue.Buffet] =
            [
                "好多！",
                "都是我的？",
                "吃不完啦。",
                "嘿嘿，开饭。",
            ],
            [DialogueCue.MealSpotted] =
            [
                "有吃的。",
                "香香的。",
                "我来啦。",
                "那个能吃吗？",
            ],
            [DialogueCue.MealQueueContinues] =
            [
                "还有呀。",
                "下一个。",
                "都要吃。",
                "别跑。",
            ],
            [DialogueCue.IconsHidden] =
            [
                "没有图标……",
                "藏哪啦？",
                "舔不到。",
                "空空的。",
            ],
            [DialogueCue.ManualIconLick] =
            [
                "好饿……",
                "先舔一口。",
                "就一小口。",
                "这个能吃吗？",
            ],
            [DialogueCue.CuriousIconLick] =
            [
                "什么味呀？",
                "舔一下。",
                "看着好香。",
                "就试试。",
            ],
            [DialogueCue.PlatformLaunch] =
            [
                "飞起来啦！",
                "呜哇！",
                "脚呢？",
                "好高！",
            ],
            [DialogueCue.HardLanding] =
            [
                "噗叽。",
                "扁掉啦。",
                "呼，到了。",
                "我又圆啦。",
            ],
            [DialogueCue.VeryHungry] =
            [
                "好饿……",
                "饿扁了。",
                "想吃东西。",
                "肚子空啦。",
            ],
            [DialogueCue.ABitHungry] =
            [
                "有点饿。",
                "想吃一口。",
                "有吃的吗？",
                "嘴馋了。",
            ],
            [DialogueCue.ConfidentClimb] =
            [
                "我能上去。",
                "看我的。",
                "嘿咻。",
                "上面有吃的？",
            ],
            [DialogueCue.CarefulClimb] =
            [
                "好高……",
                "慢一点。",
                "别掉呀。",
                "我试试。",
            ],
            [DialogueCue.ClimbSlip] =
            [
                "滑下来啦……",
                "没抓住。",
                "呜……差一点。",
                "再来。",
            ],
            [DialogueCue.ClimbSuccess] =
            [
                "上来啦。",
                "嘿嘿。",
                "我厉害吧。",
                "这里好高。",
            ],
            [DialogueCue.HungryRoll] =
            [
                "好饿好饿。",
                "给我吃的。",
                "我滚一下。",
                "饿扁啦。",
            ],
            [DialogueCue.Suction] =
            [
                "吸过来！",
                "啊——",
                "到嘴里来。",
                "我要吃啦。",
            ],
            [DialogueCue.Exploration] =
            [
                "这里是哪？",
                "没来过。",
                "看看这边。",
                "好奇。",
            ],
            [DialogueCue.Sleep] =
            [
                "我要睡觉啦。",
                "困困。",
                "先睡一会儿。",
                "晚安。",
            ],
            [DialogueCue.WakeForFood] =
            [
                "有吃的？",
                "我醒啦！",
                "香香的！",
                "开饭吗？",
            ],
            [DialogueCue.WakeNormally] =
            [
                "醒啦。",
                "还想睡……",
                "睡饱啦。",
                "再躺一下？",
            ],
            [DialogueCue.ComfortablyFull] =
            [
                "吃饱啦。",
                "肚子圆圆。",
                "好撑。",
                "不动了。",
            ],
            [DialogueCue.IconTaste] =
            [
                "不好吃。",
                "只有图标味。",
                "空的。",
                "再舔一下？",
            ],
            [DialogueCue.FeastContinues] =
            [
                "还能吃！",
                "再来一个。",
                "都给我。",
                "还没饱。",
            ],
            [DialogueCue.AnotherBite] =
            [
                "下一个。",
                "还有吗？",
                "继续吃。",
                "我还要。",
            ],
            [DialogueCue.Stuffed] =
            [
                "吃撑啦。",
                "肚子好圆。",
                "真的饱了。",
                "动不了啦。",
            ],
            [DialogueCue.TastedItem] =
            [
                "{item} 好吃。",
                "{item} 香香的。",
                "喜欢 {item}。",
                "这个叫 {item}？",
            ],
            [DialogueCue.PickedUp] =
            [
                "被抓住啦。",
                "轻一点。",
                "要拉长啦。",
                "呜……",
            ],
            [DialogueCue.Released] =
            [
                "放开啦。",
                "我掉啦。",
                "脚在哪里？",
                "转圈圈……",
            ],
            [DialogueCue.DragThrow] =
            [
                "飞走啦！",
                "呜哇——",
                "停不下来！",
                "我被甩啦！",
            ],
            [DialogueCue.TerrainHop] =
            [
                "跳一下。",
                "嘿咻！",
                "我会飞。",
                "蹦起来啦。",
            ],
            [DialogueCue.TerrainJumpDown] =
            [
                "我跳啦。",
                "下面接住我。",
                "走你！",
                "飞下去。",
            ],
            [DialogueCue.EdgeSlide] =
            [
                "滑下去啦。",
                "慢慢滑。",
                "手要抓住。",
                "这是滑梯？",
            ],
            [DialogueCue.WindowMaximized] =
            [
                "变大啦！",
                "被弹飞啦！",
                "呜哇，好大！",
                "窗口长大了！",
            ],
            [DialogueCue.HungryRequestQueued] =
            [
                "好饿……等一下。",
                "站稳就吃。",
                "马上去舔。",
                "肚子等不及啦。",
            ],
            [DialogueCue.Home] =
            [
                "到家啦。",
                "回窝。",
                "这里好。",
                "不走了。",
            ],
            [DialogueCue.DeleteReactionEnabled] =
            [
                "删掉的给我吃。",
                "我会接住。",
                "记得叫我。",
                "有吃的啦。",
            ],
            [DialogueCue.DeleteReactionDisabled] =
            [
                "今天不吃。",
                "先忍一下。",
                "不追啦。",
                "图标安全啦。",
            ],
            [DialogueCue.VoiceEnabled] =
            [
                "我有声音啦。",
                "听得到吗？",
                "嘿嘿，是我。",
                "我说话啦。",
            ],
            [DialogueCue.VoiceDisabled] =
            [
                "我安静啦。",
                "嘘。",
                "不说话啦。",
                "小声一点。",
            ],
        };

    private static readonly IReadOnlyDictionary<DialogueCue, IReadOnlyList<string>> VietnameseLines =
        new Dictionary<DialogueCue, IReadOnlyList<string>>
        {
            [DialogueCue.Startup] =
            [
                "Oa, chào buổi sáng nha~",
                "Mình thức dậy rồi nè!",
                "Hôm nay ăn món gì ta?",
                "Ngẩn ngơ một tẹo đã nè...",
            ],
            [DialogueCue.Buffet] =
            [
                "Nhiều đồ ăn quá chừng!",
                "Tất cả là của mình hả?",
                "Ăn không xuể luôn á!",
                "Hehe, chén thôi nào~",
            ],
            [DialogueCue.MealSpotted] =
            [
                "A, có đồ ăn nè!",
                "Mùi thơm nức mũi luôn~",
                "Mình tới đây!",
                "Cái đó ăn được hông ta?",
            ],
            [DialogueCue.MealQueueContinues] =
            [
                "Vẫn còn nữa nè~",
                "Tới món tiếp theo!",
                "Ăn sạch sành sanh luôn!",
                "Đừng có chạy nha~",
            ],
            [DialogueCue.IconsHidden] =
            [
                "Ủa, không thấy icon đâu...",
                "Trốn ở đâu mất tiêu rồi?",
                "Liếm không tới...",
                "Màn hình trống trơn à...",
            ],
            [DialogueCue.ManualIconLick] =
            [
                "Đói bụng quá đi...",
                "Liếm thử một miếng trước nè.",
                "Chỉ một miếng nhỏ xíu thôi nha.",
                "Cái này ăn được hông ta?",
            ],
            [DialogueCue.CuriousIconLick] =
            [
                "Có vị gì vậy ta?",
                "Liếm một cái thử coi.",
                "Trông có vẻ ngon ghê á.",
                "Thử một tẹo thôi nha.",
            ],
            [DialogueCue.PlatformLaunch] =
            [
                "Bay lên trời luôn rồi!",
                "Oa oa oa!",
                "Đôi chân của mình đâu rồi?",
                "Cao quá trời ơi!",
            ],
            [DialogueCue.HardLanding] =
            [
                "Bẹp dí một cái!",
                "Biến thành mochi dẹt rồi...",
                "Phù, đáp đất an toàn rồi.",
                "Mình lại tròn xoe rồi nè~",
            ],
            [DialogueCue.VeryHungry] =
            [
                "Đói meo râu rồi...",
                "Bụng xẹp lép như bánh tráng...",
                "Muốn ăn cái gì đó quá...",
                "Bụng kêu réo ùng ục rồi nè...",
            ],
            [DialogueCue.ABitHungry] =
            [
                "Hơi đói bụng một xíu...",
                "Muốn nhấm nháp một miếng.",
                "Có gì ăn được hông ta?",
                "Thèm ăn vặt quá đi...",
            ],
            [DialogueCue.ConfidentClimb] =
            [
                "Mình leo lên được mà!",
                "Xem chiêu của mình nè!",
                "Hây dô!",
                "Trên đó có gì ngon hông ta?",
            ],
            [DialogueCue.CarefulClimb] =
            [
                "Cao quá đi...",
                "Chậm thôi nào...",
                "Đừng để ngã nha.",
                "Cố lên, thử xem sao.",
            ],
            [DialogueCue.ClimbSlip] =
            [
                "Trượt chân tuột xuống rồi...",
                "Không bám chặt được...",
                "Hu hu... suýt chút nữa là được rồi.",
                "Leo lại lần nữa nè!",
            ],
            [DialogueCue.ClimbSuccess] =
            [
                "Lên tới nơi rồi nè!",
                "Hehe, giỏi ghê chưa!",
                "Mình siêu thật đấy!",
                "Ở đây cao thoáng ghê!",
            ],
            [DialogueCue.HungryRoll] =
            [
                "Đói quá đói quá đi mất!",
                "Cho mình xin miếng đồ ăn đi mà~",
                "Lăn qua lăn lại ăn vạ nè!",
                "Bụng lép kẹp luôn rồi á...",
            ],
            [DialogueCue.Suction] =
            [
                "Hút lại đây mau!",
                "Aaaaaa——",
                "Ngoan ngoãn bay vào miệng nè.",
                "Mình chuẩn bị chén đây!",
            ],
            [DialogueCue.Exploration] =
            [
                "Chỗ này là ở đâu ta?",
                "Chưa từng tới đây bao giờ luôn.",
                "Để ngó nghiêng bên này thử xem.",
                "Tò mò ghê á!",
            ],
            [DialogueCue.Sleep] =
            [
                "Buồn ngủ dí cả mắt rồi...",
                "Khò khò...",
                "Ngủ một giấc đã nha...",
                "Chúc ngủ ngon nè~",
            ],
            [DialogueCue.WakeForFood] =
            [
                "Ủa, có đồ ăn hả?",
                "Mình tỉnh dậy liền rồi nè!",
                "Thơm quá đi mất!",
                "Dọn tiệc chưa vậy ta?",
            ],
            [DialogueCue.WakeNormally] =
            [
                "Dậy rồi nè~",
                "Vẫn còn muốn ngủ nướng...",
                "Ngủ đẫy giấc sướng quá!",
                "Nằm rốn thêm một xíu nữa được hông?",
            ],
            [DialogueCue.ComfortablyFull] =
            [
                "No nê thỏa thích rồi~",
                "Bụng căng tròn như quả bóng!",
                "No căng rốn luôn rồi.",
                "Lười cử động quá đi...",
            ],
            [DialogueCue.IconTaste] =
            [
                "Không ngon lắm...",
                "Chỉ có toàn vị icon thôi à.",
                "Vị rỗng tuếch...",
                "Hay là liếm thêm phát nữa ta?",
            ],
            [DialogueCue.FeastContinues] =
            [
                "Vẫn còn sức ăn tiếp nè!",
                "Cho thêm một phần nữa đi!",
                "Đưa hết cho mình nào!",
                "Vẫn chưa no đâu á!",
            ],
            [DialogueCue.AnotherBite] =
            [
                "Tiếp theo là em nào!",
                "Còn món nào nữa hông ta?",
                "Tiếp tục công cuộc ăn uống!",
                "Mình vẫn muốn ăn thêm nữa!",
            ],
            [DialogueCue.Stuffed] =
            [
                "No nứt bụng rồi á!",
                "Bụng tròn xoe lăn lông lốc!",
                "No thật sự luôn rồi á.",
                "Hết nhúc nhích nổi rồi...",
            ],
            [DialogueCue.TastedItem] =
            [
                "{item} ngon tuyệt cú mèo luôn!",
                "{item} thơm lừng nức mũi!",
                "Thích {item} nhất trần đời luôn!",
                "Cái này gọi là {item} hả ta?",
            ],
            [DialogueCue.PickedUp] =
            [
                "Á, bị túm lại rồi!",
                "Nhẹ tay một chút thôi mà!",
                "Bị kéo dài người ra rồi nè!",
                "Hu hu...",
            ],
            [DialogueCue.Released] =
            [
                "Được thả ra rồi nè~",
                "Rơi tự do rồi!",
                "Chân ơi đang ở đâu đấy?",
                "Quay cuồng hoa cả mắt...",
            ],
            [DialogueCue.DragThrow] =
            [
                "Bay vèo đi rồi!",
                "Oa oa oa——",
                "Không phanh lại được!",
                "Mình bị ném bay đi rồi!",
            ],
            [DialogueCue.TerrainHop] =
            [
                "Nhảy một cái nào!",
                "Hây dô!",
                "Mình biết bay lượn nè!",
                "Bật tưng tưng lên rồi!",
            ],
            [DialogueCue.TerrainJumpDown] =
            [
                "Mình nhảy xuống đây!",
                "Ở dưới đỡ mình nha!",
                "Đi thôi nào!",
                "Lượn xuống dưới nè!",
            ],
            [DialogueCue.EdgeSlide] =
            [
                "Trượt xuống dốc rồi!",
                "Trượt từ từ thôi nha.",
                "Tay phải bám thật chặt!",
                "Đây là cầu trượt hả ta?",
            ],
            [DialogueCue.WindowMaximized] =
            [
                "Phình to đùng ra rồi!",
                "Bị bắn văng ra ngoài luôn!",
                "Oa oa, to quá xá!",
                "Cửa sổ bỗng nhiên lớn tướng!",
            ],
            [DialogueCue.HungryRequestQueued] =
            [
                "Đói bụng quá... ráng đợi một xíu.",
                "Đứng vững lại là ăn liền!",
                "Chạy đi liếm ngay và luôn!",
                "Cái bụng không đợi thêm được nữa đâu!",
            ],
            [DialogueCue.Home] =
            [
                "Về tới nhà rồi nè!",
                "Chui về tổ ấm êm.",
                "Ở đây là thoải mái nhất!",
                "Không đi lang thang nữa đâu.",
            ],
            [DialogueCue.DeleteReactionEnabled] =
            [
                "File nào bị xóa cứ cho mình ăn hết nha!",
                "Mình sẽ bắt lấy ăn ngon lành!",
                "Nhớ gọi mình đấy nhé!",
                "Lại sắp có đồ ăn rồi!",
            ],
            [DialogueCue.DeleteReactionDisabled] =
            [
                "Hôm nay nhịn ăn nè.",
                "Ráng kiêng một xíu vậy.",
                "Không đuổi theo đồ ăn nữa đâu.",
                "Icon an toàn rồi nhé!",
            ],
            [DialogueCue.VoiceEnabled] =
            [
                "Mình cất tiếng nói được rồi nè!",
                "Bạn có nghe rõ hông dợ?",
                "Hehe, chính là mình nè!",
                "Mình đang trò chuyện với bạn đó!",
            ],
            [DialogueCue.VoiceDisabled] =
            [
                "Mình giữ trật tự nè.",
                "Suỵt khẽ thôi nha.",
                "Hông nói chuyện nữa đâu.",
                "Nói nhỏ nhẹ thôi nè.",
            ],
        };

    public static IReadOnlyList<string> GetLines(DialogueCue cue, PetCharacterProfile? profile = null)
    {
        if (profile?.Id == PetCharacterProfile.FeibiJiubi.Id)
        {
            return FeibiJiubiDialogue.GetLines(cue);
        }

        if (LocalizationManager.IsVietnamese && VietnameseLines.TryGetValue(cue, out var viLines))
        {
            return viLines;
        }

        return Lines[cue];
    }
}

public sealed class PetDialogueSelector
{
    private readonly Random _random;
    private readonly PetCharacterProfile _profile;
    private readonly Dictionary<DialogueCue, int> _lastLineByCue = [];

    public PetDialogueSelector(Random? random = null, PetCharacterProfile? profile = null)
    {
        _random = random ?? Random.Shared;
        _profile = profile ?? PetCharacterProfile.Nuonuo;
    }

    public string Choose(DialogueCue cue, string? itemName = null)
    {
        var lines = PetDialogueCatalog.GetLines(cue, _profile);
        var index = _random.Next(lines.Count);
        if (lines.Count > 1 && _lastLineByCue.TryGetValue(cue, out var previous) && index == previous)
        {
            index = (index + 1) % lines.Count;
        }

        _lastLineByCue[cue] = index;
        return lines[index].Replace("{item}", itemName ?? "这份文件", StringComparison.Ordinal);
    }
}
