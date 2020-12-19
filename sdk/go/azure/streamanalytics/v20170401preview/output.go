// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20170401preview

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// An output object, containing all information associated with the named output. All outputs are contained under a streaming job.
type Output struct {
	pulumi.CustomResourceState

	// Describes the data source that output will be written to. Required on PUT (CreateOrReplace) requests.
	Datasource pulumi.AnyOutput `pulumi:"datasource"`
	// Describes conditions applicable to the Input, Output, or the job overall, that warrant customer attention.
	Diagnostics DiagnosticsResponseOutput `pulumi:"diagnostics"`
	// The current entity tag for the output. This is an opaque string. You can use it to detect whether the resource has changed between requests. You can also use it in the If-Match or If-None-Match headers for write operations for optimistic concurrency.
	Etag pulumi.StringOutput `pulumi:"etag"`
	// Resource name
	Name pulumi.StringPtrOutput `pulumi:"name"`
	// Describes how data from an input is serialized or how data is serialized when written to an output. Required on PUT (CreateOrReplace) requests.
	Serialization pulumi.AnyOutput        `pulumi:"serialization"`
	SizeWindow    pulumi.Float64PtrOutput `pulumi:"sizeWindow"`
	TimeWindow    pulumi.StringPtrOutput  `pulumi:"timeWindow"`
	// Resource type
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewOutput registers a new resource with the given unique name, arguments, and options.
func NewOutput(ctx *pulumi.Context,
	name string, args *OutputArgs, opts ...pulumi.ResourceOption) (*Output, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.JobName == nil {
		return nil, errors.New("invalid value for required argument 'JobName'")
	}
	if args.OutputName == nil {
		return nil, errors.New("invalid value for required argument 'OutputName'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:streamanalytics/latest:Output"),
		},
		{
			Type: pulumi.String("azure-nextgen:streamanalytics/v20160301:Output"),
		},
	})
	opts = append(opts, aliases)
	var resource Output
	err := ctx.RegisterResource("azure-nextgen:streamanalytics/v20170401preview:Output", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetOutput gets an existing Output resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetOutput(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *OutputState, opts ...pulumi.ResourceOption) (*Output, error) {
	var resource Output
	err := ctx.ReadResource("azure-nextgen:streamanalytics/v20170401preview:Output", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Output resources.
type outputState struct {
	// Describes the data source that output will be written to. Required on PUT (CreateOrReplace) requests.
	Datasource interface{} `pulumi:"datasource"`
	// Describes conditions applicable to the Input, Output, or the job overall, that warrant customer attention.
	Diagnostics *DiagnosticsResponse `pulumi:"diagnostics"`
	// The current entity tag for the output. This is an opaque string. You can use it to detect whether the resource has changed between requests. You can also use it in the If-Match or If-None-Match headers for write operations for optimistic concurrency.
	Etag *string `pulumi:"etag"`
	// Resource name
	Name *string `pulumi:"name"`
	// Describes how data from an input is serialized or how data is serialized when written to an output. Required on PUT (CreateOrReplace) requests.
	Serialization interface{} `pulumi:"serialization"`
	SizeWindow    *float64    `pulumi:"sizeWindow"`
	TimeWindow    *string     `pulumi:"timeWindow"`
	// Resource type
	Type *string `pulumi:"type"`
}

type OutputState struct {
	// Describes the data source that output will be written to. Required on PUT (CreateOrReplace) requests.
	Datasource pulumi.Input
	// Describes conditions applicable to the Input, Output, or the job overall, that warrant customer attention.
	Diagnostics DiagnosticsResponsePtrInput
	// The current entity tag for the output. This is an opaque string. You can use it to detect whether the resource has changed between requests. You can also use it in the If-Match or If-None-Match headers for write operations for optimistic concurrency.
	Etag pulumi.StringPtrInput
	// Resource name
	Name pulumi.StringPtrInput
	// Describes how data from an input is serialized or how data is serialized when written to an output. Required on PUT (CreateOrReplace) requests.
	Serialization pulumi.Input
	SizeWindow    pulumi.Float64PtrInput
	TimeWindow    pulumi.StringPtrInput
	// Resource type
	Type pulumi.StringPtrInput
}

func (OutputState) ElementType() reflect.Type {
	return reflect.TypeOf((*outputState)(nil)).Elem()
}

type outputArgs struct {
	// Describes the data source that output will be written to. Required on PUT (CreateOrReplace) requests.
	Datasource interface{} `pulumi:"datasource"`
	// The name of the streaming job.
	JobName string `pulumi:"jobName"`
	// Resource name
	Name *string `pulumi:"name"`
	// The name of the output.
	OutputName string `pulumi:"outputName"`
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Describes how data from an input is serialized or how data is serialized when written to an output. Required on PUT (CreateOrReplace) requests.
	Serialization interface{} `pulumi:"serialization"`
	SizeWindow    *float64    `pulumi:"sizeWindow"`
	TimeWindow    *string     `pulumi:"timeWindow"`
}

// The set of arguments for constructing a Output resource.
type OutputArgs struct {
	// Describes the data source that output will be written to. Required on PUT (CreateOrReplace) requests.
	Datasource pulumi.Input
	// The name of the streaming job.
	JobName pulumi.StringInput
	// Resource name
	Name pulumi.StringPtrInput
	// The name of the output.
	OutputName pulumi.StringInput
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName pulumi.StringInput
	// Describes how data from an input is serialized or how data is serialized when written to an output. Required on PUT (CreateOrReplace) requests.
	Serialization pulumi.Input
	SizeWindow    pulumi.Float64PtrInput
	TimeWindow    pulumi.StringPtrInput
}

func (OutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*outputArgs)(nil)).Elem()
}

type OutputInput interface {
	pulumi.Input

	ToOutputOutput() OutputOutput
	ToOutputOutputWithContext(ctx context.Context) OutputOutput
}

func (*Output) ElementType() reflect.Type {
	return reflect.TypeOf((*Output)(nil))
}

func (i *Output) ToOutputOutput() OutputOutput {
	return i.ToOutputOutputWithContext(context.Background())
}

func (i *Output) ToOutputOutputWithContext(ctx context.Context) OutputOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OutputOutput)
}

type OutputOutput struct {
	*pulumi.OutputState
}

func (OutputOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Output)(nil))
}

func (o OutputOutput) ToOutputOutput() OutputOutput {
	return o
}

func (o OutputOutput) ToOutputOutputWithContext(ctx context.Context) OutputOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(OutputOutput{})
}
