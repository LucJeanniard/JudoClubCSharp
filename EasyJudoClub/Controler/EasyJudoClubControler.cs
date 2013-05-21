// -----------------------------------------------------------------------
// <copyright file="EasyJudoClubControler.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace EasyJudoClub.Controler
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using EasyJudoClub.Model;

    public class EasyJudoClubControler
    {
        public IClub JudoClub 
        {
            get; private set;
        }

        public void Initialize()
        {
            JudoClub = Club.Deserialize();
        }

        public void Initialize(IClub club)
        {
            JudoClub = club;
        }

        public void Save()
        {
            Club.Serialize(JudoClub);
        }

        public void RemoveMember(int memberId)
        {
            JudoClub.RemoveMember(memberId);
        }

        public Member AddMember()
        {
            return JudoClub.AddMember();
        }

        public void UpdateMember(Member oldMember, Member newMember)
        {
            JudoClub.UpdateMember(oldMember, newMember);
        }

        public List<Member> GetFilteredMembersByName(string searchPattern)
        {
            var filteredMembers = JudoClub.Members
                .Where(_ =>
                       (!String.IsNullOrEmpty(_.Nom) && !String.IsNullOrEmpty(_.Prenom)) &&
                       (
                          _.Nom.ToLower().Contains(searchPattern.ToLower()) ||
                          _.Prenom.ToLower().Contains(searchPattern.ToLower()))
                       )
                .ToList();
            return filteredMembers;
        }

        public List<Member> GetFilteredMembersWithSeason2012_2013Only(List<Member> memberList)
        {
            return memberList.Where(_ => _.saison2012_2013 == true).ToList();
        }
    }
}
