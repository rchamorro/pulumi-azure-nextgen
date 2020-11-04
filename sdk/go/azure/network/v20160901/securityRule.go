// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20160901

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Network security rule.
type SecurityRule struct {
	pulumi.CustomResourceState

	// The network traffic is allowed or denied. Possible values are: 'Allow' and 'Deny'.
	Access pulumi.StringOutput `pulumi:"access"`
	// A description for this rule. Restricted to 140 chars.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// The destination address prefix. CIDR or source IP range. Asterisk '*' can also be used to match all source IPs. Default tags such as 'VirtualNetwork', 'AzureLoadBalancer' and 'Internet' can also be used.
	DestinationAddressPrefix pulumi.StringOutput `pulumi:"destinationAddressPrefix"`
	// The destination port or range. Integer or range between 0 and 65535. Asterisk '*' can also be used to match all ports.
	DestinationPortRange pulumi.StringPtrOutput `pulumi:"destinationPortRange"`
	// The direction of the rule. The direction specifies if rule will be evaluated on incoming or outgoing traffic. Possible values are: 'Inbound' and 'Outbound'.
	Direction pulumi.StringOutput `pulumi:"direction"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrOutput `pulumi:"etag"`
	// The name of the resource that is unique within a resource group. This name can be used to access the resource.
	Name pulumi.StringPtrOutput `pulumi:"name"`
	// The priority of the rule. The value can be between 100 and 4096. The priority number must be unique for each rule in the collection. The lower the priority number, the higher the priority of the rule.
	Priority pulumi.IntPtrOutput `pulumi:"priority"`
	// Network protocol this rule applies to. Possible values are 'Tcp', 'Udp', and '*'.
	Protocol pulumi.StringOutput `pulumi:"protocol"`
	// The provisioning state of the public IP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
	ProvisioningState pulumi.StringPtrOutput `pulumi:"provisioningState"`
	// The CIDR or source IP range. Asterisk '*' can also be used to match all source IPs. Default tags such as 'VirtualNetwork', 'AzureLoadBalancer' and 'Internet' can also be used. If this is an ingress rule, specifies where network traffic originates from.
	SourceAddressPrefix pulumi.StringOutput `pulumi:"sourceAddressPrefix"`
	// The source port or range. Integer or range between 0 and 65535. Asterisk '*' can also be used to match all ports.
	SourcePortRange pulumi.StringPtrOutput `pulumi:"sourcePortRange"`
}

// NewSecurityRule registers a new resource with the given unique name, arguments, and options.
func NewSecurityRule(ctx *pulumi.Context,
	name string, args *SecurityRuleArgs, opts ...pulumi.ResourceOption) (*SecurityRule, error) {
	if args == nil || args.Access == nil {
		return nil, errors.New("missing required argument 'Access'")
	}
	if args == nil || args.DestinationAddressPrefix == nil {
		return nil, errors.New("missing required argument 'DestinationAddressPrefix'")
	}
	if args == nil || args.Direction == nil {
		return nil, errors.New("missing required argument 'Direction'")
	}
	if args == nil || args.NetworkSecurityGroupName == nil {
		return nil, errors.New("missing required argument 'NetworkSecurityGroupName'")
	}
	if args == nil || args.Protocol == nil {
		return nil, errors.New("missing required argument 'Protocol'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.SecurityRuleName == nil {
		return nil, errors.New("missing required argument 'SecurityRuleName'")
	}
	if args == nil || args.SourceAddressPrefix == nil {
		return nil, errors.New("missing required argument 'SourceAddressPrefix'")
	}
	if args == nil {
		args = &SecurityRuleArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:network/latest:SecurityRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20150501preview:SecurityRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20150615:SecurityRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20160330:SecurityRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20160601:SecurityRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20161201:SecurityRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20170301:SecurityRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20170601:SecurityRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20170801:SecurityRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20170901:SecurityRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20171001:SecurityRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20171101:SecurityRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180101:SecurityRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180201:SecurityRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180401:SecurityRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180601:SecurityRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180701:SecurityRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180801:SecurityRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20181001:SecurityRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20181101:SecurityRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20181201:SecurityRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190201:SecurityRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190401:SecurityRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190601:SecurityRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190701:SecurityRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190801:SecurityRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190901:SecurityRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20191101:SecurityRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20191201:SecurityRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200301:SecurityRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200401:SecurityRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200501:SecurityRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200601:SecurityRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200701:SecurityRule"),
		},
	})
	opts = append(opts, aliases)
	var resource SecurityRule
	err := ctx.RegisterResource("azure-nextgen:network/v20160901:SecurityRule", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSecurityRule gets an existing SecurityRule resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSecurityRule(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SecurityRuleState, opts ...pulumi.ResourceOption) (*SecurityRule, error) {
	var resource SecurityRule
	err := ctx.ReadResource("azure-nextgen:network/v20160901:SecurityRule", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering SecurityRule resources.
type securityRuleState struct {
	// The network traffic is allowed or denied. Possible values are: 'Allow' and 'Deny'.
	Access *string `pulumi:"access"`
	// A description for this rule. Restricted to 140 chars.
	Description *string `pulumi:"description"`
	// The destination address prefix. CIDR or source IP range. Asterisk '*' can also be used to match all source IPs. Default tags such as 'VirtualNetwork', 'AzureLoadBalancer' and 'Internet' can also be used.
	DestinationAddressPrefix *string `pulumi:"destinationAddressPrefix"`
	// The destination port or range. Integer or range between 0 and 65535. Asterisk '*' can also be used to match all ports.
	DestinationPortRange *string `pulumi:"destinationPortRange"`
	// The direction of the rule. The direction specifies if rule will be evaluated on incoming or outgoing traffic. Possible values are: 'Inbound' and 'Outbound'.
	Direction *string `pulumi:"direction"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag *string `pulumi:"etag"`
	// The name of the resource that is unique within a resource group. This name can be used to access the resource.
	Name *string `pulumi:"name"`
	// The priority of the rule. The value can be between 100 and 4096. The priority number must be unique for each rule in the collection. The lower the priority number, the higher the priority of the rule.
	Priority *int `pulumi:"priority"`
	// Network protocol this rule applies to. Possible values are 'Tcp', 'Udp', and '*'.
	Protocol *string `pulumi:"protocol"`
	// The provisioning state of the public IP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
	ProvisioningState *string `pulumi:"provisioningState"`
	// The CIDR or source IP range. Asterisk '*' can also be used to match all source IPs. Default tags such as 'VirtualNetwork', 'AzureLoadBalancer' and 'Internet' can also be used. If this is an ingress rule, specifies where network traffic originates from.
	SourceAddressPrefix *string `pulumi:"sourceAddressPrefix"`
	// The source port or range. Integer or range between 0 and 65535. Asterisk '*' can also be used to match all ports.
	SourcePortRange *string `pulumi:"sourcePortRange"`
}

