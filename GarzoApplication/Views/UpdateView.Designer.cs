namespace GarzoApplication.Views {
    partial class UpdateView {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            updateBotPanel = new Panel();
            btnSearch = new Button();
            searchTxtBox = new TextBox();
            updateVerticalPanel = new Panel();
            btnClear = new Button();
            panel2 = new Panel();
            btnSave = new Button();
            panel1 = new Panel();
            updateCentralPanel = new Panel();
            idTxtBox = new TextBox();
            idLabel = new Label();
            canceledChkBox = new CheckBox();
            datePicker = new DateTimePicker();
            completedChkBox = new CheckBox();
            pendingChkBox = new CheckBox();
            serviceTxtBox = new RichTextBox();
            emailTxtBox = new TextBox();
            phoneTxtBox = new TextBox();
            lastNameTxtBox = new TextBox();
            nameTxtBox = new TextBox();
            dateLabel = new Label();
            statusLabel = new Label();
            serviceLabel = new Label();
            emailLabel = new Label();
            phoneLabel = new Label();
            Last_name = new Label();
            nameLabel = new Label();
            updateBotPanel.SuspendLayout();
            updateVerticalPanel.SuspendLayout();
            updateCentralPanel.SuspendLayout();
            SuspendLayout();
            // 
            // updateBotPanel
            // 
            updateBotPanel.BackColor = Color.FromArgb(0, 125, 255);
            updateBotPanel.Controls.Add(btnSearch);
            updateBotPanel.Controls.Add(searchTxtBox);
            updateBotPanel.Dock = DockStyle.Bottom;
            updateBotPanel.Location = new Point(0, 421);
            updateBotPanel.Name = "updateBotPanel";
            updateBotPanel.Size = new Size(839, 29);
            updateBotPanel.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Location = new Point(731, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(105, 23);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // searchTxtBox
            // 
            searchTxtBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            searchTxtBox.Location = new Point(3, 3);
            searchTxtBox.Name = "searchTxtBox";
            searchTxtBox.Size = new Size(724, 23);
            searchTxtBox.TabIndex = 0;
            // 
            // updateVerticalPanel
            // 
            updateVerticalPanel.BackColor = Color.FromArgb(0, 125, 255);
            updateVerticalPanel.Controls.Add(btnClear);
            updateVerticalPanel.Controls.Add(panel2);
            updateVerticalPanel.Controls.Add(btnSave);
            updateVerticalPanel.Controls.Add(panel1);
            updateVerticalPanel.Dock = DockStyle.Right;
            updateVerticalPanel.Location = new Point(731, 0);
            updateVerticalPanel.Name = "updateVerticalPanel";
            updateVerticalPanel.Size = new Size(108, 421);
            updateVerticalPanel.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Right;
            btnClear.BackColor = Color.FromArgb(0, 123, 255);
            btnClear.BackgroundImageLayout = ImageLayout.None;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 31, 55);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(0, 96);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(99, 35);
            btnClear.TabIndex = 11;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(220, 53, 69);
            panel2.Location = new Point(95, 96);
            panel2.Name = "panel2";
            panel2.Size = new Size(13, 35);
            panel2.TabIndex = 10;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(0, 123, 255);
            btnSave.BackgroundImageLayout = ImageLayout.None;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 31, 55);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(2, 47);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(97, 35);
            btnSave.TabIndex = 9;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(25, 135, 84);
            panel1.Location = new Point(98, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 35);
            panel1.TabIndex = 8;
            // 
            // updateCentralPanel
            // 
            updateCentralPanel.Controls.Add(idTxtBox);
            updateCentralPanel.Controls.Add(idLabel);
            updateCentralPanel.Controls.Add(canceledChkBox);
            updateCentralPanel.Controls.Add(datePicker);
            updateCentralPanel.Controls.Add(completedChkBox);
            updateCentralPanel.Controls.Add(pendingChkBox);
            updateCentralPanel.Controls.Add(serviceTxtBox);
            updateCentralPanel.Controls.Add(emailTxtBox);
            updateCentralPanel.Controls.Add(phoneTxtBox);
            updateCentralPanel.Controls.Add(lastNameTxtBox);
            updateCentralPanel.Controls.Add(nameTxtBox);
            updateCentralPanel.Controls.Add(dateLabel);
            updateCentralPanel.Controls.Add(statusLabel);
            updateCentralPanel.Controls.Add(serviceLabel);
            updateCentralPanel.Controls.Add(emailLabel);
            updateCentralPanel.Controls.Add(phoneLabel);
            updateCentralPanel.Controls.Add(Last_name);
            updateCentralPanel.Controls.Add(nameLabel);
            updateCentralPanel.Dock = DockStyle.Fill;
            updateCentralPanel.Location = new Point(0, 0);
            updateCentralPanel.Name = "updateCentralPanel";
            updateCentralPanel.Size = new Size(731, 421);
            updateCentralPanel.TabIndex = 2;
            // 
            // idTxtBox
            // 
            idTxtBox.Cursor = Cursors.IBeam;
            idTxtBox.Enabled = false;
            idTxtBox.Location = new Point(52, 37);
            idTxtBox.Name = "idTxtBox";
            idTxtBox.Size = new Size(165, 23);
            idTxtBox.TabIndex = 41;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idLabel.Location = new Point(15, 42);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(31, 18);
            idLabel.TabIndex = 40;
            idLabel.Text = "ID:";
            // 
            // canceledChkBox
            // 
            canceledChkBox.AutoSize = true;
            canceledChkBox.Font = new Font("Lucida Fax", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            canceledChkBox.Location = new Point(545, 297);
            canceledChkBox.Name = "canceledChkBox";
            canceledChkBox.Size = new Size(85, 20);
            canceledChkBox.TabIndex = 39;
            canceledChkBox.Text = "Canceled";
            canceledChkBox.UseVisualStyleBackColor = true;
            canceledChkBox.CheckedChanged += canceledChkBox_CheckedChanged;
            // 
            // datePicker
            // 
            datePicker.Cursor = Cursors.Hand;
            datePicker.CustomFormat = "MM-dd-yyyy HH:mm";
            datePicker.Format = DateTimePickerFormat.Custom;
            datePicker.Location = new Point(391, 353);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(210, 23);
            datePicker.TabIndex = 38;
            // 
            // completedChkBox
            // 
            completedChkBox.AutoSize = true;
            completedChkBox.Font = new Font("Lucida Fax", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            completedChkBox.Location = new Point(424, 297);
            completedChkBox.Name = "completedChkBox";
            completedChkBox.Size = new Size(97, 20);
            completedChkBox.TabIndex = 37;
            completedChkBox.Text = "Completed";
            completedChkBox.UseVisualStyleBackColor = true;
            completedChkBox.CheckedChanged += completedChkBox_CheckedChanged;
            // 
            // pendingChkBox
            // 
            pendingChkBox.AutoSize = true;
            pendingChkBox.Font = new Font("Lucida Fax", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pendingChkBox.Location = new Point(325, 297);
            pendingChkBox.Name = "pendingChkBox";
            pendingChkBox.Size = new Size(80, 20);
            pendingChkBox.TabIndex = 36;
            pendingChkBox.Text = "Pending";
            pendingChkBox.UseVisualStyleBackColor = true;
            pendingChkBox.CheckedChanged += pendingChkBox_CheckedChanged;
            // 
            // serviceTxtBox
            // 
            serviceTxtBox.Cursor = Cursors.IBeam;
            serviceTxtBox.Location = new Point(325, 63);
            serviceTxtBox.Name = "serviceTxtBox";
            serviceTxtBox.Size = new Size(377, 195);
            serviceTxtBox.TabIndex = 35;
            serviceTxtBox.Text = "";
            // 
            // emailTxtBox
            // 
            emailTxtBox.Location = new Point(84, 284);
            emailTxtBox.Name = "emailTxtBox";
            emailTxtBox.PlaceholderText = "Opcional";
            emailTxtBox.Size = new Size(165, 23);
            emailTxtBox.TabIndex = 34;
            // 
            // phoneTxtBox
            // 
            phoneTxtBox.Location = new Point(106, 215);
            phoneTxtBox.Name = "phoneTxtBox";
            phoneTxtBox.PlaceholderText = "*";
            phoneTxtBox.Size = new Size(165, 23);
            phoneTxtBox.TabIndex = 33;
            // 
            // lastNameTxtBox
            // 
            lastNameTxtBox.Location = new Point(106, 152);
            lastNameTxtBox.Name = "lastNameTxtBox";
            lastNameTxtBox.PlaceholderText = "*";
            lastNameTxtBox.Size = new Size(165, 23);
            lastNameTxtBox.TabIndex = 32;
            // 
            // nameTxtBox
            // 
            nameTxtBox.Cursor = Cursors.IBeam;
            nameTxtBox.Location = new Point(95, 91);
            nameTxtBox.Name = "nameTxtBox";
            nameTxtBox.PlaceholderText = "*";
            nameTxtBox.Size = new Size(165, 23);
            nameTxtBox.TabIndex = 31;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateLabel.Location = new Point(325, 353);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(60, 18);
            dateLabel.TabIndex = 30;
            dateLabel.Text = "Fecha:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusLabel.Location = new Point(325, 276);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(66, 18);
            statusLabel.TabIndex = 29;
            statusLabel.Text = "Estado:";
            // 
            // serviceLabel
            // 
            serviceLabel.AutoSize = true;
            serviceLabel.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            serviceLabel.Location = new Point(325, 42);
            serviceLabel.Name = "serviceLabel";
            serviceLabel.Size = new Size(77, 18);
            serviceLabel.TabIndex = 28;
            serviceLabel.Text = "Servicio:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailLabel.Location = new Point(15, 284);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(63, 18);
            emailLabel.TabIndex = 27;
            emailLabel.Text = "E-mail:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneLabel.Location = new Point(15, 215);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(85, 18);
            phoneLabel.TabIndex = 26;
            phoneLabel.Text = "Telefono:";
            // 
            // Last_name
            // 
            Last_name.AutoSize = true;
            Last_name.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Last_name.Location = new Point(12, 152);
            Last_name.Name = "Last_name";
            Last_name.Size = new Size(88, 18);
            Last_name.TabIndex = 25;
            Last_name.Text = "Apellidos:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(12, 96);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(77, 18);
            nameLabel.TabIndex = 24;
            nameLabel.Text = "Nombre:";
            // 
            // UpdateView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(839, 450);
            Controls.Add(updateCentralPanel);
            Controls.Add(updateVerticalPanel);
            Controls.Add(updateBotPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateView";
            Text = "UpdateView";
            updateBotPanel.ResumeLayout(false);
            updateBotPanel.PerformLayout();
            updateVerticalPanel.ResumeLayout(false);
            updateCentralPanel.ResumeLayout(false);
            updateCentralPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel updateBotPanel;
        private Button btnSearch;
        private TextBox searchTxtBox;
        private Panel updateVerticalPanel;
        private Panel updateCentralPanel;
        private CheckBox canceledChkBox;
        private DateTimePicker datePicker;
        private CheckBox completedChkBox;
        private CheckBox pendingChkBox;
        private RichTextBox serviceTxtBox;
        private TextBox emailTxtBox;
        private TextBox phoneTxtBox;
        private TextBox lastNameTxtBox;
        private TextBox nameTxtBox;
        private Label dateLabel;
        private Label statusLabel;
        private Label serviceLabel;
        private Label emailLabel;
        private Label phoneLabel;
        private Label Last_name;
        private Label nameLabel;
        private Button btnSave;
        private Panel panel1;
        private Button btnClear;
        private Panel panel2;
        private TextBox idTxtBox;
        private Label idLabel;
    }
}