using System;
using System.Collections.Generic;

namespace Domain
{
    public class Reviewer
    {
        private string firstName;
        private string lastName;
        private string email;
        private string password;
        private DateTime dateOfBirth;
        private List<Summary> summaries;

        public Reviewer()
        {
            this.summaries = new List<Summary>();
        }
    }
}
