namespace GarzoApplication.Views {
    partial class AppointmentView {
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentView));
            verticalMenu = new Panel();
            btnExit = new Button();
            panel5 = new Panel();
            btnDelete = new Button();
            panel4 = new Panel();
            btnUpdate = new Button();
            panel3 = new Panel();
            btnNew = new Button();
            panel2 = new Panel();
            btnAppointments = new Button();
            panel1 = new Panel();
            logoImage = new PictureBox();
            barPanel = new Panel();
            titleLabel = new Label();
            mainPanel = new Panel();
            verticalMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoImage).BeginInit();
            barPanel.SuspendLayout();
            SuspendLayout();
            // 
            // verticalMenu
            // 
            verticalMenu.BackColor = Color.FromArgb(5, 31, 55);
            verticalMenu.Controls.Add(btnExit);
            verticalMenu.Controls.Add(panel5);
            verticalMenu.Controls.Add(btnDelete);
            verticalMenu.Controls.Add(panel4);
            verticalMenu.Controls.Add(btnUpdate);
            verticalMenu.Controls.Add(panel3);
            verticalMenu.Controls.Add(btnNew);
            verticalMenu.Controls.Add(panel2);
            verticalMenu.Controls.Add(btnAppointments);
            verticalMenu.Controls.Add(panel1);
            verticalMenu.Controls.Add(logoImage);
            verticalMenu.Dock = DockStyle.Right;
            verticalMenu.Location = new Point(1099, 0);
            verticalMenu.Name = "verticalMenu";
            verticalMenu.Size = new Size(185, 611);
            verticalMenu.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(5, 31, 55);
            btnExit.BackgroundImageLayout = ImageLayout.None;
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 123, 255);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(0, 377);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(176, 52);
            btnExit.TabIndex = 5;
            btnExit.Text = "SALIR";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(220, 53, 69);
            panel5.Location = new Point(175, 377);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 52);
            panel5.TabIndex = 4;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(5, 31, 55);
            btnDelete.BackgroundImageLayout = ImageLayout.None;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 123, 255);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(0, 282);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(176, 52);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "BORRAR CITA";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(220, 53, 69);
            panel4.Location = new Point(175, 282);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 52);
            panel4.TabIndex = 4;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(5, 31, 55);
            btnUpdate.BackgroundImageLayout = ImageLayout.None;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 123, 255);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(0, 224);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(176, 52);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "ACTUALIZAR CITA";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 193, 7);
            panel3.Location = new Point(175, 224);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 52);
            panel3.TabIndex = 4;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.FromArgb(5, 31, 55);
            btnNew.BackgroundImageLayout = ImageLayout.None;
            btnNew.Cursor = Cursors.Hand;
            btnNew.FlatAppearance.BorderSize = 0;
            btnNew.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 123, 255);
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.ForeColor = Color.White;
            btnNew.Location = new Point(0, 166);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(176, 52);
            btnNew.TabIndex = 3;
            btnNew.Text = "NUEVA CITA";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(25, 135, 84);
            panel2.Location = new Point(175, 166);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 52);
            panel2.TabIndex = 2;
            // 
            // btnAppointments
            // 
            btnAppointments.BackColor = Color.FromArgb(5, 31, 55);
            btnAppointments.BackgroundImageLayout = ImageLayout.None;
            btnAppointments.Cursor = Cursors.Hand;
            btnAppointments.FlatAppearance.BorderSize = 0;
            btnAppointments.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 123, 255);
            btnAppointments.FlatStyle = FlatStyle.Flat;
            btnAppointments.ForeColor = Color.White;
            btnAppointments.ImageAlign = ContentAlignment.MiddleLeft;
            btnAppointments.Location = new Point(0, 108);
            btnAppointments.Name = "btnAppointments";
            btnAppointments.Size = new Size(176, 52);
            btnAppointments.TabIndex = 1;
            btnAppointments.Text = "CITAS";
            btnAppointments.UseVisualStyleBackColor = false;
            btnAppointments.Click += btnAppointments_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 123, 255);
            panel1.Location = new Point(175, 108);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 52);
            panel1.TabIndex = 0;
            // 
            // logoImage
            // 
            logoImage.Image = (Image)resources.GetObject("logoImage.Image");
            logoImage.Location = new Point(38, 25);
            logoImage.Name = "logoImage";
            logoImage.Size = new Size(124, 51);
            logoImage.TabIndex = 0;
            logoImage.TabStop = false;
            logoImage.Click += logoImage_Click;
            // 
            // barPanel
            // 
            barPanel.BackColor = Color.FromArgb(0, 125, 255);
            barPanel.Controls.Add(titleLabel);
            barPanel.Dock = DockStyle.Top;
            barPanel.Location = new Point(0, 0);
            barPanel.Name = "barPanel";
            barPanel.Size = new Size(1099, 40);
            barPanel.TabIndex = 1;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(12, 9);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(96, 20);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "GarzoAuto";
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.White;
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 40);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1099, 571);
            mainPanel.TabIndex = 2;
            // 
            // AppointmentView2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 611);
            Controls.Add(mainPanel);
            Controls.Add(barPanel);
            Controls.Add(verticalMenu);
            Name = "AppointmentView2";
            Text = "AppointmentView2";
            verticalMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoImage).EndInit();
            barPanel.ResumeLayout(false);
            barPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel verticalMenu;
        private Panel barPanel;
        private PictureBox logoImage;
        private Panel mainPanel;
        private Label titleLabel;
        private Button btnAppointments;
        private Panel panel1;
        private Button btnNew;
        private Panel panel2;
        private Button btnExit;
        private Panel panel5;
        private Button btnDelete;
        private Panel panel4;
        private Button btnUpdate;
        private Panel panel3;
    }
}