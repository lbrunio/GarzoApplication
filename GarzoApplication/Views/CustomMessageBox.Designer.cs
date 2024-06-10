namespace GarzoApplication.Views {
    partial class CustomMessageBox {
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
            messageLabel = new Label();
            btn1 = new Button();
            btn2 = new Button();
            SuspendLayout();
            // 
            // messageLabel
            // 
            messageLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            messageLabel.AutoSize = true;
            messageLabel.Location = new Point(114, 53);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(31, 15);
            messageLabel.TabIndex = 0;
            messageLabel.Text = "aaaa";
            messageLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn1
            // 
            btn1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn1.Location = new Point(12, 104);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 23);
            btn1.TabIndex = 1;
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn2.Location = new Point(190, 104);
            btn2.Name = "btn2";
            btn2.Size = new Size(75, 23);
            btn2.TabIndex = 2;
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // CustomMessageBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 139);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(messageLabel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "CustomMessageBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label messageLabel;
        private Button btn1;
        private Button btn2;
    }
}