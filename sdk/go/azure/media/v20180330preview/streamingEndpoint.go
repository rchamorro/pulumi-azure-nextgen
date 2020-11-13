// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20180330preview

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// The StreamingEndpoint.
type StreamingEndpoint struct {
	pulumi.CustomResourceState

	// The access control definition of the StreamingEndpoint.
	AccessControl StreamingEndpointAccessControlResponsePtrOutput `pulumi:"accessControl"`
	// AvailabilitySet name
	AvailabilitySetName pulumi.StringPtrOutput `pulumi:"availabilitySetName"`
	// The CDN enabled flag.
	CdnEnabled pulumi.BoolPtrOutput `pulumi:"cdnEnabled"`
	// The CDN profile name.
	CdnProfile pulumi.StringPtrOutput `pulumi:"cdnProfile"`
	// The CDN provider name.
	CdnProvider pulumi.StringPtrOutput `pulumi:"cdnProvider"`
	// The exact time the StreamingEndpoint was created.
	Created pulumi.StringOutput `pulumi:"created"`
	// The StreamingEndpoint access policies.
	CrossSiteAccessPolicies CrossSiteAccessPoliciesResponsePtrOutput `pulumi:"crossSiteAccessPolicies"`
	// The custom host names of the StreamingEndpoint
	CustomHostNames pulumi.StringArrayOutput `pulumi:"customHostNames"`
	// The StreamingEndpoint description.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// The free trial expiration time.
	FreeTrialEndTime pulumi.StringOutput `pulumi:"freeTrialEndTime"`
	// The StreamingEndpoint host name.
	HostName pulumi.StringOutput `pulumi:"hostName"`
	// The exact time the StreamingEndpoint was last modified.
	LastModified pulumi.StringOutput `pulumi:"lastModified"`
	// The Azure Region of the resource.
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// Max cache age
	MaxCacheAge pulumi.IntPtrOutput `pulumi:"maxCacheAge"`
	// The name of the resource.
	Name pulumi.StringOutput `pulumi:"name"`
	// The provisioning state of the StreamingEndpoint.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// The resource state of the StreamingEndpoint.
	ResourceState pulumi.StringOutput `pulumi:"resourceState"`
	// The number of scale units.
	ScaleUnits pulumi.IntPtrOutput `pulumi:"scaleUnits"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// The type of the resource.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewStreamingEndpoint registers a new resource with the given unique name, arguments, and options.
func NewStreamingEndpoint(ctx *pulumi.Context,
	name string, args *StreamingEndpointArgs, opts ...pulumi.ResourceOption) (*StreamingEndpoint, error) {
	if args == nil || args.AccountName == nil {
		return nil, errors.New("missing required argument 'AccountName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.StreamingEndpointName == nil {
		return nil, errors.New("missing required argument 'StreamingEndpointName'")
	}
	if args == nil {
		args = &StreamingEndpointArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:media/latest:StreamingEndpoint"),
		},
		{
			Type: pulumi.String("azure-nextgen:media/v20180601preview:StreamingEndpoint"),
		},
		{
			Type: pulumi.String("azure-nextgen:media/v20180701:StreamingEndpoint"),
		},
		{
			Type: pulumi.String("azure-nextgen:media/v20190501preview:StreamingEndpoint"),
		},
		{
			Type: pulumi.String("azure-nextgen:media/v20200501:StreamingEndpoint"),
		},
	})
	opts = append(opts, aliases)
	var resource StreamingEndpoint
	err := ctx.RegisterResource("azure-nextgen:media/v20180330preview:StreamingEndpoint", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetStreamingEndpoint gets an existing StreamingEndpoint resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetStreamingEndpoint(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *StreamingEndpointState, opts ...pulumi.ResourceOption) (*StreamingEndpoint, error) {
	var resource StreamingEndpoint
	err := ctx.ReadResource("azure-nextgen:media/v20180330preview:StreamingEndpoint", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering StreamingEndpoint resources.
type streamingEndpointState struct {
	// The access control definition of the StreamingEndpoint.
	AccessControl *StreamingEndpointAccessControlResponse `pulumi:"accessControl"`
	// AvailabilitySet name
	AvailabilitySetName *string `pulumi:"availabilitySetName"`
	// The CDN enabled flag.
	CdnEnabled *bool `pulumi:"cdnEnabled"`
	// The CDN profile name.
	CdnProfile *string `pulumi:"cdnProfile"`
	// The CDN provider name.
	CdnProvider *string `pulumi:"cdnProvider"`
	// The exact time the StreamingEndpoint was created.
	Created *string `pulumi:"created"`
	// The StreamingEndpoint access policies.
	CrossSiteAccessPolicies *CrossSiteAccessPoliciesResponse `pulumi:"crossSiteAccessPolicies"`
	// The custom host names of the StreamingEndpoint
	CustomHostNames []string `pulumi:"customHostNames"`
	// The StreamingEndpoint description.
	Description *string `pulumi:"description"`
	// The free trial expiration time.
	FreeTrialEndTime *string `pulumi:"freeTrialEndTime"`
	// The StreamingEndpoint host name.
	HostName *string `pulumi:"hostName"`
	// The exact time the StreamingEndpoint was last modified.
	LastModified *string `pulumi:"lastModified"`
	// The Azure Region of the resource.
	Location *string `pulumi:"location"`
	// Max cache age
	MaxCacheAge *int `pulumi:"maxCacheAge"`
	// The name of the resource.
	Name *string `pulumi:"name"`
	// The provisioning state of the StreamingEndpoint.
	ProvisioningState *string `pulumi:"provisioningState"`
	// The resource state of the StreamingEndpoint.
	ResourceState *string `pulumi:"resourceState"`
	// The number of scale units.
	ScaleUnits *int `pulumi:"scaleUnits"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// The type of the resource.
	Type *string `pulumi:"type"`
}

