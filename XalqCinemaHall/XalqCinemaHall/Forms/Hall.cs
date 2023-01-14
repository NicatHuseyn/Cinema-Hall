using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XalqCinemaHall.Forms
{
    public partial class Hall : Form
    {
        // 
        private decimal _seatsCount;
        private decimal _seatsColumn;

        // list for save buttons

        List<Button> selectSeats = new List<Button>();

        #region Hall constructor
        public Hall(decimal SeatsCount, decimal SeatsColumn)
        {
            InitializeComponent();

            this._seatsCount = SeatsCount;
            this._seatsColumn = SeatsColumn;

            // Method call CreateSeats
            this.CreateSeats();
        }
        #endregion

        #region event method to close the application
        private void Hall_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Cerated Seats
        private void CreateSeats()
        {
            if (this._seatsCount == 0 || this._seatsColumn ==0)
            {
                MessageBox.Show("Oturacaq sayı və Sıra Sayı Seçməlisiniz");
                return;
            }
            else
            {
                // mövqeləri düzəltmək üçün kod

                int x = 20;
                int y = 20;
                for (int i = 0; i < this._seatsCount; i++)
                {
                    Button button = new Button();
                    button.Text = (i + 1).ToString();
                    button.Size = new Size(30,30);
                    button.Location = new Point(x,y);
                    button.BackColor = Color.White;
                    button.ForeColor = Color.Black;

                    // code for button event clicked 
                    button.Click +=new  EventHandler(AllSeats_Click);

                    // code for Button border none
                    button.TabStop = false;
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;


                    PnLSeats.Controls.Add(button);

                    x += 40;

                    if ((i+1)% this._seatsColumn == 0)
                    {
                        x = 20;
                        y += 40;
                    }
                }
            }
        }
        #endregion

        #region Selected Seats
        private void AllSeats_Click(object sender, EventArgs e)
        {
            Button clickedSeat = sender as Button;

            if (clickedSeat.BackColor == Color.White)
            {
                clickedSeat.BackColor = Color.Green;
                clickedSeat.ForeColor = Color.White;
                selectSeats.Add(clickedSeat);
                CalcTotalPrice();
                this.DisplaySeatsSelected();
            }
            else if (clickedSeat.BackColor == Color.Green)
            {
                clickedSeat.BackColor = Color.White;
                clickedSeat.ForeColor = Color.Black;
                selectSeats.Remove(clickedSeat);
                CalcTotalPrice();
                this.DisplaySeatsSelected();
            }
            else
            {
                DialogResult result = MessageBox.Show("Bu bileti ləğv etmək istəyirsinizmi?","Bilet ləğvi",MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    clickedSeat.BackColor = Color.White;
                    clickedSeat.ForeColor = Color.Black;
                    selectSeats.Remove(clickedSeat);
                }
            }
            
        }
        #endregion

        #region total price of tickets sold
        // Method for clalc all seats price
        private void CalcTotalPrice()
        {
            if (selectSeats.Count == 0)
            {
                LblSavePrice.Text = "";
            }
            else
            {
                LblSavePrice.Text = (selectSeats.Count * 5).ToString();
            }
        }
        #endregion

        #region number of selected chairs
        private void DisplaySeatsSelected()
        {
            LblSaveSeats.Text = string.Join(",",selectSeats.Select(s=>s.Text).ToArray());
        }
        #endregion

        #region ticket sales confirmation
        private void BtnSaved_Click(object sender, EventArgs e)
        {
            if (selectSeats.Count == 0)
            {
                MessageBox.Show("Heç bir yer seçilməyib");
                return;
            }
            foreach (Button seat in this.selectSeats)
            {
                seat.BackColor = Color.Blue;
                seat.ForeColor = Color.White;
            }

            this.LblSaveSeats.Text = "";
            this.LblSavePrice.Text = "";

            MessageBox.Show("Biletlər satıldı. Təşəkkürlər!");
        }
        #endregion
    }
}
