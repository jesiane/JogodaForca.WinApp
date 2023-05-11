namespace JogodaForca.WinApp
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
            gbJogo = new GroupBox();
            btn2 = new Button();
            btnItems = new Button();
            listForca = new ListBox();
            txtSolucao = new TextBox();
            gbLetra = new GroupBox();
            btnOK = new Button();
            textLetra = new TextBox();
            groupBox2 = new GroupBox();
            lblTrestantes = new Label();
            groupBox1 = new GroupBox();
            lblTtentativas = new Label();
            label2 = new Label();
            textPalavraSecreta = new TextBox();
            btnStart = new Button();
            gbJogo.SuspendLayout();
            gbLetra.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // gbJogo
            // 
            gbJogo.BackColor = SystemColors.ActiveCaption;
            gbJogo.Controls.Add(btn2);
            gbJogo.Controls.Add(btnItems);
            gbJogo.Controls.Add(listForca);
            gbJogo.Controls.Add(txtSolucao);
            gbJogo.Controls.Add(gbLetra);
            gbJogo.Controls.Add(groupBox2);
            gbJogo.Controls.Add(groupBox1);
            gbJogo.Controls.Add(label2);
            gbJogo.Controls.Add(textPalavraSecreta);
            gbJogo.Location = new Point(4, 4);
            gbJogo.Name = "gbJogo";
            gbJogo.Size = new Size(402, 397);
            gbJogo.TabIndex = 0;
            gbJogo.TabStop = false;
            gbJogo.Text = "Jogo da Forca";
            gbJogo.Visible = false;
            // 
            // btn2
            // 
            btn2.BackColor = Color.FromArgb(255, 192, 255);
            btn2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.Location = new Point(380, 374);
            btn2.Name = "btn2";
            btn2.Size = new Size(22, 23);
            btn2.TabIndex = 12;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btnItems
            // 
            btnItems.BackColor = Color.FromArgb(64, 0, 64);
            btnItems.Location = new Point(36, 328);
            btnItems.Name = "btnItems";
            btnItems.Size = new Size(24, 26);
            btnItems.TabIndex = 11;
            btnItems.Text = ".";
            btnItems.UseVisualStyleBackColor = false;
            btnItems.Click += btnItems_Click;
            // 
            // listForca
            // 
            listForca.FormattingEnabled = true;
            listForca.ItemHeight = 15;
            listForca.Location = new Point(36, 235);
            listForca.Name = "listForca";
            listForca.Size = new Size(120, 94);
            listForca.TabIndex = 10;
            // 
            // txtSolucao
            // 
            txtSolucao.Location = new Point(209, 65);
            txtSolucao.Name = "txtSolucao";
            txtSolucao.Size = new Size(100, 23);
            txtSolucao.TabIndex = 9;
            // 
            // gbLetra
            // 
            gbLetra.Controls.Add(btnOK);
            gbLetra.Controls.Add(textLetra);
            gbLetra.Location = new Point(18, 113);
            gbLetra.Name = "gbLetra";
            gbLetra.RightToLeft = RightToLeft.No;
            gbLetra.Size = new Size(200, 100);
            gbLetra.TabIndex = 7;
            gbLetra.TabStop = false;
            gbLetra.Text = "Escreva uma letra";
            // 
            // btnOK
            // 
            btnOK.Location = new Point(112, 22);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 1;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // textLetra
            // 
            textLetra.Location = new Point(6, 22);
            textLetra.MaxLength = 1;
            textLetra.Name = "textLetra";
            textLetra.Size = new Size(100, 23);
            textLetra.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblTrestantes);
            groupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(259, 284);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(121, 100);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tentativas Restantes";
            // 
            // lblTrestantes
            // 
            lblTrestantes.AutoSize = true;
            lblTrestantes.BackColor = Color.FromArgb(255, 192, 192);
            lblTrestantes.Location = new Point(55, 53);
            lblTrestantes.Name = "lblTrestantes";
            lblTrestantes.Size = new Size(12, 17);
            lblTrestantes.TabIndex = 4;
            lblTrestantes.Text = ".";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblTtentativas);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(264, 178);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(116, 100);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Total de Tentativas";
            // 
            // lblTtentativas
            // 
            lblTtentativas.AutoSize = true;
            lblTtentativas.BackColor = Color.FromArgb(255, 192, 192);
            lblTtentativas.Location = new Point(50, 57);
            lblTtentativas.Name = "lblTtentativas";
            lblTtentativas.Size = new Size(12, 17);
            lblTtentativas.TabIndex = 4;
            lblTtentativas.Text = ".";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(19, 42);
            label2.Name = "label2";
            label2.Size = new Size(184, 17);
            label2.TabIndex = 3;
            label2.Text = "Identifique a Palavra Secreta";
            // 
            // textPalavraSecreta
            // 
            textPalavraSecreta.Location = new Point(18, 65);
            textPalavraSecreta.Name = "textPalavraSecreta";
            textPalavraSecreta.Size = new Size(185, 23);
            textPalavraSecreta.TabIndex = 2;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(4, 407);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(402, 23);
            btnStart.TabIndex = 1;
            btnStart.Text = "Começar";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 440);
            Controls.Add(btnStart);
            Controls.Add(gbJogo);
            Name = "Form1";
            Text = "Form1";
            gbJogo.ResumeLayout(false);
            gbJogo.PerformLayout();
            gbLetra.ResumeLayout(false);
            gbLetra.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbJogo;
        private Button btnStart;
        private Label label2;
        private TextBox textPalavraSecreta;
        private GroupBox gbLetra;
        private TextBox textLetra;
        private GroupBox groupBox2;
        private Label lblTrestantes;
        private GroupBox groupBox1;
        private Label lblTtentativas;
        private Button btnOK;
        private TextBox txtSolucao;
        private Button btnItems;
        private ListBox listForca;
        private Button btn2;
    }
}