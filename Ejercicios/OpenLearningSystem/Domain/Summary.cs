using System;
using System.Collections.Generic;

namespace Domain
{
    public class Summary
    {
        private string description;
        private string content;
        private DateTime createdAt;
        private DateTime? reviewedAt;
        private Status status;
        private PublicationType publicationType;
        private Author author;
        private Reviewer reviewer;
        private List<Reader> readers;

        public Summary()
        {
            this.readers = new List<Reader>();
        }

        public void assignReviewer(Reviewer reviewer)
        {

        }
    }
}
