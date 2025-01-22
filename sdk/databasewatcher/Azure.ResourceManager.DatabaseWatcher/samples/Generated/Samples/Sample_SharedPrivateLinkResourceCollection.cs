// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DatabaseWatcher.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.DatabaseWatcher.Samples
{
    public partial class Sample_SharedPrivateLinkResourceCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_SharedPrivateLinkResourcesCreateMaximumSet()
        {
            // Generated from example definition: 2025-01-02/SharedPrivateLinkResources_Create_MaximumSet_Gen.json
            // this example is just showing the usage of "SharedPrivateLinkResource_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WatcherResource created on azure
            // for more information of creating WatcherResource, please refer to the document of WatcherResource
            string subscriptionId = "49e0fbd3-75e8-44e7-96fd-5b64d9ad818d";
            string resourceGroupName = "apiTest-ddat4p";
            string watcherName = "databasemo3ej9ih";
            ResourceIdentifier watcherResourceId = WatcherResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, watcherName);
            WatcherResource watcher = client.GetWatcherResource(watcherResourceId);

            // get the collection of this SharedPrivateLinkResource
            SharedPrivateLinkResourceCollection collection = watcher.GetSharedPrivateLinkResources();

            // invoke the operation
            string sharedPrivateLinkResourceName = "monitoringh22eed";
            SharedPrivateLinkResourceData data = new SharedPrivateLinkResourceData
            {
                Properties = new SharedPrivateLinkResourceProperties(new ResourceIdentifier("/subscriptions/49e0fbd3-75e8-44e7-96fd-5b64d9ad818d/resourceGroups/apiTest-ddat4p/providers/Microsoft.KeyVault/vaults/kvmo3ej9ih"), "vault", "request message")
                {
                    DnsZone = "ec3ae9d410ba",
                },
            };
            ArmOperation<SharedPrivateLinkResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, sharedPrivateLinkResourceName, data);
            SharedPrivateLinkResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SharedPrivateLinkResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_SharedPrivateLinkResourcesGetMaximumSet()
        {
            // Generated from example definition: 2025-01-02/SharedPrivateLinkResources_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "SharedPrivateLinkResource_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WatcherResource created on azure
            // for more information of creating WatcherResource, please refer to the document of WatcherResource
            string subscriptionId = "49e0fbd3-75e8-44e7-96fd-5b64d9ad818d";
            string resourceGroupName = "apiTest-ddat4p";
            string watcherName = "databasemo3ej9ih";
            ResourceIdentifier watcherResourceId = WatcherResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, watcherName);
            WatcherResource watcher = client.GetWatcherResource(watcherResourceId);

            // get the collection of this SharedPrivateLinkResource
            SharedPrivateLinkResourceCollection collection = watcher.GetSharedPrivateLinkResources();

            // invoke the operation
            string sharedPrivateLinkResourceName = "monitoringh22eed";
            SharedPrivateLinkResource result = await collection.GetAsync(sharedPrivateLinkResourceName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SharedPrivateLinkResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_SharedPrivateLinkResourcesListByWatcherMaximumSet()
        {
            // Generated from example definition: 2025-01-02/SharedPrivateLinkResources_ListByWatcher_MaximumSet_Gen.json
            // this example is just showing the usage of "SharedPrivateLinkResource_ListByWatcher" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WatcherResource created on azure
            // for more information of creating WatcherResource, please refer to the document of WatcherResource
            string subscriptionId = "49e0fbd3-75e8-44e7-96fd-5b64d9ad818d";
            string resourceGroupName = "apiTest-ddat4p";
            string watcherName = "databasemo3ej9ih";
            ResourceIdentifier watcherResourceId = WatcherResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, watcherName);
            WatcherResource watcher = client.GetWatcherResource(watcherResourceId);

            // get the collection of this SharedPrivateLinkResource
            SharedPrivateLinkResourceCollection collection = watcher.GetSharedPrivateLinkResources();

            // invoke the operation and iterate over the result
            await foreach (SharedPrivateLinkResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SharedPrivateLinkResourceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_SharedPrivateLinkResourcesGetMaximumSet()
        {
            // Generated from example definition: 2025-01-02/SharedPrivateLinkResources_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "SharedPrivateLinkResource_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WatcherResource created on azure
            // for more information of creating WatcherResource, please refer to the document of WatcherResource
            string subscriptionId = "49e0fbd3-75e8-44e7-96fd-5b64d9ad818d";
            string resourceGroupName = "apiTest-ddat4p";
            string watcherName = "databasemo3ej9ih";
            ResourceIdentifier watcherResourceId = WatcherResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, watcherName);
            WatcherResource watcher = client.GetWatcherResource(watcherResourceId);

            // get the collection of this SharedPrivateLinkResource
            SharedPrivateLinkResourceCollection collection = watcher.GetSharedPrivateLinkResources();

            // invoke the operation
            string sharedPrivateLinkResourceName = "monitoringh22eed";
            bool result = await collection.ExistsAsync(sharedPrivateLinkResourceName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_SharedPrivateLinkResourcesGetMaximumSet()
        {
            // Generated from example definition: 2025-01-02/SharedPrivateLinkResources_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "SharedPrivateLinkResource_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WatcherResource created on azure
            // for more information of creating WatcherResource, please refer to the document of WatcherResource
            string subscriptionId = "49e0fbd3-75e8-44e7-96fd-5b64d9ad818d";
            string resourceGroupName = "apiTest-ddat4p";
            string watcherName = "databasemo3ej9ih";
            ResourceIdentifier watcherResourceId = WatcherResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, watcherName);
            WatcherResource watcher = client.GetWatcherResource(watcherResourceId);

            // get the collection of this SharedPrivateLinkResource
            SharedPrivateLinkResourceCollection collection = watcher.GetSharedPrivateLinkResources();

            // invoke the operation
            string sharedPrivateLinkResourceName = "monitoringh22eed";
            NullableResponse<SharedPrivateLinkResource> response = await collection.GetIfExistsAsync(sharedPrivateLinkResourceName);
            SharedPrivateLinkResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SharedPrivateLinkResourceData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
