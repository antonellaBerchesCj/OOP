namespace Learn
{
    /*
     * Lazy initialization of an object means that its creation is deferred until it is first used.
     * 
     * Microsoft recommends using the Lazy<T> class instead. The Lazy<T> class in the System namespace in C# 
     * was introduced as part of .Net Framework 4.0 to provide a thread-safe way to implement lazy initialization. 
     * You can take advantage of this class to defer the initialization of resource-intensive objects in your application.
     * 
     * Note that the one-to-many relationship between the Author and Blog classes has been represented 
     * using a List property (of type Blog) in the Author class. Using this property, the Author class 
     * can hold a collection of one or more instances of the Blog class.
     */
    public static class LazyInitialization
    {
        public static void DoWork()
        {
            Lazy<IEnumerable<Author>> authorsLazy = new Lazy<IEnumerable<Author>>();
            IEnumerable<Author> result = authorsLazy.Value;

            Console.WriteLine(result);
        }
    }

    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

        //public List<Blog> Blogs { get; set; }
        public Lazy<IList<Blog>> Blogs => new Lazy<IList<Blog>>(() => GetBlogDetailsForAuthor(this.Id));
        private IList<Blog> GetBlogDetailsForAuthor(int Id)
        {
            return new List<Blog>
            {
                new Blog
                {
                    Id = 1,
                    PublicationDate = new DateTime(2022,11,01),
                    Title = "First blog"
                },
                new Blog
                {
                    Id = 2,
                    PublicationDate = new DateTime(2022,11,03),
                    Title = "Second blog"
                },
                new Blog
                {
                    Id = 3,
                    PublicationDate = new DateTime(2022,12,04),
                    Title = "Third blog"
                }
            };
        }
    }
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime PublicationDate { get; set; }
    }
}
