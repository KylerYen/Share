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
            int Item1, Item2, Item3;
            int Price1, Price2, Price3;

            Item1 = int.Parse(Item1_txtbox.Text.ToString());
            Item2 = int.Parse(Item2_txtbox.Text.ToString());
            Item3 = int.Parse(Item3_txtbox.Text.ToString());

            check1 = (bool)Item1_Chk.IsChecked;
            check2 = (bool)Item2_Chk.IsChecked;
            check3 = (bool)Item3_Chk.IsChecked;

            Price1 = Item1 * 30;
            Price2 = Item2 * 35;
            Price3 = Item3 * 40;

            if (check1 != true && check2 != true && check3 != true)
            {
                //list.Add(new Menu { animals = "", content =""});
                lb.Content = "請勾選菜單";
            }
            else if(check1 == true && check2 == true && check3 == true)
            {
                list.Add(new Menu { Item = "魯肉飯", Quantity = Item1, Price = Price1 });
                list.Add(new Menu { Item = "肉圓", Quantity = Item2, Price = Price2 });
                list.Add(new Menu { Item = "麵線", Quantity = Item3, Price = Price3 });

                MessageBox.Show("總共點了:"+"\n"+list[0].Item+ list[0].Quantity+"碗"+ list[0].Price+"元"+"\n" + list[1].Item + list[1].Quantity + "個" + list[1].Price + "元" + "\n" + list[2].Item + list[2].Quantity + "碗" + list[2].Price + "元" + "\n");
            }
            else{
                //lb.Content = "已選擇";
                if (check1 == true) 
                {

                }
            }
        }
    }

    public class Menu
    {
        public String Item;//項目
        public int Quantity;//總數量
        public int Price;//總價
    }
    /*public class Menu { 
        public string animals { get; set; }
        public string content { get; set; }
    }

    public class Menu2
    {
        public string title { get; set; }
        public string content { get; set; }
    }*/
}
