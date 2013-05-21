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
    public partial class TextBoxField : UserControl
    {

        public TextBoxField()
        {
            InitializeComponent();
            textBox.TextChanged += new EventHandler(textBox_TextChanged);
        }

        void textBox_TextChanged(object sender, EventArgs e)
        {
            if (!ReadOnly)
            {
                textBox.BackColor = string.IsNullOrEmpty(textBox.Text) ? Color.Pink : Color.White;
            }
        }

        public string Label 
        {
            get { return label.Text; }
            set { label.Text = value;}
        }

        public new string Text
        {
            get { return textBox.Text; }
            set { textBox.Text = value; }
        }

        public bool ReadOnly
        {
            get
            {
                return textBox.ReadOnly;
            }
            set
            {
                textBox.ReadOnly = value;
                if (value)
                    textBox.BackColor =  SystemColors.GradientInactiveCaption;
            }
        }
    }
}
