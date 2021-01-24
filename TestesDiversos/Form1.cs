using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DominoV5
{
    public partial class Form1 : Form
    {
        //Caminho da pasta das imagens
        public static string caminho = Application.StartupPath;
        public static string pastaImagensDomino = @"\img\pedras\";
        public static string[] files = Directory.GetFiles(caminho + pastaImagensDomino); // totall de arquivos
        public int i = files.Count();

        List<PictureBox> listaPedras = new List<PictureBox>();

        public static PictureBox domino;

        // public int DominoXDir { get; set; } // lado direito da pedra


        public int DominoY { get; set; } // posição Y do primeiro domino inserido na mesa
        public int DominoX { get; set; } // posição Y do primeiro domino inserido na mesa

        public int DominoXesq { get; set; } // Posição X do domino inserido do lado esquerdo
        public int DominoYesq { get; set; } // Posição Y do domino inserido do lado esquerdo

        public int DominoXdir { get; set; } // Posição X do domino inserido do lado direito
        public int DominoYdir { get; set; } // Posição Y do domino inserido do lado direito

        public int DominoXJ1 { get; set; } // `Posição X do domino no painel do jogador 1
        public int DominoYJ1 { get; set; } // Posição Y do domino no painel do jogador 1

        //  public int DominoY2 { get; set; } // posição Y do domino
        // public int DominoYbotton { get; set; }
        // public int DominoYtop { get; set; }
        public string Lado { get; set; } //Grava o lago que o jogador escolheu para jogar a pedra
                                         // public int DominoXe { get; set; }
                                         // public int DominoXe2 { get; set; }
                                         //public int DominoXd { get; set; }
                                         // public int DominoXd2 { get; set; }
                                         // public string PosicaoFilaDir { get; set; }
                                         //  public string PosicaoFilaEsq { get; set; }



        // public string NomeDaPedra { get; set; }
        // public string LadoPosicaoPedra { get; set; }
        //public string TipoDePedraDireita { get; set; }
        //public string TipoDePedraesquerda { get; set; }

        public string PontoEsq { get; set; } // Numero llivre do domino da ponta esquerda
        public string PontoDir { get; set; } // Numero llivre do domino da ponta direita
        //public string LadoJogado { get; set; }
        //public int TotalXDir { get; set; }
        //public int ContaPedraDir { get; set; }


        Image IMG1;
        

        public Form1()
        {
            InitializeComponent();

            CarregaDomino();

            // TotalXDir = 0;

            DominoX = pnMesa.Width / 2;
            DominoY = pnMesa.Height / 2;
            DominoYJ1 = 5;
            DominoXJ1 = 5;
            // DominoY2 = pnMesa.Height / 2;
            // ContaPedraDir = 0;

        }



        /// <summary>
        /// 
        /// </summary>
        public new void Update()
        {
            labDir.Text = PontoDir;
            labEsq.Text = PontoEsq;


            lblStatus.Visible = false;
            lblStatus.Text = "Selecione o lado para colocar a peça!!!";
            Lado = "";
        }

        /// <summary>
        /// Função que executa clique em cada pedra do domino e realiza as funções devidas
        /// /Função parassa pela função da  #region Carrega Domino
        /// </summary>
        /// <param  name="ClickDominoJogadores">Recupera a função click passada pela função  CarregaDomino</param>
        /// O <paramref name="EventArgs"/> recebe a função passada pelo controle da função CarregaDomino
        /// O <paramref name="sender"/> recebe informações do domino que foi clicado
        /// <param name="e">Evento Click</param>
        /// 
        private void ClickDominoJogadores(object sender, EventArgs e)
        {
            /// <summary>DoWork is a method in the TestClass class.
            /// The <paramref name="int1"/> parameter takes a number.
            /// </summary>
            PictureBox pedra = (sender as PictureBox);
            string inteiro = pedra.Tag.ToString();

        }


        //! função desativada por enquanto N1

        //    private void zClickDominoJogadores(object sender, EventArgs e)
        //{
        //    PictureBox pedra = (sender as PictureBox);
        //    string inteiro = pedra.Tag.ToString();

        //    string esquerda = inteiro.Remove(0, 1); //Pega a numeração esquerda da pedra do domino
        //    string direita = inteiro.Remove(1, 1); //Pega a numeração esquerda da pedra do domino

        //    int contaMesa = pnMesa.Controls.Count;


        //    if (contaMesa == 0)
        //    {
        //        pnMesa.Controls.Add(pedra);
        //        pedra.Size = new Size(42, 82);
        //        pedra.Location = new Point(DominoX, DominoY);
        //        DominoX = pedra.Location.X;
        //        DominoY = pedra.Location.Y;
        //        DominoY2 = pedra.Location.Y;
        //        DominoXe = pedra.Left;
        //        DominoXd = pedra.Right;
        //        PontoDir = direita;
        //        PontoEsq = esquerda;
        //        pedra.Click -= ClickDominoJogadores;
        //        Update();
        //        return;
        //    }

        //    //Verificando se o jogador tem pedra igual aos dos lados
        //    if (direita == PontoDir && esquerda == PontoEsq || direita == PontoEsq && esquerda == PontoDir)
        //    {
        //        lblStatus.Visible = true;
        //        if (Lado == "esquerdo")
        //        {
        //            if (esquerda == PontoEsq)
        //            {

        //                //compara o Lado Esquerdo (cima) do domino com o lado esquerdo da mesa
        //                IMG1 = (Image)Image.FromFile(pedra.ImageLocation);
        //                IMG1.RotateFlip(RotateFlipType.Rotate90FlipY);
        //                pedra.Image = IMG1;
        //                pnMesa.Controls.Add(pedra);
        //                pedra.Size = new Size(82, 42);
        //                pedra.Location = new Point(DominoXe - 82, DominoY + 20);
        //                DominoXe = pedra.Left;
        //                DominoY = pedra.Location.Y - 20;
        //                PontoEsq = direita;
        //                lblStatus.Visible = false;
        //                pedra.Click -= ClickDominoJogadores;
        //                Lado = "";
        //                Update();
        //                return;
        //            }

        //            if (direita == PontoEsq)
        //            {


        //                IMG1 = (Image)Image.FromFile(pedra.ImageLocation);
        //                IMG1.RotateFlip(RotateFlipType.Rotate90FlipX);
        //                pedra.Image = IMG1;
        //                pnMesa.Controls.Add(pedra);
        //                pedra.Size = new Size(82, 42);
        //                pedra.Location = new Point(DominoXe - 82, DominoY + 20);
        //                DominoXe = pedra.Left;
        //                DominoY = pedra.Location.Y - 20;
        //                PontoEsq = esquerda;
        //                pedra.Click -= ClickDominoJogadores;

        //                Update();
        //                return;
        //            }
        //            Lado = "";
        //        }
        //        if (Lado == "direito")
        //        {
        //            if (esquerda == PontoDir)
        //            {

        //                //compara o Lado Esquerdo (cima) do domino com o lado direito da mesa
        //                IMG1 = (Image)Image.FromFile(pedra.ImageLocation);
        //                IMG1.RotateFlip(RotateFlipType.Rotate90FlipX);
        //                pedra.Image = IMG1;
        //                pnMesa.Controls.Add(pedra);
        //                pedra.Size = new Size(82, 42);
        //                pedra.Location = new Point(DominoXd, DominoY + 20);
        //                DominoXd = pedra.Right;
        //                DominoY = pedra.Location.Y - 20;
        //                PontoDir = direita;
        //                lblStatus.Visible = false;
        //                pedra.Click -= ClickDominoJogadores;
        //                Lado = "";
        //                Update();
        //                return;
        //            }

        //            if (direita == PontoDir)
        //            {


        //                IMG1 = (Image)Image.FromFile(pedra.ImageLocation);
        //                IMG1.RotateFlip(RotateFlipType.Rotate90FlipY);
        //                pedra.Image = IMG1;
        //                pnMesa.Controls.Add(pedra);
        //                pedra.Size = new Size(82, 42);
        //                pedra.Location = new Point(DominoXd, DominoY + 20);
        //                DominoXd = pedra.Right;
        //                DominoY = pedra.Location.Y - 20;
        //                PontoDir = esquerda;
        //                pedra.Click -= ClickDominoJogadores;

        //                Update();
        //                return;
        //            }
        //        }
        //        Lado = "";
        //        return;
        //    }
        //    //Lados Iguais
        //    if (PontoDir == PontoEsq)
        //    {
        //        lblStatus.Visible = true;

        //        if (Lado == "esquerdo")
        //        {

        //            if (esquerda == PontoEsq)
        //            {

        //                //compara o Lado Esquerdo (cima) do domino com o lado esquerdo da mesa
        //                IMG1 = (Image)Image.FromFile(pedra.ImageLocation);
        //                IMG1.RotateFlip(RotateFlipType.Rotate90FlipY);
        //                pedra.Image = IMG1;
        //                pnMesa.Controls.Add(pedra);
        //                pedra.Size = new Size(82, 42);
        //                pedra.Location = new Point(DominoXe - 82, DominoY + 20);
        //                DominoXe = pedra.Left;
        //                DominoY = pedra.Location.Y - 20;
        //                PontoEsq = direita;
        //                lblStatus.Visible = false;
        //                pedra.Click -= ClickDominoJogadores;
        //                Lado = "";
        //                Update();
        //                return;
        //            }

        //            if (direita == PontoEsq)
        //            {


        //                IMG1 = (Image)Image.FromFile(pedra.ImageLocation);
        //                IMG1.RotateFlip(RotateFlipType.Rotate90FlipX);
        //                pedra.Image = IMG1;
        //                pnMesa.Controls.Add(pedra);
        //                pedra.Size = new Size(82, 42);
        //                pedra.Location = new Point(DominoXe - 82, DominoY + 20);
        //                DominoXe = pedra.Left;
        //                DominoY = pedra.Location.Y - 20;
        //                PontoEsq = esquerda;
        //                pedra.Click -= ClickDominoJogadores;

        //                Update();
        //                return;
        //            }



        //        }

        //        if (Lado == "direito")
        //        {
        //            if (esquerda == PontoDir)
        //            {

        //                //compara o Lado Esquerdo (cima) do domino com o lado direito da mesa
        //                IMG1 = (Image)Image.FromFile(pedra.ImageLocation);
        //                IMG1.RotateFlip(RotateFlipType.Rotate90FlipX);
        //                pedra.Image = IMG1;
        //                pnMesa.Controls.Add(pedra);
        //                pedra.Size = new Size(82, 42);
        //                pedra.Location = new Point(DominoXd, DominoY + 20);
        //                DominoXd = pedra.Right;
        //                DominoY = pedra.Location.Y - 20;
        //                PontoDir = direita;
        //                lblStatus.Visible = false;
        //                pedra.Click -= ClickDominoJogadores;
        //                Lado = "";
        //                Update();
        //                return;
        //            }

        //            if (direita == PontoDir)
        //            {


        //                IMG1 = (Image)Image.FromFile(pedra.ImageLocation);
        //                IMG1.RotateFlip(RotateFlipType.Rotate90FlipY);
        //                pedra.Image = IMG1;
        //                pnMesa.Controls.Add(pedra);
        //                pedra.Size = new Size(82, 42);
        //                pedra.Location = new Point(DominoXd, DominoY + 20);
        //                DominoXd = pedra.Right;
        //                DominoY = pedra.Location.Y - 20;
        //                PontoDir = esquerda;
        //                pedra.Click -= ClickDominoJogadores;

        //                Update();
        //                return;
        //            }

        //        }
        //        return;
        //    }

        //    //Função para gabão
        //    if (inteiro == "00" || inteiro == "11" || inteiro == "22" || inteiro == "33" || inteiro == "44" || inteiro == "55" || inteiro == "66")
        //    {
        //        //Compara com o lado direito
        //        if (direita == PontoDir)
        //        {
        //            pnMesa.Controls.Add(pedra);
        //            pedra.Size = new Size(42, 82);
        //            pedra.Location = new Point(DominoXd, DominoY);
        //            DominoY = pedra.Location.Y;
        //            DominoXd = pedra.Right;
        //            PontoDir = direita;
        //            //PontoEsq = esquerda;
        //            pedra.Click -= ClickDominoJogadores;
        //            Update();
        //            return;
        //        }
        //        //Compara com o lado esquerdo
        //        if (esquerda == PontoEsq)
        //        {
        //            if (PosicaoFilaDir == "esquerdaBaixo" && esquerda == PontoEsq)
        //            {
        //                MessageBox.Show("33");

        //                pnMesa.Controls.Add(pedra);
        //                pedra.Size = new Size(42, 82);
        //                pedra.Location = new Point(80, DominoYbotton);
        //                //DominoX = pedra.Location.X ;
        //                DominoYbotton = pedra.Bottom;
        //                PontoEsq = esquerda;
        //                Update();
        //                return;
        //            }

        //            pnMesa.Controls.Add(pedra);
        //            pedra.Size = new Size(42, 82);
        //            pedra.Location = new Point(DominoXe - 42, DominoY);
        //            DominoY = pedra.Location.Y;
        //            DominoXe = pedra.Left;
        //            //PontoDir = direita;
        //            PontoEsq = esquerda;
        //            pedra.Click -= ClickDominoJogadores;
        //            Update();
        //            return;
        //        }

        //        return;
        //    }


        //    //compara o Lado Esquerdo (cima) do domino com o lado esquerdo da mesa
        //    if (esquerda == PontoEsq)
        //    {
        //        if (PosicaoFilaEsq == "esquerdaBaixo" && esquerda == PontoEsq)
        //        {
        //            MessageBox.Show("35");
        //            pnMesa.Controls.Add(pedra);
        //            pedra.Size = new Size(42, 82);
        //            pedra.Location = new Point(38, DominoYbotton);
        //            //DominoX = pedra.Location.X ;
        //            DominoYbotton = pedra.Bottom;
        //            PontoEsq = direita;
        //            Update();
        //            return;
        //        }
        //        if (PosicaoFilaDir == "direitaCima" && esquerda == PontoEsq)
        //        {
        //            MessageBox.Show(esquerda.ToString());
        //            IMG1 = (Image)Image.FromFile(pedra.ImageLocation);
        //            IMG1.RotateFlip(RotateFlipType.Rotate180FlipX);
        //            pedra.Image = IMG1;
        //            pnMesa.Controls.Add(pedra);
        //            pedra.Size = new Size(42, 82);
        //            pedra.Location = new Point(820, DominoYtop - 82);
        //            //DominoX = pedra.Location.X ;
        //            DominoYtop = pedra.Top;
        //            PontoDir = esquerda;
        //            Update();
        //            return;
        //        }
        //        MessageBox.Show("1");
        //        IMG1 = (Image)Image.FromFile(pedra.ImageLocation);
        //        IMG1.RotateFlip(RotateFlipType.Rotate90FlipY);
        //        pedra.Image = IMG1;
        //        pnMesa.Controls.Add(pedra);
        //        pedra.Size = new Size(82, 42);
        //        pedra.Location = new Point(DominoXe - 82, DominoY + 20);
        //        DominoXe = pedra.Left;
        //        DominoY = pedra.Location.Y - 20;
        //        PontoEsq = direita;
        //        pedra.Click -= ClickDominoJogadores;

        //        Update();
        //        return;
        //    }

        //    //compara o Lado Esquerdo (cima) do domino com o lado direito da mesa
        //    if (esquerda == PontoDir)
        //    {
        //        if (PosicaoFilaDir == "direitaCima" && esquerda == PontoDir)
        //        {
        //            IMG1 = (Image)Image.FromFile(pedra.ImageLocation);
        //            IMG1.RotateFlip(RotateFlipType.Rotate180FlipX);
        //            pedra.Image = IMG1;
        //            pnMesa.Controls.Add(pedra);
        //            pedra.Size = new Size(42, 82);
        //            pedra.Location = new Point(820, DominoYtop - 82);
        //            //DominoX = pedra.Location.X ;
        //            DominoYtop = pedra.Top;
        //            PontoDir = direita;
        //            Update();
        //            return;
        //        }
        //        MessageBox.Show("2");
        //        IMG1 = (Image)Image.FromFile(pedra.ImageLocation);
        //        IMG1.RotateFlip(RotateFlipType.Rotate90FlipX);
        //        pedra.Image = IMG1;
        //        pnMesa.Controls.Add(pedra);
        //        pedra.Size = new Size(82, 42);
        //        pedra.Location = new Point(DominoXd, DominoY + 20);
        //        DominoXd = pedra.Right;
        //        DominoY = pedra.Location.Y - 20;
        //        PontoDir = direita;
        //        pedra.Click -= ClickDominoJogadores;

        //        Update();
        //        return;
        //    }

        //    //compara o Lado direito (baixo) do domino com o lado esquerdo da mesa
        //    if (direita == PontoEsq)
        //    {
        //        if (PosicaoFilaEsq == "esquerdaBaixo")
        //        {
        //            MessageBox.Show("33");
        //            IMG1 = (Image)Image.FromFile(domino.ImageLocation);
        //            IMG1.RotateFlip(RotateFlipType.Rotate180FlipY);
        //            domino.Image = IMG1;
        //            pnMesa.Controls.Add(pedra);
        //            pedra.Size = new Size(42, 82);
        //            pedra.Location = new Point(38, DominoYbotton);
        //            //DominoX = pedra.Location.X ;
        //            DominoYbotton = pedra.Bottom;
        //            PontoEsq = esquerda;
        //            Update();
        //            return;
        //        }
        //        MessageBox.Show("3");
        //        IMG1 = (Image)Image.FromFile(pedra.ImageLocation);
        //        IMG1.RotateFlip(RotateFlipType.Rotate90FlipX);
        //        pedra.Image = IMG1;
        //        pnMesa.Controls.Add(pedra);
        //        pedra.Size = new Size(82, 42);
        //        pedra.Location = new Point(DominoXe - 82, DominoY + 20);
        //        DominoXe = pedra.Left;
        //        DominoY = pedra.Location.Y - 20;
        //        PontoEsq = esquerda;
        //        pedra.Click -= ClickDominoJogadores;

        //        Update();
        //        return;
        //    }

        //    //compara o Lado direito (baixo) do domino com o lado direito da mesa
        //    if (direita == PontoDir)
        //    {
        //        if (PosicaoFilaDir == "direitaCima" && direita == PontoDir)
        //        {
        //            MessageBox.Show("44");
        //            IMG1 = (Image)Image.FromFile(pedra.ImageLocation);
        //            IMG1.RotateFlip(RotateFlipType.Rotate180FlipY);
        //            pedra.Image = IMG1;
        //            pnMesa.Controls.Add(pedra);
        //            pedra.Size = new Size(42, 82);
        //            pedra.Location = new Point(820, DominoYtop - 82);
        //            //DominoX = pedra.Location.X ;
        //            DominoYtop = pedra.Top;
        //            PontoDir = direita;
        //            Update();
        //            return;
        //        }

        //        MessageBox.Show("4");
        //        IMG1 = (Image)Image.FromFile(pedra.ImageLocation);
        //        IMG1.RotateFlip(RotateFlipType.Rotate90FlipY);
        //        pedra.Image = IMG1;
        //        pnMesa.Controls.Add(pedra);
        //        pedra.Size = new Size(82, 42);
        //        pedra.Location = new Point(DominoXd, DominoY + 20);
        //        DominoXd = pedra.Right;
        //        DominoY = pedra.Location.Y - 20;
        //        PontoDir = esquerda;
        //        pedra.Click -= ClickDominoJogadores;

        //        Update();
        //        return;
        //    } 
        //! Final da função N1







        #region Carrega Domino
        public void CarregaDomino()
        {
            //MessageBox.Show(i.ToString());
            int f = 0;

            do
            {

                string nomeArquivo = files[f];
                string[] subs = nomeArquivo.Split('\\'); subs = subs[10].Split('.');
                // MessageBox.Show(subs[0]); // Rega somente a numeração das pedras



                domino = new PictureBox()
                {

                    Image = Image.FromFile(files[f]),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    ImageLocation = files[f],
                    Size = new Size(42, 82),
                    Name = "picDomino" + f,
                    Location = new Point(DominoXJ1 + 2, DominoYJ1 + 5),
                    Tag = subs[0]


                };
                listaPedras.Add(domino); //lista das pedras
                DominoXJ1 = domino.Right;
                pnJogador.Controls.Add(domino);
                domino.Click += new EventHandler(ClickDominoJogadores);
                f++;
            } while (f <= 27);

            labTotalJ1.Text = f.ToString();
        }
        #endregion

        private void button3_Click(object sender, EventArgs e)
        {
            lblInfoPnmesa.Text = "Largura (Width): " + pnMesa.Width + Environment.NewLine +
                                 "Altura (Height): " + pnMesa.Height + Environment.NewLine +
                                 "Centro pela largura: " + pnMesa.Width / 2 + Environment.NewLine +
                                 "Centro pela altura: " + pnMesa.Height / 2 + Environment.NewLine +
                                 "Posição X esquerda: " + pnMesa.Location.X + Environment.NewLine +
                                 "Posição X direita: " + (pnMesa.Location.X + pnMesa.Width) + Environment.NewLine +
                                 "Posição Y do topo: " + pnMesa.Location.Y + Environment.NewLine +
                                 "Posição Y de baixo: " + (pnMesa.Location.Y + pnMesa.Height) + Environment.NewLine + Environment.NewLine +
                                 "Nome do Painel: " + pnMesa.Name + "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[] XY = textBox4.Text.Split(',');

            picteste.Location = new Point(Convert.ToInt32(XY[0]), Convert.ToInt32(XY[1]));

        }

        private void pnMesa_MouseLeave(object sender, EventArgs e)
        {
            pnMesa.Invalidate();
        }

        private void pnMesa_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void pnMesa_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.X < pnMesa.Width / 2)
            {
                Lado = "esquerdo";
                lblStatus.Text = "Selecione a Pedra para por na ponta esquerda da mesa";
                return;
            }
            else
            {
                Lado = "direito";
                lblStatus.Text = "Selecione a Pedra para por na ponta direita mesa!";
                return;
            }

        }

        //!Função desativada por enquanto N2
        //private void tmrQuebra_Tick(object sender, EventArgs e)
        //{
        //    foreach (PictureBox domino in pnMesa.Controls)
        //    {
        //        if (domino.Name == domino.Name)
        //        {
        //            if (domino.Location.X <= 20)
        //            {
        //                IMG1 = (Image)Image.FromFile(domino.ImageLocation);
        //                if (PontoEsq == "0" || PontoEsq == "1" || PontoEsq == "2" || PontoEsq == "3" || PontoEsq == "4")
        //                {
        //                    IMG1.RotateFlip(RotateFlipType.Rotate180FlipY);
        //                }
        //                else
        //                {
        //                    IMG1.RotateFlip(RotateFlipType.Rotate180FlipX);
        //                }

        //                domino.Image = IMG1;
        //                DominoY2 = DominoY + 40;
        //                DominoXe2 = DominoXe;
        //                DominoXd2 = DominoXd;
        //                pnMesa.Controls.Add(domino);
        //                domino.Size = new Size(42, 82);
        //                domino.Location = new Point(DominoXe2 + 40, DominoY2 + 21);
        //                DominoXe2 = domino.Location.X;
        //                DominoY2 = domino.Location.Y;
        //                PosicaoFilaEsq = "esquerdaBaixo";
        //                DominoYbotton = domino.Bottom;

        //                //return;
        //            }

        //            if (domino.Location.Y >= 450)
        //            {
        //                IMG1 = (Image)Image.FromFile(domino.ImageLocation);
        //                IMG1.RotateFlip(RotateFlipType.Rotate90FlipX);
        //                domino.Image = IMG1;
        //                DominoY2 = DominoY + 40;
        //                DominoXe2 = DominoXe;
        //                DominoXd2 = DominoXd;
        //                pnMesa.Controls.Add(domino);
        //                domino.Size = new Size(82, 42);
        //                domino.Location = new Point(80, domino.Top);
        //                DominoXe2 = domino.Location.X;
        //                DominoXd2 = domino.Right;
        //                DominoY2 = domino.Location.Y;
        //                PosicaoFilaDir = "baixoDireita";
        //                DominoYbotton = domino.Bottom;

        //            }

        //            if (domino.Location.X >= 800)
        //            {

        //                IMG1 = (Image)Image.FromFile(domino.ImageLocation);
        //                if (PontoDir == "2" || PontoDir == "3" || PontoDir == "4" || PontoDir == "5" || PontoDir == "6" || PontoDir == "0")
        //                {
        //                    IMG1.RotateFlip(RotateFlipType.Rotate180FlipX);
        //                }
        //                else
        //                {
        //                    IMG1.RotateFlip(RotateFlipType.Rotate180FlipX);
        //                }

        //                domino.Image = IMG1;
        //                DominoY2 = DominoY + 40;
        //                DominoXe2 = DominoXe;
        //                DominoXd2 = DominoXd;
        //                pnMesa.Controls.Add(domino);
        //                domino.Size = new Size(42, 82);
        //                domino.Location = new Point(domino.Right - 42, DominoY - 20);
        //                DominoXe2 = domino.Location.X;
        //                DominoXd2 = domino.Right;
        //                DominoY2 = domino.Location.Y;
        //                PosicaoFilaDir = "direitaCima";
        //                DominoYtop = domino.Top;

        //                tmrQuebra.Enabled = false;
        //            }


        //            // MessageBox.Show("ok");
        //        }
        //    }
        //}
        //!Final da função N2



        /// <summary>
        /// Variaveis responsáveis  pelas propriedades do controle Panel, com o nome "pnMesa"
        /// </summary>
        /// <param name="largura">define a propriedade Width do panel</param>
        /// <param name="altura">Define a propriedade Height do panel</param>
        /// <param name="locX">Define a location X do panel</param>
        /// <param name="locY">Define a location Y do panel</param>



        public int largura { get; set; }
        public int altura { get; set; }
        public int locX { get; set; }
        public int locY { get; set; }


        public const int larguraP = 900;
        public const int alturaP = 600;
        public const int locXP = 250;
        public const int locYP = 30;

        /// <summary>
        /// Metodo para carregar os valores padrões do panel.
        /// Valores que foram declarados nas propriedares estáticas da ferramenta panel
        /// </summary>
        private void LoadPadrao()
        {

            txtLargunaPnMesa.Text = larguraP.ToString();
            txtAlturaPnMesa.Text = alturaP.ToString();
            txtXmesa.Text = locXP.ToString();
            txtYmesa.Text = locYP.ToString();
        }

        /// <summary>
        /// Metodo para carregar os valores inseridos durante a execução do programa
        /// </summary>
        public void UpdadePanel()
        {
            largura = Convert.ToInt32(txtLargunaPnMesa.Text);
            altura = Convert.ToInt32(txtAlturaPnMesa.Text);
            locX = Convert.ToInt32(txtXmesa.Text);
            locY = Convert.ToInt32(txtYmesa.Text);

            pnMesa.Width = largura;
            pnMesa.Height = altura;
            pnMesa.Location = new Point(locX, locY);

            LoadAtualizado();
        }

        /// <summary>
        /// Metodo para carregar os valores atuais das variaveis nos campo texto
        /// </summary>
        public void LoadAtualizado()
        {
            txtLargunaPnMesa.Text = largura.ToString();
            txtAlturaPnMesa.Text = altura.ToString();
            txtXmesa.Text = locX.ToString();
            txtYmesa.Text = locY.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadPadrao();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdadePanel();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lblInfoPicTeste.Text = "Largura (Width): " + picteste.Width + Environment.NewLine +
                                    "Altura (Height): " + picteste.Height + Environment.NewLine +
                                    "Posição X esquerda: " + picteste.Location.X + Environment.NewLine +
                                    "Posição X direita: " + (picteste.Location.X + pnMesa.Width) + Environment.NewLine +
                                    "Posição Y do topo: " + picteste.Location.Y + Environment.NewLine +
                                    "Posição Y de baixo: " + (picteste.Location.Y + pnMesa.Height) + Environment.NewLine + Environment.NewLine +
                                    "Nome do Picture: " + picteste.Name + "";

        }

        private void txtLargunaPnMesa_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtLargunaPnMesa.MaxLength = 3;
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }



        private void txtAlturaPnMesa_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtAlturaPnMesa.MaxLength = 3;
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtXmesa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtYmesa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pnMesa.Controls.Remove(picteste);
        }

        private void tmrContaMesa_Tick(object sender, EventArgs e)
        {
            int PedrasMesa = pnMesa.Controls.Count;
            int PedraJogador1 = pnJogador.Controls.Count;
            lblTotalPedraMesa.Text = PedrasMesa.ToString();
            labTotalJ1.Text = PedraJogador1.ToString();

        }


      
       
    }
}










