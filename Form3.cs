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
    public partial class Form3 : Form
    {
        private int rows;
        private int columns;
        private Button[,] buttons;
        private string[,] boardContent; 
        private int timeLeft;
        private int dydelfy;
        private int krokodyle;
        private int szopy;

        public Form3(int rows, int columns, int timeLeft, int dydelfy, int krokodyle, int szopy)
        {
            InitializeComponent();
            this.rows = rows;
            this.columns = columns;
            this.timeLeft = timeLeft;   
            this.dydelfy = dydelfy;
            this.krokodyle = krokodyle;
            this.szopy = szopy;
            buttons = new Button[rows, columns];
            boardContent = new string[rows, columns];
            InitializeBoard();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void InitializeBoard()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Button button = new Button
                    {
                        Width = 50,
                        Height = 50,
                        Top = i * 50,
                        Left = j * 50,
                        BackColor = Color.Gray
                    };
                    button.Click += Button_Click;
                    buttons[i, j] = button;
                    Controls.Add(button);
                }
            }

            List<(int row, int col)> allPositions = new List<(int, int)>();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    allPositions.Add((i, j));
                }
            }

            Random rand = new Random();
            allPositions = allPositions.OrderBy(x => rand.Next()).ToList();

            int index = 0;

            for (int i = 0; i < dydelfy && index < allPositions.Count; i++, index++)
            {
                var pos = allPositions[index];
                boardContent[pos.row, pos.col] = "dydelf";
            }

            for (int i = 0; i < szopy && index < allPositions.Count; i++, index++)
            {
                var pos = allPositions[index];
                boardContent[pos.row, pos.col] = "szop";
            }

            for (int i = 0; i < krokodyle && index < allPositions.Count; i++, index++)
            {
                var pos = allPositions[index];
                boardContent[pos.row, pos.col] = "krokodyl";
            }

            for (; index < allPositions.Count; index++)
            {
                var pos = allPositions[index];
                boardContent[pos.row, pos.col] = "empty";
            }

            StartGameAsync();
        }

        private async void StartGameAsync()
        {
            while (timeLeft > 0)
            {
                labelTime.Text = $"Czas: {timeLeft}s";
                await Task.Delay(1000); // Czekaj 1 sekundę
                timeLeft--;
            }

            if (timeLeft == 0)
            {
                MessageBox.Show("Czas się skończył! Przegrałeś!");
                this.Close();
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            int row = clickedButton.Top / 50;
            int col = clickedButton.Left / 50;

            if (boardContent[row, col] == "empty")
            {
                clickedButton.BackColor = Color.White;
                clickedButton.Enabled = false;
            }
            else if (boardContent[row, col] == "dydelf")
            {
                clickedButton.BackColor = Color.Green;
                CheckDydelf();
            }
            else if (boardContent[row, col] == "szop")
            {
                clickedButton.BackColor = Color.Blue;
                CheckSzop(clickedButton);
            }
            else if (boardContent[row, col] == "krokodyl")
            {
                clickedButton.BackColor = Color.Red;
                if (clickedButton.Tag != null && clickedButton.Tag.ToString() == "aktywny_krokodyl")
                {
                    clickedButton.BackColor = Color.DarkGreen;
                    clickedButton.Enabled = false;
                    clickedButton.Tag = "zamkniety_krokodyl";
                }
                else
                {
                    clickedButton.BackColor = Color.Red;
                    CheckKrokodyl(clickedButton); 
                }
            }
        }

        private void CheckDydelf ()
        {
            dydelfy--;
            if (dydelfy == 0)
            {
                MessageBox.Show("Wszystkie dydelfy zostały odnalezione na czas! GRATULACJE!");
                this.Close();
            }
        }

        private async void CheckSzop(Button clickedButton)
        {
            clickedButton.Tag = "aktywny_szop";

            await Task.Delay(2000);

            if (clickedButton.Tag != null && clickedButton.Tag.ToString() == "aktywny_szop")
            {
                int greenCount = 0;
                int row = clickedButton.Top / 50;
                int col = clickedButton.Left / 50;

                for (int i = row - 1; i <= row + 1; i++)
                {
                    for (int j = col - 1; j <= col + 1; j++)
                    {
                        if (i >= 0 && i < rows && j >= 0 && j < columns)
                        {
                            Button btn = buttons[i, j];
                            if (btn.BackColor == Color.Green)
                            {
                                greenCount++;
                            }

                            btn.BackColor = Color.Gray;
                        }
                    }
                }

                dydelfy += greenCount;
            }
        }

        private async void CheckKrokodyl(Button clickedButton)
        {
            clickedButton.Tag = "aktywny_krokodyl";

            await Task.Delay(2000); 

            if (clickedButton.Tag != null && clickedButton.Tag.ToString() == "aktywny_krokodyl")
            {
                MessageBox.Show("Zatrzymałeś krokodyla za późno! Przegrałeś!");
                this.Close();
            }
        }

    }
}
