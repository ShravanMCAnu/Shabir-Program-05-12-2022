using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shabir_Program
{
    public interface ISchoolRepository
    {
        string GetSchoolName();
        List<Author> GetAllList();
        string GetNameByBook(string book);
    }
}
