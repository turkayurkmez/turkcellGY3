namespace introduceEFCore.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Comment { get; set; } = string.Empty;
        public int? BookId { get; set; }

        public string VoterName { get; set; } = string.Empty;
        public Book? Book { get; set; }
        public double? Rating { get; set; }
    }
}
