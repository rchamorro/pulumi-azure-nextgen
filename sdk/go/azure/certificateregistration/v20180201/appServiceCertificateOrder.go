// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20180201

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// SSL certificate purchase order.
type AppServiceCertificateOrder struct {
	pulumi.CustomResourceState

	// Reasons why App Service Certificate is not renewable at the current moment.
	AppServiceCertificateNotRenewableReasons pulumi.StringArrayOutput `pulumi:"appServiceCertificateNotRenewableReasons"`
	// <code>true</code> if the certificate should be automatically renewed when it expires; otherwise, <code>false</code>.
	AutoRenew pulumi.BoolPtrOutput `pulumi:"autoRenew"`
	// State of the Key Vault secret.
	Certificates AppServiceCertificateResponseMapOutput `pulumi:"certificates"`
	// Last CSR that was created for this order.
	Csr pulumi.StringPtrOutput `pulumi:"csr"`
	// Certificate distinguished name.
	DistinguishedName pulumi.StringPtrOutput `pulumi:"distinguishedName"`
	// Domain verification token.
	DomainVerificationToken pulumi.StringOutput `pulumi:"domainVerificationToken"`
	// Certificate expiration time.
	ExpirationTime pulumi.StringOutput `pulumi:"expirationTime"`
	// Intermediate certificate.
	Intermediate CertificateDetailsResponseOutput `pulumi:"intermediate"`
	// <code>true</code> if private key is external; otherwise, <code>false</code>.
	IsPrivateKeyExternal pulumi.BoolOutput `pulumi:"isPrivateKeyExternal"`
	// Certificate key size.
	KeySize pulumi.IntPtrOutput `pulumi:"keySize"`
	// Kind of resource.
	Kind pulumi.StringPtrOutput `pulumi:"kind"`
	// Certificate last issuance time.
	LastCertificateIssuanceTime pulumi.StringOutput `pulumi:"lastCertificateIssuanceTime"`
	// Resource Location.
	Location pulumi.StringOutput `pulumi:"location"`
	// Resource Name.
	Name pulumi.StringOutput `pulumi:"name"`
	// Time stamp when the certificate would be auto renewed next
	NextAutoRenewalTimeStamp pulumi.StringOutput `pulumi:"nextAutoRenewalTimeStamp"`
	// Certificate product type.
	ProductType pulumi.StringOutput `pulumi:"productType"`
	// Status of certificate order.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// Root certificate.
	Root CertificateDetailsResponseOutput `pulumi:"root"`
	// Current serial number of the certificate.
	SerialNumber pulumi.StringOutput `pulumi:"serialNumber"`
	// Signed certificate.
	SignedCertificate CertificateDetailsResponseOutput `pulumi:"signedCertificate"`
	// Current order status.
	Status pulumi.StringOutput `pulumi:"status"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
	// Duration in years (must be between 1 and 3).
	ValidityInYears pulumi.IntPtrOutput `pulumi:"validityInYears"`
}

// NewAppServiceCertificateOrder registers a new resource with the given unique name, arguments, and options.
func NewAppServiceCertificateOrder(ctx *pulumi.Context,
	name string, args *AppServiceCertificateOrderArgs, opts ...pulumi.ResourceOption) (*AppServiceCertificateOrder, error) {
	if args == nil || args.CertificateOrderName == nil {
		return nil, errors.New("missing required argument 'CertificateOrderName'")
	}
	if args == nil || args.Location == nil {
		return nil, errors.New("missing required argument 'Location'")
	}
	if args == nil || args.ProductType == nil {
		return nil, errors.New("missing required argument 'ProductType'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &AppServiceCertificateOrderArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:certificateregistration/latest:AppServiceCertificateOrder"),
		},
		{
			Type: pulumi.String("azure-nextgen:certificateregistration/v20150801:AppServiceCertificateOrder"),
		},
		{
			Type: pulumi.String("azure-nextgen:certificateregistration/v20190801:AppServiceCertificateOrder"),
		},
		{
			Type: pulumi.String("azure-nextgen:certificateregistration/v20200601:AppServiceCertificateOrder"),
		},
	})
	opts = append(opts, aliases)
	var resource AppServiceCertificateOrder
	err := ctx.RegisterResource("azure-nextgen:certificateregistration/v20180201:AppServiceCertificateOrder", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetAppServiceCertificateOrder gets an existing AppServiceCertificateOrder resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAppServiceCertificateOrder(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *AppServiceCertificateOrderState, opts ...pulumi.ResourceOption) (*AppServiceCertificateOrder, error) {
	var resource AppServiceCertificateOrder
	err := ctx.ReadResource("azure-nextgen:certificateregistration/v20180201:AppServiceCertificateOrder", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering AppServiceCertificateOrder resources.
type appServiceCertificateOrderState struct {
	// Reasons why App Service Certificate is not renewable at the current moment.
	AppServiceCertificateNotRenewableReasons []string `pulumi:"appServiceCertificateNotRenewableReasons"`
	// <code>true</code> if the certificate should be automatically renewed when it expires; otherwise, <code>false</code>.
	AutoRenew *bool `pulumi:"autoRenew"`
	// State of the Key Vault secret.
	Certificates map[string]AppServiceCertificateResponse `pulumi:"certificates"`
	// Last CSR that was created for this order.
	Csr *string `pulumi:"csr"`
	// Certificate distinguished name.
	DistinguishedName *string `pulumi:"distinguishedName"`
	// Domain verification token.
	DomainVerificationToken *string `pulumi:"domainVerificationToken"`
	// Certificate expiration time.
	ExpirationTime *string `pulumi:"expirationTime"`
	// Intermediate certificate.
	Intermediate *CertificateDetailsResponse `pulumi:"intermediate"`
	// <code>true</code> if private key is external; otherwise, <code>false</code>.
	IsPrivateKeyExternal *bool `pulumi:"isPrivateKeyExternal"`
	// Certificate key size.
	KeySize *int `pulumi:"keySize"`
	// Kind of resource.
	Kind *string `pulumi:"kind"`
	// Certificate last issuance time.
	LastCertificateIssuanceTime *string `pulumi:"lastCertificateIssuanceTime"`
	// Resource Location.
	Location *string `pulumi:"location"`
	// Resource Name.
	Name *string `pulumi:"name"`
	// Time stamp when the certificate would be auto renewed next
	NextAutoRenewalTimeStamp *string `pulumi:"nextAutoRenewalTimeStamp"`
	// Certificate product type.
	ProductType *string `pulumi:"productType"`
	// Status of certificate order.
	ProvisioningState *string `pulumi:"provisioningState"`
	// Root certificate.
	Root *CertificateDetailsResponse `pulumi:"root"`
	// Current serial number of the certificate.
	SerialNumber *string `pulumi:"serialNumber"`
	// Signed certificate.
	SignedCertificate *CertificateDetailsResponse `pulumi:"signedCertificate"`
	// Current order status.
	Status *string `pulumi:"status"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Resource type.
	Type *string `pulumi:"type"`
	// Duration in years (must be between 1 and 3).
	ValidityInYears *int `pulumi:"validityInYears"`
}

