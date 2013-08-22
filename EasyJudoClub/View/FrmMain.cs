using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Be.Timvw.Framework.ComponentModel;
using EasyJudoClub.Model;
using EasyJudoClub.Controler;
using EasyJudoClub.Utils;
using System.Collections.Generic;

namespace EasyJudoClub
{
    public partial class FrmMain : Form
    {
        private EasyJudoClubControler _easyJudoClubControler;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _easyJudoClubControler = new EasyJudoClubControler();
            _easyJudoClubControler.Initialize();

            if (_easyJudoClubControler.JudoClub == null)
            {
                MessageBox.Show(this, "Ficher base de données non trouvé: " + Club.EASY_SPORT_CLUB_DB_FILE_NAME, "error", MessageBoxButtons.OK);
                this.Close();
            }

            dataGridMembers.DataSource = _easyJudoClubControler.JudoClub.Members;
            SetGridPoperties();
            RefreshFrmMain();
        }

        private void SetGridPoperties()
        {
            // Columns header
            saison20122013DataGridViewCheckBoxColumn.HeaderText = "2012/2013";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            dateEntreeClubDataGridViewTextBoxColumn.HeaderText = "Date entrée club";
            nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            prenomDataGridViewTextBoxColumn.HeaderText = "Prénom";
            nomPereDataGridViewTextBoxColumn.HeaderText = "Nom père";
            prenomPereDataGridViewTextBoxColumn.HeaderText = "Prénom père";
            nomMereDataGridViewTextBoxColumn.HeaderText = "Nom mère";
            prenomMereDataGridViewTextBoxColumn.HeaderText = "Prénom mère";
            communeDataGridViewTextBoxColumn.HeaderText = "Commune";
            codePostalDataGridViewTextBoxColumn.HeaderText = "Code postal";
            adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            emailMereDataGridViewTextBoxColumn.HeaderText = "email mère";
            emailPereDataGridViewTextBoxColumn.HeaderText = "email père";
            telMereDataGridViewTextBoxColumn.HeaderText = "Tel fixe mère";
            telPereDataGridViewTextBoxColumn.HeaderText = "Tel fixe père";
            telPortableMereDataGridViewTextBoxColumn.HeaderText = "Tel portable mère";
            telPortableMereDataGridViewTextBoxColumn.HeaderText = "Tel portable père";
            dateDeNaissanceDataGridViewTextBoxColumn.HeaderText = "Date de naissance";
            sexeDataGridViewTextBoxColumn.HeaderText = "Sexe";
            licenseNumberDataGridViewTextBoxColumn.HeaderText = "License";
            ceintureDataGridViewTextBoxColumn.HeaderText = "Ceinture";
            commisaireSportifDataGridViewCheckBoxColumn.HeaderText = "CS";
            arbitreDataGridViewCheckBoxColumn.HeaderText = "Arbitre";
            certificatMedicalNomMedecinDataGridViewTextBoxColumn.HeaderText = "Nom medecin";
            certificatMedicalTelMedecinDataGridViewTextBoxColumn.HeaderText = "Tel medecin";
            coutCotisationDataGridViewTextBoxColumn.HeaderText = "Coût cotisation";
            categorieDataGridViewTextBoxColumn.HeaderText = "Catégorie";
            ageDataGridViewTextBoxColumn.HeaderText = "Age";
            cotisationAJourDataGridViewCheckBoxColumn.HeaderText = "Cotisation payée";

            // ReadOnly
            dataGridMembers.ReadOnly = false;
            foreach (DataGridViewColumn column in dataGridMembers.Columns)
            {
                column.ReadOnly = true;
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            saison20122013DataGridViewCheckBoxColumn.ReadOnly = false;

            // Season changed trigger saving
            dataGridMembers.CellValidated += DataGridMembersOnCellValidated;

            //Sort by Name
            dataGridMembers.Sort(nomDataGridViewTextBoxColumn, ListSortDirection.Ascending);

            //Set column colors
            foreach (DataGridViewColumn column in dataGridMembers.Columns)
            {
                if (column.ReadOnly)
                    column.DefaultCellStyle.BackColor = SystemColors.GradientInactiveCaption;
            }

        }

        private void OpenSelectedMember()
        {
            var currentMember = dataGridMembers.SelectedRows[0].DataBoundItem as Member;
            OpenMember(currentMember);
        }

        private void OpenMember(Member member)
        {
            using (var formulaire = new FrmLicencie())
            {
                formulaire.DoctorsAndTel = this._easyJudoClubControler.GetDoctorsAndTel();
                formulaire.Member = member;
               
                if (formulaire.ShowDialog() == DialogResult.OK)
                {
                    var sortedColumn = dataGridMembers.SortedColumn;

                    var oldMember = _easyJudoClubControler.JudoClub.Members.First(_ => _.Id == member.Id);
                    var newMember = formulaire.Member;

                    _easyJudoClubControler.UpdateMember(oldMember, newMember);
                    
                    Save();
                    RefreshFrmMain();
                    SetFilter(textBox1.Text, cb_2012_2013_Filter.Checked);
                    if (sortedColumn != null)
                        dataGridMembers.Sort(sortedColumn, ListSortDirection.Ascending);

                    SelectRow(member.Id);
                }
            }
        }

        private void Save()
        {
            _easyJudoClubControler.Save();
        }

        private void dataGridMembers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenSelectedMember();
        }

