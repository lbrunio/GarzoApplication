namespace GarzoApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GetButton = new Button();
            dgvApp = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellidos = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Servicio = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvApp).BeginInit();
            SuspendLayout();
            // 
            // GetButton
            // 
            GetButton.Location = new Point(333, 404);
            GetButton.Name = "GetButton";
            GetButton.Size = new Size(92, 34);
            GetButton.TabIndex = 0;
            GetButton.Text = "Get";
            GetButton.UseVisualStyleBackColor = true;
            GetButton.Click += GetButton_Click;
            // 
            // dgvApp
            // 
            dgvApp.AllowUserToAddRows = false;
            dgvApp.AllowUserToDeleteRows = false;
            dgvApp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvApp.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Apellidos, Telefono, Email, Servicio, Estado, Fecha });
            dgvApp.Location = new Point(12, 12);
            dgvApp.Name = "dgvApp";
            dgvApp.ReadOnly = true;
            dgvApp.Size = new Size(743, 386);
            dgvApp.TabIndex = 1;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Apellidos
            // 
            Apellidos.HeaderText = "Apellidos";
            Apellidos.Name = "Apellidos";
            Apellidos.ReadOnly = true;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // Servicio
            // 
            Servicio.HeaderText = "Servicio";
            Servicio.Name = "Servicio";
            Servicio.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 450);
            Controls.Add(dgvApp);
            Controls.Add(GetButton);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvApp).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button GetButton;
        private DataGridView dgvApp;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellidos;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Servicio;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Fecha;
    }
}
