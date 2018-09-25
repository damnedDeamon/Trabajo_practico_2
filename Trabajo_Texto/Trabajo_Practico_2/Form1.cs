using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Practico_2
{
    public partial class Form1 : Form
    {
        private int linea;
        private int vocal;
        private int contCons;
        private int contarPa;
        private int tabulacion;
        private int espacio;
        private int carac;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {

            OpenFileDialog buscar = new OpenFileDialog();
            buscar.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (buscar.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {


                txtUrl.Text = buscar.FileName;
                txtTexto.Text = System.IO.File.ReadAllText("" + txtUrl.Text);
                txtTexto.Enabled = false;
                
                contarLinea();
                contarPalabra();
                contarEspacio();
                contarCaracter();
                contarTabulacion();
                contarVocal();
                contarConsonantes();
            }


        }

        private void contarLinea()
        {
            linea = 0;

            for (int i = 0; i < txtTexto.Lines.Count(); i++)
            {
                if (i > -1)
                {
                    linea += 1;
                }
            }
            txtLineas.Text = linea.ToString();
        }

        private void contarEspacio()
        {
            String texto = txtTexto.Text.ToLower();
            espacio = 0;
            for (int i = 0; i < texto.Length; i++)
            {
                switch (texto[i])
                {
                    case ' ':
                        espacio += 1;
                        break;

                        //case '  ':
                        //    tab += 1;
                        //    break;
                }
            }

            txtEspacio.Text = espacio.ToString();

        }

        private void contarCaracter()
        {
            String[] caracter = new string[txtTexto.Text.Length];
            carac = 0;
            for (int i = 0; i < caracter.Length; i++)
            {
                carac += 1;

            }
            for (int i = 1; i < linea; i++)
            {
                carac -= 2;
            }



            txtCaracter.Text = carac.ToString();
        }
        private void contarTabulacion()
        {
            String tabs = txtTexto.Text.ToLower();
            tabulacion = 0;
            for (int i = 0; i < tabs.Length; i++)
            {
                switch (tabs[i])
                {
                    case '\t':
                        tabulacion += 1;
                        break;
                }
            }
            txtTabulador.Text = tabulacion.ToString();

        }
        private void contarConsonantes()
        {
            String consonante = txtTexto.Text.ToLower();
            contCons = 0;

            for (int i = 0; i < consonante.Length; i++)
            {
                switch (consonante[i])
                {
                    case 'b':
                        contCons += 1;
                        break;
                    case 'c':
                        contCons += 1;
                        break;
                    case 'd':
                        contCons += 1;
                        break;
                    case 'f':
                        contCons += 1;
                        break;
                    case 'g':
                        contCons += 1;
                        break;
                    case 'h':
                        contCons += 1;
                        break;
                    case 'j':
                        contCons += 1;
                        break;
                    case 'k':
                        contCons += 1;
                        break;
                    case 'l':
                        contCons += 1;
                        break;
                    case 'm':
                        contCons += 1;
                        break;
                    case 'n':
                        contCons += 1;
                        break;
                    case 'p':
                        contCons += 1;
                        break;
                    case 'q':
                        contCons += 1;
                        break;
                    case 'r':
                        contCons += 1;
                        break;
                    case 's':
                        contCons += 1;
                        break;
                    case 't':
                        contCons += 1;
                        break;
                    case 'v':
                        contCons += 1;
                        break;
                    case 'w':
                        contCons += 1;
                        break;
                    case 'x':
                        contCons += 1;
                        break;
                    case 'y':
                        contCons += 1;
                        break;
                    case 'z':
                        contCons += 1;
                        break;
                }
            }

            txtConsonate.Text = contCons.ToString();
        }
        private void contarVocal()
        {
            String vocales = txtTexto.Text.ToLower();
            vocal = 0;

            for (int i = 0; i < vocales.Length; i++)
            {
                switch (vocales[i])
                {
                    case 'a':
                        vocal += 1;
                        break;
                    case 'e':
                        vocal += 1;
                        break;
                    case 'i':
                        vocal += 1;
                        break;
                    case 'o':
                        vocal += 1;
                        break;
                    case 'u':
                        vocal += 1;
                        break;
                }
            }
            txtVocal.Text = vocal.ToString();
        }
        private void contarPalabra()
        {
            var palabra = txtTexto.Text.Split().GroupBy(x => x);
            contarPa = 0;
            foreach (var pal in palabra)
            {
                if (pal != null)
                {
                    contarPa += 1;

                }

            }
            if (linea >= 2)
            {
                contarPa -= 1;
            }
            txtPalabra.Text = contarPa.ToString();
        }


        private void btnProcesar_Click(object sender, EventArgs e)
        {
            if (cboQuitar.SelectedIndex == 0)
            {
                txtTexto.Text =  txtTexto.Text.Replace(" ","");
                txtTexto.Text = txtTexto.Text.Replace("\t", "");
                txtEspacio.Text = "0";

            }else if (cboQuitar.SelectedIndex == 1)
            {
                txtTexto.Text = txtTexto.Text.Replace("a", "");
                txtTexto.Text = txtTexto.Text.Replace("e", "");
                txtTexto.Text = txtTexto.Text.Replace("i", "");
                txtTexto.Text = txtTexto.Text.Replace("o", "");
                txtTexto.Text = txtTexto.Text.Replace("u", "");
                txtVocal.Text = "0";

            } else if (cboQuitar.SelectedIndex == 2)
            {
                txtTexto.Text = txtTexto.Text.Replace("b", "");
                txtTexto.Text = txtTexto.Text.Replace("c", "");
                txtTexto.Text = txtTexto.Text.Replace("d", "");
                txtTexto.Text = txtTexto.Text.Replace("f", "");
                txtTexto.Text = txtTexto.Text.Replace("g", "");
                txtTexto.Text = txtTexto.Text.Replace("h", "");
                txtTexto.Text = txtTexto.Text.Replace("i", "");
                txtTexto.Text = txtTexto.Text.Replace("j", "");
                txtTexto.Text = txtTexto.Text.Replace("k", "");
                txtTexto.Text = txtTexto.Text.Replace("l", "");
                txtTexto.Text = txtTexto.Text.Replace("m", "");
                txtTexto.Text = txtTexto.Text.Replace("n", "");
                txtTexto.Text = txtTexto.Text.Replace("p", "");
                txtTexto.Text = txtTexto.Text.Replace("q", "");
                txtTexto.Text = txtTexto.Text.Replace("r", "");
                txtTexto.Text = txtTexto.Text.Replace("s", "");
                txtTexto.Text = txtTexto.Text.Replace("t", "");
                txtTexto.Text = txtTexto.Text.Replace("v", "");
                txtTexto.Text = txtTexto.Text.Replace("w", "");
                txtTexto.Text = txtTexto.Text.Replace("x", "");
                txtTexto.Text = txtTexto.Text.Replace("y", "");
                txtTexto.Text = txtTexto.Text.Replace("z", "");

                txtTexto.Text = txtTexto.Text.Replace("B", "");
                txtTexto.Text = txtTexto.Text.Replace("C", "");
                txtTexto.Text = txtTexto.Text.Replace("D", "");
                txtTexto.Text = txtTexto.Text.Replace("F", "");
                txtTexto.Text = txtTexto.Text.Replace("G", "");
                txtTexto.Text = txtTexto.Text.Replace("H", "");
                txtTexto.Text = txtTexto.Text.Replace("I", "");
                txtTexto.Text = txtTexto.Text.Replace("J", "");
                txtTexto.Text = txtTexto.Text.Replace("K", "");
                txtTexto.Text = txtTexto.Text.Replace("L", "");
                txtTexto.Text = txtTexto.Text.Replace("M", "");
                txtTexto.Text = txtTexto.Text.Replace("N", "");
                txtTexto.Text = txtTexto.Text.Replace("P", "");
                txtTexto.Text = txtTexto.Text.Replace("Q", "");
                txtTexto.Text = txtTexto.Text.Replace("R", "");
                txtTexto.Text = txtTexto.Text.Replace("S", "");
                txtTexto.Text = txtTexto.Text.Replace("T", "");
                txtTexto.Text = txtTexto.Text.Replace("V", "");
                txtTexto.Text = txtTexto.Text.Replace("W", "");
                txtTexto.Text = txtTexto.Text.Replace("X", "");
                txtTexto.Text = txtTexto.Text.Replace("Y", "");
                txtTexto.Text = txtTexto.Text.Replace("Z", "");

                txtConsonate.Text = "0";

            }

            contarLinea();
            contarPalabra();
            contarEspacio();
            contarCaracter();
            contarTabulacion();
            contarVocal();
            contarConsonantes();

            if (txtConsonate.Text == "0" && txtVocal.Text == "0" && txtEspacio.Text == "0")
            {
                txtLineas.Text = "0";
            }
            if (txtVocal.Text == "0" || txtConsonate.Text == "0")
            {
                txtPalabra.Text = "0";
            }
            

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter guardarTexto = File.AppendText(guardar.FileName)) 
                guardarTexto.WriteLine(txtTexto.Text);
            }
        }
    }
}
