// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getProtectionPolicy(args: GetProtectionPolicyArgs, opts?: pulumi.InvokeOptions): Promise<GetProtectionPolicyResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:recoveryservices/v20160601:getProtectionPolicy", {
        "policyName": args.policyName,
        "resourceGroupName": args.resourceGroupName,
        "vaultName": args.vaultName,
    }, opts);
}

export interface GetProtectionPolicyArgs {
    /**
     * The backup policy name used in this GET operation.
     */
    readonly policyName: string;
    /**
     * The name of the resource group associated with the Recovery Services vault.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the Recovery Services vault.
     */
    readonly vaultName: string;
}

/**
 * The base class for backup policy. Workload-specific backup policies are derived from this class.
 */
export interface GetProtectionPolicyResult {
    /**
     * Optional ETag.
     */
    readonly eTag?: string;
    /**
     * Resource location.
     */
    readonly location?: string;
    /**
     * Resource name associated with the resource.
     */
    readonly name?: string;
    /**
     * The base class for a backup policy. Workload-specific backup policies are derived from this class.
     */
    readonly properties: outputs.recoveryservices.v20160601.AzureIaaSVMProtectionPolicyResponse | outputs.recoveryservices.v20160601.AzureSqlProtectionPolicyResponse | outputs.recoveryservices.v20160601.MabProtectionPolicyResponse;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type represents the complete path of the form Namespace/ResourceType/ResourceType/...
     */
    readonly type?: string;
}
