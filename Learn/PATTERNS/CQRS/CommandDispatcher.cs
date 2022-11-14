//using Cqrs.Commands;

//namespace Learn.PATTERNS.CQRS
//{
//    // class called CommandDispatcher that implement ICommandDispatcher and used to choose a proper handler
//    // for a giving command. The handlers are injected using Microsoft.Extensions.DependencyInjection.
//    public class CommandDispatcher : ICommandDispatcher
//    {
//        private readonly IServiceProvider _service;

//        public CommandDispatcher(IServiceProvider service)
//        {
//            _service = service;
//        }

//        public void Send<T>(T command) where T : ICommand
//        {
//            var handler = _service.GetService(typeof(ICommandHandler<T>));
//            if (handler != null)
//                ((ICommandHandler<T>)handler).Handle(command);
//            else
//                throw new Exception($"Command doesn't have any handler {command.GetType().Name}");
//        }
//    }
//}
