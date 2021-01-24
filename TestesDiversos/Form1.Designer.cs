
namespace DominoV5
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnJogador = new System.Windows.Forms.Panel();
            this.pnMesa = new System.Windows.Forms.Panel();
            this.picteste = new System.Windows.Forms.PictureBox();
            this.labTotalJ1 = new System.Windows.Forms.Label();
            this.labDir = new System.Windows.Forms.Label();
            this.labEsq = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tmrQuebra = new System.Windows.Forms.Timer(this.components);
            this.lblInfoPnmesa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblInfoPicTeste = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtXmesa = new System.Windows.Forms.TextBox();
            this.txtYmesa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAlturaPnMesa = new System.Windows.Forms.TextBox();
            this.txtLargunaPnMesa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTotalPedraMesa = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tmrContaMesa = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picteste)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnJogador
            // 
            this.pnJogador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnJogador.AutoSize = true;
            this.pnJogador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnJogador.Location = new System.Drawing.Point(134, 653);
            this.pnJogador.Name = "pnJogador";
            this.pnJogador.Size = new System.Drawing.Size(1245, 100);
            this.pnJogador.TabIndex = 0;
            // 
            // pnMesa
            // 
            this.pnMesa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnMesa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnMesa.Location = new System.Drawing.Point(250, 30);
            this.pnMesa.Name = "pnMesa";
            this.pnMesa.Size = new System.Drawing.Size(900, 600);
            this.pnMesa.TabIndex = 1;
            this.pnMesa.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnMesa_MouseClick);
            this.pnMesa.MouseLeave += new System.EventHandler(this.pnMesa_MouseLeave);
            this.pnMesa.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnMesa_MouseMove);
            // 
            // picteste
            // 
            this.picteste.BackColor = System.Drawing.SystemColors.HotTrack;
            this.picteste.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picteste.Location = new System.Drawing.Point(186, 525);
            this.picteste.Name = "picteste";
            this.picteste.Size = new System.Drawing.Size(40, 40);
            this.picteste.TabIndex = 0;
            this.picteste.TabStop = false;
            // 
            // labTotalJ1
            // 
            this.labTotalJ1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labTotalJ1.AutoSize = true;
            this.labTotalJ1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labTotalJ1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labTotalJ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTotalJ1.Location = new System.Drawing.Point(45, 61);
            this.labTotalJ1.Name = "labTotalJ1";
            this.labTotalJ1.Size = new System.Drawing.Size(23, 26);
            this.labTotalJ1.TabIndex = 4;
            this.labTotalJ1.Text = "0";
            // 
            // labDir
            // 
            this.labDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labDir.AutoSize = true;
            this.labDir.BackColor = System.Drawing.SystemColors.Info;
            this.labDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDir.Location = new System.Drawing.Point(173, 2);
            this.labDir.Name = "labDir";
            this.labDir.Size = new System.Drawing.Size(27, 27);
            this.labDir.TabIndex = 5;
            this.labDir.Text = "0";
            // 
            // labEsq
            // 
            this.labEsq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labEsq.AutoSize = true;
            this.labEsq.BackColor = System.Drawing.SystemColors.Info;
            this.labEsq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labEsq.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEsq.Location = new System.Drawing.Point(4, 2);
            this.labEsq.Name = "labEsq";
            this.labEsq.Size = new System.Drawing.Size(27, 27);
            this.labEsq.TabIndex = 6;
            this.labEsq.Text = "0";
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(151, 388);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Obter escalas";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.BackColor = System.Drawing.SystemColors.Info;
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(250, 5);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Padding = new System.Windows.Forms.Padding(2);
            this.lblStatus.Size = new System.Drawing.Size(916, 23);
            this.lblStatus.TabIndex = 18;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStatus.Visible = false;
            // 
            // lblInfoPnmesa
            // 
            this.lblInfoPnmesa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInfoPnmesa.Location = new System.Drawing.Point(12, 31);
            this.lblInfoPnmesa.Name = "lblInfoPnmesa";
            this.lblInfoPnmesa.Padding = new System.Windows.Forms.Padding(5);
            this.lblInfoPnmesa.Size = new System.Drawing.Size(221, 352);
            this.lblInfoPnmesa.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Informações (escalas) da mesa";
            // 
            // lblInfoPicTeste
            // 
            this.lblInfoPicTeste.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInfoPicTeste.Location = new System.Drawing.Point(13, 434);
            this.lblInfoPicTeste.Name = "lblInfoPicTeste";
            this.lblInfoPicTeste.Size = new System.Drawing.Size(220, 136);
            this.lblInfoPicTeste.TabIndex = 25;
            // 
            // button7
            // 
            this.button7.AutoSize = true;
            this.button7.Location = new System.Drawing.Point(149, 575);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(82, 23);
            this.button7.TabIndex = 26;
            this.button7.Text = "Obter escalas";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Informações (escalas) do PicTeste";
            // 
            // button8
            // 
            this.button8.AutoSize = true;
            this.button8.Location = new System.Drawing.Point(83, 575);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(60, 23);
            this.button8.TabIndex = 28;
            this.button8.Text = "Remover";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.AutoSize = true;
            this.button9.Location = new System.Drawing.Point(14, 575);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(60, 23);
            this.button9.TabIndex = 29;
            this.button9.Text = "Criar";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtXmesa);
            this.panel1.Controls.Add(this.txtYmesa);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtAlturaPnMesa);
            this.panel1.Controls.Add(this.txtLargunaPnMesa);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(1157, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 239);
            this.panel1.TabIndex = 30;
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Location = new System.Drawing.Point(6, 211);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 23);
            this.button4.TabIndex = 36;
            this.button4.Text = "Carregar padrão";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "Atualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtXmesa
            // 
            this.txtXmesa.Location = new System.Drawing.Point(74, 94);
            this.txtXmesa.Name = "txtXmesa";
            this.txtXmesa.Size = new System.Drawing.Size(100, 20);
            this.txtXmesa.TabIndex = 33;
            this.txtXmesa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtXmesa_KeyPress);
            // 
            // txtYmesa
            // 
            this.txtYmesa.Location = new System.Drawing.Point(74, 123);
            this.txtYmesa.Name = "txtYmesa";
            this.txtYmesa.Size = new System.Drawing.Size(100, 20);
            this.txtYmesa.TabIndex = 32;
            this.txtYmesa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYmesa_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Posição Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Posição X";
            // 
            // txtAlturaPnMesa
            // 
            this.txtAlturaPnMesa.Location = new System.Drawing.Point(74, 65);
            this.txtAlturaPnMesa.Name = "txtAlturaPnMesa";
            this.txtAlturaPnMesa.Size = new System.Drawing.Size(100, 20);
            this.txtAlturaPnMesa.TabIndex = 29;
            this.txtAlturaPnMesa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlturaPnMesa_KeyPress);
            // 
            // txtLargunaPnMesa
            // 
            this.txtLargunaPnMesa.Location = new System.Drawing.Point(74, 36);
            this.txtLargunaPnMesa.Name = "txtLargunaPnMesa";
            this.txtLargunaPnMesa.Size = new System.Drawing.Size(100, 20);
            this.txtLargunaPnMesa.TabIndex = 28;
            this.txtLargunaPnMesa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLargunaPnMesa_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Altura";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Largura:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(7, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Ajustar/Editar a Mesa (pnMesa)";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(1158, 274);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(205, 186);
            this.panel2.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(7, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 15);
            this.label9.TabIndex = 26;
            this.label9.Text = "Ultima Pedra Inserida";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.lblTotalPedraMesa);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.labDir);
            this.panel3.Controls.Add(this.labEsq);
            this.panel3.Location = new System.Drawing.Point(1158, 466);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(205, 164);
            this.panel3.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 138);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Total de Pedras na mesa";
            // 
            // lblTotalPedraMesa
            // 
            this.lblTotalPedraMesa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPedraMesa.AutoSize = true;
            this.lblTotalPedraMesa.BackColor = System.Drawing.SystemColors.Info;
            this.lblTotalPedraMesa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalPedraMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPedraMesa.Location = new System.Drawing.Point(172, 131);
            this.lblTotalPedraMesa.Name = "lblTotalPedraMesa";
            this.lblTotalPedraMesa.Size = new System.Drawing.Size(27, 27);
            this.lblTotalPedraMesa.TabIndex = 8;
            this.lblTotalPedraMesa.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(35, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "< Esquerda -- Direita >";
            // 
            // tmrContaMesa
            // 
            this.tmrContaMesa.Enabled = true;
            this.tmrContaMesa.Tick += new System.EventHandler(this.tmrContaMesa_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 608);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "X,Y";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(156, 604);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 20);
            this.button5.TabIndex = 10;
            this.button5.Text = "move";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(83, 604);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(60, 20);
            this.textBox4.TabIndex = 15;
            this.textBox4.Text = "10,10";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.labTotalJ1);
            this.panel4.Location = new System.Drawing.Point(13, 653);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(115, 100);
            this.panel4.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(5, 11);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(5);
            this.label11.Size = new System.Drawing.Size(105, 39);
            this.label11.TabIndex = 10;
            this.label11.Text = "Total de Pedras Jogador 1";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 765);
            this.Controls.Add(this.picteste);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.lblInfoPicTeste);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblInfoPnmesa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pnMesa);
            this.Controls.Add(this.pnJogador);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picteste)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnJogador;
        private System.Windows.Forms.Panel pnMesa;
        private System.Windows.Forms.Label labTotalJ1;
        private System.Windows.Forms.Label labDir;
        private System.Windows.Forms.Label labEsq;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer tmrQuebra;
        private System.Windows.Forms.PictureBox picteste;
        private System.Windows.Forms.Label lblInfoPnmesa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblInfoPicTeste;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLargunaPnMesa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAlturaPnMesa;
        private System.Windows.Forms.TextBox txtXmesa;
        private System.Windows.Forms.TextBox txtYmesa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTotalPedraMesa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer tmrContaMesa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label11;
    }
}

