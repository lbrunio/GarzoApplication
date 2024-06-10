namespace GarzoApplication.Views {
    partial class DatePickerPopUp {
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
            initialTime = new DateTimePicker();
            initalDateLabel = new Label();
            btnOk = new Button();
            btnCancel = new Button();
            finishDateLabel = new Label();
            finishTime = new DateTimePicker();
            SuspendLayout();
            // 
            // initialTime
            // 
            initialTime.Location = new Point(12, 55);
            initialTime.Name = "initialTime";
            initialTime.Size = new Size(200, 23);
            initialTime.TabIndex = 0;
            // 
            // initalDateLabel
            // 
            initalDateLabel.AutoSize = true;
            initalDateLabel.Location = new Point(12, 37);
            initalDateLabel.Name = "initalDateLabel";
            initalDateLabel.Size = new Size(24, 15);
            initalDateLabel.TabIndex = 1;
            initalDateLabel.Text = "De:";
            // 
            // btnOk
            // 
            btnOk.Location = new Point(12, 193);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 2;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(137, 193);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "CANCELAR";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // finishDateLabel
            // 
            finishDateLabel.AutoSize = true;
            finishDateLabel.Location = new Point(12, 108);
            finishDateLabel.Name = "finishDateLabel";
            finishDateLabel.Size = new Size(16, 15);
            finishDateLabel.TabIndex = 4;
            finishDateLabel.Text = "a:";
            // 
            // finishTime
            // 
            finishTime.Location = new Point(12, 126);
            finishTime.Name = "finishTime";
            finishTime.Size = new Size(200, 23);
            finishTime.TabIndex = 5;
            // 
            // DatePickerPopUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(236, 257);
            Controls.Add(finishTime);
            Controls.Add(finishDateLabel);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(initalDateLabel);
            Controls.Add(initialTime);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "DatePickerPopUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker initialTime;
        private Label initalDateLabel;
        private Button btnOk;
        private Button btnCancel;
        private Label finishDateLabel;
        private DateTimePicker finishTime;
    }
}