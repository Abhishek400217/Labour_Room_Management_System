using LRMS_API.DTOs;
using LRMS_API.Repositories;

namespace LRMS_API.Services
{
    public class LoginService
    {
        private readonly LoginRepository _repository;

        public LoginService(LoginRepository repository)
        {
            _repository = repository;
        }

        public async Task<LoginResponseDTO?> LoginAsync(LoginRequestDTO request)
        {
            return await _repository.LoginAsync(request);
        }
    }
}