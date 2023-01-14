
namespace XalqCinemaHall.Forms
{
    partial class Hall
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnLSeats = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSaved = new System.Windows.Forms.Button();
            this.LblSavePrice = new System.Windows.Forms.Label();
            this.LblSaveSeatPrice = new System.Windows.Forms.Label();
            this.LblSaveSeats = new System.Windows.Forms.Label();
            this.LblSeat = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnLSeats
            // 
            this.PnLSeats.Location = new System.Drawing.Point(1, 0);
            this.PnLSeats.Name = "PnLSeats";
            this.PnLSeats.Size = new System.Drawing.Size(498, 352);
            this.PnLSeats.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnSaved);
            this.panel1.Controls.Add(this.LblSavePrice);
            this.panel1.Controls.Add(this.LblSaveSeatPrice);
            this.panel1.Controls.Add(this.LblSaveSeats);
            this.panel1.Controls.Add(this.LblSeat);
            this.panel1.Location = new System.Drawing.Point(505, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 147);
            this.panel1.TabIndex = 1;
            // 
            // BtnSaved
            // 
            this.BtnSaved.Location = new System.Drawing.Point(49, 97);
            this.BtnSaved.Name = "BtnSaved";
            this.BtnSaved.Size = new System.Drawing.Size(75, 28);
            this.BtnSaved.TabIndex = 5;
            this.BtnSaved.Text = "Təsdiqlə";
            this.BtnSaved.UseVisualStyleBackColor = true;
            this.BtnSaved.Click += new System.EventHandler(this.BtnSaved_Click);
            // 
            // LblSavePrice
            // 
            this.LblSavePrice.AutoSize = true;
            this.LblSavePrice.Location = new System.Drawing.Point(103, 57);
            this.LblSavePrice.Name = "LblSavePrice";
            this.LblSavePrice.Size = new System.Drawing.Size(0, 13);
            this.LblSavePrice.TabIndex = 3;
            // 
            // LblSaveSeatPrice
            // 
            this.LblSaveSeatPrice.AutoSize = true;
            this.LblSaveSeatPrice.Location = new System.Drawing.Point(12, 57);
            this.LblSaveSeatPrice.Name = "LblSaveSeatPrice";
            this.LblSaveSeatPrice.Size = new System.Drawing.Size(75, 13);
            this.LblSaveSeatPrice.TabIndex = 2;
            this.LblSaveSeatPrice.Text = "Yekun məbləğ";
            // 
            // LblSaveSeats
            // 
            this.LblSaveSeats.AutoSize = true;
            this.LblSaveSeats.Location = new System.Drawing.Point(103, 26);
            this.LblSaveSeats.Name = "LblSaveSeats";
            this.LblSaveSeats.Size = new System.Drawing.Size(0, 13);
            this.LblSaveSeats.TabIndex = 1;
            // 
            // LblSeat
            // 
            this.LblSeat.AutoSize = true;
            this.LblSeat.Location = new System.Drawing.Point(12, 26);
            this.LblSeat.Name = "LblSeat";
            this.LblSeat.Size = new System.Drawing.Size(75, 13);
            this.LblSeat.TabIndex = 0;
            this.LblSeat.Text = "Seçilmiş stullar";
            // 
            // Hall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 372);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnLSeats);
            this.Name = "Hall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hall";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Hall_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnLSeats;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSaved;
        private System.Windows.Forms.Label LblSavePrice;
        private System.Windows.Forms.Label LblSaveSeatPrice;
        private System.Windows.Forms.Label LblSaveSeats;
        private System.Windows.Forms.Label LblSeat;
    }
}