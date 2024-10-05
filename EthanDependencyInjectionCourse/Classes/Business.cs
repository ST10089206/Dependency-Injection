using EthanDependencyInjectionCourse.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EthanDependencyInjectionCourse.Classes
{
    public class Business : IBusiness
    {
        //A you can see the data access instance is now changed according to what service you want to use
        //however using the Open-Closed Principle(SOLID) it is possible to overcome this high coupling between 
        //the DA and BIZ
        //Open-Closed Principle = Open for extension, Closed for modification

        private IDataAccess _dataAccess;

        public Business(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public void SignUp(string userName, string password)
        {
            //var da = new DataAccessMySQL();
            _dataAccess.SignUp(userName, password);
        }
    }
}
