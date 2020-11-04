// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getLoadBalancerBackendAddressPool(args: GetLoadBalancerBackendAddressPoolArgs, opts?: pulumi.InvokeOptions): Promise<GetLoadBalancerBackendAddressPoolResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:network/v20200701:getLoadBalancerBackendAddressPool", {
        "backendAddressPoolName": args.backendAddressPoolName,
        "loadBalancerName": args.loadBalancerName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetLoadBalancerBackendAddressPoolArgs {
    /**
     * The name of the backend address pool.
     */
    readonly backendAddressPoolName: string;
    /**
     * The name of the load balancer.
     */
    readonly loadBalancerName: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
}

/**
 * Pool of backend IP addresses.
 */
export interface GetLoadBalancerBackendAddressPoolResult {
    /**
     * An array of references to IP addresses defined in network interfaces.
     */
    readonly backendIPConfigurations: outputs.network.v20200701.NetworkInterfaceIPConfigurationResponse[];
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    readonly etag: string;
    /**
     * An array of backend addresses.
     */
    readonly loadBalancerBackendAddresses?: outputs.network.v20200701.LoadBalancerBackendAddressResponse[];
    /**
     * An array of references to load balancing rules that use this backend address pool.
     */
    readonly loadBalancingRules: outputs.network.v20200701.SubResourceResponse[];
    /**
     * The name of the resource that is unique within the set of backend address pools used by the load balancer. This name can be used to access the resource.
     */
    readonly name?: string;
    /**
     * A reference to an outbound rule that uses this backend address pool.
     */
    readonly outboundRule: outputs.network.v20200701.SubResourceResponse;
    /**
     * An array of references to outbound rules that use this backend address pool.
     */
    readonly outboundRules: outputs.network.v20200701.SubResourceResponse[];
    /**
     * The provisioning state of the backend address pool resource.
     */
    readonly provisioningState: string;
    /**
     * Type of the resource.
     */
    readonly type: string;
}
