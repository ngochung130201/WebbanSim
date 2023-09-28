using APIWebbansimClient.Interface;

namespace APIWebbansimClient.Service;

public class TestService<T> : ITestService<T> where T : class
{
    private readonly IHttpClientService<T> _httpClientService;

    public TestService(IHttpClientService<T> httpClientService)
    {
        _httpClientService = httpClientService;
    }

    public async Task<string> GetTest()
    {
       var result = await _httpClientService.GetAsync("http://localhost:7030/api/about");
       var test = result;
       return result?.ToString();
    }
}