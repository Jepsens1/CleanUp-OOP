using System;
using System.Collections.Generic;
using System.Text;

namespace CleanUp_OOP
{
    class OSSystem
    {
        private string user;

        public string User
        {
            get { return user; }
            set { user = value; }
        }

        private string organization;

        public string Organization
        {
            get { return organization; }
            set { organization = value; }
        }

        private string os;

        public string OS
        {
            get { return os; }
            set { os = value; }
        }
        public OSSystem()
        {

        }

        public OSSystem(string _user, string _organization, string _os)
        {
            User = _user;
            Organization = _organization;
            OS = _os;
        }
    }
}
