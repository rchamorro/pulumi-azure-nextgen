// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getPrivateLinkService(args: GetPrivateLinkServiceArgs, opts?: pulumi.InvokeOptions): Promise<GetPrivateLinkServiceResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:network/v20200701:getPrivateLinkService", {
        "expand": args.expand,
        "resourceGroupName": args.resourceGroupName,
        "serviceName": args.serviceName,
    }, opts);
}

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
    readonly autoApproval?: outputs.network.v20200701.PrivateLinkServicePropertiesResponseAutoApproval;
    /**
     * Whether the private link service is enabled for proxy protocol or not.
     */
    readonly enableProxyProtocol?: boolean;
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    readonly etag: string;
    /**
     * The list of Fqdn.
     */
    readonly fqdns?: string[];
    /**
     * An array of private link service IP configurations.
     */
    readonly ipConfigurations?: outputs.network.v20200701.PrivateLinkServiceIpConfigurationResponse[];
    /**
     * An array of references to the load balancer IP configurations.
     */
    readonly loadBalancerFrontendIpConfigurations?: outputs.network.v20200701.FrontendIPConfigurationResponse[];
    /**
     * Resource location.
     */
    readonly location?: string;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * An array of references to the network interfaces created for this private link service.
     */
    readonly networkInterfaces: outputs.network.v20200701.NetworkInterfaceResponse[];
    /**
     * An array of list about connections to the private endpoint.
     */
    readonly privateEndpointConnections: outputs.network.v20200701.PrivateEndpointConnectionResponse[];
    /**
     * The provisioning state of the private link service resource.
     */
    readonly provisioningState: string;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type.
     */
    readonly type: string;
    /**
     * The visibility list of the private link service.
     */
    readonly visibility?: outputs.network.v20200701.PrivateLinkServicePropertiesResponseVisibility;
}
