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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
        }
        private void GetToEditingNum(object sender, RoutedEventArgs e)
        {
            ExpenseEdit Editor = new ExpenseEdit(this.expenseListBox.SelectedItem);
            this.NavigationService.Navigate(Editor);
        }
        private void GetToEditingDate(object sender, RoutedEventArgs e)
        {
            DateEdit Editor = new DateEdit();
            this.NavigationService.Navigate(Editor);
        }
        private void ViewExpenses(object sender, RoutedEventArgs e)
        {
            ViewExpenses Viewer = new ViewExpenses();
            this.NavigationService.Navigate(Viewer);
        }
    }
}
