import * as pulumi from "@pulumi/pulumi";
import * as outputs from "../../types/output";
export declare function getPrivateLinkService(args: GetPrivateLinkServiceArgs, opts?: pulumi.InvokeOptions): Promise<GetPrivateLinkServiceResult>;
export interface GetPrivateLinkServiceArgs {
    /**
     * Expands referenced resources.
     */
    readonly expand?: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the private link service.
     */
    readonly serviceName: string;
}
/**
 * Private link service resource.
 */
export interface GetPrivateLinkServiceResult {
    /**
     * The alias of the private link service.
     */
    readonly alias: string;
    /**
     * The auto-approval list of the private link service.
     */
    readonly autoApproval?: outputs.network.v20190601.PrivateLinkServicePropertiesResponseAutoApproval;
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    readonly etag?: string;
    /**
     * The list of Fqdn.
     */
    readonly fqdns?: string[];
    /**
     * An array of references to the private link service IP configuration.
     */
    readonly ipConfigurations?: outputs.network.v20190601.PrivateLinkServiceIpConfigurationResponse[];
    /**
     * An array of references to the load balancer IP configurations.
     */
    readonly loadBalancerFrontendIpConfigurations?: outputs.network.v20190601.FrontendIPConfigurationResponse[];
    /**
     * Resource location.
     */
    readonly location?: string;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * Gets an array of references to the network interfaces created for this private link service.
     */
    readonly networkInterfaces: outputs.network.v20190601.NetworkInterfaceResponse[];
    /**
     * An array of list about connections to the private endpoint.
     */
    readonly privateEndpointConnections?: outputs.network.v20190601.PrivateEndpointConnectionResponse[];
    /**
     * The provisioning state of the private link service.
     */
    readonly provisioningState?: string;
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
     * The visibility list of the private link service.
     */
    readonly visibility?: outputs.network.v20190601.PrivateLinkServicePropertiesResponseVisibility;
}