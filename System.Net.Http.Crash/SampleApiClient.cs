using NetStandardLib;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace System.Net.Http.Crash
{
    public class SampleApiClient
    {
        private const string BaseUrl = "https://somesite.com";
        private static readonly JsonSerializer Serializer = new JsonSerializer();
        private static readonly IApiClient<ErrorResponse> ApiClient = new ApiClient<ErrorResponse>(CreateHttpClient(), Serializer, HttpVersion.Version11);

        public SampleApiClient()
        {
        }

        private static HttpClient CreateHttpClient()
        {
            return new HttpClient();
        }
    }

    internal class ErrorResponse
    {
    }
}