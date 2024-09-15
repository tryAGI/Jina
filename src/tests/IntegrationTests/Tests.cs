namespace Jina.IntegrationTests;

[TestClass]
public partial class Tests
{
    [TestMethod]
    public JinaApi GetAuthenticatedApi()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("JINA_API_KEY") ??
            throw new AssertInconclusiveException("JINA_API_KEY environment variable is not found.");

        var api = new JinaApi(apiKey);
        
        return api;
    }
}
