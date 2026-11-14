using System;
using System.Windows;
using System.Windows.Media.Imaging;
using SizovVoins9.Classes;

namespace SizovVoins9
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        LightKnight lightKnight = new LightKnight(100);
        HeavyKnight heavyKnight = new HeavyKnight(100);
        private void DamageClick(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            if (rnd.Next(2) == 0)
            {
                lightKnight.getAttack(12);
                if (lightKnight.HealthPoint <= 0) lightKnight.HealthPoint = 0;

                MyImage.Source = new BitmapImage(new Uri(@"/Images/light.jpg", UriKind.Relative));
                voin.Content = "Воин: лёгкий";
                HP.Content = $"HP: {lightKnight.HealthPoint}";
                
                if (lightKnight.HealthPoint == 0) lightKnight.HealthPoint = 100;
            }
            else
            {
                heavyKnight.getAttack(12);
                if (heavyKnight.HealthPoint <= 0) heavyKnight.HealthPoint = 0;

                MyImage.Source = new BitmapImage(new Uri(@"/Images/heavy.jfif", UriKind.Relative));
                voin.Content = "Воин: тяжелый";
                HP.Content = $"HP: {heavyKnight.HealthPoint}";

                if (heavyKnight.HealthPoint == 0) heavyKnight.HealthPoint = 100;


            }

        }
        public void reversePhoto()
        {
            
        }
    }
}
