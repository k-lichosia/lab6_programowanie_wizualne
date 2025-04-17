namespace lab6_wizualne
{
    public partial class Form1 : Form
    {
        public int x = 4;
        public int y = 4;
        public int dydelfy = 4;
        public int krokodyle = 1;
        public int szopy = 3;
        public int czas = 60;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //START
        {
            Form3 form3 = new Form3(x, y, czas, dydelfy, krokodyle, szopy);
            form3.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) //USTAWIENIA
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            x = form2.X;
            y = form2.Y;
            dydelfy = form2.Dydelfy;
            krokodyle = form2.Krokodyle;
            szopy = form2.Szopy;
            czas = form2.Czas;
            //MessageBox.Show("x: " + x + ", y: " + y + ", dydelfy: " + dydelfy + ", krokodyle: " + krokodyle + ", czas: " + czas);
        }

        private void button3_Click(object sender, EventArgs e) //KONIEC
        {
            //MessageBox.Show("x: " + x + ", y: " + y);
            this.Close();
        }
    }
}
