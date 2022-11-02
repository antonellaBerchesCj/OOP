namespace Learn
{
    /*
     * Entity => Dto (implicit operator)
     * 
     * You can have ONLY ONE operator defined. 
     * If you define the explicit operator, you can only convert objects explicitly. 
     * However, if you define the IMPLICIT operator, you can use it in both ways, implicit and explicit.
       
        MessageDto dto = tableEntity;
        MessageDto dto = (MessageDto)tableEntity;

     * A better way to achieve the model-DTO conversions illustrated above is to use implicit and explicit operators.
     * When you use implicit or explicit conversion operators, you don’t have to write cumbersome methods to convert
     * an instance of one type to another. The code is much more straightforward.
     */
    public class ImplicitExplicitOperators
    {
        // classic way
        //public static AuthorDto ConvertAuthorToAuthorDto(Author author)
        //{
        //    AuthorDto authorDto = new AuthorDto
        //    {
        //        Id = author.Id.ToString(),
        //        FirstName = author.FirstName,
        //        LastName = author.LastName
        //    };
        //    return authorDto;
        //}

        ////classic way
        //public static Author ConvertAuthorDtoToAuthor(AuthorDto authorDto)
        //{
        //    Author author = new Author
        //    {
        //        Id = Guid.Parse(authorDto.Id),
        //        FirstName = authorDto.FirstName,
        //        LastName = authorDto.LastName
        //    };
        //    return author;
        //}

        public static void DoWork()
        {
            AuthorEntity author = new AuthorEntity();
            author.FirstName = "David";

            // implicit operator
            AuthorDto authorDto = author;
            Console.WriteLine(authorDto.FirstName);

            // explicit operator
            AuthorDto authorDto2 = (AuthorDto)author;
            authorDto2.FirstName = "Anto";

            Console.WriteLine(authorDto2.FirstName);
        }

        public static void DoWork2()
        {
            var t0 = new Temperature(10d, 'K');

            Temperature t1 = 20d;
            Temperature t2 = 'H';
            Console.WriteLine(t0.MeasureUnit); // K
            Console.WriteLine(t0.Value); // 10
            
            Console.WriteLine(t1.MeasureUnit); // K
            Console.WriteLine(t1.Value); // 20

            Console.WriteLine(t2.MeasureUnit); // F
            Console.WriteLine(t2.Value); // F
        }
    }

    public class AuthorEntity
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static implicit operator AuthorDto(AuthorEntity author)
        {
            AuthorDto authorDto = new AuthorDto();
            authorDto.Id = author.Id.ToString();
            authorDto.FirstName = author.FirstName;
            authorDto.LastName = author.LastName;
            return authorDto;
        }
    }

    public class AuthorDto
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class Temperature
    {
        public double Value { get; }
        public char MeasureUnit { get; }
        public Temperature(double value, char measureUnit)
        {
            Value = value;
            MeasureUnit = measureUnit;
        }

        public static implicit operator Temperature(double lhs) => new Temperature(lhs, 'K');
        public static implicit operator Temperature(char fahrenheit) => new Temperature(fahrenheit, 'F');
        public static implicit operator double(Temperature lhs) => lhs.Value;
    }

}
