import * as pulumi from "@pulumi/pulumi";
import * as outputs from "../../types/output";
export declare function getCustomDomain(args: GetCustomDomainArgs, opts?: pulumi.InvokeOptions): Promise<GetCustomDomainResult>;
export interface GetCustomDomainArgs {
    /**
     * The name of the App resource.
     */
    readonly appName: string;
    /**
     * The name of the custom domain resource.
     */
    readonly domainName: string;
    /**
     * The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the Service resource.
     */
    readonly serviceName: string;
}
/**
 * Custom domain resource payload.
 */
export interface GetCustomDomainResult {
    /**
     * The name of the resource.
     */
    readonly name: string;
    /**
     * Properties of the custom domain resource.
     */
    readonly properties: outputs.appplatform.v20200701.CustomDomainPropertiesResponse;
    /**
     * The type of the resource.
     */
    readonly type: string;
}