type AppServiceCertificateOrderState struct {
	// Reasons why App Service Certificate is not renewable at the current moment.
	AppServiceCertificateNotRenewableReasons pulumi.StringArrayInput
	// <code>true</code> if the certificate should be automatically renewed when it expires; otherwise, <code>false</code>.
	AutoRenew pulumi.BoolPtrInput
	// State of the Key Vault secret.
	Certificates AppServiceCertificateResponseMapInput
	// Last CSR that was created for this order.
	Csr pulumi.StringPtrInput
	// Certificate distinguished name.
	DistinguishedName pulumi.StringPtrInput
	// Domain verification token.
	DomainVerificationToken pulumi.StringPtrInput
	// Certificate expiration time.
	ExpirationTime pulumi.StringPtrInput
	// Intermediate certificate.
	Intermediate CertificateDetailsResponsePtrInput
	// <code>true</code> if private key is external; otherwise, <code>false</code>.
	IsPrivateKeyExternal pulumi.BoolPtrInput
	// Certificate key size.
	KeySize pulumi.IntPtrInput
	// Kind of resource.
	Kind pulumi.StringPtrInput
	// Certificate last issuance time.
	LastCertificateIssuanceTime pulumi.StringPtrInput
	// Resource Location.
	Location pulumi.StringPtrInput
	// Resource Name.
	Name pulumi.StringPtrInput
	// Time stamp when the certificate would be auto renewed next
	NextAutoRenewalTimeStamp pulumi.StringPtrInput
	// Certificate product type.
	ProductType pulumi.StringPtrInput
	// Status of certificate order.
	ProvisioningState pulumi.StringPtrInput
	// Root certificate.
	Root CertificateDetailsResponsePtrInput
	// Current serial number of the certificate.
	SerialNumber pulumi.StringPtrInput
	// Signed certificate.
	SignedCertificate CertificateDetailsResponsePtrInput
	// Current order status.
	Status pulumi.StringPtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// Resource type.
	Type pulumi.StringPtrInput
	// Duration in years (must be between 1 and 3).
	ValidityInYears pulumi.IntPtrInput
}

