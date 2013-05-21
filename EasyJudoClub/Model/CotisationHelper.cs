using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyJudoClub.Model
{
    public static class CotisationHelper
    {
        public static int GetCotisation(string commune, Categorie categorie)
        {
            const int coutSupExterieur = 10;
            const int license = 33;

            var exterieur = string.Compare(commune, "Colombe", StringComparison.OrdinalIgnoreCase) != 0;

            var adhesion = GetAdhesion(categorie);

            var coutAnnee = adhesion + license;

            if (exterieur)
                coutAnnee += coutSupExterieur;

            return coutAnnee;
        }

        public static int GetAdhesion(Categorie categorie)
        {
            const int adhesion1 = 83;
            const int adhesion2 = 103;

            if ((categorie == Categorie.Eveil) || (categorie == Categorie.Poussinet))
                return adhesion1;
            else
                return adhesion2;
        }

    }
}
