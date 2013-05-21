using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EasyJudoClub
{
    public partial class FrmColumnChooser : Form
    {
        public FrmColumnChooser()
        {
            InitializeComponent();
        }

        public static void Show(DataGridView grid)
        {
            using (var form = new FrmColumnChooser())
            {
                var columnDictionary = grid.Columns.Cast<DataGridViewColumn>().ToDictionary(column => column.HeaderText);

                form.checkedListBox.Items.Clear();
                form.checkedListBox.Items.AddRange(columnDictionary.Keys.ToArray());
                form.checkedListBox.CheckOnClick = true;
                
                //initialize 
                for(var i = 0; i <form.checkedListBox.Items.Count; i++)
                {
                    var currentItem = form.checkedListBox.Items[i].ToString();
                    form.checkedListBox.SetItemChecked(i, columnDictionary[currentItem].Visible);
                }

                form.checkedListBox.ItemCheck += delegate(object sender, ItemCheckEventArgs args)
                                                     {
                                                         var currentItem = form.checkedListBox.Items[args.Index].ToString();
                                                         columnDictionary[currentItem].Visible = args.NewValue == CheckState.Checked;
                                                     };

                form.ShowDialog();
            }
        }
    }
}
