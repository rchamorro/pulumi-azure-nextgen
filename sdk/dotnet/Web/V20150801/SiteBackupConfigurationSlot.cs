// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20150801
{
    /// <summary>
    /// Description of a backup which will be performed
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:web/v20150801:SiteBackupConfigurationSlot")]
    public partial class SiteBackupConfigurationSlot : Pulumi.CustomResource
    {
        /// <summary>
        /// Schedule for the backup if it is executed periodically
        /// </summary>
        [Output("backupSchedule")]
        public Output<Outputs.BackupScheduleResponse?> BackupSchedule { get; private set; } = null!;

        /// <summary>
        /// Databases included in the backup
        /// </summary>
        [Output("databases")]
        public Output<ImmutableArray<Outputs.DatabaseBackupSettingResponse>> Databases { get; private set; } = null!;

        /// <summary>
        /// True if the backup schedule is enabled (must be included in that case), false if the backup schedule should be disabled
        /// </summary>
        [Output("enabled")]
        public Output<bool?> Enabled { get; private set; } = null!;

        /// <summary>
        /// Kind of resource
        /// </summary>
        [Output("kind")]
        public Output<string?> Kind { get; private set; } = null!;

        /// <summary>
        /// Resource Location
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// Resource Name
        /// </summary>
        [Output("name")]
        public Output<string?> Name { get; private set; } = null!;

        /// <summary>
        /// SAS URL to the container
        /// </summary>
        [Output("storageAccountUrl")]
        public Output<string?> StorageAccountUrl { get; private set; } = null!;

        /// <summary>
        /// Resource tags
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// Resource type
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a SiteBackupConfigurationSlot resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public SiteBackupConfigurationSlot(string name, SiteBackupConfigurationSlotArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:web/v20150801:SiteBackupConfigurationSlot", name, args ?? new SiteBackupConfigurationSlotArgs(), MakeResourceOptions(options, ""))
        {
        }

        private SiteBackupConfigurationSlot(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:web/v20150801:SiteBackupConfigurationSlot", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:web/latest:SiteBackupConfigurationSlot"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20160801:SiteBackupConfigurationSlot"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20180201:SiteBackupConfigurationSlot"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20181101:SiteBackupConfigurationSlot"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20190801:SiteBackupConfigurationSlot"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20200601:SiteBackupConfigurationSlot"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20200901:SiteBackupConfigurationSlot"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing SiteBackupConfigurationSlot resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static SiteBackupConfigurationSlot Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new SiteBackupConfigurationSlot(name, id, options);
        }
    }

    public sealed class SiteBackupConfigurationSlotArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Schedule for the backup if it is executed periodically
        /// </summary>
        [Input("backupSchedule")]
        public Input<Inputs.BackupScheduleArgs>? BackupSchedule { get; set; }

        [Input("databases")]
        private InputList<Inputs.DatabaseBackupSettingArgs>? _databases;

        /// <summary>
        /// Databases included in the backup
        /// </summary>
        public InputList<Inputs.DatabaseBackupSettingArgs> Databases
        {
            get => _databases ?? (_databases = new InputList<Inputs.DatabaseBackupSettingArgs>());
            set => _databases = value;
        }

        /// <summary>
        /// True if the backup schedule is enabled (must be included in that case), false if the backup schedule should be disabled
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// Resource Id
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// Kind of resource
        /// </summary>
        [Input("kind")]
        public Input<string>? Kind { get; set; }

        /// <summary>
        /// Resource Location
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Resource Name
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Name of resource group
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Name of web app slot. If not specified then will default to production slot.
        /// </summary>
        [Input("slot", required: true)]
        public Input<string> Slot { get; set; } = null!;

        /// <summary>
        /// SAS URL to the container
        /// </summary>
        [Input("storageAccountUrl")]
        public Input<string>? StorageAccountUrl { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Resource tags
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        /// <summary>
        /// Resource type
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public SiteBackupConfigurationSlotArgs()
        {
        }
    }
}