func (AppServiceCertificateOrderState) ElementType() reflect.Type {
	return reflect.TypeOf((*appServiceCertificateOrderState)(nil)).Elem()
}

type appServiceCertificateOrderArgs struct {
	// <code>true</code> if the certificate should be automatically renewed when it expires; otherwise, <code>false</code>.
	AutoRenew *bool `pulumi:"autoRenew"`
	// Name of the certificate order.
	CertificateOrderName string `pulumi:"certificateOrderName"`
	// State of the Key Vault secret.
	Certificates map[string]AppServiceCertificate `pulumi:"certificates"`
	// Last CSR that was created for this order.
	Csr *string `pulumi:"csr"`
	// Certificate distinguished name.
	DistinguishedName *string `pulumi:"distinguishedName"`
	// Certificate key size.
	KeySize *int `pulumi:"keySize"`
	// Kind of resource.
	Kind *string `pulumi:"kind"`
	// Resource Location.
	Location string `pulumi:"location"`
	// Certificate product type.
	ProductType string `pulumi:"productType"`
	// Name of the resource group to which the resource belongs.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Duration in years (must be between 1 and 3).
	ValidityInYears *int `pulumi:"validityInYears"`
}

// The set of arguments for constructing a AppServiceCertificateOrder resource.
type AppServiceCertificateOrderArgs struct {
	// <code>true</code> if the certificate should be automatically renewed when it expires; otherwise, <code>false</code>.
	AutoRenew pulumi.BoolPtrInput
	// Name of the certificate order.
	CertificateOrderName pulumi.StringInput
	// State of the Key Vault secret.
	Certificates AppServiceCertificateMapInput
	// Last CSR that was created for this order.
	Csr pulumi.StringPtrInput
	// Certificate distinguished name.
	DistinguishedName pulumi.StringPtrInput
	// Certificate key size.
	KeySize pulumi.IntPtrInput
	// Kind of resource.
	Kind pulumi.StringPtrInput
	// Resource Location.
	Location pulumi.StringInput
	// Certificate product type.
	ProductType pulumi.StringInput
	// Name of the resource group to which the resource belongs.
	ResourceGroupName pulumi.StringInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// Duration in years (must be between 1 and 3).
	ValidityInYears pulumi.IntPtrInput
}

func (AppServiceCertificateOrderArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*appServiceCertificateOrderArgs)(nil)).Elem()
}

type AppServiceCertificateOrderInput interface {
	pulumi.Input

	ToAppServiceCertificateOrderOutput() AppServiceCertificateOrderOutput
	ToAppServiceCertificateOrderOutputWithContext(ctx context.Context) AppServiceCertificateOrderOutput
}

func (AppServiceCertificateOrder) ElementType() reflect.Type {
	return reflect.TypeOf((*AppServiceCertificateOrder)(nil)).Elem()
}

func (i AppServiceCertificateOrder) ToAppServiceCertificateOrderOutput() AppServiceCertificateOrderOutput {
	return i.ToAppServiceCertificateOrderOutputWithContext(context.Background())
}

func (i AppServiceCertificateOrder) ToAppServiceCertificateOrderOutputWithContext(ctx context.Context) AppServiceCertificateOrderOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AppServiceCertificateOrderOutput)
}

type AppServiceCertificateOrderOutput struct {
	*pulumi.OutputState
}

func (AppServiceCertificateOrderOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*AppServiceCertificateOrderOutput)(nil)).Elem()
}

func (o AppServiceCertificateOrderOutput) ToAppServiceCertificateOrderOutput() AppServiceCertificateOrderOutput {
	return o
}

func (o AppServiceCertificateOrderOutput) ToAppServiceCertificateOrderOutputWithContext(ctx context.Context) AppServiceCertificateOrderOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(AppServiceCertificateOrderOutput{})
}
