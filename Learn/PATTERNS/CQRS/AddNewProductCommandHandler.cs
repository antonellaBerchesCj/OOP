//using Cqrs.Commands;
//using Learn.PATTERNS.RepositoryPattern;
//using System.ComponentModel.DataAnnotations;
//using System.Text;

//namespace Learn.PATTERNS.CQRS
//{
//    public class AddNewProductCommandHandler : ICommandHandler<AddNewProductCommand>
//    {
//        private readonly IApplicationContext _context;
//        public AddNewProductCommandHandler(IApplicationContext context)
//        {
//            _context = context;
//        }

//        public async Task Handle(AddNewProductCommand command)
//        {
//            var validator = new AddNewProductCommandValidator();
//            ValidationResult results = validator.Validate(command);
//            bool validationSucceeded = results.IsValid;
//            if (!validationSucceeded)
//            {
//                var failures = results.ErrorMessage.ToList();
//                var message = new StringBuilder();
//                failures.ForEach(f => { message.Append(f.ErrorMessage + Environment.NewLine); });
//                throw new ValidationException(message.ToString());
//            }
//            var product = new Product
//            {
//                Id = command.Id,
//                Name = command.Name,
//                Description = command.Description,
//                UnitPrice = 0,
//                CurrentStock = 0
//            };

//            _context.Products.Add(product);
//            //Command must be processed asynchronously, so I used an Emty Task.
//            //In the real world, saving data is an asynchronous operation, we use something like _context. SaveChangesAsync ();
//            await Task.Run(() => { });
//        }
//    }
//}
