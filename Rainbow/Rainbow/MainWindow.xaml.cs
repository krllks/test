using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;



namespace Rainbow
{
    public partial class MainWindow : Window
    {
        private int S = 0;
        static readonly Random rnd = new Random();
        string[] array;

        Brush[] brushes = new Brush[]
        {
            new SolidColorBrush(Color.FromRgb(255, 68, 68)),
            new SolidColorBrush(Color.FromRgb(255, 170, 3)),
            new SolidColorBrush(Color.FromRgb(236, 255, 78)),
            new SolidColorBrush(Color.FromRgb(45, 255, 125)),
            new SolidColorBrush(Color.FromRgb(91, 195, 255)),
            new SolidColorBrush(Color.FromRgb(46, 135, 255)),
            new SolidColorBrush(Color.FromRgb(150, 45, 250)),
        };

        public MainWindow()
        {
            InitializeComponent();

            MessageBox.Show("О, привет!\r\nВыбери цвета радуги в правильном порядке.", "", MessageBoxButton.OK, MessageBoxImage.Information);
            Main();
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы действительно хотите выйти из приложения?",
                                                      "Подтверждение", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
                exit();
        }

        private void message()
        {
            if (S == 7)
            {
                MessageBox.Show("R A I N B O W");
                exit();
            }
        }

        private void exit()
        {
            MessageBox.Show("See you later nerds.", "", MessageBoxButton.OK);
            Application.Current.Shutdown();
        }

        private void main()
        {
            string chars = ""; 
            char[] a = { ',' };
            int[] perm = Enumerable.Range(0, 7).ToArray(); // 0 1 2 ... (n + 1)

            for (int i = 6; i >= 1; i--)
            {
                int j = rnd.Next(i + 1);
                // exchange perm[j] and perm[i]
                int temp = perm[j];
                perm[j] = perm[i];
                perm[i] = temp;
            }

            foreach (var item in perm)
            {
                chars += item.ToString() + ",";
            }
            array = chars.Split(a);

            //MessageBox.Show(chars);
        }

        private void Main()
        {
            main();

            btn1.Background = brushes[int.Parse(array[0])];
            btn2.Background = brushes[int.Parse(array[1])];
            btn3.Background = brushes[int.Parse(array[2])];
            btn4.Background = brushes[int.Parse(array[3])];
            btn5.Background = brushes[int.Parse(array[4])];
            btn6.Background = brushes[int.Parse(array[5])];
            btn7.Background = brushes[int.Parse(array[6])];
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            int seq = 0;
            for (int i = -1; i <= int.Parse(array[0]); i++)
                seq = i;

            if (S == seq)
            {
                S++;
            }
            else
            {
                MessageBox.Show("Неверная последовательность\r\nНачните сначала");
                S = 0;
            }

            message();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            int seq = 0;
            for (int i = -1; i <= int.Parse(array[1]); i++)
                seq = i;

            if (S == seq)
            {
                S++;
            }
            else
            {
                MessageBox.Show("Неверная последовательность\r\nНачните сначала");
                S = 0;
            }

            message();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            int seq = 0;
            for (int i = -1; i <= int.Parse(array[2]); i++)
                seq = i;

            if (S == seq)
            {
                S++;
            }
            else
            {
                MessageBox.Show("Неверная последовательность\r\nНачните сначала");
                S = 0;
            }

            message();
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            int seq = 0;
            for (int i = -1; i <= int.Parse(array[3]); i++)
                seq = i;

            if (S == seq)
            {
                S++;
            }
            else
            {
                MessageBox.Show("Неверная последовательность\r\nНачните сначала");
                S = 0;
            }

            message();
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            int seq = 0;
            for (int i = -1; i <= int.Parse(array[4]); i++)
                seq = i;

            if (S == seq)
            {
                S++;
            }
            else
            {
                MessageBox.Show("Неверная последовательность\r\nНачните сначала");
                S = 0;
            }

            message();
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            int seq = 0;
            for (int i = -1; i <= int.Parse(array[5]); i++)
                seq = i;

            if (S == seq)
            {
                S++;
            }
            else
            {
                MessageBox.Show("Неверная последовательность\r\nНачните сначала");
                S = 0;
            }

            message();
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            int seq = 0;
            for (int i = -1; i <= int.Parse(array[6]); i++)
                seq = i;

            if (S == seq)
            {
                S++;
            }
            else
            {
                MessageBox.Show("Неверная последовательность\r\nНачните сначала");
                S = 0;
            }

            message();
        }

        private void dark_Click(object sender, RoutedEventArgs e)
        {
            border.Background = new SolidColorBrush(Color.FromRgb(27, 25, 37));
            text.Foreground = Brushes.White;
            dark.Visibility = Visibility.Hidden;
            light.Visibility = Visibility.Visible;
        }

        private void light_Click(object sender, RoutedEventArgs e)
        {
            border.Background = Brushes.White;
            text.Foreground = Brushes.Black;
            light.Visibility = Visibility.Hidden;
            dark.Visibility = Visibility.Visible;
        }

        private void Exit_MouseEnter(object sender, MouseEventArgs e)
        {
            Exit.Background = new SolidColorBrush(Color.FromRgb(255, 85, 85));
        }
        private void Exit_MouseLeave(object sender, MouseEventArgs e)
        {
            Exit.Background = new SolidColorBrush(Color.FromArgb(0, 255, 71, 51));
        }

        private void Theme_MouseEnter(object sender, MouseEventArgs e)
        {
            light.Background = new SolidColorBrush(Color.FromArgb(255, 121, 113, 160));
            dark.Background  = new SolidColorBrush(Color.FromArgb(255, 250, 255, 186));
        }
        private void Theme_MouseLeave(object sender, MouseEventArgs e)
        {
            light.Background = new SolidColorBrush(Color.FromArgb(0, 121, 113, 160));
            dark.Background  = new SolidColorBrush(Color.FromArgb(0, 121, 113, 160));
        }
    }
}
