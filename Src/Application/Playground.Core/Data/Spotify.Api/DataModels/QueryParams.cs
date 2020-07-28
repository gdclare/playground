using System.Collections.Generic;

namespace Playground.Core.Data.Spotify.Api.DataModels
{
    internal class QueryParams
    {
        public QueryParams()
        {
            QueryParameters = new Dictionary<string, string>();
        }

        public QueryParams(Dictionary<string, string> queryParams)
        {
            QueryParameters = queryParams;
        }

        public Dictionary<string, string> QueryParameters { get; set; }

        public override string ToString()
        {
            string paramsConcat = string.Empty;
            foreach (var param in QueryParameters)
            {
                paramsConcat += string.Join("&", $"{param.Key}={param.Value}");
            }
            return $"?{paramsConcat}";
        }
    }
}