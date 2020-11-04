// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getPrivateEndpoint(args: GetPrivateEndpointArgs, opts?: pulumi.InvokeOptions): Promise<GetPrivateEndpointResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:network/v20200701:getPrivateEndpoint", {
        "expand": args.expand,
        "privateEndpointName": args.privateEndpointName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetPrivateEndpointArgs {
    /**
     * Expands referenced resources.
     */
    readonly expand?: string;
    /**
     * The name of the private endpoint.
     */
    readonly privateEndpointName: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
}

/**
 * Private endpoint resource.
 */
export interface GetPrivateEndpointResult {
    /**
     * An array of custom dns configurations.
     */
    readonly customDnsConfigs?: outputs.network.v20200701.CustomDnsConfigPropertiesFormatResponse[];
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    readonly etag: string;
    /**
     * Resource location.
     */
    readonly location?: string;
    /**
     * A grouping of information about the connection to the remote resource. Used when the network admin does not have access to approve connections to the remote resource.
     */
    readonly manualPrivateLinkServiceConnections?: outputs.network.v20200701.PrivateLinkServiceConnectionResponse[];
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * An array of references to the network interfaces created for this private endpoint.
     */
    readonly networkInterfaces: outputs.network.v20200701.NetworkInterfaceResponse[];
    /**
     * A grouping of information about the connection to the remote resource.
     */
    readonly privateLinkServiceConnections?: outputs.network.v20200701.PrivateLinkServiceConnectionResponse[];
    /**
     * The provisioning state of the private endpoint resource.
     */
    readonly provisioningState: string;
    /**
     * The ID of the subnet from which the private IP will be allocated.
     */
    readonly subnet?: outputs.network.v20200701.SubnetResponse;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type.
     */
    readonly type: string;
}