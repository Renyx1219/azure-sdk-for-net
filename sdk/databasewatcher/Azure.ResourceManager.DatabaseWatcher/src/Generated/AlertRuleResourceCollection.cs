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
    /// A class representing a collection of <see cref="AlertRuleResource"/> and their operations.
    /// Each <see cref="AlertRuleResource"/> in the collection will belong to the same instance of <see cref="WatcherResource"/>.
    /// To get an <see cref="AlertRuleResourceCollection"/> instance call the GetAlertRuleResources method from an instance of <see cref="WatcherResource"/>.
    /// </summary>
    public partial class AlertRuleResourceCollection : ArmCollection, IEnumerable<AlertRuleResource>, IAsyncEnumerable<AlertRuleResource>
    {
        private readonly ClientDiagnostics _alertRuleResourceClientDiagnostics;
        private readonly AlertRuleResourcesRestOperations _alertRuleResourceRestClient;

        /// <summary> Initializes a new instance of the <see cref="AlertRuleResourceCollection"/> class for mocking. </summary>
        protected AlertRuleResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AlertRuleResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AlertRuleResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _alertRuleResourceClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DatabaseWatcher", AlertRuleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AlertRuleResource.ResourceType, out string alertRuleResourceApiVersion);
            _alertRuleResourceRestClient = new AlertRuleResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, alertRuleResourceApiVersion);
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
        /// Create a AlertRuleResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DatabaseWatcher/watchers/{watcherName}/alertRuleResources/{alertRuleResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertRuleResource_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AlertRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="alertRuleResourceName"> The alert rule proxy resource name. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertRuleResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertRuleResourceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AlertRuleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string alertRuleResourceName, AlertRuleResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertRuleResourceName, nameof(alertRuleResourceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _alertRuleResourceClientDiagnostics.CreateScope("AlertRuleResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _alertRuleResourceRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, alertRuleResourceName, data, cancellationToken).ConfigureAwait(false);
                var uri = _alertRuleResourceRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, alertRuleResourceName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new DatabaseWatcherArmOperation<AlertRuleResource>(Response.FromValue(new AlertRuleResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Create a AlertRuleResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DatabaseWatcher/watchers/{watcherName}/alertRuleResources/{alertRuleResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertRuleResource_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AlertRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="alertRuleResourceName"> The alert rule proxy resource name. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertRuleResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertRuleResourceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AlertRuleResource> CreateOrUpdate(WaitUntil waitUntil, string alertRuleResourceName, AlertRuleResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertRuleResourceName, nameof(alertRuleResourceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _alertRuleResourceClientDiagnostics.CreateScope("AlertRuleResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _alertRuleResourceRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, alertRuleResourceName, data, cancellationToken);
                var uri = _alertRuleResourceRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, alertRuleResourceName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new DatabaseWatcherArmOperation<AlertRuleResource>(Response.FromValue(new AlertRuleResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Get a AlertRuleResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DatabaseWatcher/watchers/{watcherName}/alertRuleResources/{alertRuleResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertRuleResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AlertRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alertRuleResourceName"> The alert rule proxy resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertRuleResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertRuleResourceName"/> is null. </exception>
        public virtual async Task<Response<AlertRuleResource>> GetAsync(string alertRuleResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertRuleResourceName, nameof(alertRuleResourceName));

            using var scope = _alertRuleResourceClientDiagnostics.CreateScope("AlertRuleResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _alertRuleResourceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, alertRuleResourceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AlertRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a AlertRuleResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DatabaseWatcher/watchers/{watcherName}/alertRuleResources/{alertRuleResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertRuleResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AlertRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alertRuleResourceName"> The alert rule proxy resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertRuleResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertRuleResourceName"/> is null. </exception>
        public virtual Response<AlertRuleResource> Get(string alertRuleResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertRuleResourceName, nameof(alertRuleResourceName));

            using var scope = _alertRuleResourceClientDiagnostics.CreateScope("AlertRuleResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _alertRuleResourceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, alertRuleResourceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AlertRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List AlertRuleResource resources by Watcher
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DatabaseWatcher/watchers/{watcherName}/alertRuleResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertRuleResource_ListByParent</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AlertRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AlertRuleResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AlertRuleResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _alertRuleResourceRestClient.CreateListByParentRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _alertRuleResourceRestClient.CreateListByParentNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new AlertRuleResource(Client, AlertRuleResourceData.DeserializeAlertRuleResourceData(e)), _alertRuleResourceClientDiagnostics, Pipeline, "AlertRuleResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List AlertRuleResource resources by Watcher
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DatabaseWatcher/watchers/{watcherName}/alertRuleResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertRuleResource_ListByParent</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AlertRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AlertRuleResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AlertRuleResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _alertRuleResourceRestClient.CreateListByParentRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _alertRuleResourceRestClient.CreateListByParentNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new AlertRuleResource(Client, AlertRuleResourceData.DeserializeAlertRuleResourceData(e)), _alertRuleResourceClientDiagnostics, Pipeline, "AlertRuleResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DatabaseWatcher/watchers/{watcherName}/alertRuleResources/{alertRuleResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertRuleResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AlertRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alertRuleResourceName"> The alert rule proxy resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertRuleResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertRuleResourceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string alertRuleResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertRuleResourceName, nameof(alertRuleResourceName));

            using var scope = _alertRuleResourceClientDiagnostics.CreateScope("AlertRuleResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _alertRuleResourceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, alertRuleResourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DatabaseWatcher/watchers/{watcherName}/alertRuleResources/{alertRuleResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertRuleResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AlertRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alertRuleResourceName"> The alert rule proxy resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertRuleResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertRuleResourceName"/> is null. </exception>
        public virtual Response<bool> Exists(string alertRuleResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertRuleResourceName, nameof(alertRuleResourceName));

            using var scope = _alertRuleResourceClientDiagnostics.CreateScope("AlertRuleResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _alertRuleResourceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, alertRuleResourceName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DatabaseWatcher/watchers/{watcherName}/alertRuleResources/{alertRuleResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertRuleResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AlertRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alertRuleResourceName"> The alert rule proxy resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertRuleResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertRuleResourceName"/> is null. </exception>
        public virtual async Task<NullableResponse<AlertRuleResource>> GetIfExistsAsync(string alertRuleResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertRuleResourceName, nameof(alertRuleResourceName));

            using var scope = _alertRuleResourceClientDiagnostics.CreateScope("AlertRuleResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _alertRuleResourceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, alertRuleResourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<AlertRuleResource>(response.GetRawResponse());
                return Response.FromValue(new AlertRuleResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DatabaseWatcher/watchers/{watcherName}/alertRuleResources/{alertRuleResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertRuleResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AlertRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alertRuleResourceName"> The alert rule proxy resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertRuleResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertRuleResourceName"/> is null. </exception>
        public virtual NullableResponse<AlertRuleResource> GetIfExists(string alertRuleResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertRuleResourceName, nameof(alertRuleResourceName));

            using var scope = _alertRuleResourceClientDiagnostics.CreateScope("AlertRuleResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _alertRuleResourceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, alertRuleResourceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<AlertRuleResource>(response.GetRawResponse());
                return Response.FromValue(new AlertRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AlertRuleResource> IEnumerable<AlertRuleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AlertRuleResource> IAsyncEnumerable<AlertRuleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
