using System.Net.Http.Json;

namespace CaseFichasMedicas.Client.Services.RoleService
{
    public class RoleService : IRoleService
    {
        private readonly HttpClient _http;

        public RoleService(HttpClient http)
        {
            _http = http;
        }

        public List<Role> Roles { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public async Task GetRoles()
        {
            var result = await _http.GetFromJsonAsync<List<Role>>("api/roles");
            if (result == null)
                Roles = result;
        }
    }
}
