using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using System.Collections.Generic;
using Be.Timvw.Framework.ComponentModel;

namespace EasyJudoClub.Model
{
    public class Club : IClub
    {
        public const string EASY_SPORT_CLUB_DB_FILE_NAME = @".\EasySportClubDataBase.xml";

        public SortableBindingList<Member> Members { get; set; }

        [XmlIgnore]
        public int MemberCount
        {
            get { return Members.Count; }
        }


        public void RemoveMember(int memberId)
        {
            Members.Remove(Members.First(_ => _.Id == memberId));
        }

        public Member AddMember()
        {
            var newMemberId = 0;
            if (Members.Count > 0)
                newMemberId = Members.Max(_ => _.Id) + 1;

            var newMember = getDefaultMember();
            newMember.Id = newMemberId;

            Members.Add(newMember);
            return newMember;
        }

        public void UpdateMember(Member oldMember, Member newMember)
        {
            Debug.Assert(oldMember.Id == newMember.Id);

            this.RemoveMember(oldMember.Id);

            if (newMember.Id < Members.Count)
                Members.Insert(newMember.Id, newMember);
            else
                Members.Add(newMember);
        }

        public static IClub Deserialize()
        {
            var serializer = new XmlSerializer(typeof(Club));
            if (!File.Exists(EASY_SPORT_CLUB_DB_FILE_NAME))
                return null;
            var streamReader = new StreamReader(EASY_SPORT_CLUB_DB_FILE_NAME);
            var club = (Club)serializer.Deserialize(streamReader);
            streamReader.Close();
            return club;
        }

        public static void Serialize(IClub club)
        {
            var serializer = new XmlSerializer(typeof(Club));
            var streamWriter = new StreamWriter(EASY_SPORT_CLUB_DB_FILE_NAME);
            serializer.Serialize(streamWriter, club);
            streamWriter.Close();
        }

        public static bool BackUpDataBase(out string errorMessage)
        {
            errorMessage = "";
            bool result;

            var currentDateTime = DateTime.Now;
            var backupFileName =
                String.Format(Path.GetFileNameWithoutExtension(EASY_SPORT_CLUB_DB_FILE_NAME) + "_{0}_{1}_{2}_{3}h{4}min{5}s.xml",
                              currentDateTime.Day,
                              currentDateTime.Month,
                              currentDateTime.Year,
                              currentDateTime.Hour,
                              currentDateTime.Minute,
                              currentDateTime.Second);

            try
            {
                File.Copy(EASY_SPORT_CLUB_DB_FILE_NAME, backupFileName);
                result = true;
            }
            catch (Exception e)
            {
                errorMessage = e.Message;
                result = false;
            }

            return result;

        }

        private Member getDefaultMember()
        {
            var newMember = new Member()
            {
                DateDeNaissance = new DateTime(2000, 1, 1),
                DateEntreeClub = DateTime.Now,
                saisonN = true,
                saisonNmoins1 = false,
                Nom = "",
                Prenom = "",
                NomPere = "",
                PrenomPere = "",
                NomMere = "",
                PrenomMere = "",
                Commune = "",
                CodePostal = "",
                Adresse = "",
                EmailMere = "",
                TelMere = "",
                TelPortableMere = "",
                EmailPere = "",
                TelPere = "",
                TelPortablePere = "",
                Sexe = EasyJudoClub.Sexe.Masculin,
                LicenseNumber = "",
                Ceinture = Ceinture.Blanche,
                CommisaireSportif = false,
                Arbitre = false,
                Passeport = false,
                CertificatMedicalNomMedecin = "",
                CertificatMedicalTelMedecin = "",
                MoyenPaiementsLiquide = "",
                MoyenPaiementsCheque = "",
                MoyenPaiementsChequesVacances = "",
                MoyenPaiementsChequierJeune = "",
                MoyenPaiementsCarteMRA = ""
            };

            return newMember;
        }


        public Dictionary<string, string> GetDoctorsAndTel()
        {
            var doctors = new Dictionary<string, string>();

            
            foreach(var member in this.Members)
            {
                var medecin = member.CertificatMedicalNomMedecin;
                var tel = member.CertificatMedicalTelMedecin;
                if(!String.IsNullOrEmpty(medecin) && !doctors.Keys.Contains(medecin))
                {
                    doctors.Add(medecin, tel);
                }
            }

            return doctors ;
        }

        public void NewSaison()
        {
            foreach (var member in this.Members)
            {
                member.saisonNmoins1 = member.saisonN;
                member.saisonN = false;
                member.MoyenPaiementsCarteMRA = String.Empty;
                member.MoyenPaiementsCheque = String.Empty;
                member.MoyenPaiementsChequesVacances = String.Empty;
                member.MoyenPaiementsChequierJeune = String.Empty;
                member.MoyenPaiementsLiquide= String.Empty;
            }

        }
    }
}
