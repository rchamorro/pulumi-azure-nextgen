// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Cloud shell console
type ConsoleWithLocation struct {
	pulumi.CustomResourceState

	// Cloud shell console properties.
	Properties ConsolePropertiesResponseOutput `pulumi:"properties"`
}

// NewConsoleWithLocation registers a new resource with the given unique name, arguments, and options.
func NewConsoleWithLocation(ctx *pulumi.Context,
	name string, args *ConsoleWithLocationArgs, opts ...pulumi.ResourceOption) (*ConsoleWithLocation, error) {
	if args == nil || args.ConsoleName == nil {
		return nil, errors.New("missing required argument 'ConsoleName'")
	}
	if args == nil || args.Location == nil {
		return nil, errors.New("missing required argument 'Location'")
	}
	if args == nil {
		args = &ConsoleWithLocationArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:portal/v20181001:ConsoleWithLocation"),
		},
	})
	opts = append(opts, aliases)
	var resource ConsoleWithLocation
	err := ctx.RegisterResource("azure-nextgen:portal/latest:ConsoleWithLocation", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetConsoleWithLocation gets an existing ConsoleWithLocation resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetConsoleWithLocation(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ConsoleWithLocationState, opts ...pulumi.ResourceOption) (*ConsoleWithLocation, error) {
	var resource ConsoleWithLocation
	err := ctx.ReadResource("azure-nextgen:portal/latest:ConsoleWithLocation", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ConsoleWithLocation resources.
type consoleWithLocationState struct {
	// Cloud shell console properties.
	Properties *ConsolePropertiesResponse `pulumi:"properties"`
}

type ConsoleWithLocationState struct {
	// Cloud shell console properties.
	Properties ConsolePropertiesResponsePtrInput
}

func (ConsoleWithLocationState) ElementType() reflect.Type {
	return reflect.TypeOf((*consoleWithLocationState)(nil)).Elem()
}

type consoleWithLocationArgs struct {
	// The name of the console
	ConsoleName string `pulumi:"consoleName"`
	// The provider location
	Location string `pulumi:"location"`
}

// The set of arguments for constructing a ConsoleWithLocation resource.
type ConsoleWithLocationArgs struct {
	// The name of the console
	ConsoleName pulumi.StringInput
	// The provider location
	Location pulumi.StringInput
}

func (ConsoleWithLocationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*consoleWithLocationArgs)(nil)).Elem()
}

type ConsoleWithLocationInput interface {
	pulumi.Input

	ToConsoleWithLocationOutput() ConsoleWithLocationOutput
	ToConsoleWithLocationOutputWithContext(ctx context.Context) ConsoleWithLocationOutput
}

func (ConsoleWithLocation) ElementType() reflect.Type {
	return reflect.TypeOf((*ConsoleWithLocation)(nil)).Elem()
}

func (i ConsoleWithLocation) ToConsoleWithLocationOutput() ConsoleWithLocationOutput {
	return i.ToConsoleWithLocationOutputWithContext(context.Background())
}

func (i ConsoleWithLocation) ToConsoleWithLocationOutputWithContext(ctx context.Context) ConsoleWithLocationOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ConsoleWithLocationOutput)
}

type ConsoleWithLocationOutput struct {
	*pulumi.OutputState
}

func (ConsoleWithLocationOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ConsoleWithLocationOutput)(nil)).Elem()
}

func (o ConsoleWithLocationOutput) ToConsoleWithLocationOutput() ConsoleWithLocationOutput {
	return o
}

func (o ConsoleWithLocationOutput) ToConsoleWithLocationOutputWithContext(ctx context.Context) ConsoleWithLocationOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ConsoleWithLocationOutput{})
}
