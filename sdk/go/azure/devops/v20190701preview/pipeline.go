// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20190701preview

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Azure DevOps Pipeline used to configure Continuous Integration (CI) & Continuous Delivery (CD) for Azure resources.
type Pipeline struct {
	pulumi.CustomResourceState

	// Configuration used to bootstrap the Pipeline.
	BootstrapConfiguration BootstrapConfigurationResponseOutput `pulumi:"bootstrapConfiguration"`
	// Resource Location
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// Resource Name
	Name pulumi.StringOutput `pulumi:"name"`
	// Reference to the Azure DevOps Organization containing the Pipeline.
	Organization OrganizationReferenceResponseOutput `pulumi:"organization"`
	// Unique identifier of the Azure Pipeline within the Azure DevOps Project.
	PipelineId pulumi.IntOutput `pulumi:"pipelineId"`
	// Reference to the Azure DevOps Project containing the Pipeline.
	Project ProjectReferenceResponseOutput `pulumi:"project"`
	// Resource Tags
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Resource Type
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewPipeline registers a new resource with the given unique name, arguments, and options.
func NewPipeline(ctx *pulumi.Context,
	name string, args *PipelineArgs, opts ...pulumi.ResourceOption) (*Pipeline, error) {
	if args == nil || args.BootstrapConfiguration == nil {
		return nil, errors.New("missing required argument 'BootstrapConfiguration'")
	}
	if args == nil || args.Organization == nil {
		return nil, errors.New("missing required argument 'Organization'")
	}
	if args == nil || args.PipelineName == nil {
		return nil, errors.New("missing required argument 'PipelineName'")
	}
	if args == nil || args.Project == nil {
		return nil, errors.New("missing required argument 'Project'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &PipelineArgs{}
	}
	var resource Pipeline
	err := ctx.RegisterResource("azure-nextgen:devops/v20190701preview:Pipeline", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetPipeline gets an existing Pipeline resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetPipeline(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *PipelineState, opts ...pulumi.ResourceOption) (*Pipeline, error) {
	var resource Pipeline
	err := ctx.ReadResource("azure-nextgen:devops/v20190701preview:Pipeline", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Pipeline resources.
type pipelineState struct {
	// Configuration used to bootstrap the Pipeline.
	BootstrapConfiguration *BootstrapConfigurationResponse `pulumi:"bootstrapConfiguration"`
	// Resource Location
	Location *string `pulumi:"location"`
	// Resource Name
	Name *string `pulumi:"name"`
	// Reference to the Azure DevOps Organization containing the Pipeline.
	Organization *OrganizationReferenceResponse `pulumi:"organization"`
	// Unique identifier of the Azure Pipeline within the Azure DevOps Project.
	PipelineId *int `pulumi:"pipelineId"`
	// Reference to the Azure DevOps Project containing the Pipeline.
	Project *ProjectReferenceResponse `pulumi:"project"`
	// Resource Tags
	Tags map[string]string `pulumi:"tags"`
	// Resource Type
	Type *string `pulumi:"type"`
}

type PipelineState struct {
	// Configuration used to bootstrap the Pipeline.
	BootstrapConfiguration BootstrapConfigurationResponsePtrInput
	// Resource Location
	Location pulumi.StringPtrInput
	// Resource Name
	Name pulumi.StringPtrInput
	// Reference to the Azure DevOps Organization containing the Pipeline.
	Organization OrganizationReferenceResponsePtrInput
	// Unique identifier of the Azure Pipeline within the Azure DevOps Project.
	PipelineId pulumi.IntPtrInput
	// Reference to the Azure DevOps Project containing the Pipeline.
	Project ProjectReferenceResponsePtrInput
	// Resource Tags
	Tags pulumi.StringMapInput
	// Resource Type
	Type pulumi.StringPtrInput
}

func (PipelineState) ElementType() reflect.Type {
	return reflect.TypeOf((*pipelineState)(nil)).Elem()
}

type pipelineArgs struct {
	// Configuration used to bootstrap the Pipeline.
	BootstrapConfiguration BootstrapConfiguration `pulumi:"bootstrapConfiguration"`
	// Resource Location
	Location *string `pulumi:"location"`
	// Reference to the Azure DevOps Organization containing the Pipeline.
	Organization OrganizationReference `pulumi:"organization"`
	// The name of the Azure Pipeline resource in ARM.
	PipelineName string `pulumi:"pipelineName"`
	// Reference to the Azure DevOps Project containing the Pipeline.
	Project ProjectReference `pulumi:"project"`
	// Name of the resource group within the Azure subscription.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Resource Tags
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a Pipeline resource.
type PipelineArgs struct {
	// Configuration used to bootstrap the Pipeline.
	BootstrapConfiguration BootstrapConfigurationInput
	// Resource Location
	Location pulumi.StringPtrInput
	// Reference to the Azure DevOps Organization containing the Pipeline.
	Organization OrganizationReferenceInput
	// The name of the Azure Pipeline resource in ARM.
	PipelineName pulumi.StringInput
	// Reference to the Azure DevOps Project containing the Pipeline.
	Project ProjectReferenceInput
	// Name of the resource group within the Azure subscription.
	ResourceGroupName pulumi.StringInput
	// Resource Tags
	Tags pulumi.StringMapInput
}

func (PipelineArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*pipelineArgs)(nil)).Elem()
}

type PipelineInput interface {
	pulumi.Input

	ToPipelineOutput() PipelineOutput
	ToPipelineOutputWithContext(ctx context.Context) PipelineOutput
}

func (Pipeline) ElementType() reflect.Type {
	return reflect.TypeOf((*Pipeline)(nil)).Elem()
}

func (i Pipeline) ToPipelineOutput() PipelineOutput {
	return i.ToPipelineOutputWithContext(context.Background())
}

func (i Pipeline) ToPipelineOutputWithContext(ctx context.Context) PipelineOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PipelineOutput)
}

type PipelineOutput struct {
	*pulumi.OutputState
}

func (PipelineOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*PipelineOutput)(nil)).Elem()
}

func (o PipelineOutput) ToPipelineOutput() PipelineOutput {
	return o
}

func (o PipelineOutput) ToPipelineOutputWithContext(ctx context.Context) PipelineOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(PipelineOutput{})
}
