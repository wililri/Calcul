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

namespace Calcul
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void Button_Click(object sender,RoutedEventArgs e)
        {
            InitializeComponent();
            string operation=((Button)sender).Content.ToString();
            double oper1 = Convert.ToDouble(Output_panel.Text);
            double oper2 = Convert.ToDouble(panel.Text);
            double res = 0;
            switch (operation)
            {
                case "+":
                    res=oper1+ oper2;
                    break;
                case "-":
                    res=oper2 - oper1;
                    break;
                    case "*":  
                    res=oper1 * oper2;
                    break;
                    case "/":
                    res=oper1 / oper2;
                    break;
            }
            panela.Text=res.ToString();
        }

        private void Output_panel_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
