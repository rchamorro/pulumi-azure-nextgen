import * as pulumi from "@pulumi/pulumi";
import * as outputs from "../../types/output";
export declare function getInboundNatRule(args: GetInboundNatRuleArgs, opts?: pulumi.InvokeOptions): Promise<GetInboundNatRuleResult>;
export interface GetInboundNatRuleArgs {
    /**
     * Expands referenced resources.
     */
    readonly expand?: string;
    /**
     * The name of the inbound nat rule.
     */
    readonly inboundNatRuleName: string;
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
 * Inbound NAT rule of the load balancer.
 */
export interface GetInboundNatRuleResult {
    /**
     * A reference to a private IP address defined on a network interface of a VM. Traffic sent to the frontend port of each of the frontend IP configurations is forwarded to the backend IP.
     */
    readonly backendIPConfiguration: outputs.network.v20191201.NetworkInterfaceIPConfigurationResponse;
    /**
     * The port used for the internal endpoint. Acceptable values range from 1 to 65535.
     */
    readonly backendPort?: number;
    /**
     * Configures a virtual machine's endpoint for the floating IP capability required to configure a SQL AlwaysOn Availability Group. This setting is required when using the SQL AlwaysOn Availability Groups in SQL server. This setting can't be changed after you create the endpoint.
     */
    readonly enableFloatingIP?: boolean;
    /**
     * Receive bidirectional TCP Reset on TCP flow idle timeout or unexpected connection termination. This element is only used when the protocol is set to TCP.
     */
    readonly enableTcpReset?: boolean;
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    readonly etag: string;
    /**
     * A reference to frontend IP addresses.
     */
    readonly frontendIPConfiguration?: outputs.network.v20191201.SubResourceResponse;
    /**
     * The port for the external endpoint. Port numbers for each rule must be unique within the Load Balancer. Acceptable values range from 1 to 65534.
     */
    readonly frontendPort?: number;
    /**
     * The timeout for the TCP idle connection. The value can be set between 4 and 30 minutes. The default value is 4 minutes. This element is only used when the protocol is set to TCP.
     */
    readonly idleTimeoutInMinutes?: number;
    /**
     * The name of the resource that is unique within the set of inbound NAT rules used by the load balancer. This name can be used to access the resource.
     */
    readonly name?: string;
    /**
     * The reference to the transport protocol used by the load balancing rule.
     */
    readonly protocol?: string;
    /**
     * The provisioning state of the inbound NAT rule resource.
     */
    readonly provisioningState: string;
    /**
     * Type of the resource.
     */
    readonly type: string;
}