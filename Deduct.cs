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
    public partial class Deduct : Form
    {
        public Deduct()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Main m = new Main();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculator c = new Calculator();
            c.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I am 18 years old as of 03/11/2015 and I find joy in coding for applications that may benefit people in any way possible! So enjoy my app while you still can :)", "About Me!");
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelMake lm = new labelMake();
            lm.ShowDialog();
        }
    }
}
