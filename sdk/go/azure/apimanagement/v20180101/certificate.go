// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20180101

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Certificate details.
type Certificate struct {
	pulumi.CustomResourceState

	// Expiration date of the certificate. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
	ExpirationDate pulumi.StringOutput `pulumi:"expirationDate"`
	// Resource name.
	Name pulumi.StringOutput `pulumi:"name"`
	// Subject attribute of the certificate.
	Subject pulumi.StringOutput `pulumi:"subject"`
	// Thumbprint of the certificate.
	Thumbprint pulumi.StringOutput `pulumi:"thumbprint"`
	// Resource type for API Management resource.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewCertificate registers a new resource with the given unique name, arguments, and options.
func NewCertificate(ctx *pulumi.Context,
	name string, args *CertificateArgs, opts ...pulumi.ResourceOption) (*Certificate, error) {
	if args == nil || args.CertificateId == nil {
		return nil, errors.New("missing required argument 'CertificateId'")
	}
	if args == nil || args.Data == nil {
		return nil, errors.New("missing required argument 'Data'")
	}
	if args == nil || args.Password == nil {
		return nil, errors.New("missing required argument 'Password'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.ServiceName == nil {
		return nil, errors.New("missing required argument 'ServiceName'")
	}
	if args == nil {
		args = &CertificateArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:apimanagement/latest:Certificate"),
		},
		{
			Type: pulumi.String("azure-nextgen:apimanagement/v20160707:Certificate"),
		},
		{
			Type: pulumi.String("azure-nextgen:apimanagement/v20161010:Certificate"),
		},
		{
			Type: pulumi.String("azure-nextgen:apimanagement/v20170301:Certificate"),
		},
		{
			Type: pulumi.String("azure-nextgen:apimanagement/v20180601preview:Certificate"),
		},
		{
			Type: pulumi.String("azure-nextgen:apimanagement/v20190101:Certificate"),
		},
		{
			Type: pulumi.String("azure-nextgen:apimanagement/v20191201:Certificate"),
		},
		{
			Type: pulumi.String("azure-nextgen:apimanagement/v20191201preview:Certificate"),
		},
		{
			Type: pulumi.String("azure-nextgen:apimanagement/v20200601preview:Certificate"),
		},
	})
	opts = append(opts, aliases)
	var resource Certificate
	err := ctx.RegisterResource("azure-nextgen:apimanagement/v20180101:Certificate", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetCertificate gets an existing Certificate resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetCertificate(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *CertificateState, opts ...pulumi.ResourceOption) (*Certificate, error) {
	var resource Certificate
	err := ctx.ReadResource("azure-nextgen:apimanagement/v20180101:Certificate", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Certificate resources.
type certificateState struct {
	// Expiration date of the certificate. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
	ExpirationDate *string `pulumi:"expirationDate"`
	// Resource name.
	Name *string `pulumi:"name"`
	// Subject attribute of the certificate.
	Subject *string `pulumi:"subject"`
	// Thumbprint of the certificate.
	Thumbprint *string `pulumi:"thumbprint"`
	// Resource type for API Management resource.
	Type *string `pulumi:"type"`
}

type CertificateState struct {
	// Expiration date of the certificate. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
	ExpirationDate pulumi.StringPtrInput
	// Resource name.
	Name pulumi.StringPtrInput
	// Subject attribute of the certificate.
	Subject pulumi.StringPtrInput
	// Thumbprint of the certificate.
	Thumbprint pulumi.StringPtrInput
	// Resource type for API Management resource.
	Type pulumi.StringPtrInput
}

func (CertificateState) ElementType() reflect.Type {
	return reflect.TypeOf((*certificateState)(nil)).Elem()
}

type certificateArgs struct {
	// Identifier of the certificate entity. Must be unique in the current API Management service instance.
	CertificateId string `pulumi:"certificateId"`
	// Base 64 encoded certificate using the application/x-pkcs12 representation.
	Data string `pulumi:"data"`
	// Password for the Certificate
	Password string `pulumi:"password"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the API Management service.
	ServiceName string `pulumi:"serviceName"`
}

// The set of arguments for constructing a Certificate resource.
type CertificateArgs struct {
	// Identifier of the certificate entity. Must be unique in the current API Management service instance.
	CertificateId pulumi.StringInput
	// Base 64 encoded certificate using the application/x-pkcs12 representation.
	Data pulumi.StringInput
	// Password for the Certificate
	Password pulumi.StringInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// The name of the API Management service.
	ServiceName pulumi.StringInput
}

func (CertificateArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*certificateArgs)(nil)).Elem()
}

type CertificateInput interface {
	pulumi.Input

	ToCertificateOutput() CertificateOutput
	ToCertificateOutputWithContext(ctx context.Context) CertificateOutput
}

func (Certificate) ElementType() reflect.Type {
	return reflect.TypeOf((*Certificate)(nil)).Elem()
}

func (i Certificate) ToCertificateOutput() CertificateOutput {
	return i.ToCertificateOutputWithContext(context.Background())
}

func (i Certificate) ToCertificateOutputWithContext(ctx context.Context) CertificateOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CertificateOutput)
}

type CertificateOutput struct {
	*pulumi.OutputState
}

func (CertificateOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*CertificateOutput)(nil)).Elem()
}

func (o CertificateOutput) ToCertificateOutput() CertificateOutput {
	return o
}

func (o CertificateOutput) ToCertificateOutputWithContext(ctx context.Context) CertificateOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(CertificateOutput{})
}
