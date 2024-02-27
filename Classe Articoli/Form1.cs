using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Classe_Articoli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        List<ArticoloAlimentare> articoloalimentare = new List<ArticoloAlimentare>();
        public void InserisciArticoloAlimentare(string nome, string codice, string descrizione, double costo, bool sconto, int data)
        {
            articoloalimentare.Add(new ArticoloAlimentare(nome,  codice,  descrizione,  costo,  sconto,  data));
        }



        List<ArticoloNonAlimentare> articolononalimentare = new List<ArticoloNonAlimentare>();
        public void InserisciArticoloNonAlimentare(string nome, string codice, string descrizione, double costo, bool sconto, bool riciclabile, string materiale)
        {
            articolononalimentare.Add(new ArticoloNonAlimentare(nome, codice, descrizione, costo, sconto, riciclabile, materiale));
        }



        List<ArticoloAlimentareFresco> articoloalimentarefresco = new List<ArticoloAlimentareFresco>();
        public void InserisciArticoloAlimentareFresco(string nome, string codice, string descrizione, double costo, bool sconto, int data, int fresco)
        {
            articoloalimentarefresco.Add(new ArticoloAlimentareFresco( nome,  codice,  descrizione,  costo,  sconto,  data,  fresco));
        }

        class Articolo
        {
            public string _nome { get; set; }
            public string _codice { get; set; }
            public string _descrizione { get; set; }
            public double _costo { get; set; }
            public bool _sconto { get; set; }


            public Articolo(string nome, string codice, string descrizione, double costo, bool sconto)
            {
                _nome = nome;
                _codice = codice;
                _descrizione = descrizione;
                _costo = costo;
                _sconto = sconto;               
            }

            public virtual void Sconta()
            {
               if (_sconto == true)
               {
                    _costo = _costo - (_costo / 100) * 5;
               }
            }
        }

        class ArticoloAlimentare : Articolo
        {
            public int _data { get; set; }
            public ArticoloAlimentare(string nome, string codice, string descrizione, double costo, bool sconto, int data) : base(nome, codice, descrizione, costo, sconto)
            {
                _data = data;
            }
            public override void Sconta()
            {
                if (_sconto == true)
                {
                    _costo = _costo - (_costo / 100) * 5;
                }
                if (_data == DateTime.Now.Year)
                {
                    _costo = _costo - (_costo / 100) * 20;                   
                }               
            }           
        }
        class ArticoloAlimentareFresco : ArticoloAlimentare
        {
            public int _fresco { get; set; }
            public ArticoloAlimentareFresco(string nome, string codice, string descrizione, double costo, bool sconto, int data, int fresco) : base(nome, codice, descrizione, costo, sconto, data)
            {
                _fresco = fresco;
            }
            public override void Sconta()
            {
                if (_sconto == true)
                {
                    _costo = _costo - (_costo / 100) * 5;
                }
                int sconto = 0;
                for (int i = 6; i > _fresco; i--)
                {
                    sconto += 2;
                }
                _costo = _costo - (_costo / 100) * sconto;               
            }
        }

        class ArticoloNonAlimentare : Articolo
        {
            public bool _riciclabile { get; set; }
            public string _materiale { get; set; }
            public ArticoloNonAlimentare(string nome, string codice, string descrizione, double costo, bool sconto, bool riciclabile, string materiale) : base(nome, codice, descrizione, costo, sconto)
            {
                _riciclabile = riciclabile;
                _materiale = materiale;
            }
            public override void Sconta()
            {
                if (_sconto == true)
                {
                    _costo = _costo - (_costo / 100) * 5;
                }
                if (_riciclabile == true)
                {
                    _costo = _costo - (_costo / 100) * 10;
                }
            }
        }



        private void checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox2.Checked == true)
            {
                checkbox2.Checked = false;
            }
            if (checkbox.Checked == true)
            {
                textBox3.Visible = true;
                label6.Visible = true;
                checkBox3.Visible = true;
                label7.Visible = true;
                checkBox3.Checked = false;
            }
            if (checkbox.Checked == false)
            {
                textBox3.Visible = false;
                label6.Visible = false;
                checkBox3.Visible = false;
                checkBox3.Checked = false;
                label7.Visible = false;
                label8.Visible = false;
                textBox1.Visible = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                textBox1.Visible = true;
                label8.Visible = true;
            }
            if (checkBox3.Checked == false)
            {
                textBox1.Visible = false;
                label8.Visible = false;
            }
        }

        private void checkbox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox.Checked == true)
            {
                checkbox.Checked = false;
            }
            if (checkbox2.Checked == true)
            {
                textBox2.Visible = true;
                label10.Visible = true;
                checkBox4.Visible = true;
                label9.Visible = true;
            }
            if (checkbox2.Checked == false)
            {
                textBox2.Visible = false;
                label10.Visible = false;
                checkBox4.Visible = false;
                label9.Visible = false;
                checkBox4.Checked = false;
            }
        }
        int indicealimenti = 0;
        int indicealimentifreschi = 0;
        int indicenonalimenti = 0;
        private void aggiungi_Click(object sender, EventArgs e)
        {
            if (checkbox.Checked == true && checkBox3.Checked == true)
            {                
                InserisciArticoloAlimentareFresco(nome.Text, codice.Text, descrizione.Text, Convert.ToInt16(costo.Text) , checkBox1.Checked, Convert.ToInt16(textBox3.Text), Convert.ToInt16(textBox1.Text));
                articoloalimentarefresco[indicealimentifreschi].Sconta();
                indicealimentifreschi++;
            }
            else if (checkbox.Checked == true && checkBox3.Checked == false)
            {                
                InserisciArticoloAlimentare(nome.Text, codice.Text, descrizione.Text, Convert.ToInt16(costo.Text), checkBox1.Checked, Convert.ToInt16(textBox3.Text));
                articoloalimentare[indicealimenti].Sconta();
                indicealimenti++;
            }
            else if (checkbox2.Checked == true)
            {
                InserisciArticoloNonAlimentare(nome.Text, codice.Text, descrizione.Text, Convert.ToInt16(costo.Text), checkBox1.Checked, checkBox4.Checked, textBox2.Text);
                articolononalimentare[indicenonalimenti].Sconta();
                indicenonalimenti++;
            }       
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            scontrino.Visible = true;
            scontrino.Text = "ALIMENTI: \r\n";
            for (int i = 0; i < articoloalimentare.Count; i++)
            {
                scontrino.Text += ("Prodotto: " + (i + 1) + "\r\n" + "Nome: " + articoloalimentare[i]._nome + "\r\n" + "Descrizione: " + articoloalimentare[i]._descrizione + "\r\n" + "Prezzo: " + Convert.ToString(articoloalimentare[i]._costo) + "\r\n" + "Codice: " + Convert.ToString(articoloalimentare[i]._codice) + "\r\n" + "Sconto: " + checkBox1.Checked + "\r\n" + "Data Scadenza: " + Convert.ToString(articoloalimentare[i]._data) + "\r\n");                                                                                                                                                                                                 
            }
            scontrino.Text += "\r\n";
            scontrino.Text += "ALIMENTI FRESCHI: \r\n";
            for (int i = 0; i < articoloalimentarefresco.Count; i++)
            {
                scontrino.Text += ("Prodotto: " + (i + 1) + "\r\n" + "Nome: " + articoloalimentarefresco[i]._nome + "\r\n" + "Descrizione: " + articoloalimentarefresco[i]._descrizione + "\r\n" + "Prezzo: " + Convert.ToString(articoloalimentarefresco[i]._costo) + "\r\n" + "Codice: " + Convert.ToString(articoloalimentarefresco[i]._codice) + "\r\n" + "Sconto: " + checkBox1.Checked + "\r\n" + "Scadenza: " + Convert.ToString(articoloalimentarefresco[i]._fresco) + " giorni" + "\r\n");
            }
            scontrino.Text += "\r\n";
            scontrino.Text += "NON ALIMENTI: \r\n";
            for (int i = 0; i < articolononalimentare.Count; i++)
            {
                scontrino.Text += ("Prodotto: " + (i + 1) + "\r\n" + "Nome: " + articolononalimentare[i]._nome + "\r\n" + "Descrizione: " + articolononalimentare[i]._descrizione + "\r\n" + "Prezzo: " + Convert.ToString(articolononalimentare[i]._costo) + "\r\n" + "Codice: " + Convert.ToString(articolononalimentare[i]._codice) + "\r\n" + "Sconto: " + checkBox1.Checked + "\r\n" + "Materiale Principale:  " + Convert.ToString(articolononalimentare[i]._materiale) + "\r\n" + "Ricilabilità: " + articolononalimentare[i]._riciclabile + "\r\n");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            scontrino.Visible = false;
            button2.Visible = false;
        }

    }
}
