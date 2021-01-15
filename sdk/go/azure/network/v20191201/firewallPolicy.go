// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20191201

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// FirewallPolicy Resource.
type FirewallPolicy struct {
	pulumi.CustomResourceState

	// The parent firewall policy from which rules are inherited.
	BasePolicy SubResourceResponsePtrOutput `pulumi:"basePolicy"`
	// List of references to Child Firewall Policies.
	ChildPolicies SubResourceResponseArrayOutput `pulumi:"childPolicies"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringOutput `pulumi:"etag"`
	// List of references to Azure Firewalls that this Firewall Policy is associated with.
	Firewalls SubResourceResponseArrayOutput `pulumi:"firewalls"`
	// Resource location.
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// Resource name.
	Name pulumi.StringOutput `pulumi:"name"`
	// The provisioning state of the firewall policy resource.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// List of references to FirewallPolicyRuleGroups.
	RuleGroups SubResourceResponseArrayOutput `pulumi:"ruleGroups"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// The operation mode for Threat Intelligence.
	ThreatIntelMode pulumi.StringPtrOutput `pulumi:"threatIntelMode"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewFirewallPolicy registers a new resource with the given unique name, arguments, and options.
func NewFirewallPolicy(ctx *pulumi.Context,
	name string, args *FirewallPolicyArgs, opts ...pulumi.ResourceOption) (*FirewallPolicy, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.FirewallPolicyName == nil {
		return nil, errors.New("invalid value for required argument 'FirewallPolicyName'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:network/latest:FirewallPolicy"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190601:FirewallPolicy"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190701:FirewallPolicy"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190801:FirewallPolicy"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190901:FirewallPolicy"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20191101:FirewallPolicy"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200301:FirewallPolicy"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200401:FirewallPolicy"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200501:FirewallPolicy"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200601:FirewallPolicy"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200701:FirewallPolicy"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200801:FirewallPolicy"),
		},
	})
	opts = append(opts, aliases)
	var resource FirewallPolicy
	err := ctx.RegisterResource("azure-nextgen:network/v20191201:FirewallPolicy", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetFirewallPolicy gets an existing FirewallPolicy resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetFirewallPolicy(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *FirewallPolicyState, opts ...pulumi.ResourceOption) (*FirewallPolicy, error) {
	var resource FirewallPolicy
	err := ctx.ReadResource("azure-nextgen:network/v20191201:FirewallPolicy", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering FirewallPolicy resources.
type firewallPolicyState struct {
	// The parent firewall policy from which rules are inherited.
	BasePolicy *SubResourceResponse `pulumi:"basePolicy"`
	// List of references to Child Firewall Policies.
	ChildPolicies []SubResourceResponse `pulumi:"childPolicies"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag *string `pulumi:"etag"`
	// List of references to Azure Firewalls that this Firewall Policy is associated with.
	Firewalls []SubResourceResponse `pulumi:"firewalls"`
	// Resource location.
	Location *string `pulumi:"location"`
	// Resource name.
	Name *string `pulumi:"name"`
	// The provisioning state of the firewall policy resource.
	ProvisioningState *string `pulumi:"provisioningState"`
	// List of references to FirewallPolicyRuleGroups.
	RuleGroups []SubResourceResponse `pulumi:"ruleGroups"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// The operation mode for Threat Intelligence.
	ThreatIntelMode *string `pulumi:"threatIntelMode"`
	// Resource type.
	Type *string `pulumi:"type"`
}

type FirewallPolicyState struct {
	// The parent firewall policy from which rules are inherited.
	BasePolicy SubResourceResponsePtrInput
	// List of references to Child Firewall Policies.
	ChildPolicies SubResourceResponseArrayInput
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrInput
	// List of references to Azure Firewalls that this Firewall Policy is associated with.
	Firewalls SubResourceResponseArrayInput
	// Resource location.
	Location pulumi.StringPtrInput
	// Resource name.
	Name pulumi.StringPtrInput
	// The provisioning state of the firewall policy resource.
	ProvisioningState pulumi.StringPtrInput
	// List of references to FirewallPolicyRuleGroups.
	RuleGroups SubResourceResponseArrayInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// The operation mode for Threat Intelligence.
	ThreatIntelMode pulumi.StringPtrInput
	// Resource type.
	Type pulumi.StringPtrInput
}

func (FirewallPolicyState) ElementType() reflect.Type {
	return reflect.TypeOf((*firewallPolicyState)(nil)).Elem()
}

type firewallPolicyArgs struct {
	// The parent firewall policy from which rules are inherited.
	BasePolicy *SubResource `pulumi:"basePolicy"`
	// The name of the Firewall Policy.
	FirewallPolicyName string `pulumi:"firewallPolicyName"`
	// Resource ID.
	Id *string `pulumi:"id"`
	// Resource location.
	Location *string `pulumi:"location"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// The operation mode for Threat Intelligence.
	ThreatIntelMode *string `pulumi:"threatIntelMode"`
}

// The set of arguments for constructing a FirewallPolicy resource.
type FirewallPolicyArgs struct {
	// The parent firewall policy from which rules are inherited.
	BasePolicy SubResourcePtrInput
	// The name of the Firewall Policy.
	FirewallPolicyName pulumi.StringInput
	// Resource ID.
	Id pulumi.StringPtrInput
	// Resource location.
	Location pulumi.StringPtrInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// The operation mode for Threat Intelligence.
	ThreatIntelMode pulumi.StringPtrInput
}

func (FirewallPolicyArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*firewallPolicyArgs)(nil)).Elem()
}

type FirewallPolicyInput interface {
	pulumi.Input

	ToFirewallPolicyOutput() FirewallPolicyOutput
	ToFirewallPolicyOutputWithContext(ctx context.Context) FirewallPolicyOutput
}

func (*FirewallPolicy) ElementType() reflect.Type {
	return reflect.TypeOf((*FirewallPolicy)(nil))
}

func (i *FirewallPolicy) ToFirewallPolicyOutput() FirewallPolicyOutput {
	return i.ToFirewallPolicyOutputWithContext(context.Background())
}

func (i *FirewallPolicy) ToFirewallPolicyOutputWithContext(ctx context.Context) FirewallPolicyOutput {
	return pulumi.ToOutputWithContext(ctx, i).(FirewallPolicyOutput)
}

type FirewallPolicyOutput struct {
	*pulumi.OutputState
}

func (FirewallPolicyOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*FirewallPolicy)(nil))
}

func (o FirewallPolicyOutput) ToFirewallPolicyOutput() FirewallPolicyOutput {
	return o
}

func (o FirewallPolicyOutput) ToFirewallPolicyOutputWithContext(ctx context.Context) FirewallPolicyOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(FirewallPolicyOutput{})
}
