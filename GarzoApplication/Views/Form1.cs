using GarzoApplication.Controllers;

namespace GarzoApplication
{
    public partial class Form1 : Form
    {
        private readonly AppointmentController _controller;
        public Form1()
        {
            InitializeComponent();
            _controller = new AppointmentController();
        }

        private async void GetAppointments()
        {
            var appointments = await _controller.GetAllAppointments();

            if (appointments != null)
            {
                dgvApp.Rows.Clear();
                foreach (var appointment in appointments)
                {
                    var row = new DataGridViewRow();
                    row.CreateCells(dgvApp, appointment.AppointmentId, appointment.Name, appointment.Last_name, appointment.Phone_number, appointment.Email, appointment.Service_type, appointment.State, appointment.Appointment_date);
                    dgvApp.Rows.Add(row);
                }
            }
            else
            {
                MessageBox.Show("Error retrieving appointments.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void GetButton_Click(object sender, EventArgs e)
        {
            GetAppointments();
        }
    }
}
