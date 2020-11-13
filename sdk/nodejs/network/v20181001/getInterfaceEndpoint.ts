// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getInterfaceEndpoint(args: GetInterfaceEndpointArgs, opts?: pulumi.InvokeOptions): Promise<GetInterfaceEndpointResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:network/v20181001:getInterfaceEndpoint", {
        "expand": args.expand,
        "interfaceEndpointName": args.interfaceEndpointName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetInterfaceEndpointArgs {
    /**
     * Expands referenced resources.
     */
    readonly expand?: string;
    /**
     * The name of the interface endpoint.
     */
    readonly interfaceEndpointName: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
}

/**
 * Interface endpoint resource.
 */
export interface GetInterfaceEndpointResult {
    /**
     * A reference to the service being brought into the virtual network.
     */
    readonly endpointService?: outputs.network.v20181001.EndpointServiceResponse;
    /**
     * Gets a unique read-only string that changes whenever the resource is updated.
     */
    readonly etag?: string;
    /**
     * A first-party service's FQDN that is mapped to the private IP allocated via this interface endpoint.
     */
    readonly fqdn?: string;
    /**
     * Resource location.
     */
    readonly location?: string;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * Gets an array of references to the network interfaces created for this interface endpoint.
     */
    readonly networkInterfaces: outputs.network.v20181001.NetworkInterfaceResponse[];
    /**
     * A read-only property that identifies who created this interface endpoint.
     */
    readonly owner: string;
    /**
     * The provisioning state of the interface endpoint. Possible values are: 'Updating', 'Deleting', and 'Failed'.
     */
    readonly provisioningState: string;
    /**
     * The ID of the subnet from which the private IP will be allocated.
     */
    readonly subnet?: outputs.network.v20181001.SubnetResponse;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type.
     */
    readonly type: string;
}
