// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20191101preview

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Defines the PUT rollout request body.
type Rollout struct {
	pulumi.CustomResourceState

	// The reference to the artifact source resource Id where the payload is located.
	ArtifactSourceId pulumi.StringPtrOutput `pulumi:"artifactSourceId"`
	// The version of the build being deployed.
	BuildVersion pulumi.StringOutput `pulumi:"buildVersion"`
	// Identity for the resource.
	Identity IdentityResponseOutput `pulumi:"identity"`
	// The geo-location where the resource lives
	Location pulumi.StringOutput `pulumi:"location"`
	// The name of the resource
	Name pulumi.StringOutput `pulumi:"name"`
	// The list of step groups that define the orchestration.
	StepGroups StepGroupResponseArrayOutput `pulumi:"stepGroups"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// The resource Id of the service topology from which service units are being referenced in step groups to be deployed.
	TargetServiceTopologyId pulumi.StringOutput `pulumi:"targetServiceTopologyId"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewRollout registers a new resource with the given unique name, arguments, and options.
func NewRollout(ctx *pulumi.Context,
	name string, args *RolloutArgs, opts ...pulumi.ResourceOption) (*Rollout, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.BuildVersion == nil {
		return nil, errors.New("invalid value for required argument 'BuildVersion'")
	}
	if args.Identity == nil {
		return nil, errors.New("invalid value for required argument 'Identity'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	if args.RolloutName == nil {
		return nil, errors.New("invalid value for required argument 'RolloutName'")
	}
	if args.StepGroups == nil {
		return nil, errors.New("invalid value for required argument 'StepGroups'")
	}
	if args.TargetServiceTopologyId == nil {
		return nil, errors.New("invalid value for required argument 'TargetServiceTopologyId'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:deploymentmanager/v20180901preview:Rollout"),
		},
	})
	opts = append(opts, aliases)
	var resource Rollout
	err := ctx.RegisterResource("azure-nextgen:deploymentmanager/v20191101preview:Rollout", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetRollout gets an existing Rollout resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetRollout(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *RolloutState, opts ...pulumi.ResourceOption) (*Rollout, error) {
	var resource Rollout
	err := ctx.ReadResource("azure-nextgen:deploymentmanager/v20191101preview:Rollout", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Rollout resources.
type rolloutState struct {
	// The reference to the artifact source resource Id where the payload is located.
	ArtifactSourceId *string `pulumi:"artifactSourceId"`
	// The version of the build being deployed.
	BuildVersion *string `pulumi:"buildVersion"`
	// Identity for the resource.
	Identity *IdentityResponse `pulumi:"identity"`
	// The geo-location where the resource lives
	Location *string `pulumi:"location"`
	// The name of the resource
	Name *string `pulumi:"name"`
	// The list of step groups that define the orchestration.
	StepGroups []StepGroupResponse `pulumi:"stepGroups"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// The resource Id of the service topology from which service units are being referenced in step groups to be deployed.
	TargetServiceTopologyId *string `pulumi:"targetServiceTopologyId"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type *string `pulumi:"type"`
}

type RolloutState struct {
	// The reference to the artifact source resource Id where the payload is located.
	ArtifactSourceId pulumi.StringPtrInput
	// The version of the build being deployed.
	BuildVersion pulumi.StringPtrInput
	// Identity for the resource.
	Identity IdentityResponsePtrInput
	// The geo-location where the resource lives
	Location pulumi.StringPtrInput
	// The name of the resource
	Name pulumi.StringPtrInput
	// The list of step groups that define the orchestration.
	StepGroups StepGroupResponseArrayInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// The resource Id of the service topology from which service units are being referenced in step groups to be deployed.
	TargetServiceTopologyId pulumi.StringPtrInput
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringPtrInput
}

func (RolloutState) ElementType() reflect.Type {
	return reflect.TypeOf((*rolloutState)(nil)).Elem()
}

type rolloutArgs struct {
	// The reference to the artifact source resource Id where the payload is located.
	ArtifactSourceId *string `pulumi:"artifactSourceId"`
	// The version of the build being deployed.
	BuildVersion string `pulumi:"buildVersion"`
	// Identity for the resource.
	Identity Identity `pulumi:"identity"`
	// The geo-location where the resource lives
	Location *string `pulumi:"location"`
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The rollout name.
	RolloutName string `pulumi:"rolloutName"`
	// The list of step groups that define the orchestration.
	StepGroups []StepGroup `pulumi:"stepGroups"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// The resource Id of the service topology from which service units are being referenced in step groups to be deployed.
	TargetServiceTopologyId string `pulumi:"targetServiceTopologyId"`
}

// The set of arguments for constructing a Rollout resource.
type RolloutArgs struct {
	// The reference to the artifact source resource Id where the payload is located.
	ArtifactSourceId pulumi.StringPtrInput
	// The version of the build being deployed.
	BuildVersion pulumi.StringInput
	// Identity for the resource.
	Identity IdentityInput
	// The geo-location where the resource lives
	Location pulumi.StringPtrInput
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName pulumi.StringInput
	// The rollout name.
	RolloutName pulumi.StringInput
	// The list of step groups that define the orchestration.
	StepGroups StepGroupArrayInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// The resource Id of the service topology from which service units are being referenced in step groups to be deployed.
	TargetServiceTopologyId pulumi.StringInput
}

func (RolloutArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*rolloutArgs)(nil)).Elem()
}

type RolloutInput interface {
	pulumi.Input

	ToRolloutOutput() RolloutOutput
	ToRolloutOutputWithContext(ctx context.Context) RolloutOutput
}

func (*Rollout) ElementType() reflect.Type {
	return reflect.TypeOf((*Rollout)(nil))
}

func (i *Rollout) ToRolloutOutput() RolloutOutput {
	return i.ToRolloutOutputWithContext(context.Background())
}

func (i *Rollout) ToRolloutOutputWithContext(ctx context.Context) RolloutOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RolloutOutput)
}

type RolloutOutput struct {
	*pulumi.OutputState
}

func (RolloutOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Rollout)(nil))
}

func (o RolloutOutput) ToRolloutOutput() RolloutOutput {
	return o
}

func (o RolloutOutput) ToRolloutOutputWithContext(ctx context.Context) RolloutOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(RolloutOutput{})
}
