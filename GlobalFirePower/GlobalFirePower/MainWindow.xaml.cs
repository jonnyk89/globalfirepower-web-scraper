using System.Windows;
using System.Windows.Navigation;
using GlobalFirePower.Views;

namespace GlobalFirePower
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            OpenMenuPage();
        }

        private void OpenMenuPage()
        {
            Menu pg = new Menu();
            this.Content = pg;
        }
    }
}