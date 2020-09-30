// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

/**
 * Describes a Virtual Machine Extension.
 */
export class VirtualMachineScaleSetVMExtension extends pulumi.CustomResource {
    /**
     * Get an existing VirtualMachineScaleSetVMExtension resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): VirtualMachineScaleSetVMExtension {
        return new VirtualMachineScaleSetVMExtension(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:compute/v20190701:VirtualMachineScaleSetVMExtension';

    /**
     * Returns true if the given object is an instance of VirtualMachineScaleSetVMExtension.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is VirtualMachineScaleSetVMExtension {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === VirtualMachineScaleSetVMExtension.__pulumiType;
    }

    /**
     * Indicates whether the extension should use a newer minor version if one is available at deployment time. Once deployed, however, the extension will not upgrade minor versions unless redeployed, even with this property set to true.
     */
    public readonly autoUpgradeMinorVersion!: pulumi.Output<boolean | undefined>;
    /**
     * How the extension handler should be forced to update even if the extension configuration has not changed.
     */
    public readonly forceUpdateTag!: pulumi.Output<string | undefined>;
    /**
     * The virtual machine extension instance view.
     */
    public readonly instanceView!: pulumi.Output<outputs.compute.v20190701.VirtualMachineExtensionInstanceViewResponse | undefined>;
    /**
     * Resource location
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * Resource name
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected settings at all.
     */
    public readonly protectedSettings!: pulumi.Output<any | undefined>;
    /**
     * The provisioning state, which only appears in the response.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * The name of the extension handler publisher.
     */
    public readonly publisher!: pulumi.Output<string | undefined>;
    /**
     * Json formatted public settings for the extension.
     */
    public readonly settings!: pulumi.Output<any | undefined>;
    /**
     * Resource tags
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Resource type
     */
    public readonly type!: pulumi.Output<string>;
    /**
     * Specifies the version of the script handler.
     */
    public readonly typeHandlerVersion!: pulumi.Output<string | undefined>;

    /**
     * Create a VirtualMachineScaleSetVMExtension resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: VirtualMachineScaleSetVMExtensionArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.instanceId === undefined) {
                throw new Error("Missing required property 'instanceId'");
            }
            if (!args || args.location === undefined) {
                throw new Error("Missing required property 'location'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.vmExtensionName === undefined) {
                throw new Error("Missing required property 'vmExtensionName'");
            }
            if (!args || args.vmScaleSetName === undefined) {
                throw new Error("Missing required property 'vmScaleSetName'");
            }
            inputs["autoUpgradeMinorVersion"] = args ? args.autoUpgradeMinorVersion : undefined;
            inputs["forceUpdateTag"] = args ? args.forceUpdateTag : undefined;
            inputs["instanceId"] = args ? args.instanceId : undefined;
            inputs["instanceView"] = args ? args.instanceView : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["protectedSettings"] = args ? args.protectedSettings : undefined;
            inputs["publisher"] = args ? args.publisher : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["settings"] = args ? args.settings : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["type"] = args ? args.type : undefined;
            inputs["typeHandlerVersion"] = args ? args.typeHandlerVersion : undefined;
            inputs["vmExtensionName"] = args ? args.vmExtensionName : undefined;
            inputs["vmScaleSetName"] = args ? args.vmScaleSetName : undefined;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
        } else {
            inputs["autoUpgradeMinorVersion"] = undefined /*out*/;
            inputs["forceUpdateTag"] = undefined /*out*/;
            inputs["instanceView"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["protectedSettings"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["publisher"] = undefined /*out*/;
            inputs["settings"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["typeHandlerVersion"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:compute/latest:VirtualMachineScaleSetVMExtension" }, { type: "azure-nextgen:compute/v20191201:VirtualMachineScaleSetVMExtension" }, { type: "azure-nextgen:compute/v20200601:VirtualMachineScaleSetVMExtension" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(VirtualMachineScaleSetVMExtension.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a VirtualMachineScaleSetVMExtension resource.
 */
export interface VirtualMachineScaleSetVMExtensionArgs {
    /**
     * Indicates whether the extension should use a newer minor version if one is available at deployment time. Once deployed, however, the extension will not upgrade minor versions unless redeployed, even with this property set to true.
     */
    readonly autoUpgradeMinorVersion?: pulumi.Input<boolean>;
    /**
     * How the extension handler should be forced to update even if the extension configuration has not changed.
     */
    readonly forceUpdateTag?: pulumi.Input<string>;
    /**
     * The instance ID of the virtual machine.
     */
    readonly instanceId: pulumi.Input<string>;
    /**
     * The virtual machine extension instance view.
     */
    readonly instanceView?: pulumi.Input<inputs.compute.v20190701.VirtualMachineExtensionInstanceView>;
    /**
     * Resource location
     */
    readonly location: pulumi.Input<string>;
    /**
     * The extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected settings at all.
     */
    readonly protectedSettings?: any;
    /**
     * The name of the extension handler publisher.
     */
    readonly publisher?: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Json formatted public settings for the extension.
     */
    readonly settings?: any;
    /**
     * Resource tags
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Specifies the type of the extension; an example is "CustomScriptExtension".
     */
    readonly type?: pulumi.Input<string>;
    /**
     * Specifies the version of the script handler.
     */
    readonly typeHandlerVersion?: pulumi.Input<string>;
    /**
     * The name of the virtual machine extension.
     */
    readonly vmExtensionName: pulumi.Input<string>;
    /**
     * The name of the VM scale set.
     */
    readonly vmScaleSetName: pulumi.Input<string>;
}
