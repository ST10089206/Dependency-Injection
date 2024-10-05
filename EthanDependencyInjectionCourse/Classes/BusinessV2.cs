using EthanDependencyInjectionCourse.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EthanDependencyInjectionCourse.Classes
{
    public class BusinessV2 : IBusiness
    {
        private IDataAccess _dataAccess;

        public BusinessV2(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public void SignUp(string userName, string password)
        {
            _dataAccess.SignUp(userName, password);
        }
    }
}
