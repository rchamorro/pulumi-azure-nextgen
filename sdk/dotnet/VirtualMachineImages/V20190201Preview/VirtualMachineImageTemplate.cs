// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.VirtualMachineImages.V20190201Preview
{
    [AzureNextGenResourceType("azure-nextgen:virtualmachineimages/v20190201preview:VirtualMachineImageTemplate")]
    public partial class VirtualMachineImageTemplate : Pulumi.CustomResource
    {
        /// <summary>
        /// Specifies the properties used to describe the customization steps of the image, like Image source etc
        /// </summary>
        [Output("customize")]
        public Output<ImmutableArray<Union<Outputs.ImageTemplatePowerShellCustomizerResponse, Union<Outputs.ImageTemplateRestartCustomizerResponse, Outputs.ImageTemplateShellCustomizerResponse>>>> Customize { get; private set; } = null!;

        /// <summary>
        /// The distribution targets where the image output needs to go to.
        /// </summary>
        [Output("distribute")]
        public Output<ImmutableArray<Union<Outputs.ImageTemplateManagedImageDistributorResponse, Union<Outputs.ImageTemplateSharedImageDistributorResponse, Outputs.ImageTemplateVhdDistributorResponse>>>> Distribute { get; private set; } = null!;

        /// <summary>
        /// State of 'run' that is currently executing or was last executed.
        /// </summary>
        [Output("lastRunStatus")]
        public Output<Outputs.ImageTemplateLastRunStatusResponse> LastRunStatus { get; private set; } = null!;

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
        /// Provisioning error, if any
        /// </summary>
        [Output("provisioningError")]
        public Output<Outputs.ProvisioningErrorResponse> ProvisioningError { get; private set; } = null!;

        /// <summary>
        /// Provisioning state of the resource
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// Specifies the properties used to describe the source image.
        /// </summary>
        [Output("source")]
        public Output<Union<Outputs.ImageTemplateIsoSourceResponse, Union<Outputs.ImageTemplateManagedImageSourceResponse, Outputs.ImageTemplatePlatformImageSourceResponse>>> Source { get; private set; } = null!;

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
        /// Create a VirtualMachineImageTemplate resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public VirtualMachineImageTemplate(string name, VirtualMachineImageTemplateArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:virtualmachineimages/v20190201preview:VirtualMachineImageTemplate", name, args ?? new VirtualMachineImageTemplateArgs(), MakeResourceOptions(options, ""))
        {
        }

        private VirtualMachineImageTemplate(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:virtualmachineimages/v20190201preview:VirtualMachineImageTemplate", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:virtualmachineimages/latest:VirtualMachineImageTemplate"},
                    new Pulumi.Alias { Type = "azure-nextgen:virtualmachineimages/v20180201preview:VirtualMachineImageTemplate"},
                    new Pulumi.Alias { Type = "azure-nextgen:virtualmachineimages/v20190501preview:VirtualMachineImageTemplate"},
                    new Pulumi.Alias { Type = "azure-nextgen:virtualmachineimages/v20200214:VirtualMachineImageTemplate"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing VirtualMachineImageTemplate resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static VirtualMachineImageTemplate Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new VirtualMachineImageTemplate(name, id, options);
        }
    }

    public sealed class VirtualMachineImageTemplateArgs : Pulumi.ResourceArgs
    {
        [Input("customize")]
        private InputList<Union<Inputs.ImageTemplatePowerShellCustomizerArgs, Union<Inputs.ImageTemplateRestartCustomizerArgs, Inputs.ImageTemplateShellCustomizerArgs>>>? _customize;

        /// <summary>
        /// Specifies the properties used to describe the customization steps of the image, like Image source etc
        /// </summary>
        public InputList<Union<Inputs.ImageTemplatePowerShellCustomizerArgs, Union<Inputs.ImageTemplateRestartCustomizerArgs, Inputs.ImageTemplateShellCustomizerArgs>>> Customize
        {
            get => _customize ?? (_customize = new InputList<Union<Inputs.ImageTemplatePowerShellCustomizerArgs, Union<Inputs.ImageTemplateRestartCustomizerArgs, Inputs.ImageTemplateShellCustomizerArgs>>>());
            set => _customize = value;
        }

        [Input("distribute", required: true)]
        private InputList<Union<Inputs.ImageTemplateManagedImageDistributorArgs, Union<Inputs.ImageTemplateSharedImageDistributorArgs, Inputs.ImageTemplateVhdDistributorArgs>>>? _distribute;

        /// <summary>
        /// The distribution targets where the image output needs to go to.
        /// </summary>
        public InputList<Union<Inputs.ImageTemplateManagedImageDistributorArgs, Union<Inputs.ImageTemplateSharedImageDistributorArgs, Inputs.ImageTemplateVhdDistributorArgs>>> Distribute
        {
            get => _distribute ?? (_distribute = new InputList<Union<Inputs.ImageTemplateManagedImageDistributorArgs, Union<Inputs.ImageTemplateSharedImageDistributorArgs, Inputs.ImageTemplateVhdDistributorArgs>>>());
            set => _distribute = value;
        }

        /// <summary>
        /// The name of the image Template
        /// </summary>
        [Input("imageTemplateName", required: true)]
        public Input<string> ImageTemplateName { get; set; } = null!;

        /// <summary>
        /// Resource location
        /// </summary>
        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Specifies the properties used to describe the source image.
        /// </summary>
        [Input("source", required: true)]
        public InputUnion<Inputs.ImageTemplateIsoSourceArgs, InputUnion<Inputs.ImageTemplateManagedImageSourceArgs, Inputs.ImageTemplatePlatformImageSourceArgs>> Source { get; set; } = null!;

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

        public VirtualMachineImageTemplateArgs()
        {
        }
    }
}
