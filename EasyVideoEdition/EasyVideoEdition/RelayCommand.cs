using System;
using System.Windows.Input;

class RelayCommand : ICommand
{
    /// <summary>
    /// Class that describe a relay Command
    /// </summary>

    private Action function;

    /// <summary>
    /// Create a relay command who launch the function f
    /// </summary>
    /// <param name="f">Function to use when the command is called</param>
    public RelayCommand(Action f)
    {
        this.function = f;
    }

    public bool CanExecute(object parameter)
    {
        return this.function != null;
    }

    public event EventHandler CanExecuteChanged
    {
        add { CommandManager.RequerySuggested += value; }
        remove { CommandManager.RequerySuggested -= value; }
    }

    public void Execute(object parameter)
    {
        if (this.function != null)
        {
            this.function();
        }
    }
}