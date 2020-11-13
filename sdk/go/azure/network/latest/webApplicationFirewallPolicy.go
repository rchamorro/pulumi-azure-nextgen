// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Defines web application firewall policy.
type WebApplicationFirewallPolicy struct {
	pulumi.CustomResourceState

	// A collection of references to application gateways.
	ApplicationGateways ApplicationGatewayResponseArrayOutput `pulumi:"applicationGateways"`
	// The custom rules inside the policy.
	CustomRules WebApplicationFirewallCustomRuleResponseArrayOutput `pulumi:"customRules"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringOutput `pulumi:"etag"`
	// A collection of references to application gateway http listeners.
	HttpListeners SubResourceResponseArrayOutput `pulumi:"httpListeners"`
	// Resource location.
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// Describes the managedRules structure.
	ManagedRules ManagedRulesDefinitionResponseOutput `pulumi:"managedRules"`
	// Resource name.
	Name pulumi.StringOutput `pulumi:"name"`
	// A collection of references to application gateway path rules.
	PathBasedRules SubResourceResponseArrayOutput `pulumi:"pathBasedRules"`
	// The PolicySettings for policy.
	PolicySettings PolicySettingsResponsePtrOutput `pulumi:"policySettings"`
	// The provisioning state of the web application firewall policy resource.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// Resource status of the policy.
	ResourceState pulumi.StringOutput `pulumi:"resourceState"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewWebApplicationFirewallPolicy registers a new resource with the given unique name, arguments, and options.
func NewWebApplicationFirewallPolicy(ctx *pulumi.Context,
	name string, args *WebApplicationFirewallPolicyArgs, opts ...pulumi.ResourceOption) (*WebApplicationFirewallPolicy, error) {
	if args == nil || args.ManagedRules == nil {
		return nil, errors.New("missing required argument 'ManagedRules'")
	}
	if args == nil || args.PolicyName == nil {
		return nil, errors.New("missing required argument 'PolicyName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &WebApplicationFirewallPolicyArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:network/v20181201:WebApplicationFirewallPolicy"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190201:WebApplicationFirewallPolicy"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190401:WebApplicationFirewallPolicy"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190601:WebApplicationFirewallPolicy"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190701:WebApplicationFirewallPolicy"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190801:WebApplicationFirewallPolicy"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190901:WebApplicationFirewallPolicy"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20191101:WebApplicationFirewallPolicy"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20191201:WebApplicationFirewallPolicy"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200301:WebApplicationFirewallPolicy"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200401:WebApplicationFirewallPolicy"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200501:WebApplicationFirewallPolicy"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200601:WebApplicationFirewallPolicy"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200701:WebApplicationFirewallPolicy"),
		},
	})
	opts = append(opts, aliases)
	var resource WebApplicationFirewallPolicy
	err := ctx.RegisterResource("azure-nextgen:network/latest:WebApplicationFirewallPolicy", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetWebApplicationFirewallPolicy gets an existing WebApplicationFirewallPolicy resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetWebApplicationFirewallPolicy(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *WebApplicationFirewallPolicyState, opts ...pulumi.ResourceOption) (*WebApplicationFirewallPolicy, error) {
	var resource WebApplicationFirewallPolicy
	err := ctx.ReadResource("azure-nextgen:network/latest:WebApplicationFirewallPolicy", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering WebApplicationFirewallPolicy resources.
type webApplicationFirewallPolicyState struct {
	// A collection of references to application gateways.
	ApplicationGateways []ApplicationGatewayResponse `pulumi:"applicationGateways"`
	// The custom rules inside the policy.
	CustomRules []WebApplicationFirewallCustomRuleResponse `pulumi:"customRules"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag *string `pulumi:"etag"`
	// A collection of references to application gateway http listeners.
	HttpListeners []SubResourceResponse `pulumi:"httpListeners"`
	// Resource location.
	Location *string `pulumi:"location"`
	// Describes the managedRules structure.
	ManagedRules *ManagedRulesDefinitionResponse `pulumi:"managedRules"`
	// Resource name.
	Name *string `pulumi:"name"`
	// A collection of references to application gateway path rules.
	PathBasedRules []SubResourceResponse `pulumi:"pathBasedRules"`
	// The PolicySettings for policy.
	PolicySettings *PolicySettingsResponse `pulumi:"policySettings"`
	// The provisioning state of the web application firewall policy resource.
	ProvisioningState *string `pulumi:"provisioningState"`
	// Resource status of the policy.
	ResourceState *string `pulumi:"resourceState"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Resource type.
	Type *string `pulumi:"type"`
}

type WebApplicationFirewallPolicyState struct {
	// A collection of references to application gateways.
	ApplicationGateways ApplicationGatewayResponseArrayInput
	// The custom rules inside the policy.
	CustomRules WebApplicationFirewallCustomRuleResponseArrayInput
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrInput
	// A collection of references to application gateway http listeners.
	HttpListeners SubResourceResponseArrayInput
	// Resource location.
	Location pulumi.StringPtrInput
	// Describes the managedRules structure.
	ManagedRules ManagedRulesDefinitionResponsePtrInput
	// Resource name.
	Name pulumi.StringPtrInput
	// A collection of references to application gateway path rules.
	PathBasedRules SubResourceResponseArrayInput
	// The PolicySettings for policy.
	PolicySettings PolicySettingsResponsePtrInput
	// The provisioning state of the web application firewall policy resource.
	ProvisioningState pulumi.StringPtrInput
	// Resource status of the policy.
	ResourceState pulumi.StringPtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// Resource type.
	Type pulumi.StringPtrInput
}

func (WebApplicationFirewallPolicyState) ElementType() reflect.Type {
	return reflect.TypeOf((*webApplicationFirewallPolicyState)(nil)).Elem()
}

type webApplicationFirewallPolicyArgs struct {
	// The custom rules inside the policy.
	CustomRules []WebApplicationFirewallCustomRule `pulumi:"customRules"`
	// Resource ID.
	Id *string `pulumi:"id"`
	// Resource location.
	Location *string `pulumi:"location"`
	// Describes the managedRules structure.
	ManagedRules ManagedRulesDefinition `pulumi:"managedRules"`
	// The name of the policy.
	PolicyName string `pulumi:"policyName"`
	// The PolicySettings for policy.
	PolicySettings *PolicySettings `pulumi:"policySettings"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a WebApplicationFirewallPolicy resource.
type WebApplicationFirewallPolicyArgs struct {
	// The custom rules inside the policy.
	CustomRules WebApplicationFirewallCustomRuleArrayInput
	// Resource ID.
	Id pulumi.StringPtrInput
	// Resource location.
	Location pulumi.StringPtrInput
	// Describes the managedRules structure.
	ManagedRules ManagedRulesDefinitionInput
	// The name of the policy.
	PolicyName pulumi.StringInput
	// The PolicySettings for policy.
	PolicySettings PolicySettingsPtrInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// Resource tags.
	Tags pulumi.StringMapInput
}

func (WebApplicationFirewallPolicyArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*webApplicationFirewallPolicyArgs)(nil)).Elem()
}

type WebApplicationFirewallPolicyInput interface {
	pulumi.Input

	ToWebApplicationFirewallPolicyOutput() WebApplicationFirewallPolicyOutput
	ToWebApplicationFirewallPolicyOutputWithContext(ctx context.Context) WebApplicationFirewallPolicyOutput
}

func (WebApplicationFirewallPolicy) ElementType() reflect.Type {
	return reflect.TypeOf((*WebApplicationFirewallPolicy)(nil)).Elem()
}

func (i WebApplicationFirewallPolicy) ToWebApplicationFirewallPolicyOutput() WebApplicationFirewallPolicyOutput {
	return i.ToWebApplicationFirewallPolicyOutputWithContext(context.Background())
}

func (i WebApplicationFirewallPolicy) ToWebApplicationFirewallPolicyOutputWithContext(ctx context.Context) WebApplicationFirewallPolicyOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WebApplicationFirewallPolicyOutput)
}

type WebApplicationFirewallPolicyOutput struct {
	*pulumi.OutputState
}

func (WebApplicationFirewallPolicyOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*WebApplicationFirewallPolicyOutput)(nil)).Elem()
}

func (o WebApplicationFirewallPolicyOutput) ToWebApplicationFirewallPolicyOutput() WebApplicationFirewallPolicyOutput {
	return o
}

func (o WebApplicationFirewallPolicyOutput) ToWebApplicationFirewallPolicyOutputWithContext(ctx context.Context) WebApplicationFirewallPolicyOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(WebApplicationFirewallPolicyOutput{})
}
