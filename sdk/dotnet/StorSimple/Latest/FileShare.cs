// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.StorSimple.Latest
{
    /// <summary>
    /// The File Share.
    /// Latest API Version: 2016-10-01.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:storsimple/latest:FileShare")]
    public partial class FileShare : Pulumi.CustomResource
    {
        /// <summary>
        /// The user/group who will have full permission in this share. Active directory email address. Example: xyz@contoso.com or Contoso\xyz.
        /// </summary>
        [Output("adminUser")]
        public Output<string> AdminUser { get; private set; } = null!;

        /// <summary>
        /// The data policy
        /// </summary>
        [Output("dataPolicy")]
        public Output<string> DataPolicy { get; private set; } = null!;

        /// <summary>
        /// Description for file share
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// The local used capacity in Bytes.
        /// </summary>
        [Output("localUsedCapacityInBytes")]
        public Output<double> LocalUsedCapacityInBytes { get; private set; } = null!;

        /// <summary>
        /// The monitoring status
        /// </summary>
        [Output("monitoringStatus")]
        public Output<string> MonitoringStatus { get; private set; } = null!;

        /// <summary>
        /// The name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The total provisioned capacity in Bytes
        /// </summary>
        [Output("provisionedCapacityInBytes")]
        public Output<double> ProvisionedCapacityInBytes { get; private set; } = null!;

        /// <summary>
        /// The Share Status
        /// </summary>
        [Output("shareStatus")]
        public Output<string> ShareStatus { get; private set; } = null!;

        /// <summary>
        /// The type.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        /// <summary>
        /// The used capacity in Bytes.
        /// </summary>
        [Output("usedCapacityInBytes")]
        public Output<double> UsedCapacityInBytes { get; private set; } = null!;


        /// <summary>
        /// Create a FileShare resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public FileShare(string name, FileShareArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:storsimple/latest:FileShare", name, args ?? new FileShareArgs(), MakeResourceOptions(options, ""))
        {
        }

        private FileShare(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:storsimple/latest:FileShare", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:storsimple/v20161001:FileShare"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing FileShare resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static FileShare Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new FileShare(name, id, options);
        }
    }

    public sealed class FileShareArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The user/group who will have full permission in this share. Active directory email address. Example: xyz@contoso.com or Contoso\xyz.
        /// </summary>
        [Input("adminUser", required: true)]
        public Input<string> AdminUser { get; set; } = null!;

        /// <summary>
        /// The data policy
        /// </summary>
        [Input("dataPolicy", required: true)]
        public Input<Pulumi.AzureNextGen.StorSimple.Latest.DataPolicy> DataPolicy { get; set; } = null!;

        /// <summary>
        /// Description for file share
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The device name.
        /// </summary>
        [Input("deviceName", required: true)]
        public Input<string> DeviceName { get; set; } = null!;

        /// <summary>
        /// The file server name.
        /// </summary>
        [Input("fileServerName", required: true)]
        public Input<string> FileServerName { get; set; } = null!;

        /// <summary>
        /// The manager name
        /// </summary>
        [Input("managerName", required: true)]
        public Input<string> ManagerName { get; set; } = null!;

        /// <summary>
        /// The monitoring status
        /// </summary>
        [Input("monitoringStatus", required: true)]
        public Input<Pulumi.AzureNextGen.StorSimple.Latest.MonitoringStatus> MonitoringStatus { get; set; } = null!;

        /// <summary>
        /// The total provisioned capacity in Bytes
        /// </summary>
        [Input("provisionedCapacityInBytes", required: true)]
        public Input<double> ProvisionedCapacityInBytes { get; set; } = null!;

        /// <summary>
        /// The resource group name
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The file share name.
        /// </summary>
        [Input("shareName", required: true)]
        public Input<string> ShareName { get; set; } = null!;

        /// <summary>
        /// The Share Status
        /// </summary>
        [Input("shareStatus", required: true)]
        public Input<Pulumi.AzureNextGen.StorSimple.Latest.ShareStatus> ShareStatus { get; set; } = null!;

        public FileShareArgs()
        {
        }
    }
}
