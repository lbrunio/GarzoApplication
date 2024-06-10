using GarzoApplication.Models;
using Newtonsoft.Json;


namespace GarzoApplication.Views {
    public partial class DeleteView : Form {

        private static readonly HttpClient client = new HttpClient();
        private static readonly string ApiURL = "https://localhost:7257/api/appointment";

        public DeleteView() {
            InitializeComponent();
            CenterToScreen();
        }

        private void ClearTextBoxes() {
            idTxtBox.Text = string.Empty;
            nameTxtBox.Text = string.Empty;
            lastNameTxtBox.Text = string.Empty;
            phoneTxtBox.Text = string.Empty;
            emailTxtBox.Text = string.Empty;
            serviceTxtBox.Text = string.Empty;
            pendingChkBox.Checked = false;
            completedChkBox.Checked = false;
            canceledChkBox.Checked = false;
            datePicker.Value = DateTime.Now;
        }

        public async void DeleteAppointmentById(int id) {
            var response = await client.DeleteAsync($"{ApiURL}/{id}");
            if (response.IsSuccessStatusCode) {
                MessageBox.Show("Item deleted successfully!");
            } else {
                MessageBox.Show("Error deleting item");
            }
        }

        private async void SearchId() {
            try {
                int id = int.Parse(searchTxtBox.Text);
                AppointmentModel app = await GetAppointmentById(id);
                if (app != null) {
                    InsertDataToTxtBoxes(app);
                } else {
                    MessageBox.Show("No appointment found with the given ID.");
                }
            } catch (FormatException) {
                MessageBox.Show("Enter a valid ID");
                return;
            }
        }


        private async Task<AppointmentModel> GetAppointmentById(int id) {
            try {
                var response = await client.GetAsync($"{ApiURL}/{id}");
                if (response.IsSuccessStatusCode) {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    var appointments = JsonConvert.DeserializeObject<AppointmentModel>(jsonString);
                    return appointments;
                } else {
                    MessageBox.Show("Error retrieving appointments");
                }
            } catch (Exception) {

            }
            return new AppointmentModel();
        }

        private void InsertDataToTxtBoxes(AppointmentModel app) {
            try {
                idTxtBox.Text = app.AppointmentId.ToString();
                nameTxtBox.Text = app.Name;
                lastNameTxtBox.Text = app.Last_name;
                phoneTxtBox.Text = app.Phone_number.ToString();
                emailTxtBox.Text = app.Email;
                serviceTxtBox.Text = app.Service_type;
                switch (app.State) {
                    case "Pending":
                        pendingChkBox.Checked = true;
                        break;
                    case "Completed":
                        completedChkBox.Checked = true;
                        break;
                    case "Canceled":
                        canceledChkBox.Checked = true;
                        break;
                    default:
                        // Pending check box default
                        pendingChkBox.Checked = true;
                        break;
                }

                datePicker.Value = app.Appointment_date;
            } catch (NullReferenceException) {
                return;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            SearchId();
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e) {

            DialogResult option = MessageBox.Show("Permanently delete this appointment?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (option == DialogResult.Yes) {
                int id = int.Parse(searchTxtBox.Text);
                DeleteAppointmentById(id);
                ClearTextBoxes();
            }

        }
    }
}
