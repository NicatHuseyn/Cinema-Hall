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
    public partial class Input : Form
    {
        public Input()
        {
            InitializeComponent();
        }

        private void BtnCreateSeats_Click(object sender, EventArgs e)
        {
            Hall hall = new Hall(NumSeatsCount.Value, NumSeatsColumn.Value);
            hall.Show();
        }
    }
}
