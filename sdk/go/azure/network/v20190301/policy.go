// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20190301

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Defines web application firewall policy.
type Policy struct {
	pulumi.CustomResourceState

	// Describes custom rules inside the policy.
	CustomRules CustomRuleListResponsePtrOutput `pulumi:"customRules"`
	// Gets a unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrOutput `pulumi:"etag"`
	// Describes Frontend Endpoints associated with this Web Application Firewall policy.
	FrontendEndpointLinks FrontendEndpointLinkResponseArrayOutput `pulumi:"frontendEndpointLinks"`
	// Resource location.
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// Describes managed rules inside the policy.
	ManagedRules ManagedRuleSetListResponsePtrOutput `pulumi:"managedRules"`
	// Resource name.
	Name pulumi.StringOutput `pulumi:"name"`
	// Describes settings for the policy.
	PolicySettings PolicySettingsResponsePtrOutput `pulumi:"policySettings"`
	// Provisioning state of the policy.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	ResourceState     pulumi.StringOutput `pulumi:"resourceState"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewPolicy registers a new resource with the given unique name, arguments, and options.
func NewPolicy(ctx *pulumi.Context,
	name string, args *PolicyArgs, opts ...pulumi.ResourceOption) (*Policy, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.PolicyName == nil {
		return nil, errors.New("invalid value for required argument 'PolicyName'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:network/latest:Policy"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180801:Policy"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20191001:Policy"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200401:Policy"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20201101:Policy"),
		},
	})
	opts = append(opts, aliases)
	var resource Policy
	err := ctx.RegisterResource("azure-nextgen:network/v20190301:Policy", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetPolicy gets an existing Policy resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetPolicy(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *PolicyState, opts ...pulumi.ResourceOption) (*Policy, error) {
	var resource Policy
	err := ctx.ReadResource("azure-nextgen:network/v20190301:Policy", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Policy resources.
type policyState struct {
	// Describes custom rules inside the policy.
	CustomRules *CustomRuleListResponse `pulumi:"customRules"`
	// Gets a unique read-only string that changes whenever the resource is updated.
	Etag *string `pulumi:"etag"`
	// Describes Frontend Endpoints associated with this Web Application Firewall policy.
	FrontendEndpointLinks []FrontendEndpointLinkResponse `pulumi:"frontendEndpointLinks"`
	// Resource location.
	Location *string `pulumi:"location"`
	// Describes managed rules inside the policy.
	ManagedRules *ManagedRuleSetListResponse `pulumi:"managedRules"`
	// Resource name.
	Name *string `pulumi:"name"`
	// Describes settings for the policy.
	PolicySettings *PolicySettingsResponse `pulumi:"policySettings"`
	// Provisioning state of the policy.
	ProvisioningState *string `pulumi:"provisioningState"`
	ResourceState     *string `pulumi:"resourceState"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Resource type.
	Type *string `pulumi:"type"`
}

type PolicyState struct {
	// Describes custom rules inside the policy.
	CustomRules CustomRuleListResponsePtrInput
	// Gets a unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrInput
	// Describes Frontend Endpoints associated with this Web Application Firewall policy.
	FrontendEndpointLinks FrontendEndpointLinkResponseArrayInput
	// Resource location.
	Location pulumi.StringPtrInput
	// Describes managed rules inside the policy.
	ManagedRules ManagedRuleSetListResponsePtrInput
	// Resource name.
	Name pulumi.StringPtrInput
	// Describes settings for the policy.
	PolicySettings PolicySettingsResponsePtrInput
	// Provisioning state of the policy.
	ProvisioningState pulumi.StringPtrInput
	ResourceState     pulumi.StringPtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// Resource type.
	Type pulumi.StringPtrInput
}

func (PolicyState) ElementType() reflect.Type {
	return reflect.TypeOf((*policyState)(nil)).Elem()
}

type policyArgs struct {
	// Describes custom rules inside the policy.
	CustomRules *CustomRuleList `pulumi:"customRules"`
	// Gets a unique read-only string that changes whenever the resource is updated.
	Etag *string `pulumi:"etag"`
	// Resource location.
	Location *string `pulumi:"location"`
	// Describes managed rules inside the policy.
	ManagedRules *ManagedRuleSetList `pulumi:"managedRules"`
	// The name of the Web Application Firewall Policy.
	PolicyName string `pulumi:"policyName"`
	// Describes settings for the policy.
	PolicySettings *PolicySettings `pulumi:"policySettings"`
	// Name of the Resource group within the Azure subscription.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a Policy resource.
type PolicyArgs struct {
	// Describes custom rules inside the policy.
	CustomRules CustomRuleListPtrInput
	// Gets a unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrInput
	// Resource location.
	Location pulumi.StringPtrInput
	// Describes managed rules inside the policy.
	ManagedRules ManagedRuleSetListPtrInput
	// The name of the Web Application Firewall Policy.
	PolicyName pulumi.StringInput
	// Describes settings for the policy.
	PolicySettings PolicySettingsPtrInput
	// Name of the Resource group within the Azure subscription.
	ResourceGroupName pulumi.StringInput
	// Resource tags.
	Tags pulumi.StringMapInput
}

func (PolicyArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*policyArgs)(nil)).Elem()
}

type PolicyInput interface {
	pulumi.Input

	ToPolicyOutput() PolicyOutput
	ToPolicyOutputWithContext(ctx context.Context) PolicyOutput
}

func (*Policy) ElementType() reflect.Type {
	return reflect.TypeOf((*Policy)(nil))
}

func (i *Policy) ToPolicyOutput() PolicyOutput {
	return i.ToPolicyOutputWithContext(context.Background())
}

func (i *Policy) ToPolicyOutputWithContext(ctx context.Context) PolicyOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PolicyOutput)
}

type PolicyOutput struct {
	*pulumi.OutputState
}

func (PolicyOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Policy)(nil))
}

func (o PolicyOutput) ToPolicyOutput() PolicyOutput {
	return o
}

func (o PolicyOutput) ToPolicyOutputWithContext(ctx context.Context) PolicyOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(PolicyOutput{})
}
