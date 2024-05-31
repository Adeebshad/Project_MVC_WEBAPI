using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PatientInformation.Models;
using System.Text.Json;
using System.Text;

namespace PatientInformation.Controllers
{
    public class PatientController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly ApiClient _apiClient;
        public PatientController(ApiClient apiClient)
        {
            _httpClient = new HttpClient();
            _apiClient = apiClient;
            _httpClient.BaseAddress = new Uri("https://localhost:7220/api/Disease"); // Change to your API base address
        }


        // GET: PatientController
        public async Task<IActionResult> Index()
        {
            var model = new DiseaseModel();
            model.Diseases = new List<SelectListItem>();

            var apiUrl = "https://localhost:7220/api/Disease";
            var diseaseList = await _apiClient.GetAsync<List<DiseaseModel>>(apiUrl);
            foreach(var disease in diseaseList)
            {
                model.Diseases.Add(new SelectListItem { Text = disease.Name, Value = disease.Id.ToString()});
            }


            return View();
        }

        // POST: PatientController/Create
        [HttpPost]
        public async Task<ActionResult> Create(PatientViewModel model)
        {
            model.Allergies = new List<string>();
            var json = JsonSerializer.Serialize(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("https://localhost:7220/api/PatientInfo/AddPatientInfo", content);

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Patient added successfully.");
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode}");
            }
            return RedirectToAction("");
        }
    }
}
