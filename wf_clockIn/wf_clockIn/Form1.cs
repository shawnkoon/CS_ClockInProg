using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_clockIn
{
    public partial class Form1 : Form
    {
        //private int studentID;
        //private Calendar timeIn;
        //private Calendar timeOut;

        // search for calendar like api for C sharp

        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello ");
            sayHello();
        }
        // just a comment

        private void sayHello()
        {
            MessageBox.Show(txtBox.Text);
        }
    }
}
