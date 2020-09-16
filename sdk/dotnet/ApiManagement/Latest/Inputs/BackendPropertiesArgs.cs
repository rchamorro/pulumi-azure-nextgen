// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ApiManagement.Latest.Inputs
{

    /// <summary>
    /// Properties specific to the Backend Type.
    /// </summary>
    public sealed class BackendPropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Backend Service Fabric Cluster Properties
        /// </summary>
        [Input("serviceFabricCluster")]
        public Input<Inputs.BackendServiceFabricClusterPropertiesArgs>? ServiceFabricCluster { get; set; }

        public BackendPropertiesArgs()
        {
        }
    }
}