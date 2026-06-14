namespace NPIC_TEST.views.page
{
    partial class Product
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label cate_idLabel;
            System.Windows.Forms.Label prod_nameLabel;
            System.Windows.Forms.Label prod_descriptionLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label imageLabel;
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_add = new System.Windows.Forms.ToolStripButton();
            this.btn_save = new System.Windows.Forms.ToolStripButton();
            this.btn_delete = new System.Windows.Forms.ToolStripButton();
            this.btn_search = new System.Windows.Forms.ToolStripButton();
            this.txt_search = new System.Windows.Forms.ToolStripTextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nPIC_TESTDataSet = new NPIC_TEST.NPIC_TESTDataSet();
            this.prod_nameTextBox = new System.Windows.Forms.TextBox();
            this.prod_descriptionTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.productTableAdapter = new NPIC_TEST.NPIC_TESTDataSetTableAdapters.productTableAdapter();
            this.tableAdapterManager = new NPIC_TEST.NPIC_TESTDataSetTableAdapters.TableAdapterManager();
            this.categoryTableAdapter = new NPIC_TEST.NPIC_TESTDataSetTableAdapters.categoryTableAdapter();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.fKproductcategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cateidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proddescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewImageColumn();
            idLabel = new System.Windows.Forms.Label();
            cate_idLabel = new System.Windows.Forms.Label();
            prod_nameLabel = new System.Windows.Forms.Label();
            prod_descriptionLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            imageLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPIC_TESTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKproductcategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Enabled = false;
            idLabel.Location = new System.Drawing.Point(62, 69);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 2;
            idLabel.Text = "id:";
            // 
            // cate_idLabel
            // 
            cate_idLabel.AutoSize = true;
            cate_idLabel.Location = new System.Drawing.Point(62, 95);
            cate_idLabel.Name = "cate_idLabel";
            cate_idLabel.Size = new System.Drawing.Size(42, 13);
            cate_idLabel.TabIndex = 4;
            cate_idLabel.Text = "cate id:";
            // 
            // prod_nameLabel
            // 
            prod_nameLabel.AutoSize = true;
            prod_nameLabel.Location = new System.Drawing.Point(62, 121);
            prod_nameLabel.Name = "prod_nameLabel";
            prod_nameLabel.Size = new System.Drawing.Size(60, 13);
            prod_nameLabel.TabIndex = 6;
            prod_nameLabel.Text = "prod name:";
            // 
            // prod_descriptionLabel
            // 
            prod_descriptionLabel.AutoSize = true;
            prod_descriptionLabel.Location = new System.Drawing.Point(62, 147);
            prod_descriptionLabel.Name = "prod_descriptionLabel";
            prod_descriptionLabel.Size = new System.Drawing.Size(85, 13);
            prod_descriptionLabel.TabIndex = 8;
            prod_descriptionLabel.Text = "prod description:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(62, 173);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(33, 13);
            priceLabel.TabIndex = 10;
            priceLabel.Text = "price:";
            // 
            // imageLabel
            // 
            imageLabel.AutoSize = true;
            imageLabel.Location = new System.Drawing.Point(469, 170);
            imageLabel.Name = "imageLabel";
            imageLabel.Size = new System.Drawing.Size(38, 13);
            imageLabel.TabIndex = 12;
            imageLabel.Text = "image:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.Font = new System.Drawing.Font("Khmer OS System", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_add,
            this.btn_save,
            this.btn_delete,
            this.btn_search,
            this.txt_search});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(662, 32);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_add
            // 
            this.btn_add.Image = global::NPIC_TEST.Properties.Resources.add;
            this.btn_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(93, 29);
            this.btn_add.Text = "Add New";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_save
            // 
            this.btn_save.Image = global::NPIC_TEST.Properties.Resources.save;
            this.btn_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(68, 29);
            this.btn_save.Text = "Save";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Image = global::NPIC_TEST.Properties.Resources.bin;
            this.btn_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(77, 29);
            this.btn_delete.Text = "Delete";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_search
            // 
            this.btn_search.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(61, 29);
            this.btn_search.Text = "Search";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txt_search.AutoSize = false;
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_search.Margin = new System.Windows.Forms.Padding(0, 1, 0, 2);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(226, 23);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "id", true));
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(153, 66);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 3;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.nPIC_TESTDataSet;
            // 
            // nPIC_TESTDataSet
            // 
            this.nPIC_TESTDataSet.DataSetName = "NPIC_TESTDataSet";
            this.nPIC_TESTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prod_nameTextBox
            // 
            this.prod_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "prod_name", true));
            this.prod_nameTextBox.Location = new System.Drawing.Point(153, 118);
            this.prod_nameTextBox.Name = "prod_nameTextBox";
            this.prod_nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.prod_nameTextBox.TabIndex = 7;
            // 
            // prod_descriptionTextBox
            // 
            this.prod_descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "prod_description", true));
            this.prod_descriptionTextBox.Location = new System.Drawing.Point(153, 144);
            this.prod_descriptionTextBox.Name = "prod_descriptionTextBox";
            this.prod_descriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.prod_descriptionTextBox.TabIndex = 9;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "price", true));
            this.priceTextBox.Location = new System.Drawing.Point(153, 170);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 11;
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.productBindingSource, "image", true));
            this.imagePictureBox.Location = new System.Drawing.Point(437, 66);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(100, 98);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePictureBox.TabIndex = 13;
            this.imagePictureBox.TabStop = false;
            this.imagePictureBox.Click += new System.EventHandler(this.imagePictureBox_Click);
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdministrativeBoundariesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoryTableAdapter = this.categoryTableAdapter;
            this.tableAdapterManager.productTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.UpdateOrder = NPIC_TEST.NPIC_TESTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "category";
            this.categoryBindingSource.DataSource = this.nPIC_TESTDataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "cate_id", true));
            this.comboBox1.DataSource = this.categoryBindingSource;
            this.comboBox1.DisplayMember = "cate_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(153, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.ValueMember = "id";
            // 
            // fKproductcategoryBindingSource
            // 
            this.fKproductcategoryBindingSource.DataMember = "FK_product_category";
            this.fKproductcategoryBindingSource.DataSource = this.categoryBindingSource;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.cateidDataGridViewTextBoxColumn,
            this.prodnameDataGridViewTextBoxColumn,
            this.proddescriptionDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.image});
            this.dataGridView1.DataSource = this.productBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 222);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(644, 246);
            this.dataGridView1.TabIndex = 15;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 40;
            // 
            // cateidDataGridViewTextBoxColumn
            // 
            this.cateidDataGridViewTextBoxColumn.DataPropertyName = "cate_id";
            this.cateidDataGridViewTextBoxColumn.HeaderText = "cate_id";
            this.cateidDataGridViewTextBoxColumn.Name = "cateidDataGridViewTextBoxColumn";
            this.cateidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodnameDataGridViewTextBoxColumn
            // 
            this.prodnameDataGridViewTextBoxColumn.DataPropertyName = "prod_name";
            this.prodnameDataGridViewTextBoxColumn.HeaderText = "prod_name";
            this.prodnameDataGridViewTextBoxColumn.Name = "prodnameDataGridViewTextBoxColumn";
            this.prodnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // proddescriptionDataGridViewTextBoxColumn
            // 
            this.proddescriptionDataGridViewTextBoxColumn.DataPropertyName = "prod_description";
            this.proddescriptionDataGridViewTextBoxColumn.HeaderText = "prod_description";
            this.proddescriptionDataGridViewTextBoxColumn.Name = "proddescriptionDataGridViewTextBoxColumn";
            this.proddescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // image
            // 
            this.image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.image.DataPropertyName = "image";
            this.image.HeaderText = "image";
            this.image.Name = "image";
            this.image.ReadOnly = true;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 498);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(cate_idLabel);
            this.Controls.Add(prod_nameLabel);
            this.Controls.Add(this.prod_nameTextBox);
            this.Controls.Add(prod_descriptionLabel);
            this.Controls.Add(this.prod_descriptionTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(imageLabel);
            this.Controls.Add(this.imagePictureBox);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Product";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPIC_TESTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKproductcategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_add;
        private System.Windows.Forms.ToolStripButton btn_save;
        private System.Windows.Forms.ToolStripButton btn_delete;
        private System.Windows.Forms.ToolStripButton btn_search;
        private System.Windows.Forms.ToolStripTextBox txt_search;
        private NPIC_TESTDataSet nPIC_TESTDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private NPIC_TESTDataSetTableAdapters.productTableAdapter productTableAdapter;
        private NPIC_TESTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox prod_nameTextBox;
        private System.Windows.Forms.TextBox prod_descriptionTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private NPIC_TESTDataSetTableAdapters.categoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource fKproductcategoryBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cateidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proddescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn image;
    }
}