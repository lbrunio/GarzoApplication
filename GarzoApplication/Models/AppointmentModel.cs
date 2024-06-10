
namespace GarzoApplication.Models
{
    public class AppointmentModel
    {
        
        public int AppointmentId { get; set; }

  
        public string Name { get; set; }

        
        public string Last_name { get; set; }

       
        public string Phone_number { get; set; }

      
        public string? Email { get; set; }

      
        public string Service_type { get; set; }

      
        public string State { get; set; }

        public DateTime Appointment_date { get; set; }
    } 
}
