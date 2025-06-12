using DemExamen52Bratuxa.windows;
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

namespace DemExamen52Bratuxa
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

        private void PartnerButton_Click(object sender, RoutedEventArgs e)
        {
            PartnerWindow partnerWindow = new PartnerWindow();
            partnerWindow.Show();
            this.Close();
        }

        private void PartnerHistoryButton_Click(object sender, RoutedEventArgs e)
        {
            var partnerHistoryWindow = new PartnerHistoryWindow();
            partnerHistoryWindow.Show();
            this.Close();

        }
    }
}
