namespace Shabir_Program
{
    public class MainClass
    {
        private readonly ISchoolRepository _schoolRepository;
        public MainClass(ISchoolRepository schoolRepository)
        {
            _schoolRepository = schoolRepository;
        }
        public string GetSchoolNames()
        {
            var schoolName = _schoolRepository.GetSchoolName();
            return schoolName;
        }
        public List<Author> GetAllLists()
        {
            var authorList = _schoolRepository.GetAllList();
            return authorList;
        }
        public string GetNameByBook()
        {
            string bookName = "HR";
            var bookNames = _schoolRepository.GetNameByBook(bookName);
            return bookNames;
        }
    }   
}