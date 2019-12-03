using Properties.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;

namespace Properties.Service
{
    public class PropertyService : IPropertyService
    {
        private IList<Property> _properties;
        private readonly HttpClient _httpClient;

        public PropertyService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            var byteArray = Encoding.ASCII.GetBytes("simplyrets:simplyrets");
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");

            _properties = new List<Property>();
            /*_properties.Add(new Property(1, "one"));
            _properties.Add(new Property(2, "two"));
            _properties.Add(new Property(3, "three"));
            _properties.Add(new Property(4, "four"));*/
        }

        public async Task<IEnumerable<Property>> getAllPropertiesAsync()
        {
            HttpResponseMessage response = await _httpClient.GetAsync(_httpClient.BaseAddress + "/properties");
            response.EnsureSuccessStatusCode();
            string content = await response.Content.ReadAsStringAsync();
            var json = JsonConvert.DeserializeObject<List<Property>>(content);

            return json.AsEnumerable();
        }

        public Property getPropertyById(string id)
        {
            return _properties.Single(p => p.MlsId.Equals(id));
        }
    }

    public interface IPropertyService
    {
        Property getPropertyById(string id);
        Task<IEnumerable<Property>> getAllPropertiesAsync();
    }
}
