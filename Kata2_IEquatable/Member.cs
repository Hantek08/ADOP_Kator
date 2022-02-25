using Kata2_IEquitable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata2_IEquatable
{
    internal class Member : IMember
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public MemberLevel Level { get; set; }
        public DateTime Since { get; set; }

        public int CompareTo(IMember other)
        { 
            if(this.Level != other.Level)
            {
                return this.Level.CompareTo(other.Level);
            }
            if (this.LastName != other.LastName)
            {
                return this.Level.CompareTo(other.LastName);
            }
            if (this.FirstName != other.FirstName)
            {
                return this.FirstName.CompareTo(other.FirstName);
            }
                return this.Since.CompareTo(other.Since);
            
           
        }
        public bool Equals(IMember member) => (this.Level, this.LastName, this.FirstName, this.Since) == (member.Level, member.LastName, member.FirstName, member.Since);
        public override bool Equals(object obj) => Equals(obj as IMember);
        public override int GetHashCode() => (Level,LastName,FirstName,Since).GetHashCode();

        public static DateTime RandomDate()
        {
            var rnd = new Random();
            while (true)
            {
                try
                {
                    int year = rnd.Next(1980, DateTime.Today.Year);
                    int month = rnd.Next(1, 13);
                    int day = rnd.Next(1, 32);
                    return new DateTime (year, month, day);
                }
                catch { }
            }
        }


        public void RandomInit()
        {
           var rnd = new Random();
            bool valid = false;
            while (!valid)
            {
                try
                {
                    this.Level = (MemberLevel)rnd.Next((int)MemberLevel.Platinum, (int)MemberLevel.Blue + 1);
                    this.Since = RandomDate();
                    string[] _firstName = "Hanna Alexandra Jenny Sophie Sahar".Split(' ');
                    this.FirstName = _firstName[rnd.Next(0, _firstName.Length)];
                    string[] _lastName = "Tekie Anderson Larson Svenson Johansson Karlson".Split(' ');
                    this.LastName = _lastName[rnd.Next(0, _lastName.Length)];
                }
                catch 
                {
                }
                finally
                {
                    valid = true;
                }
                
                
            }
            

        }

        public Member()
        {
            RandomInit();
        }

        public override string ToString()
        {
            return $"FirstName: {this.FirstName} LastName: {this.LastName}  Level: {this.Level}  Since: {this.Since}\n";
        }
    }
}
