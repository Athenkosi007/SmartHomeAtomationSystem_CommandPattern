using System.Windows.Input;

namespace SmartHomeAtomationSystem_CommandPattern
{
    public class RemoteControl
    {
        private readonly Stack<ICommand> _commandHistory = new();

        public void SendCommand(ICommand command)
        {
            command.Execute();
            _commandHistory.Push(command);
        }

        public void UndoLastCommand()
        {
            if (_commandHistory.Count > 0)
            {
                var command = _commandHistory.Pop();
                command.Undo();
            }
            else
            {
                Console.WriteLine("❌ No command to undo");
            }
        }
    }
}
