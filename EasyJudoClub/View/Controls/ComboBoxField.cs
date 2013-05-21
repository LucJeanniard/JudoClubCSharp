using System;
using System.Windows.Forms;

namespace EasyJudoClub
{
    public partial class ComboBoxField : UserControl
    {
        private Type _items;

        public ComboBoxField()
        {
            InitializeComponent();
        }
        
        public string Label
        {
            get { return label.Text; }
            set { label.Text = value; }
        }

        public Type Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
                comboBox.DataSource = Enum.GetValues(_items);
            }
        }

        public object Value
        {
            get
            {
                return comboBox.SelectedItem;
            }
            set 
            {
                    comboBox.SelectedItem = comboBox.Items[(int) value];
            }
        }

        public bool ReadOnly
        {
            get { return comboBox.Enabled; }
            set { comboBox.Enabled = value; }
        }


    }
}
