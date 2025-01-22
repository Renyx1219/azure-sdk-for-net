// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.DatabaseWatcher.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableDatabaseWatcherResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableDatabaseWatcherResourceGroupResource"/> class for mocking. </summary>
        protected MockableDatabaseWatcherResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableDatabaseWatcherResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableDatabaseWatcherResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of WatcherResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of WatcherResources and their operations over a WatcherResource. </returns>
        public virtual WatcherCollection GetWatchers()
        {
            return GetCachedClient(client => new WatcherCollection(client, Id));
        }

        /// <summary>
        /// Get a Watcher
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DatabaseWatcher/watchers/{watcherName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Watcher_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WatcherResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="watcherName"> The database watcher name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="watcherName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="watcherName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<WatcherResource>> GetWatcherAsync(string watcherName, CancellationToken cancellationToken = default)
        {
            return await GetWatchers().GetAsync(watcherName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a Watcher
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DatabaseWatcher/watchers/{watcherName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Watcher_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WatcherResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="watcherName"> The database watcher name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="watcherName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="watcherName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<WatcherResource> GetWatcher(string watcherName, CancellationToken cancellationToken = default)
        {
            return GetWatchers().Get(watcherName, cancellationToken);
        }
    }
}
