using System.Windows.Forms;

namespace GarzoApplication.Views {
    partial class AppointmentForm {
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
            napBotPanel = new Panel();
            btnFilter = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            apVerticalMenu = new Panel();
            statusPanel = new Panel();
            btnFilterCanceled = new Button();
            panel7 = new Panel();
            btnFilterAll = new Button();
            panel6 = new Panel();
            btnFilterCompleted = new Button();
            panel4 = new Panel();
            btnPendingFilter = new Button();
            panel3 = new Panel();
            btnFilterStatus = new Button();
            panel2 = new Panel();
            btnFilterDate = new Button();
            panel5 = new Panel();
            appDvg = new DataGridView();
            appointmentPanel = new Panel();
            panel1 = new Panel();
            dgvPanel = new Panel();
            napBotPanel.SuspendLayout();
            apVerticalMenu.SuspendLayout();
            statusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)appDvg).BeginInit();
            appointmentPanel.SuspendLayout();
            panel1.SuspendLayout();
            dgvPanel.SuspendLayout();
            SuspendLayout();
            // 
            // napBotPanel
            // 
            napBotPanel.BackColor = Color.FromArgb(0, 125, 255);
            napBotPanel.Controls.Add(btnFilter);
            napBotPanel.Controls.Add(btnSearch);
            napBotPanel.Controls.Add(txtSearch);
            napBotPanel.Dock = DockStyle.Bottom;
            napBotPanel.Location = new Point(0, 492);
            napBotPanel.Name = "napBotPanel";
            napBotPanel.Size = new Size(940, 29);
            napBotPanel.TabIndex = 2;
            // 
            // btnFilter
            // 
            btnFilter.Anchor = AnchorStyles.Right;
            btnFilter.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnFilter.Location = new Point(848, 3);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(88, 23);
            btnFilter.TabIndex = 2;
            btnFilter.Text = "FILTER";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Right;
            btnSearch.Location = new Point(754, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(88, 22);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(3, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(745, 23);
            txtSearch.TabIndex = 0;
            // 
            // apVerticalMenu
            // 
            apVerticalMenu.BackColor = Color.FromArgb(0, 125, 255);
            apVerticalMenu.Controls.Add(statusPanel);
            apVerticalMenu.Controls.Add(btnFilterAll);
            apVerticalMenu.Controls.Add(btnFilterStatus);
            apVerticalMenu.Controls.Add(panel6);
            apVerticalMenu.Controls.Add(panel2);
            apVerticalMenu.Controls.Add(btnFilterDate);
            apVerticalMenu.Controls.Add(panel5);
            apVerticalMenu.Dock = DockStyle.Right;
            apVerticalMenu.Location = new Point(848, 0);
            apVerticalMenu.Name = "apVerticalMenu";
            apVerticalMenu.Size = new Size(92, 492);
            apVerticalMenu.TabIndex = 4;
            // 
            // statusPanel
            // 
            statusPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            statusPanel.Controls.Add(btnFilterCanceled);
            statusPanel.Controls.Add(panel7);
            statusPanel.Controls.Add(btnFilterCompleted);
            statusPanel.Controls.Add(panel4);
            statusPanel.Controls.Add(btnPendingFilter);
            statusPanel.Controls.Add(panel3);
            statusPanel.Location = new Point(23, 316);
            statusPanel.Name = "statusPanel";
            statusPanel.Size = new Size(69, 91);
            statusPanel.TabIndex = 10;
            // 
            // btnFilterCanceled
            // 
            btnFilterCanceled.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFilterCanceled.BackColor = Color.FromArgb(0, 123, 255);
            btnFilterCanceled.BackgroundImageLayout = ImageLayout.None;
            btnFilterCanceled.Cursor = Cursors.Hand;
            btnFilterCanceled.FlatAppearance.BorderSize = 0;
            btnFilterCanceled.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 31, 55);
            btnFilterCanceled.FlatStyle = FlatStyle.Flat;
            btnFilterCanceled.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFilterCanceled.ForeColor = Color.White;
            btnFilterCanceled.Location = new Point(0, 2);
            btnFilterCanceled.Name = "btnFilterCanceled";
            btnFilterCanceled.Size = new Size(60, 24);
            btnFilterCanceled.TabIndex = 17;
            btnFilterCanceled.Text = "Cancelados";
            btnFilterCanceled.UseVisualStyleBackColor = false;
            btnFilterCanceled.Click += btnFilterCanceled_Click;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel7.BackColor = Color.FromArgb(220, 53, 69);
            panel7.Location = new Point(47, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(22, 24);
            panel7.TabIndex = 16;
            // 
            // btnFilterAll
            // 
            btnFilterAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFilterAll.BackColor = Color.FromArgb(0, 123, 255);
            btnFilterAll.BackgroundImageLayout = ImageLayout.None;
            btnFilterAll.Cursor = Cursors.Hand;
            btnFilterAll.FlatAppearance.BorderSize = 0;
            btnFilterAll.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 31, 55);
            btnFilterAll.FlatStyle = FlatStyle.Flat;
            btnFilterAll.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFilterAll.ForeColor = Color.White;
            btnFilterAll.Location = new Point(0, 274);
            btnFilterAll.Name = "btnFilterAll";
            btnFilterAll.Size = new Size(83, 36);
            btnFilterAll.TabIndex = 15;
            btnFilterAll.Text = "All Citas";
            btnFilterAll.UseVisualStyleBackColor = false;
            btnFilterAll.Click += btnFilterAll_Click;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel6.BackColor = Color.FromArgb(25, 135, 84);
            panel6.Location = new Point(47, 274);
            panel6.Name = "panel6";
            panel6.Size = new Size(45, 36);
            panel6.TabIndex = 14;
            // 
            // btnFilterCompleted
            // 
            btnFilterCompleted.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFilterCompleted.BackColor = Color.FromArgb(0, 123, 255);
            btnFilterCompleted.BackgroundImageLayout = ImageLayout.None;
            btnFilterCompleted.Cursor = Cursors.Hand;
            btnFilterCompleted.FlatAppearance.BorderSize = 0;
            btnFilterCompleted.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 31, 55);
            btnFilterCompleted.FlatStyle = FlatStyle.Flat;
            btnFilterCompleted.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFilterCompleted.ForeColor = Color.White;
            btnFilterCompleted.Location = new Point(0, 32);
            btnFilterCompleted.Name = "btnFilterCompleted";
            btnFilterCompleted.Size = new Size(60, 24);
            btnFilterCompleted.TabIndex = 13;
            btnFilterCompleted.Text = "Completado";
            btnFilterCompleted.UseVisualStyleBackColor = false;
            btnFilterCompleted.Click += btnFilterCompleted_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel4.BackColor = Color.FromArgb(25, 135, 84);
            panel4.Location = new Point(47, 32);
            panel4.Name = "panel4";
            panel4.Size = new Size(22, 24);
            panel4.TabIndex = 12;
            // 
            // btnPendingFilter
            // 
            btnPendingFilter.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPendingFilter.BackColor = Color.FromArgb(0, 123, 255);
            btnPendingFilter.BackgroundImageLayout = ImageLayout.None;
            btnPendingFilter.Cursor = Cursors.Hand;
            btnPendingFilter.FlatAppearance.BorderSize = 0;
            btnPendingFilter.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 31, 55);
            btnPendingFilter.FlatStyle = FlatStyle.Flat;
            btnPendingFilter.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPendingFilter.ForeColor = Color.White;
            btnPendingFilter.Location = new Point(0, 62);
            btnPendingFilter.Name = "btnPendingFilter";
            btnPendingFilter.Size = new Size(60, 24);
            btnPendingFilter.TabIndex = 11;
            btnPendingFilter.Text = "Pendiente";
            btnPendingFilter.UseVisualStyleBackColor = false;
            btnPendingFilter.Click += btnPendingFilter_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(220, 53, 69);
            panel3.Location = new Point(47, 62);
            panel3.Name = "panel3";
            panel3.Size = new Size(22, 24);
            panel3.TabIndex = 10;
            // 
            // btnFilterStatus
            // 
            btnFilterStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFilterStatus.BackColor = Color.FromArgb(0, 123, 255);
            btnFilterStatus.BackgroundImageLayout = ImageLayout.None;
            btnFilterStatus.Cursor = Cursors.Hand;
            btnFilterStatus.FlatAppearance.BorderSize = 0;
            btnFilterStatus.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 31, 55);
            btnFilterStatus.FlatStyle = FlatStyle.Flat;
            btnFilterStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFilterStatus.ForeColor = Color.White;
            btnFilterStatus.Location = new Point(0, 408);
            btnFilterStatus.Name = "btnFilterStatus";
            btnFilterStatus.Size = new Size(83, 36);
            btnFilterStatus.TabIndex = 9;
            btnFilterStatus.Text = "ESTADO";
            btnFilterStatus.UseVisualStyleBackColor = false;
            btnFilterStatus.Click += btnFilterStatus_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(5, 31, 55);
            panel2.Location = new Point(79, 408);
            panel2.Name = "panel2";
            panel2.Size = new Size(13, 36);
            panel2.TabIndex = 8;
            // 
            // btnFilterDate
            // 
            btnFilterDate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFilterDate.BackColor = Color.FromArgb(0, 123, 255);
            btnFilterDate.BackgroundImageLayout = ImageLayout.None;
            btnFilterDate.Cursor = Cursors.Hand;
            btnFilterDate.FlatAppearance.BorderSize = 0;
            btnFilterDate.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 31, 55);
            btnFilterDate.FlatStyle = FlatStyle.Flat;
            btnFilterDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFilterDate.ForeColor = Color.White;
            btnFilterDate.Location = new Point(0, 450);
            btnFilterDate.Name = "btnFilterDate";
            btnFilterDate.Size = new Size(83, 36);
            btnFilterDate.TabIndex = 7;
            btnFilterDate.Text = "FECHA";
            btnFilterDate.UseVisualStyleBackColor = false;
            btnFilterDate.Click += btnFilterDate_Click;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel5.BackColor = Color.FromArgb(5, 31, 55);
            panel5.Location = new Point(79, 450);
            panel5.Name = "panel5";
            panel5.Size = new Size(13, 36);
            panel5.TabIndex = 6;
            // 
            // appDvg
            // 
            appDvg.AllowUserToAddRows = false;
            appDvg.AllowUserToDeleteRows = false;
            appDvg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            appDvg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            appDvg.BackgroundColor = Color.White;
            appDvg.BorderStyle = BorderStyle.None;
            appDvg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            appDvg.Dock = DockStyle.Fill;
            appDvg.Location = new Point(0, 0);
            appDvg.Name = "appDvg";
            appDvg.ReadOnly = true;
            appDvg.Size = new Size(848, 492);
            appDvg.TabIndex = 0;
            appDvg.CellDoubleClick += appDvg_CellDoubleClick;
            // 
            // appointmentPanel
            // 
            appointmentPanel.Controls.Add(panel1);
            appointmentPanel.Controls.Add(napBotPanel);
            appointmentPanel.Dock = DockStyle.Fill;
            appointmentPanel.Location = new Point(0, 0);
            appointmentPanel.Name = "appointmentPanel";
            appointmentPanel.Size = new Size(940, 521);
            appointmentPanel.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvPanel);
            panel1.Controls.Add(apVerticalMenu);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(940, 492);
            panel1.TabIndex = 5;
            // 
            // dgvPanel
            // 
            dgvPanel.AutoScroll = true;
            dgvPanel.Controls.Add(appDvg);
            dgvPanel.Dock = DockStyle.Fill;
            dgvPanel.Location = new Point(0, 0);
            dgvPanel.Name = "dgvPanel";
            dgvPanel.Size = new Size(848, 492);
            dgvPanel.TabIndex = 5;
            // 
            // AppointmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 521);
            Controls.Add(appointmentPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AppointmentForm";
            Text = "AppointmentForm";
            napBotPanel.ResumeLayout(false);
            napBotPanel.PerformLayout();
            apVerticalMenu.ResumeLayout(false);
            statusPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)appDvg).EndInit();
            appointmentPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            dgvPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel napBotPanel;
        private Button btnFilter;
        private Button btnSearch;
        private TextBox txtSearch;
        private Panel apVerticalMenu;
        private DataGridView appDvg;
        private Panel appointmentPanel;
        private Panel panel1;
        private Button btnFilterStatus;
        private Panel panel2;
        private Button btnFilterDate;
        private Panel panel5;
        private Panel statusPanel;
        private Button btnFilterCompleted;
        private Panel panel4;
        private Button btnPendingFilter;
        private Panel panel3;
        private Button btnFilterAll;
        private Panel panel6;
        private Button btnFilterCanceled;
        private Panel panel7;
        private Panel dgvPanel;
    }
}