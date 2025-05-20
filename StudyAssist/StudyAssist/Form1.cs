namespace StudyAssist
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Notes notes = new Notes();
            notes.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Draw draw = new Draw();
            draw.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Converter converter = new Converter();
            converter.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ToDo todo = new ToDo();
            todo.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            calculator.Show();
            this.Hide();
        }
    }
}
