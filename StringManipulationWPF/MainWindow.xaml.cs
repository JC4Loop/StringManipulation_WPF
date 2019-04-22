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

namespace StringManipulationWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            opArea.IsReadOnly = true;
            opArea.Text += "\n";
        }

        
        void appendOPArea(String s)
        {
           opArea.Text += s + "\n";
        }

        public String replaceInString(String s,char cOld, char cNew)
        {
            string newString = "";
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (c == cOld)
                {
                    newString += cNew;
                } else
                {
                    newString += s[i];
                }

            }
            return newString;
        }

        private void btn1_Click_1(object sender, RoutedEventArgs e)
        {
            string input = tbInputWord.Text;
            string inputc1 = tbInputToReplace.Text;
            string inputc2 = tbInputReplaceWith.Text;
            char c1, c2;
            if (inputc1 != "")
            {
                c1 = Convert.ToChar(inputc1);
            } else
            {
                c1 = ' ';
            }
            if (inputc2 != "")
            {
                c2 = Convert.ToChar(inputc2);
            } else
            {
                c2 = ' ';
            }
       
            string newS = replaceInString(input, c1, c2);
            appendOPArea(newS);
        }
    }
}