type SecurityRuleState struct {
	// The network traffic is allowed or denied. Possible values are: 'Allow' and 'Deny'.
	Access pulumi.StringPtrInput
	// A description for this rule. Restricted to 140 chars.
	Description pulumi.StringPtrInput
	// The destination address prefix. CIDR or source IP range. Asterisk '*' can also be used to match all source IPs. Default tags such as 'VirtualNetwork', 'AzureLoadBalancer' and 'Internet' can also be used.
	DestinationAddressPrefix pulumi.StringPtrInput
	// The destination port or range. Integer or range between 0 and 65535. Asterisk '*' can also be used to match all ports.
	DestinationPortRange pulumi.StringPtrInput
	// The direction of the rule. The direction specifies if rule will be evaluated on incoming or outgoing traffic. Possible values are: 'Inbound' and 'Outbound'.
	Direction pulumi.StringPtrInput
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrInput
	// The name of the resource that is unique within a resource group. This name can be used to access the resource.
	Name pulumi.StringPtrInput
	// The priority of the rule. The value can be between 100 and 4096. The priority number must be unique for each rule in the collection. The lower the priority number, the higher the priority of the rule.
	Priority pulumi.IntPtrInput
	// Network protocol this rule applies to. Possible values are 'Tcp', 'Udp', and '*'.
	Protocol pulumi.StringPtrInput
	// The provisioning state of the public IP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
	ProvisioningState pulumi.StringPtrInput
	// The CIDR or source IP range. Asterisk '*' can also be used to match all source IPs. Default tags such as 'VirtualNetwork', 'AzureLoadBalancer' and 'Internet' can also be used. If this is an ingress rule, specifies where network traffic originates from.
	SourceAddressPrefix pulumi.StringPtrInput
	// The source port or range. Integer or range between 0 and 65535. Asterisk '*' can also be used to match all ports.
	SourcePortRange pulumi.StringPtrInput
}

func (SecurityRuleState) ElementType() reflect.Type {
	return reflect.TypeOf((*securityRuleState)(nil)).Elem()
}

