using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatesController : ControllerBase
    {
        public static Root rates { get; set; }
        [HttpGet]
        public static async Task GetAllData()
        {
            using (var httpClient = new HttpClient())
            {
                HttpRequestMessage request = new HttpRequestMessage();
                request.RequestUri = new Uri("https://api.apilayer.com/exchangerates_data/latest");
                request.Headers.Add("apikey", "vbjeljWWPNFs5FGuVoXeefSI6jdplMS1");
                HttpResponseMessage response = await httpClient.SendAsync(request);
                string responseString = await response.Content.ReadAsStringAsync();
                rates = JsonConvert.DeserializeObject<Root>(responseString);
            }
        }
    }
}
