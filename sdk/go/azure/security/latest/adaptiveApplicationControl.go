// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type AdaptiveApplicationControl struct {
	pulumi.CustomResourceState

	// The configuration status of the machines group or machine or rule
	ConfigurationStatus pulumi.StringOutput `pulumi:"configurationStatus"`
	// The application control policy enforcement/protection mode of the machine group
	EnforcementMode pulumi.StringPtrOutput                                    `pulumi:"enforcementMode"`
	Issues          AdaptiveApplicationControlIssueSummaryResponseArrayOutput `pulumi:"issues"`
	// Location where the resource is stored
	Location pulumi.StringOutput `pulumi:"location"`
	// Resource name
	Name                pulumi.StringOutput                   `pulumi:"name"`
	PathRecommendations PathRecommendationResponseArrayOutput `pulumi:"pathRecommendations"`
	// The protection mode of the collection/file types. Exe/Msi/Script are used for Windows, Executable is used for Linux.
	ProtectionMode ProtectionModeResponsePtrOutput `pulumi:"protectionMode"`
	// The initial recommendation status of the machine group or machine
	RecommendationStatus pulumi.StringOutput `pulumi:"recommendationStatus"`
	// The source type of the machine group
	SourceSystem pulumi.StringOutput `pulumi:"sourceSystem"`
	// Resource type
	Type              pulumi.StringOutput                 `pulumi:"type"`
	VmRecommendations VmRecommendationResponseArrayOutput `pulumi:"vmRecommendations"`
}

