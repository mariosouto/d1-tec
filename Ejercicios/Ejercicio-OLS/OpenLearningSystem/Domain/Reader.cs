using System;
using System.Collections.Generic;

namespace Domain
{
    public class Reader
    {
        private string firstName;
        private string lastName;
        private string email;
        private string password;
        private DateTime dateOfBirth;
        private List<Summary> summaries;
        private Subscription? subscription;

        public Reader()
        {
            this.summaries = new List<Summary>();
        }
    }
}
