using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            int porkrice=0, porkball=0, noodlesoup=0;
            int Item1, Item2, Item3;
            bool check1, check2, check3;
            try
            {
                //List<Menu> list = new List<Menu>() { };

                

                 Item1 = int.Parse(Item1_txtbox.Text.ToString());
                 Item2 = int.Parse(Item2_txtbox.Text.ToString());
                 Item3 = int.Parse(Item3_txtbox.Text.ToString());

                 check1 = (bool)Item1_Chk.IsChecked;
                 check2 = (bool)Item2_Chk.IsChecked;
                 check3 = (bool)Item3_Chk.IsChecked;

                if (check1 != true && check2 != true && check3 != true)
                {
                    MessageBox.Show("請選擇品項");
                }
                else
                {
                    if ((check1 == true) && (Item1 % 1 == 0))
                    {
                        porkrice = Item1 * 30;
                        //list.Add(new Menu { Item = "魯肉飯", Quality = Item1, TotalPrice = porkrice });
                    }
                    
                    if ((check2 == true) && (Item2 % 1 == 0))
                    {
                        porkball = Item2 * 35;
                        //list.Add(new Menu { Item = "肉圓", Quality = Item2, TotalPrice = porkball });
                    }
                    
                    if ((check3 == true) && (Item3 % 1 == 0))
                    {
                        noodlesoup = Item3 * 40;
                        //list.Add(new Menu { Item = "麵線", Quality = Item3, TotalPrice = noodlesoup });
                    }

                    //this.Close();
                    Result rwf = new Result("魯肉飯", "肉圓", "麵線", Item1, Item2, Item3, porkrice, porkball, noodlesoup);
                    rwf.Show();
                }
            }
            catch(Exception EX)
            {
                MessageBox.Show(EX.Message.ToString());
            }
            

            /*List<Menu> list = new List<Menu>() { };
            bool check1, check2, check3;
            int Item1, Item2, Item3;

            Item1 = int.Parse(Item1_txtbox.Text.ToString());
            Item2 = int.Parse(Item2_txtbox.Text.ToString());
            Item3 = int.Parse(Item3_txtbox.Text.ToString());

            check1 = (bool)Item1_Chk.IsChecked;
            check2 = (bool)Item2_Chk.IsChecked;
            check3 = (bool)Item3_Chk.IsChecked;

            list.Add(new Menu {Item= "魯肉飯", Price = 30, Quality= Item1});
            list.Add(new Menu {Item = "肉圓", Price = 35, Quality = Item2 });
            list.Add(new Menu {Item = "麵線", Price = 40, Quality = Item3 });*/
        }

       
    }
    /*public class Menu
    {
        public String Item;//項目
        public int Quality;//數量
        public int TotalPrice;//總價
    }*/

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
