using RestSharp;

namespace FrontEnd.Databases;
public static class FetchApi {
    public static string FetchPost(string url, string urlBase, string dataJson) {
        try
        {
            var options = new RestClientOptions(url) {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest(urlBase, Method.Post);
            request.AddHeader("Content-Type", "application/json");
            request.AddStringBody(dataJson, DataFormat.Json);
            var response = client.ExecuteAsync(request).Result;
            return response.Content;
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }
}