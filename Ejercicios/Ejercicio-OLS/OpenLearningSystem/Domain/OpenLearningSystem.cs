using System;
using System.Collections.Generic;

namespace Domain
{
    public class OpenLearningSystem
    {
        private List<Summary> summaries;
        private List<Author> authors;
        private List<Reader> readers;
        private List<Subscription> subscriptions;
        private List<Reviewer> reviewers;

        public OpenLearningSystem()
        {
            this.summaries = new List<Summary>();
            this.authors = new List<Author>();
            this.readers = new List<Reader>();
            this.subscriptions = new List<Subscription>();
            this.reviewers = new List<Reviewer>();
        }

        public void addAuthor(Author author)
        {

        }

        public void addSummary(Author author, Summary summary)
        {

        }

        public void addReader(Reader reader)
        {

        }

        public void addReviewer(Reviewer reviewer)
        {

        }

        public void createSubscription(Reader reader, PaymentMethod paymentMethod)
        {

        }

        public List<Summary> getAllSummaries()
        {
            return null;
        }

        public List<Summary> getPublicSummaries()
        {
            return null;
        }

        public List<Subscription> getExpiredSubscriptions()
        {
            return null;
        }
    }
}
