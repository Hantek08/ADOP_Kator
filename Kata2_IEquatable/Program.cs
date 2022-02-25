// See https://aka.ms/new-console-template for more information


using Kata2_IEquatable;
using Kata2_IEquitable;

IMember member = new Member();
//Console.WriteLine(member);

IMemberList Hilton = new MemberList(20);
IMemberList Radisson = new MemberList(20);

//Console.WriteLine($"Hilton: \n {Hilton}");
//Console.WriteLine($"Radisson:\n {Radisson}");

var memberList = new MemberList(20);
Console.WriteLine(memberList[1]);

