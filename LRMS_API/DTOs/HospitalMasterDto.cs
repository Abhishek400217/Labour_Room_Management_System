public class HospitalMasterDto
{
    public int HospitalId { get; set; }

    public string HospitalCode { get; set; } = string.Empty;

    public string HospitalName { get; set; } = string.Empty;

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Pincode { get; set; }

    public string? ContactNo { get; set; }

    public string? Email { get; set; }

    public bool IsActive { get; set; }
}