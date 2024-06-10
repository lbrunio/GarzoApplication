namespace GarzoApplication.Views {
    partial class NewAppointmentView {
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
            napPanl = new Panel();
            btnSave = new Button();
            panel1 = new Panel();
            btnClear = new Button();
            panel2 = new Panel();
            napPanel = new Panel();
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
            napPanl.SuspendLayout();
            napPanel.SuspendLayout();
            SuspendLayout();
            // 
            // napPanl
            // 
            napPanl.BackColor = Color.FromArgb(0, 125, 255);
            napPanl.Controls.Add(btnSave);
            napPanl.Controls.Add(panel1);
            napPanl.Controls.Add(btnClear);
            napPanl.Controls.Add(panel2);
            napPanl.Dock = DockStyle.Bottom;
            napPanl.Location = new Point(0, 400);
            napPanl.Name = "napPanl";
            napPanl.Size = new Size(800, 50);
            napPanl.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnSave.BackColor = Color.FromArgb(0, 123, 255);
            btnSave.BackgroundImageLayout = ImageLayout.None;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 31, 55);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(554, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(108, 26);
            btnSave.TabIndex = 7;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.FromArgb(25, 135, 84);
            panel1.Location = new Point(661, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 26);
            panel1.TabIndex = 6;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnClear.BackColor = Color.FromArgb(0, 123, 255);
            btnClear.BackgroundImageLayout = ImageLayout.None;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 31, 55);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(668, 12);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(107, 26);
            btnClear.TabIndex = 5;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = Color.FromArgb(220, 53, 69);
            panel2.Location = new Point(774, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 26);
            panel2.TabIndex = 4;
            // 
            // napPanel
            // 
            napPanel.Controls.Add(datePicker);
            napPanel.Controls.Add(completedChkBox);
            napPanel.Controls.Add(pendingChkBox);
            napPanel.Controls.Add(serviceTxtBox);
            napPanel.Controls.Add(emailTxtBox);
            napPanel.Controls.Add(phoneTxtBox);
            napPanel.Controls.Add(lastNameTxtBox);
            napPanel.Controls.Add(nameTxtBox);
            napPanel.Controls.Add(dateLabel);
            napPanel.Controls.Add(statusLabel);
            napPanel.Controls.Add(serviceLabel);
            napPanel.Controls.Add(emailLabel);
            napPanel.Controls.Add(phoneLabel);
            napPanel.Controls.Add(Last_name);
            napPanel.Controls.Add(nameLabel);
            napPanel.Dock = DockStyle.Fill;
            napPanel.Location = new Point(0, 0);
            napPanel.Name = "napPanel";
            napPanel.Size = new Size(800, 400);
            napPanel.TabIndex = 1;
            // 
            // datePicker
            // 
            datePicker.Cursor = Cursors.Hand;
            datePicker.CustomFormat = "MM-dd-yyyy HH:mm";
            datePicker.Format = DateTimePickerFormat.Custom;
            datePicker.Location = new Point(440, 344);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(210, 23);
            datePicker.TabIndex = 23;
            // 
            // completedChkBox
            // 
            completedChkBox.AutoSize = true;
            completedChkBox.Font = new Font("Lucida Fax", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            completedChkBox.Location = new Point(473, 288);
            completedChkBox.Name = "completedChkBox";
            completedChkBox.Size = new Size(97, 20);
            completedChkBox.TabIndex = 13;
            completedChkBox.Text = "Completed";
            completedChkBox.UseVisualStyleBackColor = true;
            completedChkBox.CheckedChanged += completedChkBox_CheckedChanged;
            // 
            // pendingChkBox
            // 
            pendingChkBox.AutoSize = true;
            pendingChkBox.Font = new Font("Lucida Fax", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pendingChkBox.Location = new Point(374, 288);
            pendingChkBox.Name = "pendingChkBox";
            pendingChkBox.Size = new Size(80, 20);
            pendingChkBox.TabIndex = 12;
            pendingChkBox.Text = "Pending";
            pendingChkBox.UseVisualStyleBackColor = true;
            pendingChkBox.CheckedChanged += pendingChkBox_CheckedChanged;
            // 
            // serviceTxtBox
            // 
            serviceTxtBox.Cursor = Cursors.IBeam;
            serviceTxtBox.Location = new Point(374, 54);
            serviceTxtBox.Name = "serviceTxtBox";
            serviceTxtBox.Size = new Size(377, 195);
            serviceTxtBox.TabIndex = 11;
            serviceTxtBox.Text = "";
            // 
            // emailTxtBox
            // 
            emailTxtBox.Location = new Point(111, 226);
            emailTxtBox.Name = "emailTxtBox";
            emailTxtBox.PlaceholderText = "Opcional";
            emailTxtBox.Size = new Size(165, 23);
            emailTxtBox.TabIndex = 10;
            // 
            // phoneTxtBox
            // 
            phoneTxtBox.Location = new Point(133, 157);
            phoneTxtBox.Name = "phoneTxtBox";
            phoneTxtBox.PlaceholderText = "*";
            phoneTxtBox.Size = new Size(165, 23);
            phoneTxtBox.TabIndex = 9;
            // 
            // lastNameTxtBox
            // 
            lastNameTxtBox.Location = new Point(133, 94);
            lastNameTxtBox.Name = "lastNameTxtBox";
            lastNameTxtBox.PlaceholderText = "*";
            lastNameTxtBox.Size = new Size(165, 23);
            lastNameTxtBox.TabIndex = 8;
            // 
            // nameTxtBox
            // 
            nameTxtBox.Cursor = Cursors.IBeam;
            nameTxtBox.Location = new Point(122, 33);
            nameTxtBox.Name = "nameTxtBox";
            nameTxtBox.PlaceholderText = "*";
            nameTxtBox.Size = new Size(165, 23);
            nameTxtBox.TabIndex = 7;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateLabel.Location = new Point(374, 344);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(60, 18);
            dateLabel.TabIndex = 6;
            dateLabel.Text = "Fecha:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusLabel.Location = new Point(374, 267);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(66, 18);
            statusLabel.TabIndex = 5;
            statusLabel.Text = "Estado:";
            // 
            // serviceLabel
            // 
            serviceLabel.AutoSize = true;
            serviceLabel.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            serviceLabel.Location = new Point(374, 33);
            serviceLabel.Name = "serviceLabel";
            serviceLabel.Size = new Size(77, 18);
            serviceLabel.TabIndex = 4;
            serviceLabel.Text = "Servicio:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailLabel.Location = new Point(42, 226);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(63, 18);
            emailLabel.TabIndex = 3;
            emailLabel.Text = "E-mail:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneLabel.Location = new Point(42, 157);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(85, 18);
            phoneLabel.TabIndex = 2;
            phoneLabel.Text = "Telefono:";
            // 
            // Last_name
            // 
            Last_name.AutoSize = true;
            Last_name.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Last_name.Location = new Point(39, 94);
            Last_name.Name = "Last_name";
            Last_name.Size = new Size(88, 18);
            Last_name.TabIndex = 1;
            Last_name.Text = "Apellidos:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(39, 38);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(77, 18);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Nombre:";
            // 
            // NewAppointmentView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(napPanel);
            Controls.Add(napPanl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NewAppointmentView";
            Text = "NewAppointmentView";
            napPanl.ResumeLayout(false);
            napPanel.ResumeLayout(false);
            napPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel napPanl;
        private Button btnClear;
        private Panel panel2;
        private Button btnSave;
        private Panel panel1;
        private Panel napPanel;
        private Label serviceLabel;
        private Label emailLabel;
        private Label phoneLabel;
        private Label Last_name;
        private Label nameLabel;
        private TextBox nameTxtBox;
        private Label dateLabel;
        private Label statusLabel;
        private TextBox emailTxtBox;
        private TextBox phoneTxtBox;
        private TextBox lastNameTxtBox;
        private CheckBox completedChkBox;
        private CheckBox pendingChkBox;
        private RichTextBox serviceTxtBox;
        private DateTimePicker datePicker;
    }
}