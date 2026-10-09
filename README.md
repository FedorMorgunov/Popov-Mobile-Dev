# Лабораторная работа 1 — .NET MAUI, XAML: привязки и расширения разметки

Решение `Lab1_MAUI_XAML.sln` состоит из 7 проектов (Visual Studio 2022, .NET 9):

| Проект | Задача | Что показывает |
|---|---|---|
| `Lab1_1_MAUI_XAML` | 1 | Присоединённые свойства `AbsoluteLayout.LayoutBounds` / `LayoutFlags` (шахматная доска) |
| `Lab1_2_MAUI_XAML` | 2 | Часы: `ClockViewModel` + `INotifyPropertyChanged`, `{Binding DateTime, StringFormat}` |
| `Lab1_3_MAUI_XAML` | 3 | Присоединённые свойства `Grid.Row/Column/RowSpan/ColumnSpan` |
| `Lab1_4_MAUI_XAML` | 4 | Клавиатура: `KeyPadViewModel`, привязка команд `ICommand` |
| `Lab1_5_MAUI_XAML` | 5 | Список цветов: `ListView`, `{x:Static}`, `{StaticResource}`, конвертер `FloatToIntConverter` |
| `Lab1_6_MAUI_XAML` | 6 | `BindingContext="{x:Static sys:DateTime.Now}"` + `StringFormat` |
| `Lab1_7_MAUI_XAML` | 7 | `{x:Reference}`, режимы `TwoWay` / `OneWayToSource` (слайдеры Scale/Rotation) |

Вверху каждого приложения — синий баннер с номером задачи, группой и ФИО команды.
Данные выводятся через `{x:Static team:TeamInfo...}` из **одного** файла `Shared/TeamInfo.cs`
(подключён ссылкой во все 7 проектов).

## Как запустить из GitHub

Нужно: Visual Studio 2022 (17.12+) с нагрузкой **«Разработка мультиплатформенных приложений .NET MAUI»** и .NET 9 SDK.

1. Склонировать репозиторий в `C:\Users\<пользователь>\source\repos` (папка Repos по умолчанию):
   - VS → «Клонирование репозитория» → URL `https://github.com/FedorMorgunov/Popov-Mobile-Dev.git`,
     путь `C:\Users\<пользователь>\source\repos\Popov-Mobile-Dev` → «Клонировать»;
   - или в терминале:
     ```
     cd %USERPROFILE%\source\repos
     git clone https://github.com/FedorMorgunov/Popov-Mobile-Dev.git
     ```
2. Открыть `Lab1_MAUI_XAML.sln`.
3. **Один раз** открыть `Shared/TeamInfo.cs` и вписать номер группы и ФИО всех членов команды.
4. В «Обозревателе решений» ПКМ по нужному проекту (например `Lab1_1_MAUI_XAML`) →
   «Назначить запускаемым проектом».
5. На панели инструментов выбрать **Windows Machine**
   (если не видно — стрелка рядом с кнопкой запуска → «Платформа» → `net9.0-windows10.0.19041.0`).
6. «Сборка» → «Пересобрать решение», затем F5 («Отладка» → «Начать отладку»).
7. Повторить шаги 4–6 для остальных 6 проектов.

Для Android: в том же списке выбрать «Эмуляторы Android» → Pixel 7 – API 35.
