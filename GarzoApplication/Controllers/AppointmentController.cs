using GarzoApplication.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace GarzoApplication.Controllers
{
    public class AppointmentController
    {
        private readonly HttpClient _client;

        public AppointmentController()
        {
            _client = new HttpClient();
        }

        public async Task<List<AppointmentModel>> GetAllAppointments()
        {
            try
            {
                HttpResponseMessage response = await _client.GetAsync("https://localhost:7257/api/appointment");
                response.EnsureSuccessStatusCode();

                string responseJson = await response.Content.ReadAsStringAsync();
                var appointments = JsonConvert.DeserializeObject<List<AppointmentModel>>(responseJson);
                return appointments;
            }
            catch (HttpRequestException httpEx)
            {
                // Log the exception or handle it as necessary
                Console.WriteLine($"HTTP error: {httpEx.Message}");
                return null;
            }
            catch (JsonException jsonEx)
            {
                // Log the exception or handle it as necessary
                Console.WriteLine($"JSON error: {jsonEx.Message}");
                return null;
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return null;
            }
        }
    }
}
