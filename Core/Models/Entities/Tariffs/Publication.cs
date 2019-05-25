using System;
using MedicalBilingBackEnd.Core.Models.Entities.Lookups;

public class Publication : Lookup {

    public DateTime? From { get; set; }
    public DateTime? To { get; set; }
}