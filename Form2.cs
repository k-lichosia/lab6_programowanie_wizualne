using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6_wizualne
{
    public partial class Form2 : Form
    {
        public int X { get; set; }
        public int Y { get; set; }  
        public int Dydelfy {  get; set; }
        public int Krokodyle {  get; set; }
        public int Szopy {  get; set; }
        public int Czas { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //Zatwierdź
        {
            int x, y, dydelfy, krokodyle, szopy, czas;

            // Sprawdzamy, czy wartości wprowadzone przez użytkownika mieszczą się w wymaganych zakresach
            if (int.TryParse(textBox1.Text, out x) && x >= 3 && x <= 10 &&
                int.TryParse(textBox2.Text, out y) && y >= 3 && y <= 10 &&
                int.TryParse(textBox3.Text, out dydelfy) && dydelfy >= 1 && dydelfy <= 6 &&
                int.TryParse(textBox4.Text, out krokodyle) && (krokodyle == 0 || krokodyle == 1) &&
                int.TryParse(textBox6.Text, out szopy) && szopy >= 3 && szopy <= 8 &&
                int.TryParse(textBox5.Text, out czas) && czas >= 10 && czas <= 60)
            {
                // Jeśli wszystkie dane są poprawne
                X = x;
                Y = y;
                Dydelfy = dydelfy;
                Krokodyle = krokodyle;
                Szopy = szopy;
                Czas = czas;

                this.Close();
            }
            else
            {
                // Jeśli dane są niepoprawne, wyświetlamy komunikat o błędzie
                MessageBox.Show("Wprowadzone dane są niepoprawne. Sprawdź zakresy wartości:\n" +
                                "X i Y: od 3 do 10\n" +
                                "Dydelfy: od 1 do 6\n" +
                                "Krokodyle: 0 lub 1\n" +
                                "Szopy: od 3 do 8\n" +
                                "Czas: od 10 do 60", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
