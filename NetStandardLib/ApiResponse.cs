using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace NetStandardLib
{
    public class ApiResponse<TError>
        where TError : class
    {
        public ApiResponse(TError error, HttpStatusCode statusCode, IReadOnlyDictionary<string, IEnumerable<string>> headers, bool wasSuccessfull)
        {
            Error = error;
            StatusCode = statusCode;
            Headers = headers;
            WasSuccessfull = wasSuccessfull;
        }

        public bool WasSuccessfull { get; }

        public TError Error { get; }

        public HttpStatusCode StatusCode { get; }

        public IReadOnlyDictionary<string, IEnumerable<string>> Headers { get; }
    }

    public class ApiResponse<TValue, TError> : ApiResponse<TError>
        where TValue : class
        where TError : class
    {
        public ApiResponse(TValue value, TError error, HttpStatusCode statusCode, IReadOnlyDictionary<string, IEnumerable<string>> headers, bool wasSuccessfull) : base(error, statusCode, headers, wasSuccessfull)
        {
            Value = value;
        }

        public TValue Value { get; }
    }
}
