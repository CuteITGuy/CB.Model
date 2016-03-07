using System;
using System.Windows.Input;


namespace CB.Model.Common
{
    public abstract class ViewModelBase: ObservableObject
    {
        #region Implementation
        protected virtual ICommand GetCommand(ref ICommand command, Action<object> execute,
            Predicate<object> canExecute = null)
            => command ?? (command = new RelayCommand(execute, canExecute));
        #endregion
    }
}