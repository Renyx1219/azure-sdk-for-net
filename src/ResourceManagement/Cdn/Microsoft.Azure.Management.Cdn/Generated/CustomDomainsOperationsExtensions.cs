// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Cdn
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    public static partial class CustomDomainsOperationsExtensions
    {
            /// <summary>
            /// Lists the existing CDN Custom Domains within an Endpoint
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint within the CDN profile
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile within the resource group
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the Azure subscription
            /// </param>
            public static IPage<CustomDomain> ListByEndpoint(this ICustomDomainsOperations operations, string endpointName, string profileName, string resourceGroupName)
            {
                return Task.Factory.StartNew(s => ((ICustomDomainsOperations)s).ListByEndpointAsync(endpointName, profileName, resourceGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the existing CDN Custom Domains within an Endpoint
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint within the CDN profile
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile within the resource group
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the Azure subscription
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<CustomDomain>> ListByEndpointAsync( this ICustomDomainsOperations operations, string endpointName, string profileName, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                var result = await operations.ListByEndpointWithHttpMessagesAsync(endpointName, profileName, resourceGroupName, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Gets an existing CDN Custom Domain within an Endpoint
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='customDomainName'>
            /// Name of the custom domain within an endpoint
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint within the CDN profile
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile within the resource group
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the Azure subscription
            /// </param>
            public static CustomDomain Get(this ICustomDomainsOperations operations, string customDomainName, string endpointName, string profileName, string resourceGroupName)
            {
                return Task.Factory.StartNew(s => ((ICustomDomainsOperations)s).GetAsync(customDomainName, endpointName, profileName, resourceGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets an existing CDN Custom Domain within an Endpoint
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='customDomainName'>
            /// Name of the custom domain within an endpoint
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint within the CDN profile
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile within the resource group
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the Azure subscription
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CustomDomain> GetAsync( this ICustomDomainsOperations operations, string customDomainName, string endpointName, string profileName, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                var result = await operations.GetWithHttpMessagesAsync(customDomainName, endpointName, profileName, resourceGroupName, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Creates a new CDN Custom Domain within an Endpoint
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='customDomainName'>
            /// Name of the custom domain within an endpoint
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint within the CDN profile
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile within the resource group
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the Azure subscription
            /// </param>
            /// <param name='hostName'>
            /// The host name of the custom domain
            /// </param>
            public static CustomDomain Create(this ICustomDomainsOperations operations, string customDomainName, string endpointName, string profileName, string resourceGroupName, string hostName)
            {
                return Task.Factory.StartNew(s => ((ICustomDomainsOperations)s).CreateAsync(customDomainName, endpointName, profileName, resourceGroupName, hostName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new CDN Custom Domain within an Endpoint
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='customDomainName'>
            /// Name of the custom domain within an endpoint
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint within the CDN profile
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile within the resource group
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the Azure subscription
            /// </param>
            /// <param name='hostName'>
            /// The host name of the custom domain
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CustomDomain> CreateAsync( this ICustomDomainsOperations operations, string customDomainName, string endpointName, string profileName, string resourceGroupName, string hostName, CancellationToken cancellationToken = default(CancellationToken))
            {
                var result = await operations.CreateWithHttpMessagesAsync(customDomainName, endpointName, profileName, resourceGroupName, hostName, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Creates a new CDN Custom Domain within an Endpoint
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='customDomainName'>
            /// Name of the custom domain within an endpoint
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint within the CDN profile
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile within the resource group
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the Azure subscription
            /// </param>
            /// <param name='hostName'>
            /// The host name of the custom domain
            /// </param>
            public static CustomDomain BeginCreate(this ICustomDomainsOperations operations, string customDomainName, string endpointName, string profileName, string resourceGroupName, string hostName)
            {
                return Task.Factory.StartNew(s => ((ICustomDomainsOperations)s).BeginCreateAsync(customDomainName, endpointName, profileName, resourceGroupName, hostName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new CDN Custom Domain within an Endpoint
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='customDomainName'>
            /// Name of the custom domain within an endpoint
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint within the CDN profile
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile within the resource group
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the Azure subscription
            /// </param>
            /// <param name='hostName'>
            /// The host name of the custom domain
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CustomDomain> BeginCreateAsync( this ICustomDomainsOperations operations, string customDomainName, string endpointName, string profileName, string resourceGroupName, string hostName, CancellationToken cancellationToken = default(CancellationToken))
            {
                var result = await operations.BeginCreateWithHttpMessagesAsync(customDomainName, endpointName, profileName, resourceGroupName, hostName, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Updates an existing CDN Custom Domain within an Endpoint
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='customDomainName'>
            /// Name of the custom domain within an endpoint
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint within the CDN profile
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile within the resource group
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the Azure subscription
            /// </param>
            /// <param name='hostName'>
            /// The host name of the custom domain
            /// </param>
            public static ErrorResponse Update(this ICustomDomainsOperations operations, string customDomainName, string endpointName, string profileName, string resourceGroupName, string hostName)
            {
                return Task.Factory.StartNew(s => ((ICustomDomainsOperations)s).UpdateAsync(customDomainName, endpointName, profileName, resourceGroupName, hostName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates an existing CDN Custom Domain within an Endpoint
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='customDomainName'>
            /// Name of the custom domain within an endpoint
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint within the CDN profile
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile within the resource group
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the Azure subscription
            /// </param>
            /// <param name='hostName'>
            /// The host name of the custom domain
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ErrorResponse> UpdateAsync( this ICustomDomainsOperations operations, string customDomainName, string endpointName, string profileName, string resourceGroupName, string hostName, CancellationToken cancellationToken = default(CancellationToken))
            {
                var result = await operations.UpdateWithHttpMessagesAsync(customDomainName, endpointName, profileName, resourceGroupName, hostName, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Deletes an existing CDN Custom Domain within an Endpoint
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='customDomainName'>
            /// Name of the custom domain within an endpoint
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint within the CDN profile
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile within the resource group
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the Azure subscription
            /// </param>
            public static CustomDomain DeleteIfExists(this ICustomDomainsOperations operations, string customDomainName, string endpointName, string profileName, string resourceGroupName)
            {
                return Task.Factory.StartNew(s => ((ICustomDomainsOperations)s).DeleteIfExistsAsync(customDomainName, endpointName, profileName, resourceGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an existing CDN Custom Domain within an Endpoint
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='customDomainName'>
            /// Name of the custom domain within an endpoint
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint within the CDN profile
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile within the resource group
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the Azure subscription
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CustomDomain> DeleteIfExistsAsync( this ICustomDomainsOperations operations, string customDomainName, string endpointName, string profileName, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                var result = await operations.DeleteIfExistsWithHttpMessagesAsync(customDomainName, endpointName, profileName, resourceGroupName, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Deletes an existing CDN Custom Domain within an Endpoint
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='customDomainName'>
            /// Name of the custom domain within an endpoint
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint within the CDN profile
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile within the resource group
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the Azure subscription
            /// </param>
            public static CustomDomain BeginDeleteIfExists(this ICustomDomainsOperations operations, string customDomainName, string endpointName, string profileName, string resourceGroupName)
            {
                return Task.Factory.StartNew(s => ((ICustomDomainsOperations)s).BeginDeleteIfExistsAsync(customDomainName, endpointName, profileName, resourceGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an existing CDN Custom Domain within an Endpoint
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='customDomainName'>
            /// Name of the custom domain within an endpoint
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint within the CDN profile
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile within the resource group
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the Azure subscription
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CustomDomain> BeginDeleteIfExistsAsync( this ICustomDomainsOperations operations, string customDomainName, string endpointName, string profileName, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                var result = await operations.BeginDeleteIfExistsWithHttpMessagesAsync(customDomainName, endpointName, profileName, resourceGroupName, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Lists the existing CDN Custom Domains within an Endpoint
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<CustomDomain> ListByEndpointNext(this ICustomDomainsOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((ICustomDomainsOperations)s).ListByEndpointNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the existing CDN Custom Domains within an Endpoint
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<CustomDomain>> ListByEndpointNextAsync( this ICustomDomainsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                var result = await operations.ListByEndpointNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

    }
}
