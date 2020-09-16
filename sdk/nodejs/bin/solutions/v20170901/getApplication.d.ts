import * as pulumi from "@pulumi/pulumi";
import * as outputs from "../../types/output";
export declare function getApplication(args: GetApplicationArgs, opts?: pulumi.InvokeOptions): Promise<GetApplicationResult>;
export interface GetApplicationArgs {
    /**
     * The name of the managed application.
     */
    readonly applicationName: string;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    readonly resourceGroupName: string;
}
/**
 * Information about managed application.
 */
export interface GetApplicationResult {
    /**
     * The fully qualified path of managed application definition Id.
     */
    readonly applicationDefinitionId?: string;
    /**
     * The identity of the resource.
     */
    readonly identity?: outputs.solutions.v20170901.IdentityResponse;
    /**
     * The kind of the managed application. Allowed values are MarketPlace and ServiceCatalog.
     */
    readonly kind: string;
    /**
     * Resource location
     */
    readonly location?: string;
    /**
     * ID of the resource that manages this resource.
     */
    readonly managedBy?: string;
    /**
     * The managed resource group Id.
     */
    readonly managedResourceGroupId: string;
    /**
     * Resource name
     */
    readonly name: string;
    /**
     * Name and value pairs that define the managed application outputs.
     */
    readonly outputs: {
        [key: string]: any;
    };
    /**
     * Name and value pairs that define the managed application parameters. It can be a JObject or a well formed JSON string.
     */
    readonly parameters?: {
        [key: string]: any;
    };
    /**
     * The plan information.
     */
    readonly plan?: outputs.solutions.v20170901.PlanResponse;
    /**
     * The managed application provisioning state.
     */
    readonly provisioningState: string;
    /**
     * The SKU of the resource.
     */
    readonly sku?: outputs.solutions.v20170901.SkuResponse;
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
     * The blob URI where the UI definition file is located.
     */
    readonly uiDefinitionUri?: string;
}