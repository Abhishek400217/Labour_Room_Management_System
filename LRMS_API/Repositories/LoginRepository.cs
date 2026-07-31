using Dapper;
using LRMS_API.Data;
using LRMS_API.DTOs;
using System.Data;

namespace LRMS_API.Repositories
{
    public class LoginRepository
    {
        private readonly SqlConnectionFactory _factory;

        public LoginRepository(SqlConnectionFactory factory)
        {
            _factory = factory;
        }

        public async Task<LoginResponseDTO?> LoginAsync(LoginRequestDTO request)
        {
            using var connection = _factory.CreateConnection();

            var parameter = new DynamicParameters();

            parameter.Add("@Username", request.Username);
            parameter.Add("@Password", request.Password);

            var result = await connection.QueryFirstOrDefaultAsync<LoginResponseDTO>(
                "USP_Login",
                parameter,
                commandType: CommandType.StoredProcedure);

            return result;
        }
    }
}