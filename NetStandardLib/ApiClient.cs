using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NetStandardLib
{
    public class ApiClient<TError> : IApiClient<TError>
     where TError : class
    {
        private const string MediaType = "application/json";
        private readonly JsonSerializer _serializer;
        private readonly HttpClient _client;
        private readonly Version _httpVersion;

        public ApiClient(HttpClient client, JsonSerializer serializer, Version httpVersion)
        {
            _client = client;
            _serializer = serializer;
            _httpVersion = httpVersion;
        }

        public Task<ApiResponse<TError>> RequestAsync(ApiRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse<TResult, TError>> RequestAsync<TResult>(ApiRequest request, CancellationToken cancellationToken)
            where TResult : class
        {
            throw new NotImplementedException();

        }
    }
}
