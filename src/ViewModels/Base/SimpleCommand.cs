using System;
using System.Windows.Input;

namespace PowerOff
{
    public class SimpleCommand : ICommand
    {
        private readonly Action _execute;

        public SimpleCommand(Action execute)
            => _execute = execute ?? throw new ArgumentNullException(nameof(execute));

        public bool CanExecute(object? parameter)
            => true;

        public void Execute(object? parameter)
            => _execute();

        public event EventHandler? CanExecuteChanged
        {
            add { }
            remove { }
        }
    }
}
