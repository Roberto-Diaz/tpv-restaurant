using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Restaurant.Utility
{
    public class RelayCommand: ICommand
    {
        //private Action methodToExecute;         
        //readonly Predicate<Object> _canExecute;

        //public RelayCommand(Action methodToExecute, Predicate<Object> canExecute)
        //{
        //    if (methodToExecute == null)
        //        throw new NullReferenceException("execute");

        //    this.methodToExecute = methodToExecute;
        //    _canExecute = canExecute;
        //}

        //public RelayCommand(Action methodToExecute) : this(methodToExecute, null)
        //{
        //}
        //public event EventHandler CanExecuteChanged
        //{
        //    add { CommandManager.RequerySuggested += value; }
        //    remove { CommandManager.RequerySuggested -= value; }

        //}

        //public bool CanExecute(object parameter)
        //{
        //    return _canExecute == null ? true : _canExecute(parameter);
        //}

        //public void Execute(object parameter)
        //{
        //    methodToExecute.Invoke();
        //}



        private Action<object> _execute;
        private Predicate<object> _canExecute;

        public RelayCommand(Action<object> execute, Predicate<object> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }   

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            //return _canExecute(parameter);
            return _canExecute == null ? true : _canExecute.Invoke(parameter);  
        }   

        public void Execute(object parameter)
        {       
            _execute.Invoke(parameter);
        }
    }
}
