import * as pulumi from "@pulumi/pulumi";
import * as outputs from "../../types/output";
export declare function getDevice(args: GetDeviceArgs, opts?: pulumi.InvokeOptions): Promise<GetDeviceResult>;
export interface GetDeviceArgs {
    /**
     * The device name.
     */
    readonly deviceName: string;
    /**
     * The resource group name.
     */
    readonly resourceGroupName: string;
}
/**
 * The Data Box Edge/Gateway device.
 */
export interface GetDeviceResult {
    /**
     * Type of compute roles configured.
     */
    readonly configuredRoleTypes: string[];
    /**
     * The Data Box Edge/Gateway device culture.
     */
    readonly culture: string;
    /**
     * The status of the Data Box Edge/Gateway device.
     */
    readonly dataBoxEdgeDeviceStatus?: string;
    /**
     * The Description of the Data Box Edge/Gateway device.
     */
    readonly description?: string;
    /**
     * The device software version number of the device (eg: 1.2.18105.6).
     */
    readonly deviceHcsVersion: string;
    /**
     * The Data Box Edge/Gateway device local capacity in MB.
     */
    readonly deviceLocalCapacity: number;
    /**
     * The Data Box Edge/Gateway device model.
     */
    readonly deviceModel: string;
    /**
     * The Data Box Edge/Gateway device software version.
     */
    readonly deviceSoftwareVersion: string;
    /**
     * The type of the Data Box Edge/Gateway device.
     */
    readonly deviceType: string;
    /**
     * The etag for the devices.
     */
    readonly etag?: string;
    /**
     * The Data Box Edge/Gateway device name.
     */
    readonly friendlyName?: string;
    /**
     * The location of the device. This is a supported and registered Azure geographical region (for example, West US, East US, or Southeast Asia). The geographical region of a device cannot be changed once it is created, but if an identical geographical region is specified on update, the request will succeed.
     */
    readonly location: string;
    /**
     * The description of the Data Box Edge/Gateway device model.
     */
    readonly modelDescription?: string;
    /**
     * The object name.
     */
    readonly name: string;
    /**
     * The number of nodes in the cluster.
     */
    readonly nodeCount: number;
    /**
     * The Serial Number of Data Box Edge/Gateway device.
     */
    readonly serialNumber: string;
    /**
     * The SKU type.
     */
    readonly sku?: outputs.databoxedge.v20190701.SkuResponse;
    /**
     * The list of tags that describe the device. These tags can be used to view and group this device (across resource groups).
     */
    readonly tags?: {
        [key: string]: string;
    };
    /**
     * The Data Box Edge/Gateway device timezone.
     */
    readonly timeZone: string;
    /**
     * The hierarchical type of the object.
     */
    readonly type: string;
}