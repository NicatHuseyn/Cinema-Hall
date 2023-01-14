
namespace XalqCinemaHall.Forms
{
    partial class Input
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblSeatsCount = new System.Windows.Forms.Label();
            this.LblSeatsColumn = new System.Windows.Forms.Label();
            this.NumSeatsCount = new System.Windows.Forms.NumericUpDown();
            this.NumSeatsColumn = new System.Windows.Forms.NumericUpDown();
            this.BtnCreateSeats = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumSeatsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumSeatsColumn)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnCreateSeats);
            this.groupBox1.Controls.Add(this.NumSeatsColumn);
            this.groupBox1.Controls.Add(this.NumSeatsCount);
            this.groupBox1.Controls.Add(this.LblSeatsColumn);
            this.groupBox1.Controls.Add(this.LblSeatsCount);
            this.groupBox1.Location = new System.Drawing.Point(73, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info Box";
            // 
            // LblSeatsCount
            // 
            this.LblSeatsCount.AutoSize = true;
            this.LblSeatsCount.Location = new System.Drawing.Point(41, 39);
            this.LblSeatsCount.Name = "LblSeatsCount";
            this.LblSeatsCount.Size = new System.Drawing.Size(48, 13);
            this.LblSeatsCount.TabIndex = 0;
            this.LblSeatsCount.Text = "Stul Sayı";
            // 
            // LblSeatsColumn
            // 
            this.LblSeatsColumn.AutoSize = true;
            this.LblSeatsColumn.Location = new System.Drawing.Point(41, 77);
            this.LblSeatsColumn.Name = "LblSeatsColumn";
            this.LblSeatsColumn.Size = new System.Drawing.Size(48, 13);
            this.LblSeatsColumn.TabIndex = 1;
            this.LblSeatsColumn.Text = "Sıra Sayı";
            // 
            // NumSeatsCount
            // 
            this.NumSeatsCount.Location = new System.Drawing.Point(129, 37);
            this.NumSeatsCount.Name = "NumSeatsCount";
            this.NumSeatsCount.Size = new System.Drawing.Size(79, 20);
            this.NumSeatsCount.TabIndex = 2;
            this.NumSeatsCount.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // NumSeatsColumn
            // 
            this.NumSeatsColumn.Location = new System.Drawing.Point(129, 75);
            this.NumSeatsColumn.Name = "NumSeatsColumn";
            this.NumSeatsColumn.Size = new System.Drawing.Size(79, 20);
            this.NumSeatsColumn.TabIndex = 3;
            this.NumSeatsColumn.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // BtnCreateSeats
            // 
            this.BtnCreateSeats.Location = new System.Drawing.Point(77, 124);
            this.BtnCreateSeats.Name = "BtnCreateSeats";
            this.BtnCreateSeats.Size = new System.Drawing.Size(88, 28);
            this.BtnCreateSeats.TabIndex = 4;
            this.BtnCreateSeats.Text = "Yarat";
            this.BtnCreateSeats.UseVisualStyleBackColor = true;
            this.BtnCreateSeats.Click += new System.EventHandler(this.BtnCreateSeats_Click);
            // 
            // Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.groupBox1);
            this.Name = "Input";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xalq Cinema";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumSeatsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumSeatsColumn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown NumSeatsColumn;
        private System.Windows.Forms.NumericUpDown NumSeatsCount;
        private System.Windows.Forms.Label LblSeatsColumn;
        private System.Windows.Forms.Label LblSeatsCount;
        private System.Windows.Forms.Button BtnCreateSeats;
    }
}