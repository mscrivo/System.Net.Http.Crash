using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace NetStandardLib
{
    public class ApiRequest
    {
        public HttpMethod Method { get; }
        public string Url { get; }
        public IReadOnlyDictionary<string, IEnumerable<string>> Headers { get; }
        public object Body { get; }

        public ApiRequest(HttpMethod method, string url, IReadOnlyDictionary<string, IEnumerable<string>> headers, object body)
        {
            Method = method;
            Url = url;
            Headers = headers;
            Body = body;
        }
    }
}
