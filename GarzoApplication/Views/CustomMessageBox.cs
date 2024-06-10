
namespace GarzoApplication.Views {
    public partial class CustomMessageBox : Form {
        public CustomMessageBox() {
            InitializeComponent();
            CenterToParent();
        }

        public CustomMessageBox(string message, string btn1Text, string btn2Text) {
            InitializeComponent();
            messageLabel.Text = message;
            btn1.Text = btn1Text;
            btn2.Text = btn2Text;
        }

        public static DialogResult Show(string message, string yesText, string noText) {
            using (var box = new CustomMessageBox(message, yesText, noText)) {
                return box.ShowDialog();
            }
        }

        private void btn1_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btn2_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }

}
