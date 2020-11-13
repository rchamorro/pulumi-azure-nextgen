// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getVault(args: GetVaultArgs, opts?: pulumi.InvokeOptions): Promise<GetVaultResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:keyvault/v20180214:getVault", {
        "resourceGroupName": args.resourceGroupName,
        "vaultName": args.vaultName,
    }, opts);
}

export interface GetVaultArgs {
    /**
     * The name of the Resource Group to which the vault belongs.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the vault.
     */
    readonly vaultName: string;
}

/**
 * Resource information with extended details.
 */
export interface GetVaultResult {
    /**
     * Azure location of the key vault resource.
     */
    readonly location?: string;
    /**
     * Name of the key vault resource.
     */
    readonly name: string;
    /**
     * Properties of the vault
     */
    readonly properties: outputs.keyvault.v20180214.VaultPropertiesResponse;
    /**
     * Tags assigned to the key vault resource.
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type of the key vault resource.
     */
    readonly type: string;
}
