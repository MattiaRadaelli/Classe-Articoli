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
        public void InserisciArticoloAlimentare(string nome, string codice, string descrizione, double costo, bool sconto, DateTime data)
        {
            articoloalimentare.Add(new ArticoloAlimentare(nome,  codice,  descrizione,  costo,  sconto,  data));
        }



        List<ArticoloNonAlimentare> articolononalimentare = new List<ArticoloNonAlimentare>();
        public void InserisciArticoloNonAlimentare(string nome, string codice, string descrizione, double costo, bool sconto, bool riciclabile)
        {
            articolononalimentare.Add(new ArticoloNonAlimentare(nome, codice, descrizione, costo, sconto, riciclabile));
        }



        List<ArticoloAlimentareFresco> articoloalimentarefresco = new List<ArticoloAlimentareFresco>();
        public void InserisciArticoloAlimentareFresco(string nome, string codice, string descrizione, double costo, bool sconto, DateTime data, int fresco)
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
            public DateTime _data { get; set; }
            public ArticoloAlimentare(string nome, string codice, string descrizione, double costo, bool sconto, DateTime data) : base(nome, codice, descrizione, costo, sconto)
            {
                _data = data;
            }
            public override void Sconta()
            {
                if (Convert.ToInt16(_data) == DateTime.Now.Year)
                {
                    _costo = _costo - (_costo / 100) * 20;                   
                }               
            }           
        }
        class ArticoloAlimentareFresco : ArticoloAlimentare
        {
            public int _fresco { get; set; }
            public ArticoloAlimentareFresco(string nome, string codice, string descrizione, double costo, bool sconto, DateTime data, int fresco) : base(nome, codice, descrizione, costo, sconto, data)
            {
                _fresco = fresco;
            }
            public override void Sconta()
            {
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
            public ArticoloNonAlimentare(string nome, string codice, string descrizione, double costo, bool sconto, bool riciclabile) : base(nome, codice, descrizione, costo, sconto)
            {
                _riciclabile = riciclabile;
            }
            public override void Sconta()
            {
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
                dateTimePicker1.Visible = true;
                label6.Visible = true;
                checkBox3.Visible = true;
                label7.Visible = true;
                checkBox3.Checked = false;
            }
            if (checkbox.Checked == false)
            {
                dateTimePicker1.Visible = false;
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

        private void aggiungi_Click(object sender, EventArgs e)
        {
            if (checkbox.Checked == true && checkBox3.Checked == true)
            {
                InserisciArticoloAlimentareFresco( nome,  codice,  descrizione,  costo, checkBox1,  data,  fresco)
            }
            else if (checkbox2.Checked == true)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
