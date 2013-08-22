using gfoidl.Windows.Forms;

namespace EasyJudoClub
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.dataGridMembers = new gfoidl.Windows.Forms.gfDataGridView();
            this.memberBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_Options = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Colonnes = new System.Windows.Forms.ToolStripMenuItem();
            this.creerUneSauvegardeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvelleSaisonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatus_members = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_clearFilter = new System.Windows.Forms.Button();
            this.cb_2012_2013_Filter = new System.Windows.Forms.CheckBox();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.saison20122013DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEntreeClubDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomPereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomPereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomMereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomMereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.communeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codePostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailMereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telMereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telPortableMereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailPereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telPereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telPortablePereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDeNaissanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licenseNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ceintureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commisaireSportifDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.arbitreDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.certificatMedicalNomMedecinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.certificatMedicalTelMedecinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moyenPaiementsLiquideDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moyenPaiementsChequeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moyenPaiementsChequesVacancesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moyenPaiementsChequierJeuneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moyenPaiementsCarteMRADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cotisationAJourDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.coutCotisationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridMembers
            // 
            this.dataGridMembers.AllowUserToAddRows = false;
            this.dataGridMembers.AllowUserToDeleteRows = false;
            this.dataGridMembers.AllowUserToOrderColumns = true;
            this.dataGridMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridMembers.AutoGenerateColumns = false;
            this.dataGridMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saison20122013DataGridViewCheckBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.dateEntreeClubDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.nomPereDataGridViewTextBoxColumn,
            this.prenomPereDataGridViewTextBoxColumn,
            this.nomMereDataGridViewTextBoxColumn,
            this.prenomMereDataGridViewTextBoxColumn,
            this.communeDataGridViewTextBoxColumn,
            this.codePostalDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.emailMereDataGridViewTextBoxColumn,
            this.telMereDataGridViewTextBoxColumn,
            this.telPortableMereDataGridViewTextBoxColumn,
            this.emailPereDataGridViewTextBoxColumn,
            this.telPereDataGridViewTextBoxColumn,
            this.telPortablePereDataGridViewTextBoxColumn,
            this.dateDeNaissanceDataGridViewTextBoxColumn,
            this.sexeDataGridViewTextBoxColumn,
            this.licenseNumberDataGridViewTextBoxColumn,
            this.ceintureDataGridViewTextBoxColumn,
            this.commisaireSportifDataGridViewCheckBoxColumn,
            this.arbitreDataGridViewCheckBoxColumn,
            this.certificatMedicalNomMedecinDataGridViewTextBoxColumn,
            this.certificatMedicalTelMedecinDataGridViewTextBoxColumn,
            this.moyenPaiementsLiquideDataGridViewTextBoxColumn,
            this.moyenPaiementsChequeDataGridViewTextBoxColumn,
            this.moyenPaiementsChequesVacancesDataGridViewTextBoxColumn,
            this.moyenPaiementsChequierJeuneDataGridViewTextBoxColumn,
            this.moyenPaiementsCarteMRADataGridViewTextBoxColumn,
            this.cotisationAJourDataGridViewCheckBoxColumn,
            this.coutCotisationDataGridViewTextBoxColumn,
            this.categorieDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn});
            this.dataGridMembers.DataSource = this.memberBindingSource2;
            this.dataGridMembers.Location = new System.Drawing.Point(0, 65);
            this.dataGridMembers.Name = "dataGridMembers";
            this.dataGridMembers.ReadOnly = true;
            this.dataGridMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridMembers.Size = new System.Drawing.Size(1071, 404);
            this.dataGridMembers.TabIndex = 1;
            this.dataGridMembers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridMembers_MouseDoubleClick);
            // 
            // memberBindingSource1
            // 
            this.memberBindingSource1.DataSource = typeof(EasyJudoClub.Member);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Options,
            this.ajouterToolStripMenuItem,
            this.editerToolStripMenuItem,
            this.supprimerToolStripMenuItem,
            this.imprimerToolStripMenuItem,
            this.informationsToolStripMenuItem,
            this.nouvelleSaisonToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1071, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_Options
            // 
            this.ToolStripMenuItem_Options.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Colonnes,
            this.creerUneSauvegardeToolStripMenuItem});
            this.ToolStripMenuItem_Options.Name = "ToolStripMenuItem_Options";
            this.ToolStripMenuItem_Options.Size = new System.Drawing.Size(61, 20);
            this.ToolStripMenuItem_Options.Text = "Options";
            // 
            // ToolStripMenuItem_Colonnes
            // 
            this.ToolStripMenuItem_Colonnes.Name = "ToolStripMenuItem_Colonnes";
            this.ToolStripMenuItem_Colonnes.Size = new System.Drawing.Size(188, 22);
            this.ToolStripMenuItem_Colonnes.Text = "Colonnes";
            this.ToolStripMenuItem_Colonnes.Click += new System.EventHandler(this.colonnesToolStripMenuItem1_Click);
            // 
            // creerUneSauvegardeToolStripMenuItem
            // 
            this.creerUneSauvegardeToolStripMenuItem.Name = "creerUneSauvegardeToolStripMenuItem";
            this.creerUneSauvegardeToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.creerUneSauvegardeToolStripMenuItem.Text = "Creer une sauvegarde";
            this.creerUneSauvegardeToolStripMenuItem.Click += new System.EventHandler(this.creerUneSauvegardeToolStripMenuItem_Click);
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // editerToolStripMenuItem
            // 
            this.editerToolStripMenuItem.Name = "editerToolStripMenuItem";
            this.editerToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editerToolStripMenuItem.Text = "Editer";
            this.editerToolStripMenuItem.Click += new System.EventHandler(this.editerToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // imprimerToolStripMenuItem
            // 
            this.imprimerToolStripMenuItem.Name = "imprimerToolStripMenuItem";
            this.imprimerToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.imprimerToolStripMenuItem.Text = "Imprimer";
            this.imprimerToolStripMenuItem.Click += new System.EventHandler(this.imprimerToolStripMenuItem_Click);
            // 
            // informationsToolStripMenuItem
            // 
            this.informationsToolStripMenuItem.Name = "informationsToolStripMenuItem";
            this.informationsToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.informationsToolStripMenuItem.Text = "Informations";
            this.informationsToolStripMenuItem.Click += new System.EventHandler(this.informationsToolStripMenuItem_Click);
            // 
            // nouvelleSaisonToolStripMenuItem
            // 
            this.nouvelleSaisonToolStripMenuItem.Name = "nouvelleSaisonToolStripMenuItem";
            this.nouvelleSaisonToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.nouvelleSaisonToolStripMenuItem.Text = "Nouvelle saison";
            this.nouvelleSaisonToolStripMenuItem.Click += new System.EventHandler(this.nouvelleSaisonToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatus_members});
            this.statusStrip1.Location = new System.Drawing.Point(0, 472);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1071, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatus_members
            // 
            this.toolStripStatus_members.Name = "toolStripStatus_members";
            this.toolStripStatus_members.Size = new System.Drawing.Size(129, 17);
            this.toolStripStatus_members.Text = "Nombre de membres : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(173, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Rechercher (nom ou prénom)";
            // 
            // btn_clearFilter
            // 
            this.btn_clearFilter.Location = new System.Drawing.Point(560, 37);
            this.btn_clearFilter.Name = "btn_clearFilter";
            this.btn_clearFilter.Size = new System.Drawing.Size(75, 23);
            this.btn_clearFilter.TabIndex = 6;
            this.btn_clearFilter.Text = "Effacer filtre";
            this.btn_clearFilter.UseVisualStyleBackColor = true;
            this.btn_clearFilter.Click += new System.EventHandler(this.btn_clearFilter_Click);
            // 
            // cb_2012_2013_Filter
            // 
            this.cb_2012_2013_Filter.AutoSize = true;
            this.cb_2012_2013_Filter.Location = new System.Drawing.Point(459, 41);
            this.cb_2012_2013_Filter.Name = "cb_2012_2013_Filter";
            this.cb_2012_2013_Filter.Size = new System.Drawing.Size(85, 17);
            this.cb_2012_2013_Filter.TabIndex = 7;
            this.cb_2012_2013_Filter.Text = "2012 / 2013";
            this.cb_2012_2013_Filter.UseVisualStyleBackColor = true;
            this.cb_2012_2013_Filter.CheckedChanged += new System.EventHandler(this.cb_2012_2013_Filter_CheckedChanged);
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataSource = typeof(EasyJudoClub.Member);
            // 
            // memberBindingSource2
            // 
            this.memberBindingSource2.DataSource = typeof(EasyJudoClub.Member);
            // 
            // saison20122013DataGridViewCheckBoxColumn
            // 
            this.saison20122013DataGridViewCheckBoxColumn.DataPropertyName = "saison2012_2013";
            this.saison20122013DataGridViewCheckBoxColumn.HeaderText = "saison2012_2013";
            this.saison20122013DataGridViewCheckBoxColumn.Name = "saison20122013DataGridViewCheckBoxColumn";
            this.saison20122013DataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateEntreeClubDataGridViewTextBoxColumn
            // 
            this.dateEntreeClubDataGridViewTextBoxColumn.DataPropertyName = "DateEntreeClub";
            this.dateEntreeClubDataGridViewTextBoxColumn.HeaderText = "DateEntreeClub";
            this.dateEntreeClubDataGridViewTextBoxColumn.Name = "dateEntreeClubDataGridViewTextBoxColumn";
            this.dateEntreeClubDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "Prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "Prenom";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            this.prenomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomPereDataGridViewTextBoxColumn
            // 
            this.nomPereDataGridViewTextBoxColumn.DataPropertyName = "NomPere";
            this.nomPereDataGridViewTextBoxColumn.HeaderText = "NomPere";
            this.nomPereDataGridViewTextBoxColumn.Name = "nomPereDataGridViewTextBoxColumn";
            this.nomPereDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prenomPereDataGridViewTextBoxColumn
            // 
            this.prenomPereDataGridViewTextBoxColumn.DataPropertyName = "PrenomPere";
            this.prenomPereDataGridViewTextBoxColumn.HeaderText = "PrenomPere";
            this.prenomPereDataGridViewTextBoxColumn.Name = "prenomPereDataGridViewTextBoxColumn";
            this.prenomPereDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomMereDataGridViewTextBoxColumn
            // 
            this.nomMereDataGridViewTextBoxColumn.DataPropertyName = "NomMere";
            this.nomMereDataGridViewTextBoxColumn.HeaderText = "NomMere";
            this.nomMereDataGridViewTextBoxColumn.Name = "nomMereDataGridViewTextBoxColumn";
            this.nomMereDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prenomMereDataGridViewTextBoxColumn
            // 
            this.prenomMereDataGridViewTextBoxColumn.DataPropertyName = "PrenomMere";
            this.prenomMereDataGridViewTextBoxColumn.HeaderText = "PrenomMere";
            this.prenomMereDataGridViewTextBoxColumn.Name = "prenomMereDataGridViewTextBoxColumn";
            this.prenomMereDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // communeDataGridViewTextBoxColumn
            // 
            this.communeDataGridViewTextBoxColumn.DataPropertyName = "Commune";
            this.communeDataGridViewTextBoxColumn.HeaderText = "Commune";
            this.communeDataGridViewTextBoxColumn.Name = "communeDataGridViewTextBoxColumn";
            this.communeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codePostalDataGridViewTextBoxColumn
            // 
            this.codePostalDataGridViewTextBoxColumn.DataPropertyName = "CodePostal";
            this.codePostalDataGridViewTextBoxColumn.HeaderText = "CodePostal";
            this.codePostalDataGridViewTextBoxColumn.Name = "codePostalDataGridViewTextBoxColumn";
            this.codePostalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            this.adresseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailMereDataGridViewTextBoxColumn
            // 
            this.emailMereDataGridViewTextBoxColumn.DataPropertyName = "EmailMere";
            this.emailMereDataGridViewTextBoxColumn.HeaderText = "EmailMere";
            this.emailMereDataGridViewTextBoxColumn.Name = "emailMereDataGridViewTextBoxColumn";
            this.emailMereDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telMereDataGridViewTextBoxColumn
            // 
            this.telMereDataGridViewTextBoxColumn.DataPropertyName = "TelMere";
            this.telMereDataGridViewTextBoxColumn.HeaderText = "TelMere";
            this.telMereDataGridViewTextBoxColumn.Name = "telMereDataGridViewTextBoxColumn";
            this.telMereDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telPortableMereDataGridViewTextBoxColumn
            // 
            this.telPortableMereDataGridViewTextBoxColumn.DataPropertyName = "TelPortableMere";
            this.telPortableMereDataGridViewTextBoxColumn.HeaderText = "TelPortableMere";
            this.telPortableMereDataGridViewTextBoxColumn.Name = "telPortableMereDataGridViewTextBoxColumn";
            this.telPortableMereDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailPereDataGridViewTextBoxColumn
            // 
            this.emailPereDataGridViewTextBoxColumn.DataPropertyName = "EmailPere";
            this.emailPereDataGridViewTextBoxColumn.HeaderText = "EmailPere";
            this.emailPereDataGridViewTextBoxColumn.Name = "emailPereDataGridViewTextBoxColumn";
            this.emailPereDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telPereDataGridViewTextBoxColumn
            // 
            this.telPereDataGridViewTextBoxColumn.DataPropertyName = "TelPere";
            this.telPereDataGridViewTextBoxColumn.HeaderText = "TelPere";
            this.telPereDataGridViewTextBoxColumn.Name = "telPereDataGridViewTextBoxColumn";
            this.telPereDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telPortablePereDataGridViewTextBoxColumn
            // 
            this.telPortablePereDataGridViewTextBoxColumn.DataPropertyName = "TelPortablePere";
            this.telPortablePereDataGridViewTextBoxColumn.HeaderText = "TelPortablePere";
            this.telPortablePereDataGridViewTextBoxColumn.Name = "telPortablePereDataGridViewTextBoxColumn";
            this.telPortablePereDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDeNaissanceDataGridViewTextBoxColumn
            // 
            this.dateDeNaissanceDataGridViewTextBoxColumn.DataPropertyName = "DateDeNaissance";
            this.dateDeNaissanceDataGridViewTextBoxColumn.HeaderText = "DateDeNaissance";
            this.dateDeNaissanceDataGridViewTextBoxColumn.Name = "dateDeNaissanceDataGridViewTextBoxColumn";
            this.dateDeNaissanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexeDataGridViewTextBoxColumn
            // 
            this.sexeDataGridViewTextBoxColumn.DataPropertyName = "Sexe";
            this.sexeDataGridViewTextBoxColumn.HeaderText = "Sexe";
            this.sexeDataGridViewTextBoxColumn.Name = "sexeDataGridViewTextBoxColumn";
            this.sexeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // licenseNumberDataGridViewTextBoxColumn
            // 
            this.licenseNumberDataGridViewTextBoxColumn.DataPropertyName = "LicenseNumber";
            this.licenseNumberDataGridViewTextBoxColumn.HeaderText = "LicenseNumber";
            this.licenseNumberDataGridViewTextBoxColumn.Name = "licenseNumberDataGridViewTextBoxColumn";
            this.licenseNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ceintureDataGridViewTextBoxColumn
            // 
            this.ceintureDataGridViewTextBoxColumn.DataPropertyName = "Ceinture";
            this.ceintureDataGridViewTextBoxColumn.HeaderText = "Ceinture";
            this.ceintureDataGridViewTextBoxColumn.Name = "ceintureDataGridViewTextBoxColumn";
            this.ceintureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commisaireSportifDataGridViewCheckBoxColumn
            // 
            this.commisaireSportifDataGridViewCheckBoxColumn.DataPropertyName = "CommisaireSportif";
            this.commisaireSportifDataGridViewCheckBoxColumn.HeaderText = "CommisaireSportif";
            this.commisaireSportifDataGridViewCheckBoxColumn.Name = "commisaireSportifDataGridViewCheckBoxColumn";
            this.commisaireSportifDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // arbitreDataGridViewCheckBoxColumn
            // 
            this.arbitreDataGridViewCheckBoxColumn.DataPropertyName = "Arbitre";
            this.arbitreDataGridViewCheckBoxColumn.HeaderText = "Arbitre";
            this.arbitreDataGridViewCheckBoxColumn.Name = "arbitreDataGridViewCheckBoxColumn";
            this.arbitreDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // certificatMedicalNomMedecinDataGridViewTextBoxColumn
            // 
            this.certificatMedicalNomMedecinDataGridViewTextBoxColumn.DataPropertyName = "CertificatMedicalNomMedecin";
            this.certificatMedicalNomMedecinDataGridViewTextBoxColumn.HeaderText = "CertificatMedicalNomMedecin";
            this.certificatMedicalNomMedecinDataGridViewTextBoxColumn.Name = "certificatMedicalNomMedecinDataGridViewTextBoxColumn";
            this.certificatMedicalNomMedecinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // certificatMedicalTelMedecinDataGridViewTextBoxColumn
            // 
            this.certificatMedicalTelMedecinDataGridViewTextBoxColumn.DataPropertyName = "CertificatMedicalTelMedecin";
            this.certificatMedicalTelMedecinDataGridViewTextBoxColumn.HeaderText = "CertificatMedicalTelMedecin";
            this.certificatMedicalTelMedecinDataGridViewTextBoxColumn.Name = "certificatMedicalTelMedecinDataGridViewTextBoxColumn";
            this.certificatMedicalTelMedecinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moyenPaiementsLiquideDataGridViewTextBoxColumn
            // 
            this.moyenPaiementsLiquideDataGridViewTextBoxColumn.DataPropertyName = "MoyenPaiementsLiquide";
            this.moyenPaiementsLiquideDataGridViewTextBoxColumn.HeaderText = "MoyenPaiementsLiquide";
            this.moyenPaiementsLiquideDataGridViewTextBoxColumn.Name = "moyenPaiementsLiquideDataGridViewTextBoxColumn";
            this.moyenPaiementsLiquideDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moyenPaiementsChequeDataGridViewTextBoxColumn
            // 
            this.moyenPaiementsChequeDataGridViewTextBoxColumn.DataPropertyName = "MoyenPaiementsCheque";
            this.moyenPaiementsChequeDataGridViewTextBoxColumn.HeaderText = "MoyenPaiementsCheque";
            this.moyenPaiementsChequeDataGridViewTextBoxColumn.Name = "moyenPaiementsChequeDataGridViewTextBoxColumn";
            this.moyenPaiementsChequeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moyenPaiementsChequesVacancesDataGridViewTextBoxColumn
            // 
            this.moyenPaiementsChequesVacancesDataGridViewTextBoxColumn.DataPropertyName = "MoyenPaiementsChequesVacances";
            this.moyenPaiementsChequesVacancesDataGridViewTextBoxColumn.HeaderText = "MoyenPaiementsChequesVacances";
            this.moyenPaiementsChequesVacancesDataGridViewTextBoxColumn.Name = "moyenPaiementsChequesVacancesDataGridViewTextBoxColumn";
            this.moyenPaiementsChequesVacancesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moyenPaiementsChequierJeuneDataGridViewTextBoxColumn
            // 
            this.moyenPaiementsChequierJeuneDataGridViewTextBoxColumn.DataPropertyName = "MoyenPaiementsChequierJeune";
            this.moyenPaiementsChequierJeuneDataGridViewTextBoxColumn.HeaderText = "MoyenPaiementsChequierJeune";
            this.moyenPaiementsChequierJeuneDataGridViewTextBoxColumn.Name = "moyenPaiementsChequierJeuneDataGridViewTextBoxColumn";
            this.moyenPaiementsChequierJeuneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moyenPaiementsCarteMRADataGridViewTextBoxColumn
            // 
            this.moyenPaiementsCarteMRADataGridViewTextBoxColumn.DataPropertyName = "MoyenPaiementsCarteMRA";
            this.moyenPaiementsCarteMRADataGridViewTextBoxColumn.HeaderText = "MoyenPaiementsCarteMRA";
            this.moyenPaiementsCarteMRADataGridViewTextBoxColumn.Name = "moyenPaiementsCarteMRADataGridViewTextBoxColumn";
            this.moyenPaiementsCarteMRADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cotisationAJourDataGridViewCheckBoxColumn
            // 
            this.cotisationAJourDataGridViewCheckBoxColumn.DataPropertyName = "CotisationAJour";
            this.cotisationAJourDataGridViewCheckBoxColumn.HeaderText = "CotisationAJour";
            this.cotisationAJourDataGridViewCheckBoxColumn.Name = "cotisationAJourDataGridViewCheckBoxColumn";
            this.cotisationAJourDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // coutCotisationDataGridViewTextBoxColumn
            // 
            this.coutCotisationDataGridViewTextBoxColumn.DataPropertyName = "CoutCotisation";
            this.coutCotisationDataGridViewTextBoxColumn.HeaderText = "CoutCotisation";
            this.coutCotisationDataGridViewTextBoxColumn.Name = "coutCotisationDataGridViewTextBoxColumn";
            this.coutCotisationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categorieDataGridViewTextBoxColumn
            // 
            this.categorieDataGridViewTextBoxColumn.DataPropertyName = "Categorie";
            this.categorieDataGridViewTextBoxColumn.HeaderText = "Categorie";
            this.categorieDataGridViewTextBoxColumn.Name = "categorieDataGridViewTextBoxColumn";
            this.categorieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 494);
            this.Controls.Add(this.cb_2012_2013_Filter);
            this.Controls.Add(this.btn_clearFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridMembers);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Judo Club Colombe";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource memberBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Options;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Colonnes;
        private gfDataGridView dataGridMembers;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus_members;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem creerUneSauvegardeToolStripMenuItem;
        private System.Windows.Forms.Button btn_clearFilter;
        private System.Windows.Forms.CheckBox cb_2012_2013_Filter;
        private System.Windows.Forms.ToolStripMenuItem editerToolStripMenuItem;
        private System.Windows.Forms.BindingSource memberBindingSource1;
        private System.Windows.Forms.ToolStripMenuItem informationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouvelleSaisonToolStripMenuItem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn saison20122013DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEntreeClubDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomPereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomPereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomMereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomMereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn communeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codePostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailMereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telMereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telPortableMereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailPereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telPereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telPortablePereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDeNaissanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenseNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ceintureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn commisaireSportifDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn arbitreDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn certificatMedicalNomMedecinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn certificatMedicalTelMedecinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moyenPaiementsLiquideDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moyenPaiementsChequeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moyenPaiementsChequesVacancesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moyenPaiementsChequierJeuneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moyenPaiementsCarteMRADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cotisationAJourDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coutCotisationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource memberBindingSource2;

    }
}

