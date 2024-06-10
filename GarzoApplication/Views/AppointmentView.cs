
namespace GarzoApplication.Views {
    public partial class AppointmentView : Form {

        private static readonly HttpClient client = new HttpClient();
        private static readonly string ApiURL = "https://localhost:7257/api/appointment";


        public AppointmentView() {
            InitializeComponent();
            openForm(new HomeView());
        }

        private void Exit() {
            DialogResult option = MessageBox.Show("Esta seguro que quiere salir?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (option == DialogResult.Yes) {
                Login login = new Login();
                login.Show();
                this.Dispose();
            }
        }


        // Open panel in a panel 
        private void openForm(Form form) {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
            Form af = form as Form;
            af.TopLevel = false;
            af.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(af);
            this.mainPanel.Tag = af;
            af.Show();
        }



        private void btnAppointments_Click(object sender, EventArgs e) {
            openForm(new AppointmentForm());
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Exit();
        }

        private void logoImage_Click(object sender, EventArgs e) {
            openForm(new HomeView());
        }

        private void btnNew_Click(object sender, EventArgs e) {
            openForm(new NewAppointmentView());
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            openForm(new UpdateView());
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            openForm(new DeleteView());
        }
    }
}
