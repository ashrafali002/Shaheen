﻿using Shaheen.IshraqEntities;

namespace Shaheen.Models
{
    public class PersonModel : Person
    {
        public string countryName { get; set; }
        public string stateName { get; set; }
        public string districtName { get; set; }
        public string cityName { get; set; }
        public string areaName { get; set; }
    }
}
