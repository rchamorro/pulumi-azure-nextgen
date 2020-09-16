import * as pulumi from "@pulumi/pulumi";
import * as outputs from "../../types/output";
export declare function getVolume(args: GetVolumeArgs, opts?: pulumi.InvokeOptions): Promise<GetVolumeResult>;
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
     * DataProtection volume, can have a replication object
     */
    readonly dataProtection?: outputs.netapp.v20190801.VolumePropertiesResponseDataProtection;
    /**
     * Set of export policy rules
     */
    readonly exportPolicy?: outputs.netapp.v20190801.VolumePropertiesResponseExportPolicy;
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
    readonly mountTargets?: outputs.netapp.v20190801.MountTargetPropertiesResponse[];
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
     * UUID v4 or resource identifier used to identify the Snapshot.
     */
    readonly snapshotId?: string;
    /**
     * The Azure Resource URI for a delegated subnet. Must have the delegation Microsoft.NetApp/volumes
     */
    readonly subnetId: string;
    /**
     * Resource tags
     */
    readonly tags?: {
        [key: string]: string;
    };
    /**
     * Resource type
     */
    readonly type: string;
    /**
     * Maximum storage quota allowed for a file system in bytes. This is a soft quota used for alerting only. Minimum size is 100 GiB. Upper limit is 100TiB. Specified in bytes.
     */
    readonly usageThreshold: number;
    /**
     * What type of volume is this
     */
    readonly volumeType?: string;
}