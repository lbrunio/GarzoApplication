using GarzoApplication.Models;
using System.Data;
using Newtonsoft.Json;

namespace GarzoApplication.Views {
    public partial class AppointmentForm : Form {

        private static readonly HttpClient client = new HttpClient();
        private static readonly string ApiURL = "https://localhost:7257/api/appointment";

        public AppointmentForm() {
            InitializeComponent();
            allPendingAppointments(); // Show all pending appointments by default
            hideVerticalMenu();
        }


        // Open a form insdie a panel
        private void openForm(Form form) {
            if (this.dgvPanel.Controls.Count > 0)
                this.dgvPanel.Controls.RemoveAt(0);
            Form af = form as Form;
            af.TopLevel = false;
            af.Dock = DockStyle.Fill;
            this.dgvPanel.Controls.Add(af);
            this.dgvPanel.Tag = af;
            af.Show();
        }


        // Double click event
        private void appDvg_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                // Custom MessageBox to change the yes/no button text
                DialogResult result = CustomMessageBox.Show("Seleccione Opcion", "Borrar", "Actualizar"); // CustomMessageBox(str message, str btnText, str btnText)

                // The value of Index 0 as the ID
                int id = int.Parse(appDvg.SelectedCells[0].Value.ToString());


                // Yes as the delete button
                if (result == DialogResult.Yes) {

                    DialogResult option = MessageBox.Show("Borrar permanentemente esta cita?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (option == DialogResult.Yes) {
                        DeleteView dv = new DeleteView();
                        dv.DeleteAppointmentById(id);
                    }

                    // No as the update button
                } else if (result == DialogResult.No) {
                    openForm(new UpdateView(id)); // Open the Update Form
                    napBotPanel.Visible = false;
                    apVerticalMenu.Visible = false;
                }
            }
        }

        private async Task<List<AppointmentModel>> GetAllApointments() {
            try {
                var response = await client.GetAsync(ApiURL);
                if (response.IsSuccessStatusCode) {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    var appointments = JsonConvert.DeserializeObject<List<AppointmentModel>>(jsonString);
                    return appointments;
                }
            } catch (Exception) {
                MessageBox.Show("Error to retrieve the appointments");
            }
            return new List<AppointmentModel>();
        }


        private void showSubMenu(Panel menu) {
            if (menu.Visible == false) {
                hideVerticalMenu();
                menu.Visible = true;
            } else {
                menu.Visible = false;
            }
        }

        private void hideVerticalMenu() {
            apVerticalMenu.Visible = false;
            statusPanel.Visible = false;
        }

        private async void GetAppointmentById(int id) {
            try {
                var response = await client.GetAsync($"{ApiURL}/{id}");
                if (response.IsSuccessStatusCode) {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    jsonString = "[" + jsonString + "]";
                    var appointments = JsonConvert.DeserializeObject<List<AppointmentModel>>(jsonString);
                    appDvg.DataSource = appointments;
                } else {
                    MessageBox.Show("Error retrieving appointments");
                }
            } catch (Exception) {
                return;
            }
        }

        private async void allCanceledAppointments() {
            try {
                List<AppointmentModel> allAppointments = await GetAllApointments();


                List<AppointmentModel> filteredAppointments = allAppointments.Where(e => e.State == "Canceled").ToList();

                appDvg.DataSource = filteredAppointments;
            } catch (Exception) {

            }
        }

        private async void allCompletedAppointments() {
            try {
                List<AppointmentModel> allAppointments = await GetAllApointments();


                List<AppointmentModel> filteredAppointments = allAppointments.Where(e => e.State == "Completed").ToList();

                appDvg.DataSource = filteredAppointments;
            } catch (Exception) {
                MessageBox.Show("Error retrieving completed appointments");
            }
        }




        private async void allPendingAppointments() {
            try {
                List<AppointmentModel> allAppointments = await GetAllApointments();

                List<AppointmentModel> filteredAppointments = allAppointments.Where(e => e.State == "Pending").ToList();

                appDvg.DataSource = filteredAppointments;
            } catch (Exception) {
                MessageBox.Show("Error retrieving pending appointments");
            }
        }


        // Filter appointments by name or last name or both
        private async Task<List<AppointmentModel>> filterAppointment(string filter, bool search) {

            try {
                List<AppointmentModel> appointments = await GetAllApointments();

                // Filter the list based on the search
                List<AppointmentModel> filteredAppointments = appointments.Where(e => {
                    // If the search have a blank space
                    string combinedName = e.Name + " " + e.Last_name;
                    if (search) {
                        return combinedName.ToLower().Contains(filter.ToLower()); // search for both name and last name
                    } else {
                        return (e.Name.ToLower().Contains(filter.ToLower()) ||
                                e.Last_name.ToLower().Contains(filter.ToLower())); // only search for name or last name
                    }

                }).ToList();

                return filteredAppointments;
            } catch (Exception) {
                MessageBox.Show("Error retrieving appointment");
            }
            return null;
        }

        private async void btnSearch_Click(object sender, EventArgs e) {

            if (txtSearch.Text == string.Empty) {
                allPendingAppointments();

                // Check if it's a number
            } else if (int.TryParse(txtSearch.Text, out int number)) {
                int id = int.Parse(txtSearch.Text);
                GetAppointmentById(id);


            }
              // Search by name or last name or both
              else {
                string searchTerm = txtSearch.Text.Trim();

                // Check if the search contains a space 
                bool search = searchTerm.Contains(" ");

                List<AppointmentModel> filteredAppointments = await filterAppointment(searchTerm, search);
                appDvg.DataSource = filteredAppointments;
            }
        }

        private void btnFilter_Click(object sender, EventArgs e) {
            showSubMenu(apVerticalMenu);
        }

        private void btnFilterStatus_Click(object sender, EventArgs e) {
            if (statusPanel.Visible == true) {
                statusPanel.Visible = false;
            } else { statusPanel.Visible = true; }
        }

        private void btnFilterCompleted_Click(object sender, EventArgs e) {
            allCompletedAppointments();
        }

        private void btnPendingFilter_Click(object sender, EventArgs e) {
            allPendingAppointments();
        }

        private async void btnFilterDate_Click(object sender, EventArgs e) {
            DatePickerPopUp datePickerForm = new DatePickerPopUp();

            if (datePickerForm.ShowDialog() == DialogResult.OK) {
                DateTime initialDate = datePickerForm.initialDate;
                DateTime finishDate = datePickerForm.finishDate;

                List<AppointmentModel> appointments = await GetAllApointments();
                List<AppointmentModel> filteredAppointments = appointments.Where(a => a.Appointment_date >= initialDate && a.Appointment_date <= finishDate).ToList();
                appDvg.DataSource = filteredAppointments;
            }

        }

        private async void btnFilterAll_Click(object sender, EventArgs e) {
            List<AppointmentModel> appointments = await GetAllApointments();
            appDvg.DataSource = appointments;
        }

        private void btnFilterCanceled_Click(object sender, EventArgs e) {
            allCanceledAppointments();
        }
    }
}
