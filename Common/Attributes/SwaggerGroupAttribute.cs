using System;

namespace MedicalBilingBackEnd.Common.Attributes
{
    public class SwaggerGroupAttribute : Attribute
    {
        public string GroupName { get; }

        public SwaggerGroupAttribute(string groupName)
        {
            GroupName = groupName;
        }
    }
}