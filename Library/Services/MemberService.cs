using System;
using System.Collections.Generic;
using Library.Repositories;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library.Services
{
    public class MemberService : IService
    {
        MemberRepository memberRepository;

        public event EventHandler Updated;

        public MemberService(RepositoryFactory rFactory)
        {
            this.memberRepository = rFactory.CreateMemberRepository();
        }

        public void Add(Member member)
        {
            memberRepository.Add(member);
            OnUpdated();
        }

        /// <summary>
        /// returns all members
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Member> All()
        {
            return memberRepository.All();
        }

        /// <summary>
        /// Return members based on lamda expession
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public IEnumerable<Member> FindMembersBy(Func<Member, bool> expression)
        {
            return memberRepository.All().Where(expression);
        }

        /// <summary>
        /// returns a user based on user id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Member Find(int id)
        {
            return memberRepository.Find(id);
        }

        public void Edit(Member m)
        {
            memberRepository.Edit(m);
            OnUpdated();
        }

        public void Remove(Member m)
        {
            memberRepository.Remove(m);
            OnUpdated();
        }

        private void OnUpdated()
        {
            Updated?.Invoke(this, EventArgs.Empty);
        }
    }
}
