using JediAcademy.Domain.Entities;
using JediAcademy.Domain.Services;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace JediAcademy.Infrastructure.Services
{
    public class JediEnrollmentService : IJediEnrollmentService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<JediEnrollmentService> _logger;

        public JediEnrollmentService(IHttpClientFactory httpClientFactory, ILogger<JediEnrollmentService> logger)
        {
            _httpClientFactory = httpClientFactory;
            _logger = logger;
        }

        public async Task<(bool IsSuccess, IEnumerable<Species> Result)> GetAvailableSpecies()
        {
            try
            {
                var client = _httpClientFactory.CreateClient("Species");
                var response = await client.GetAsync("");
                var test = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsByteArrayAsync();
                    var options = new JsonSerializerOptions(){PropertyNameCaseInsensitive = true};
                    var result = JsonSerializer.Deserialize<IEnumerable<Species>>(content,options);
                    return (true, result);
                }

                return (false, null);
            }
            catch (Exception e)
            {
                _logger?.LogError(e.ToString());
                return (false, null);
            }
        }
    }
}
