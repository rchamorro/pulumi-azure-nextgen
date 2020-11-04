// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20181101

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Route Filter Rule Resource
type RouteFilterRule struct {
	pulumi.CustomResourceState

	// The access type of the rule. Valid values are: 'Allow', 'Deny'
	Access pulumi.StringOutput `pulumi:"access"`
	// The collection for bgp community values to filter on. e.g. ['12076:5010','12076:5020']
	Communities pulumi.StringArrayOutput `pulumi:"communities"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringOutput `pulumi:"etag"`
	// Resource location.
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// The name of the resource that is unique within a resource group. This name can be used to access the resource.
	Name pulumi.StringPtrOutput `pulumi:"name"`
	// The provisioning state of the resource. Possible values are: 'Updating', 'Deleting', 'Succeeded' and 'Failed'.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// The rule type of the rule. Valid value is: 'Community'
	RouteFilterRuleType pulumi.StringOutput `pulumi:"routeFilterRuleType"`
}

// NewRouteFilterRule registers a new resource with the given unique name, arguments, and options.
func NewRouteFilterRule(ctx *pulumi.Context,
	name string, args *RouteFilterRuleArgs, opts ...pulumi.ResourceOption) (*RouteFilterRule, error) {
	if args == nil || args.Access == nil {
		return nil, errors.New("missing required argument 'Access'")
	}
	if args == nil || args.Communities == nil {
		return nil, errors.New("missing required argument 'Communities'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.RouteFilterName == nil {
		return nil, errors.New("missing required argument 'RouteFilterName'")
	}
	if args == nil || args.RouteFilterRuleType == nil {
		return nil, errors.New("missing required argument 'RouteFilterRuleType'")
	}
	if args == nil || args.RuleName == nil {
		return nil, errors.New("missing required argument 'RuleName'")
	}
	if args == nil {
		args = &RouteFilterRuleArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:network/latest:RouteFilterRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20161201:RouteFilterRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20170301:RouteFilterRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20170601:RouteFilterRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20170801:RouteFilterRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20170901:RouteFilterRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20171001:RouteFilterRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20171101:RouteFilterRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180101:RouteFilterRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180201:RouteFilterRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180401:RouteFilterRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180601:RouteFilterRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180701:RouteFilterRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180801:RouteFilterRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20181001:RouteFilterRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20181201:RouteFilterRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190201:RouteFilterRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190401:RouteFilterRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190601:RouteFilterRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190701:RouteFilterRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190801:RouteFilterRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190901:RouteFilterRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20191101:RouteFilterRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20191201:RouteFilterRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200301:RouteFilterRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200401:RouteFilterRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200501:RouteFilterRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200601:RouteFilterRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200701:RouteFilterRule"),
		},
	})
	opts = append(opts, aliases)
	var resource RouteFilterRule
	err := ctx.RegisterResource("azure-nextgen:network/v20181101:RouteFilterRule", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetRouteFilterRule gets an existing RouteFilterRule resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetRouteFilterRule(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *RouteFilterRuleState, opts ...pulumi.ResourceOption) (*RouteFilterRule, error) {
	var resource RouteFilterRule
	err := ctx.ReadResource("azure-nextgen:network/v20181101:RouteFilterRule", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering RouteFilterRule resources.
type routeFilterRuleState struct {
	// The access type of the rule. Valid values are: 'Allow', 'Deny'
	Access *string `pulumi:"access"`
	// The collection for bgp community values to filter on. e.g. ['12076:5010','12076:5020']
	Communities []string `pulumi:"communities"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag *string `pulumi:"etag"`
	// Resource location.
	Location *string `pulumi:"location"`
	// The name of the resource that is unique within a resource group. This name can be used to access the resource.
	Name *string `pulumi:"name"`
	// The provisioning state of the resource. Possible values are: 'Updating', 'Deleting', 'Succeeded' and 'Failed'.
	ProvisioningState *string `pulumi:"provisioningState"`
	// The rule type of the rule. Valid value is: 'Community'
	RouteFilterRuleType *string `pulumi:"routeFilterRuleType"`
}

type RouteFilterRuleState struct {
	// The access type of the rule. Valid values are: 'Allow', 'Deny'
	Access pulumi.StringPtrInput
	// The collection for bgp community values to filter on. e.g. ['12076:5010','12076:5020']
	Communities pulumi.StringArrayInput
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrInput
	// Resource location.
	Location pulumi.StringPtrInput
	// The name of the resource that is unique within a resource group. This name can be used to access the resource.
	Name pulumi.StringPtrInput
	// The provisioning state of the resource. Possible values are: 'Updating', 'Deleting', 'Succeeded' and 'Failed'.
	ProvisioningState pulumi.StringPtrInput
	// The rule type of the rule. Valid value is: 'Community'
	RouteFilterRuleType pulumi.StringPtrInput
}

func (RouteFilterRuleState) ElementType() reflect.Type {
	return reflect.TypeOf((*routeFilterRuleState)(nil)).Elem()
}

type routeFilterRuleArgs struct {
	// The access type of the rule. Valid values are: 'Allow', 'Deny'
	Access string `pulumi:"access"`
	// The collection for bgp community values to filter on. e.g. ['12076:5010','12076:5020']
	Communities []string `pulumi:"communities"`
	// Resource ID.
	Id *string `pulumi:"id"`
	// Resource location.
	Location *string `pulumi:"location"`
	// The name of the resource that is unique within a resource group. This name can be used to access the resource.
	Name *string `pulumi:"name"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the route filter.
	RouteFilterName string `pulumi:"routeFilterName"`
	// The rule type of the rule. Valid value is: 'Community'
	RouteFilterRuleType string `pulumi:"routeFilterRuleType"`
	// The name of the route filter rule.
	RuleName string `pulumi:"ruleName"`
}

// The set of arguments for constructing a RouteFilterRule resource.
type RouteFilterRuleArgs struct {
	// The access type of the rule. Valid values are: 'Allow', 'Deny'
	Access pulumi.StringInput
	// The collection for bgp community values to filter on. e.g. ['12076:5010','12076:5020']
	Communities pulumi.StringArrayInput
	// Resource ID.
	Id pulumi.StringPtrInput
	// Resource location.
	Location pulumi.StringPtrInput
	// The name of the resource that is unique within a resource group. This name can be used to access the resource.
	Name pulumi.StringPtrInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// The name of the route filter.
	RouteFilterName pulumi.StringInput
	// The rule type of the rule. Valid value is: 'Community'
	RouteFilterRuleType pulumi.StringInput
	// The name of the route filter rule.
	RuleName pulumi.StringInput
}

func (RouteFilterRuleArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*routeFilterRuleArgs)(nil)).Elem()
}
