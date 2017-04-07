using Microsoft.Win32;
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

namespace IS2WiXToolset
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = new MainWindowsViewModel();
            InitializeComponent();
        }

      

        private void btn_Open_MsiFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "msi files (*.msi)|*.msi";
            if (openFileDialog.ShowDialog() == true)
                txtMsiFilePath.Text = openFileDialog.FileName;
        }

        private void btnBrowseIsmFileClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "ism files (*.ism)|*.ism";
            if (openFileDialog.ShowDialog() == true)
                txtMsiFilePath.Text = openFileDialog.FileName;
        }

        private void btnSetOutputDirectory(object sender, RoutedEventArgs e)
        {

        }
    }
}
