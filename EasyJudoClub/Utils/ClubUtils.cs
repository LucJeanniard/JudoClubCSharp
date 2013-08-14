using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Be.Timvw.Framework.ComponentModel;
using System.IO;
using System.Diagnostics;

namespace EasyJudoClub
{
    class ClubUtils
    {
        public static SortableBindingList<Member> LoadMemberFromFile(string filename)
        {
            var listMember = new SortableBindingList<Member>();
            var lines = File.ReadAllLines(filename);
            for (int i = 1; i < lines.Count(); i++)
            {
                var memberLine = lines[i];
                var memberFields = memberLine.Split(',');
                var newMember = new Member();

                newMember.Id = i;
                newMember.Nom = memberFields[0];
                newMember.Prenom = memberFields[1];
                newMember.CodePostal = memberFields[2];
                newMember.Commune = memberFields[3];
                newMember.DateDeNaissance = DateTime.Parse(memberFields[4]);

                if (memberFields[5] == "M")
                    newMember.Sexe = Sexe.Masculin;
                else if (memberFields[5] == "F")
                    newMember.Sexe = Sexe.Feminin;
                else
                    Debug.Assert(false, "sexe not found for " + newMember.Nom);

                newMember.LicenseNumber = memberFields[6];
                newMember.EmailMere = memberFields[7];
                newMember.TelMere = memberFields[8];
                newMember.TelPortableMere = memberFields[9];

                listMember.Add(newMember);
            }

            return listMember;
        }
    }
}
