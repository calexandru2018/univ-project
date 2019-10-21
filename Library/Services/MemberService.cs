using System;
using System.Collections.Generic;
using Library.Repositories;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library.Services
{
    class MemberService : IService
    {
        MemberRepository memberRepository;

        public MemberService(RepositoryFactory rFactory)
        {
            this.memberRepository = rFactory.CreateMemberRepository();
        }

        public event EventHandler Updated;

        public void Add(Member member)
        {
            memberRepository.Add(member);
        }

        public IEnumerable<Member> All()
        {
            return memberRepository.All();
        }

        // Space to create custom functions to search, edit, delete authors

        public void Edit(Member m)
        {
            memberRepository.Edit(m);
            // TODO: Raise the Updated event.
        }
    }
}
