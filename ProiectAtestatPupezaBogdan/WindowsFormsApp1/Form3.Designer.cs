namespace WindowsFormsApp1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.lblY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.p3 = new System.Windows.Forms.Label();
            this.p2 = new System.Windows.Forms.Label();
            this.p1 = new System.Windows.Forms.Label();
            this.p0 = new System.Windows.Forms.Label();
            this.p11 = new System.Windows.Forms.Label();
            this.p10 = new System.Windows.Forms.Label();
            this.p9 = new System.Windows.Forms.Label();
            this.p4 = new System.Windows.Forms.Label();
            this.p5 = new System.Windows.Forms.Label();
            this.p6 = new System.Windows.Forms.Label();
            this.p8 = new System.Windows.Forms.Label();
            this.p7 = new System.Windows.Forms.Label();
            this.database1DataSet = new WindowsFormsApp1.Database1DataSet();
            this.porturiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.porturiTableAdapter = new WindowsFormsApp1.Database1DataSetTableAdapters.PorturiTableAdapter();
            this.distantaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.distantaTableAdapter = new WindowsFormsApp1.Database1DataSetTableAdapters.DistantaTableAdapter();
            this.croaziereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.croaziereTableAdapter = new WindowsFormsApp1.Database1DataSetTableAdapters.CroaziereTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porturiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distantaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.croaziereBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(616, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "Initializare  Coordonate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(616, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 60);
            this.button2.TabIndex = 0;
            this.button2.Text = "Salvare Coordonate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(616, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 72);
            this.button3.TabIndex = 0;
            this.button3.Text = "Actualizare distante";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(616, 237);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 61);
            this.button4.TabIndex = 0;
            this.button4.Text = "Generare croaziere";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(616, 312);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 62);
            this.button5.TabIndex = 0;
            this.button5.Text = "Liste croaziere";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY.Location = new System.Drawing.Point(398, 386);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(25, 25);
            this.lblY.TabIndex = 1;
            this.lblY.Text = "Y";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(211, 386);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(26, 25);
            this.lblX.TabIndex = 1;
            this.lblX.Text = "X";
            // 
            // p3
            // 
            this.p3.AutoSize = true;
            this.p3.BackColor = System.Drawing.Color.Red;
            this.p3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p3.ForeColor = System.Drawing.Color.Red;
            this.p3.Location = new System.Drawing.Point(67, 313);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(16, 16);
            this.p3.TabIndex = 3;
            this.p3.Text = "o";
            this.p3.Click += new System.EventHandler(this.p3_Click);
            // 
            // p2
            // 
            this.p2.AutoSize = true;
            this.p2.BackColor = System.Drawing.Color.Red;
            this.p2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2.ForeColor = System.Drawing.Color.Red;
            this.p2.Location = new System.Drawing.Point(26, 237);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(16, 16);
            this.p2.TabIndex = 3;
            this.p2.Text = "o";
            this.p2.Click += new System.EventHandler(this.p2_Click);
            // 
            // p1
            // 
            this.p1.AutoSize = true;
            this.p1.BackColor = System.Drawing.Color.Red;
            this.p1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1.ForeColor = System.Drawing.Color.Red;
            this.p1.Location = new System.Drawing.Point(45, 203);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(16, 16);
            this.p1.TabIndex = 3;
            this.p1.Text = "o";
            this.p1.Click += new System.EventHandler(this.p1_Click);
            // 
            // p0
            // 
            this.p0.AutoSize = true;
            this.p0.BackColor = System.Drawing.Color.Red;
            this.p0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p0.ForeColor = System.Drawing.Color.Red;
            this.p0.Location = new System.Drawing.Point(74, 163);
            this.p0.Name = "p0";
            this.p0.Size = new System.Drawing.Size(16, 16);
            this.p0.TabIndex = 3;
            this.p0.Text = "o";
            this.p0.Click += new System.EventHandler(this.p0_Click);
            // 
            // p11
            // 
            this.p11.AutoSize = true;
            this.p11.BackColor = System.Drawing.Color.Red;
            this.p11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p11.ForeColor = System.Drawing.Color.Red;
            this.p11.Location = new System.Drawing.Point(152, 74);
            this.p11.Name = "p11";
            this.p11.Size = new System.Drawing.Size(16, 16);
            this.p11.TabIndex = 3;
            this.p11.Text = "o";
            this.p11.Click += new System.EventHandler(this.p11_Click);
            // 
            // p10
            // 
            this.p10.AutoSize = true;
            this.p10.BackColor = System.Drawing.Color.Red;
            this.p10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p10.ForeColor = System.Drawing.Color.Red;
            this.p10.Location = new System.Drawing.Point(235, 166);
            this.p10.Name = "p10";
            this.p10.Size = new System.Drawing.Size(16, 16);
            this.p10.TabIndex = 3;
            this.p10.Text = "o";
            this.p10.Click += new System.EventHandler(this.p10_Click);
            // 
            // p9
            // 
            this.p9.AutoSize = true;
            this.p9.BackColor = System.Drawing.Color.Red;
            this.p9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p9.ForeColor = System.Drawing.Color.Red;
            this.p9.Location = new System.Drawing.Point(261, 163);
            this.p9.Name = "p9";
            this.p9.Size = new System.Drawing.Size(16, 16);
            this.p9.TabIndex = 3;
            this.p9.Text = "o";
            this.p9.Click += new System.EventHandler(this.p9_Click);
            // 
            // p4
            // 
            this.p4.AutoSize = true;
            this.p4.BackColor = System.Drawing.Color.Red;
            this.p4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p4.ForeColor = System.Drawing.Color.Red;
            this.p4.Location = new System.Drawing.Point(170, 299);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(16, 16);
            this.p4.TabIndex = 3;
            this.p4.Text = "o";
            this.p4.Click += new System.EventHandler(this.p4_Click);
            // 
            // p5
            // 
            this.p5.AutoSize = true;
            this.p5.BackColor = System.Drawing.Color.Red;
            this.p5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p5.ForeColor = System.Drawing.Color.Red;
            this.p5.Location = new System.Drawing.Point(323, 314);
            this.p5.Name = "p5";
            this.p5.Size = new System.Drawing.Size(16, 16);
            this.p5.TabIndex = 3;
            this.p5.Text = "o";
            this.p5.Click += new System.EventHandler(this.p5_Click);
            // 
            // p6
            // 
            this.p6.AutoSize = true;
            this.p6.BackColor = System.Drawing.Color.Red;
            this.p6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p6.ForeColor = System.Drawing.Color.Red;
            this.p6.Location = new System.Drawing.Point(507, 305);
            this.p6.Name = "p6";
            this.p6.Size = new System.Drawing.Size(16, 16);
            this.p6.TabIndex = 3;
            this.p6.Text = "o";
            this.p6.Click += new System.EventHandler(this.p6_Click);
            // 
            // p8
            // 
            this.p8.AutoSize = true;
            this.p8.BackColor = System.Drawing.Color.Red;
            this.p8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p8.ForeColor = System.Drawing.Color.Red;
            this.p8.Location = new System.Drawing.Point(373, 166);
            this.p8.Name = "p8";
            this.p8.Size = new System.Drawing.Size(16, 16);
            this.p8.TabIndex = 3;
            this.p8.Text = "o";
            this.p8.Click += new System.EventHandler(this.p8_Click);
            // 
            // p7
            // 
            this.p7.AutoSize = true;
            this.p7.BackColor = System.Drawing.Color.Red;
            this.p7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p7.ForeColor = System.Drawing.Color.Red;
            this.p7.Location = new System.Drawing.Point(440, 210);
            this.p7.Name = "p7";
            this.p7.Size = new System.Drawing.Size(16, 16);
            this.p7.TabIndex = 3;
            this.p7.Text = "o";
            this.p7.Click += new System.EventHandler(this.p7_Click);
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // porturiBindingSource
            // 
            this.porturiBindingSource.DataMember = "Porturi";
            this.porturiBindingSource.DataSource = this.database1DataSet;
            // 
            // porturiTableAdapter
            // 
            this.porturiTableAdapter.ClearBeforeFill = true;
            // 
            // distantaBindingSource
            // 
            this.distantaBindingSource.DataMember = "Distanta";
            this.distantaBindingSource.DataSource = this.database1DataSet;
            // 
            // distantaTableAdapter
            // 
            this.distantaTableAdapter.ClearBeforeFill = true;
            // 
            // croaziereBindingSource
            // 
            this.croaziereBindingSource.DataMember = "Croaziere";
            this.croaziereBindingSource.DataSource = this.database1DataSet;
            // 
            // croaziereTableAdapter
            // 
            this.croaziereTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 377);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Coordonate:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(760, 431);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.p7);
            this.Controls.Add(this.p8);
            this.Controls.Add(this.p6);
            this.Controls.Add(this.p5);
            this.Controls.Add(this.p4);
            this.Controls.Add(this.p9);
            this.Controls.Add(this.p10);
            this.Controls.Add(this.p11);
            this.Controls.Add(this.p0);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Lista croaziera";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed_1);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porturiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distantaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.croaziereBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label p3;
        private System.Windows.Forms.Label p2;
        private System.Windows.Forms.Label p1;
        private System.Windows.Forms.Label p0;
        private System.Windows.Forms.Label p11;
        private System.Windows.Forms.Label p10;
        private System.Windows.Forms.Label p9;
        private System.Windows.Forms.Label p4;
        private System.Windows.Forms.Label p5;
        private System.Windows.Forms.Label p6;
        private System.Windows.Forms.Label p8;
        private System.Windows.Forms.Label p7;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource porturiBindingSource;
        private Database1DataSetTableAdapters.PorturiTableAdapter porturiTableAdapter;
        private System.Windows.Forms.BindingSource distantaBindingSource;
        private Database1DataSetTableAdapters.DistantaTableAdapter distantaTableAdapter;
        private System.Windows.Forms.BindingSource croaziereBindingSource;
        private Database1DataSetTableAdapters.CroaziereTableAdapter croaziereTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}