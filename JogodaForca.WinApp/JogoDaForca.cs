using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogodaForca.WinApp
{
    public partial class JogoDaForca : Form
    {
        private Forca forca;
        public JogoDaForca()
        {
            InitializeComponent();

            forca = new Forca();

            ConfigurarLetras();
        }

        private void ConfigurarLetras()
        {
            btnA.Click += AtribuirLetra;
            btnB.Click += AtribuirLetra;
            btnC.Click += AtribuirLetra;
            btnD.Click += AtribuirLetra;
            btnE.Click += AtribuirLetra;
            btnF.Click += AtribuirLetra;
            btnG.Click += AtribuirLetra;
            btnH.Click += AtribuirLetra;
            btnI.Click += AtribuirLetra;
            btnJ.Click += AtribuirLetra;
            btnK.Click += AtribuirLetra;
            btnL.Click += AtribuirLetra;
            btnM.Click += AtribuirLetra;
            btnN.Click += AtribuirLetra;
            btnO.Click += AtribuirLetra;
            btnP.Click += AtribuirLetra;
            btnQ.Click += AtribuirLetra;
            btnR.Click += AtribuirLetra;
            btnS.Click += AtribuirLetra;
            btnT.Click += AtribuirLetra;
            btnU.Click += AtribuirLetra;
            btnV.Click += AtribuirLetra;
            btnX.Click += AtribuirLetra;
            btnY.Click += AtribuirLetra;
            btnW.Click += AtribuirLetra;
            btnZ.Click += AtribuirLetra;

        }

        private void AtribuirLetra(object? sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;

            txtLetra.Text += botaoClicado.Text;
        }
    }

}
