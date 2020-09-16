import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
/**
 * Describes a Machine Extension.
 */
export declare class MachineExtension extends pulumi.CustomResource {
    /**
     * Get an existing MachineExtension resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): MachineExtension;
    /**
     * Returns true if the given object is an instance of MachineExtension.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    static isInstance(obj: any): obj is MachineExtension;
    /**
     * Indicates whether the extension should use a newer minor version if one is available at deployment time. Once deployed, however, the extension will not upgrade minor versions unless redeployed, even with this property set to true.
     */
    readonly autoUpgradeMinorVersion: pulumi.Output<boolean | undefined>;
    /**
     * How the extension handler should be forced to update even if the extension configuration has not changed.
     */
    readonly forceUpdateTag: pulumi.Output<string | undefined>;
    /**
     * The machine extension instance view.
     */
    readonly instanceView: pulumi.Output<outputs.hybridcompute.v20200802.MachineExtensionPropertiesResponseInstanceView | undefined>;
    /**
     * The geo-location where the resource lives
     */
    readonly location: pulumi.Output<string>;
    /**
     * The name of the resource
     */
    readonly name: pulumi.Output<string>;
    /**
     * The extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected settings at all.
     */
    readonly protectedSettings: pulumi.Output<{
        [key: string]: any;
    } | undefined>;
    /**
     * The provisioning state, which only appears in the response.
     */
    readonly provisioningState: pulumi.Output<string>;
    /**
     * The name of the extension handler publisher.
     */
    readonly publisher: pulumi.Output<string | undefined>;
    /**
     * Json formatted public settings for the extension.
     */
    readonly settings: pulumi.Output<{
        [key: string]: any;
    } | undefined>;
    /**
     * Resource tags.
     */
    readonly tags: pulumi.Output<{
        [key: string]: string;
    } | undefined>;
    /**
     * The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts.
     */
    readonly type: pulumi.Output<string>;
    /**
     * Specifies the version of the script handler.
     */
    readonly typeHandlerVersion: pulumi.Output<string | undefined>;
    /**
     * Create a MachineExtension resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: MachineExtensionArgs, opts?: pulumi.CustomResourceOptions);
    constructor(name: string, state: undefined, opts: pulumi.CustomResourceOptions);
}
/**
 * The set of arguments for constructing a MachineExtension resource.
 */
export interface MachineExtensionArgs {
    /**
     * Indicates whether the extension should use a newer minor version if one is available at deployment time. Once deployed, however, the extension will not upgrade minor versions unless redeployed, even with this property set to true.
     */
    readonly autoUpgradeMinorVersion?: pulumi.Input<boolean>;
    /**
     * The name of the machine extension.
     */
    readonly extensionName: pulumi.Input<string>;
    /**
     * How the extension handler should be forced to update even if the extension configuration has not changed.
     */
    readonly forceUpdateTag?: pulumi.Input<string>;
    /**
     * The machine extension instance view.
     */
    readonly instanceView?: pulumi.Input<inputs.hybridcompute.v20200802.MachineExtensionPropertiesInstanceView>;
    /**
     * The geo-location where the resource lives
     */
    readonly location: pulumi.Input<string>;
    /**
     * The name of the machine where the extension should be created or updated.
     */
    readonly name: pulumi.Input<string>;
    /**
     * The extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected settings at all.
     */
    readonly protectedSettings?: pulumi.Input<{
        [key: string]: any;
    }>;
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
    readonly settings?: pulumi.Input<{
        [key: string]: any;
    }>;
    /**
     * Resource tags.
     */
    readonly tags?: pulumi.Input<{
        [key: string]: pulumi.Input<string>;
    }>;
    /**
     * Specifies the type of the extension; an example is "CustomScriptExtension".
     */
    readonly type?: pulumi.Input<string>;
    /**
     * Specifies the version of the script handler.
     */
    readonly typeHandlerVersion?: pulumi.Input<string>;
}