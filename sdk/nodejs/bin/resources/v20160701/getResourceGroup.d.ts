import * as pulumi from "@pulumi/pulumi";
import * as outputs from "../../types/output";
export declare function getResourceGroup(args: GetResourceGroupArgs, opts?: pulumi.InvokeOptions): Promise<GetResourceGroupResult>;
export interface GetResourceGroupArgs {
    /**
     * The name of the resource group to get. The name is case insensitive.
     */
    readonly resourceGroupName: string;
}
/**
 * Resource group information.
 */
export interface GetResourceGroupResult {
    /**
     * The location of the resource group. It cannot be changed after the resource group has been created. Has to be one of the supported Azure Locations, such as West US, East US, West Europe, East Asia, etc.
     */
    readonly location: string;
    /**
     * The Name of the resource group.
     */
    readonly name?: string;
    /**
     * The resource group properties.
     */
    readonly properties: outputs.resources.v20160701.ResourceGroupPropertiesResponse;
    /**
     * The tags attached to the resource group.
     */
    readonly tags?: {
        [key: string]: string;
    };
}