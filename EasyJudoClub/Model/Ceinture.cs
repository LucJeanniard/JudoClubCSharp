using System.ComponentModel;

namespace EasyJudoClub
{
    public enum Ceinture
    {
        [Description("Blanche")]
        Blanche,
        [Description("Blanche 1 trait")]
        Blanche1Trait,
        [Description("Blanche 2 traits")]
        Blanche2Traits,
        [Description("Blanche et Jaune")]
        BlancheJaune,
        [Description("Jaune")]
        Jaune,
        [Description("Jaune et Orange")]
        JauneOrange,
        [Description("Orange")]
        Orange,
        [Description("Orange et Verte")]
        OrangeVerte,
        [Description("Verte")]
        Verte,
        [Description("Verte et Bleue")]
        VerteBleue,
        [Description("Bleue")]
        Bleue,
        [Description("Marron")]
        Marron,
        [Description("Noire")]
        Noire
    }
}