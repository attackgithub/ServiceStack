// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace AutorestClient
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// HelloAllTypesWithResultOperations operations.
    /// </summary>
    public partial interface IHelloAllTypesWithResultOperations
    {
        /// <param name='name'>
        /// </param>
        /// <param name='allTypes'>
        /// </param>
        /// <param name='allCollectionTypes'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="HelloAllTypesResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<HelloAllTypesResponse>> GetWithHttpMessagesAsync(string name = default(string), string allTypes = default(string), string allCollectionTypes = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <param name='name'>
        /// </param>
        /// <param name='allTypes'>
        /// </param>
        /// <param name='allCollectionTypes'>
        /// </param>
        /// <param name='body'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="HelloAllTypesResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<HelloAllTypesResponse>> CreateWithHttpMessagesAsync(string name = default(string), string allTypes = default(string), string allCollectionTypes = default(string), HelloAllTypesWithResult body = default(HelloAllTypesWithResult), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <param name='name'>
        /// </param>
        /// <param name='allTypes'>
        /// </param>
        /// <param name='allCollectionTypes'>
        /// </param>
        /// <param name='body'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="HelloAllTypesResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<HelloAllTypesResponse>> PostWithHttpMessagesAsync(string name = default(string), string allTypes = default(string), string allCollectionTypes = default(string), HelloAllTypesWithResult body = default(HelloAllTypesWithResult), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <param name='name'>
        /// </param>
        /// <param name='allTypes'>
        /// </param>
        /// <param name='allCollectionTypes'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="HelloAllTypesResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<HelloAllTypesResponse>> DeleteWithHttpMessagesAsync(string name = default(string), string allTypes = default(string), string allCollectionTypes = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
