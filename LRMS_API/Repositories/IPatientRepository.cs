using LRMS_API.DTOs;

namespace LRMS_API.Repositories;

public interface IPatientRepository
{
    Task<int> AddPatientAsync(PatientDTO dto);
}