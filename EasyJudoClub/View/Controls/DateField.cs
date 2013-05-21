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
    public partial class DateField : UserControl
    {
        public DateField()
        {
            InitializeComponent();
        }

        public string Label
        {
            get { return label.Text; }
            set { label.Text = value; }
        }

        public DateTime Date
        {
            get { return dateTimePicker1.Value; }
            set
            {
                try
                {
                    dateTimePicker1.Value = value;
                }
                catch (Exception)
                {
                    dateTimePicker1.Value  = new DateTime(1900,01,1);
                }
                
            }
        }
    }
}
