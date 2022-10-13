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

namespace OrderMenu
{
    /// <summary>
    /// Result.xaml 的互動邏輯
    /// </summary>
    public partial class Result : Window
    {
        
        public Result(String Item1, String Item2, String Item3, int Quality1, int Quality2, int Quality3, int TotalPrice1, int TotalPrice2, int TotalPrice3)
        {
            InitializeComponent();
            Result_lbl.Content = Item1 + Quality1.ToString()+TotalPrice1.ToString()+"\n"+Item2 + Quality2.ToString() + TotalPrice2.ToString() + "\n"+Item3 + Quality3.ToString() + TotalPrice3.ToString() + "\n";
        }
    }
    
}
