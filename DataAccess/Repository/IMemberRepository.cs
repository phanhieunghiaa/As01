using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        public IEnumerable<MemberObject> GetMembersList();
        public MemberObject Login(string Email, String Password);
        public void AddMember(MemberObject member);
        public void UpdateMember(MemberObject member);
        public void DeleteMember(int MemID);
        public IEnumerable<MemberObject> SearchID(int id);
        public IEnumerable<MemberObject> SearchName(string name);
        public IEnumerable<MemberObject> SearchAddress(string country, IEnumerable<MemberObject> searchList);
    }
}
