using Shaheen.IshtiraqEntities;

namespace Shaheen.Models
{
    public class AgentModel : Agent
    {
        public string countryName { get; set; }
        public string stateName { get; set; }
        public string districtName { get; set; }
        public string cityName { get; set; }
        public string areaName { get; set; }
    }
}
