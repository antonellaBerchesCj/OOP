//using Microsoft.Extensions.DependencyInjection;

//namespace Learn.PATTERNS.CQRS
//{
//    public class Main
//    {
//        public void Execute()
//        {
//            var serviceProvider = new ServiceCollection()
//                 //Add data base context
//                 .AddSingleton<IApplicationContext, ApplicationContext>()
//                 // Add commands handlers
//                 .AddScoped<ICommandHandler<AddNewProductCommand>, AddNewProductCommandHandler>()
//                 //Creat service
//                 .BuildServiceProvider();

//            var commandDispatcher = new CommandDispatcher(serviceProvider);
//            //Add new Product
//            var product = new AddNewProductCommand { Id = Guid.NewGuid(), Name = "iPhone 11", Description = "Apple iphone 11" };
//            commandDispatcher.Send(product);
//        }
//    }
//}
