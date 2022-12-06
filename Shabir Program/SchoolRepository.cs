using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Shabir_Program
{
    public class SchoolRepository:ISchoolRepository 
    {
        private readonly IAuthor _db;
        public SchoolRepository(IAuthor db)
        {
            _db = db;
        }
        public string GetSchoolName()
        {
            string schoolName = "Hyd Public School";
            return schoolName;
        }
        public List<Author> GetAllList()
        {
            var record = _db.DepartmentListMethod();
            return record;
        }
        public string GetNameByBook(string book)
        {
            var bookName = _db.DepartmentListMethod();
            var name = bookName.Where(x => x.Book == book).Select(x => x.Name).FirstOrDefault();
            return book;
        }
    }
}
