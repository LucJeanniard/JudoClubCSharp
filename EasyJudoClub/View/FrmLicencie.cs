using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using EasyJudoClub.Model;
using EasyJudoClub.Utils;

namespace EasyJudoClub
{
    public partial class FrmLicencie : Form
    {
        public FrmLicencie()
        {
            InitializeComponent();
        }
  
        private Member _member;

        public Member Member
        {
            get 
            {
                return _member;
            }
            set 
            {
                var memberOriginal = value;
                _member = ObjectCopier.Clone<Member>(memberOriginal);
                UpdateForm();
            }
        }

        public void PrepareForPrinting()
        {
            btn_OK.Visible = false;
            btn_Cancel.Visible = false;
            btn_print.Visible = false;
            tbf_Cotisation.Text = "";
            cbf_categorie.ClearText();
            cbf_Ceinture.ClearText();
        }

        private void UpdateForm()
        {
            tbf_Adresse.Text = _member.Adresse;
            tbf_CodePostal.Text = _member.CodePostal;
            cbb_Commune.Text = _member.Commune;
            cbb_Commune.Items.Clear();
            cbb_Commune.Items.AddRange(CommunesHelper.GetCommunes(_member.CodePostal).ToArray());
            cbb_Commune.SelectedItem = _member.Commune;

            tbf_Nom.Text = _member.Nom;
            tbf_Prenom.Text = _member.Prenom;
            
            tbf_NomPere.Text = _member.NomPere;
            tbf_PrenomPere.Text = _member.PrenomPere;
            tbf_NomMere.Text = _member.NomMere;
            tbf_PrenomMere.Text = _member.PrenomMere;
            
            tbf_TelFixePere.Text = _member.TelPere;
            tbf_TelPortablePere.Text = _member.TelPortablePere;
            tbf_EmailPere.Text = _member.EmailPere;

            tbf_TelFixeMere.Text = _member.TelMere;
            tbf_TelPortableMere.Text = _member.TelPortableMere;
            tbf_EmailMere.Text = _member.EmailMere;

            tbf_LicenceNumber.Text = _member.LicenseNumber;
            tbf_Age.Text = _member.Age.ToString();
            df_dateNaissance.Date = _member.DateDeNaissance;
            df_DateEntreeClub.Date = _member.DateEntreeClub;
          
            cbf_Ceinture.Value = _member.Ceinture;
            cbf_Sexe.Value = _member.Sexe;
            cbf_categorie.Value = _member.Categorie;
           
            cbf_CommissaireSportif.Value = _member.CommisaireSportif;
            cbf_Arbitre.Value = _member.Arbitre;

            tbf_NomMedecin.Text = _member.CertificatMedicalNomMedecin;
            tbf_TelMedecin.Text = _member.CertificatMedicalTelMedecin;

            tbf_Cotisation.Text = _member.CoutCotisation.ToString();
            tbf_Liquide.Text = _member.MoyenPaiementsLiquide;
            tbf_Cheque.Text = _member.MoyenPaiementsCheque;
            tbf_ChequeVacances.Text = _member.MoyenPaiementsChequesVacances;
            tbf_ChequierJeune.Text = _member.MoyenPaiementsChequierJeune;
            tbf_CarteMRA.Text = _member.MoyenPaiementsCarteMRA;
        }

        private void form_licencie_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.None)
                e.Cancel = MessageBox.Show("Voulez-vous quitter sans sauver?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No;
        }

        private void df_dateNaissance_Validated(object sender, EventArgs e)
        {
            Member.DateDeNaissance = df_dateNaissance.Date;
            UpdateForm();  // Age, Categorie
        }

        private void tbf_Nom_Validated(object sender, EventArgs e)
        {
            Member.Nom = tbf_Nom.Text;
        }

        private void tbf_Prenom_Validated(object sender, EventArgs e)
        {
            Member.Prenom = tbf_Prenom.Text;
        }

        private void cb_Sexe_Validated(object sender, EventArgs e)
        {
            Member.Sexe = (Sexe) cbf_Sexe.Value;
        }

        private void tbf_LicenceNumber_Validated(object sender, EventArgs e)
        {
            Member.LicenseNumber = tbf_LicenceNumber.Text;
        }

        private void cbf_Ceinture_Validated(object sender, EventArgs e)
        {
            Member.Ceinture = (Ceinture) cbf_Ceinture.Value;
        }

        private void tbf_Adresse_Validated(object sender, EventArgs e)
        {
            Member.Adresse = tbf_Adresse.Text;
        }

