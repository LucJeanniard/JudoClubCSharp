using System;
using Be.Timvw.Framework.ComponentModel;
using System.Collections.Generic;
namespace EasyJudoClub.Model
{
    public interface IClub
    {
        int MemberCount { get; }
        SortableBindingList<Member> Members { get; set; }
        
        Member AddMember();
        void RemoveMember(int memberId);

        void UpdateMember(Member oldMember, Member newMember);

        Dictionary<string, string> GetDoctorsAndTel();

        void NewSaison();
    }
}
