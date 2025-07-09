using System.Security.AccessControl;

namespace White_Ch5._11
{
    public partial class Form1 : Form
    {
        private int GeneratedNum;
        private int UserInput;
        public Form1()
        {
            InitializeComponent();
        }
        //created button to exit the program
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //create button that generates random number
        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            

          
                //call random method
                Random rand = new Random();

                //generates random mnumbers 1 - 100
                GeneratedNum = rand.Next(0, 101);

               
            
        }

        //button reveals/allows user to see random number if they give up
        private void RevealBtn_Click(object sender, EventArgs e)
        {
            RevealLbl.Text = GeneratedNum.ToString();
        }

        private void GuessBtn_Click(object sender, EventArgs e)
        {
            //created if statement to stop the user from guessing a negative number or a number over 100
            if (int.TryParse(UserGuessBox.Text, out UserInput))
            {
                if (UserInput > 100 || UserInput < 0)
                {
 
                    MessageBox.Show("The number you have entered is invalid. Guess Between 1 and 100.");
                }
                //displays message if the user wins/guesses the correct number
                if (UserInput == GeneratedNum)
                {
                    MessageBox.Show($"Congrats Your Guess is Correct {UserInput}");
                }
                else
                {
                    MessageBox.Show($"Your Answer is Wrong Guess Again or Generate a New Number.");
                }
            }
        }

        //stops the user from entering anything besides a number
        private void UserGuessBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Numeric Inputs Only.");
            }
         

        }
    }
}