        private void tbf_CodePostal_Validated(object sender, EventArgs e)
        {
            Member.CodePostal = tbf_CodePostal.Text;
            
            cbb_Commune.Items.Clear();

            if (String.IsNullOrEmpty(Member.CodePostal) || String.IsNullOrWhiteSpace(Member.CodePostal))
                cbb_Commune.Items.AddRange(CommunesHelper.GetAllCommunes().ToArray());
            else
                cbb_Commune.Items.AddRange(CommunesHelper.GetCommunes(Member.CodePostal).ToArray());

            cbb_Commune.SelectedItem = "";
        }

        private void cbb_Commune_Validated(object sender, EventArgs e)
        {
            if ((cbb_Commune.SelectedItem != null) && !String.IsNullOrEmpty( cbb_Commune.SelectedItem.ToString() ))
            {
                Member.Commune = cbb_Commune.SelectedItem.ToString();
                Member.CodePostal = CommunesHelper.CommuneCodePostal.Where(_ => _.Key == Member.Commune).FirstOrDefault().Value.ToString();
            }
            else
            {
                Member.Commune = "";
                Member.CodePostal = "";
            }

            UpdateForm();  //cotisation
        }

        private void tbf_EmailPere_Validated(object sender, EventArgs e)
        {
            Member.EmailPere = tbf_EmailPere.Text;
        }

        private void tbf_TelFixePere_Validated(object sender, EventArgs e)
        {
            Member.TelPere = tbf_TelFixePere.Text;
        }

        private void tbf_TelPortablePere_Validated(object sender, EventArgs e)
        {
            Member.TelPortablePere = tbf_TelPortablePere.Text;
        }

        private void tbf_EmailMere_Validated(object sender, EventArgs e)
        {
            Member.EmailMere = tbf_EmailMere.Text;
        }

        private void tbf_TelFixeMere_Validated(object sender, EventArgs e)
        {
            Member.TelMere = tbf_TelFixeMere.Text;
        }

        private void tbf_TelPortableMere_Validated(object sender, EventArgs e)
        {
            Member.TelPortableMere = tbf_TelPortableMere.Text;
        }

        private void tbf_NomPere_Validated(object sender, EventArgs e)
        {
            Member.NomPere = tbf_NomPere.Text;
        }

        private void tbf_PrenomPere_Validated(object sender, EventArgs e)
        {
            Member.PrenomPere = tbf_PrenomPere.Text;
        }

        private void tbf_NomMere_Validated(object sender, EventArgs e)
        {
            Member.NomMere = tbf_NomMere.Text;
        }

        private void tbf_PrenomMere_Validated(object sender, EventArgs e)
        {
            Member.PrenomMere = tbf_PrenomMere.Text;
        }

        private void cbf_CommissaireSportif_Validated(object sender, EventArgs e)
        {
            Member.CommisaireSportif = cbf_CommissaireSportif.Value;
        }

        private void cbf_Arbitre_Validated(object sender, EventArgs e)
        {
            Member.Arbitre = cbf_Arbitre.Value;
        }

        private void df_DateEntreeClub_Validated(object sender, EventArgs e)
        {
            Member.DateEntreeClub = df_DateEntreeClub.Date;
        }

        private void tbf_NomMedecin_Validated(object sender, EventArgs e)
        {
            Member.CertificatMedicalNomMedecin = tbf_NomMedecin.Text;
        }

        private void tbf_TelMedecin_Validated(object sender, EventArgs e)
        {
            Member.CertificatMedicalTelMedecin = tbf_TelMedecin.Text;
        }

        private void tbf_Cheque_Validated(object sender, EventArgs e)
        {
            Member.MoyenPaiementsCheque = tbf_Cheque.Text;
        }

        private void tbf_Liquide_Validated(object sender, EventArgs e)
        {
            Member.MoyenPaiementsLiquide = tbf_Liquide.Text;
        }

        private void tbf_ChequeVacances_Validated(object sender, EventArgs e)
        {
            Member.MoyenPaiementsChequesVacances = tbf_ChequeVacances.Text;
        }

        private void tbf_ChequeJeune_Validated(object sender, EventArgs e)
        {
            Member.MoyenPaiementsChequierJeune = tbf_ChequierJeune.Text;
        }

        private void tbf_CarteMRA_Validated(object sender, EventArgs e)
        {
            Member.MoyenPaiementsCarteMRA = tbf_CarteMRA.Text;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Member.Nom) || String.IsNullOrEmpty(Member.Prenom))
            {
                MessageBox.Show(this, "Le nom et le prénom ne peuvent être vides" ,"Erreur", MessageBoxButtons.OK);
                this.DialogResult = DialogResult.None;
            }
            else
                this.DialogResult = DialogResult.OK;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            MemberPrinter.Print(Member);
        }


    }
}
