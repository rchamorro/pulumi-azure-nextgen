import * as pulumi from "@pulumi/pulumi";
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
 * Network security rule
 */
export interface GetSecurityRuleResult {
    /**
     * Gets or sets network traffic is allowed or denied. Possible values are 'Allow' and 'Deny'
     */
    readonly access: string;
    /**
     * Gets or sets a description for this rule. Restricted to 140 chars.
     */
    readonly description?: string;
    /**
     * Gets or sets destination address prefix. CIDR or source IP range. Asterisk '*' can also be used to match all source IPs. Default tags such as 'VirtualNetwork', 'AzureLoadBalancer' and 'Internet' can also be used.
     */
    readonly destinationAddressPrefix: string;
    /**
     * Gets or sets Destination Port or Range. Integer or range between 0 and 65535. Asterisk '*' can also be used to match all ports.
     */
    readonly destinationPortRange?: string;
    /**
     * Gets or sets the direction of the rule.InBound or Outbound. The direction specifies if rule will be evaluated on incoming or outgoing traffic.
     */
    readonly direction: string;
    /**
     * A unique read-only string that changes whenever the resource is updated
     */
    readonly etag?: string;
    /**
     * Gets name of the resource that is unique within a resource group. This name can be used to access the resource
     */
    readonly name?: string;
    /**
     * Gets or sets the priority of the rule. The value can be between 100 and 4096. The priority number must be unique for each rule in the collection. The lower the priority number, the higher the priority of the rule.
     */
    readonly priority?: number;
    /**
     * Gets or sets Network protocol this rule applies to. Can be Tcp, Udp or All(*).
     */
    readonly protocol: string;
    /**
     * Gets provisioning state of the PublicIP resource Updating/Deleting/Failed
     */
    readonly provisioningState?: string;
    /**
     * Gets or sets source address prefix. CIDR or source IP range. Asterisk '*' can also be used to match all source IPs. Default tags such as 'VirtualNetwork', 'AzureLoadBalancer' and 'Internet' can also be used. If this is an ingress rule, specifies where network traffic originates from.
     */
    readonly sourceAddressPrefix: string;
    /**
     * Gets or sets Source Port or Range. Integer or range between 0 and 65535. Asterisk '*' can also be used to match all ports.
     */
    readonly sourcePortRange?: string;
}