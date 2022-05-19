using Core.API;

namespace API.AssetsEndpoints
{
    public class AssetsEndpoints : IEndpointDefinition
    {
        public void DefineEndpoints(WebApplication app)
        {
            app.MapGet("api/test", GetAsset);
        }

        public void DefineServices(IServiceCollection services)
        {
            
        }

        private async Task<object> GetAsset()
        {
            return await Task.FromResult("teste funfando");
        }
    }
}