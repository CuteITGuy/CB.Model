using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Microsoft.TeamFoundation.MVVM;


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