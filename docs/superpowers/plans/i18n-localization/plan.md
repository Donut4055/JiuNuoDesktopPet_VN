# Kế Hoạch Triển Khai Hệ Thống i18n & Việt Hóa Cho JiuNuoDesktopPet

## Danh sách Task (Tasks Breakdown)

- [ ] **Task 1: Tạo Core Localization Infrastructure**
  - Tạo `src/SoftMochiPet/Core/LocalizationManager.cs` quản lý ngôn ngữ hiện hành, các từ điển chuỗi UI, sự kiện `LanguageChanged`.
  - Cập nhật `src/SoftMochiPet/Models/PetSettings.cs` bổ sung trường `Language` (mặc định `"vi-VN"`) và logic di trú/lưu trữ.

- [ ] **Task 2: Việt hóa Lời thoại Nhân vật (Dialogues) theo Ngữ cảnh**
  - Cập nhật `src/SoftMochiPet/Core/PetDialogue.cs` để hỗ trợ đa ngôn ngữ cho Nhu Nhu.
  - Cập nhật `src/SoftMochiPet/Core/FeibiJiubiDialogue.cs` để hỗ trợ đa ngôn ngữ cho Phi Bỉ.
  - Cập nhật `src/SoftMochiPet/Core/MischiefDialogue.cs` cho các trò nghịch cửa sổ.
  - Cập nhật `src/SoftMochiPet/Core/PairDialogueCatalog.cs` cho tương tác đôi.

- [ ] **Task 3: Bản địa hóa Menu Khay Hệ Thống & Giao diện (Tray UI)**
  - Cập nhật `src/SoftMochiPet/Services/TrayIconService.cs`:
    - Dịch các mục menu hiện có sang tiếng Việt theo ngữ cảnh.
    - Thêm menu chuyển đổi ngôn ngữ: `Ngôn ngữ (Language) -> Tiếng Việt / 中文`.
    - Lắng nghe sự kiện `LanguageChanged` để cập nhật tiêu đề menu động.

- [ ] **Task 4: Bản địa hóa Bảng Điều khiển Hành vi & Test Target**
  - Cập nhật `src/SoftMochiPet/Core/BehaviorControlCatalog.cs` hỗ trợ hiển thị tên danh mục và tên hành động bằng tiếng Việt.
  - Cập nhật `src/SoftMochiPet/MainWindow.BehaviorControl.cs` và `MainWindow.MischiefStatus.cs`.

- [ ] **Task 5: Kiểm thử Toàn diện & Xác nhận Không Hỏng Test Logic**
  - Chạy `dotnet run --project tests/SoftMochiPet.LogicTests/SoftMochiPet.LogicTests.csproj` đảm bảo toàn bộ 217 bài test pass.
  - Ghi nhật ký tiến độ vào `.superpowers/sdd/progress.md`.
