using System;
using System.Windows.Input;
using Microsoft.TeamFoundation.MVVM;


namespace CB.Model.Common
{
    public class ViewModelBase: ObservableObject
    {
        #region Implementation
        protected ICommand GetCommand(ref ICommand command, Action<object> execute, Predicate<object> canExecute)
        {
            return command ?? (command = new RelayCommand(execute, canExecute));
        }
        #endregion
    }
}