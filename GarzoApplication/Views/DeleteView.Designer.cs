namespace GarzoApplication.Views
{
    partial class DeleteView
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
            deleteBotPanel = new Panel();
            btnDelete = new Button();
            btnSearch = new Button();
            searchTxtBox = new TextBox();
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
            deleteBotPanel.SuspendLayout();
            SuspendLayout();
            // 
            // deleteBotPanel
            // 
            deleteBotPanel.BackColor = Color.FromArgb(0, 125, 255);
            deleteBotPanel.Controls.Add(btnDelete);
            deleteBotPanel.Controls.Add(btnSearch);
            deleteBotPanel.Controls.Add(searchTxtBox);
            deleteBotPanel.Dock = DockStyle.Bottom;
            deleteBotPanel.Location = new Point(0, 420);
            deleteBotPanel.Name = "deleteBotPanel";
            deleteBotPanel.Size = new Size(800, 30);
            deleteBotPanel.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Right;
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(722, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Right;
            btnSearch.Location = new Point(641, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // searchTxtBox
            // 
            searchTxtBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            searchTxtBox.Location = new Point(3, 4);
            searchTxtBox.Name = "searchTxtBox";
            searchTxtBox.Size = new Size(632, 23);
            searchTxtBox.TabIndex = 0;
            // 
            // idTxtBox
            // 
            idTxtBox.Cursor = Cursors.IBeam;
            idTxtBox.Enabled = false;
            idTxtBox.Location = new Point(95, 56);
            idTxtBox.Name = "idTxtBox";
            idTxtBox.Size = new Size(165, 23);
            idTxtBox.TabIndex = 59;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idLabel.Location = new Point(58, 61);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(30, 20);
            idLabel.TabIndex = 58;
            idLabel.Text = "ID:";
            // 
            // canceledChkBox
            // 
            canceledChkBox.AutoSize = true;
            canceledChkBox.Enabled = false;
            canceledChkBox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            canceledChkBox.Location = new Point(588, 316);
            canceledChkBox.Name = "canceledChkBox";
            canceledChkBox.Size = new Size(84, 20);
            canceledChkBox.TabIndex = 57;
            canceledChkBox.Text = "Canceled";
            canceledChkBox.UseVisualStyleBackColor = true;
            // 
            // datePicker
            // 
            datePicker.Cursor = Cursors.Hand;
            datePicker.CustomFormat = "MM-dd-yyyy HH:mm";
            datePicker.Enabled = false;
            datePicker.Format = DateTimePickerFormat.Custom;
            datePicker.Location = new Point(434, 372);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(210, 23);
            datePicker.TabIndex = 56;
            // 
            // completedChkBox
            // 
            completedChkBox.AutoSize = true;
            completedChkBox.Enabled = false;
            completedChkBox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            completedChkBox.Location = new Point(467, 316);
            completedChkBox.Name = "completedChkBox";
            completedChkBox.Size = new Size(92, 20);
            completedChkBox.TabIndex = 55;
            completedChkBox.Text = "Completed";
            completedChkBox.UseVisualStyleBackColor = true;
            // 
            // pendingChkBox
            // 
            pendingChkBox.AutoSize = true;
            pendingChkBox.Enabled = false;
            pendingChkBox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pendingChkBox.Location = new Point(368, 316);
            pendingChkBox.Name = "pendingChkBox";
            pendingChkBox.Size = new Size(76, 20);
            pendingChkBox.TabIndex = 54;
            pendingChkBox.Text = "Pending";
            pendingChkBox.UseVisualStyleBackColor = true;
            // 
            // serviceTxtBox
            // 
            serviceTxtBox.Cursor = Cursors.IBeam;
            serviceTxtBox.Enabled = false;
            serviceTxtBox.Location = new Point(368, 82);
            serviceTxtBox.Name = "serviceTxtBox";
            serviceTxtBox.Size = new Size(377, 195);
            serviceTxtBox.TabIndex = 53;
            serviceTxtBox.Text = "";
            // 
            // emailTxtBox
            // 
            emailTxtBox.Enabled = false;
            emailTxtBox.Location = new Point(127, 303);
            emailTxtBox.Name = "emailTxtBox";
            emailTxtBox.Size = new Size(165, 23);
            emailTxtBox.TabIndex = 52;
            // 
            // phoneTxtBox
            // 
            phoneTxtBox.Enabled = false;
            phoneTxtBox.Location = new Point(149, 234);
            phoneTxtBox.Name = "phoneTxtBox";
            phoneTxtBox.Size = new Size(165, 23);
            phoneTxtBox.TabIndex = 51;
            // 
            // lastNameTxtBox
            // 
            lastNameTxtBox.Enabled = false;
            lastNameTxtBox.Location = new Point(149, 171);
            lastNameTxtBox.Name = "lastNameTxtBox";
            lastNameTxtBox.Size = new Size(165, 23);
            lastNameTxtBox.TabIndex = 50;
            // 
            // nameTxtBox
            // 
            nameTxtBox.Cursor = Cursors.IBeam;
            nameTxtBox.Enabled = false;
            nameTxtBox.Location = new Point(138, 110);
            nameTxtBox.Name = "nameTxtBox";
            nameTxtBox.Size = new Size(165, 23);
            nameTxtBox.TabIndex = 49;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateLabel.Location = new Point(368, 372);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(58, 20);
            dateLabel.TabIndex = 48;
            dateLabel.Text = "Fecha:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusLabel.Location = new Point(368, 295);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(64, 20);
            statusLabel.TabIndex = 47;
            statusLabel.Text = "Estado:";
            // 
            // serviceLabel
            // 
            serviceLabel.AutoSize = true;
            serviceLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            serviceLabel.Location = new Point(368, 61);
            serviceLabel.Name = "serviceLabel";
            serviceLabel.Size = new Size(68, 20);
            serviceLabel.TabIndex = 46;
            serviceLabel.Text = "Servicio:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailLabel.Location = new Point(58, 303);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(57, 20);
            emailLabel.TabIndex = 45;
            emailLabel.Text = "E-mail:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneLabel.Location = new Point(58, 234);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(75, 20);
            phoneLabel.TabIndex = 44;
            phoneLabel.Text = "Telefono:";
            // 
            // Last_name
            // 
            Last_name.AutoSize = true;
            Last_name.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Last_name.Location = new Point(55, 171);
            Last_name.Name = "Last_name";
            Last_name.Size = new Size(77, 20);
            Last_name.TabIndex = 43;
            Last_name.Text = "Apellidos:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(55, 115);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(69, 20);
            nameLabel.TabIndex = 42;
            nameLabel.Text = "Nombre:";
            // 
            // DeleteView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(idTxtBox);
            Controls.Add(idLabel);
            Controls.Add(canceledChkBox);
            Controls.Add(datePicker);
            Controls.Add(completedChkBox);
            Controls.Add(pendingChkBox);
            Controls.Add(serviceTxtBox);
            Controls.Add(emailTxtBox);
            Controls.Add(phoneTxtBox);
            Controls.Add(lastNameTxtBox);
            Controls.Add(nameTxtBox);
            Controls.Add(dateLabel);
            Controls.Add(statusLabel);
            Controls.Add(serviceLabel);
            Controls.Add(emailLabel);
            Controls.Add(phoneLabel);
            Controls.Add(Last_name);
            Controls.Add(nameLabel);
            Controls.Add(deleteBotPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DeleteView";
            Text = "DeleteView";
            deleteBotPanel.ResumeLayout(false);
            deleteBotPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel deleteBotPanel;
        private Button btnSearch;
        private TextBox searchTxtBox;
        private TextBox idTxtBox;
        private Label idLabel;
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
        private Button btnDelete;
    }
}