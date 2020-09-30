// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getVirtualMachineExtension(args: GetVirtualMachineExtensionArgs, opts?: pulumi.InvokeOptions): Promise<GetVirtualMachineExtensionResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:compute/latest:getVirtualMachineExtension", {
        "expand": args.expand,
        "resourceGroupName": args.resourceGroupName,
        "vmExtensionName": args.vmExtensionName,
        "vmName": args.vmName,
    }, opts);
}

export interface GetVirtualMachineExtensionArgs {
    /**
     * The expand expression to apply on the operation.
     */
    readonly expand?: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the virtual machine extension.
     */
    readonly vmExtensionName: string;
    /**
     * The name of the virtual machine containing the extension.
     */
    readonly vmName: string;
}

/**
 * Describes a Virtual Machine Extension.
 */
export interface GetVirtualMachineExtensionResult {
    /**
     * Indicates whether the extension should use a newer minor version if one is available at deployment time. Once deployed, however, the extension will not upgrade minor versions unless redeployed, even with this property set to true.
     */
    readonly autoUpgradeMinorVersion?: boolean;
    /**
     * Indicates whether the extension should be automatically upgraded by the platform if there is a newer version of the extension available.
     */
    readonly enableAutomaticUpgrade?: boolean;
    /**
     * How the extension handler should be forced to update even if the extension configuration has not changed.
     */
    readonly forceUpdateTag?: string;
    /**
     * The virtual machine extension instance view.
     */
    readonly instanceView?: outputs.compute.latest.VirtualMachineExtensionInstanceViewResponse;
    /**
     * Resource location
     */
    readonly location: string;
    /**
     * Resource name
     */
    readonly name: string;
    /**
     * The extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected settings at all.
     */
    readonly protectedSettings?: any;
    /**
     * The provisioning state, which only appears in the response.
     */
    readonly provisioningState: string;
    /**
     * The name of the extension handler publisher.
     */
    readonly publisher?: string;
    /**
     * Json formatted public settings for the extension.
     */
    readonly settings?: any;
    /**
     * Resource tags
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type
     */
    readonly type: string;
    /**
     * Specifies the version of the script handler.
     */
    readonly typeHandlerVersion?: string;
}
