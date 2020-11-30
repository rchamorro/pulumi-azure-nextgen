// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200717preview

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// NSX DHCP
type WorkloadNetworkDhcp struct {
	pulumi.CustomResourceState

	// Type of DHCP: SERVER or RELAY.
	DhcpType pulumi.StringOutput `pulumi:"dhcpType"`
	// Display name of the DHCP entity.
	DisplayName pulumi.StringPtrOutput `pulumi:"displayName"`
	// Resource name.
	Name pulumi.StringOutput `pulumi:"name"`
	// The provisioning state
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// NSX revision number.
	Revision pulumi.IntPtrOutput `pulumi:"revision"`
	// NSX Segments consuming DHCP.
	Segments pulumi.StringArrayOutput `pulumi:"segments"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewWorkloadNetworkDhcp registers a new resource with the given unique name, arguments, and options.
func NewWorkloadNetworkDhcp(ctx *pulumi.Context,
	name string, args *WorkloadNetworkDhcpArgs, opts ...pulumi.ResourceOption) (*WorkloadNetworkDhcp, error) {
	if args == nil || args.DhcpId == nil {
		return nil, errors.New("missing required argument 'DhcpId'")
	}
	if args == nil || args.DhcpType == nil {
		return nil, errors.New("missing required argument 'DhcpType'")
	}
	if args == nil || args.PrivateCloudName == nil {
		return nil, errors.New("missing required argument 'PrivateCloudName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &WorkloadNetworkDhcpArgs{}
	}
	var resource WorkloadNetworkDhcp
	err := ctx.RegisterResource("azure-nextgen:avs/v20200717preview:WorkloadNetworkDhcp", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetWorkloadNetworkDhcp gets an existing WorkloadNetworkDhcp resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetWorkloadNetworkDhcp(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *WorkloadNetworkDhcpState, opts ...pulumi.ResourceOption) (*WorkloadNetworkDhcp, error) {
	var resource WorkloadNetworkDhcp
	err := ctx.ReadResource("azure-nextgen:avs/v20200717preview:WorkloadNetworkDhcp", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering WorkloadNetworkDhcp resources.
type workloadNetworkDhcpState struct {
	// Type of DHCP: SERVER or RELAY.
	DhcpType *string `pulumi:"dhcpType"`
	// Display name of the DHCP entity.
	DisplayName *string `pulumi:"displayName"`
	// Resource name.
	Name *string `pulumi:"name"`
	// The provisioning state
	ProvisioningState *string `pulumi:"provisioningState"`
	// NSX revision number.
	Revision *int `pulumi:"revision"`
	// NSX Segments consuming DHCP.
	Segments []string `pulumi:"segments"`
	// Resource type.
	Type *string `pulumi:"type"`
}

type WorkloadNetworkDhcpState struct {
	// Type of DHCP: SERVER or RELAY.
	DhcpType pulumi.StringPtrInput
	// Display name of the DHCP entity.
	DisplayName pulumi.StringPtrInput
	// Resource name.
	Name pulumi.StringPtrInput
	// The provisioning state
	ProvisioningState pulumi.StringPtrInput
	// NSX revision number.
	Revision pulumi.IntPtrInput
	// NSX Segments consuming DHCP.
	Segments pulumi.StringArrayInput
	// Resource type.
	Type pulumi.StringPtrInput
}

func (WorkloadNetworkDhcpState) ElementType() reflect.Type {
	return reflect.TypeOf((*workloadNetworkDhcpState)(nil)).Elem()
}

type workloadNetworkDhcpArgs struct {
	// NSX DHCP identifier. Generally the same as the DHCP display name
	DhcpId string `pulumi:"dhcpId"`
	// Type of DHCP: SERVER or RELAY.
	DhcpType string `pulumi:"dhcpType"`
	// Display name of the DHCP entity.
	DisplayName *string `pulumi:"displayName"`
	// Name of the private cloud
	PrivateCloudName string `pulumi:"privateCloudName"`
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// NSX revision number.
	Revision *int `pulumi:"revision"`
}

// The set of arguments for constructing a WorkloadNetworkDhcp resource.
type WorkloadNetworkDhcpArgs struct {
	// NSX DHCP identifier. Generally the same as the DHCP display name
	DhcpId pulumi.StringInput
	// Type of DHCP: SERVER or RELAY.
	DhcpType pulumi.StringInput
	// Display name of the DHCP entity.
	DisplayName pulumi.StringPtrInput
	// Name of the private cloud
	PrivateCloudName pulumi.StringInput
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName pulumi.StringInput
	// NSX revision number.
	Revision pulumi.IntPtrInput
}

func (WorkloadNetworkDhcpArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*workloadNetworkDhcpArgs)(nil)).Elem()
}

type WorkloadNetworkDhcpInput interface {
	pulumi.Input

	ToWorkloadNetworkDhcpOutput() WorkloadNetworkDhcpOutput
	ToWorkloadNetworkDhcpOutputWithContext(ctx context.Context) WorkloadNetworkDhcpOutput
}

func (WorkloadNetworkDhcp) ElementType() reflect.Type {
	return reflect.TypeOf((*WorkloadNetworkDhcp)(nil)).Elem()
}

func (i WorkloadNetworkDhcp) ToWorkloadNetworkDhcpOutput() WorkloadNetworkDhcpOutput {
	return i.ToWorkloadNetworkDhcpOutputWithContext(context.Background())
}

func (i WorkloadNetworkDhcp) ToWorkloadNetworkDhcpOutputWithContext(ctx context.Context) WorkloadNetworkDhcpOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WorkloadNetworkDhcpOutput)
}

type WorkloadNetworkDhcpOutput struct {
	*pulumi.OutputState
}

func (WorkloadNetworkDhcpOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*WorkloadNetworkDhcpOutput)(nil)).Elem()
}

func (o WorkloadNetworkDhcpOutput) ToWorkloadNetworkDhcpOutput() WorkloadNetworkDhcpOutput {
	return o
}

func (o WorkloadNetworkDhcpOutput) ToWorkloadNetworkDhcpOutputWithContext(ctx context.Context) WorkloadNetworkDhcpOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(WorkloadNetworkDhcpOutput{})
}