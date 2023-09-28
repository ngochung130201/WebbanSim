using System.Text.Json;
using APIWebbansimClient.Interface;

namespace APIWebbansimClient.Service;

public class HttpClientService<T> : IHttpClientService<T> where T : class
{
    private readonly IHttpClientFactory _httpClientFactory;

    public HttpClientService(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<string> GetAsync(string url)
    {
        var httpClient = _httpClientFactory.CreateClient(url);
        var response = await httpClient.GetAsync(url);

        response.EnsureSuccessStatusCode();
        var jsonString = await response.Content.ReadAsStringAsync();
        if (response.IsSuccessStatusCode)
        {
           // var test = JsonSerializer.Deserialize<T>(jsonString);
           return jsonString;
        }

        return jsonString;

    }

    public async Task<T?> PostAsync(string url, T data)
    {
        var httpClient = _httpClientFactory.CreateClient("MyApi");
        var response = await httpClient.PostAsJsonAsync(url, data);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<T>();
    }

    public async Task<T?> PutAsync(string url, T data)
    {
        var httpClient = _httpClientFactory.CreateClient("MyApi");
        var response = await httpClient.PutAsJsonAsync(url, data);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<T>();
    }

    public async Task DeleteAsync(string url)
    {
        var httpClient = _httpClientFactory.CreateClient("MyApi");
        var response = await httpClient.DeleteAsync(url);

        response.EnsureSuccessStatusCode();
    }
}