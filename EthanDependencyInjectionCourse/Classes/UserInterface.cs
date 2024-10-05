using EthanDependencyInjectionCourse.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EthanDependencyInjectionCourse.Classes
{
    public class UserInterface
    {
        private string _userName;
        private string _password;

        private IBusiness _business;
        private IBusiness _business2;

        public UserInterface(IBusiness business, IBusiness business2)
        {
            _business = business;
            _business2 = business2;
        }

        private void GetData()
        {
            Console.WriteLine("Enter username: ");
            _userName = Console.ReadLine();

            Console.WriteLine("Enter password: ");
            _password = Console.ReadLine();
        }

        public void SignUp()
        {
            GetData();

            //var biz = new Business();
            _business2.SignUp(_userName, _password);
            _business.SignUp(_userName, _password);
        }
    }
}
