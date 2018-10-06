using System;

namespace MedicalBilingBackEnd.Core.Models.Entities.Doctors
{
    public class Tarrifs
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public Double Amount { get; set; }
    }
}