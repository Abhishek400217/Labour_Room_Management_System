namespace LRMS_API.DTOs;

public class PatientDTO
{
    public string UHID { get; set; } = "";

    public string FirstName { get; set; } = "";

    public string MiddleName { get; set; } = "";

    public string LastName { get; set; } = "";

    public string HusbandName { get; set; } = "";

    public int Age { get; set; }

    public string Gender { get; set; } = "";

    public string MobileNo { get; set; } = "";

    public string BloodGroup { get; set; } = "";

    public string Village { get; set; } = "";

    public string Taluka { get; set; } = "";

    public string District { get; set; } = "";
}