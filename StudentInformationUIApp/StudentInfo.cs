using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationUIApp
{
    internal class StudentInfo
    {
        public String regNumber;
        public String firstName;
        public String lastName;

        public string GetFullName()
        {
            return (firstName + " " + lastName);
        }
    }
}
