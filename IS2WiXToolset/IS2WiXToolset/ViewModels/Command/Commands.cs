using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
namespace IS2WiXToolset
{
    public class Commands : ICommand
    {
        public ViewModels.ViewModelBase viewModel { get; set; }
        public Commands(ViewModels.ViewModelBase vm)
        {
            viewModel = vm;
        }
        private Action doAction;
        private bool predicate;


        public void Command(Action doAction, bool predicate = true)
        {
        }


        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            this.viewModel.BrowseMsiFile();
        }
    }
}
