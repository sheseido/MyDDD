using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Student
{
    public class Students :  AggregateRoot<string>
    {
        private string _name;
        private string _password;

        public string Name
        {
            get { return _name; }
        }
        public string Password
        {
            get { return _password; }
        }

        public Students(string name, string password)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("姓名不能为空");

        }
    }
}
