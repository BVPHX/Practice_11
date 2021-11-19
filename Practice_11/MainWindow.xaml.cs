using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Practice_11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ResultOutput_Click(object sender, RoutedEventArgs e)
        {
            Regex regex = new Regex(@"ab{0,3}a");
            string rawText = "aa aba abba abbba abca abea";
            MatchCollection match = regex.Matches(rawText);
            object[] mas = new object[match.Count];
            match.CopyTo(mas, 0);
            resultBox.ItemsSource = mas;
        }
    }
}
