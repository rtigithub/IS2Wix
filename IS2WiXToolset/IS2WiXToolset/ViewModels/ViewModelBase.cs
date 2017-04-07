using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS2WiXToolset.ViewModels
{
    public class ViewModelBase
    {
        public Commands BrowseMSICommand { get; set; }
        public ViewModelBase()
        {
            BrowseMSICommand = new Commands(this);
        }

        public void BrowseMsiFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "msi files (*.msi)|*.msi";
            if (openFileDialog.ShowDialog() == true)
                txtMsiFilePath.Text = openFileDialog.FileName;
        }
    }
}
