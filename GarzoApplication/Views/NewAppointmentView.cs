using GarzoApplication.Models;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

using Newtonsoft.Json;

namespace GarzoApplication.Views {
    public partial class NewAppointmentView : Form {

        private static readonly HttpClient client = new HttpClient();
        private static readonly string ApiURL = "https://localhost:7257/api/appointment";
        public NewAppointmentView() {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e) {
            clearTextBox();
        }

        private void pendingChkBox_CheckedChanged(object sender, EventArgs e) {
            if (pendingChkBox.Checked) {
                completedChkBox.Checked = false;
            }
        }

        private void completedChkBox_CheckedChanged(object sender, EventArgs e) {
            if (completedChkBox.Checked) {
                pendingChkBox.Checked = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            DateTime date = datePicker.Value;

            string state = string.Empty;

            state = completedChkBox.Checked ? completedChkBox.Text : pendingChkBox.Text;

            try {
                var appointment = new AppointmentModel {
                    Name = nameTxtBox.Text,
                    Last_name = lastNameTxtBox.Text,
                    Phone_number = phoneTxtBox.Text,
                    Email = emailTxtBox.Text,
                    Service_type = serviceTxtBox.Text,
                    State = state,
                    Appointment_date = datePicker.Value
                };

                CreateAppointment(appointment);
                clearTextBox();

            } catch (FormatException) {
               
            }
        }
        private void clearTextBox() {
            nameTxtBox.Text = string.Empty;
            lastNameTxtBox.Text = string.Empty;
            phoneTxtBox.Text = string.Empty;
            serviceTxtBox.Text = string.Empty;
            pendingChkBox.Checked = false;
            completedChkBox.Checked = false;
            emailTxtBox.Text = string.Empty;
            datePicker.Value = DateTime.Now;
        }

        private async void CreateAppointment(AppointmentModel appointment) {
            var json = JsonConvert.SerializeObject(appointment);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try {
                var response = await client.PostAsync(ApiURL, content);
                if (response.IsSuccessStatusCode) {
                    MessageBox.Show("Appointment created successfully!");
                } else {
                    MessageBox.Show("Error creating appointment");
                }
            } catch (Exception) {
                return;
            }
        }
    }
}
