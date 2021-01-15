// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

export function getProtectionContainer(args: GetProtectionContainerArgs, opts?: pulumi.InvokeOptions): Promise<GetProtectionContainerResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:recoveryservices/v20201001:getProtectionContainer", {
        "containerName": args.containerName,
        "fabricName": args.fabricName,
        "resourceGroupName": args.resourceGroupName,
        "vaultName": args.vaultName,
    }, opts);
}

export interface GetProtectionContainerArgs {
    /**
     * Name of the container whose details need to be fetched.
     */
    readonly containerName: string;
    /**
     * Name of the fabric where the container belongs.
     */
    readonly fabricName: string;
    /**
     * The name of the resource group where the recovery services vault is present.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the recovery services vault.
     */
    readonly vaultName: string;
}

/**
 * Base class for container with backup items. Containers with specific workloads are derived from this class.
 */
export interface GetProtectionContainerResult {
    /**
     * Optional ETag.
     */
    readonly eTag?: string;
    /**
     * Resource Id represents the complete path to the resource.
     */
    readonly id: string;
    /**
     * Resource location.
     */
    readonly location?: string;
    /**
     * Resource name associated with the resource.
     */
    readonly name: string;
    /**
     * ProtectionContainerResource properties
     */
    readonly properties: outputs.recoveryservices.v20201001.AzureBackupServerContainerResponse | outputs.recoveryservices.v20201001.AzureIaaSClassicComputeVMContainerResponse | outputs.recoveryservices.v20201001.AzureIaaSComputeVMContainerResponse | outputs.recoveryservices.v20201001.AzureSQLAGWorkloadContainerProtectionContainerResponse | outputs.recoveryservices.v20201001.AzureSqlContainerResponse | outputs.recoveryservices.v20201001.AzureStorageContainerResponse | outputs.recoveryservices.v20201001.AzureVMAppContainerProtectionContainerResponse | outputs.recoveryservices.v20201001.AzureWorkloadContainerResponse | outputs.recoveryservices.v20201001.DpmContainerResponse | outputs.recoveryservices.v20201001.GenericContainerResponse | outputs.recoveryservices.v20201001.IaaSVMContainerResponse | outputs.recoveryservices.v20201001.MabContainerResponse;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type represents the complete path of the form Namespace/ResourceType/ResourceType/...
     */
    readonly type: string;
}
