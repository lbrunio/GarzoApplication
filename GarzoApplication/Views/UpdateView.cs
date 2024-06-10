using GarzoApplication.Models;
using System.Text;
using Newtonsoft.Json;

namespace GarzoApplication.Views {
    public partial class UpdateView : Form {

        private static readonly HttpClient client = new HttpClient();
        private static readonly string ApiURL = "https://localhost:7257/api/appointment";
        public UpdateView() {
            InitializeComponent();
            CenterToScreen();
        }

        public UpdateView(int id) {
            InitializeComponent();
            CenterToScreen();
            SearchId(id);
        }
        private async Task Update() {
            try {
                // Get the values from the text boxes
                int id = int.Parse(idTxtBox.Text);
                string name = nameTxtBox.Text;
                string lastName = lastNameTxtBox.Text;
                string phone = phoneTxtBox.Text;
                string email = emailTxtBox.Text;
                string service = serviceTxtBox.Text;
                string state = string.Empty;
                DateTime date = datePicker.Value;

                if (completedChkBox.Checked) {
                    state = completedChkBox.Text;
                } else if (pendingChkBox.Checked) {
                    state = pendingChkBox.Text;
                } else {
                    state = canceledChkBox.Text;
                }
                // Create an appointment model with the inserted values
                var updatedAppointment = new AppointmentModel {
                    Name = name,
                    Last_name = lastName,
                    Phone_number = phone,
                    Email = email,
                    Service_type = service,
                    State = state,
                    Appointment_date = date
                };

                var json = JsonConvert.SerializeObject(updatedAppointment);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PutAsync($"{ApiURL}/{id}", content);
                if (response.IsSuccessStatusCode) {
                    MessageBox.Show("Appointment updated successfully!");
                    ClearTextBoxes();
                } else {
                    var errorResponse = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Error updating appointment");
                }


            } catch (FormatException) {

            }
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


        // Show data to text boxes
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
            } catch(NullReferenceException) {
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

        private async void SearchId(int id) {
            try {
                searchTxtBox.Text = id.ToString();
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


        private void btnSearch_Click(object sender, EventArgs e) {
            SearchId();
        }

        private void pendingChkBox_CheckedChanged(object sender, EventArgs e) {
            if (pendingChkBox.Checked) {
                completedChkBox.Checked = false;
                canceledChkBox.Checked = false;
            }
        }

        private void completedChkBox_CheckedChanged(object sender, EventArgs e) {
            if (completedChkBox.Checked) {
                pendingChkBox.Checked = false;
                canceledChkBox.Checked = false;
            }
        }

        private void canceledChkBox_CheckedChanged(object sender, EventArgs e) {
            if (canceledChkBox.Checked) {
                pendingChkBox.Checked = false;
                completedChkBox.Checked = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e) {
            ClearTextBoxes();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            Task task = Update();
        }
    }
}

