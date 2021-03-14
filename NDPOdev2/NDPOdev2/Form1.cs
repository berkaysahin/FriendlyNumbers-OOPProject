/****************************************************************************
**					SAKARYA UNIVERSITY
**				FACULTY OF COMPUTER AND INFORMATION SCIENCES
**				COMPUTER ENGINEERING
**				OBJECT ORIENTED PROGRAMMING COURSE
**					2019-2020 FALL SEMESTER
**	
**				HOMEWORK NUMBER...........: 02
**				STUDENT NAME..............: BERKAY ŞAHİN
**				STUDENT NUMBER............: G191210302
**              COURSE GROUP..............: 2C Group
****************************************************************************/

using System;
using System.Drawing;
using System.Windows.Forms;

namespace NDPOdev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool haveObjectsBeenAdded  = false;
        Label lblX, lblY, lblT;
        TextBox txtT1, txtT2;
        ListBox lstX, lstY;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "") // Will work if x and y number are entered
            {
                this.Size = new Size(610, 350); // Resizing the size of the form
                if (haveObjectsBeenAdded == false) // Checking if our objects are added
                {
                    lblX = new Label(); // lblX object has been created
                    lblX.Text = "X"; // The text content of the object has been written
                    lblX.Location = new Point(326, 26); // The location of the object in the form is adjusted
                    lblX.Font = new Font("Microsoft Sans Serif", 12); // Font setted
                    this.Controls.Add(lblX); // Added object to form becomes visible

                    lblY = new Label(); // lblY object has been created
                    lblY.Text = "Y"; // The text content of the object has been written
                    lblY.Location = new Point(452, 26); // The location of the object in the form is adjusted
                    lblY.Font = new Font("Microsoft Sans Serif", 12); // Font setted
                    this.Controls.Add(lblY); // Added object to form becomes visible

                    lblT = new Label(); // lblT object has been created
                    lblT.Text = "SUMS"; // The text content of the object has been written
                    lblT.Location = new Point(190, 245); // The location of the object in the form is adjusted
                    lblT.Size = new Size(75, 17); // nesnenin boyutu verildi
                    this.Controls.Add(lblT); // Added object to form becomes visible

                    lstX = new ListBox(); // lstX object has been created
                    lstX.Size = new Size(120, 180); // nesnenin boyutu verildi
                    lstX.Location = new Point(283, 54); // The location of the object in the form is adjusted
                    this.Controls.Add(lstX); // Added object to form becomes visible

                    lstY = new ListBox(); // lstY object has been created
                    lstY.Size = new Size(120, 180); // nesnenin boyutu verildi
                    lstY.Location = new Point(409, 54); // The location of the object in the form is adjusted
                    this.Controls.Add(lstY); // Added object to form becomes visible

                    txtT1 = new TextBox(); // txtT1 object has been created
                    txtT1.Size = new Size(120, 22); // nesnenin boyutu verildi
                    txtT1.Location = new Point(283, 241); // The location of the object in the form is adjusted
                    this.Controls.Add(txtT1); // Added object to form becomes visible

                    txtT2 = new TextBox(); // txtT2 object has been created
                    txtT2.Size = new Size(120, 22); // nesnenin boyutu verildi
                    txtT2.Location = new Point(409, 241); // The location of the object in the form is adjusted
                    this.Controls.Add(txtT2); // Added object to form becomes visible

                    haveObjectsBeenAdded = true; // The objects are created, we make haveObjectsBeenAdded variable true.
                }

                lstX.Items.Clear(); // Emptying the contents of the lstX object
                lstY.Items.Clear(); // Emptying the contents of the lstY object
                txtT1.Text = ""; // Emptying the contents of the txtT1 object
                txtT2.Text = ""; // Emptying the contents of the txtT2 object


                int X = Convert.ToInt32(textBox1.Text), Y = Convert.ToInt32(textBox2.Text); // X and Y numbers have been transferred from textboxes to variables
                int sumX= 0, sumY = 0; // Variables we will keep sums

                for (int i = 1; i < X; i++) // Going to check all divisors less than X
                {
                    if (X % i == 0) // If the remainder from dividing X by i is 0, that is if it is divided completely
                    {
                        lstX.Items.Add(i); // Number i will be added to lstX
                        sumX += i; // Sum the numbers i divisor 
                    }
                }

                for (int i = 1; i < Y; i++) // Going to check all divisors less than Y
                {
                    if (Y % i == 0) // If the remainder from the division of Y by i is 0, that is, if it is divided completely 
                    {
                        lstY.Items.Add(i); // Number i will be added to lstY
                        sumY += i; // Sum the numbers i divisor
                    }
                }

                txtT1.Text = sumX.ToString(); // We write the sum of the divisors of X in txtT1
                txtT2.Text = sumY.ToString(); // We write the sum of the divisors of Y in txtT2
            }
        }
    }
}
