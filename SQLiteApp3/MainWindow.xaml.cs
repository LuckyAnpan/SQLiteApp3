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

namespace SQLiteApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataAccess.InitializeDatabase();
        }


        //ADD BUTTON
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            DataAccess.AddData(txtName.Text);
            txtName.Clear();
        }


        //SHOW BUTTON
        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            string allData = "";
            foreach (string data in DataAccess.GetData())
            {
                allData = allData + data.ToString() + "\n";
            }
            MessageBox.Show(allData);
        }
    }
}
