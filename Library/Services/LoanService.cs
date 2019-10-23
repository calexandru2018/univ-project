using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    public class LoanService : IService
    {
        LoanRepository loanRepository;

        public event EventHandler Updated;

        public LoanService(RepositoryFactory rFactory)
        {
            this.loanRepository = rFactory.CreateLoanRepository();
        }

        public void Add(Loan loan)
        {
            loanRepository.Add(loan);
            OnUpdated();
        }

        /// <summary>
        /// Returns all loans based on a member
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        public IEnumerable<Loan> AllMemberLoans(Member member)
        {
            return loanRepository.All().Where(loan => loan.MemberId == member.Id);
        }

        /// <summary>
        /// Returns all loans ever made
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Loan> All()
        {
            return loanRepository.All().OrderByDescending(loan => loan.StartLoanTimestamp);
        }

        /// <summary>
        /// Returns loans based on a lambda expression
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public IEnumerable<Loan> FindLoansBy(Func<Loan, bool> expression)
        {
            return loanRepository.All().Where(expression);
        }        

        public void Edit(Loan l)
        {
            loanRepository.Edit(l);
            OnUpdated();
        }

        public void Remove(Loan item)
        {
            loanRepository.Remove(item);
            OnUpdated();
        }

        private void OnUpdated()
        {
            Updated?.Invoke(this, EventArgs.Empty);
        }
    }
}
