using Newtonsoft.Json;
using Pro.APIConsume.Infrastructure.Common;
using Pro.APIConsume.Infrastructure.Interfaces;
using Pro.APIConsume.Models;

namespace Pro.APIConsume.Infrastructure.Services
{
    public class HSLParkAndRideService : IHSLParkAndRideService
    {
        public async Task<IEnumerable<string>> GetServices()
        {
            var services = new List<string>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://p.hsl.fi/api/v1/services"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ExceptionAnalyzer.CheckResponse(apiResponse);
                    services = JsonConvert.DeserializeObject<List<string>>(apiResponse);                  
                }
            }
            return services;
        }
        public async Task<IEnumerable<string>> GetPaymentMethods() 
        {
            var paymentMethods = new List<string>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://p.hsl.fi/api/v1/payment-methods"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ExceptionAnalyzer.CheckResponse(apiResponse);
                    paymentMethods = JsonConvert.DeserializeObject<List<string>>(apiResponse);
                }
            }
            return paymentMethods;
        }
        public async Task<IEnumerable<string>> GetPricingMethods()
        {
            var pricingMethods = new List<string>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://p.hsl.fi/api/v1/pricing-methods"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ExceptionAnalyzer.CheckResponse(apiResponse);
                    pricingMethods = JsonConvert.DeserializeObject<List<string>>(apiResponse);
                }
            }
            return pricingMethods;
        }
        public async Task<IEnumerable<string>> GetFacilityStatuses() 
        {
            var facilityStatuses = new List<string>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://p.hsl.fi/api/v1/facility-statuses"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ExceptionAnalyzer.CheckResponse(apiResponse);
                    facilityStatuses = JsonConvert.DeserializeObject<List<string>>(apiResponse);
                }
            }
            return facilityStatuses;
        }

        public async Task<Operator> GetOperators()
        {
            var operatorResponse = new Operator();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://p.hsl.fi/api/v1/operators?limit=10"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ExceptionAnalyzer.CheckResponse(apiResponse);
                    operatorResponse = JsonConvert.DeserializeObject<Operator>(apiResponse);
                }
            }
            return operatorResponse;
        }

        public Task<IEnumerable<Contact>> GetContacts()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Facility>> GetFacilities()
        {
            throw new NotImplementedException();
        }
    }
}
