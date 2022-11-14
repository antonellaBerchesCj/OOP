//using System.Windows.Input;

//namespace Learn.PATTERNS.CQRS
//{
//    // https://abdelmajid-baco.medium.com/cqrs-pattern-with-c-a9aff05aae3f
//
//    // “Add a New Product”: this scenario is a command operation because it’ll make a change to the system.
//    public class AddNewProductCommand : ICommand
//    {
//        public Guid Id { get; set; }
//        public string Name { get; set; }
//        public string Description { get; set; }

//        public event EventHandler? CanExecuteChanged;

//        public bool CanExecute(object? parameter)
//        {
//            throw new NotImplementedException();
//        }

//        public void Execute(object? parameter)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
