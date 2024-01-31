using CarProject.Dto.CarDtos;
using CarProject.Dto.TestimonialDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarProject.WebUI.ViewComponents.DefaultViewComponents
{
    public class _DefaultLast5CarWithBrandComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultLast5CarWithBrandComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7074/api/Cars/GetLast5CarWithBrandQueryHandler");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultLast5CarWithBrandDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
