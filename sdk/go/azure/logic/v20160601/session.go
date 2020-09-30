// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20160601

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// The integration account session.
type Session struct {
	pulumi.CustomResourceState

	// The changed time.
	ChangedTime pulumi.StringOutput `pulumi:"changedTime"`
	// The session content.
	Content pulumi.AnyOutput `pulumi:"content"`
	// The created time.
	CreatedTime pulumi.StringOutput `pulumi:"createdTime"`
	// The resource location.
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// Gets the resource name.
	Name pulumi.StringOutput `pulumi:"name"`
	// The resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Gets the resource type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewSession registers a new resource with the given unique name, arguments, and options.
func NewSession(ctx *pulumi.Context,
	name string, args *SessionArgs, opts ...pulumi.ResourceOption) (*Session, error) {
	if args == nil || args.IntegrationAccountName == nil {
		return nil, errors.New("missing required argument 'IntegrationAccountName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.SessionName == nil {
		return nil, errors.New("missing required argument 'SessionName'")
	}
	if args == nil {
		args = &SessionArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:logic/latest:Session"),
		},
		{
			Type: pulumi.String("azure-nextgen:logic/v20180701preview:Session"),
		},
		{
			Type: pulumi.String("azure-nextgen:logic/v20190501:Session"),
		},
	})
	opts = append(opts, aliases)
	var resource Session
	err := ctx.RegisterResource("azure-nextgen:logic/v20160601:Session", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSession gets an existing Session resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSession(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SessionState, opts ...pulumi.ResourceOption) (*Session, error) {
	var resource Session
	err := ctx.ReadResource("azure-nextgen:logic/v20160601:Session", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Session resources.
type sessionState struct {
	// The changed time.
	ChangedTime *string `pulumi:"changedTime"`
	// The session content.
	Content interface{} `pulumi:"content"`
	// The created time.
	CreatedTime *string `pulumi:"createdTime"`
	// The resource location.
	Location *string `pulumi:"location"`
	// Gets the resource name.
	Name *string `pulumi:"name"`
	// The resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Gets the resource type.
	Type *string `pulumi:"type"`
}

type SessionState struct {
	// The changed time.
	ChangedTime pulumi.StringPtrInput
	// The session content.
	Content pulumi.Input
	// The created time.
	CreatedTime pulumi.StringPtrInput
	// The resource location.
	Location pulumi.StringPtrInput
	// Gets the resource name.
	Name pulumi.StringPtrInput
	// The resource tags.
	Tags pulumi.StringMapInput
	// Gets the resource type.
	Type pulumi.StringPtrInput
}

func (SessionState) ElementType() reflect.Type {
	return reflect.TypeOf((*sessionState)(nil)).Elem()
}

type sessionArgs struct {
	// The session content.
	Content interface{} `pulumi:"content"`
	// The integration account name.
	IntegrationAccountName string `pulumi:"integrationAccountName"`
	// The resource location.
	Location *string `pulumi:"location"`
	// The resource group name.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The integration account session name.
	SessionName string `pulumi:"sessionName"`
	// The resource tags.
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a Session resource.
type SessionArgs struct {
	// The session content.
	Content pulumi.Input
	// The integration account name.
	IntegrationAccountName pulumi.StringInput
	// The resource location.
	Location pulumi.StringPtrInput
	// The resource group name.
	ResourceGroupName pulumi.StringInput
	// The integration account session name.
	SessionName pulumi.StringInput
	// The resource tags.
	Tags pulumi.StringMapInput
}

func (SessionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*sessionArgs)(nil)).Elem()
}
