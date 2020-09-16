import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
/**
 * Image template is an ARM resource managed by Microsoft.VirtualMachineImages provider
 */
export declare class VirtualMachineImageTemplate extends pulumi.CustomResource {
    /**
     * Get an existing VirtualMachineImageTemplate resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): VirtualMachineImageTemplate;
    /**
     * Returns true if the given object is an instance of VirtualMachineImageTemplate.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    static isInstance(obj: any): obj is VirtualMachineImageTemplate;
    /**
     * Maximum duration to wait while building the image template. Omit or specify 0 to use the default (4 hours).
     */
    readonly buildTimeoutInMinutes: pulumi.Output<number | undefined>;
    /**
     * Specifies the properties used to describe the customization steps of the image, like Image source etc
     */
    readonly customize: pulumi.Output<outputs.virtualmachineimages.v20200214.ImageTemplateCustomizerResponse[] | undefined>;
    /**
     * The distribution targets where the image output needs to go to.
     */
    readonly distribute: pulumi.Output<outputs.virtualmachineimages.v20200214.ImageTemplateDistributorResponse[]>;
    /**
     * The identity of the image template, if configured.
     */
    readonly identity: pulumi.Output<outputs.virtualmachineimages.v20200214.ImageTemplateIdentityResponse>;
    /**
     * State of 'run' that is currently executing or was last executed.
     */
    readonly lastRunStatus: pulumi.Output<outputs.virtualmachineimages.v20200214.ImageTemplateLastRunStatusResponse>;
    /**
     * Resource location
     */
    readonly location: pulumi.Output<string>;
    /**
     * Resource name
     */
    readonly name: pulumi.Output<string>;
    /**
     * Provisioning error, if any
     */
    readonly provisioningError: pulumi.Output<outputs.virtualmachineimages.v20200214.ProvisioningErrorResponse>;
    /**
     * Provisioning state of the resource
     */
    readonly provisioningState: pulumi.Output<string>;
    /**
     * Specifies the properties used to describe the source image.
     */
    readonly source: pulumi.Output<outputs.virtualmachineimages.v20200214.ImageTemplateSourceResponse>;
    /**
     * Resource tags
     */
    readonly tags: pulumi.Output<{
        [key: string]: string;
    } | undefined>;
    /**
     * Resource type
     */
    readonly type: pulumi.Output<string>;
    /**
     * Describes how virtual machine is set up to build images
     */
    readonly vmProfile: pulumi.Output<outputs.virtualmachineimages.v20200214.ImageTemplateVmProfileResponse | undefined>;
    /**
     * Create a VirtualMachineImageTemplate resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: VirtualMachineImageTemplateArgs, opts?: pulumi.CustomResourceOptions);
    constructor(name: string, state: undefined, opts: pulumi.CustomResourceOptions);
}
/**
 * The set of arguments for constructing a VirtualMachineImageTemplate resource.
 */
export interface VirtualMachineImageTemplateArgs {
    /**
     * Maximum duration to wait while building the image template. Omit or specify 0 to use the default (4 hours).
     */
    readonly buildTimeoutInMinutes?: pulumi.Input<number>;
    /**
     * Specifies the properties used to describe the customization steps of the image, like Image source etc
     */
    readonly customize?: pulumi.Input<pulumi.Input<inputs.virtualmachineimages.v20200214.ImageTemplateCustomizer>[]>;
    /**
     * The distribution targets where the image output needs to go to.
     */
    readonly distribute: pulumi.Input<pulumi.Input<inputs.virtualmachineimages.v20200214.ImageTemplateDistributor>[]>;
    /**
     * The identity of the image template, if configured.
     */
    readonly identity: pulumi.Input<inputs.virtualmachineimages.v20200214.ImageTemplateIdentity>;
    /**
     * The name of the image Template
     */
    readonly imageTemplateName: pulumi.Input<string>;
    /**
     * Resource location
     */
    readonly location: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Specifies the properties used to describe the source image.
     */
    readonly source: pulumi.Input<inputs.virtualmachineimages.v20200214.ImageTemplateSource>;
    /**
     * Resource tags
     */
    readonly tags?: pulumi.Input<{
        [key: string]: pulumi.Input<string>;
    }>;
    /**
     * Describes how virtual machine is set up to build images
     */
    readonly vmProfile?: pulumi.Input<inputs.virtualmachineimages.v20200214.ImageTemplateVmProfile>;
}