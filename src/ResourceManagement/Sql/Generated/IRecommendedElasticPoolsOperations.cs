// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Fluent
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// RecommendedElasticPoolsOperations operations.
    /// </summary>
    public partial interface IRecommendedElasticPoolsOperations
    {
        /// <summary>
        /// Gets a recommented elastic pool.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can
        /// obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='recommendedElasticPoolName'>
        /// The name of the recommended elastic pool to be retrieved.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<RecommendedElasticPoolInner>> GetWithHttpMessagesAsync(string resourceGroupName, string serverName, string recommendedElasticPoolName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns recommended elastic pools.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can
        /// obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IEnumerable<RecommendedElasticPoolInner>>> ListByServerWithHttpMessagesAsync(string resourceGroupName, string serverName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns recommented elastic pool metrics.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can
        /// obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='recommendedElasticPoolName'>
        /// The name of the recommended elastic pool to be retrieved.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IEnumerable<RecommendedElasticPoolMetric>>> ListMetricsWithHttpMessagesAsync(string resourceGroupName, string serverName, string recommendedElasticPoolName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
