using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dynamicDeduct
{
    public partial class labelMake : Form
    {
        int A = 1, count = 1;
        public labelMake()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deduct d = new Deduct();
            d.Visible = true;
            d.Activate();
            d.Controls.Add(AddNewLabel(labelName.Text));
            d.Controls.Add(AddNewText());
            this.Close();
        }
        public System.Windows.Forms.TextBox AddNewText()
        {
            System.Windows.Forms.TextBox txt = new System.Windows.Forms.TextBox();
            txt.ReadOnly = true;
            this.Controls.Add(txt);
            txt.Top = A * 60;
            txt.Left = 90;
            A = A + 1;
            return txt;

        }
        public System.Windows.Forms.Label AddNewLabel(String name)
        {
            Label label = new Label();
            label.Location = new Point(10, (60 * count));
            label.Size = new Size(40, 20);
            label.Name = name;
            label.Text = name;
            this.Controls.Add(label);
            count = count + 1;
            return label;
        }
    }
}
