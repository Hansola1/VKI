namespace My_lib
{
    public class Book
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public int PubYear { get; set; }
        public int CountCopies { get; set; }

        public Book(int id, string author, string title, int pubYear, int countCopies)
        {
            Id = id;
            Author = author;
            Title = title;
            PubYear = pubYear;
            CountCopies = countCopies;
        }
     
        public override string ToString()
        {
            return $"\nАртикул: {Id}\nАвтор: {Author}\nНазвание: {Title}\nГод издания: {PubYear}\nКоличество экземпляров: {CountCopies}\n";
        }
    }
}
