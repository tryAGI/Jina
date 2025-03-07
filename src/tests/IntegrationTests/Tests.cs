namespace Jina.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static JinaClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("JINA_API_KEY") ??
            throw new AssertInconclusiveException("JINA_API_KEY environment variable is not found.");

        var client = new JinaClient(apiKey);
        
        return client;
    }
}