type StreamingEndpointState struct {
	// The access control definition of the StreamingEndpoint.
	AccessControl StreamingEndpointAccessControlResponsePtrInput
	// AvailabilitySet name
	AvailabilitySetName pulumi.StringPtrInput
	// The CDN enabled flag.
	CdnEnabled pulumi.BoolPtrInput
	// The CDN profile name.
	CdnProfile pulumi.StringPtrInput
	// The CDN provider name.
	CdnProvider pulumi.StringPtrInput
	// The exact time the StreamingEndpoint was created.
	Created pulumi.StringPtrInput
	// The StreamingEndpoint access policies.
	CrossSiteAccessPolicies CrossSiteAccessPoliciesResponsePtrInput
	// The custom host names of the StreamingEndpoint
	CustomHostNames pulumi.StringArrayInput
	// The StreamingEndpoint description.
	Description pulumi.StringPtrInput
	// The free trial expiration time.
	FreeTrialEndTime pulumi.StringPtrInput
	// The StreamingEndpoint host name.
	HostName pulumi.StringPtrInput
	// The exact time the StreamingEndpoint was last modified.
	LastModified pulumi.StringPtrInput
	// The Azure Region of the resource.
	Location pulumi.StringPtrInput
	// Max cache age
	MaxCacheAge pulumi.IntPtrInput
	// The name of the resource.
	Name pulumi.StringPtrInput
	// The provisioning state of the StreamingEndpoint.
	ProvisioningState pulumi.StringPtrInput
	// The resource state of the StreamingEndpoint.
	ResourceState pulumi.StringPtrInput
	// The number of scale units.
	ScaleUnits pulumi.IntPtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// The type of the resource.
	Type pulumi.StringPtrInput
}

func (StreamingEndpointState) ElementType() reflect.Type {
	return reflect.TypeOf((*streamingEndpointState)(nil)).Elem()
}

