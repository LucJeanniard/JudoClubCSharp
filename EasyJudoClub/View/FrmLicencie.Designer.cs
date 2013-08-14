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
            this.tbf_CodePostal = new EasyJudoClub.TextBoxField();
            this.tbf_Adresse = new EasyJudoClub.TextBoxField();
            this.gb_mère = new System.Windows.Forms.GroupBox();
            this.tbf_TelFixeMere = new EasyJudoClub.TextBoxField();
            this.tbf_TelPortableMere = new EasyJudoClub.TextBoxField();
            this.tbf_EmailMere = new EasyJudoClub.TextBoxField();
            this.tbf_PrenomMere = new EasyJudoClub.TextBoxField();
            this.tbf_NomMere = new EasyJudoClub.TextBoxField();
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
            this.btn_print = new System.Windows.Forms.Button();
            this.gb_père = new System.Windows.Forms.GroupBox();
            this.tbf_TelFixePere = new EasyJudoClub.TextBoxField();
            this.tbf_TelPortablePere = new EasyJudoClub.TextBoxField();
            this.tbf_EmailPere = new EasyJudoClub.TextBoxField();
            this.tbf_PrenomPere = new EasyJudoClub.TextBoxField();
            this.tbf_NomPere = new EasyJudoClub.TextBoxField();
            this.gb_identite.SuspendLayout();
            this.gb_adresse.SuspendLayout();
            this.gb_mère.SuspendLayout();
            this.gb_divers.SuspendLayout();
            this.gb_reglement.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gb_père.SuspendLayout();
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
            this.gb_identite.Size = new System.Drawing.Size(629, 168);
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
            this.gb_adresse.Controls.Add(this.tbf_CodePostal);
            this.gb_adresse.Controls.Add(this.tbf_Adresse);
            this.gb_adresse.Location = new System.Drawing.Point(12, 407);
            this.gb_adresse.Name = "gb_adresse";
            this.gb_adresse.Size = new System.Drawing.Size(306, 241);
            this.gb_adresse.TabIndex = 3;
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
            // gb_mère
            // 
            this.gb_mère.Controls.Add(this.tbf_TelFixeMere);
            this.gb_mère.Controls.Add(this.tbf_TelPortableMere);
            this.gb_mère.Controls.Add(this.tbf_EmailMere);
            this.gb_mère.Controls.Add(this.tbf_PrenomMere);
            this.gb_mère.Controls.Add(this.tbf_NomMere);
            this.gb_mère.Location = new System.Drawing.Point(12, 195);
            this.gb_mère.Name = "gb_mère";
            this.gb_mère.Size = new System.Drawing.Size(306, 199);
            this.gb_mère.TabIndex = 1;
            this.gb_mère.TabStop = false;
            this.gb_mère.Text = "Mère";
            // 
            // tbf_TelFixeMere
            // 
            this.tbf_TelFixeMere.Label = "Tel fixe";
            this.tbf_TelFixeMere.Location = new System.Drawing.Point(6, 121);
            this.tbf_TelFixeMere.Name = "tbf_TelFixeMere";
            this.tbf_TelFixeMere.ReadOnly = false;
            this.tbf_TelFixeMere.Size = new System.Drawing.Size(296, 27);
            this.tbf_TelFixeMere.TabIndex = 3;
            this.tbf_TelFixeMere.Validated += new System.EventHandler(this.tbf_TelFixeMere_Validated);
            // 
            // tbf_TelPortableMere
            // 
            this.tbf_TelPortableMere.Label = "Tel portable";
            this.tbf_TelPortableMere.Location = new System.Drawing.Point(6, 154);
            this.tbf_TelPortableMere.Name = "tbf_TelPortableMere";
            this.tbf_TelPortableMere.ReadOnly = false;
            this.tbf_TelPortableMere.Size = new System.Drawing.Size(296, 27);
            this.tbf_TelPortableMere.TabIndex = 4;
            this.tbf_TelPortableMere.Validated += new System.EventHandler(this.tbf_TelPortableMere_Validated);
            // 
            // tbf_EmailMere
            // 
            this.tbf_EmailMere.Label = "Email";
            this.tbf_EmailMere.Location = new System.Drawing.Point(6, 88);
            this.tbf_EmailMere.Name = "tbf_EmailMere";
            this.tbf_EmailMere.ReadOnly = false;
            this.tbf_EmailMere.Size = new System.Drawing.Size(296, 27);
            this.tbf_EmailMere.TabIndex = 2;
            this.tbf_EmailMere.Validated += new System.EventHandler(this.tbf_EmailMere_Validated);
            // 
            // tbf_PrenomMere
            // 
            this.tbf_PrenomMere.Label = "Prénom Mère";
            this.tbf_PrenomMere.Location = new System.Drawing.Point(6, 55);
            this.tbf_PrenomMere.Name = "tbf_PrenomMere";
            this.tbf_PrenomMere.ReadOnly = false;
            this.tbf_PrenomMere.Size = new System.Drawing.Size(296, 27);
            this.tbf_PrenomMere.TabIndex = 1;
            this.tbf_PrenomMere.Validated += new System.EventHandler(this.tbf_PrenomMere_Validated);
            // 
            // tbf_NomMere
            // 
            this.tbf_NomMere.Label = "Nom Mère";
            this.tbf_NomMere.Location = new System.Drawing.Point(6, 22);
            this.tbf_NomMere.Name = "tbf_NomMere";
            this.tbf_NomMere.ReadOnly = false;
            this.tbf_NomMere.Size = new System.Drawing.Size(296, 27);
            this.tbf_NomMere.TabIndex = 0;
            this.tbf_NomMere.Validated += new System.EventHandler(this.tbf_NomMere_Validated);
            // 
            // gb_divers
            // 
            this.gb_divers.Controls.Add(this.cbf_Arbitre);
            this.gb_divers.Controls.Add(this.df_DateEntreeClub);
            this.gb_divers.Controls.Add(this.cbf_CommissaireSportif);
            this.gb_divers.Location = new System.Drawing.Point(647, 12);
            this.gb_divers.Name = "gb_divers";
            this.gb_divers.Size = new System.Drawing.Size(331, 97);
            this.gb_divers.TabIndex = 5;
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
            this.gb_reglement.Location = new System.Drawing.Point(330, 407);
            this.gb_reglement.Name = "gb_reglement";
            this.gb_reglement.Size = new System.Drawing.Size(311, 241);
            this.gb_reglement.TabIndex = 4;
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
            this.tbf_CarteMRA.TabIndex = 5;
            this.tbf_CarteMRA.Validated += new System.EventHandler(this.tbf_CarteMRA_Validated);
            // 
            // tbf_ChequeVacances
            // 
            this.tbf_ChequeVacances.Label = "Ch. vacances";
            this.tbf_ChequeVacances.Location = new System.Drawing.Point(6, 134);
            this.tbf_ChequeVacances.Name = "tbf_ChequeVacances";
            this.tbf_ChequeVacances.ReadOnly = false;
            this.tbf_ChequeVacances.Size = new System.Drawing.Size(287, 28);
            this.tbf_ChequeVacances.TabIndex = 3;
            this.tbf_ChequeVacances.Validated += new System.EventHandler(this.tbf_ChequeVacances_Validated);
            // 
            // tbf_Liquide
            // 
            this.tbf_Liquide.Label = "Liquide";
            this.tbf_Liquide.Location = new System.Drawing.Point(6, 100);
            this.tbf_Liquide.Name = "tbf_Liquide";
            this.tbf_Liquide.ReadOnly = false;
            this.tbf_Liquide.Size = new System.Drawing.Size(287, 28);
            this.tbf_Liquide.TabIndex = 2;
            this.tbf_Liquide.Validated += new System.EventHandler(this.tbf_Liquide_Validated);
            // 
            // tbf_ChequierJeune
            // 
            this.tbf_ChequierJeune.Label = "Ch. jeune";
            this.tbf_ChequierJeune.Location = new System.Drawing.Point(6, 168);
            this.tbf_ChequierJeune.Name = "tbf_ChequierJeune";
            this.tbf_ChequierJeune.ReadOnly = false;
            this.tbf_ChequierJeune.Size = new System.Drawing.Size(287, 28);
            this.tbf_ChequierJeune.TabIndex = 4;
            this.tbf_ChequierJeune.Validated += new System.EventHandler(this.tbf_ChequeJeune_Validated);
            // 
            // tbf_Cheque
            // 
            this.tbf_Cheque.Label = "Chèque";
            this.tbf_Cheque.Location = new System.Drawing.Point(6, 66);
            this.tbf_Cheque.Name = "tbf_Cheque";
            this.tbf_Cheque.ReadOnly = false;
            this.tbf_Cheque.Size = new System.Drawing.Size(287, 28);
            this.tbf_Cheque.TabIndex = 1;
            this.tbf_Cheque.Validated += new System.EventHandler(this.tbf_Cheque_Validated);
            // 
            // tbf_Cotisation
            // 
            this.tbf_Cotisation.Label = "Cotisation";
            this.tbf_Cotisation.Location = new System.Drawing.Point(6, 33);
            this.tbf_Cotisation.Name = "tbf_Cotisation";
            this.tbf_Cotisation.ReadOnly = true;
            this.tbf_Cotisation.Size = new System.Drawing.Size(287, 27);
            this.tbf_Cotisation.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbf_TelMedecin);
            this.groupBox1.Controls.Add(this.tbf_NomMedecin);
            this.groupBox1.Location = new System.Drawing.Point(647, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 93);
            this.groupBox1.TabIndex = 6;
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
            this.tbf_NomMedecin.Size = new System.Drawing.Size(285, 27);
            this.tbf_NomMedecin.TabIndex = 0;
            this.tbf_NomMedecin.Validated += new System.EventHandler(this.tbf_NomMedecin_Validated);
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Location = new System.Drawing.Point(664, 534);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(97, 32);
            this.btn_OK.TabIndex = 7;
            this.btn_OK.Text = "Enregister";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(774, 534);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(96, 32);
            this.btn_Cancel.TabIndex = 8;
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
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(881, 534);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(97, 32);
            this.btn_print.TabIndex = 9;
            this.btn_print.Text = "Imprimer";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // gb_père
            // 
            this.gb_père.Controls.Add(this.tbf_TelFixePere);
            this.gb_père.Controls.Add(this.tbf_TelPortablePere);
            this.gb_père.Controls.Add(this.tbf_EmailPere);
            this.gb_père.Controls.Add(this.tbf_PrenomPere);
            this.gb_père.Controls.Add(this.tbf_NomPere);
            this.gb_père.Location = new System.Drawing.Point(330, 192);
            this.gb_père.Name = "gb_père";
            this.gb_père.Size = new System.Drawing.Size(311, 199);
            this.gb_père.TabIndex = 2;
            this.gb_père.TabStop = false;
            this.gb_père.Text = "Père";
            // 
            // tbf_TelFixePere
            // 
            this.tbf_TelFixePere.Label = "Tel fixe";
            this.tbf_TelFixePere.Location = new System.Drawing.Point(6, 124);
            this.tbf_TelFixePere.Name = "tbf_TelFixePere";
            this.tbf_TelFixePere.ReadOnly = false;
            this.tbf_TelFixePere.Size = new System.Drawing.Size(296, 27);
            this.tbf_TelFixePere.TabIndex = 3;
            this.tbf_TelFixePere.Validated += new System.EventHandler(this.tbf_TelFixePere_Validated);
            // 
            // tbf_TelPortablePere
            // 
            this.tbf_TelPortablePere.Label = "Tel portable";
            this.tbf_TelPortablePere.Location = new System.Drawing.Point(6, 157);
            this.tbf_TelPortablePere.Name = "tbf_TelPortablePere";
            this.tbf_TelPortablePere.ReadOnly = false;
            this.tbf_TelPortablePere.Size = new System.Drawing.Size(296, 27);
            this.tbf_TelPortablePere.TabIndex = 4;
            this.tbf_TelPortablePere.Validated += new System.EventHandler(this.tbf_TelPortablePere_Validated);
            // 
            // tbf_EmailPere
            // 
            this.tbf_EmailPere.Label = "Email";
            this.tbf_EmailPere.Location = new System.Drawing.Point(6, 91);
            this.tbf_EmailPere.Name = "tbf_EmailPere";
            this.tbf_EmailPere.ReadOnly = false;
            this.tbf_EmailPere.Size = new System.Drawing.Size(296, 27);
            this.tbf_EmailPere.TabIndex = 2;
            this.tbf_EmailPere.Validated += new System.EventHandler(this.tbf_EmailPere_Validated);
            // 
            // tbf_PrenomPere
            // 
            this.tbf_PrenomPere.Label = "Prénom Père";
            this.tbf_PrenomPere.Location = new System.Drawing.Point(6, 58);
            this.tbf_PrenomPere.Name = "tbf_PrenomPere";
            this.tbf_PrenomPere.ReadOnly = false;
            this.tbf_PrenomPere.Size = new System.Drawing.Size(296, 27);
            this.tbf_PrenomPere.TabIndex = 1;
            this.tbf_PrenomPere.Validated += new System.EventHandler(this.tbf_PrenomPere_Validated);
            // 
            // tbf_NomPere
            // 
            this.tbf_NomPere.Label = "Nom Père";
            this.tbf_NomPere.Location = new System.Drawing.Point(6, 25);
            this.tbf_NomPere.Name = "tbf_NomPere";
            this.tbf_NomPere.ReadOnly = false;
            this.tbf_NomPere.Size = new System.Drawing.Size(296, 27);
            this.tbf_NomPere.TabIndex = 0;
            this.tbf_NomPere.Validated += new System.EventHandler(this.tbf_NomPere_Validated);
            // 
            // FrmLicencie
            // 
            this.AcceptButton = this.btn_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(996, 661);
            this.Controls.Add(this.gb_père);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_reglement);
            this.Controls.Add(this.gb_divers);
            this.Controls.Add(this.gb_mère);
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
            this.gb_mère.ResumeLayout(false);
            this.gb_divers.ResumeLayout(false);
            this.gb_reglement.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gb_père.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_identite;
        private TextBoxField tbf_Prenom;
        private TextBoxField tbf_Nom;
        private System.Windows.Forms.GroupBox gb_adresse;
        private TextBoxField tbf_CodePostal;
        private TextBoxField tbf_Adresse;
        private System.Windows.Forms.GroupBox gb_mère;
        private TextBoxField tbf_PrenomMere;
        private TextBoxField tbf_NomMere;
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
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.GroupBox gb_père;
        private TextBoxField tbf_TelFixePere;
        private TextBoxField tbf_TelPortablePere;
        private TextBoxField tbf_EmailPere;
        private TextBoxField tbf_PrenomPere;
        private TextBoxField tbf_NomPere;
        private TextBoxField tbf_TelFixeMere;
        private TextBoxField tbf_TelPortableMere;
        private TextBoxField tbf_EmailMere;
    }
}