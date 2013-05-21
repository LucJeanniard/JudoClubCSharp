using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EasyJudoClub
{
    public partial class NumBoxField : UserControl
    {

        public NumBoxField()
        {
            InitializeComponent();
            maskedTextBox.TextChanged += new EventHandler(maskedTextBox_TextChanged);
            maskedTextBox.Mask = "#########";
        }

        void maskedTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!ReadOnly)
            {
                maskedTextBox.BackColor = string.IsNullOrEmpty(maskedTextBox.Text) ? Color.Pink : Color.White;
            }
        }

        public string Label 
        {
            get { return label.Text; }
            set { label.Text = value;}
        }

        public new string Text
        {
            get { return maskedTextBox.Text; }
            set { maskedTextBox.Text = value; }
        }

        public bool ReadOnly
        {
            get
            {
                return maskedTextBox.ReadOnly;
            }
            set
            {
                maskedTextBox.ReadOnly = value;
                if (value)
                    maskedTextBox.BackColor = SystemColors.GradientInactiveCaption;
            }
        }
    }
}
