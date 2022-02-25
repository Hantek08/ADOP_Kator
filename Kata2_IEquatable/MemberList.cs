using Kata2_IEquitable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata2_IEquatable
{
    
    class MemberList : IMemberList
    {
        public List<Member> _memberLists = new List<Member>();

        public MemberList(int NrOfMembers)
        {
            for (int i = 0; i < NrOfMembers; i++)
            {
                _memberLists.Add(new Member());
            }
        }

        public Member this[int index]
        {
            get => _memberLists[index];
            set => _memberLists.Insert(index, value);
        }
        public int Count()
        {
           return _memberLists.Count();
        }

        public int Count(int year)
        {
            int result = 0;
            for (int i = 0; i < _memberLists.Count; i++)
            {
                if(_memberLists[i].Since.Year == year)
                {
                    result += i;
                }
            }
            return result;
        }

        public void Sort()
        {
            _memberLists.Sort();
        }

        public override string ToString()
        {
            string sRet = "";
            for (int i = 0; i < _memberLists.Count ; i++)
            {
                sRet += $"{_memberLists[i],-10}";
                if ((i+1)% 10==0)
                {
                    sRet += "\n";
                }
            }
            return sRet;
        }
    }
}
