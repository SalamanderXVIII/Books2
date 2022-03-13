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

namespace Books2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public enum Theme
    {
        Romance, Fantasy, Horror, Science
    }
    public partial class MainWindow : Window
    {
        Themes theme = new Themes();
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Horror_Checked(object sender, RoutedEventArgs e)
        {
            Catalog.Text = "Format: Author, book's number, theme." + '\n';
            for (int i = 0; i < 20; i++)
            {
                if (theme.Theme_str[i] == Convert.ToString (Theme.Horror))
                Catalog.Text += theme.BookAuthors[i] + ", " + Convert.ToString(i + 1) + ", " + theme.Theme_str[i] + "." + '\n';
            }
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            Catalog.Text = "Format: Author, book's number, theme." + '\n';
            for (int i = 0; i < 20; i++)
            {
                Catalog.Text += theme.BookAuthors[i] + ", " + Convert.ToString(i+1) + ", " + theme.Theme_str[i] + "." + '\n';
            }
        }

        private void Fantasy_Checked(object sender, RoutedEventArgs e)
        {
            Catalog.Text = "Format: Author, book's number, theme." + '\n';
            for (int i = 0; i < 20; i++)
            {
                if (theme.Theme_str[i] == Convert.ToString(Theme.Fantasy))
                    Catalog.Text += theme.BookAuthors[i] + ", " + Convert.ToString(i + 1) + ", " + theme.Theme_str[i] + "." + '\n';
            }
        }

        private void Science_Checked(object sender, RoutedEventArgs e)
        {
            Catalog.Text = "Format: Author, book's number, theme." + '\n';
            for (int i = 0; i < 20; i++)
            {
                if (theme.Theme_str[i] == Convert.ToString(Theme.Science))
                    Catalog.Text += theme.BookAuthors[i] + ", " + Convert.ToString(i + 1) + ", " + theme.Theme_str[i] + "." + '\n';
            }
        }

        private void Romance_Checked(object sender, RoutedEventArgs e)
        {
            Catalog.Text = "Format: Author, book's number, theme." + '\n';
            for (int i = 0; i < 20; i++)
            {
                if (theme.Theme_str[i] == Convert.ToString(Theme.Romance))
                    Catalog.Text += theme.BookAuthors[i] + ", " + Convert.ToString(i + 1) + ", " + theme.Theme_str[i] + "." + '\n';
            }
        }
    }
}
