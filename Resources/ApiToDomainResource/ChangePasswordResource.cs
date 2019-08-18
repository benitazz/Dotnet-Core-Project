namespace MedicalEngineMicroServicet.Resources.ApiToDomainResource
{
    public class ChangePasswordResource
    {
        public string OldPassword { get; set; }

        /*[Required]
        [StringLength(100, ErrorMessage = "{0} characters should be greater or equal to {2}", MinimumLength = 6)]
        [DataType(DataType.Password)] */
        public string NewPassword { get; set; }

        /*[DataType(DataType.Password)]
        [Compare("NewPassword", ErrorMessage = "Password and confirmation should match")]*/
        public string ConfirmPassword { get; set; }
    }
}