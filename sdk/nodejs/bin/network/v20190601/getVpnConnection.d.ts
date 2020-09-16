import * as pulumi from "@pulumi/pulumi";
import * as outputs from "../../types/output";
export declare function getVpnConnection(args: GetVpnConnectionArgs, opts?: pulumi.InvokeOptions): Promise<GetVpnConnectionResult>;
export interface GetVpnConnectionArgs {
    /**
     * The name of the vpn connection.
     */
    readonly connectionName: string;
    /**
     * The name of the gateway.
     */
    readonly gatewayName: string;
    /**
     * The resource group name of the VpnGateway.
     */
    readonly resourceGroupName: string;
}
/**
 * VpnConnection Resource.
 */
export interface GetVpnConnectionResult {
    /**
     * Expected bandwidth in MBPS.
     */
    readonly connectionBandwidth?: number;
    /**
     * The connection status.
     */
    readonly connectionStatus?: string;
    /**
     * Egress bytes transferred.
     */
    readonly egressBytesTransferred: number;
    /**
     * EnableBgp flag.
     */
    readonly enableBgp?: boolean;
    /**
     * Enable internet security.
     */
    readonly enableInternetSecurity?: boolean;
    /**
     * EnableBgp flag.
     */
    readonly enableRateLimiting?: boolean;
    /**
     * Gets a unique read-only string that changes whenever the resource is updated.
     */
    readonly etag: string;
    /**
     * Ingress bytes transferred.
     */
    readonly ingressBytesTransferred: number;
    /**
     * The IPSec Policies to be considered by this connection.
     */
    readonly ipsecPolicies?: outputs.network.v20190601.IpsecPolicyResponse[];
    /**
     * The name of the resource that is unique within a resource group. This name can be used to access the resource.
     */
    readonly name?: string;
    /**
     * The provisioning state of the resource.
     */
    readonly provisioningState?: string;
    /**
     * Id of the connected vpn site.
     */
    readonly remoteVpnSite?: outputs.network.v20190601.SubResourceResponse;
    /**
     * Routing weight for vpn connection.
     */
    readonly routingWeight?: number;
    /**
     * SharedKey for the vpn connection.
     */
    readonly sharedKey?: string;
    /**
     * Use local azure ip to initiate connection.
     */
    readonly useLocalAzureIpAddress?: boolean;
    /**
     * Enable policy-based traffic selectors.
     */
    readonly usePolicyBasedTrafficSelectors?: boolean;
    /**
     * Connection protocol used for this connection.
     */
    readonly vpnConnectionProtocolType?: string;
    /**
     * List of all vpn site link connections to the gateway.
     */
    readonly vpnLinkConnections?: outputs.network.v20190601.VpnSiteLinkConnectionResponse[];
}