using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories
{
    public class LoanRepository : IRepository<Loan, int>
    {
        LibraryContext context;

        public LoanRepository(LibraryContext c)
        {
            this.context = c;
        }

        public void Add(Loan item)
        {
            context.Loans.Add(item);
            context.SaveChanges();
        }

        public IEnumerable<Loan> All()
        {
            return context.Loans;
        }

        public Loan Find(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(Loan l)
        {
            context.SaveChanges();
        }

        public void Remove(Loan item)
        {
            context.Loans.Remove(item);
            context.SaveChanges();
        }
    }
}