type streamingEndpointArgs struct {
	// The access control definition of the StreamingEndpoint.
	AccessControl *StreamingEndpointAccessControl `pulumi:"accessControl"`
	// The Media Services account name.
	AccountName string `pulumi:"accountName"`
	// The flag indicates if auto start the Live Event.
	AutoStart *bool `pulumi:"autoStart"`
	// AvailabilitySet name
	AvailabilitySetName *string `pulumi:"availabilitySetName"`
	// The CDN enabled flag.
	CdnEnabled *bool `pulumi:"cdnEnabled"`
	// The CDN profile name.
	CdnProfile *string `pulumi:"cdnProfile"`
	// The CDN provider name.
	CdnProvider *string `pulumi:"cdnProvider"`
	// The StreamingEndpoint access policies.
	CrossSiteAccessPolicies *CrossSiteAccessPolicies `pulumi:"crossSiteAccessPolicies"`
	// The custom host names of the StreamingEndpoint
	CustomHostNames []string `pulumi:"customHostNames"`
	// The StreamingEndpoint description.
	Description *string `pulumi:"description"`
	// The Azure Region of the resource.
	Location *string `pulumi:"location"`
	// Max cache age
	MaxCacheAge *int `pulumi:"maxCacheAge"`
	// The name of the resource group within the Azure subscription.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The number of scale units.
	ScaleUnits *int `pulumi:"scaleUnits"`
	// The name of the StreamingEndpoint.
	StreamingEndpointName string `pulumi:"streamingEndpointName"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a StreamingEndpoint resource.
type StreamingEndpointArgs struct {
	// The access control definition of the StreamingEndpoint.
	AccessControl StreamingEndpointAccessControlPtrInput
	// The Media Services account name.
	AccountName pulumi.StringInput
	// The flag indicates if auto start the Live Event.
	AutoStart pulumi.BoolPtrInput
	// AvailabilitySet name
	AvailabilitySetName pulumi.StringPtrInput
	// The CDN enabled flag.
	CdnEnabled pulumi.BoolPtrInput
	// The CDN profile name.
	CdnProfile pulumi.StringPtrInput
	// The CDN provider name.
	CdnProvider pulumi.StringPtrInput
	// The StreamingEndpoint access policies.
	CrossSiteAccessPolicies CrossSiteAccessPoliciesPtrInput
	// The custom host names of the StreamingEndpoint
	CustomHostNames pulumi.StringArrayInput
	// The StreamingEndpoint description.
	Description pulumi.StringPtrInput
	// The Azure Region of the resource.
	Location pulumi.StringPtrInput
	// Max cache age
	MaxCacheAge pulumi.IntPtrInput
	// The name of the resource group within the Azure subscription.
	ResourceGroupName pulumi.StringInput
	// The number of scale units.
	ScaleUnits pulumi.IntPtrInput
	// The name of the StreamingEndpoint.
	StreamingEndpointName pulumi.StringInput
	// Resource tags.
	Tags pulumi.StringMapInput
}

func (StreamingEndpointArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*streamingEndpointArgs)(nil)).Elem()
}

type StreamingEndpointInput interface {
	pulumi.Input

	ToStreamingEndpointOutput() StreamingEndpointOutput
	ToStreamingEndpointOutputWithContext(ctx context.Context) StreamingEndpointOutput
}

func (StreamingEndpoint) ElementType() reflect.Type {
	return reflect.TypeOf((*StreamingEndpoint)(nil)).Elem()
}

func (i StreamingEndpoint) ToStreamingEndpointOutput() StreamingEndpointOutput {
	return i.ToStreamingEndpointOutputWithContext(context.Background())
}

func (i StreamingEndpoint) ToStreamingEndpointOutputWithContext(ctx context.Context) StreamingEndpointOutput {
	return pulumi.ToOutputWithContext(ctx, i).(StreamingEndpointOutput)
}

type StreamingEndpointOutput struct {
	*pulumi.OutputState
}

func (StreamingEndpointOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*StreamingEndpointOutput)(nil)).Elem()
}

func (o StreamingEndpointOutput) ToStreamingEndpointOutput() StreamingEndpointOutput {
	return o
}

func (o StreamingEndpointOutput) ToStreamingEndpointOutputWithContext(ctx context.Context) StreamingEndpointOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(StreamingEndpointOutput{})
}
