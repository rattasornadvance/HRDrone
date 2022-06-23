using HRDrone.Operational.Configs;
using Microsoft.Extensions.Options;

namespace HRDroneAPI.Middleware
{
    public class AppSettingMiddleware
    {
        private readonly RequestDelegate _next;
        public AppSettingMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context, IOptions<HRDConfig> config)
        {
            HRDConfig _config = config.Value;
            await _next.Invoke(context);
        }
    }
}
