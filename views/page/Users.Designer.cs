namespace NPIC_TEST.views.page
{
    partial class Users
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
            System.Windows.Forms.Label pictureLabel;
            System.Windows.Forms.Label disableLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label nicknameLabel;
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_add = new System.Windows.Forms.ToolStripButton();
            this.btn_save = new System.Windows.Forms.ToolStripButton();
            this.btn_delete = new System.Windows.Forms.ToolStripButton();
            this.btn_search = new System.Windows.Forms.ToolStripButton();
            this.txt_search = new System.Windows.Forms.ToolStripTextBox();
            this.nPIC_TESTDataSet = new NPIC_TEST.NPIC_TESTDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new NPIC_TEST.NPIC_TESTDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new NPIC_TEST.NPIC_TESTDataSetTableAdapters.TableAdapterManager();
            this.disableCheckBox = new System.Windows.Forms.CheckBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.nicknameTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.picturePictureBox = new System.Windows.Forms.PictureBox();
            idLabel = new System.Windows.Forms.Label();
            pictureLabel = new System.Windows.Forms.Label();
            disableLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            nicknameLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nPIC_TESTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(67, 108);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(21, 16);
            idLabel.TabIndex = 2;
            idLabel.Text = "id:";
            // 
            // pictureLabel
            // 
            pictureLabel.AutoSize = true;
            pictureLabel.Location = new System.Drawing.Point(736, 278);
            pictureLabel.Name = "pictureLabel";
            pictureLabel.Size = new System.Drawing.Size(50, 16);
            pictureLabel.TabIndex = 16;
            pictureLabel.Text = "picture:";
            // 
            // disableLabel
            // 
            disableLabel.AutoSize = true;
            disableLabel.Location = new System.Drawing.Point(67, 278);
            disableLabel.Name = "disableLabel";
            disableLabel.Size = new System.Drawing.Size(55, 16);
            disableLabel.TabIndex = 14;
            disableLabel.Text = "disable:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(67, 248);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(48, 16);
            phoneLabel.TabIndex = 12;
            phoneLabel.Text = "phone:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(67, 220);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(43, 16);
            emailLabel.TabIndex = 10;
            emailLabel.Text = "email:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(67, 192);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(69, 16);
            passwordLabel.TabIndex = 8;
            passwordLabel.Text = "password:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(67, 164);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(70, 16);
            usernameLabel.TabIndex = 6;
            usernameLabel.Text = "username:";
            // 
            // nicknameLabel
            // 
            nicknameLabel.AutoSize = true;
            nicknameLabel.Location = new System.Drawing.Point(67, 136);
            nicknameLabel.Name = "nicknameLabel";
            nicknameLabel.Size = new System.Drawing.Size(68, 16);
            nicknameLabel.TabIndex = 4;
            nicknameLabel.Text = "nickname:";
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
            this.toolStrip1.Size = new System.Drawing.Size(863, 38);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_add
            // 
            this.btn_add.Image = global::NPIC_TEST.Properties.Resources.add;
            this.btn_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(105, 35);
            this.btn_add.Text = "Add New";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_save
            // 
            this.btn_save.Image = global::NPIC_TEST.Properties.Resources.save;
            this.btn_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(76, 35);
            this.btn_save.Text = "Save";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click_1);
            // 
            // btn_delete
            // 
            this.btn_delete.Image = global::NPIC_TEST.Properties.Resources.bin;
            this.btn_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(86, 35);
            this.btn_delete.Text = "Delete";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_search
            // 
            this.btn_search.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(71, 35);
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
            this.txt_search.Size = new System.Drawing.Size(300, 35);
            // 
            // nPIC_TESTDataSet
            // 
            this.nPIC_TESTDataSet.DataSetName = "NPIC_TESTDataSet";
            this.nPIC_TESTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.nPIC_TESTDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdministrativeBoundariesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = NPIC_TEST.NPIC_TESTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            // 
            // disableCheckBox
            // 
            this.disableCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usersBindingSource, "disable", true));
            this.disableCheckBox.Location = new System.Drawing.Point(143, 273);
            this.disableCheckBox.Name = "disableCheckBox";
            this.disableCheckBox.Size = new System.Drawing.Size(104, 24);
            this.disableCheckBox.TabIndex = 15;
            this.disableCheckBox.Text = "checkBox1";
            this.disableCheckBox.UseVisualStyleBackColor = true;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(143, 245);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(200, 22);
            this.phoneTextBox.TabIndex = 13;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(143, 217);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 22);
            this.emailTextBox.TabIndex = 11;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(143, 189);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(200, 22);
            this.passwordTextBox.TabIndex = 9;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "username", true));
            this.usernameTextBox.Location = new System.Drawing.Point(143, 161);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(200, 22);
            this.usernameTextBox.TabIndex = 7;
            // 
            // nicknameTextBox
            // 
            this.nicknameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "nickname", true));
            this.nicknameTextBox.Location = new System.Drawing.Point(143, 133);
            this.nicknameTextBox.Name = "nicknameTextBox";
            this.nicknameTextBox.Size = new System.Drawing.Size(200, 22);
            this.nicknameTextBox.TabIndex = 5;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(143, 105);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(200, 22);
            this.idTextBox.TabIndex = 3;
            // 
            // picturePictureBox
            // 
            this.picturePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picturePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.usersBindingSource, "picture", true));
            this.picturePictureBox.Location = new System.Drawing.Point(672, 102);
            this.picturePictureBox.Name = "picturePictureBox";
            this.picturePictureBox.Size = new System.Drawing.Size(158, 162);
            this.picturePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePictureBox.TabIndex = 17;
            this.picturePictureBox.TabStop = false;
            this.picturePictureBox.Click += new System.EventHandler(this.picturePictureBox_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 352);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nicknameLabel);
            this.Controls.Add(this.nicknameTextBox);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(disableLabel);
            this.Controls.Add(this.disableCheckBox);
            this.Controls.Add(pictureLabel);
            this.Controls.Add(this.picturePictureBox);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nPIC_TESTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_delete;
        private System.Windows.Forms.ToolStripButton btn_add;
        private System.Windows.Forms.ToolStripButton btn_save;
        private System.Windows.Forms.ToolStripButton btn_search;
        private System.Windows.Forms.ToolStripTextBox txt_search;
        private NPIC_TESTDataSet nPIC_TESTDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private NPIC_TESTDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private NPIC_TESTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.CheckBox disableCheckBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox nicknameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.PictureBox picturePictureBox;
    }
}