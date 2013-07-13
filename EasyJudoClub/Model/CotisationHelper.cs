using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace EasyJudoClub.Model
{
    public static class CotisationHelper
    {
        public static int GetPrixLicense()
        {
            var valueAsString = ConfigurationManager.AppSettings["PrixLicense"];
            
            if (String.IsNullOrEmpty(valueAsString))
                return 33;
            
            return Convert.ToInt32(valueAsString);
        }

        public static int GetPrixSuppExterieur()
        {
            var valueAsString = ConfigurationManager.AppSettings["PrixSuppExterieur"];

            if (String.IsNullOrEmpty(valueAsString))
                return 10;
            
            return Convert.ToInt32(valueAsString);
        }


        public static int GetPrixAdhesion1()
        {
            var valueAsString = ConfigurationManager.AppSettings["PrixAdhesion1"];
            
            if (String.IsNullOrEmpty(valueAsString))
                return 83;
            
            return Convert.ToInt32(valueAsString);
        }

        public static int GetPrixAdhesion2()
        {
            var valueAsString = ConfigurationManager.AppSettings["PrixAdhesion2"];
            
            if (String.IsNullOrEmpty(valueAsString))
                return 103;
            
            return Convert.ToInt32(valueAsString);
        }

        public static int GetCotisation(string commune, Categorie categorie)
        {
            int coutSupExterieur = GetPrixSuppExterieur();
            int license = GetPrixLicense();

            var exterieur = string.Compare(commune, "Colombe", StringComparison.OrdinalIgnoreCase) != 0;

            var adhesion = GetAdhesion(categorie);

            var coutAnnee = adhesion + license;

            if (exterieur)
                coutAnnee += coutSupExterieur;

            return coutAnnee;
        }

        public static int GetAdhesion(Categorie categorie)
        {
            int adhesion1 = GetPrixAdhesion1();
            int adhesion2 = GetPrixAdhesion2();

            if ((categorie == Categorie.Eveil) || (categorie == Categorie.Poussinet))
                return adhesion1;
            else
                return adhesion2;
        }

    }
}
