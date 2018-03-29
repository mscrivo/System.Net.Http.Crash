using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NetStandardLib
{
    public interface IApiClient<TError>
        where TError : class
    {
        Task<ApiResponse<TError>> RequestAsync(ApiRequest request, CancellationToken cancellationToken);
        Task<ApiResponse<TResult, TError>> RequestAsync<TResult>(ApiRequest request, CancellationToken cancellationToken) where TResult : class;
    }
}
