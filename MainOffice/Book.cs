namespace MainOffice
{
    class Book
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Stars { get; set; }

        public Book(int id, string name, int stars)
        {
            Id = id;
            Name = name;
            Stars = stars;
        }

        public Book()
        {
        }
    }
}
