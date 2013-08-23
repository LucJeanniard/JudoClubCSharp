using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using EasyJudoClub.Model;

namespace EasyJudoClub
{
    [Serializable]
    public class Member
    {        
        public bool saison2012_2013 { get; set; }
        public bool saisonN { get; set; }
        public bool saisonNmoins1{ get; set; }
        public int Id { get; set; }
        public DateTime DateEntreeClub { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string NomPere { get; set; }
        public string PrenomPere { get; set; }
        public string NomMere { get; set; }
        public string PrenomMere { get; set; }
        public string Commune { get; set; }
        public string CodePostal { get; set; }
        public string Adresse { get; set; }
        public string EmailMere { get; set; }
        public string TelMere { get; set; }
        public string TelPortableMere { get; set; }
        public string EmailPere { get; set; }
        public string TelPere { get; set; }
        public string TelPortablePere { get; set; }

        public DateTime DateDeNaissance { get; set; }
        public Sexe Sexe { get; set; }
        public string LicenseNumber { get; set; }
        public Ceinture Ceinture { get; set; }
        public bool CommisaireSportif { get; set; }
        public bool Arbitre { get; set; }
        public string CertificatMedicalNomMedecin { get; set; }
        public string CertificatMedicalTelMedecin { get; set; }

        public string MoyenPaiementsLiquide { get; set; }
        public string MoyenPaiementsCheque { get; set; }
        public string MoyenPaiementsChequesVacances { get; set; }
        public string MoyenPaiementsChequierJeune { get; set; }
        public string MoyenPaiementsCarteMRA { get; set; }

        [XmlIgnore]
        public bool CotisationAJour
        {
            get
            {
                return

                    ((!String.IsNullOrEmpty(MoyenPaiementsLiquide)) && (!String.IsNullOrWhiteSpace(MoyenPaiementsLiquide))) ||
                    ((!String.IsNullOrEmpty(MoyenPaiementsCheque)) && (!String.IsNullOrWhiteSpace(MoyenPaiementsCheque))) ||
                    ((!String.IsNullOrEmpty(MoyenPaiementsChequesVacances)) && (!String.IsNullOrWhiteSpace(MoyenPaiementsChequesVacances))) ||
                    ((!String.IsNullOrEmpty(MoyenPaiementsChequierJeune)) && (!String.IsNullOrWhiteSpace(MoyenPaiementsChequierJeune))) ||
                    ((!String.IsNullOrEmpty(MoyenPaiementsCarteMRA)) && (!String.IsNullOrWhiteSpace(MoyenPaiementsCarteMRA)));
            }
        }


        [XmlIgnore]
        public int CoutCotisation
        {
            get { return CotisationHelper.GetCotisation(Commune, Categorie); }
        }

        [XmlIgnore]
        public Categorie Categorie 
        {
            get
            {
                return CategorieHelper.GetCategorie(DateTime.Now.Year, DateDeNaissance.Year);
            }
        }

        [XmlIgnore]
        public int Age
        {
            get
            {
                return GetAge(DateTime.Now, DateDeNaissance);
            }
        }


        public static int GetAge(DateTime date, DateTime dateDeNaissance)
        {
            int age = date.Year - dateDeNaissance.Year;
            
            if (dateDeNaissance > date.AddYears(-age))
                age--;
            return age;
        }

    }
}