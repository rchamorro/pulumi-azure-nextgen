// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20180122

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// The X509 Certificate.
type Certificate struct {
	pulumi.CustomResourceState

	// The entity tag.
	Etag pulumi.StringOutput `pulumi:"etag"`
	// The name of the certificate.
	Name pulumi.StringOutput `pulumi:"name"`
	// The description of an X509 CA Certificate.
	Properties CertificatePropertiesResponseOutput `pulumi:"properties"`
	// The resource type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewCertificate registers a new resource with the given unique name, arguments, and options.
func NewCertificate(ctx *pulumi.Context,
	name string, args *CertificateArgs, opts ...pulumi.ResourceOption) (*Certificate, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.CertificateName == nil {
		return nil, errors.New("invalid value for required argument 'CertificateName'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	if args.ResourceName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:devices/latest:Certificate"),
		},
		{
			Type: pulumi.String("azure-nextgen:devices/v20170701:Certificate"),
		},
		{
			Type: pulumi.String("azure-nextgen:devices/v20180401:Certificate"),
		},
		{
			Type: pulumi.String("azure-nextgen:devices/v20181201preview:Certificate"),
		},
		{
			Type: pulumi.String("azure-nextgen:devices/v20190322:Certificate"),
		},
		{
			Type: pulumi.String("azure-nextgen:devices/v20190322preview:Certificate"),
		},
		{
			Type: pulumi.String("azure-nextgen:devices/v20190701preview:Certificate"),
		},
		{
			Type: pulumi.String("azure-nextgen:devices/v20191104:Certificate"),
		},
		{
			Type: pulumi.String("azure-nextgen:devices/v20200301:Certificate"),
		},
		{
			Type: pulumi.String("azure-nextgen:devices/v20200401:Certificate"),
		},
		{
			Type: pulumi.String("azure-nextgen:devices/v20200615:Certificate"),
		},
		{
			Type: pulumi.String("azure-nextgen:devices/v20200710preview:Certificate"),
		},
		{
			Type: pulumi.String("azure-nextgen:devices/v20200801:Certificate"),
		},
	})
	opts = append(opts, aliases)
	var resource Certificate
	err := ctx.RegisterResource("azure-nextgen:devices/v20180122:Certificate", name, args, &resource, opts...)
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
	err := ctx.ReadResource("azure-nextgen:devices/v20180122:Certificate", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Certificate resources.
type certificateState struct {
	// The entity tag.
	Etag *string `pulumi:"etag"`
	// The name of the certificate.
	Name *string `pulumi:"name"`
	// The description of an X509 CA Certificate.
	Properties *CertificatePropertiesResponse `pulumi:"properties"`
	// The resource type.
	Type *string `pulumi:"type"`
}

type CertificateState struct {
	// The entity tag.
	Etag pulumi.StringPtrInput
	// The name of the certificate.
	Name pulumi.StringPtrInput
	// The description of an X509 CA Certificate.
	Properties CertificatePropertiesResponsePtrInput
	// The resource type.
	Type pulumi.StringPtrInput
}

func (CertificateState) ElementType() reflect.Type {
	return reflect.TypeOf((*certificateState)(nil)).Elem()
}

type certificateArgs struct {
	// base-64 representation of the X509 leaf certificate .cer file or just .pem file content.
	Certificate *string `pulumi:"certificate"`
	// The name of the certificate
	CertificateName string `pulumi:"certificateName"`
	// The name of the resource group that contains the IoT hub.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the IoT hub.
	ResourceName string `pulumi:"resourceName"`
}

// The set of arguments for constructing a Certificate resource.
type CertificateArgs struct {
	// base-64 representation of the X509 leaf certificate .cer file or just .pem file content.
	Certificate pulumi.StringPtrInput
	// The name of the certificate
	CertificateName pulumi.StringInput
	// The name of the resource group that contains the IoT hub.
	ResourceGroupName pulumi.StringInput
	// The name of the IoT hub.
	ResourceName pulumi.StringInput
}

func (CertificateArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*certificateArgs)(nil)).Elem()
}

type CertificateInput interface {
	pulumi.Input

	ToCertificateOutput() CertificateOutput
	ToCertificateOutputWithContext(ctx context.Context) CertificateOutput
}

func (*Certificate) ElementType() reflect.Type {
	return reflect.TypeOf((*Certificate)(nil))
}

func (i *Certificate) ToCertificateOutput() CertificateOutput {
	return i.ToCertificateOutputWithContext(context.Background())
}

func (i *Certificate) ToCertificateOutputWithContext(ctx context.Context) CertificateOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CertificateOutput)
}

type CertificateOutput struct {
	*pulumi.OutputState
}

func (CertificateOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Certificate)(nil))
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
