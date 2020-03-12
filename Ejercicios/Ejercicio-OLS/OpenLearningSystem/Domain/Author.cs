using System;
using System.Collections.Generic;

namespace Domain
{
    public class Author
    {
        private string firstName;
        private string lastName;
        private string email;
        private string password;
        private DateTime dateOfBirth;
        private List<Summary> summaries;

        public Author()
        {
            this.summaries = new List<Summary>();
        }
    }
}
