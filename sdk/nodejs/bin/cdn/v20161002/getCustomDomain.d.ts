import * as pulumi from "@pulumi/pulumi";
export declare function getCustomDomain(args: GetCustomDomainArgs, opts?: pulumi.InvokeOptions): Promise<GetCustomDomainResult>;
export interface GetCustomDomainArgs {
    /**
     * Name of the custom domain within an endpoint.
     */
    readonly customDomainName: string;
    /**
     * Name of the endpoint under the profile which is unique globally.
     */
    readonly endpointName: string;
    /**
     * Name of the CDN profile which is unique within the resource group.
     */
    readonly profileName: string;
    /**
     * Name of the Resource group within the Azure subscription.
     */
    readonly resourceGroupName: string;
}
/**
 * Customer provided domain for branding purposes, e.g. www.contoso.com.
 */
export interface GetCustomDomainResult {
    /**
     * Provisioning state of Custom Https of the custom domain.
     */
    readonly customHttpsProvisioningState: string;
    /**
     * The host name of the custom domain. Must be a domain name.
     */
    readonly hostName: string;
    /**
     * Resource location.
     */
    readonly location: string;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * Provisioning status of the custom domain.
     */
    readonly provisioningState: string;
    /**
     * Resource status of the custom domain.
     */
    readonly resourceState: string;
    /**
     * Resource tags.
     */
    readonly tags?: {
        [key: string]: string;
    };
    /**
     * Resource type.
     */
    readonly type: string;
    /**
     * Special validation or data may be required when delivering CDN to some regions due to local compliance reasons. E.g. ICP license number of a custom domain is required to deliver content in China.
     */
    readonly validationData?: string;
}