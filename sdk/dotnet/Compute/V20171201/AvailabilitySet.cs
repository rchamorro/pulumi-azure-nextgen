// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Compute.V20171201
{
    /// <summary>
    /// Specifies information about the availability set that the virtual machine should be assigned to. Virtual machines specified in the same availability set are allocated to different nodes to maximize availability. For more information about availability sets, see [Manage the availability of virtual machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-manage-availability?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json). &lt;br&gt;&lt;br&gt; For more information on Azure planned maintenance, see [Planned maintenance for virtual machines in Azure](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-planned-maintenance?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json) &lt;br&gt;&lt;br&gt; Currently, a VM can only be added to availability set at creation time. An existing VM cannot be added to an availability set.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:compute/v20171201:AvailabilitySet")]
    public partial class AvailabilitySet : Pulumi.CustomResource
    {
        /// <summary>
        /// Resource location
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// Resource name
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Fault Domain count.
        /// </summary>
        [Output("platformFaultDomainCount")]
        public Output<int?> PlatformFaultDomainCount { get; private set; } = null!;

        /// <summary>
        /// Update Domain count.
        /// </summary>
        [Output("platformUpdateDomainCount")]
        public Output<int?> PlatformUpdateDomainCount { get; private set; } = null!;

        /// <summary>
        /// Sku of the availability set
        /// </summary>
        [Output("sku")]
        public Output<Outputs.SkuResponse?> Sku { get; private set; } = null!;

        /// <summary>
        /// The resource status information.
        /// </summary>
        [Output("statuses")]
        public Output<ImmutableArray<Outputs.InstanceViewStatusResponse>> Statuses { get; private set; } = null!;

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
        /// A list of references to all virtual machines in the availability set.
        /// </summary>
        [Output("virtualMachines")]
        public Output<ImmutableArray<Outputs.SubResourceResponse>> VirtualMachines { get; private set; } = null!;


        /// <summary>
        /// Create a AvailabilitySet resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public AvailabilitySet(string name, AvailabilitySetArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:compute/v20171201:AvailabilitySet", name, args ?? new AvailabilitySetArgs(), MakeResourceOptions(options, ""))
        {
        }

        private AvailabilitySet(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:compute/v20171201:AvailabilitySet", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:compute/latest:AvailabilitySet"},
                    new Pulumi.Alias { Type = "azure-nextgen:compute/v20150615:AvailabilitySet"},
                    new Pulumi.Alias { Type = "azure-nextgen:compute/v20160330:AvailabilitySet"},
                    new Pulumi.Alias { Type = "azure-nextgen:compute/v20160430preview:AvailabilitySet"},
                    new Pulumi.Alias { Type = "azure-nextgen:compute/v20170330:AvailabilitySet"},
                    new Pulumi.Alias { Type = "azure-nextgen:compute/v20180401:AvailabilitySet"},
                    new Pulumi.Alias { Type = "azure-nextgen:compute/v20180601:AvailabilitySet"},
                    new Pulumi.Alias { Type = "azure-nextgen:compute/v20181001:AvailabilitySet"},
                    new Pulumi.Alias { Type = "azure-nextgen:compute/v20190301:AvailabilitySet"},
                    new Pulumi.Alias { Type = "azure-nextgen:compute/v20190701:AvailabilitySet"},
                    new Pulumi.Alias { Type = "azure-nextgen:compute/v20191201:AvailabilitySet"},
                    new Pulumi.Alias { Type = "azure-nextgen:compute/v20200601:AvailabilitySet"},
                    new Pulumi.Alias { Type = "azure-nextgen:compute/v20201201:AvailabilitySet"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing AvailabilitySet resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static AvailabilitySet Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new AvailabilitySet(name, id, options);
        }
    }

    public sealed class AvailabilitySetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the availability set.
        /// </summary>
        [Input("availabilitySetName", required: true)]
        public Input<string> AvailabilitySetName { get; set; } = null!;

        /// <summary>
        /// Resource location
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Fault Domain count.
        /// </summary>
        [Input("platformFaultDomainCount")]
        public Input<int>? PlatformFaultDomainCount { get; set; }

        /// <summary>
        /// Update Domain count.
        /// </summary>
        [Input("platformUpdateDomainCount")]
        public Input<int>? PlatformUpdateDomainCount { get; set; }

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Sku of the availability set
        /// </summary>
        [Input("sku")]
        public Input<Inputs.SkuArgs>? Sku { get; set; }

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

        [Input("virtualMachines")]
        private InputList<Inputs.SubResourceArgs>? _virtualMachines;

        /// <summary>
        /// A list of references to all virtual machines in the availability set.
        /// </summary>
        public InputList<Inputs.SubResourceArgs> VirtualMachines
        {
            get => _virtualMachines ?? (_virtualMachines = new InputList<Inputs.SubResourceArgs>());
            set => _virtualMachines = value;
        }

        public AvailabilitySetArgs()
        {
        }
    }
}
