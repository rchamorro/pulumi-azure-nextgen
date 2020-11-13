// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200717preview

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// A cluster resource
type Cluster struct {
	pulumi.CustomResourceState

	// The identity
	ClusterId pulumi.IntOutput `pulumi:"clusterId"`
	// The cluster size
	ClusterSize pulumi.IntPtrOutput `pulumi:"clusterSize"`
	// The hosts
	Hosts pulumi.StringArrayOutput `pulumi:"hosts"`
	// Resource name.
	Name pulumi.StringOutput `pulumi:"name"`
	// The state of the cluster provisioning
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// The cluster SKU
	Sku SkuResponseOutput `pulumi:"sku"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewCluster registers a new resource with the given unique name, arguments, and options.
func NewCluster(ctx *pulumi.Context,
	name string, args *ClusterArgs, opts ...pulumi.ResourceOption) (*Cluster, error) {
	if args == nil || args.ClusterName == nil {
		return nil, errors.New("missing required argument 'ClusterName'")
	}
	if args == nil || args.PrivateCloudName == nil {
		return nil, errors.New("missing required argument 'PrivateCloudName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.Sku == nil {
		return nil, errors.New("missing required argument 'Sku'")
	}
	if args == nil {
		args = &ClusterArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:avs/latest:Cluster"),
		},
		{
			Type: pulumi.String("azure-nextgen:avs/v20190809preview:Cluster"),
		},
		{
			Type: pulumi.String("azure-nextgen:avs/v20200320:Cluster"),
		},
	})
	opts = append(opts, aliases)
	var resource Cluster
	err := ctx.RegisterResource("azure-nextgen:avs/v20200717preview:Cluster", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetCluster gets an existing Cluster resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetCluster(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ClusterState, opts ...pulumi.ResourceOption) (*Cluster, error) {
	var resource Cluster
	err := ctx.ReadResource("azure-nextgen:avs/v20200717preview:Cluster", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Cluster resources.
type clusterState struct {
	// The identity
	ClusterId *int `pulumi:"clusterId"`
	// The cluster size
	ClusterSize *int `pulumi:"clusterSize"`
	// The hosts
	Hosts []string `pulumi:"hosts"`
	// Resource name.
	Name *string `pulumi:"name"`
	// The state of the cluster provisioning
	ProvisioningState *string `pulumi:"provisioningState"`
	// The cluster SKU
	Sku *SkuResponse `pulumi:"sku"`
	// Resource type.
	Type *string `pulumi:"type"`
}

type ClusterState struct {
	// The identity
	ClusterId pulumi.IntPtrInput
	// The cluster size
	ClusterSize pulumi.IntPtrInput
	// The hosts
	Hosts pulumi.StringArrayInput
	// Resource name.
	Name pulumi.StringPtrInput
	// The state of the cluster provisioning
	ProvisioningState pulumi.StringPtrInput
	// The cluster SKU
	Sku SkuResponsePtrInput
	// Resource type.
	Type pulumi.StringPtrInput
}

func (ClusterState) ElementType() reflect.Type {
	return reflect.TypeOf((*clusterState)(nil)).Elem()
}

type clusterArgs struct {
	// Name of the cluster in the private cloud
	ClusterName string `pulumi:"clusterName"`
	// The cluster size
	ClusterSize *int `pulumi:"clusterSize"`
	// The name of the private cloud.
	PrivateCloudName string `pulumi:"privateCloudName"`
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The cluster SKU
	Sku Sku `pulumi:"sku"`
}

// The set of arguments for constructing a Cluster resource.
type ClusterArgs struct {
	// Name of the cluster in the private cloud
	ClusterName pulumi.StringInput
	// The cluster size
	ClusterSize pulumi.IntPtrInput
	// The name of the private cloud.
	PrivateCloudName pulumi.StringInput
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName pulumi.StringInput
	// The cluster SKU
	Sku SkuInput
}

func (ClusterArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*clusterArgs)(nil)).Elem()
}

type ClusterInput interface {
	pulumi.Input

	ToClusterOutput() ClusterOutput
	ToClusterOutputWithContext(ctx context.Context) ClusterOutput
}

func (Cluster) ElementType() reflect.Type {
	return reflect.TypeOf((*Cluster)(nil)).Elem()
}

func (i Cluster) ToClusterOutput() ClusterOutput {
	return i.ToClusterOutputWithContext(context.Background())
}

func (i Cluster) ToClusterOutputWithContext(ctx context.Context) ClusterOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ClusterOutput)
}

type ClusterOutput struct {
	*pulumi.OutputState
}

func (ClusterOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ClusterOutput)(nil)).Elem()
}

func (o ClusterOutput) ToClusterOutput() ClusterOutput {
	return o
}

func (o ClusterOutput) ToClusterOutputWithContext(ctx context.Context) ClusterOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ClusterOutput{})
}
