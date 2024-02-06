namespace Classe_Articoli
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkbox = new System.Windows.Forms.CheckBox();
            this.aggiungi = new System.Windows.Forms.Button();
            this.nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.codice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.descrizione = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.prezzo = new System.Windows.Forms.TextBox();
            this.checkbox2 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkbox
            // 
            this.checkbox.AutoSize = true;
            this.checkbox.Location = new System.Drawing.Point(114, 51);
            this.checkbox.Name = "checkbox";
            this.checkbox.Size = new System.Drawing.Size(66, 17);
            this.checkbox.TabIndex = 0;
            this.checkbox.Text = "Alimento";
            this.checkbox.UseVisualStyleBackColor = true;
            // 
            // aggiungi
            // 
            this.aggiungi.Location = new System.Drawing.Point(11, 51);
            this.aggiungi.Name = "aggiungi";
            this.aggiungi.Size = new System.Drawing.Size(97, 40);
            this.aggiungi.TabIndex = 1;
            this.aggiungi.Text = "Aggiungi";
            this.aggiungi.UseVisualStyleBackColor = true;
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(11, 25);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(170, 20);
            this.nome.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome Articolo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Codice Articolo:";
            // 
            // codice
            // 
            this.codice.Location = new System.Drawing.Point(362, 25);
            this.codice.Name = "codice";
            this.codice.Size = new System.Drawing.Size(173, 20);
            this.codice.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descrizione Articolo:";
            // 
            // descrizione
            // 
            this.descrizione.Location = new System.Drawing.Point(186, 25);
            this.descrizione.Multiline = true;
            this.descrizione.Name = "descrizione";
            this.descrizione.Size = new System.Drawing.Size(170, 66);
            this.descrizione.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Prezzo Articolo:";
            // 
            // prezzo
            // 
            this.prezzo.Location = new System.Drawing.Point(365, 71);
            this.prezzo.Name = "prezzo";
            this.prezzo.Size = new System.Drawing.Size(170, 20);
            this.prezzo.TabIndex = 9;
            // 
            // checkbox2
            // 
            this.checkbox2.AutoSize = true;
            this.checkbox2.Location = new System.Drawing.Point(114, 74);
            this.checkbox2.Name = "checkbox2";
            this.checkbox2.Size = new System.Drawing.Size(66, 17);
            this.checkbox2.TabIndex = 10;
            this.checkbox2.Text = "Prodotto";
            this.checkbox2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 26);
            this.button1.TabIndex = 11;
            this.button1.Text = "Aggiungi";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkbox2);
            this.Controls.Add(this.prezzo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.descrizione);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.codice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.aggiungi);
            this.Controls.Add(this.checkbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkbox;
        private System.Windows.Forms.Button aggiungi;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox descrizione;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox prezzo;
        private System.Windows.Forms.CheckBox checkbox2;
        private System.Windows.Forms.Button button1;
    }
}

