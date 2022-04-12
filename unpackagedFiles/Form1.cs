using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace CandyCrush
{
    public partial class Form1 : Form
    {
        private static bool resetting = false;
        private int moveCount = 0;
        private Btn[,] grid;
        private Color originalColor;
        private Color currentColor = Color.LightCoral;
        private int rows, cols;
        private Dictionary<Color, int> existingColors = new Dictionary<Color, int>();
        private static int totalButtons = 0;
        private static string winningColor;
        private static Dictionary<Color, string> convertColor = new Dictionary<Color, string>()
            {
                [Color.LightCoral] = "Red",
                [Color.Gold] = "Yellow",
                [Color.RoyalBlue] = "Blue",
                [Color.PaleGreen] = "Green",
                [Color.BurlyWood] = "Brown",
                [Color.BlueViolet] = "Purple"
            };

        public Form1()
        {
            InitializeComponent();

            // display selected color
            pictureBox1.BackColor = currentColor;

            // setup existingColors
            foreach (Color color in Btn.colors)
                existingColors.Add(color, 0);

            PopulateGrid();
        }
        
        // function for btn_reset_Click()
        private void timer()
        {
            resetting = true;
            Thread.Sleep(1650);
            resetting = false;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            if (resetting) return;

            // prevent reset spamming
            Thread thr = new Thread(new ThreadStart(timer));
            thr.Start();

            // reset move count
            moveCount = 0;
            lbl_moveCounter.Text = "Move: 0";
            
            // reset field
            panel1.Controls.Clear();
            PopulateGrid();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '1':
                    currentColor = Color.LightCoral;
                    break;

                case '2':
                    currentColor = Color.Gold;
                    break;

                case '3':
                    currentColor = Color.RoyalBlue;
                    break;

                case '4':
                    currentColor = Color.PaleGreen;
                    break;

                case '5':
                    currentColor = Color.BurlyWood;
                    break;

                case '6':
                    currentColor = Color.BlueViolet;
                    break;

            }
            pictureBox1.BackColor = currentColor;
        }


        private void PopulateGrid()
        {
            // calculate the number of rows and columns
            cols = panel1.Height / Btn.size;
            rows = panel1.Width / Btn.size;
            
            // specify values of empty 2d list
            grid = new Btn[rows, cols];

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    // create new button at a grid position, and then set its date attrs
                    grid[r, c] = new Btn();
                    grid[r, c].row = r;
                    grid[r, c].col = c;

                    // click event handler
                    grid[r, c].Click += Btn_Click;
                    panel1.Controls.Add(grid[r, c]);

                    // set location data; we multiply to get the pixel location (amount of buttons * size of button = location)
                    grid[r, c].Location = new Point(r * Btn.size, c * Btn.size);

                    // set keypress handler
                    grid[r, c].KeyPress += Form1_KeyPress;

                    // update existingColors data
                    existingColors[grid[r, c].BackColor]++;

                    totalButtons += 1;
                }
            }
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button; // as is type-casting
            
            // set current color
            currentColor = btn.BackColor;

            // display selected color
            pictureBox1.BackColor = currentColor;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            // figure out which button was clicked
            Btn btn = sender as Btn;

            // color
            originalColor = btn.BackColor;

            // avoid error when clicking on cell where its backcolor == currentColor
            if (originalColor == currentColor) return;

            // update move count
            moveCount++;
            lbl_moveCounter.Text = "Move: " + moveCount;

            // flood fill recursion
            FloodFill(btn.row, btn.col);
            
            // win checker. Show "play again" message when they win
            if (CheckWin())
            {
                DialogResult response = MessageBox.Show(text: $"It took you {moveCount} moves to switch all squares to {winningColor.ToLower()}. Play again?", caption: "You won! ", buttons: MessageBoxButtons.YesNo, icon: MessageBoxIcon.None, defaultButton: MessageBoxDefaultButton.Button1);
                if (response == DialogResult.Yes) btn_reset_Click(sender = null, e = null);
                else if (response == DialogResult.No) this.Close();
            }
        }

        private bool CheckWin()
        {
            bool win = false;
            foreach (KeyValuePair<Color, int> kvp in existingColors)
            {
                win = (kvp.Value == totalButtons); // whole screen is taken up if this is true, meaning player won
                if (win) { winningColor = convertColor[kvp.Key]; break; }
            }
            return win;

        }

        private void FloodFill(int row, int col)
        {
            // base case
            // if the current cell that is about to be colored in is out of bounds, or is NOT the same color as the clicked cell, don't color it in.
            if (!isValid(row, col) || !grid[row, col].BackColor.Equals(originalColor)) return;

            // update button-count data values
            existingColors[grid[row, col].BackColor]--;
            existingColors[currentColor]++;

            // change the color of the clicked cell
            grid[row, col].BackColor = currentColor;

            //
            // straight
            //
            // apply to the cell to the right of the clicked cell (row + 1)
            FloodFill(row + 1, col); // recursion

            // apply to the left of the clicked cell
            FloodFill(row-1, col);

            // apply to the bottom of the clicked cell
            FloodFill(row, col-1);

            // apply to the bottom of the clicked cell
            FloodFill(row, col + 1);
            //
            // diagonals
            //
            // apply to top right of the clicked cell
            FloodFill(row-1, col+1);

            // apply to top left of the clicked cell
            FloodFill(row - 1, col - 1);

            // apply to bottom right of the clicked cell
            FloodFill(row + 1, col + 1);

            // apply to bottom left of the clicked cell
            FloodFill(row + 1, col - 1);
        }

        private bool isValid(int row, int col)
        {
            return (row < rows && row >= 0 && col < cols && col >= 0);
        }
    }
}
