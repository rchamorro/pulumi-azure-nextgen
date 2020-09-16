import * as pulumi from "@pulumi/pulumi";
import * as outputs from "../../types/output";
export declare function getLoadBalancer(args: GetLoadBalancerArgs, opts?: pulumi.InvokeOptions): Promise<GetLoadBalancerResult>;
export interface GetLoadBalancerArgs {
    /**
     * Expands referenced resources.
     */
    readonly expand?: string;
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
 * LoadBalancer resource.
 */
export interface GetLoadBalancerResult {
    /**
     * Collection of backend address pools used by a load balancer.
     */
    readonly backendAddressPools?: outputs.network.v20190901.BackendAddressPoolResponse[];
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    readonly etag: string;
    /**
     * Object representing the frontend IPs to be used for the load balancer.
     */
    readonly frontendIPConfigurations?: outputs.network.v20190901.FrontendIPConfigurationResponse[];
    /**
     * Defines an external port range for inbound NAT to a single backend port on NICs associated with a load balancer. Inbound NAT rules are created automatically for each NIC associated with the Load Balancer using an external port from this range. Defining an Inbound NAT pool on your Load Balancer is mutually exclusive with defining inbound Nat rules. Inbound NAT pools are referenced from virtual machine scale sets. NICs that are associated with individual virtual machines cannot reference an inbound NAT pool. They have to reference individual inbound NAT rules.
     */
    readonly inboundNatPools?: outputs.network.v20190901.InboundNatPoolResponse[];
    /**
     * Collection of inbound NAT Rules used by a load balancer. Defining inbound NAT rules on your load balancer is mutually exclusive with defining an inbound NAT pool. Inbound NAT pools are referenced from virtual machine scale sets. NICs that are associated with individual virtual machines cannot reference an Inbound NAT pool. They have to reference individual inbound NAT rules.
     */
    readonly inboundNatRules?: outputs.network.v20190901.InboundNatRuleResponse[];
    /**
     * Object collection representing the load balancing rules Gets the provisioning.
     */
    readonly loadBalancingRules?: outputs.network.v20190901.LoadBalancingRuleResponse[];
    /**
     * Resource location.
     */
    readonly location?: string;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * The outbound rules.
     */
    readonly outboundRules?: outputs.network.v20190901.OutboundRuleResponse[];
    /**
     * Collection of probe objects used in the load balancer.
     */
    readonly probes?: outputs.network.v20190901.ProbeResponse[];
    /**
     * The provisioning state of the load balancer resource.
     */
    readonly provisioningState: string;
    /**
     * The resource GUID property of the load balancer resource.
     */
    readonly resourceGuid: string;
    /**
     * The load balancer SKU.
     */
    readonly sku?: outputs.network.v20190901.LoadBalancerSkuResponse;
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
}