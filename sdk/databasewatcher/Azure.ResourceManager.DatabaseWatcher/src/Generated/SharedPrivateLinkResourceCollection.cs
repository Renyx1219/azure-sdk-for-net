// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.DatabaseWatcher
{
    /// <summary>
    /// A class representing a collection of <see cref="SharedPrivateLinkResource"/> and their operations.
    /// Each <see cref="SharedPrivateLinkResource"/> in the collection will belong to the same instance of <see cref="WatcherResource"/>.
    /// To get a <see cref="SharedPrivateLinkResourceCollection"/> instance call the GetSharedPrivateLinkResources method from an instance of <see cref="WatcherResource"/>.
    /// </summary>
    public partial class SharedPrivateLinkResourceCollection : ArmCollection, IEnumerable<SharedPrivateLinkResource>, IAsyncEnumerable<SharedPrivateLinkResource>
    {
        private readonly ClientDiagnostics _sharedPrivateLinkResourceClientDiagnostics;
        private readonly SharedPrivateLinkResourcesRestOperations _sharedPrivateLinkResourceRestClient;

        /// <summary> Initializes a new instance of the <see cref="SharedPrivateLinkResourceCollection"/> class for mocking. </summary>
        protected SharedPrivateLinkResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SharedPrivateLinkResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SharedPrivateLinkResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sharedPrivateLinkResourceClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DatabaseWatcher", SharedPrivateLinkResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SharedPrivateLinkResource.ResourceType, out string sharedPrivateLinkResourceApiVersion);
            _sharedPrivateLinkResourceRestClient = new SharedPrivateLinkResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sharedPrivateLinkResourceApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WatcherResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WatcherResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a SharedPrivateLinkResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DatabaseWatcher/watchers/{watcherName}/sharedPrivateLinkResources/{sharedPrivateLinkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SharedPrivateLinkResource_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SharedPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sharedPrivateLinkResourceName"> The Shared Private Link resource name. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sharedPrivateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sharedPrivateLinkResourceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SharedPrivateLinkResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string sharedPrivateLinkResourceName, SharedPrivateLinkResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sharedPrivateLinkResourceName, nameof(sharedPrivateLinkResourceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sharedPrivateLinkResourceClientDiagnostics.CreateScope("SharedPrivateLinkResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sharedPrivateLinkResourceRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sharedPrivateLinkResourceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new DatabaseWatcherArmOperation<SharedPrivateLinkResource>(new SharedPrivateLinkResourceOperationSource(Client), _sharedPrivateLinkResourceClientDiagnostics, Pipeline, _sharedPrivateLinkResourceRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sharedPrivateLinkResourceName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create a SharedPrivateLinkResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DatabaseWatcher/watchers/{watcherName}/sharedPrivateLinkResources/{sharedPrivateLinkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SharedPrivateLinkResource_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SharedPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sharedPrivateLinkResourceName"> The Shared Private Link resource name. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sharedPrivateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sharedPrivateLinkResourceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SharedPrivateLinkResource> CreateOrUpdate(WaitUntil waitUntil, string sharedPrivateLinkResourceName, SharedPrivateLinkResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sharedPrivateLinkResourceName, nameof(sharedPrivateLinkResourceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sharedPrivateLinkResourceClientDiagnostics.CreateScope("SharedPrivateLinkResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sharedPrivateLinkResourceRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sharedPrivateLinkResourceName, data, cancellationToken);
                var operation = new DatabaseWatcherArmOperation<SharedPrivateLinkResource>(new SharedPrivateLinkResourceOperationSource(Client), _sharedPrivateLinkResourceClientDiagnostics, Pipeline, _sharedPrivateLinkResourceRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sharedPrivateLinkResourceName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a SharedPrivateLinkResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DatabaseWatcher/watchers/{watcherName}/sharedPrivateLinkResources/{sharedPrivateLinkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SharedPrivateLinkResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SharedPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sharedPrivateLinkResourceName"> The Shared Private Link resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sharedPrivateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sharedPrivateLinkResourceName"/> is null. </exception>
        public virtual async Task<Response<SharedPrivateLinkResource>> GetAsync(string sharedPrivateLinkResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sharedPrivateLinkResourceName, nameof(sharedPrivateLinkResourceName));

            using var scope = _sharedPrivateLinkResourceClientDiagnostics.CreateScope("SharedPrivateLinkResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _sharedPrivateLinkResourceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sharedPrivateLinkResourceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SharedPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a SharedPrivateLinkResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DatabaseWatcher/watchers/{watcherName}/sharedPrivateLinkResources/{sharedPrivateLinkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SharedPrivateLinkResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SharedPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sharedPrivateLinkResourceName"> The Shared Private Link resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sharedPrivateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sharedPrivateLinkResourceName"/> is null. </exception>
        public virtual Response<SharedPrivateLinkResource> Get(string sharedPrivateLinkResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sharedPrivateLinkResourceName, nameof(sharedPrivateLinkResourceName));

            using var scope = _sharedPrivateLinkResourceClientDiagnostics.CreateScope("SharedPrivateLinkResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _sharedPrivateLinkResourceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sharedPrivateLinkResourceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SharedPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List SharedPrivateLinkResource resources by Watcher
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DatabaseWatcher/watchers/{watcherName}/sharedPrivateLinkResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SharedPrivateLinkResource_ListByWatcher</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SharedPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SharedPrivateLinkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SharedPrivateLinkResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sharedPrivateLinkResourceRestClient.CreateListByWatcherRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sharedPrivateLinkResourceRestClient.CreateListByWatcherNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SharedPrivateLinkResource(Client, SharedPrivateLinkResourceData.DeserializeSharedPrivateLinkResourceData(e)), _sharedPrivateLinkResourceClientDiagnostics, Pipeline, "SharedPrivateLinkResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List SharedPrivateLinkResource resources by Watcher
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DatabaseWatcher/watchers/{watcherName}/sharedPrivateLinkResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SharedPrivateLinkResource_ListByWatcher</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SharedPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SharedPrivateLinkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SharedPrivateLinkResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sharedPrivateLinkResourceRestClient.CreateListByWatcherRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sharedPrivateLinkResourceRestClient.CreateListByWatcherNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SharedPrivateLinkResource(Client, SharedPrivateLinkResourceData.DeserializeSharedPrivateLinkResourceData(e)), _sharedPrivateLinkResourceClientDiagnostics, Pipeline, "SharedPrivateLinkResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DatabaseWatcher/watchers/{watcherName}/sharedPrivateLinkResources/{sharedPrivateLinkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SharedPrivateLinkResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SharedPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sharedPrivateLinkResourceName"> The Shared Private Link resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sharedPrivateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sharedPrivateLinkResourceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string sharedPrivateLinkResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sharedPrivateLinkResourceName, nameof(sharedPrivateLinkResourceName));

            using var scope = _sharedPrivateLinkResourceClientDiagnostics.CreateScope("SharedPrivateLinkResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _sharedPrivateLinkResourceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sharedPrivateLinkResourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DatabaseWatcher/watchers/{watcherName}/sharedPrivateLinkResources/{sharedPrivateLinkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SharedPrivateLinkResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SharedPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sharedPrivateLinkResourceName"> The Shared Private Link resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sharedPrivateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sharedPrivateLinkResourceName"/> is null. </exception>
        public virtual Response<bool> Exists(string sharedPrivateLinkResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sharedPrivateLinkResourceName, nameof(sharedPrivateLinkResourceName));

            using var scope = _sharedPrivateLinkResourceClientDiagnostics.CreateScope("SharedPrivateLinkResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _sharedPrivateLinkResourceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sharedPrivateLinkResourceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DatabaseWatcher/watchers/{watcherName}/sharedPrivateLinkResources/{sharedPrivateLinkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SharedPrivateLinkResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SharedPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sharedPrivateLinkResourceName"> The Shared Private Link resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sharedPrivateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sharedPrivateLinkResourceName"/> is null. </exception>
        public virtual async Task<NullableResponse<SharedPrivateLinkResource>> GetIfExistsAsync(string sharedPrivateLinkResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sharedPrivateLinkResourceName, nameof(sharedPrivateLinkResourceName));

            using var scope = _sharedPrivateLinkResourceClientDiagnostics.CreateScope("SharedPrivateLinkResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _sharedPrivateLinkResourceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sharedPrivateLinkResourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SharedPrivateLinkResource>(response.GetRawResponse());
                return Response.FromValue(new SharedPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DatabaseWatcher/watchers/{watcherName}/sharedPrivateLinkResources/{sharedPrivateLinkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SharedPrivateLinkResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SharedPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sharedPrivateLinkResourceName"> The Shared Private Link resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sharedPrivateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sharedPrivateLinkResourceName"/> is null. </exception>
        public virtual NullableResponse<SharedPrivateLinkResource> GetIfExists(string sharedPrivateLinkResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sharedPrivateLinkResourceName, nameof(sharedPrivateLinkResourceName));

            using var scope = _sharedPrivateLinkResourceClientDiagnostics.CreateScope("SharedPrivateLinkResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _sharedPrivateLinkResourceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sharedPrivateLinkResourceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SharedPrivateLinkResource>(response.GetRawResponse());
                return Response.FromValue(new SharedPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SharedPrivateLinkResource> IEnumerable<SharedPrivateLinkResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SharedPrivateLinkResource> IAsyncEnumerable<SharedPrivateLinkResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
