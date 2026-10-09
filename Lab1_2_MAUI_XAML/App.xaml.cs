namespace Lab1_2_MAUI_XAML
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            // Светлая тема, чтобы чёрный текст из заданий был виден на любом ПК
            UserAppTheme = AppTheme.Light;
        }

        protected override Window CreateWindow(IActivationState activationState)
        {
            return new Window(new AppShell());
        }
    }
}
