// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20190101preview

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Represents an incident in Azure Security Insights.
type Incident struct {
	pulumi.CustomResourceState

	// Additional data on the incident
	AdditionalData IncidentAdditionalDataResponseOutput `pulumi:"additionalData"`
	// The reason the incident was closed
	Classification pulumi.StringPtrOutput `pulumi:"classification"`
	// Describes the reason the incident was closed
	ClassificationComment pulumi.StringPtrOutput `pulumi:"classificationComment"`
	// The classification reason the incident was closed with
	ClassificationReason pulumi.StringPtrOutput `pulumi:"classificationReason"`
	// The time the incident was created
	CreatedTimeUtc pulumi.StringOutput `pulumi:"createdTimeUtc"`
	// The description of the incident
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// Etag of the azure resource
	Etag pulumi.StringPtrOutput `pulumi:"etag"`
	// The time of the first activity in the incident
	FirstActivityTimeUtc pulumi.StringPtrOutput `pulumi:"firstActivityTimeUtc"`
	// A sequential number
	IncidentNumber pulumi.IntOutput `pulumi:"incidentNumber"`
	// The deep-link url to the incident in Azure portal
	IncidentUrl pulumi.StringOutput `pulumi:"incidentUrl"`
	// List of labels relevant to this incident
	Labels IncidentLabelResponseArrayOutput `pulumi:"labels"`
	// The time of the last activity in the incident
	LastActivityTimeUtc pulumi.StringPtrOutput `pulumi:"lastActivityTimeUtc"`
	// The last time the incident was updated
	LastModifiedTimeUtc pulumi.StringOutput `pulumi:"lastModifiedTimeUtc"`
	// Azure resource name
	Name pulumi.StringOutput `pulumi:"name"`
	// Describes a user that the incident is assigned to
	Owner IncidentOwnerInfoResponsePtrOutput `pulumi:"owner"`
	// The incident ID assigned by the incident provider
	ProviderIncidentId pulumi.StringPtrOutput `pulumi:"providerIncidentId"`
	// The name of the source provider that generated the incident
	ProviderName pulumi.StringPtrOutput `pulumi:"providerName"`
	// List of resource ids of Analytic rules related to the incident
	RelatedAnalyticRuleIds pulumi.StringArrayOutput `pulumi:"relatedAnalyticRuleIds"`
	// The severity of the incident
	Severity pulumi.StringOutput `pulumi:"severity"`
	// The status of the incident
	Status pulumi.StringOutput `pulumi:"status"`
	// The title of the incident
	Title pulumi.StringOutput `pulumi:"title"`
	// Azure resource type
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewIncident registers a new resource with the given unique name, arguments, and options.
func NewIncident(ctx *pulumi.Context,
	name string, args *IncidentArgs, opts ...pulumi.ResourceOption) (*Incident, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.IncidentId == nil {
		return nil, errors.New("invalid value for required argument 'IncidentId'")
	}
	if args.OperationalInsightsResourceProvider == nil {
		return nil, errors.New("invalid value for required argument 'OperationalInsightsResourceProvider'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	if args.Severity == nil {
		return nil, errors.New("invalid value for required argument 'Severity'")
	}
	if args.Status == nil {
		return nil, errors.New("invalid value for required argument 'Status'")
	}
	if args.Title == nil {
		return nil, errors.New("invalid value for required argument 'Title'")
	}
	if args.WorkspaceName == nil {
		return nil, errors.New("invalid value for required argument 'WorkspaceName'")
	}
	var resource Incident
	err := ctx.RegisterResource("azure-nextgen:securityinsights/v20190101preview:Incident", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetIncident gets an existing Incident resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetIncident(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *IncidentState, opts ...pulumi.ResourceOption) (*Incident, error) {
	var resource Incident
	err := ctx.ReadResource("azure-nextgen:securityinsights/v20190101preview:Incident", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Incident resources.
type incidentState struct {
	// Additional data on the incident
	AdditionalData *IncidentAdditionalDataResponse `pulumi:"additionalData"`
	// The reason the incident was closed
	Classification *string `pulumi:"classification"`
	// Describes the reason the incident was closed
	ClassificationComment *string `pulumi:"classificationComment"`
	// The classification reason the incident was closed with
	ClassificationReason *string `pulumi:"classificationReason"`
	// The time the incident was created
	CreatedTimeUtc *string `pulumi:"createdTimeUtc"`
	// The description of the incident
	Description *string `pulumi:"description"`
	// Etag of the azure resource
	Etag *string `pulumi:"etag"`
	// The time of the first activity in the incident
	FirstActivityTimeUtc *string `pulumi:"firstActivityTimeUtc"`
	// A sequential number
	IncidentNumber *int `pulumi:"incidentNumber"`
	// The deep-link url to the incident in Azure portal
	IncidentUrl *string `pulumi:"incidentUrl"`
	// List of labels relevant to this incident
	Labels []IncidentLabelResponse `pulumi:"labels"`
	// The time of the last activity in the incident
	LastActivityTimeUtc *string `pulumi:"lastActivityTimeUtc"`
	// The last time the incident was updated
	LastModifiedTimeUtc *string `pulumi:"lastModifiedTimeUtc"`
	// Azure resource name
	Name *string `pulumi:"name"`
	// Describes a user that the incident is assigned to
	Owner *IncidentOwnerInfoResponse `pulumi:"owner"`
	// The incident ID assigned by the incident provider
	ProviderIncidentId *string `pulumi:"providerIncidentId"`
	// The name of the source provider that generated the incident
	ProviderName *string `pulumi:"providerName"`
	// List of resource ids of Analytic rules related to the incident
	RelatedAnalyticRuleIds []string `pulumi:"relatedAnalyticRuleIds"`
	// The severity of the incident
	Severity *string `pulumi:"severity"`
	// The status of the incident
	Status *string `pulumi:"status"`
	// The title of the incident
	Title *string `pulumi:"title"`
	// Azure resource type
	Type *string `pulumi:"type"`
}

type IncidentState struct {
	// Additional data on the incident
	AdditionalData IncidentAdditionalDataResponsePtrInput
	// The reason the incident was closed
	Classification pulumi.StringPtrInput
	// Describes the reason the incident was closed
	ClassificationComment pulumi.StringPtrInput
	// The classification reason the incident was closed with
	ClassificationReason pulumi.StringPtrInput
	// The time the incident was created
	CreatedTimeUtc pulumi.StringPtrInput
	// The description of the incident
	Description pulumi.StringPtrInput
	// Etag of the azure resource
	Etag pulumi.StringPtrInput
	// The time of the first activity in the incident
	FirstActivityTimeUtc pulumi.StringPtrInput
	// A sequential number
	IncidentNumber pulumi.IntPtrInput
	// The deep-link url to the incident in Azure portal
	IncidentUrl pulumi.StringPtrInput
	// List of labels relevant to this incident
	Labels IncidentLabelResponseArrayInput
	// The time of the last activity in the incident
	LastActivityTimeUtc pulumi.StringPtrInput
	// The last time the incident was updated
	LastModifiedTimeUtc pulumi.StringPtrInput
	// Azure resource name
	Name pulumi.StringPtrInput
	// Describes a user that the incident is assigned to
	Owner IncidentOwnerInfoResponsePtrInput
	// The incident ID assigned by the incident provider
	ProviderIncidentId pulumi.StringPtrInput
	// The name of the source provider that generated the incident
	ProviderName pulumi.StringPtrInput
	// List of resource ids of Analytic rules related to the incident
	RelatedAnalyticRuleIds pulumi.StringArrayInput
	// The severity of the incident
	Severity pulumi.StringPtrInput
	// The status of the incident
	Status pulumi.StringPtrInput
	// The title of the incident
	Title pulumi.StringPtrInput
	// Azure resource type
	Type pulumi.StringPtrInput
}

func (IncidentState) ElementType() reflect.Type {
	return reflect.TypeOf((*incidentState)(nil)).Elem()
}

type incidentArgs struct {
	// The reason the incident was closed
	Classification *string `pulumi:"classification"`
	// Describes the reason the incident was closed
	ClassificationComment *string `pulumi:"classificationComment"`
	// The classification reason the incident was closed with
	ClassificationReason *string `pulumi:"classificationReason"`
	// The description of the incident
	Description *string `pulumi:"description"`
	// Etag of the azure resource
	Etag *string `pulumi:"etag"`
	// The time of the first activity in the incident
	FirstActivityTimeUtc *string `pulumi:"firstActivityTimeUtc"`
	// Incident ID
	IncidentId string `pulumi:"incidentId"`
	// List of labels relevant to this incident
	Labels []IncidentLabel `pulumi:"labels"`
	// The time of the last activity in the incident
	LastActivityTimeUtc *string `pulumi:"lastActivityTimeUtc"`
	// The namespace of workspaces resource provider- Microsoft.OperationalInsights.
	OperationalInsightsResourceProvider string `pulumi:"operationalInsightsResourceProvider"`
	// Describes a user that the incident is assigned to
	Owner *IncidentOwnerInfo `pulumi:"owner"`
	// The incident ID assigned by the incident provider
	ProviderIncidentId *string `pulumi:"providerIncidentId"`
	// The name of the source provider that generated the incident
	ProviderName *string `pulumi:"providerName"`
	// The name of the resource group within the user's subscription. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The severity of the incident
	Severity string `pulumi:"severity"`
	// The status of the incident
	Status string `pulumi:"status"`
	// The title of the incident
	Title string `pulumi:"title"`
	// The name of the workspace.
	WorkspaceName string `pulumi:"workspaceName"`
}

// The set of arguments for constructing a Incident resource.
type IncidentArgs struct {
	// The reason the incident was closed
	Classification pulumi.StringPtrInput
	// Describes the reason the incident was closed
	ClassificationComment pulumi.StringPtrInput
	// The classification reason the incident was closed with
	ClassificationReason pulumi.StringPtrInput
	// The description of the incident
	Description pulumi.StringPtrInput
	// Etag of the azure resource
	Etag pulumi.StringPtrInput
	// The time of the first activity in the incident
	FirstActivityTimeUtc pulumi.StringPtrInput
	// Incident ID
	IncidentId pulumi.StringInput
	// List of labels relevant to this incident
	Labels IncidentLabelArrayInput
	// The time of the last activity in the incident
	LastActivityTimeUtc pulumi.StringPtrInput
	// The namespace of workspaces resource provider- Microsoft.OperationalInsights.
	OperationalInsightsResourceProvider pulumi.StringInput
	// Describes a user that the incident is assigned to
	Owner IncidentOwnerInfoPtrInput
	// The incident ID assigned by the incident provider
	ProviderIncidentId pulumi.StringPtrInput
	// The name of the source provider that generated the incident
	ProviderName pulumi.StringPtrInput
	// The name of the resource group within the user's subscription. The name is case insensitive.
	ResourceGroupName pulumi.StringInput
	// The severity of the incident
	Severity pulumi.StringInput
	// The status of the incident
	Status pulumi.StringInput
	// The title of the incident
	Title pulumi.StringInput
	// The name of the workspace.
	WorkspaceName pulumi.StringInput
}

func (IncidentArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*incidentArgs)(nil)).Elem()
}

type IncidentInput interface {
	pulumi.Input

	ToIncidentOutput() IncidentOutput
	ToIncidentOutputWithContext(ctx context.Context) IncidentOutput
}

func (*Incident) ElementType() reflect.Type {
	return reflect.TypeOf((*Incident)(nil))
}

func (i *Incident) ToIncidentOutput() IncidentOutput {
	return i.ToIncidentOutputWithContext(context.Background())
}

func (i *Incident) ToIncidentOutputWithContext(ctx context.Context) IncidentOutput {
	return pulumi.ToOutputWithContext(ctx, i).(IncidentOutput)
}

type IncidentOutput struct {
	*pulumi.OutputState
}

func (IncidentOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Incident)(nil))
}

func (o IncidentOutput) ToIncidentOutput() IncidentOutput {
	return o
}

func (o IncidentOutput) ToIncidentOutputWithContext(ctx context.Context) IncidentOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(IncidentOutput{})
}