type securityRuleArgs struct {
	// The network traffic is allowed or denied. Possible values are: 'Allow' and 'Deny'.
	Access string `pulumi:"access"`
	// A description for this rule. Restricted to 140 chars.
	Description *string `pulumi:"description"`
	// The destination address prefix. CIDR or source IP range. Asterisk '*' can also be used to match all source IPs. Default tags such as 'VirtualNetwork', 'AzureLoadBalancer' and 'Internet' can also be used.
	DestinationAddressPrefix string `pulumi:"destinationAddressPrefix"`
	// The destination port or range. Integer or range between 0 and 65535. Asterisk '*' can also be used to match all ports.
	DestinationPortRange *string `pulumi:"destinationPortRange"`
	// The direction of the rule. The direction specifies if rule will be evaluated on incoming or outgoing traffic. Possible values are: 'Inbound' and 'Outbound'.
	Direction string `pulumi:"direction"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag *string `pulumi:"etag"`
	// Resource ID.
	Id *string `pulumi:"id"`
	// The name of the resource that is unique within a resource group. This name can be used to access the resource.
	Name *string `pulumi:"name"`
	// The name of the network security group.
	NetworkSecurityGroupName string `pulumi:"networkSecurityGroupName"`
	// The priority of the rule. The value can be between 100 and 4096. The priority number must be unique for each rule in the collection. The lower the priority number, the higher the priority of the rule.
	Priority *int `pulumi:"priority"`
	// Network protocol this rule applies to. Possible values are 'Tcp', 'Udp', and '*'.
	Protocol string `pulumi:"protocol"`
	// The provisioning state of the public IP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
	ProvisioningState *string `pulumi:"provisioningState"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the security rule.
	SecurityRuleName string `pulumi:"securityRuleName"`
	// The CIDR or source IP range. Asterisk '*' can also be used to match all source IPs. Default tags such as 'VirtualNetwork', 'AzureLoadBalancer' and 'Internet' can also be used. If this is an ingress rule, specifies where network traffic originates from.
	SourceAddressPrefix string `pulumi:"sourceAddressPrefix"`
	// The source port or range. Integer or range between 0 and 65535. Asterisk '*' can also be used to match all ports.
	SourcePortRange *string `pulumi:"sourcePortRange"`
}

// The set of arguments for constructing a SecurityRule resource.
type SecurityRuleArgs struct {
	// The network traffic is allowed or denied. Possible values are: 'Allow' and 'Deny'.
	Access pulumi.StringInput
	// A description for this rule. Restricted to 140 chars.
	Description pulumi.StringPtrInput
	// The destination address prefix. CIDR or source IP range. Asterisk '*' can also be used to match all source IPs. Default tags such as 'VirtualNetwork', 'AzureLoadBalancer' and 'Internet' can also be used.
	DestinationAddressPrefix pulumi.StringInput
	// The destination port or range. Integer or range between 0 and 65535. Asterisk '*' can also be used to match all ports.
	DestinationPortRange pulumi.StringPtrInput
	// The direction of the rule. The direction specifies if rule will be evaluated on incoming or outgoing traffic. Possible values are: 'Inbound' and 'Outbound'.
	Direction pulumi.StringInput
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrInput
	// Resource ID.
	Id pulumi.StringPtrInput
	// The name of the resource that is unique within a resource group. This name can be used to access the resource.
	Name pulumi.StringPtrInput
	// The name of the network security group.
	NetworkSecurityGroupName pulumi.StringInput
	// The priority of the rule. The value can be between 100 and 4096. The priority number must be unique for each rule in the collection. The lower the priority number, the higher the priority of the rule.
	Priority pulumi.IntPtrInput
	// Network protocol this rule applies to. Possible values are 'Tcp', 'Udp', and '*'.
	Protocol pulumi.StringInput
	// The provisioning state of the public IP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
	ProvisioningState pulumi.StringPtrInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// The name of the security rule.
	SecurityRuleName pulumi.StringInput
	// The CIDR or source IP range. Asterisk '*' can also be used to match all source IPs. Default tags such as 'VirtualNetwork', 'AzureLoadBalancer' and 'Internet' can also be used. If this is an ingress rule, specifies where network traffic originates from.
	SourceAddressPrefix pulumi.StringInput
	// The source port or range. Integer or range between 0 and 65535. Asterisk '*' can also be used to match all ports.
	SourcePortRange pulumi.StringPtrInput
}

func (SecurityRuleArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*securityRuleArgs)(nil)).Elem()
}
