namespace APIWebbansimClient.Interface;

public interface ITestService<T> where T : class
{
    Task<string> GetTest();
}