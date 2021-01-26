// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20180901preview

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Graph Query entity definition.
type GraphQuery struct {
	pulumi.CustomResourceState

	// The description of a graph query.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// This will be used to handle Optimistic Concurrency. If not present, it will always overwrite the existing resource without checking conflict.
	Etag pulumi.StringPtrOutput `pulumi:"etag"`
	// The location of the resource
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// Azure resource name. This is GUID value. The display name should be assigned within properties field.
	Name pulumi.StringOutput `pulumi:"name"`
	// KQL query that will be graph.
	Query pulumi.StringOutput `pulumi:"query"`
	// Enum indicating a type of graph query.
	ResultKind pulumi.StringOutput `pulumi:"resultKind"`
	// Resource tags
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Date and time in UTC of the last modification that was made to this graph query definition.
	TimeModified pulumi.StringOutput `pulumi:"timeModified"`
	// Azure resource type
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewGraphQuery registers a new resource with the given unique name, arguments, and options.
func NewGraphQuery(ctx *pulumi.Context,
	name string, args *GraphQueryArgs, opts ...pulumi.ResourceOption) (*GraphQuery, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Query == nil {
		return nil, errors.New("invalid value for required argument 'Query'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	if args.ResourceName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:resourcegraph/v20200401preview:GraphQuery"),
		},
	})
	opts = append(opts, aliases)
	var resource GraphQuery
	err := ctx.RegisterResource("azure-nextgen:resourcegraph/v20180901preview:GraphQuery", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetGraphQuery gets an existing GraphQuery resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetGraphQuery(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *GraphQueryState, opts ...pulumi.ResourceOption) (*GraphQuery, error) {
	var resource GraphQuery
	err := ctx.ReadResource("azure-nextgen:resourcegraph/v20180901preview:GraphQuery", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering GraphQuery resources.
type graphQueryState struct {
	// The description of a graph query.
	Description *string `pulumi:"description"`
	// This will be used to handle Optimistic Concurrency. If not present, it will always overwrite the existing resource without checking conflict.
	Etag *string `pulumi:"etag"`
	// The location of the resource
	Location *string `pulumi:"location"`
	// Azure resource name. This is GUID value. The display name should be assigned within properties field.
	Name *string `pulumi:"name"`
	// KQL query that will be graph.
	Query *string `pulumi:"query"`
	// Enum indicating a type of graph query.
	ResultKind *string `pulumi:"resultKind"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// Date and time in UTC of the last modification that was made to this graph query definition.
	TimeModified *string `pulumi:"timeModified"`
	// Azure resource type
	Type *string `pulumi:"type"`
}

type GraphQueryState struct {
	// The description of a graph query.
	Description pulumi.StringPtrInput
	// This will be used to handle Optimistic Concurrency. If not present, it will always overwrite the existing resource without checking conflict.
	Etag pulumi.StringPtrInput
	// The location of the resource
	Location pulumi.StringPtrInput
	// Azure resource name. This is GUID value. The display name should be assigned within properties field.
	Name pulumi.StringPtrInput
	// KQL query that will be graph.
	Query pulumi.StringPtrInput
	// Enum indicating a type of graph query.
	ResultKind pulumi.StringPtrInput
	// Resource tags
	Tags pulumi.StringMapInput
	// Date and time in UTC of the last modification that was made to this graph query definition.
	TimeModified pulumi.StringPtrInput
	// Azure resource type
	Type pulumi.StringPtrInput
}

func (GraphQueryState) ElementType() reflect.Type {
	return reflect.TypeOf((*graphQueryState)(nil)).Elem()
}

type graphQueryArgs struct {
	// The description of a graph query.
	Description *string `pulumi:"description"`
	// This will be used to handle Optimistic Concurrency. If not present, it will always overwrite the existing resource without checking conflict.
	Etag *string `pulumi:"etag"`
	// The location of the resource
	Location *string `pulumi:"location"`
	// KQL query that will be graph.
	Query string `pulumi:"query"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the Graph Query resource.
	ResourceName string `pulumi:"resourceName"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a GraphQuery resource.
type GraphQueryArgs struct {
	// The description of a graph query.
	Description pulumi.StringPtrInput
	// This will be used to handle Optimistic Concurrency. If not present, it will always overwrite the existing resource without checking conflict.
	Etag pulumi.StringPtrInput
	// The location of the resource
	Location pulumi.StringPtrInput
	// KQL query that will be graph.
	Query pulumi.StringInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// The name of the Graph Query resource.
	ResourceName pulumi.StringInput
	// Resource tags
	Tags pulumi.StringMapInput
}

func (GraphQueryArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*graphQueryArgs)(nil)).Elem()
}

type GraphQueryInput interface {
	pulumi.Input

	ToGraphQueryOutput() GraphQueryOutput
	ToGraphQueryOutputWithContext(ctx context.Context) GraphQueryOutput
}

func (*GraphQuery) ElementType() reflect.Type {
	return reflect.TypeOf((*GraphQuery)(nil))
}

func (i *GraphQuery) ToGraphQueryOutput() GraphQueryOutput {
	return i.ToGraphQueryOutputWithContext(context.Background())
}

func (i *GraphQuery) ToGraphQueryOutputWithContext(ctx context.Context) GraphQueryOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GraphQueryOutput)
}

type GraphQueryOutput struct {
	*pulumi.OutputState
}

func (GraphQueryOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GraphQuery)(nil))
}

func (o GraphQueryOutput) ToGraphQueryOutput() GraphQueryOutput {
	return o
}

func (o GraphQueryOutput) ToGraphQueryOutputWithContext(ctx context.Context) GraphQueryOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(GraphQueryOutput{})
}
