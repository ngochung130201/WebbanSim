namespace APIWebbansimClient.Interface;

public interface IHttpClientService<T> where T : class
{
    Task<string> GetAsync(string url);
    Task<T?> PostAsync(string url, T data);
    Task<T?> PutAsync(string url, T data);
    Task DeleteAsync(string url);
}