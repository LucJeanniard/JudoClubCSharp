using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EasyJudoClub.Controls
{
    public partial class CheckBoxField : UserControl
    {
        public CheckBoxField()
        {
            InitializeComponent();
        }

        public string Label
        {
            get { return label.Text; }
            set { label.Text = value; }
        }

        public bool Value
        {
            get { return checkBox1.Checked; }
            set { checkBox1.Checked = value; }
        }
    }
}
