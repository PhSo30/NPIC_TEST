namespace NPIC_TEST.views
{
    partial class Dashboard2
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
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.labelx = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.administrativeBoundariesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nPIC_TESTDataSet = new NPIC_TEST.NPIC_TESTDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.administrativeBoundariesTableAdapter = new NPIC_TEST.NPIC_TESTDataSetTableAdapters.AdministrativeBoundariesTableAdapter();
            this.fKAdministrativeBoundariesAdministrativeBoundariesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.administrativeBoundariesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.administrativeBoundariesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.administrativeBoundariesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.administrativeBoundariesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPIC_TESTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKAdministrativeBoundariesAdministrativeBoundariesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administrativeBoundariesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administrativeBoundariesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administrativeBoundariesBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 330);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 34);
            this.label6.TabIndex = 30;
            this.label6.Text = "ភូមិ";
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.administrativeBoundariesBindingSource3;
            this.comboBox4.DisplayMember = "TitleKH";
            this.comboBox4.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(237, 326);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(428, 42);
            this.comboBox4.TabIndex = 29;
            this.comboBox4.ValueMember = "ID";
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 266);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 34);
            this.label5.TabIndex = 28;
            this.label5.Text = "ឃុំ/សង្កាត់";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.administrativeBoundariesBindingSource2;
            this.comboBox3.DisplayMember = "TitleKH";
            this.comboBox3.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(237, 262);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(428, 42);
            this.comboBox3.TabIndex = 27;
            this.comboBox3.ValueMember = "ID";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // labelx
            // 
            this.labelx.AutoSize = true;
            this.labelx.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelx.Location = new System.Drawing.Point(49, 203);
            this.labelx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelx.Name = "labelx";
            this.labelx.Size = new System.Drawing.Size(98, 34);
            this.labelx.TabIndex = 26;
            this.labelx.Text = "ស្រុក/ខណ្ឌ";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.administrativeBoundariesBindingSource1;
            this.comboBox2.DisplayMember = "TitleKH";
            this.comboBox2.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(237, 199);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(428, 42);
            this.comboBox2.TabIndex = 25;
            this.comboBox2.ValueMember = "ID";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(561, 12);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(100, 38);
            this.checkBox2.TabIndex = 24;
            this.checkBox2.Text = "English";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(567, 466);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 47);
            this.button2.TabIndex = 23;
            this.button2.Text = "រក្សាទុក";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 474);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 34);
            this.label3.TabIndex = 22;
            this.label3.Text = "ទីតាំង";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 34);
            this.label2.TabIndex = 21;
            this.label2.Text = "រាជធានី/ខេត្ត";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(56, 529);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(609, 267);
            this.textBox2.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(459, 466);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 47);
            this.button1.TabIndex = 19;
            this.button1.Text = "ជម្រះ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(413, 12);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(109, 38);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "ភាសាខ្មែរ";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.administrativeBoundariesBindingSource;
            this.comboBox1.DisplayMember = "TitleKH";
            this.comboBox1.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(237, 135);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(428, 42);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.ValueMember = "ID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // administrativeBoundariesBindingSource
            // 
            this.administrativeBoundariesBindingSource.DataMember = "AdministrativeBoundaries";
            this.administrativeBoundariesBindingSource.DataSource = this.nPIC_TESTDataSet;
            // 
            // nPIC_TESTDataSet
            // 
            this.nPIC_TESTDataSet.DataSetName = "NPIC_TESTDataSet";
            this.nPIC_TESTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 34);
            this.label1.TabIndex = 16;
            this.label1.Text = "បង្ហាញជា";
            // 
            // administrativeBoundariesTableAdapter
            // 
            this.administrativeBoundariesTableAdapter.ClearBeforeFill = true;
            // 
            // fKAdministrativeBoundariesAdministrativeBoundariesBindingSource
            // 
            this.fKAdministrativeBoundariesAdministrativeBoundariesBindingSource.DataMember = "FK_AdministrativeBoundaries_AdministrativeBoundaries";
            this.fKAdministrativeBoundariesAdministrativeBoundariesBindingSource.DataSource = this.administrativeBoundariesBindingSource;
            // 
            // administrativeBoundariesBindingSource1
            // 
            this.administrativeBoundariesBindingSource1.DataMember = "AdministrativeBoundaries";
            this.administrativeBoundariesBindingSource1.DataSource = this.nPIC_TESTDataSet;
            // 
            // administrativeBoundariesBindingSource2
            // 
            this.administrativeBoundariesBindingSource2.DataMember = "AdministrativeBoundaries";
            this.administrativeBoundariesBindingSource2.DataSource = this.nPIC_TESTDataSet;
            // 
            // administrativeBoundariesBindingSource3
            // 
            this.administrativeBoundariesBindingSource3.DataMember = "AdministrativeBoundaries";
            this.administrativeBoundariesBindingSource3.DataSource = this.nPIC_TESTDataSet;
            // 
            // Dashboard2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 818);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.labelx);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Dashboard2";
            this.Text = "Dashboard2";
            this.Load += new System.EventHandler(this.Dashboard2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.administrativeBoundariesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPIC_TESTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKAdministrativeBoundariesAdministrativeBoundariesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.administrativeBoundariesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.administrativeBoundariesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.administrativeBoundariesBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label labelx;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private NPIC_TESTDataSet nPIC_TESTDataSet;
        private System.Windows.Forms.BindingSource administrativeBoundariesBindingSource;
        private NPIC_TESTDataSetTableAdapters.AdministrativeBoundariesTableAdapter administrativeBoundariesTableAdapter;
        private System.Windows.Forms.BindingSource fKAdministrativeBoundariesAdministrativeBoundariesBindingSource;
        private System.Windows.Forms.BindingSource administrativeBoundariesBindingSource1;
        private System.Windows.Forms.BindingSource administrativeBoundariesBindingSource3;
        private System.Windows.Forms.BindingSource administrativeBoundariesBindingSource2;
    }
}