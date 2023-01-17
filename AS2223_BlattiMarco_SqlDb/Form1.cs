using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS2223_BlattiMarco_SqlDb
{
    public partial class Form1 : Form
    {
        private const string V = "\r\n";
        list<Query> querylist;

        public Form1()
        {
            InitializeComponent();
            // creo la lista di query
            querylist = new List<Query>();
        }
        private void btnDb_Click(object sender, EventArgs e)
        {
            // cliccando il bottone apre il percorso file
            OpenFileDialog opDialog = new OpenFileDialog();

            opDialog.InitialDirectory = Application.StartupPath;
            opDialog.Filter = "Sqlite files (*.db)|*.db|Mdb files (*.mdb)|*mdb|Xls files (*.xls)|*xls";
            opDialog.FilterIndex = 1;
            opDialog.RestoreDirectory = true;
            // da il risultato di quello che hai aperto
            DialogResult dialogResult = opDialog.ShowDialog();
        }
        private void btnQuery_Click(object sender, EventArgs e)
        {
            OpenFileDialog opDialog = new OpenFileDialog();

            opDialog.InitialDirectory = Application.StartupPath;
            opDialog.Filter = "Text files (*.txt)|*.txt";
            opDialog.FilterIndex = 1;
            opDialog.RestoreDirectory = true;

            DialogResult dialogResult = opDialog.ShowDialog();

            if (dialogResult == DialogResult.OK) txtQuery.Text = opDialog.FileName;
        }

        private void btnEsegui_Click(object sender, EventArgs e)
        {
            // definizione della stringa di connessione
            string connectionString = $"Data Source={txtDb.Text};Version=3", queryString = txtQuery.Text;

            if (txtDb.Text == "" || txtQuery.Text == "")
            {
                MessageBox.Show("Compilare tutti i campi");
                return;
            }
            // controlla che ci sia un elemento selezionato nel combobox
            if (cmbQuery.SelectedItem == null)
            {
                MessageBox.Show("Selezionare una query");
                return;
            }

            DataTable dt = new DataTable();
            // rimpiazza i parametri con i valori assegnati
            queryString = ReplaceParameters(queryString);

            var dataAdapter = new SQLiteDataAdapter(queryString, connectionString);

            try
            {
                // riempe il dataAdapter
                dataAdapter.Fill(dt);
                dataGrid.DataSource = dt;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private string ReplaceParameters(string input)
        {
            if (txt1.Text != "") input = input.Replace("@PAR1@", txt1.Text);
            if (txt2.Text != "") input = input.Replace("@PAR2@", txt2.Text);
            if (txt3.Text != "") input = input.Replace("@PAR3@", txt3.Text);
            if (txt4.Text != "") input = input.Replace("@PAR4@", txt4.Text);
            if (txt5.Text != "") input = input.Replace("@PAR5@", txt5.Text);
            if (txt6.Text != "") input = input.Replace("@PAR6@", txt6.Text);

            return input;
        }

        private List<Query> DecodeFile(string input, string v)
        {

            List<Query> output = new List<Query>();
            string[] contentSplitted = input.Split('#'), rowSplitted;
            string content, titolo;
            // ricava le diverse query 
            foreach (string queryString in contentSplitted)
            {
                if (queryString == "") continue;

                content = "";

                rowSplitted = queryString.Split();

                titolo = rowSplitted[0];
                // prende tutte le stringhe nell'array e le unisce utilizzando uno spazio per separarle
                content = string.Join(" ", rowSplitted.Skip(1));

                Query q = new Query(titolo, content.Trim());
                output.Add(q);
            }

            return output;
        }

        private void btnCarica_Click(object sender, EventArgs e)
        {
            string fileContent;

            try
            {
                StreamReader sr = new StreamReader(txtQuery.Text);
                fileContent = sr.ReadToEnd();
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            

            querylist = DecodeFile(fileContent, V);
            // pulisce gli elementi dentro il combo
            cmbQuery.Items.Clear();
            // collegamento degli oggetti con il combobox
            cmbQuery.DataSource = querylist;

            cmbQuery.DisplayMember = "Titolo";
            cmbQuery.ValueMember = "Contenuto";

        }
        // classe che uso per comuniare con il database
        private class SQLiteDataAdapter
        {
            private string queryString;
            private string connectionString;

            //costruttore
            public SQLiteDataAdapter(string queryString, string connectionString)
            {
                this.queryString = queryString;
                this.connectionString = connectionString;
            }

            // riempie il dataTable
            internal void Fill(DataTable dt)
            {
                throw new NotImplementedException();
            }
        }
    }

        
}

