// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20181001
{
    /// <summary>
    /// Information about the connection monitor.
    /// </summary>
    public partial class ConnectionMonitor : Pulumi.CustomResource
    {
        /// <summary>
        /// Determines if the connection monitor will start automatically once created.
        /// </summary>
        [Output("autoStart")]
        public Output<bool?> AutoStart { get; private set; } = null!;

        /// <summary>
        /// Describes the destination of connection monitor.
        /// </summary>
        [Output("destination")]
        public Output<Outputs.ConnectionMonitorDestinationResponse> Destination { get; private set; } = null!;

        [Output("etag")]
        public Output<string?> Etag { get; private set; } = null!;

        /// <summary>
        /// Connection monitor location.
        /// </summary>
        [Output("location")]
        public Output<string?> Location { get; private set; } = null!;

        /// <summary>
        /// Monitoring interval in seconds.
        /// </summary>
        [Output("monitoringIntervalInSeconds")]
        public Output<int?> MonitoringIntervalInSeconds { get; private set; } = null!;

        /// <summary>
        /// The monitoring status of the connection monitor.
        /// </summary>
        [Output("monitoringStatus")]
        public Output<string?> MonitoringStatus { get; private set; } = null!;

        /// <summary>
        /// Name of the connection monitor.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The provisioning state of the connection monitor.
        /// </summary>
        [Output("provisioningState")]
        public Output<string?> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// Describes the source of connection monitor.
        /// </summary>
        [Output("source")]
        public Output<Outputs.ConnectionMonitorSourceResponse> Source { get; private set; } = null!;

        /// <summary>
        /// The date and time when the connection monitor was started.
        /// </summary>
        [Output("startTime")]
        public Output<string?> StartTime { get; private set; } = null!;

        /// <summary>
        /// Connection monitor tags.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// Connection monitor type.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a ConnectionMonitor resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ConnectionMonitor(string name, ConnectionMonitorArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:network/v20181001:ConnectionMonitor", name, args ?? new ConnectionMonitorArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ConnectionMonitor(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:network/v20181001:ConnectionMonitor", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:network/latest:ConnectionMonitor"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20171001:ConnectionMonitor"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20171101:ConnectionMonitor"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180101:ConnectionMonitor"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180201:ConnectionMonitor"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180401:ConnectionMonitor"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180601:ConnectionMonitor"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180701:ConnectionMonitor"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180801:ConnectionMonitor"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20181101:ConnectionMonitor"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20181201:ConnectionMonitor"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190201:ConnectionMonitor"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190401:ConnectionMonitor"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190601:ConnectionMonitor"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190701:ConnectionMonitor"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190801:ConnectionMonitor"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190901:ConnectionMonitor"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20191101:ConnectionMonitor"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20191201:ConnectionMonitor"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200301:ConnectionMonitor"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200401:ConnectionMonitor"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200501:ConnectionMonitor"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200601:ConnectionMonitor"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing ConnectionMonitor resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ConnectionMonitor Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new ConnectionMonitor(name, id, options);
        }
    }

    public sealed class ConnectionMonitorArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Determines if the connection monitor will start automatically once created.
        /// </summary>
        [Input("autoStart")]
        public Input<bool>? AutoStart { get; set; }

        /// <summary>
        /// The name of the connection monitor.
        /// </summary>
        [Input("connectionMonitorName", required: true)]
        public Input<string> ConnectionMonitorName { get; set; } = null!;

        /// <summary>
        /// Describes the destination of connection monitor.
        /// </summary>
        [Input("destination", required: true)]
        public Input<Inputs.ConnectionMonitorDestinationArgs> Destination { get; set; } = null!;

        /// <summary>
        /// Connection monitor location.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Monitoring interval in seconds.
        /// </summary>
        [Input("monitoringIntervalInSeconds")]
        public Input<int>? MonitoringIntervalInSeconds { get; set; }

        /// <summary>
        /// The name of the Network Watcher resource.
        /// </summary>
        [Input("networkWatcherName", required: true)]
        public Input<string> NetworkWatcherName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group containing Network Watcher.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Describes the source of connection monitor.
        /// </summary>
        [Input("source", required: true)]
        public Input<Inputs.ConnectionMonitorSourceArgs> Source { get; set; } = null!;

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Connection monitor tags.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public ConnectionMonitorArgs()
        {
        }
    }
}