using Newtonsoft.Json;
using SuperShopMobile.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopMobile.Services
{
    public class ApiService : IApiService
    {
        public async Task<Response> GetListAsync<T>(string urlBase, string servicePrefix, string controller)
        {
            try
            {
                var client = new HttpClient
                {
                    BaseAddress = new Uri(urlBase),
                };

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", @"eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJkaW9nb3NkbDI1QGhvdG1haWwuY29tIiwianRpIjoiMDU5Y2FlMTMtNjNmMC00NjdjLWE0Y2EtZDE2NTdiY2E0OGFmIiwiZXhwIjoxNzI4NDkyNjk0LCJpc3MiOiJsb2NhbGhvc3QiLCJhdWQiOiJ1c2VycyJ9.PnL7bTCk0dNbWtlM7Pahp8rniIzLIEnkQfKxCfXpV2Q");

                var url = $"{servicePrefix}{controller}";
                var response = await client.GetAsync(url);
                var result = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = result,
                    };
                }

                var list = JsonConvert.DeserializeObject<List<T>>(result);
                return new Response
                {
                    IsSuccess = true,
                    Result = list
                };
            }
            catch (Exception ex)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }
    }
}
