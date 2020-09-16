import * as pulumi from "@pulumi/pulumi";
import * as outputs from "../../types/output";
export declare function getSecurityRule(args: GetSecurityRuleArgs, opts?: pulumi.InvokeOptions): Promise<GetSecurityRuleResult>;
export interface GetSecurityRuleArgs {
    /**
     * The name of the network security group.
     */
    readonly networkSecurityGroupName: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the security rule.
     */
    readonly securityRuleName: string;
}
/**
 * Network security rule.
 */
export interface GetSecurityRuleResult {
    /**
     * The network traffic is allowed or denied. Possible values are: 'Allow' and 'Deny'.
     */
    readonly access: string;
    /**
     * A description for this rule. Restricted to 140 chars.
     */
    readonly description?: string;
    /**
     * The destination address prefix. CIDR or destination IP range. Asterisk '*' can also be used to match all source IPs. Default tags such as 'VirtualNetwork', 'AzureLoadBalancer' and 'Internet' can also be used.
     */
    readonly destinationAddressPrefix?: string;
    /**
     * The destination address prefixes. CIDR or destination IP ranges.
     */
    readonly destinationAddressPrefixes?: string[];
    /**
     * The application security group specified as destination.
     */
    readonly destinationApplicationSecurityGroups?: outputs.network.v20171101.ApplicationSecurityGroupResponse[];
    /**
     * The destination port or range. Integer or range between 0 and 65535. Asterisk '*' can also be used to match all ports.
     */
    readonly destinationPortRange?: string;
    /**
     * The destination port ranges.
     */
    readonly destinationPortRanges?: string[];
    /**
     * The direction of the rule. The direction specifies if rule will be evaluated on incoming or outgoing traffic. Possible values are: 'Inbound' and 'Outbound'.
     */
    readonly direction: string;
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    readonly etag?: string;
    /**
     * The name of the resource that is unique within a resource group. This name can be used to access the resource.
     */
    readonly name?: string;
    /**
     * The priority of the rule. The value can be between 100 and 4096. The priority number must be unique for each rule in the collection. The lower the priority number, the higher the priority of the rule.
     */
    readonly priority?: number;
    /**
     * Network protocol this rule applies to. Possible values are 'Tcp', 'Udp', and '*'.
     */
    readonly protocol: string;
    /**
     * The provisioning state of the public IP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
     */
    readonly provisioningState?: string;
    /**
     * The CIDR or source IP range. Asterisk '*' can also be used to match all source IPs. Default tags such as 'VirtualNetwork', 'AzureLoadBalancer' and 'Internet' can also be used. If this is an ingress rule, specifies where network traffic originates from.
     */
    readonly sourceAddressPrefix?: string;
    /**
     * The CIDR or source IP ranges.
     */
    readonly sourceAddressPrefixes?: string[];
    /**
     * The application security group specified as source.
     */
    readonly sourceApplicationSecurityGroups?: outputs.network.v20171101.ApplicationSecurityGroupResponse[];
    /**
     * The source port or range. Integer or range between 0 and 65535. Asterisk '*' can also be used to match all ports.
     */
    readonly sourcePortRange?: string;
    /**
     * The source port ranges.
     */
    readonly sourcePortRanges?: string[];
}