using System.Diagnostics;
using System.Windows;
using System.Windows.Input;
using System.Windows.Shapes;

namespace OnStoreWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PreviewKeyDown += HandleEsc;
        }

        private void HandleEsc(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.Escape) return;
            Close();
        }

        private void Close_Click(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void ControlBox_Click(object sender, MouseButtonEventArgs e)
        {
            var elp = sender as Ellipse;

            switch (elp.Name)
            {
                case "close":
                    Close();
                    break;
                case "max":
                    WindowState = WindowState == WindowState.Normal ? WindowState.Maximized : WindowState.Normal;
                    break;
                default:
                    WindowState = WindowState.Minimized;
                    break;
            }
        }
    }
}
