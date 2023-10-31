using RestSharp;

namespace FrontEnd.Databases;
public static class FetchApi {
    public static string FetchGet(string url, string urlBase) {
        try
        {
            var options = new RestClientOptions(url) {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest(urlBase, Method.Get);
            request.AddHeader("Content-Type", "application/json");
            var response = client.ExecuteAsync(request).Result;
            return response.Content;
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }
}