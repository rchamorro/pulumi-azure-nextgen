// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20191201

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// User details.
type User struct {
	pulumi.CustomResourceState

	// Email address.
	Email pulumi.StringPtrOutput `pulumi:"email"`
	// First name.
	FirstName pulumi.StringPtrOutput `pulumi:"firstName"`
	// Collection of groups user is part of.
	Groups GroupContractPropertiesResponseArrayOutput `pulumi:"groups"`
	// Collection of user identities.
	Identities UserIdentityContractResponseArrayOutput `pulumi:"identities"`
	// Last name.
	LastName pulumi.StringPtrOutput `pulumi:"lastName"`
	// Resource name.
	Name pulumi.StringOutput `pulumi:"name"`
	// Optional note about a user set by the administrator.
	Note pulumi.StringPtrOutput `pulumi:"note"`
	// Date of user registration. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
	RegistrationDate pulumi.StringPtrOutput `pulumi:"registrationDate"`
	// Account state. Specifies whether the user is active or not. Blocked users are unable to sign into the developer portal or call any APIs of subscribed products. Default state is Active.
	State pulumi.StringPtrOutput `pulumi:"state"`
	// Resource type for API Management resource.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewUser registers a new resource with the given unique name, arguments, and options.
func NewUser(ctx *pulumi.Context,
	name string, args *UserArgs, opts ...pulumi.ResourceOption) (*User, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Email == nil {
		return nil, errors.New("invalid value for required argument 'Email'")
	}
	if args.FirstName == nil {
		return nil, errors.New("invalid value for required argument 'FirstName'")
	}
	if args.LastName == nil {
		return nil, errors.New("invalid value for required argument 'LastName'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	if args.ServiceName == nil {
		return nil, errors.New("invalid value for required argument 'ServiceName'")
	}
	if args.UserId == nil {
		return nil, errors.New("invalid value for required argument 'UserId'")
	}
	if args.State == nil {
		args.State = pulumi.StringPtr("active")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:apimanagement/latest:User"),
		},
		{
			Type: pulumi.String("azure-nextgen:apimanagement/v20160707:User"),
		},
		{
			Type: pulumi.String("azure-nextgen:apimanagement/v20161010:User"),
		},
		{
			Type: pulumi.String("azure-nextgen:apimanagement/v20170301:User"),
		},
		{
			Type: pulumi.String("azure-nextgen:apimanagement/v20180101:User"),
		},
		{
			Type: pulumi.String("azure-nextgen:apimanagement/v20180601preview:User"),
		},
		{
			Type: pulumi.String("azure-nextgen:apimanagement/v20190101:User"),
		},
		{
			Type: pulumi.String("azure-nextgen:apimanagement/v20191201preview:User"),
		},
		{
			Type: pulumi.String("azure-nextgen:apimanagement/v20200601preview:User"),
		},
	})
	opts = append(opts, aliases)
	var resource User
	err := ctx.RegisterResource("azure-nextgen:apimanagement/v20191201:User", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetUser gets an existing User resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetUser(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *UserState, opts ...pulumi.ResourceOption) (*User, error) {
	var resource User
	err := ctx.ReadResource("azure-nextgen:apimanagement/v20191201:User", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering User resources.
type userState struct {
	// Email address.
	Email *string `pulumi:"email"`
	// First name.
	FirstName *string `pulumi:"firstName"`
	// Collection of groups user is part of.
	Groups []GroupContractPropertiesResponse `pulumi:"groups"`
	// Collection of user identities.
	Identities []UserIdentityContractResponse `pulumi:"identities"`
	// Last name.
	LastName *string `pulumi:"lastName"`
	// Resource name.
	Name *string `pulumi:"name"`
	// Optional note about a user set by the administrator.
	Note *string `pulumi:"note"`
	// Date of user registration. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
	RegistrationDate *string `pulumi:"registrationDate"`
	// Account state. Specifies whether the user is active or not. Blocked users are unable to sign into the developer portal or call any APIs of subscribed products. Default state is Active.
	State *string `pulumi:"state"`
	// Resource type for API Management resource.
	Type *string `pulumi:"type"`
}

type UserState struct {
	// Email address.
	Email pulumi.StringPtrInput
	// First name.
	FirstName pulumi.StringPtrInput
	// Collection of groups user is part of.
	Groups GroupContractPropertiesResponseArrayInput
	// Collection of user identities.
	Identities UserIdentityContractResponseArrayInput
	// Last name.
	LastName pulumi.StringPtrInput
	// Resource name.
	Name pulumi.StringPtrInput
	// Optional note about a user set by the administrator.
	Note pulumi.StringPtrInput
	// Date of user registration. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
	RegistrationDate pulumi.StringPtrInput
	// Account state. Specifies whether the user is active or not. Blocked users are unable to sign into the developer portal or call any APIs of subscribed products. Default state is Active.
	State pulumi.StringPtrInput
	// Resource type for API Management resource.
	Type pulumi.StringPtrInput
}

func (UserState) ElementType() reflect.Type {
	return reflect.TypeOf((*userState)(nil)).Elem()
}

type userArgs struct {
	// Determines the type of application which send the create user request. Default is legacy portal.
	AppType *string `pulumi:"appType"`
	// Determines the type of confirmation e-mail that will be sent to the newly created user.
	Confirmation *string `pulumi:"confirmation"`
	// Email address. Must not be empty and must be unique within the service instance.
	Email string `pulumi:"email"`
	// First name.
	FirstName string `pulumi:"firstName"`
	// Collection of user identities.
	Identities []UserIdentityContract `pulumi:"identities"`
	// Last name.
	LastName string `pulumi:"lastName"`
	// Optional note about a user set by the administrator.
	Note *string `pulumi:"note"`
	// Send an Email notification to the User.
	Notify *bool `pulumi:"notify"`
	// User Password. If no value is provided, a default password is generated.
	Password *string `pulumi:"password"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the API Management service.
	ServiceName string `pulumi:"serviceName"`
	// Account state. Specifies whether the user is active or not. Blocked users are unable to sign into the developer portal or call any APIs of subscribed products. Default state is Active.
	State *string `pulumi:"state"`
	// User identifier. Must be unique in the current API Management service instance.
	UserId string `pulumi:"userId"`
}

// The set of arguments for constructing a User resource.
type UserArgs struct {
	// Determines the type of application which send the create user request. Default is legacy portal.
	AppType pulumi.StringPtrInput
	// Determines the type of confirmation e-mail that will be sent to the newly created user.
	Confirmation pulumi.StringPtrInput
	// Email address. Must not be empty and must be unique within the service instance.
	Email pulumi.StringInput
	// First name.
	FirstName pulumi.StringInput
	// Collection of user identities.
	Identities UserIdentityContractArrayInput
	// Last name.
	LastName pulumi.StringInput
	// Optional note about a user set by the administrator.
	Note pulumi.StringPtrInput
	// Send an Email notification to the User.
	Notify pulumi.BoolPtrInput
	// User Password. If no value is provided, a default password is generated.
	Password pulumi.StringPtrInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// The name of the API Management service.
	ServiceName pulumi.StringInput
	// Account state. Specifies whether the user is active or not. Blocked users are unable to sign into the developer portal or call any APIs of subscribed products. Default state is Active.
	State pulumi.StringPtrInput
	// User identifier. Must be unique in the current API Management service instance.
	UserId pulumi.StringInput
}

func (UserArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*userArgs)(nil)).Elem()
}

type UserInput interface {
	pulumi.Input

	ToUserOutput() UserOutput
	ToUserOutputWithContext(ctx context.Context) UserOutput
}

func (*User) ElementType() reflect.Type {
	return reflect.TypeOf((*User)(nil))
}

func (i *User) ToUserOutput() UserOutput {
	return i.ToUserOutputWithContext(context.Background())
}

func (i *User) ToUserOutputWithContext(ctx context.Context) UserOutput {
	return pulumi.ToOutputWithContext(ctx, i).(UserOutput)
}

type UserOutput struct {
	*pulumi.OutputState
}

func (UserOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*User)(nil))
}

func (o UserOutput) ToUserOutput() UserOutput {
	return o
}

func (o UserOutput) ToUserOutputWithContext(ctx context.Context) UserOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(UserOutput{})
}
