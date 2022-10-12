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

namespace OrderMenu
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Item1_Chk_Checked(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(sender);
        }

        private void SendOrder_Btn_Click(object sender, RoutedEventArgs e)
        {
            List<Menu> list = new List<Menu>() { };
            bool check1, check2, check3;
            check1 = (bool)Item1_Chk.IsChecked;
            check2 = (bool)Item2_Chk.IsChecked;
            check3 = (bool)Item3_Chk.IsChecked;
            if (check1 != true && check2 != true && check3 != true)
            {
                list.Add(new Menu { animals = "", content =""});
                lb.Content = "請勾選菜單";
            }
            else {
                lb.Content = "已選擇";
            }
        }
    }

    public class Menu { 
        public string animals { get; set; }
        public string content { get; set; }
    }

    public class Menu2
    {
        public string title { get; set; }
        public string content { get; set; }
    }
}
