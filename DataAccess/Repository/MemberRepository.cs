using BusinessObject;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public void AddMember(MemberObject member) => MemberDAO.Instance.AddMember(member);

        public void DeleteMember(int MemID) => MemberDAO.Instance.Delete(MemID);

        public IEnumerable<MemberObject> GetMembersList()
        {
            return MemberDAO.Instance.GetMembersList;
        }

        public MemberObject Login(string Email, string Password)
        {
            return MemberDAO.Instance.Login(Email, Password);
        }

        public IEnumerable<MemberObject> SearchAddress(string address, IEnumerable<MemberObject> searchList)
        {
            return MemberDAO.Instance.AddressFilter(address, searchList);
        }

        public IEnumerable<MemberObject> SearchID(int id)
        {
            return MemberDAO.Instance.SearchID(id);
        }

        public IEnumerable<MemberObject> SearchName(string name)
        {
            return MemberDAO.Instance.SearchName(name);
        }

        public void UpdateMember(MemberObject member) => MemberDAO.Instance.Update(member);
    }
}
