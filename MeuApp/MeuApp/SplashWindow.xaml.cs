using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace MeuApp
{
    public partial class SplashWindow : Window
    {
        public SplashWindow()
        {
            InitializeComponent();

            Loaded += SplashWindow_Loaded;
        }

        private async void SplashWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // Animação da logo
            DoubleAnimation animacao = new DoubleAnimation
            {
                From = 0,
                To = 360,
                Duration = TimeSpan.FromSeconds(1),
                RepeatBehavior = RepeatBehavior.Forever
            };

            LogoRotation.BeginAnimation(
                RotateTransform.AngleProperty,
                animacao
            );

            // Aguarda 3 segundos
            await Task.Delay(3000);

            // Abre o aplicativo principal
            MainWindow main = new MainWindow();
            main.Show();

            // Fecha o Splash
            Close();
        }
    }
}