// NewAdaptiveApplicationControl registers a new resource with the given unique name, arguments, and options.
func NewAdaptiveApplicationControl(ctx *pulumi.Context,
	name string, args *AdaptiveApplicationControlArgs, opts ...pulumi.ResourceOption) (*AdaptiveApplicationControl, error) {
	if args == nil || args.AscLocation == nil {
		return nil, errors.New("missing required argument 'AscLocation'")
	}
	if args == nil || args.GroupName == nil {
		return nil, errors.New("missing required argument 'GroupName'")
	}
	if args == nil {
		args = &AdaptiveApplicationControlArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:security/v20150601preview:AdaptiveApplicationControl"),
		},
		{
			Type: pulumi.String("azure-nextgen:security/v20200101:AdaptiveApplicationControl"),
		},
	})
	opts = append(opts, aliases)
	var resource AdaptiveApplicationControl
	err := ctx.RegisterResource("azure-nextgen:security/latest:AdaptiveApplicationControl", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetAdaptiveApplicationControl gets an existing AdaptiveApplicationControl resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAdaptiveApplicationControl(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *AdaptiveApplicationControlState, opts ...pulumi.ResourceOption) (*AdaptiveApplicationControl, error) {
	var resource AdaptiveApplicationControl
	err := ctx.ReadResource("azure-nextgen:security/latest:AdaptiveApplicationControl", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering AdaptiveApplicationControl resources.
type adaptiveApplicationControlState struct {
	// The configuration status of the machines group or machine or rule
	ConfigurationStatus *string `pulumi:"configurationStatus"`
	// The application control policy enforcement/protection mode of the machine group
	EnforcementMode *string                                          `pulumi:"enforcementMode"`
	Issues          []AdaptiveApplicationControlIssueSummaryResponse `pulumi:"issues"`
	// Location where the resource is stored
	Location *string `pulumi:"location"`
	// Resource name
	Name                *string                      `pulumi:"name"`
	PathRecommendations []PathRecommendationResponse `pulumi:"pathRecommendations"`
	// The protection mode of the collection/file types. Exe/Msi/Script are used for Windows, Executable is used for Linux.
	ProtectionMode *ProtectionModeResponse `pulumi:"protectionMode"`
	// The initial recommendation status of the machine group or machine
	RecommendationStatus *string `pulumi:"recommendationStatus"`
	// The source type of the machine group
	SourceSystem *string `pulumi:"sourceSystem"`
	// Resource type
	Type              *string                    `pulumi:"type"`
	VmRecommendations []VmRecommendationResponse `pulumi:"vmRecommendations"`
}

type AdaptiveApplicationControlState struct {
	// The configuration status of the machines group or machine or rule
	ConfigurationStatus pulumi.StringPtrInput
	// The application control policy enforcement/protection mode of the machine group
	EnforcementMode pulumi.StringPtrInput
	Issues          AdaptiveApplicationControlIssueSummaryResponseArrayInput
	// Location where the resource is stored
	Location pulumi.StringPtrInput
	// Resource name
	Name                pulumi.StringPtrInput
	PathRecommendations PathRecommendationResponseArrayInput
	// The protection mode of the collection/file types. Exe/Msi/Script are used for Windows, Executable is used for Linux.
	ProtectionMode ProtectionModeResponsePtrInput
	// The initial recommendation status of the machine group or machine
	RecommendationStatus pulumi.StringPtrInput
	// The source type of the machine group
	SourceSystem pulumi.StringPtrInput
	// Resource type
	Type              pulumi.StringPtrInput
	VmRecommendations VmRecommendationResponseArrayInput
}

func (AdaptiveApplicationControlState) ElementType() reflect.Type {
	return reflect.TypeOf((*adaptiveApplicationControlState)(nil)).Elem()
}

type adaptiveApplicationControlArgs struct {
	// The location where ASC stores the data of the subscription. can be retrieved from Get locations
	AscLocation string `pulumi:"ascLocation"`
	// The application control policy enforcement/protection mode of the machine group
	EnforcementMode *string `pulumi:"enforcementMode"`
	// Name of an application control machine group
	GroupName           string               `pulumi:"groupName"`
	PathRecommendations []PathRecommendation `pulumi:"pathRecommendations"`
	// The protection mode of the collection/file types. Exe/Msi/Script are used for Windows, Executable is used for Linux.
	ProtectionMode    *ProtectionMode    `pulumi:"protectionMode"`
	VmRecommendations []VmRecommendation `pulumi:"vmRecommendations"`
}

// The set of arguments for constructing a AdaptiveApplicationControl resource.
type AdaptiveApplicationControlArgs struct {
	// The location where ASC stores the data of the subscription. can be retrieved from Get locations
	AscLocation pulumi.StringInput
	// The application control policy enforcement/protection mode of the machine group
	EnforcementMode pulumi.StringPtrInput
	// Name of an application control machine group
	GroupName           pulumi.StringInput
	PathRecommendations PathRecommendationArrayInput
	// The protection mode of the collection/file types. Exe/Msi/Script are used for Windows, Executable is used for Linux.
	ProtectionMode    ProtectionModePtrInput
	VmRecommendations VmRecommendationArrayInput
}

func (AdaptiveApplicationControlArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*adaptiveApplicationControlArgs)(nil)).Elem()
}

type AdaptiveApplicationControlInput interface {
	pulumi.Input

	ToAdaptiveApplicationControlOutput() AdaptiveApplicationControlOutput
	ToAdaptiveApplicationControlOutputWithContext(ctx context.Context) AdaptiveApplicationControlOutput
}

func (AdaptiveApplicationControl) ElementType() reflect.Type {
	return reflect.TypeOf((*AdaptiveApplicationControl)(nil)).Elem()
}

func (i AdaptiveApplicationControl) ToAdaptiveApplicationControlOutput() AdaptiveApplicationControlOutput {
	return i.ToAdaptiveApplicationControlOutputWithContext(context.Background())
}

func (i AdaptiveApplicationControl) ToAdaptiveApplicationControlOutputWithContext(ctx context.Context) AdaptiveApplicationControlOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AdaptiveApplicationControlOutput)
}

type AdaptiveApplicationControlOutput struct {
	*pulumi.OutputState
}

func (AdaptiveApplicationControlOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*AdaptiveApplicationControlOutput)(nil)).Elem()
}

func (o AdaptiveApplicationControlOutput) ToAdaptiveApplicationControlOutput() AdaptiveApplicationControlOutput {
	return o
}

func (o AdaptiveApplicationControlOutput) ToAdaptiveApplicationControlOutputWithContext(ctx context.Context) AdaptiveApplicationControlOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(AdaptiveApplicationControlOutput{})
}
