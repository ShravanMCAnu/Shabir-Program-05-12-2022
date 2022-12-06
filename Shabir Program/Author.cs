namespace Shabir_Program
{
    public class Author : IAuthor
    {
        public string? Name { get; set; }
        public string? Book { get; set; }
        public double Price { get; set; }
        public List<Author> DepartmentListMethod()
        {
            List<Author> authorList = new List<Author>
            {
            new Author{Name="Human Resource",Book="HR"},
            new Author{Name="Electricity",Book="EC"},
            new Author{Name= "Home Department",Book="HD"},
            new Author{Name=""}
            };
            return authorList;
        }
    }
}