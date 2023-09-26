using BusinessObject;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    internal class MemberDAO
    {
        private MemberObject GetDefaultMember()
        {
            MemberObject Default = null;
                Default = new MemberObject
                {
                    MemID = 1,
                    Email = "admin",
                    Password = "1",
                    Address = "",
                    MemName = "Admin"
                };

            return Default;
        }
        private static List<MemberObject> members = new List<MemberObject>
        {
            new MemberObject
            {
                MemID = 2,
                MemName = "Nghia Phan",
                Email = "nghia@gmail.com",
                Password = "111111",
                Address = "Can Tho"
            },

            new MemberObject
            {
                MemID = 3,
                MemName = "Huy Hoang",
                Email = "Hoang@gmail.com",
                Password = "222222",
                Address = "Ho Chi Minh"
            },

            new MemberObject
            {
                MemID = 3,
                MemName = "Minh Tu",
                Email = "Tu@gmail.com",
                Password = "333333",
                Address = "Can Tho"
            },

            new MemberObject
            {
                MemID = 4,
                MemName = "Hai Nam",
                Email = "Nam@gmail.com",
                Password = "444444",
                Address = "Can Tho"
            },

            new MemberObject
            {
                MemID = 5,
                MemName = "Tran Quynh",
                Email = "Quynh@gmail.com",
                Password = "555555",
                Address = "Da Nang"
            },

        };

        private MemberDAO()
        {
            MemberObject DefaultAdmin = GetDefaultMember();
            if (DefaultAdmin != null)
            {
                members.Add(DefaultAdmin);
            }
        }

        private static MemberDAO instance = null;
        private static object instanceLook = new object();

        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLook)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }

        public List<MemberObject> GetMembersList => members;

        public MemberObject Login(string Email, string Password)
        {
            MemberObject member = members.SingleOrDefault(mb => mb.Email.Equals(Email) && mb.Password.Equals(Password));
            return member;
        }

        public MemberObject GetMember(int MemberId)
        {
            return members.SingleOrDefault(mb => mb.MemID == MemberId);
        }
        public MemberObject GetMember(string MemberEmail)
        {
            return members.SingleOrDefault(mb => mb.Email.Equals(MemberEmail));
        }
        public void AddMember(MemberObject member)
        {
            if (member == null)
            {
                throw new Exception("Member is undefined!!");
            }

            if (GetMember(member.MemID) == null && GetMember(member.Email) == null)
            {
                members.Add(member);
            }
            else
            {
                throw new Exception("Member already existed!!");
            }
        }
        public void Update(MemberObject member)
        {
            if (member == null)
            {
                throw new Exception("Member is undefined!!");
            }
            MemberObject mem = GetMember(member.MemID);
            if (mem != null)
            {
                var index = members.IndexOf(mem);
                members[index] = member;
            }
            else
            {
                throw new Exception("Member does not exist!!");
            }
        }
        public void Delete(int MemberId)
        {
            MemberObject member = GetMember(MemberId);
            if (member != null)
            {
                members.Remove(member);
            }
            else
            {
                throw new Exception("Member does not exist!!");
            }
        }

        public IEnumerable<MemberObject> SearchID(int id)
        {
            IEnumerable<MemberObject> searchResult = null;

            var memberSearch = from member in members where member.MemID == id select member;
            searchResult = memberSearch;

            return searchResult;
        }
        public IEnumerable<MemberObject> SearchName(string name)
        {
            IEnumerable<MemberObject> searchResult = null;

            var memberSearch = from member in members where member.MemName.ToLower().Contains(name.ToLower()) select member;
            searchResult = memberSearch;

            return searchResult;
        }

        public IEnumerable<MemberObject> AddressFilter(string address, IEnumerable<MemberObject> searchList)
        {
            IEnumerable<MemberObject> searchResult = null;

            var memberSearch = from member in searchList
                               where member.Address == address
                               select member;
            if (address.Equals("All"))
            {
                memberSearch = from member in searchList
                               select member;
            }
            searchResult = memberSearch;

            return searchResult;
        }
    }
}
