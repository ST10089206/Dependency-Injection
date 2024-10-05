using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EthanDependencyInjectionCourse.Interfaces
{
    public interface IDataAccess
    {
        void SignUp(string userName, string password);
    }
}
