using APIWebbansimClient.Enum;
using APIWebbansimClient.Interface;
using APIWebbansimClient.Service;

namespace APIWebbansimClient.Config;

public class Configure
{

    public void ConfigureService(IServiceCollection serviceCollection)
    {
        // serviceCollection.add
       // serviceCollection.Configure<EnumAPI>(GetSection(nameof(EnumAPI.BACKEND_URL)));
      serviceCollection.AddScoped(typeof(ITestService<>), typeof(TestService<>));
      serviceCollection.AddScoped(typeof(IHttpClientService<>), typeof(HttpClientService<>));
    }
}