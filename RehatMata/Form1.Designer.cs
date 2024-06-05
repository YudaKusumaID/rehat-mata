namespace RehatMata
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnStart = new Button();
            panel1 = new Panel();
            UlangiSetiapKali = new Label();
            lblWaktuIstirahatDetik = new Label();
            lblWaktuDepanLayarDetik = new Label();
            radioUlangiSetiap = new RadioButton();
            radioTakTerbatas = new RadioButton();
            numberUDSetiap = new NumericUpDown();
            lblUlangi = new Label();
            lblPengaturan = new Label();
            txtbIstirahat = new TextBox();
            lblWaktuIstirahat = new Label();
            txtbDepanLayar = new TextBox();
            lblWaktuDepanLayar = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numberUDSetiap).BeginInit();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.FromArgb(88, 129, 87);
            btnStart.FlatAppearance.BorderSize = 0;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Montserrat", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnStart.ForeColor = Color.White;
            btnStart.Location = new Point(272, 290);
            btnStart.Name = "btnStart";
            btnStart.Padding = new Padding(10);
            btnStart.Size = new Size(131, 54);
            btnStart.TabIndex = 0;
            btnStart.Text = "Mulai";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(UlangiSetiapKali);
            panel1.Controls.Add(lblWaktuIstirahatDetik);
            panel1.Controls.Add(lblWaktuDepanLayarDetik);
            panel1.Controls.Add(radioUlangiSetiap);
            panel1.Controls.Add(radioTakTerbatas);
            panel1.Controls.Add(numberUDSetiap);
            panel1.Controls.Add(lblUlangi);
            panel1.Controls.Add(lblPengaturan);
            panel1.Controls.Add(txtbIstirahat);
            panel1.Controls.Add(lblWaktuIstirahat);
            panel1.Controls.Add(txtbDepanLayar);
            panel1.Controls.Add(lblWaktuDepanLayar);
            panel1.Location = new Point(19, 19);
            panel1.Margin = new Padding(10);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(384, 258);
            panel1.TabIndex = 1;
            // 
            // UlangiSetiapKali
            // 
            UlangiSetiapKali.AutoSize = true;
            UlangiSetiapKali.Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point);
            UlangiSetiapKali.Location = new Point(322, 165);
            UlangiSetiapKali.Name = "UlangiSetiapKali";
            UlangiSetiapKali.Size = new Size(27, 15);
            UlangiSetiapKali.TabIndex = 11;
            UlangiSetiapKali.Text = "Kali";
            // 
            // lblWaktuIstirahatDetik
            // 
            lblWaktuIstirahatDetik.AutoSize = true;
            lblWaktuIstirahatDetik.Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point);
            lblWaktuIstirahatDetik.Location = new Point(322, 123);
            lblWaktuIstirahatDetik.Name = "lblWaktuIstirahatDetik";
            lblWaktuIstirahatDetik.Size = new Size(37, 15);
            lblWaktuIstirahatDetik.TabIndex = 10;
            lblWaktuIstirahatDetik.Text = "Detik";
            // 
            // lblWaktuDepanLayarDetik
            // 
            lblWaktuDepanLayarDetik.AutoSize = true;
            lblWaktuDepanLayarDetik.Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point);
            lblWaktuDepanLayarDetik.Location = new Point(322, 80);
            lblWaktuDepanLayarDetik.Name = "lblWaktuDepanLayarDetik";
            lblWaktuDepanLayarDetik.Size = new Size(37, 15);
            lblWaktuDepanLayarDetik.TabIndex = 9;
            lblWaktuDepanLayarDetik.Text = "Detik";
            // 
            // radioUlangiSetiap
            // 
            radioUlangiSetiap.AutoSize = true;
            radioUlangiSetiap.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            radioUlangiSetiap.Location = new Point(146, 162);
            radioUlangiSetiap.Name = "radioUlangiSetiap";
            radioUlangiSetiap.Size = new Size(62, 20);
            radioUlangiSetiap.TabIndex = 8;
            radioUlangiSetiap.TabStop = true;
            radioUlangiSetiap.Text = "Setiap";
            radioUlangiSetiap.UseVisualStyleBackColor = true;
            // 
            // radioTakTerbatas
            // 
            radioTakTerbatas.AutoSize = true;
            radioTakTerbatas.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            radioTakTerbatas.Location = new Point(146, 203);
            radioTakTerbatas.Margin = new Padding(10);
            radioTakTerbatas.Name = "radioTakTerbatas";
            radioTakTerbatas.Size = new Size(100, 20);
            radioTakTerbatas.TabIndex = 7;
            radioTakTerbatas.TabStop = true;
            radioTakTerbatas.Text = "Tak Terbatas";
            radioTakTerbatas.UseVisualStyleBackColor = true;
            // 
            // numberUDSetiap
            // 
            numberUDSetiap.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            numberUDSetiap.Location = new Point(220, 161);
            numberUDSetiap.Margin = new Padding(10);
            numberUDSetiap.Name = "numberUDSetiap";
            numberUDSetiap.Size = new Size(80, 22);
            numberUDSetiap.TabIndex = 6;
            // 
            // lblUlangi
            // 
            lblUlangi.AutoSize = true;
            lblUlangi.Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point);
            lblUlangi.Location = new Point(26, 165);
            lblUlangi.Name = "lblUlangi";
            lblUlangi.Size = new Size(43, 15);
            lblUlangi.TabIndex = 5;
            lblUlangi.Text = "Ulangi";
            // 
            // lblPengaturan
            // 
            lblPengaturan.AutoSize = true;
            lblPengaturan.Font = new Font("Montserrat SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPengaturan.Location = new Point(13, 10);
            lblPengaturan.Name = "lblPengaturan";
            lblPengaturan.Padding = new Padding(10);
            lblPengaturan.Size = new Size(149, 46);
            lblPengaturan.TabIndex = 4;
            lblPengaturan.Text = "Pengaturan";
            // 
            // txtbIstirahat
            // 
            txtbIstirahat.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            txtbIstirahat.Location = new Point(146, 119);
            txtbIstirahat.Margin = new Padding(10);
            txtbIstirahat.Name = "txtbIstirahat";
            txtbIstirahat.Size = new Size(154, 22);
            txtbIstirahat.TabIndex = 3;
            txtbIstirahat.Text = "25";
            txtbIstirahat.TextChanged += txtbIstirahat_TextChanged;
            // 
            // lblWaktuIstirahat
            // 
            lblWaktuIstirahat.AutoSize = true;
            lblWaktuIstirahat.Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point);
            lblWaktuIstirahat.Location = new Point(26, 123);
            lblWaktuIstirahat.Name = "lblWaktuIstirahat";
            lblWaktuIstirahat.Size = new Size(86, 15);
            lblWaktuIstirahat.TabIndex = 2;
            lblWaktuIstirahat.Text = "Waktu Istirahat";
            // 
            // txtbDepanLayar
            // 
            txtbDepanLayar.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            txtbDepanLayar.Location = new Point(146, 76);
            txtbDepanLayar.Margin = new Padding(10);
            txtbDepanLayar.Name = "txtbDepanLayar";
            txtbDepanLayar.Size = new Size(154, 22);
            txtbDepanLayar.TabIndex = 1;
            txtbDepanLayar.Text = "1200";
            txtbDepanLayar.TextChanged += txtbDepanLayar_TextChanged;
            // 
            // lblWaktuDepanLayar
            // 
            lblWaktuDepanLayar.AutoSize = true;
            lblWaktuDepanLayar.Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point);
            lblWaktuDepanLayar.Location = new Point(26, 80);
            lblWaktuDepanLayar.Name = "lblWaktuDepanLayar";
            lblWaktuDepanLayar.Size = new Size(112, 15);
            lblWaktuDepanLayar.TabIndex = 0;
            lblWaktuDepanLayar.Text = "Waktu Depan Layar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(426, 363);
            Controls.Add(panel1);
            Controls.Add(btnStart);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rehat Mata";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numberUDSetiap).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnStart;
        private Panel panel1;
        private Label lblWaktuDepanLayar;
        private TextBox txtbIstirahat;
        private Label lblWaktuIstirahat;
        private TextBox txtbDepanLayar;
        private Label lblUlangi;
        private Label lblPengaturan;
        private NumericUpDown numberUDSetiap;
        private RadioButton radioTakTerbatas;
        private RadioButton radioUlangiSetiap;
        private Label UlangiSetiapKali;
        private Label lblWaktuIstirahatDetik;
        private Label lblWaktuDepanLayarDetik;
        private System.Windows.Forms.Timer timer1;
    }
}