// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200801

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupSecurityRule(ctx *pulumi.Context, args *LookupSecurityRuleArgs, opts ...pulumi.InvokeOption) (*LookupSecurityRuleResult, error) {
	var rv LookupSecurityRuleResult
	err := ctx.Invoke("azure-nextgen:network/v20200801:getSecurityRule", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupSecurityRuleArgs struct {
	// The name of the network security group.
	NetworkSecurityGroupName string `pulumi:"networkSecurityGroupName"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the security rule.
	SecurityRuleName string `pulumi:"securityRuleName"`
}

// Network security rule.
type LookupSecurityRuleResult struct {
	// The network traffic is allowed or denied.
	Access string `pulumi:"access"`
	// A description for this rule. Restricted to 140 chars.
	Description *string `pulumi:"description"`
	// The destination address prefix. CIDR or destination IP range. Asterisk '*' can also be used to match all source IPs. Default tags such as 'VirtualNetwork', 'AzureLoadBalancer' and 'Internet' can also be used.
	DestinationAddressPrefix *string `pulumi:"destinationAddressPrefix"`
	// The destination address prefixes. CIDR or destination IP ranges.
	DestinationAddressPrefixes []string `pulumi:"destinationAddressPrefixes"`
	// The application security group specified as destination.
	DestinationApplicationSecurityGroups []ApplicationSecurityGroupResponse `pulumi:"destinationApplicationSecurityGroups"`
	// The destination port or range. Integer or range between 0 and 65535. Asterisk '*' can also be used to match all ports.
	DestinationPortRange *string `pulumi:"destinationPortRange"`
	// The destination port ranges.
	DestinationPortRanges []string `pulumi:"destinationPortRanges"`
	// The direction of the rule. The direction specifies if rule will be evaluated on incoming or outgoing traffic.
	Direction string `pulumi:"direction"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag string `pulumi:"etag"`
	// Resource ID.
	Id *string `pulumi:"id"`
	// The name of the resource that is unique within a resource group. This name can be used to access the resource.
	Name *string `pulumi:"name"`
	// The priority of the rule. The value can be between 100 and 4096. The priority number must be unique for each rule in the collection. The lower the priority number, the higher the priority of the rule.
	Priority *int `pulumi:"priority"`
	// Network protocol this rule applies to.
	Protocol string `pulumi:"protocol"`
	// The provisioning state of the security rule resource.
	ProvisioningState string `pulumi:"provisioningState"`
	// The CIDR or source IP range. Asterisk '*' can also be used to match all source IPs. Default tags such as 'VirtualNetwork', 'AzureLoadBalancer' and 'Internet' can also be used. If this is an ingress rule, specifies where network traffic originates from.
	SourceAddressPrefix *string `pulumi:"sourceAddressPrefix"`
	// The CIDR or source IP ranges.
	SourceAddressPrefixes []string `pulumi:"sourceAddressPrefixes"`
	// The application security group specified as source.
	SourceApplicationSecurityGroups []ApplicationSecurityGroupResponse `pulumi:"sourceApplicationSecurityGroups"`
	// The source port or range. Integer or range between 0 and 65535. Asterisk '*' can also be used to match all ports.
	SourcePortRange *string `pulumi:"sourcePortRange"`
	// The source port ranges.
	SourcePortRanges []string `pulumi:"sourcePortRanges"`
	// The type of the resource.
	Type *string `pulumi:"type"`
}
