namespace MedicalBilingMicroservice.Resources.ApiToDomainResource
{
    public class SetPasswordResource
    {
        /*[Required]
        [StringLength(100, ErrorMessage = "{0} characters should be greater or equal to {2}", MinimumLength = 6)]
        [DataType(DataType.Password)] */       
        public string NewPassword { get; set; }

        /* [DataType(DataType.Password)]        
        [Compare("NewPassword", ErrorMessage = "New password and confirmation should match")]*/
        public string ConfirmPassword { get; set; }

    }
}