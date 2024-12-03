// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Projects
{
    /// <summary> The input definition information for a Microsoft Fabric tool as used to configure an agent. </summary>
    public partial class MicrosoftFabricToolDefinition : ToolDefinition
    {
        /// <summary> Initializes a new instance of <see cref="MicrosoftFabricToolDefinition"/>. </summary>
        /// <param name="fabricAiskill"> The list of connections used by the Microsoft Fabric tool. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fabricAiskill"/> is null. </exception>
        public MicrosoftFabricToolDefinition(ToolConnectionList fabricAiskill)
        {
            Argument.AssertNotNull(fabricAiskill, nameof(fabricAiskill));

            Type = "fabric_aiskill";
            FabricAiskill = fabricAiskill;
        }

        /// <summary> Initializes a new instance of <see cref="MicrosoftFabricToolDefinition"/>. </summary>
        /// <param name="type"> The object type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="fabricAiskill"> The list of connections used by the Microsoft Fabric tool. </param>
        internal MicrosoftFabricToolDefinition(string type, IDictionary<string, BinaryData> serializedAdditionalRawData, ToolConnectionList fabricAiskill) : base(type, serializedAdditionalRawData)
        {
            FabricAiskill = fabricAiskill;
        }

        /// <summary> Initializes a new instance of <see cref="MicrosoftFabricToolDefinition"/> for deserialization. </summary>
        internal MicrosoftFabricToolDefinition()
        {
        }

        /// <summary> The list of connections used by the Microsoft Fabric tool. </summary>
        public ToolConnectionList FabricAiskill { get; set; }
    }
}
