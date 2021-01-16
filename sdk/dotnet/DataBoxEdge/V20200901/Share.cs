// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataBoxEdge.V20200901
{
    /// <summary>
    /// Represents a share on the  Data Box Edge/Gateway device.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:databoxedge/v20200901:Share")]
    public partial class Share : Pulumi.CustomResource
    {
        /// <summary>
        /// Access protocol to be used by the share.
        /// </summary>
        [Output("accessProtocol")]
        public Output<string> AccessProtocol { get; private set; } = null!;

        /// <summary>
        /// Azure container mapping for the share.
        /// </summary>
        [Output("azureContainerInfo")]
        public Output<Outputs.AzureContainerInfoResponse?> AzureContainerInfo { get; private set; } = null!;

        /// <summary>
        /// List of IP addresses and corresponding access rights on the share(required for NFS protocol).
        /// </summary>
        [Output("clientAccessRights")]
        public Output<ImmutableArray<Outputs.ClientAccessRightResponse>> ClientAccessRights { get; private set; } = null!;

        /// <summary>
        /// Data policy of the share.
        /// </summary>
        [Output("dataPolicy")]
        public Output<string?> DataPolicy { get; private set; } = null!;

        /// <summary>
        /// Description for the share.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// Current monitoring status of the share.
        /// </summary>
        [Output("monitoringStatus")]
        public Output<string> MonitoringStatus { get; private set; } = null!;

        /// <summary>
        /// The object name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Details of the refresh job on this share.
        /// </summary>
        [Output("refreshDetails")]
        public Output<Outputs.RefreshDetailsResponse?> RefreshDetails { get; private set; } = null!;

        /// <summary>
        /// Share mount point to the role.
        /// </summary>
        [Output("shareMappings")]
        public Output<ImmutableArray<Outputs.MountPointMapResponse>> ShareMappings { get; private set; } = null!;

        /// <summary>
        /// Current status of the share.
        /// </summary>
        [Output("shareStatus")]
        public Output<string> ShareStatus { get; private set; } = null!;

        /// <summary>
        /// Share on ASE device
        /// </summary>
        [Output("systemData")]
        public Output<Outputs.SystemDataResponse> SystemData { get; private set; } = null!;

        /// <summary>
        /// The hierarchical type of the object.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        /// <summary>
        /// Mapping of users and corresponding access rights on the share (required for SMB protocol).
        /// </summary>
        [Output("userAccessRights")]
        public Output<ImmutableArray<Outputs.UserAccessRightResponse>> UserAccessRights { get; private set; } = null!;


        /// <summary>
        /// Create a Share resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Share(string name, ShareArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:databoxedge/v20200901:Share", name, args ?? new ShareArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Share(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:databoxedge/v20200901:Share", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:databoxedge/latest:Share"},
                    new Pulumi.Alias { Type = "azure-nextgen:databoxedge/v20190301:Share"},
                    new Pulumi.Alias { Type = "azure-nextgen:databoxedge/v20190701:Share"},
                    new Pulumi.Alias { Type = "azure-nextgen:databoxedge/v20190801:Share"},
                    new Pulumi.Alias { Type = "azure-nextgen:databoxedge/v20200501preview:Share"},
                    new Pulumi.Alias { Type = "azure-nextgen:databoxedge/v20200901preview:Share"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Share resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Share Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Share(name, id, options);
        }
    }

    public sealed class ShareArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Access protocol to be used by the share.
        /// </summary>
        [Input("accessProtocol", required: true)]
        public InputUnion<string, Pulumi.AzureNextGen.DataBoxEdge.V20200901.ShareAccessProtocol> AccessProtocol { get; set; } = null!;

        /// <summary>
        /// Azure container mapping for the share.
        /// </summary>
        [Input("azureContainerInfo")]
        public Input<Inputs.AzureContainerInfoArgs>? AzureContainerInfo { get; set; }

        [Input("clientAccessRights")]
        private InputList<Inputs.ClientAccessRightArgs>? _clientAccessRights;

        /// <summary>
        /// List of IP addresses and corresponding access rights on the share(required for NFS protocol).
        /// </summary>
        public InputList<Inputs.ClientAccessRightArgs> ClientAccessRights
        {
            get => _clientAccessRights ?? (_clientAccessRights = new InputList<Inputs.ClientAccessRightArgs>());
            set => _clientAccessRights = value;
        }

        /// <summary>
        /// Data policy of the share.
        /// </summary>
        [Input("dataPolicy")]
        public InputUnion<string, Pulumi.AzureNextGen.DataBoxEdge.V20200901.DataPolicy>? DataPolicy { get; set; }

        /// <summary>
        /// Description for the share.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The device name.
        /// </summary>
        [Input("deviceName", required: true)]
        public Input<string> DeviceName { get; set; } = null!;

        /// <summary>
        /// Current monitoring status of the share.
        /// </summary>
        [Input("monitoringStatus", required: true)]
        public InputUnion<string, Pulumi.AzureNextGen.DataBoxEdge.V20200901.MonitoringStatus> MonitoringStatus { get; set; } = null!;

        /// <summary>
        /// The share name.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Details of the refresh job on this share.
        /// </summary>
        [Input("refreshDetails")]
        public Input<Inputs.RefreshDetailsArgs>? RefreshDetails { get; set; }

        /// <summary>
        /// The resource group name.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Current status of the share.
        /// </summary>
        [Input("shareStatus", required: true)]
        public InputUnion<string, Pulumi.AzureNextGen.DataBoxEdge.V20200901.ShareStatus> ShareStatus { get; set; } = null!;

        [Input("userAccessRights")]
        private InputList<Inputs.UserAccessRightArgs>? _userAccessRights;

        /// <summary>
        /// Mapping of users and corresponding access rights on the share (required for SMB protocol).
        /// </summary>
        public InputList<Inputs.UserAccessRightArgs> UserAccessRights
        {
            get => _userAccessRights ?? (_userAccessRights = new InputList<Inputs.UserAccessRightArgs>());
            set => _userAccessRights = value;
        }

        public ShareArgs()
        {
        }
    }
}
