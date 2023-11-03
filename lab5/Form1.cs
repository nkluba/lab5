namespace lab5
{
    public partial class Form1 : Form
    {
        private int secretNumber;
        private int attempts;

        public Form1()
        {
            InitializeComponent();
            NewGame();
        }

        private void NewGame()
        {
            Random random = new Random();
            secretNumber = random.Next(1, 101);
            attempts = 0;
        }

        private void CheckGuess()
        {
            int userGuess;
            if (int.TryParse(textBox1.Text, out userGuess))
            {
                attempts++;
                if (userGuess < secretNumber)
                {
                    MessageBox.Show("Too low, try again.");
                }
                else if (userGuess > secretNumber)
                {
                    MessageBox.Show("Too high, try again.");
                }
                else
                {
                    MessageBox.Show($"Congratulations! You guessed the number {secretNumber} in {attempts} attempts.");
                    NewGame();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckGuess();
        }
    }
}