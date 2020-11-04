// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200501

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Virtual Appliance Site resource.
type VirtualApplianceSite struct {
	pulumi.CustomResourceState

	// Address Prefix.
	AddressPrefix pulumi.StringPtrOutput `pulumi:"addressPrefix"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringOutput `pulumi:"etag"`
	// Name of the virtual appliance site.
	Name pulumi.StringPtrOutput `pulumi:"name"`
	// Office 365 Policy.
	O365Policy Office365PolicyPropertiesResponsePtrOutput `pulumi:"o365Policy"`
	// The provisioning state of the resource.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// Site type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewVirtualApplianceSite registers a new resource with the given unique name, arguments, and options.
func NewVirtualApplianceSite(ctx *pulumi.Context,
	name string, args *VirtualApplianceSiteArgs, opts ...pulumi.ResourceOption) (*VirtualApplianceSite, error) {
	if args == nil || args.NetworkVirtualApplianceName == nil {
		return nil, errors.New("missing required argument 'NetworkVirtualApplianceName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.SiteName == nil {
		return nil, errors.New("missing required argument 'SiteName'")
	}
	if args == nil {
		args = &VirtualApplianceSiteArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:network/latest:VirtualApplianceSite"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200601:VirtualApplianceSite"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200701:VirtualApplianceSite"),
		},
	})
	opts = append(opts, aliases)
	var resource VirtualApplianceSite
	err := ctx.RegisterResource("azure-nextgen:network/v20200501:VirtualApplianceSite", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetVirtualApplianceSite gets an existing VirtualApplianceSite resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetVirtualApplianceSite(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *VirtualApplianceSiteState, opts ...pulumi.ResourceOption) (*VirtualApplianceSite, error) {
	var resource VirtualApplianceSite
	err := ctx.ReadResource("azure-nextgen:network/v20200501:VirtualApplianceSite", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering VirtualApplianceSite resources.
type virtualApplianceSiteState struct {
	// Address Prefix.
	AddressPrefix *string `pulumi:"addressPrefix"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag *string `pulumi:"etag"`
	// Name of the virtual appliance site.
	Name *string `pulumi:"name"`
	// Office 365 Policy.
	O365Policy *Office365PolicyPropertiesResponse `pulumi:"o365Policy"`
	// The provisioning state of the resource.
	ProvisioningState *string `pulumi:"provisioningState"`
	// Site type.
	Type *string `pulumi:"type"`
}

type VirtualApplianceSiteState struct {
	// Address Prefix.
	AddressPrefix pulumi.StringPtrInput
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrInput
	// Name of the virtual appliance site.
	Name pulumi.StringPtrInput
	// Office 365 Policy.
	O365Policy Office365PolicyPropertiesResponsePtrInput
	// The provisioning state of the resource.
	ProvisioningState pulumi.StringPtrInput
	// Site type.
	Type pulumi.StringPtrInput
}

func (VirtualApplianceSiteState) ElementType() reflect.Type {
	return reflect.TypeOf((*virtualApplianceSiteState)(nil)).Elem()
}

type virtualApplianceSiteArgs struct {
	// Address Prefix.
	AddressPrefix *string `pulumi:"addressPrefix"`
	// Resource ID.
	Id *string `pulumi:"id"`
	// Name of the virtual appliance site.
	Name *string `pulumi:"name"`
	// The name of the Network Virtual Appliance.
	NetworkVirtualApplianceName string `pulumi:"networkVirtualApplianceName"`
	// Office 365 Policy.
	O365Policy *Office365PolicyProperties `pulumi:"o365Policy"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the site.
	SiteName string `pulumi:"siteName"`
}

// The set of arguments for constructing a VirtualApplianceSite resource.
type VirtualApplianceSiteArgs struct {
	// Address Prefix.
	AddressPrefix pulumi.StringPtrInput
	// Resource ID.
	Id pulumi.StringPtrInput
	// Name of the virtual appliance site.
	Name pulumi.StringPtrInput
	// The name of the Network Virtual Appliance.
	NetworkVirtualApplianceName pulumi.StringInput
	// Office 365 Policy.
	O365Policy Office365PolicyPropertiesPtrInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// The name of the site.
	SiteName pulumi.StringInput
}

func (VirtualApplianceSiteArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*virtualApplianceSiteArgs)(nil)).Elem()
}
