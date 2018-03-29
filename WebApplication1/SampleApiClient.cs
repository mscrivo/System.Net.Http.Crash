using System;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Threading;
using System.Threading.Tasks;
using NetStandardLib;
using Newtonsoft.Json;

namespace WebApplication1
{
    public class LinkedInServiceFactory : ILinkedInServiceFactory
    {
        private static readonly JsonSerializer Serializer = new JsonSerializer();

        private static readonly IApiClient<LinkedInError> ApiClient = new ApiClient<LinkedInError>(CreateHttpClient(), Serializer, HttpVersion.Version10);

        public ILinkedInService Create(LinkedInCredentials credentials)
        {
            return new LinkedInService();
        }

        private static HttpClient CreateHttpClient()
        {
            var httpClient = new HttpClient();

            return httpClient;
        }
    }

    public class LinkedInCredentials
    {
        public string ScreenName { get; set; }

        public string AccessToken { get; set; }
    }

    internal class LinkedInService : ILinkedInService
    {
        public Task<LinkedInResponse<PostShareResponse>> PostShareAsync(PostShareOptions options,
            CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

    public class LinkedInError
    {
        [JsonProperty("errorCode")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("requestId")]
        public string requestId { get; set; }

        [JsonProperty("timestamp")]
        public long timestamp { get; set; }
    }

    public class PostShareContent
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("submittedImageUrl")]
        public string SubmittedImageUrl { get; set; }

        [JsonProperty("submittedUrl")]
        public string SubmittedUrl { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    [DataContract]
    public class PostShareOptions
    {
        [DataMember]
        [JsonProperty("comment")]
        public string Comment { get; set; }

        [DataMember]
        [JsonProperty]
        public PostShareContent Content { get; set; }
    }

    public class PostShareResponse
    {
        [JsonProperty("updateKey")]
        public string UpdateKey { get; set; }

        [JsonProperty("updateUrl")]
        public string UpdateUrl { get; set; }
    }

    public class LinkedInResponse<T>
    {
        public T Value { get; set; }
    }

    public interface ILinkedInService
    {
        Task<LinkedInResponse<PostShareResponse>> PostShareAsync(PostShareOptions options, CancellationToken cancellationToken);
    }

    public interface ILinkedInServiceFactory
    {
        ILinkedInService Create(LinkedInCredentials credentials);
    }

    internal class ErrorResponse
    {
    }
}