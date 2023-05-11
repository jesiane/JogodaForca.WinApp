using Microsoft.VisualBasic.ApplicationServices;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;

namespace JogodaForca.WinApp
{
    public partial class Form1 : Form
    {
        private Forca forca;

        public string[] palavras;
        public string tela;
        public string palavra;
        public int tentativas;
        public int aleatorio;

        public Form1()
        {
            forca = new Forca();

            InitializeComponent();
            this.IniciaVetor();

        }

        private void IniciaVetor()
        {
            palavras = new string[30];

            palavras[0] = "ABACATE";
            palavras[1] = "ABACAXI";
            palavras[2] = "ACEROLA";
            palavras[3] = "ACAI";
            palavras[4] = "ARACA";
            palavras[5] = "ABACATE";
            palavras[6] = "BACABA";
            palavras[7] = "BACURI";
            palavras[8] = "BANANA";
            palavras[9] = "CAJA";
            palavras[10] = "CAJU";
            palavras[11] = "CARAMBOLA";
            palavras[12] = "CUPUACU";
            palavras[13] = "GRAVIOLA";
            palavras[14] = "GOIABA";
            palavras[15] = "JABUTICABA";
            palavras[16] = "JENIPAPO";
            palavras[17] = "MACA";
            palavras[18] = "MANGABA";
            palavras[19] = "MANGA";
            palavras[20] = "MARACUJA";
            palavras[21] = "MURICI";
            palavras[22] = "PEQUI";
            palavras[23] = "PITANGA";
            palavras[24] = "PITAYA";
            palavras[25] = "SAPOTI";
            palavras[26] = "TANGERINA";
            palavras[27] = "UMBU";
            palavras[28] = "UVA";
            palavras[29] = "UVAIA";

        }

        private void IniciaJogo()
        {
            Random r = new Random();

            aleatorio = r.Next(palavras.Length);

            palavra = palavras[aleatorio];

            txtSolucao.Text = palavra;

            tela = "";
            for (int i = 0; i < palavra.Length; i++)
            {
                tela = tela + "#";
            }
            textPalavraSecreta.Text = tela;

            tentativas = 5;
            lblTtentativas.Text = tentativas.ToString();
            lblTrestantes.Text = tentativas.ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //     pnMsg.Visible = false;
            gbJogo.Visible = true;
            btnStart.Visible = false;
            this.IniciaJogo();

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            listForca.Items.Add("ABACATE");
            listForca.Items.Add("ABACAXI");
            listForca.Items.Add("UVAIA");
            listForca.Items.Add("PEQUI");
            listForca.Items.Add("PITAYA");
            listForca.Items.Add("PITANGA");
            listForca.Items.Add("SAPOTI");
            listForca.Items.Add("MURICI");
            listForca.Items.Add("MARACUJA");
            listForca.Items.Add("MANGA");
            listForca.Items.Add("TANGERINA");
            listForca.Items.Add("MANGABA");
            listForca.Items.Add("MACA");
            listForca.Items.Add("GOIABA");
            listForca.Items.Add("JENIPAPO");
            listForca.Items.Add("JABUTICABA");
            listForca.Items.Add("CUPUACU");
            listForca.Items.Add("GRAVIOLA");
            listForca.Items.Add("CARAMBOLA");
            listForca.Items.Add("CAJU");
            listForca.Items.Add("CAJA");
            listForca.Items.Add("BANANA");
            listForca.Items.Add("BACABA");
            listForca.Items.Add("BACURI");
            listForca.Items.Add("ABACATE");
            listForca.Items.Add("ARACA");
            listForca.Items.Add("ACAI");
            listForca.Items.Add("ACEROLA");
            listForca.Items.Add("UMBU");
            listForca.Items.Add("UVA");

        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            bool encontrou = false;
            char letra = '0';
            //  int pletra = 0;
            try
            {
                letra = Convert.ToChar(textLetra.Text);
            }
            catch
            {
                MessageBox.Show(" É permitido apenas letras Maiusculas");
                //    return;
            }
            string txt = "";
            for (int i = 0; i < palavra.Length; i++)
            {
                if (palavra[i] == letra)
                {
                    encontrou = true;
                    //    pletra = i;
                    txt = txt + textLetra.Text;
                }
                else
                {
                    txt = txt + tela[i];
                }
            }
            tela = txt;
            textPalavraSecreta.Text = tela;
            textLetra.Clear();
            tentativas--;
            lblTrestantes.Text = tentativas.ToString();

            if (tentativas <= 0)
            {
                gbJogo.Visible = false;
                // pnMsg.Visible = true;
                btnStart.Visible = true;
            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Form form2 = new JogoDaForca();
            this.Visible = false;
            form2.ShowDialog();
        }
    }
}
