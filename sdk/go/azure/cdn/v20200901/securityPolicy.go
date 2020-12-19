// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200901

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// SecurityPolicy association for AzureFrontDoor profile
type SecurityPolicy struct {
	pulumi.CustomResourceState

	DeploymentStatus pulumi.StringOutput `pulumi:"deploymentStatus"`
	// Resource name.
	Name pulumi.StringOutput `pulumi:"name"`
	// object which contains security policy parameters
	Parameters SecurityPolicyWebApplicationFirewallParametersResponsePtrOutput `pulumi:"parameters"`
	// Provisioning status
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// Read only system data
	SystemData SystemDataResponseOutput `pulumi:"systemData"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewSecurityPolicy registers a new resource with the given unique name, arguments, and options.
func NewSecurityPolicy(ctx *pulumi.Context,
	name string, args *SecurityPolicyArgs, opts ...pulumi.ResourceOption) (*SecurityPolicy, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ProfileName == nil {
		return nil, errors.New("invalid value for required argument 'ProfileName'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	if args.SecurityPolicyName == nil {
		return nil, errors.New("invalid value for required argument 'SecurityPolicyName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:cdn/latest:SecurityPolicy"),
		},
	})
	opts = append(opts, aliases)
	var resource SecurityPolicy
	err := ctx.RegisterResource("azure-nextgen:cdn/v20200901:SecurityPolicy", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSecurityPolicy gets an existing SecurityPolicy resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSecurityPolicy(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SecurityPolicyState, opts ...pulumi.ResourceOption) (*SecurityPolicy, error) {
	var resource SecurityPolicy
	err := ctx.ReadResource("azure-nextgen:cdn/v20200901:SecurityPolicy", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering SecurityPolicy resources.
type securityPolicyState struct {
	DeploymentStatus *string `pulumi:"deploymentStatus"`
	// Resource name.
	Name *string `pulumi:"name"`
	// object which contains security policy parameters
	Parameters *SecurityPolicyWebApplicationFirewallParametersResponse `pulumi:"parameters"`
	// Provisioning status
	ProvisioningState *string `pulumi:"provisioningState"`
	// Read only system data
	SystemData *SystemDataResponse `pulumi:"systemData"`
	// Resource type.
	Type *string `pulumi:"type"`
}

type SecurityPolicyState struct {
	DeploymentStatus pulumi.StringPtrInput
	// Resource name.
	Name pulumi.StringPtrInput
	// object which contains security policy parameters
	Parameters SecurityPolicyWebApplicationFirewallParametersResponsePtrInput
	// Provisioning status
	ProvisioningState pulumi.StringPtrInput
	// Read only system data
	SystemData SystemDataResponsePtrInput
	// Resource type.
	Type pulumi.StringPtrInput
}

func (SecurityPolicyState) ElementType() reflect.Type {
	return reflect.TypeOf((*securityPolicyState)(nil)).Elem()
}

type securityPolicyArgs struct {
	// object which contains security policy parameters
	Parameters *SecurityPolicyWebApplicationFirewallParameters `pulumi:"parameters"`
	// Name of the CDN profile which is unique within the resource group.
	ProfileName string `pulumi:"profileName"`
	// Name of the Resource group within the Azure subscription.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Name of the security policy under the profile.
	SecurityPolicyName string `pulumi:"securityPolicyName"`
}

// The set of arguments for constructing a SecurityPolicy resource.
type SecurityPolicyArgs struct {
	// object which contains security policy parameters
	Parameters SecurityPolicyWebApplicationFirewallParametersPtrInput
	// Name of the CDN profile which is unique within the resource group.
	ProfileName pulumi.StringInput
	// Name of the Resource group within the Azure subscription.
	ResourceGroupName pulumi.StringInput
	// Name of the security policy under the profile.
	SecurityPolicyName pulumi.StringInput
}

func (SecurityPolicyArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*securityPolicyArgs)(nil)).Elem()
}

type SecurityPolicyInput interface {
	pulumi.Input

	ToSecurityPolicyOutput() SecurityPolicyOutput
	ToSecurityPolicyOutputWithContext(ctx context.Context) SecurityPolicyOutput
}

func (*SecurityPolicy) ElementType() reflect.Type {
	return reflect.TypeOf((*SecurityPolicy)(nil))
}

func (i *SecurityPolicy) ToSecurityPolicyOutput() SecurityPolicyOutput {
	return i.ToSecurityPolicyOutputWithContext(context.Background())
}

func (i *SecurityPolicy) ToSecurityPolicyOutputWithContext(ctx context.Context) SecurityPolicyOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SecurityPolicyOutput)
}

type SecurityPolicyOutput struct {
	*pulumi.OutputState
}

func (SecurityPolicyOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*SecurityPolicy)(nil))
}

func (o SecurityPolicyOutput) ToSecurityPolicyOutput() SecurityPolicyOutput {
	return o
}

func (o SecurityPolicyOutput) ToSecurityPolicyOutputWithContext(ctx context.Context) SecurityPolicyOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(SecurityPolicyOutput{})
}
