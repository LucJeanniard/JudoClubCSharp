namespace EasyJudoClub
{
    public enum Categorie
    {
        NonDefinie, 
        EveilCorporel,
        Eveil,
        Poussinet,
        Poussin,
        Benjamin,
        Minime,
        Cadet,
        Junior,
        Senior
    }

    public static class CategorieHelper
    {
        public static Categorie GetCategorie(int annee, int anneeNaissance)
        {
            var categorie = Categorie.NonDefinie;
      
            var deltaAnnee = annee - anneeNaissance;

            if (deltaAnnee > 18)
                return Categorie.Senior;

            switch (deltaAnnee)
            {
                case 3:
                    categorie = Categorie.EveilCorporel;
                    break;
                case 4:
                case 5:
                    categorie = Categorie.Eveil;
                    break;

                case 6:
                case 7:
                    categorie = Categorie.Poussinet;
                    break;
                case 8:
                case 9:
                    categorie = Categorie.Poussin;
                    break;
                case 10:
                case 11:
                    categorie = Categorie.Benjamin;
                    break;
                case 12:
                case 13:
                    categorie = Categorie.Minime;
                    break;
                case 14:
                case 15:
                    categorie = Categorie.Cadet;
                    break;
                case 16:
                case 17:
                case 18:
                    categorie = Categorie.Junior;
                    break;
            }

            return categorie;
        }
    }
}