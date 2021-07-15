namespace WindowsFormsApp1
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CB = new System.Windows.Forms.ComboBox();
            this.croaziereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new WindowsFormsApp1.Database1DataSet();
            this.croaziereTableAdapter = new WindowsFormsApp1.Database1DataSetTableAdapters.CroaziereTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id_Croaziera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipCroazieraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porturiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFinalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrPasageriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.croaziereBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.croaziereBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.croaziereBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // CB
            // 
            this.CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB.FormattingEnabled = true;
            this.CB.Items.AddRange(new object[] {
            "3zile",
            "5zile",
            "8zile"});
            this.CB.Location = new System.Drawing.Point(470, 37);
            this.CB.Name = "CB";
            this.CB.Size = new System.Drawing.Size(179, 32);
            this.CB.TabIndex = 0;
            this.CB.TextChanged += new System.EventHandler(this.CB_TextChanged);
            // 
            // croaziereBindingSource
            // 
            this.croaziereBindingSource.DataMember = "Croaziere";
            this.croaziereBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // croaziereTableAdapter
            // 
            this.croaziereTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Croaziera,
            this.tipCroazieraDataGridViewTextBoxColumn,
            this.porturiDataGridViewTextBoxColumn,
            this.dataStartDataGridViewTextBoxColumn,
            this.dataFinalDataGridViewTextBoxColumn,
            this.pretDataGridViewTextBoxColumn,
            this.nrPasageriDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.croaziereBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1043, 461);
            this.dataGridView1.TabIndex = 1;
            // 
            // Id_Croaziera
            // 
            this.Id_Croaziera.DataPropertyName = "Id_Croaziera";
            this.Id_Croaziera.HeaderText = "Id_Croaziera";
            this.Id_Croaziera.Name = "Id_Croaziera";
            this.Id_Croaziera.ReadOnly = true;
            // 
            // tipCroazieraDataGridViewTextBoxColumn
            // 
            this.tipCroazieraDataGridViewTextBoxColumn.DataPropertyName = "Tip_Croaziera";
            this.tipCroazieraDataGridViewTextBoxColumn.HeaderText = "Tip_Croaziera";
            this.tipCroazieraDataGridViewTextBoxColumn.Name = "tipCroazieraDataGridViewTextBoxColumn";
            this.tipCroazieraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // porturiDataGridViewTextBoxColumn
            // 
            this.porturiDataGridViewTextBoxColumn.DataPropertyName = "Porturi";
            this.porturiDataGridViewTextBoxColumn.HeaderText = "Porturi";
            this.porturiDataGridViewTextBoxColumn.Name = "porturiDataGridViewTextBoxColumn";
            this.porturiDataGridViewTextBoxColumn.ReadOnly = true;
            this.porturiDataGridViewTextBoxColumn.Width = 400;
            // 
            // dataStartDataGridViewTextBoxColumn
            // 
            this.dataStartDataGridViewTextBoxColumn.DataPropertyName = "Data_Start";
            this.dataStartDataGridViewTextBoxColumn.HeaderText = "Data_Start";
            this.dataStartDataGridViewTextBoxColumn.Name = "dataStartDataGridViewTextBoxColumn";
            this.dataStartDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataFinalDataGridViewTextBoxColumn
            // 
            this.dataFinalDataGridViewTextBoxColumn.DataPropertyName = "Data_Final";
            this.dataFinalDataGridViewTextBoxColumn.HeaderText = "Data_Final";
            this.dataFinalDataGridViewTextBoxColumn.Name = "dataFinalDataGridViewTextBoxColumn";
            this.dataFinalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pretDataGridViewTextBoxColumn
            // 
            this.pretDataGridViewTextBoxColumn.DataPropertyName = "Pret";
            this.pretDataGridViewTextBoxColumn.HeaderText = "Pret";
            this.pretDataGridViewTextBoxColumn.Name = "pretDataGridViewTextBoxColumn";
            this.pretDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nrPasageriDataGridViewTextBoxColumn
            // 
            this.nrPasageriDataGridViewTextBoxColumn.DataPropertyName = "Nr_Pasageri";
            this.nrPasageriDataGridViewTextBoxColumn.HeaderText = "Nr_Pasageri";
            this.nrPasageriDataGridViewTextBoxColumn.Name = "nrPasageriDataGridViewTextBoxColumn";
            this.nrPasageriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // croaziereBindingSource1
            // 
            this.croaziereBindingSource1.DataMember = "Croaziere";
            this.croaziereBindingSource1.DataSource = this.database1DataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Solicitati tipul de croaziera:";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(924, 571);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(179, 34);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Iesire";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1134, 661);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CB);
            this.Name = "Form5";
            this.Text = "Liste croaziere";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form5_FormClosed);
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.croaziereBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.croaziereBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource croaziereBindingSource;
        private Database1DataSetTableAdapters.CroaziereTableAdapter croaziereTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource croaziereBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Croaziera;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipCroazieraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn porturiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFinalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrPasageriDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
    }
}