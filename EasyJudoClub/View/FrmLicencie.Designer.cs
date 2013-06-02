namespace EasyJudoClub
{
    partial class FrmLicencie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLicencie));
            this.gb_identite = new System.Windows.Forms.GroupBox();
            this.cbf_categorie = new EasyJudoClub.ComboBoxField();
            this.tbf_Age = new EasyJudoClub.TextBoxField();
            this.tbf_LicenceNumber = new EasyJudoClub.TextBoxField();
            this.df_dateNaissance = new EasyJudoClub.Controls.DateField();
            this.cbf_Ceinture = new EasyJudoClub.ComboBoxField();
            this.cbf_Sexe = new EasyJudoClub.ComboBoxField();
            this.tbf_Prenom = new EasyJudoClub.TextBoxField();
            this.tbf_Nom = new EasyJudoClub.TextBoxField();
            this.gb_adresse = new System.Windows.Forms.GroupBox();
            this.lbl_Commune = new System.Windows.Forms.Label();
            this.cbb_Commune = new System.Windows.Forms.ComboBox();
            this.tbf_TelFixe = new EasyJudoClub.TextBoxField();
            this.tbf_TelPortable = new EasyJudoClub.TextBoxField();
            this.tbf_Email = new EasyJudoClub.TextBoxField();
            this.tbf_CodePostal = new EasyJudoClub.TextBoxField();
            this.tbf_Adresse = new EasyJudoClub.TextBoxField();
            this.gb_parents = new System.Windows.Forms.GroupBox();
            this.tbf_PrenomMere = new EasyJudoClub.TextBoxField();
            this.tbf_NomMere = new EasyJudoClub.TextBoxField();
            this.tbf_PrenomPere = new EasyJudoClub.TextBoxField();
            this.tbf_NomPere = new EasyJudoClub.TextBoxField();
            this.gb_divers = new System.Windows.Forms.GroupBox();
            this.cbf_Arbitre = new EasyJudoClub.Controls.CheckBoxField();
            this.df_DateEntreeClub = new EasyJudoClub.Controls.DateField();
            this.cbf_CommissaireSportif = new EasyJudoClub.Controls.CheckBoxField();
            this.gb_reglement = new System.Windows.Forms.GroupBox();
            this.tbf_CarteMRA = new EasyJudoClub.TextBoxField();
            this.tbf_ChequeVacances = new EasyJudoClub.TextBoxField();
            this.tbf_Liquide = new EasyJudoClub.TextBoxField();
            this.tbf_ChequierJeune = new EasyJudoClub.TextBoxField();
            this.tbf_Cheque = new EasyJudoClub.TextBoxField();
            this.tbf_Cotisation = new EasyJudoClub.TextBoxField();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbf_TelMedecin = new EasyJudoClub.TextBoxField();
            this.tbf_NomMedecin = new EasyJudoClub.TextBoxField();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gb_identite.SuspendLayout();
            this.gb_adresse.SuspendLayout();
            this.gb_parents.SuspendLayout();
            this.gb_divers.SuspendLayout();
            this.gb_reglement.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_identite
            // 
            this.gb_identite.Controls.Add(this.cbf_categorie);
            this.gb_identite.Controls.Add(this.tbf_Age);
            this.gb_identite.Controls.Add(this.tbf_LicenceNumber);
            this.gb_identite.Controls.Add(this.df_dateNaissance);
            this.gb_identite.Controls.Add(this.cbf_Ceinture);
            this.gb_identite.Controls.Add(this.cbf_Sexe);
            this.gb_identite.Controls.Add(this.tbf_Prenom);
            this.gb_identite.Controls.Add(this.tbf_Nom);
            this.gb_identite.Location = new System.Drawing.Point(12, 12);
            this.gb_identite.Name = "gb_identite";
            this.gb_identite.Size = new System.Drawing.Size(629, 198);
            this.gb_identite.TabIndex = 0;
            this.gb_identite.TabStop = false;
            this.gb_identite.Text = "Identité";
            // 
            // cbf_categorie
            // 
            this.cbf_categorie.ForeColor = System.Drawing.Color.Black;
            this.cbf_categorie.Items = typeof(EasyJudoClub.Categorie);
            this.cbf_categorie.Label = "Categorie";
            this.cbf_categorie.Location = new System.Drawing.Point(308, 121);
            this.cbf_categorie.Name = "cbf_categorie";
            this.cbf_categorie.ReadOnly = false;
            this.cbf_categorie.Size = new System.Drawing.Size(309, 27);
            this.cbf_categorie.TabIndex = 7;
            this.cbf_categorie.Value = EasyJudoClub.Categorie.Benjamin;
            // 
            // tbf_Age
            // 
            this.tbf_Age.Label = "Age";
            this.tbf_Age.Location = new System.Drawing.Point(6, 121);
            this.tbf_Age.Name = "tbf_Age";
            this.tbf_Age.ReadOnly = true;
            this.tbf_Age.Size = new System.Drawing.Size(296, 27);
            this.tbf_Age.TabIndex = 6;
            // 
            // tbf_LicenceNumber
            // 
            this.tbf_LicenceNumber.Label = "Licence";
            this.tbf_LicenceNumber.Location = new System.Drawing.Point(308, 55);
            this.tbf_LicenceNumber.Name = "tbf_LicenceNumber";
            this.tbf_LicenceNumber.ReadOnly = false;
            this.tbf_LicenceNumber.Size = new System.Drawing.Size(309, 27);
            this.tbf_LicenceNumber.TabIndex = 3;
            this.tbf_LicenceNumber.Validated += new System.EventHandler(this.tbf_LicenceNumber_Validated);
            // 
            // df_dateNaissance
            // 
            this.df_dateNaissance.Date = new System.DateTime(2012, 7, 10, 7, 36, 23, 693);
            this.df_dateNaissance.Label = "Né(e) le";
            this.df_dateNaissance.Location = new System.Drawing.Point(6, 88);
            this.df_dateNaissance.Name = "df_dateNaissance";
            this.df_dateNaissance.Size = new System.Drawing.Size(296, 27);
            this.df_dateNaissance.TabIndex = 4;
            this.df_dateNaissance.Validated += new System.EventHandler(this.df_dateNaissance_Validated);
            // 
            // cbf_Ceinture
            // 
            this.cbf_Ceinture.Items = typeof(EasyJudoClub.Ceinture);
            this.cbf_Ceinture.Label = "Ceinture";
            this.cbf_Ceinture.Location = new System.Drawing.Point(308, 88);
            this.cbf_Ceinture.Name = "cbf_Ceinture";
            this.cbf_Ceinture.ReadOnly = true;
            this.cbf_Ceinture.Size = new System.Drawing.Size(190, 27);
            this.cbf_Ceinture.TabIndex = 5;
            this.cbf_Ceinture.Value = EasyJudoClub.Ceinture.Blanche;
            this.cbf_Ceinture.Validated += new System.EventHandler(this.cbf_Ceinture_Validated);
            // 
            // cbf_Sexe
            // 
            this.cbf_Sexe.Items = typeof(EasyJudoClub.Sexe);
            this.cbf_Sexe.Label = "Sexe";
            this.cbf_Sexe.Location = new System.Drawing.Point(6, 55);
            this.cbf_Sexe.Name = "cbf_Sexe";
            this.cbf_Sexe.ReadOnly = true;
            this.cbf_Sexe.Size = new System.Drawing.Size(190, 27);
            this.cbf_Sexe.TabIndex = 2;
            this.cbf_Sexe.Value = EasyJudoClub.Sexe.Masculin;
            this.cbf_Sexe.Validated += new System.EventHandler(this.cb_Sexe_Validated);
            // 
            // tbf_Prenom
            // 
            this.tbf_Prenom.Label = "Prénom";
            this.tbf_Prenom.Location = new System.Drawing.Point(308, 22);
            this.tbf_Prenom.Name = "tbf_Prenom";
            this.tbf_Prenom.ReadOnly = false;
            this.tbf_Prenom.Size = new System.Drawing.Size(309, 27);
            this.tbf_Prenom.TabIndex = 1;
            this.tbf_Prenom.Validated += new System.EventHandler(this.tbf_Prenom_Validated);
            // 
            // tbf_Nom
            // 
            this.tbf_Nom.Label = "Nom";
            this.tbf_Nom.Location = new System.Drawing.Point(6, 22);
            this.tbf_Nom.Name = "tbf_Nom";
            this.tbf_Nom.ReadOnly = false;
            this.tbf_Nom.Size = new System.Drawing.Size(296, 27);
            this.tbf_Nom.TabIndex = 0;
            this.tbf_Nom.Validated += new System.EventHandler(this.tbf_Nom_Validated);
            // 
            // gb_adresse
            // 
            this.gb_adresse.Controls.Add(this.lbl_Commune);
            this.gb_adresse.Controls.Add(this.cbb_Commune);
            this.gb_adresse.Controls.Add(this.tbf_TelFixe);
            this.gb_adresse.Controls.Add(this.tbf_TelPortable);
            this.gb_adresse.Controls.Add(this.tbf_Email);
            this.gb_adresse.Controls.Add(this.tbf_CodePostal);
            this.gb_adresse.Controls.Add(this.tbf_Adresse);
            this.gb_adresse.Location = new System.Drawing.Point(12, 325);
            this.gb_adresse.Name = "gb_adresse";
            this.gb_adresse.Size = new System.Drawing.Size(312, 241);
            this.gb_adresse.TabIndex = 2;
            this.gb_adresse.TabStop = false;
            this.gb_adresse.Text = "Adresse";
            // 
            // lbl_Commune
            // 
            this.lbl_Commune.AutoSize = true;
            this.lbl_Commune.Location = new System.Drawing.Point(6, 93);
            this.lbl_Commune.Name = "lbl_Commune";
            this.lbl_Commune.Size = new System.Drawing.Size(54, 13);
            this.lbl_Commune.TabIndex = 7;
            this.lbl_Commune.Text = "Commune";
            // 
            // cbb_Commune
            // 
            this.cbb_Commune.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbb_Commune.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbb_Commune.FormattingEnabled = true;
            this.cbb_Commune.Location = new System.Drawing.Point(79, 90);
            this.cbb_Commune.Name = "cbb_Commune";
            this.cbb_Commune.Size = new System.Drawing.Size(217, 21);
            this.cbb_Commune.TabIndex = 2;
            this.cbb_Commune.Validated += new System.EventHandler(this.cbb_Commune_Validated);
            // 
            // tbf_TelFixe
            // 
            this.tbf_TelFixe.Label = "Tel fixe";
            this.tbf_TelFixe.Location = new System.Drawing.Point(6, 171);
            this.tbf_TelFixe.Name = "tbf_TelFixe";
            this.tbf_TelFixe.ReadOnly = false;
            this.tbf_TelFixe.Size = new System.Drawing.Size(296, 27);
            this.tbf_TelFixe.TabIndex = 4;
            this.tbf_TelFixe.Validated += new System.EventHandler(this.tbf_TelFixe_Validated);
            // 
            // tbf_TelPortable
            // 
            this.tbf_TelPortable.Label = "Tel portable";
            this.tbf_TelPortable.Location = new System.Drawing.Point(6, 204);
            this.tbf_TelPortable.Name = "tbf_TelPortable";
            this.tbf_TelPortable.ReadOnly = false;
            this.tbf_TelPortable.Size = new System.Drawing.Size(296, 27);
            this.tbf_TelPortable.TabIndex = 5;
            this.tbf_TelPortable.Validated += new System.EventHandler(this.tbf_TelPortable_Validated);
            // 
            // tbf_Email
            // 
            this.tbf_Email.Label = "Email";
            this.tbf_Email.Location = new System.Drawing.Point(6, 138);
            this.tbf_Email.Name = "tbf_Email";
            this.tbf_Email.ReadOnly = false;
            this.tbf_Email.Size = new System.Drawing.Size(296, 27);
            this.tbf_Email.TabIndex = 3;
            this.tbf_Email.Validated += new System.EventHandler(this.tbf_email_Validated);
            // 
            // tbf_CodePostal
            // 
            this.tbf_CodePostal.Label = "Code postal";
            this.tbf_CodePostal.Location = new System.Drawing.Point(6, 55);
            this.tbf_CodePostal.Name = "tbf_CodePostal";
            this.tbf_CodePostal.ReadOnly = false;
            this.tbf_CodePostal.Size = new System.Drawing.Size(296, 27);
            this.tbf_CodePostal.TabIndex = 1;
            this.tbf_CodePostal.Validated += new System.EventHandler(this.tbf_CodePostal_Validated);
            // 
            // tbf_Adresse
            // 
            this.tbf_Adresse.Label = "Adresse";
            this.tbf_Adresse.Location = new System.Drawing.Point(6, 22);
            this.tbf_Adresse.Name = "tbf_Adresse";
            this.tbf_Adresse.ReadOnly = false;
            this.tbf_Adresse.Size = new System.Drawing.Size(296, 27);
            this.tbf_Adresse.TabIndex = 0;
            this.tbf_Adresse.Validated += new System.EventHandler(this.tbf_Adresse_Validated);
            // 
            // gb_parents
            // 
            this.gb_parents.Controls.Add(this.tbf_PrenomMere);
            this.gb_parents.Controls.Add(this.tbf_NomMere);
            this.gb_parents.Controls.Add(this.tbf_PrenomPere);
            this.gb_parents.Controls.Add(this.tbf_NomPere);
            this.gb_parents.Location = new System.Drawing.Point(12, 223);
            this.gb_parents.Name = "gb_parents";
            this.gb_parents.Size = new System.Drawing.Size(629, 96);
            this.gb_parents.TabIndex = 1;
            this.gb_parents.TabStop = false;
            this.gb_parents.Text = "Parents";
            // 
            // tbf_PrenomMere
            // 
            this.tbf_PrenomMere.Label = "Prénom Mère";
            this.tbf_PrenomMere.Location = new System.Drawing.Point(308, 52);
            this.tbf_PrenomMere.Name = "tbf_PrenomMere";
            this.tbf_PrenomMere.ReadOnly = false;
            this.tbf_PrenomMere.Size = new System.Drawing.Size(296, 27);
            this.tbf_PrenomMere.TabIndex = 3;
            this.tbf_PrenomMere.Validated += new System.EventHandler(this.tbf_PrenomMere_Validated);
            // 
            // tbf_NomMere
            // 
            this.tbf_NomMere.Label = "Nom Mère";
            this.tbf_NomMere.Location = new System.Drawing.Point(6, 52);
            this.tbf_NomMere.Name = "tbf_NomMere";
            this.tbf_NomMere.ReadOnly = false;
            this.tbf_NomMere.Size = new System.Drawing.Size(296, 27);
            this.tbf_NomMere.TabIndex = 2;
            this.tbf_NomMere.Validated += new System.EventHandler(this.tbf_NomMere_Validated);
            // 
            // tbf_PrenomPere
            // 
            this.tbf_PrenomPere.Label = "Prénom Père";
            this.tbf_PrenomPere.Location = new System.Drawing.Point(308, 19);
            this.tbf_PrenomPere.Name = "tbf_PrenomPere";
            this.tbf_PrenomPere.ReadOnly = false;
            this.tbf_PrenomPere.Size = new System.Drawing.Size(296, 27);
            this.tbf_PrenomPere.TabIndex = 1;
            this.tbf_PrenomPere.Validated += new System.EventHandler(this.tbf_PrenomPere_Validated);
            // 
            // tbf_NomPere
            // 
            this.tbf_NomPere.Label = "Nom Père";
            this.tbf_NomPere.Location = new System.Drawing.Point(6, 19);
            this.tbf_NomPere.Name = "tbf_NomPere";
            this.tbf_NomPere.ReadOnly = false;
            this.tbf_NomPere.Size = new System.Drawing.Size(296, 27);
            this.tbf_NomPere.TabIndex = 0;
            this.tbf_NomPere.Validated += new System.EventHandler(this.tbf_NomPere_Validated);
            // 
            // gb_divers
            // 
            this.gb_divers.Controls.Add(this.cbf_Arbitre);
            this.gb_divers.Controls.Add(this.df_DateEntreeClub);
            this.gb_divers.Controls.Add(this.cbf_CommissaireSportif);
            this.gb_divers.Location = new System.Drawing.Point(647, 12);
            this.gb_divers.Name = "gb_divers";
            this.gb_divers.Size = new System.Drawing.Size(331, 97);
            this.gb_divers.TabIndex = 4;
            this.gb_divers.TabStop = false;
            this.gb_divers.Text = "Divers";
            // 
            // cbf_Arbitre
            // 
            this.cbf_Arbitre.Label = "Arbitre";
            this.cbf_Arbitre.Location = new System.Drawing.Point(190, 22);
            this.cbf_Arbitre.Name = "cbf_Arbitre";
            this.cbf_Arbitre.Size = new System.Drawing.Size(92, 27);
            this.cbf_Arbitre.TabIndex = 1;
            this.cbf_Arbitre.Value = false;
            this.cbf_Arbitre.Validated += new System.EventHandler(this.cbf_Arbitre_Validated);
            // 
            // df_DateEntreeClub
            // 
            this.df_DateEntreeClub.Date = new System.DateTime(2012, 7, 10, 7, 36, 23, 693);
            this.df_DateEntreeClub.Label = "Date entrée au club";
            this.df_DateEntreeClub.Location = new System.Drawing.Point(6, 55);
            this.df_DateEntreeClub.Name = "df_DateEntreeClub";
            this.df_DateEntreeClub.Size = new System.Drawing.Size(315, 27);
            this.df_DateEntreeClub.TabIndex = 2;
            this.df_DateEntreeClub.Validated += new System.EventHandler(this.df_DateEntreeClub_Validated);
            // 
            // cbf_CommissaireSportif
            // 
            this.cbf_CommissaireSportif.Label = "Commissaire sportif";
            this.cbf_CommissaireSportif.Location = new System.Drawing.Point(6, 22);
            this.cbf_CommissaireSportif.Name = "cbf_CommissaireSportif";
            this.cbf_CommissaireSportif.Size = new System.Drawing.Size(127, 27);
            this.cbf_CommissaireSportif.TabIndex = 0;
            this.cbf_CommissaireSportif.Value = false;
            this.cbf_CommissaireSportif.Validated += new System.EventHandler(this.cbf_CommissaireSportif_Validated);
            // 
            // gb_reglement
            // 
            this.gb_reglement.Controls.Add(this.tbf_CarteMRA);
            this.gb_reglement.Controls.Add(this.tbf_ChequeVacances);
            this.gb_reglement.Controls.Add(this.tbf_Liquide);
            this.gb_reglement.Controls.Add(this.tbf_ChequierJeune);
            this.gb_reglement.Controls.Add(this.tbf_Cheque);
            this.gb_reglement.Controls.Add(this.tbf_Cotisation);
            this.gb_reglement.Location = new System.Drawing.Point(336, 325);
            this.gb_reglement.Name = "gb_reglement";
            this.gb_reglement.Size = new System.Drawing.Size(311, 241);
            this.gb_reglement.TabIndex = 3;
            this.gb_reglement.TabStop = false;
            this.gb_reglement.Text = "Règlement";
            // 
            // tbf_CarteMRA
            // 
            this.tbf_CarteMRA.Label = "Carte MRA";
            this.tbf_CarteMRA.Location = new System.Drawing.Point(6, 202);
            this.tbf_CarteMRA.Name = "tbf_CarteMRA";
            this.tbf_CarteMRA.ReadOnly = false;
            this.tbf_CarteMRA.Size = new System.Drawing.Size(287, 28);
            this.tbf_CarteMRA.TabIndex = 13;
            this.tbf_CarteMRA.Validated += new System.EventHandler(this.tbf_CarteMRA_Validated);
            // 
            // tbf_ChequeVacances
            // 
            this.tbf_ChequeVacances.Label = "Ch. vacances";
            this.tbf_ChequeVacances.Location = new System.Drawing.Point(6, 134);
            this.tbf_ChequeVacances.Name = "tbf_ChequeVacances";
            this.tbf_ChequeVacances.ReadOnly = false;
            this.tbf_ChequeVacances.Size = new System.Drawing.Size(287, 28);
            this.tbf_ChequeVacances.TabIndex = 11;
            this.tbf_ChequeVacances.Validated += new System.EventHandler(this.tbf_ChequeVacances_Validated);
            // 
            // tbf_Liquide
            // 
            this.tbf_Liquide.Label = "Liquide";
            this.tbf_Liquide.Location = new System.Drawing.Point(6, 100);
            this.tbf_Liquide.Name = "tbf_Liquide";
            this.tbf_Liquide.ReadOnly = false;
            this.tbf_Liquide.Size = new System.Drawing.Size(287, 28);
            this.tbf_Liquide.TabIndex = 10;
            this.tbf_Liquide.Validated += new System.EventHandler(this.tbf_Liquide_Validated);
            // 
            // tbf_ChequierJeune
            // 
            this.tbf_ChequierJeune.Label = "Ch. jeune";
            this.tbf_ChequierJeune.Location = new System.Drawing.Point(6, 168);
            this.tbf_ChequierJeune.Name = "tbf_ChequierJeune";
            this.tbf_ChequierJeune.ReadOnly = false;
            this.tbf_ChequierJeune.Size = new System.Drawing.Size(287, 28);
            this.tbf_ChequierJeune.TabIndex = 12;
            this.tbf_ChequierJeune.Validated += new System.EventHandler(this.tbf_ChequeJeune_Validated);
            // 
            // tbf_Cheque
            // 
            this.tbf_Cheque.Label = "Chèque";
            this.tbf_Cheque.Location = new System.Drawing.Point(6, 66);
            this.tbf_Cheque.Name = "tbf_Cheque";
            this.tbf_Cheque.ReadOnly = false;
            this.tbf_Cheque.Size = new System.Drawing.Size(287, 28);
            this.tbf_Cheque.TabIndex = 9;
            this.tbf_Cheque.Validated += new System.EventHandler(this.tbf_Cheque_Validated);
            // 
            // tbf_Cotisation
            // 
            this.tbf_Cotisation.Label = "Cotisation";
            this.tbf_Cotisation.Location = new System.Drawing.Point(6, 33);
            this.tbf_Cotisation.Name = "tbf_Cotisation";
            this.tbf_Cotisation.ReadOnly = true;
            this.tbf_Cotisation.Size = new System.Drawing.Size(287, 27);
            this.tbf_Cotisation.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbf_TelMedecin);
            this.groupBox1.Controls.Add(this.tbf_NomMedecin);
            this.groupBox1.Location = new System.Drawing.Point(647, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 93);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Certificat médical";
            // 
            // tbf_TelMedecin
            // 
            this.tbf_TelMedecin.Label = "Tel";
            this.tbf_TelMedecin.Location = new System.Drawing.Point(6, 55);
            this.tbf_TelMedecin.Name = "tbf_TelMedecin";
            this.tbf_TelMedecin.ReadOnly = false;
            this.tbf_TelMedecin.Size = new System.Drawing.Size(285, 27);
            this.tbf_TelMedecin.TabIndex = 1;
            this.tbf_TelMedecin.Validated += new System.EventHandler(this.tbf_TelMedecin_Validated);
            // 
            // tbf_NomMedecin
            // 
            this.tbf_NomMedecin.Label = "Nom";
            this.tbf_NomMedecin.Location = new System.Drawing.Point(6, 22);
            this.tbf_NomMedecin.Name = "tbf_NomMedecin";
            this.tbf_NomMedecin.ReadOnly = false;
            this.tbf_NomMedecin.Size = new System.Drawing.Size(279, 27);
            this.tbf_NomMedecin.TabIndex = 0;
            this.tbf_NomMedecin.Validated += new System.EventHandler(this.tbf_NomMedecin_Validated);
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Location = new System.Drawing.Point(664, 534);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(143, 32);
            this.btn_OK.TabIndex = 6;
            this.btn_OK.Text = "Enregister";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(841, 534);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(143, 32);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "Quitter";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(678, 224);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 294);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLicencie
            // 
            this.AcceptButton = this.btn_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(996, 578);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_reglement);
            this.Controls.Add(this.gb_divers);
            this.Controls.Add(this.gb_parents);
            this.Controls.Add(this.gb_adresse);
            this.Controls.Add(this.gb_identite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmLicencie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Membre";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_licencie_FormClosing);
            this.gb_identite.ResumeLayout(false);
            this.gb_adresse.ResumeLayout(false);
            this.gb_adresse.PerformLayout();
            this.gb_parents.ResumeLayout(false);
            this.gb_divers.ResumeLayout(false);
            this.gb_reglement.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_identite;
        private TextBoxField tbf_Prenom;
        private TextBoxField tbf_Nom;
        private System.Windows.Forms.GroupBox gb_adresse;
        private TextBoxField tbf_TelFixe;
        private TextBoxField tbf_TelPortable;
        private TextBoxField tbf_Email;
        private TextBoxField tbf_CodePostal;
        private TextBoxField tbf_Adresse;
        private System.Windows.Forms.GroupBox gb_parents;
        private TextBoxField tbf_PrenomMere;
        private TextBoxField tbf_NomMere;
        private TextBoxField tbf_PrenomPere;
        private TextBoxField tbf_NomPere;
        private ComboBoxField cbf_Sexe;
        private Controls.DateField df_dateNaissance;
        private Controls.DateField df_DateEntreeClub;
        private TextBoxField tbf_LicenceNumber;
        private ComboBoxField cbf_Ceinture;
        private Controls.CheckBoxField cbf_Arbitre;
        private TextBoxField tbf_Age;
        private ComboBoxField cbf_categorie;
        private System.Windows.Forms.GroupBox gb_divers;
        private Controls.CheckBoxField cbf_CommissaireSportif;
        private System.Windows.Forms.GroupBox gb_reglement;
        private System.Windows.Forms.GroupBox groupBox1;
        private TextBoxField tbf_TelMedecin;
        private TextBoxField tbf_NomMedecin;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private TextBoxField tbf_Cotisation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbb_Commune;
        private System.Windows.Forms.Label lbl_Commune;
        private TextBoxField tbf_CarteMRA;
        private TextBoxField tbf_ChequeVacances;
        private TextBoxField tbf_Liquide;
        private TextBoxField tbf_ChequierJeune;
        private TextBoxField tbf_Cheque;
    }
}