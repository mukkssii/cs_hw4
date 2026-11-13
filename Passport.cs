using System;
using System.Collections.Generic;
using System.Text;

namespace cs4_hw
{
    internal class Passport
    {
        private string _passNum;
        private string _fullName;
        private DateTime _issueDate;

        public Passport(string passNum, string fullName, DateTime issueDate)
        {
            if (passNum == "")
            {
                throw new Exception("Invalid passport number");
            }

            if (fullName == "")
            {
                throw new Exception("Wrong full name!");
            }

            if (issueDate > DateTime.Now)
            {
                throw new Exception("Wrong issue date!");
            }
            _passNum = passNum;
            _fullName = fullName;
            _issueDate = issueDate;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Passport number: {_passNum}");
            Console.WriteLine($"Full name: {_fullName}");
            Console.WriteLine($"Issue date: {_issueDate.ToString()}");
        }
    }
}
