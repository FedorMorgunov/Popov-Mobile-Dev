namespace LabShared
{
    /// <summary>
    /// Данные команды. Файл подключён ссылкой (Link) во все 7 проектов,
    /// поэтому правка здесь меняет баннер сразу во всех приложениях.
    /// В XAML значения выводятся через расширение разметки x:Static.
    /// </summary>
    public static class TeamInfo
    {
        // TODO: впишите номер группы и состав команды (до 4 человек)
        public static string Group => "Группа: XXXX-00-00";

        public static string Members => string.Join("\n", new[]
        {
            "Моргунов Ф.",
            "Фамилия И.О.",
            "Фамилия И.О.",
            "Фамилия И.О.",
        });
    }
}
