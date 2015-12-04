namespace LifeGraphics
{
    partial class LifeMainForm
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
            this.components = new System.ComponentModel.Container();
            this.pictureBoxGameScreen = new System.Windows.Forms.PictureBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.buttonStop = new System.Windows.Forms.Button();
            this.numericUpDownSize = new System.Windows.Forms.NumericUpDown();
            this.labelSize = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBegin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxGameScreen
            // 
            this.pictureBoxGameScreen.BackColor = System.Drawing.Color.Black;
            this.pictureBoxGameScreen.Location = new System.Drawing.Point(2, 2);
            this.pictureBoxGameScreen.Name = "pictureBoxGameScreen";
            this.pictureBoxGameScreen.Size = new System.Drawing.Size(600, 600);
            this.pictureBoxGameScreen.TabIndex = 0;
            this.pictureBoxGameScreen.TabStop = false;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(14, 49);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // timerGame
            // 
            this.timerGame.Interval = 50;
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(14, 116);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 2;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // numericUpDownSize
            // 
            this.numericUpDownSize.Location = new System.Drawing.Point(9, 23);
            this.numericUpDownSize.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericUpDownSize.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownSize.Name = "numericUpDownSize";
            this.numericUpDownSize.Size = new System.Drawing.Size(87, 20);
            this.numericUpDownSize.TabIndex = 3;
            this.numericUpDownSize.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(9, 7);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(76, 13);
            this.labelSize.TabIndex = 4;
            this.labelSize.Text = "Размер поля:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonBegin);
            this.panel1.Controls.Add(this.numericUpDownSize);
            this.panel1.Controls.Add(this.labelSize);
            this.panel1.Controls.Add(this.buttonStart);
            this.panel1.Controls.Add(this.buttonStop);
            this.panel1.Location = new System.Drawing.Point(608, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(101, 180);
            this.panel1.TabIndex = 5;
            // 
            // buttonBegin
            // 
            this.buttonBegin.Location = new System.Drawing.Point(14, 145);
            this.buttonBegin.Name = "buttonBegin";
            this.buttonBegin.Size = new System.Drawing.Size(75, 23);
            this.buttonBegin.TabIndex = 5;
            this.buttonBegin.Text = "Begin";
            this.buttonBegin.UseVisualStyleBackColor = true;
            this.buttonBegin.Click += new System.EventHandler(this.buttonBegin_Click);
            // 
            // LifeMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 613);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxGameScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LifeMainForm";
            this.Text = "LIFE";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxGameScreen;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.NumericUpDown numericUpDownSize;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonBegin;
    }
}

