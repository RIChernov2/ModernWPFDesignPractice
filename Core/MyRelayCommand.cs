﻿namespace ModernWPFDesignPractice.Core
{
    using System.Windows.Input;

    // testing own class instaed of CommunityToolkit.Mvvm.Input.RelayCommand
    public class MyRelayCommand : ICommand
    {

        private Action<object?> _execute;
        private Func<object?, bool>? _canExecute;

        public MyRelayCommand(Action<object?> execute, Func<object?, bool>? canExecute = null)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object? parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }

        public void Execute (object? parameter)
        {
            _execute?.Invoke(parameter);
        }
    }
}
