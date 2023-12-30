using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _12Games
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WPF_Balloon_Popping_Game_Moo_ICT.MainWindow game = new WPF_Balloon_Popping_Game_Moo_ICT.MainWindow();
            game.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Flappy_Bird_WPF_MOO_ICT.MainWindow gome = new Flappy_Bird_WPF_MOO_ICT.MainWindow();
            gome.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Space_Invaders_Game_WPF_MOO_ICT.MainWindow geme = new Space_Invaders_Game_WPF_MOO_ICT.MainWindow();
            geme.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Space_battle_shooter_WPF_MOO_ICT.MainWindow help = new Space_battle_shooter_WPF_MOO_ICT.MainWindow();
            help.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            SnakeGame.MainWindow snake = new SnakeGame.MainWindow();
            snake.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            PAC_Man_Game_WPF_MOO_ICT.MainWindow fed = new PAC_Man_Game_WPF_MOO_ICT.MainWindow();
            fed.Show();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            TicTacToeWPF.MainWindow tick = new TicTacToeWPF.MainWindow();
            tick.Show();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Clicky_Game_WPF_MOO_ICT.MainWindow click = new Clicky_Game_WPF_MOO_ICT.MainWindow();
            click.Show();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            hangman.MainWindow wind = new hangman.MainWindow();
            wind.Show();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            PongProject.MainWindow pong = new PongProject.MainWindow();
            pong.Show();
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            KidsMathGame.MainWindow kids = new KidsMathGame.MainWindow();
            kids.Show();
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            WpfApp1.MainWindow one = new WpfApp1.MainWindow();
            one.Show();
        }
    }
}
