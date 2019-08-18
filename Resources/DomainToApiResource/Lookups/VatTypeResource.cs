using System;

namespace MedicalEngineMicroService.Resources.DomainToApiResource.Lookups
{
    public class VatTypeResource
    {
        public int Id { get; set; }
        public Double Percentage { get; set; }
        public string Description { get; set; }
    }
}