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
using System.Windows.Shapes;
using QuanLyGaraOto.ViewModel;

namespace QuanLyGaraOto
{
    /// <summary>
    /// Interaction logic for GoodBillWindow.xaml
    /// </summary>
    public partial class GoodBillWindow : Window
    {
        public GoodBillWindowViewModel goodBillWindowViewModel { get; set; }
        public GoodBillWindow()
        {
            InitializeComponent();
            this.DataContext = (goodBillWindowViewModel = new GoodBillWindowViewModel());
        }
    }
}
