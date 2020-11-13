// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20180715preview

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// A Database Migration Service resource
type Service struct {
	pulumi.CustomResourceState

	// HTTP strong entity tag value. Ignored if submitted
	Etag pulumi.StringPtrOutput `pulumi:"etag"`
	// The resource kind. Only 'vm' (the default) is supported.
	Kind pulumi.StringPtrOutput `pulumi:"kind"`
	// Resource location.
	Location pulumi.StringOutput `pulumi:"location"`
	// Resource name.
	Name pulumi.StringOutput `pulumi:"name"`
	// The resource's provisioning state
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// The public key of the service, used to encrypt secrets sent to the service
	PublicKey pulumi.StringPtrOutput `pulumi:"publicKey"`
	// Service SKU
	Sku ServiceSkuResponsePtrOutput `pulumi:"sku"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
	// The ID of the Microsoft.Network/networkInterfaces resource which the service have
	VirtualNicId pulumi.StringPtrOutput `pulumi:"virtualNicId"`
	// The ID of the Microsoft.Network/virtualNetworks/subnets resource to which the service should be joined
	VirtualSubnetId pulumi.StringOutput `pulumi:"virtualSubnetId"`
}

// NewService registers a new resource with the given unique name, arguments, and options.
func NewService(ctx *pulumi.Context,
	name string, args *ServiceArgs, opts ...pulumi.ResourceOption) (*Service, error) {
	if args == nil || args.GroupName == nil {
		return nil, errors.New("missing required argument 'GroupName'")
	}
	if args == nil || args.Location == nil {
		return nil, errors.New("missing required argument 'Location'")
	}
	if args == nil || args.ServiceName == nil {
		return nil, errors.New("missing required argument 'ServiceName'")
	}
	if args == nil || args.VirtualSubnetId == nil {
		return nil, errors.New("missing required argument 'VirtualSubnetId'")
	}
	if args == nil {
		args = &ServiceArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:datamigration/latest:Service"),
		},
		{
			Type: pulumi.String("azure-nextgen:datamigration/v20171115preview:Service"),
		},
		{
			Type: pulumi.String("azure-nextgen:datamigration/v20180315preview:Service"),
		},
		{
			Type: pulumi.String("azure-nextgen:datamigration/v20180331preview:Service"),
		},
		{
			Type: pulumi.String("azure-nextgen:datamigration/v20180419:Service"),
		},
	})
	opts = append(opts, aliases)
	var resource Service
	err := ctx.RegisterResource("azure-nextgen:datamigration/v20180715preview:Service", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetService gets an existing Service resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetService(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ServiceState, opts ...pulumi.ResourceOption) (*Service, error) {
	var resource Service
	err := ctx.ReadResource("azure-nextgen:datamigration/v20180715preview:Service", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Service resources.
type serviceState struct {
	// HTTP strong entity tag value. Ignored if submitted
	Etag *string `pulumi:"etag"`
	// The resource kind. Only 'vm' (the default) is supported.
	Kind *string `pulumi:"kind"`
	// Resource location.
	Location *string `pulumi:"location"`
	// Resource name.
	Name *string `pulumi:"name"`
	// The resource's provisioning state
	ProvisioningState *string `pulumi:"provisioningState"`
	// The public key of the service, used to encrypt secrets sent to the service
	PublicKey *string `pulumi:"publicKey"`
	// Service SKU
	Sku *ServiceSkuResponse `pulumi:"sku"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Resource type.
	Type *string `pulumi:"type"`
	// The ID of the Microsoft.Network/networkInterfaces resource which the service have
	VirtualNicId *string `pulumi:"virtualNicId"`
	// The ID of the Microsoft.Network/virtualNetworks/subnets resource to which the service should be joined
	VirtualSubnetId *string `pulumi:"virtualSubnetId"`
}

type ServiceState struct {
	// HTTP strong entity tag value. Ignored if submitted
	Etag pulumi.StringPtrInput
	// The resource kind. Only 'vm' (the default) is supported.
	Kind pulumi.StringPtrInput
	// Resource location.
	Location pulumi.StringPtrInput
	// Resource name.
	Name pulumi.StringPtrInput
	// The resource's provisioning state
	ProvisioningState pulumi.StringPtrInput
	// The public key of the service, used to encrypt secrets sent to the service
	PublicKey pulumi.StringPtrInput
	// Service SKU
	Sku ServiceSkuResponsePtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// Resource type.
	Type pulumi.StringPtrInput
	// The ID of the Microsoft.Network/networkInterfaces resource which the service have
	VirtualNicId pulumi.StringPtrInput
	// The ID of the Microsoft.Network/virtualNetworks/subnets resource to which the service should be joined
	VirtualSubnetId pulumi.StringPtrInput
}

func (ServiceState) ElementType() reflect.Type {
	return reflect.TypeOf((*serviceState)(nil)).Elem()
}

type serviceArgs struct {
	// HTTP strong entity tag value. Ignored if submitted
	Etag *string `pulumi:"etag"`
	// Name of the resource group
	GroupName string `pulumi:"groupName"`
	// The resource kind. Only 'vm' (the default) is supported.
	Kind *string `pulumi:"kind"`
	// Resource location.
	Location string `pulumi:"location"`
	// The public key of the service, used to encrypt secrets sent to the service
	PublicKey *string `pulumi:"publicKey"`
	// Name of the service
	ServiceName string `pulumi:"serviceName"`
	// Service SKU
	Sku *ServiceSku `pulumi:"sku"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// The ID of the Microsoft.Network/networkInterfaces resource which the service have
	VirtualNicId *string `pulumi:"virtualNicId"`
	// The ID of the Microsoft.Network/virtualNetworks/subnets resource to which the service should be joined
	VirtualSubnetId string `pulumi:"virtualSubnetId"`
}

// The set of arguments for constructing a Service resource.
type ServiceArgs struct {
	// HTTP strong entity tag value. Ignored if submitted
	Etag pulumi.StringPtrInput
	// Name of the resource group
	GroupName pulumi.StringInput
	// The resource kind. Only 'vm' (the default) is supported.
	Kind pulumi.StringPtrInput
	// Resource location.
	Location pulumi.StringInput
	// The public key of the service, used to encrypt secrets sent to the service
	PublicKey pulumi.StringPtrInput
	// Name of the service
	ServiceName pulumi.StringInput
	// Service SKU
	Sku ServiceSkuPtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// The ID of the Microsoft.Network/networkInterfaces resource which the service have
	VirtualNicId pulumi.StringPtrInput
	// The ID of the Microsoft.Network/virtualNetworks/subnets resource to which the service should be joined
	VirtualSubnetId pulumi.StringInput
}

func (ServiceArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*serviceArgs)(nil)).Elem()
}

type ServiceInput interface {
	pulumi.Input

	ToServiceOutput() ServiceOutput
	ToServiceOutputWithContext(ctx context.Context) ServiceOutput
}

func (Service) ElementType() reflect.Type {
	return reflect.TypeOf((*Service)(nil)).Elem()
}

func (i Service) ToServiceOutput() ServiceOutput {
	return i.ToServiceOutputWithContext(context.Background())
}

func (i Service) ToServiceOutputWithContext(ctx context.Context) ServiceOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ServiceOutput)
}

type ServiceOutput struct {
	*pulumi.OutputState
}

func (ServiceOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ServiceOutput)(nil)).Elem()
}

func (o ServiceOutput) ToServiceOutput() ServiceOutput {
	return o
}

func (o ServiceOutput) ToServiceOutputWithContext(ctx context.Context) ServiceOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ServiceOutput{})
}
