# Thiết Kế Chi Tiết Hệ Thống Bản Địa Hóa (i18n) & Việt Hóa Theo Ngữ Cảnh Cho JiuNuoDesktopPet

## 1. Mục tiêu & Phạm vi
- Hỗ trợ chuyển đổi ngôn ngữ đa quốc gia (i18n), mặc định kích hoạt ngôn ngữ **Tiếng Việt (`vi-VN`)** và bảo lưu tùy chọn **Tiếng Trung (`zh-CN`)**.
- Việt hóa toàn bộ giao diện, menu khay hệ thống, bảng điều khiển hành vi, và lời thoại bong bóng chat của 2 nhân vật Nhu Nhu (糯糯) và Phi Bỉ Cửu Bỉ (菲比啾比).
- Dịch thoát nghĩa, tự nhiên theo tính cách của từng nhân vật:
  - **Nhu Nhu**: Bé cưng háu ăn, ngọt ngào, ngây thơ, xưng hô nũng nịu.
  - **Phi Bỉ**: Tinh nghịch, hiếu động, ranh mãnh, thích phá phách trêu chọc.
  - **Tương tác đôi**: Lời qua tiếng lại dí dỏm giữa hai bé.
- Đảm bảo 100% tương thích ngược, không làm lỗi bất kỳ logic test nào trong bộ kiểm thử (217 logic tests).

## 2. Kiến trúc Kỹ thuật

```
                             [PetSettings.Language]
                                      │
                                      ▼
                        ┌───────────────────────────┐
                        │    LocalizationManager    │
                        │ (CurrentLanguage, Events) │
                        └─────────────┬─────────────┘
                                      │
         ┌────────────────────────────┼───────────────────────────┐
         ▼                            ▼                           ▼
┌──────────────────┐        ┌───────────────────┐       ┌──────────────────┐
│   Strings / UI   │        │ PetDialogueCatalog│       │ BehaviorControl  │
│ - Menu khay      │        │ - Nhu Nhu (vi/zh) │       │ - Di chuyển      │
│ - Tooltip        │        │ - Phi Bỉ (vi/zh)  │       │ - Tương tác      │
│ - Cửa sổ phụ     │        │ - Tương tác đôi   │       │ - Phá phách...   │
└──────────────────┘        └───────────────────┘       └──────────────────┘
```

### 2.1. Thành phần Cốt lõi
1. `LocalizationManager`:
   - Quản lý trạng thái ngôn ngữ hiện hành: `PetLanguage.Vietnamese ("vi-VN")`, `PetLanguage.Chinese ("zh-CN")`.
   - Cung cấp hàm `T(key, ...args)` hoặc lấy chuỗi theo danh mục.
   - Cung cấp sự kiện `LanguageChanged` khi người dùng chuyển ngôn ngữ trên khay hệ thống.
2. `PetSettings.Language`:
   - Thuộc tính lưu trữ trong `settings.json`, tự động khôi phục khi mở lại app.
   - Mặc định là `"vi-VN"`.
3. `PetDialogueCatalog` & `FeibiJiubiDialogue`:
   - Bổ sung bộ dữ liệu từ điển tiếng Việt song song với tiếng Trung gốc.
   - Khi `Language == "vi-VN"`, trả về các câu thoại tiếng Việt biểu cảm cao.
   - Khi `Language == "zh-CN"` (hoặc khi chạy test cô lập không set ngôn ngữ), trả về nguyên vẹn câu thoại tiếng Trung gốc để đảm bảo tương thích 100% với các test case xác thực độ dài và nội dung ký tự tiếng Trung.
4. `TrayIconService`:
   - Thêm menu lựa chọn ngôn ngữ: `Ngôn ngữ / 语言` -> `Tiếng Việt` / `中文`.
   - Cập nhật text của tất cả MenuItem khi đổi ngôn ngữ mà không cần khởi động lại ứng dụng.
5. `BehaviorControlCatalog`:
   - Bản địa hóa tên các danh mục (Di chuyển, Tương tác, Sinh hoạt, Nghịch ngợm, Cửa sổ) và các hành động tương ứng.

## 3. Bản đồ Dịch thuật Theo Ngữ Cảnh (Contextual Translation Mapping)

### 3.1. Menu Khay Hệ Thống (Tray Menu)
- `禁音` -> `Tắt tiếng`
- `随系统启动` -> `Khởi động cùng Windows`
- `禁食模式` -> `Chế độ nhịn ăn (không nhặt icon)`
- `无限模式` -> `Chế độ vô hạn năng lượng`
- `双宠共存` -> `Cho cả hai bé cùng xuất hiện`
- `头顶气泡` -> `Hiển thị bong bóng thoại`
- `安静模式` -> `Chế độ yên tĩnh (chỉ đứng yên / ngủ)`
- `允许捣蛋` -> `Cho phép Phi Bỉ nghịch ngợm`
- `捣蛋状态` -> `Trạng thái nghịch ngợm`
- `立即捣蛋一次` -> `Nghịch ngợm ngay lập tức`
- `逗一下` -> `Chọc ghẹo một chút`
- `把窗口还回来` -> `Bắt Phi Bỉ trả lại cửa sổ`
- `角色选择` -> `Chọn nhân vật`
- `退出` -> `Thoát`

### 3.2. Lời thoại Nhu Nhu (糯糯)
- `早呀。` -> `Oa, chào buổi sáng nha~`
- `我醒啦。` -> `Mình thức dậy rồi nè!`
- `今天吃什么？` -> `Hôm nay ăn món gì ta?`
- `先发会儿呆。` -> `Ngẩn ngơ một tẹo đã nè...`
- `有吃的！` -> `Có đồ ăn mới rơi ra kìa!`
- `啊呜！` -> `Ngoạm một miếng bự!`
- `真香。` -> `Thơm nức mũi luôn~`
- `饱啦。` -> `No căng bụng rồi á~`
- `困了……` -> `Buồn ngủ dí cả mắt... zZz`

### 3.3. Lời thoại Phi Bỉ Cửu Bỉ (菲比啾比)
- `看招！` -> `Xem chiêu đây!`
- `接我一脚！` -> `Ăn một cú đá nè!`
- `窗口借我玩玩。` -> `Mượn cái cửa sổ chơi xíu nha!`
- `收进帽子里！` -> `Cất biến vào mũ thần kỳ!`
- `撕开啦！` -> `Xé làm đôi luôn nè!`
- `哎呀，没拿稳。` -> `Ái chà, trượt tay xíu thôi mà!`

## 4. Kế hoạch Kiểm thử & Xác minh
- Chạy toàn bộ 217 logic tests để đảm bảo không suy giảm chất lượng.
- Kiểm tra tính năng chuyển đổi ngôn ngữ runtime không crash.
- Kiểm tra lưu và đọc lại `settings.json`.
