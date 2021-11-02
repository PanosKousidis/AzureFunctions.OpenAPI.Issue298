using Microsoft.Azure.Functions.Worker.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;
using Microsoft.Azure.Functions.Worker.Extensions.OpenApi.Extensions;

namespace Function
{
    public class Program
    {
        public static void Main()
        {
            var host = new HostBuilder()
                .ConfigureFunctionsWorkerDefaults()
                .ConfigureOpenApi()
                .Build();

            host.Run();
        }
    }
}