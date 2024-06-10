

namespace GarzoApplication.Views {
    public partial class DatePickerPopUp : Form {
        public DateTime initialDate { get; private set; }
        public DateTime finishDate { get; private set; }
        public DatePickerPopUp() {
            InitializeComponent();
            CenterToScreen();
            ControlBox = false;
        }

        private void btnOk_Click(object sender, EventArgs e) {
            initialDate = initialTime.Value;
            finishDate = finishTime.Value;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
