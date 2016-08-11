using System;
using System.Windows.Forms;

namespace wf_clockIn
{
    public partial class MainClockInForm : Form
    {
        public MainClockInForm()
        {
            InitializeComponent();
            idDisplay.Text = "";
            idDisplay.MaxLength = 10; // Recommanded. If more needed, Please Widen the idDisplay box.
        }
        // this is a comment 



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
            // Need to show all the Contributers' Names As well as Program's version, language used and ETC...
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
            btnEnter.Focus();
        }// End of wrtieNumber method.



        #region Button Click Method group.

        // If [AC] button is clicked.
        private void btnAllClear_Click(object sender, EventArgs e)
        {
            // Remove all the text from the ID display.
            idDisplay.Text = "";
        }
        // If [Enter] button is clicked.
        private void btnEnter_Click(object sender, EventArgs e)
        {
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

        private void MainClockInForm_KeyDown(object sender, KeyEventArgs e)
        {
            // write the digit 0 to the idDisplay box 
            #region Keyboard key checking 
            if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
            {
                writeNumber(0);
            }
            else if(e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {
                writeNumber(1);
            }
            else if(e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {
                writeNumber(2);
            }
            else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {
                writeNumber(3);
            }
            else if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
            {
                writeNumber(4);
            }
            else if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
            {
                writeNumber(5);
            }
            else if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
            {
                writeNumber(6);
            }
            else if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
            {
                writeNumber(7);
            }
            else if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
            {
                writeNumber(8);
            }
            else if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
            {
                writeNumber(9);
            }
            else if (e.KeyCode == Keys.Back)
            {
                deleteNumber();
            }
            else if(e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
            {
                studentClockIn();
            }
            

            #endregion
            // do the same for the other digits

        }
        private void deleteNumber()
        {
            // edge case
            if(idDisplay.Text.Length > 0)
            {
                string str = idDisplay.Text;
              
                str = str.Substring(0, str.Length - 1);
                idDisplay.Text = str;
            }
        }

        
    }//main 
}
