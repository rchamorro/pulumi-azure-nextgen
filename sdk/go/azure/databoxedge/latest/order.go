// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// The order details.
type Order struct {
	pulumi.CustomResourceState

	// The contact details.
	ContactInformation ContactDetailsResponseOutput `pulumi:"contactInformation"`
	// Current status of the order.
	CurrentStatus OrderStatusResponsePtrOutput `pulumi:"currentStatus"`
	// Tracking information for the package delivered to the customer whether it has an original or a replacement device.
	DeliveryTrackingInfo TrackingInfoResponseArrayOutput `pulumi:"deliveryTrackingInfo"`
	// The object name.
	Name pulumi.StringOutput `pulumi:"name"`
	// List of status changes in the order.
	OrderHistory OrderStatusResponseArrayOutput `pulumi:"orderHistory"`
	// Tracking information for the package returned from the customer whether it has an original or a replacement device.
	ReturnTrackingInfo TrackingInfoResponseArrayOutput `pulumi:"returnTrackingInfo"`
	// Serial number of the device.
	SerialNumber pulumi.StringOutput `pulumi:"serialNumber"`
	// The shipping address.
	ShippingAddress AddressResponseOutput `pulumi:"shippingAddress"`
	// The hierarchical type of the object.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewOrder registers a new resource with the given unique name, arguments, and options.
func NewOrder(ctx *pulumi.Context,
	name string, args *OrderArgs, opts ...pulumi.ResourceOption) (*Order, error) {
	if args == nil || args.ContactInformation == nil {
		return nil, errors.New("missing required argument 'ContactInformation'")
	}
	if args == nil || args.DeviceName == nil {
		return nil, errors.New("missing required argument 'DeviceName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.ShippingAddress == nil {
		return nil, errors.New("missing required argument 'ShippingAddress'")
	}
	if args == nil {
		args = &OrderArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:databoxedge/v20190301:Order"),
		},
		{
			Type: pulumi.String("azure-nextgen:databoxedge/v20190701:Order"),
		},
		{
			Type: pulumi.String("azure-nextgen:databoxedge/v20190801:Order"),
		},
		{
			Type: pulumi.String("azure-nextgen:databoxedge/v20200501preview:Order"),
		},
	})
	opts = append(opts, aliases)
	var resource Order
	err := ctx.RegisterResource("azure-nextgen:databoxedge/latest:Order", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetOrder gets an existing Order resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetOrder(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *OrderState, opts ...pulumi.ResourceOption) (*Order, error) {
	var resource Order
	err := ctx.ReadResource("azure-nextgen:databoxedge/latest:Order", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Order resources.
type orderState struct {
	// The contact details.
	ContactInformation *ContactDetailsResponse `pulumi:"contactInformation"`
	// Current status of the order.
	CurrentStatus *OrderStatusResponse `pulumi:"currentStatus"`
	// Tracking information for the package delivered to the customer whether it has an original or a replacement device.
	DeliveryTrackingInfo []TrackingInfoResponse `pulumi:"deliveryTrackingInfo"`
	// The object name.
	Name *string `pulumi:"name"`
	// List of status changes in the order.
	OrderHistory []OrderStatusResponse `pulumi:"orderHistory"`
	// Tracking information for the package returned from the customer whether it has an original or a replacement device.
	ReturnTrackingInfo []TrackingInfoResponse `pulumi:"returnTrackingInfo"`
	// Serial number of the device.
	SerialNumber *string `pulumi:"serialNumber"`
	// The shipping address.
	ShippingAddress *AddressResponse `pulumi:"shippingAddress"`
	// The hierarchical type of the object.
	Type *string `pulumi:"type"`
}

type OrderState struct {
	// The contact details.
	ContactInformation ContactDetailsResponsePtrInput
	// Current status of the order.
	CurrentStatus OrderStatusResponsePtrInput
	// Tracking information for the package delivered to the customer whether it has an original or a replacement device.
	DeliveryTrackingInfo TrackingInfoResponseArrayInput
	// The object name.
	Name pulumi.StringPtrInput
	// List of status changes in the order.
	OrderHistory OrderStatusResponseArrayInput
	// Tracking information for the package returned from the customer whether it has an original or a replacement device.
	ReturnTrackingInfo TrackingInfoResponseArrayInput
	// Serial number of the device.
	SerialNumber pulumi.StringPtrInput
	// The shipping address.
	ShippingAddress AddressResponsePtrInput
	// The hierarchical type of the object.
	Type pulumi.StringPtrInput
}

func (OrderState) ElementType() reflect.Type {
	return reflect.TypeOf((*orderState)(nil)).Elem()
}

type orderArgs struct {
	// The contact details.
	ContactInformation ContactDetails `pulumi:"contactInformation"`
	// Current status of the order.
	CurrentStatus *OrderStatus `pulumi:"currentStatus"`
	// The order details of a device.
	DeviceName string `pulumi:"deviceName"`
	// The resource group name.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The shipping address.
	ShippingAddress Address `pulumi:"shippingAddress"`
}

// The set of arguments for constructing a Order resource.
type OrderArgs struct {
	// The contact details.
	ContactInformation ContactDetailsInput
	// Current status of the order.
	CurrentStatus OrderStatusPtrInput
	// The order details of a device.
	DeviceName pulumi.StringInput
	// The resource group name.
	ResourceGroupName pulumi.StringInput
	// The shipping address.
	ShippingAddress AddressInput
}

func (OrderArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*orderArgs)(nil)).Elem()
}

type OrderInput interface {
	pulumi.Input

	ToOrderOutput() OrderOutput
	ToOrderOutputWithContext(ctx context.Context) OrderOutput
}

func (Order) ElementType() reflect.Type {
	return reflect.TypeOf((*Order)(nil)).Elem()
}

func (i Order) ToOrderOutput() OrderOutput {
	return i.ToOrderOutputWithContext(context.Background())
}

func (i Order) ToOrderOutputWithContext(ctx context.Context) OrderOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OrderOutput)
}

type OrderOutput struct {
	*pulumi.OutputState
}

func (OrderOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*OrderOutput)(nil)).Elem()
}

func (o OrderOutput) ToOrderOutput() OrderOutput {
	return o
}

func (o OrderOutput) ToOrderOutputWithContext(ctx context.Context) OrderOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(OrderOutput{})
}