        private void ShowColumnChooser()
        {
            FrmColumnChooser.Show(dataGridMembers);
        }

        public void DeleteSelectedMembers()
        {
            var confirmationMessage = String.Format("Voulez-vous supprimer le(s) {0} membre(s) selectionés", dataGridMembers.SelectedRows.Count);
            if (MessageBox.Show(this, confirmationMessage, "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var selectedMembers = GetSelectedMembers();
                foreach(var member in selectedMembers)
                {
                    var memberId = member.Id;
                    _easyJudoClubControler.RemoveMember(memberId);
                }
                ResetFilter();
                RefreshFrmMain();
            }
        }

        private List<Member> GetSelectedMembers()
        {
            var members = new List<Member>();
            foreach (DataGridViewRow selectedRow in dataGridMembers.SelectedRows)
            {
                var member = selectedRow.DataBoundItem as Member;
                if (member != null)
                {
                    members.Add(member);
                }
            }
            return members;
        }


        private void SelectRow(int memberId)
        {
            foreach (var row in dataGridMembers.Rows)
            {
                var dataGridViewRow = row as DataGridViewRow;
                dataGridViewRow.Selected = (dataGridViewRow.DataBoundItem as Member).Id == memberId;
            }
        }

        private void RefreshFrmMain()
        {
            dataGridMembers.Refresh();
            toolStripStatus_members.Text = "Nombre de membres : " + _easyJudoClubControler.JudoClub.MemberCount.ToString();
        }

        private void AddMember()
        {
            var newMember = _easyJudoClubControler.AddMember();
            RefreshFrmMain();
            OpenMember(newMember);
            ResetFilter();
        }

        private void SetFilter(string searchPattern, bool season2012_2013_Only)
        {
            if (String.IsNullOrEmpty(searchPattern) && !season2012_2013_Only)
            {
                dataGridMembers.DataSource = _easyJudoClubControler.JudoClub.Members;
            }
            else
            {
                var filteredMembersByName = _easyJudoClubControler.GetFilteredMembersByName(searchPattern);

                if (season2012_2013_Only)
                    filteredMembersByName = _easyJudoClubControler.GetFilteredMembersWithSeason2012_2013Only(filteredMembersByName);

                var filteredMembersSortableBindingList = new SortableBindingList<Member>();
                foreach (var member in filteredMembersByName)
                    filteredMembersSortableBindingList.Add(member);

                dataGridMembers.DataSource = filteredMembersSortableBindingList;
            }
            RefreshFrmMain();
        }

        public void ResetFilter()
        {
            textBox1.Text = "";
            cb_2012_2013_Filter.Checked = false;
        }

        private void DataGridMembersOnCellValidated(object sender, DataGridViewCellEventArgs dataGridViewCellEventArgs)
        {
            Save();
        }

        private void colonnesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowColumnChooser();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMember();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteSelectedMembers();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SetFilter(textBox1.Text, cb_2012_2013_Filter.Checked);
        }

        private void creerUneSauvegardeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string errorMessage;
            if (!Club.BackUpDataBase(out errorMessage))
                MessageBox.Show(this, "Erreur lors de la creation de la sauvegarde : " + errorMessage, "Erreur",
                                MessageBoxButtons.OK);
        }

        private void btn_clearFilter_Click(object sender, EventArgs e)
        {
            ResetFilter();
        }

        private void cb_2012_2013_Filter_CheckedChanged(object sender, EventArgs e)
        {
            SetFilter(textBox1.Text, cb_2012_2013_Filter.Checked);
        }

        private void editerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var currentMember = (dataGridMembers.CurrentRow.DataBoundItem as Member);
            OpenMember(currentMember);
        }

        private void informationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAbout.ShowModal();
        }

        private void imprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberPrinter.Print(GetSelectedMembers());
        }

        private void nouvelleSaisonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirmationMessage =  "Etes-vous certain de vouloir changer de saison? Les changement de saison sont non reversibles";
            if (MessageBox.Show(this, confirmationMessage, "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                RefreshFrmMain();
            }
        }
    }
}
