namespace introduceEFCore.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public IList<Book>? Books { get; set; }



    }
}
