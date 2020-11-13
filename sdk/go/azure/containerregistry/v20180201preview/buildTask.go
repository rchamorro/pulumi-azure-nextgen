// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20180201preview

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// The build task that has the resource properties and all build items. The build task will have all information to schedule a build against it.
type BuildTask struct {
	pulumi.CustomResourceState

	// The alternative updatable name for a build task.
	Alias pulumi.StringOutput `pulumi:"alias"`
	// The creation date of build task.
	CreationDate pulumi.StringOutput `pulumi:"creationDate"`
	// The location of the resource. This cannot be changed after the resource is created.
	Location pulumi.StringOutput `pulumi:"location"`
	// The name of the resource.
	Name pulumi.StringOutput `pulumi:"name"`
	// The platform properties against which the build has to happen.
	Platform PlatformPropertiesResponseOutput `pulumi:"platform"`
	// The provisioning state of the build task.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// The properties that describes the source(code) for the build task.
	SourceRepository SourceRepositoryPropertiesResponseOutput `pulumi:"sourceRepository"`
	// The current status of build task.
	Status pulumi.StringPtrOutput `pulumi:"status"`
	// The tags of the resource.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Build timeout in seconds.
	Timeout pulumi.IntPtrOutput `pulumi:"timeout"`
	// The type of the resource.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewBuildTask registers a new resource with the given unique name, arguments, and options.
func NewBuildTask(ctx *pulumi.Context,
	name string, args *BuildTaskArgs, opts ...pulumi.ResourceOption) (*BuildTask, error) {
	if args == nil || args.Alias == nil {
		return nil, errors.New("missing required argument 'Alias'")
	}
	if args == nil || args.BuildTaskName == nil {
		return nil, errors.New("missing required argument 'BuildTaskName'")
	}
	if args == nil || args.Location == nil {
		return nil, errors.New("missing required argument 'Location'")
	}
	if args == nil || args.Platform == nil {
		return nil, errors.New("missing required argument 'Platform'")
	}
	if args == nil || args.RegistryName == nil {
		return nil, errors.New("missing required argument 'RegistryName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.SourceRepository == nil {
		return nil, errors.New("missing required argument 'SourceRepository'")
	}
	if args == nil {
		args = &BuildTaskArgs{}
	}
	var resource BuildTask
	err := ctx.RegisterResource("azure-nextgen:containerregistry/v20180201preview:BuildTask", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetBuildTask gets an existing BuildTask resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetBuildTask(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *BuildTaskState, opts ...pulumi.ResourceOption) (*BuildTask, error) {
	var resource BuildTask
	err := ctx.ReadResource("azure-nextgen:containerregistry/v20180201preview:BuildTask", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering BuildTask resources.
type buildTaskState struct {
	// The alternative updatable name for a build task.
	Alias *string `pulumi:"alias"`
	// The creation date of build task.
	CreationDate *string `pulumi:"creationDate"`
	// The location of the resource. This cannot be changed after the resource is created.
	Location *string `pulumi:"location"`
	// The name of the resource.
	Name *string `pulumi:"name"`
	// The platform properties against which the build has to happen.
	Platform *PlatformPropertiesResponse `pulumi:"platform"`
	// The provisioning state of the build task.
	ProvisioningState *string `pulumi:"provisioningState"`
	// The properties that describes the source(code) for the build task.
	SourceRepository *SourceRepositoryPropertiesResponse `pulumi:"sourceRepository"`
	// The current status of build task.
	Status *string `pulumi:"status"`
	// The tags of the resource.
	Tags map[string]string `pulumi:"tags"`
	// Build timeout in seconds.
	Timeout *int `pulumi:"timeout"`
	// The type of the resource.
	Type *string `pulumi:"type"`
}

type BuildTaskState struct {
	// The alternative updatable name for a build task.
	Alias pulumi.StringPtrInput
	// The creation date of build task.
	CreationDate pulumi.StringPtrInput
	// The location of the resource. This cannot be changed after the resource is created.
	Location pulumi.StringPtrInput
	// The name of the resource.
	Name pulumi.StringPtrInput
	// The platform properties against which the build has to happen.
	Platform PlatformPropertiesResponsePtrInput
	// The provisioning state of the build task.
	ProvisioningState pulumi.StringPtrInput
	// The properties that describes the source(code) for the build task.
	SourceRepository SourceRepositoryPropertiesResponsePtrInput
	// The current status of build task.
	Status pulumi.StringPtrInput
	// The tags of the resource.
	Tags pulumi.StringMapInput
	// Build timeout in seconds.
	Timeout pulumi.IntPtrInput
	// The type of the resource.
	Type pulumi.StringPtrInput
}

func (BuildTaskState) ElementType() reflect.Type {
	return reflect.TypeOf((*buildTaskState)(nil)).Elem()
}

type buildTaskArgs struct {
	// The alternative updatable name for a build task.
	Alias string `pulumi:"alias"`
	// The name of the container registry build task.
	BuildTaskName string `pulumi:"buildTaskName"`
	// The location of the resource. This cannot be changed after the resource is created.
	Location string `pulumi:"location"`
	// The platform properties against which the build has to happen.
	Platform PlatformProperties `pulumi:"platform"`
	// The name of the container registry.
	RegistryName string `pulumi:"registryName"`
	// The name of the resource group to which the container registry belongs.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The properties that describes the source(code) for the build task.
	SourceRepository SourceRepositoryProperties `pulumi:"sourceRepository"`
	// The current status of build task.
	Status *string `pulumi:"status"`
	// The tags of the resource.
	Tags map[string]string `pulumi:"tags"`
	// Build timeout in seconds.
	Timeout *int `pulumi:"timeout"`
}

// The set of arguments for constructing a BuildTask resource.
type BuildTaskArgs struct {
	// The alternative updatable name for a build task.
	Alias pulumi.StringInput
	// The name of the container registry build task.
	BuildTaskName pulumi.StringInput
	// The location of the resource. This cannot be changed after the resource is created.
	Location pulumi.StringInput
	// The platform properties against which the build has to happen.
	Platform PlatformPropertiesInput
	// The name of the container registry.
	RegistryName pulumi.StringInput
	// The name of the resource group to which the container registry belongs.
	ResourceGroupName pulumi.StringInput
	// The properties that describes the source(code) for the build task.
	SourceRepository SourceRepositoryPropertiesInput
	// The current status of build task.
	Status pulumi.StringPtrInput
	// The tags of the resource.
	Tags pulumi.StringMapInput
	// Build timeout in seconds.
	Timeout pulumi.IntPtrInput
}

func (BuildTaskArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*buildTaskArgs)(nil)).Elem()
}

type BuildTaskInput interface {
	pulumi.Input

	ToBuildTaskOutput() BuildTaskOutput
	ToBuildTaskOutputWithContext(ctx context.Context) BuildTaskOutput
}

func (BuildTask) ElementType() reflect.Type {
	return reflect.TypeOf((*BuildTask)(nil)).Elem()
}

func (i BuildTask) ToBuildTaskOutput() BuildTaskOutput {
	return i.ToBuildTaskOutputWithContext(context.Background())
}

func (i BuildTask) ToBuildTaskOutputWithContext(ctx context.Context) BuildTaskOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BuildTaskOutput)
}

type BuildTaskOutput struct {
	*pulumi.OutputState
}

func (BuildTaskOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*BuildTaskOutput)(nil)).Elem()
}

func (o BuildTaskOutput) ToBuildTaskOutput() BuildTaskOutput {
	return o
}

func (o BuildTaskOutput) ToBuildTaskOutputWithContext(ctx context.Context) BuildTaskOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(BuildTaskOutput{})
}
