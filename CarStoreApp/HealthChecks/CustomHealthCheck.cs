using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace CarStoreApp.HealthChecks
{
    public class CustomHealthCheck : IHealthCheck
    {
        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {

            var isHealthy = true;

            if (isHealthy)
            {
                return Task.FromResult(
                    HealthCheckResult.Healthy(" Congrats! All the buyers are happy with their new cars! "));
            }

            return Task.FromResult(
                new HealthCheckResult(
                    context.Registration.FailureStatus, " Oh no! Some buyers are not feeling happy with their cars!"));
        }
    }
}
