// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getVolume(args: GetVolumeArgs, opts?: pulumi.InvokeOptions): Promise<GetVolumeResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:netapp/v20190501:getVolume", {
        "accountName": args.accountName,
        "poolName": args.poolName,
        "resourceGroupName": args.resourceGroupName,
        "volumeName": args.volumeName,
    }, opts);
}

export interface GetVolumeArgs {
    /**
     * The name of the NetApp account
     */
    readonly accountName: string;
    /**
     * The name of the capacity pool
     */
    readonly poolName: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the volume
     */
    readonly volumeName: string;
}

/**
 * Volume resource
 */
export interface GetVolumeResult {
    /**
     * Unique Baremetal Tenant Identifier.
     */
    readonly baremetalTenantId: string;
    /**
     * A unique file path for the volume. Used when creating mount targets
     */
    readonly creationToken: string;
    /**
     * Set of export policy rules
     */
    readonly exportPolicy?: outputs.netapp.v20190501.VolumePropertiesResponseExportPolicy;
    /**
     * Unique FileSystem Identifier.
     */
    readonly fileSystemId: string;
    /**
     * Resource location
     */
    readonly location: string;
    /**
     * List of mount targets
     */
    readonly mountTargets?: outputs.netapp.v20190501.MountTargetPropertiesResponse[];
    /**
     * Resource name
     */
    readonly name: string;
    /**
     * Set of protocol types
     */
    readonly protocolTypes?: string[];
    /**
     * Azure lifecycle management
     */
    readonly provisioningState: string;
    /**
     * The service level of the file system
     */
    readonly serviceLevel?: string;
    /**
     * UUID v4 used to identify the Snapshot
     */
    readonly snapshotId?: string;
    /**
     * The Azure Resource URI for a delegated subnet. Must have the delegation Microsoft.NetApp/volumes
     */
    readonly subnetId: string;
    /**
     * Resource tags
     */
    readonly tags?: any;
    /**
     * Resource type
     */
    readonly type: string;
    /**
     * Maximum storage quota allowed for a file system in bytes. This is a soft quota used for alerting only. Minimum size is 100 GiB. Upper limit is 100TiB. Specified in bytes.
     */
    readonly usageThreshold: number;
}
