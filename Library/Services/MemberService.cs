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

        public IEnumerable<Member> All()
        {
            return memberRepository.All();
        }

        // Space to create custom functions to search, edit, delete authors

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
