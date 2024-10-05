using EthanDependencyInjectionCourse.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EthanDependencyInjectionCourse.Data
{
    public class DataAccessMySQL : IDataAccess
    {
        public void SignUp(string userName, string password)
        {
            //use EF to write data into SQL server
        }
    }
}
