// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200908preview

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Data controller resource
type DataController struct {
	pulumi.CustomResourceState

	// The raw kubernetes information
	K8sRaw pulumi.AnyOutput `pulumi:"k8sRaw"`
	// Last uploaded date from on premise cluster. Defaults to current date time
	LastUploadedDate pulumi.StringPtrOutput `pulumi:"lastUploadedDate"`
	// The geo-location where the resource lives
	Location pulumi.StringOutput `pulumi:"location"`
	// The name of the resource
	Name pulumi.StringOutput `pulumi:"name"`
	// Properties from the on premise data controller
	OnPremiseProperty OnPremisePropertyResponseOutput `pulumi:"onPremiseProperty"`
	// Read only system data
	SystemData SystemDataResponseOutput `pulumi:"systemData"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewDataController registers a new resource with the given unique name, arguments, and options.
func NewDataController(ctx *pulumi.Context,
	name string, args *DataControllerArgs, opts ...pulumi.ResourceOption) (*DataController, error) {
	if args == nil || args.DataControllerName == nil {
		return nil, errors.New("missing required argument 'DataControllerName'")
	}
	if args == nil || args.Location == nil {
		return nil, errors.New("missing required argument 'Location'")
	}
	if args == nil || args.OnPremiseProperty == nil {
		return nil, errors.New("missing required argument 'OnPremiseProperty'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &DataControllerArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:azuredata/v20190724preview:DataController"),
		},
	})
	opts = append(opts, aliases)
	var resource DataController
	err := ctx.RegisterResource("azure-nextgen:azuredata/v20200908preview:DataController", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDataController gets an existing DataController resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDataController(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DataControllerState, opts ...pulumi.ResourceOption) (*DataController, error) {
	var resource DataController
	err := ctx.ReadResource("azure-nextgen:azuredata/v20200908preview:DataController", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering DataController resources.
type dataControllerState struct {
	// The raw kubernetes information
	K8sRaw interface{} `pulumi:"k8sRaw"`
	// Last uploaded date from on premise cluster. Defaults to current date time
	LastUploadedDate *string `pulumi:"lastUploadedDate"`
	// The geo-location where the resource lives
	Location *string `pulumi:"location"`
	// The name of the resource
	Name *string `pulumi:"name"`
	// Properties from the on premise data controller
	OnPremiseProperty *OnPremisePropertyResponse `pulumi:"onPremiseProperty"`
	// Read only system data
	SystemData *SystemDataResponse `pulumi:"systemData"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts.
	Type *string `pulumi:"type"`
}

type DataControllerState struct {
	// The raw kubernetes information
	K8sRaw pulumi.Input
	// Last uploaded date from on premise cluster. Defaults to current date time
	LastUploadedDate pulumi.StringPtrInput
	// The geo-location where the resource lives
	Location pulumi.StringPtrInput
	// The name of the resource
	Name pulumi.StringPtrInput
	// Properties from the on premise data controller
	OnPremiseProperty OnPremisePropertyResponsePtrInput
	// Read only system data
	SystemData SystemDataResponsePtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts.
	Type pulumi.StringPtrInput
}

func (DataControllerState) ElementType() reflect.Type {
	return reflect.TypeOf((*dataControllerState)(nil)).Elem()
}

type dataControllerArgs struct {
	DataControllerName string `pulumi:"dataControllerName"`
	// The raw kubernetes information
	K8sRaw interface{} `pulumi:"k8sRaw"`
	// Last uploaded date from on premise cluster. Defaults to current date time
	LastUploadedDate *string `pulumi:"lastUploadedDate"`
	// The geo-location where the resource lives
	Location string `pulumi:"location"`
	// Properties from the on premise data controller
	OnPremiseProperty OnPremiseProperty `pulumi:"onPremiseProperty"`
	// The name of the Azure resource group
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a DataController resource.
type DataControllerArgs struct {
	DataControllerName pulumi.StringInput
	// The raw kubernetes information
	K8sRaw pulumi.Input
	// Last uploaded date from on premise cluster. Defaults to current date time
	LastUploadedDate pulumi.StringPtrInput
	// The geo-location where the resource lives
	Location pulumi.StringInput
	// Properties from the on premise data controller
	OnPremiseProperty OnPremisePropertyInput
	// The name of the Azure resource group
	ResourceGroupName pulumi.StringInput
	// Resource tags.
	Tags pulumi.StringMapInput
}

func (DataControllerArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*dataControllerArgs)(nil)).Elem()
}
