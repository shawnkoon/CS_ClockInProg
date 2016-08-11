using System;
using System.Windows.Forms;

namespace wf_clockIn
{
    public partial class MainCalculatorForm : Form
    {
        public MainCalculatorForm()
        {
            InitializeComponent();
            idDisplay.Text = "";
            idDisplay.MaxLength = 10; // Recommanded. If more needed, Please Widen the idDisplay box.
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
            // create a new from to connect to the student database? 
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Need to show different form that will be able to Modify the Log history Database.
        }

        #endregion
        

        // Helper method for when [Enter] is clicked || User hits the Enter Key.
        private void studentClockIn()
        {
            // Validate the student ID.
            // If it's Valid ID  -> Clock In with Message.
            // If it's NOT Valid -> Change display Box color to Red / Show Message to Re-Enter.
        }

        // Helper method to write number to idDisplay box.
        private void writeNumber(int number)
        {
            if (idDisplay.Text.Length < 10)
            {
                idDisplay.Text += (""+ number);
            }
        }

        #region Button Click Method group.

        // If [AC] button is clicked.
        private void btnAllClear_Click(object sender, EventArgs e)
        {
            // Remove all the text from the ID display.
            idDisplay.Text = "";
        }
        // If [Enter] button is clicked.
        private void btnClear_Click(object sender, EventArgs e)
        {
            // Call studentClockIn() function. (helper method)
            studentClockIn();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            writeNumber(0);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            writeNumber(1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            writeNumber(2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            writeNumber(3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            writeNumber(4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            writeNumber(5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            writeNumber(6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            writeNumber(7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            writeNumber(8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            writeNumber(9);
        }

        #endregion
    }
}
