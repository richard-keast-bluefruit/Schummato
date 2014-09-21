using System.Net;

namespace Schummato.Utilities
{
    public interface IDataRetriever
    {
        string GetJson(string endpoint);
    }

    internal class DataRetriever : IDataRetriever
    {
        public string GetJson(string endpoint)
        {
            string json;

            using (var webClient = new WebClient())
            {
                json = webClient.DownloadString(endpoint);
            }

            return json;
        }
    }
}
