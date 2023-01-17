namespace AS2223_BlattiMarco_SqlDb
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
            this.txtDb = new System.Windows.Forms.TextBox();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.lblDb = new System.Windows.Forms.Label();
            this.lblQuerylblQuery = new System.Windows.Forms.Label();
            this.lblQuery2 = new System.Windows.Forms.Label();
            this.btnDb = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.cmbQuery = new System.Windows.Forms.ComboBox();
            this.btnEsegui = new System.Windows.Forms.Button();
            this.btnCarica = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt6 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDb
            // 
            this.txtDb.Location = new System.Drawing.Point(171, 96);
            this.txtDb.Name = "txtDb";
            this.txtDb.Size = new System.Drawing.Size(218, 22);
            this.txtDb.TabIndex = 0;
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(171, 145);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(218, 22);
            this.txtQuery.TabIndex = 1;
            // 
            // lblDb
            // 
            this.lblDb.Location = new System.Drawing.Point(62, 99);
            this.lblDb.Name = "lblDb";
            this.lblDb.Size = new System.Drawing.Size(103, 49);
            this.lblDb.TabIndex = 3;
            this.lblDb.Text = "DB";
            // 
            // lblQuerylblQuery
            // 
            this.lblQuerylblQuery.Location = new System.Drawing.Point(62, 148);
            this.lblQuerylblQuery.Name = "lblQuerylblQuery";
            this.lblQuerylblQuery.Size = new System.Drawing.Size(94, 44);
            this.lblQuerylblQuery.TabIndex = 4;
            this.lblQuerylblQuery.Text = "FileQuery";
            // 
            // lblQuery2
            // 
            this.lblQuery2.Location = new System.Drawing.Point(62, 205);
            this.lblQuery2.Name = "lblQuery2";
            this.lblQuery2.Size = new System.Drawing.Size(80, 43);
            this.lblQuery2.TabIndex = 5;
            this.lblQuery2.Text = "QUERY";
            // 
            // btnDb
            // 
            this.btnDb.Location = new System.Drawing.Point(425, 96);
            this.btnDb.Name = "btnDb";
            this.btnDb.Size = new System.Drawing.Size(30, 21);
            this.btnDb.TabIndex = 6;
            this.btnDb.Text = "...";
            this.btnDb.UseVisualStyleBackColor = true;
            this.btnDb.Click += new System.EventHandler(this.btnDb_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(425, 148);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(30, 21);
            this.btnQuery.TabIndex = 7;
            this.btnQuery.Text = "...";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // cmbQuery
            // 
            this.cmbQuery.FormattingEnabled = true;
            this.cmbQuery.Location = new System.Drawing.Point(171, 202);
            this.cmbQuery.Name = "cmbQuery";
            this.cmbQuery.Size = new System.Drawing.Size(218, 24);
            this.cmbQuery.TabIndex = 8;
            // 
            // btnEsegui
            // 
            this.btnEsegui.Location = new System.Drawing.Point(171, 232);
            this.btnEsegui.Name = "btnEsegui";
            this.btnEsegui.Size = new System.Drawing.Size(103, 47);
            this.btnEsegui.TabIndex = 9;
            this.btnEsegui.Text = "ESEGUI";
            this.btnEsegui.UseVisualStyleBackColor = true;
            this.btnEsegui.Click += new System.EventHandler(this.btnEsegui_Click);
            // 
            // btnCarica
            // 
            this.btnCarica.Location = new System.Drawing.Point(280, 232);
            this.btnCarica.Name = "btnCarica";
            this.btnCarica.Size = new System.Drawing.Size(98, 47);
            this.btnCarica.TabIndex = 10;
            this.btnCarica.Text = "CARICA";
            this.btnCarica.UseVisualStyleBackColor = true;
            this.btnCarica.Click += new System.EventHandler(this.btnCarica_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(65, 285);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(513, 232);
            this.dataGrid.TabIndex = 11;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(658, 285);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(130, 22);
            this.txt1.TabIndex = 12;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(658, 330);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(130, 22);
            this.txt2.TabIndex = 13;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(658, 384);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(130, 22);
            this.txt3.TabIndex = 14;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(827, 285);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(117, 22);
            this.txt4.TabIndex = 15;
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(827, 330);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(117, 22);
            this.txt5.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(65, 307);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(513, 232);
            this.dataGridView1.TabIndex = 11;
            // 
            // txt6
            // 
            this.txt6.Location = new System.Drawing.Point(827, 384);
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(117, 22);
            this.txt6.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 575);
            this.Controls.Add(this.txt6);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.btnCarica);
            this.Controls.Add(this.btnEsegui);
            this.Controls.Add(this.cmbQuery);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.btnDb);
            this.Controls.Add(this.lblQuery2);
            this.Controls.Add(this.lblQuerylblQuery);
            this.Controls.Add(this.lblDb);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.txtDb);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDb;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Label lblDb;
        private System.Windows.Forms.Label lblQuerylblQuery;
        private System.Windows.Forms.Label lblQuery2;
        private System.Windows.Forms.Button btnDb;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.ComboBox cmbQuery;
        private System.Windows.Forms.Button btnEsegui;
        private System.Windows.Forms.Button btnCarica;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt6;
        protected System.Windows.Forms.TextBox txt1;
    }
}

