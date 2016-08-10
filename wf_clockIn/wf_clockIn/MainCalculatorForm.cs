using System;
using System.Windows.Forms;

namespace wf_clockIn
{
    public partial class MainCalculatorForm : Form
    {
        //private int studentID;
        //private Calendar timeIn;
        //private Calendar timeOut;

        // search for calendar like api for C sharp

        public MainCalculatorForm()
        {
            InitializeComponent();
        }


        #region Group of Toolstrip menu Items.
         
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Need to show help message about how to use the program.
            // ex) MessageBox.show("Hello! welcome to .... \nThis is how to use....","The title of the message box");
        }

        private void saveExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Need to show different form that will be to Query log history.
        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Need to show all the Contributer's Names As well as Program's version, language used and ETC...
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Need to show different form that will be able to Modify the Student Database.
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Need to show different form that will be able to Modify the Log history Database.
        }

        #endregion
    }
}
