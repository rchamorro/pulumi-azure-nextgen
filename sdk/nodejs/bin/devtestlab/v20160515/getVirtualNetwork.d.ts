import * as pulumi from "@pulumi/pulumi";
import * as outputs from "../../types/output";
export declare function getVirtualNetwork(args: GetVirtualNetworkArgs, opts?: pulumi.InvokeOptions): Promise<GetVirtualNetworkResult>;
export interface GetVirtualNetworkArgs {
    /**
     * Specify the $expand query. Example: 'properties($expand=externalSubnets)'
     */
    readonly expand?: string;
    /**
     * The name of the lab.
     */
    readonly labName: string;
    /**
     * The name of the virtual network.
     */
    readonly name: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
}
/**
 * A virtual network.
 */
export interface GetVirtualNetworkResult {
    /**
     * The allowed subnets of the virtual network.
     */
    readonly allowedSubnets?: outputs.devtestlab.v20160515.SubnetResponse[];
    /**
     * The creation date of the virtual network.
     */
    readonly createdDate: string;
    /**
     * The description of the virtual network.
     */
    readonly description?: string;
    /**
     * The Microsoft.Network resource identifier of the virtual network.
     */
    readonly externalProviderResourceId?: string;
    /**
     * The external subnet properties.
     */
    readonly externalSubnets?: outputs.devtestlab.v20160515.ExternalSubnetResponse[];
    /**
     * The location of the resource.
     */
    readonly location?: string;
    /**
     * The name of the resource.
     */
    readonly name: string;
    /**
     * The provisioning status of the resource.
     */
    readonly provisioningState?: string;
    /**
     * The subnet overrides of the virtual network.
     */
    readonly subnetOverrides?: outputs.devtestlab.v20160515.SubnetOverrideResponse[];
    /**
     * The tags of the resource.
     */
    readonly tags?: {
        [key: string]: string;
    };
    /**
     * The type of the resource.
     */
    readonly type: string;
    /**
     * The unique immutable identifier of a resource (Guid).
     */
    readonly uniqueIdentifier?: string;
}