// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20170601

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Domain service.
type DomainService struct {
	pulumi.CustomResourceState

	// List of Domain Controller IP Address
	DomainControllerIpAddress pulumi.StringArrayOutput `pulumi:"domainControllerIpAddress"`
	// The name of the Azure domain that the user would like to deploy Domain Services to.
	DomainName pulumi.StringPtrOutput `pulumi:"domainName"`
	// DomainSecurity Settings
	DomainSecuritySettings DomainSecuritySettingsResponsePtrOutput `pulumi:"domainSecuritySettings"`
	// Resource etag
	Etag pulumi.StringPtrOutput `pulumi:"etag"`
	// Enabled or Disabled flag to turn on Group-based filtered sync
	FilteredSync pulumi.StringPtrOutput `pulumi:"filteredSync"`
	// List of Domain Health Alerts
	HealthAlerts HealthAlertResponseArrayOutput `pulumi:"healthAlerts"`
	// Last domain evaluation run DateTime
	HealthLastEvaluated pulumi.StringOutput `pulumi:"healthLastEvaluated"`
	// List of Domain Health Monitors
	HealthMonitors HealthMonitorResponseArrayOutput `pulumi:"healthMonitors"`
	// Secure LDAP Settings
	LdapsSettings LdapsSettingsResponsePtrOutput `pulumi:"ldapsSettings"`
	// Resource location
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// Resource name
	Name pulumi.StringOutput `pulumi:"name"`
	// Notification Settings
	NotificationSettings NotificationSettingsResponsePtrOutput `pulumi:"notificationSettings"`
	// the current deployment or provisioning state, which only appears in the response.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// Status of Domain Service instance
	ServiceStatus pulumi.StringOutput `pulumi:"serviceStatus"`
	// The name of the virtual network that Domain Services will be deployed on. The id of the subnet that Domain Services will be deployed on. /virtualNetwork/vnetName/subnets/subnetName.
	SubnetId pulumi.StringPtrOutput `pulumi:"subnetId"`
	// Resource tags
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Azure Active Directory tenant id
	TenantId pulumi.StringOutput `pulumi:"tenantId"`
	// Resource type
	Type pulumi.StringOutput `pulumi:"type"`
	// Virtual network site id
	VnetSiteId pulumi.StringOutput `pulumi:"vnetSiteId"`
}

// NewDomainService registers a new resource with the given unique name, arguments, and options.
func NewDomainService(ctx *pulumi.Context,
	name string, args *DomainServiceArgs, opts ...pulumi.ResourceOption) (*DomainService, error) {
	if args == nil || args.DomainServiceName == nil {
		return nil, errors.New("missing required argument 'DomainServiceName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &DomainServiceArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:aad/latest:DomainService"),
		},
		{
			Type: pulumi.String("azure-nextgen:aad/v20170101:DomainService"),
		},
		{
			Type: pulumi.String("azure-nextgen:aad/v20200101:DomainService"),
		},
	})
	opts = append(opts, aliases)
	var resource DomainService
	err := ctx.RegisterResource("azure-nextgen:aad/v20170601:DomainService", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDomainService gets an existing DomainService resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDomainService(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DomainServiceState, opts ...pulumi.ResourceOption) (*DomainService, error) {
	var resource DomainService
	err := ctx.ReadResource("azure-nextgen:aad/v20170601:DomainService", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering DomainService resources.
type domainServiceState struct {
	// List of Domain Controller IP Address
	DomainControllerIpAddress []string `pulumi:"domainControllerIpAddress"`
	// The name of the Azure domain that the user would like to deploy Domain Services to.
	DomainName *string `pulumi:"domainName"`
	// DomainSecurity Settings
	DomainSecuritySettings *DomainSecuritySettingsResponse `pulumi:"domainSecuritySettings"`
	// Resource etag
	Etag *string `pulumi:"etag"`
	// Enabled or Disabled flag to turn on Group-based filtered sync
	FilteredSync *string `pulumi:"filteredSync"`
	// List of Domain Health Alerts
	HealthAlerts []HealthAlertResponse `pulumi:"healthAlerts"`
	// Last domain evaluation run DateTime
	HealthLastEvaluated *string `pulumi:"healthLastEvaluated"`
	// List of Domain Health Monitors
	HealthMonitors []HealthMonitorResponse `pulumi:"healthMonitors"`
	// Secure LDAP Settings
	LdapsSettings *LdapsSettingsResponse `pulumi:"ldapsSettings"`
	// Resource location
	Location *string `pulumi:"location"`
	// Resource name
	Name *string `pulumi:"name"`
	// Notification Settings
	NotificationSettings *NotificationSettingsResponse `pulumi:"notificationSettings"`
	// the current deployment or provisioning state, which only appears in the response.
	ProvisioningState *string `pulumi:"provisioningState"`
	// Status of Domain Service instance
	ServiceStatus *string `pulumi:"serviceStatus"`
	// The name of the virtual network that Domain Services will be deployed on. The id of the subnet that Domain Services will be deployed on. /virtualNetwork/vnetName/subnets/subnetName.
	SubnetId *string `pulumi:"subnetId"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// Azure Active Directory tenant id
	TenantId *string `pulumi:"tenantId"`
	// Resource type
	Type *string `pulumi:"type"`
	// Virtual network site id
	VnetSiteId *string `pulumi:"vnetSiteId"`
}

type DomainServiceState struct {
	// List of Domain Controller IP Address
	DomainControllerIpAddress pulumi.StringArrayInput
	// The name of the Azure domain that the user would like to deploy Domain Services to.
	DomainName pulumi.StringPtrInput
	// DomainSecurity Settings
	DomainSecuritySettings DomainSecuritySettingsResponsePtrInput
	// Resource etag
	Etag pulumi.StringPtrInput
	// Enabled or Disabled flag to turn on Group-based filtered sync
	FilteredSync pulumi.StringPtrInput
	// List of Domain Health Alerts
	HealthAlerts HealthAlertResponseArrayInput
	// Last domain evaluation run DateTime
	HealthLastEvaluated pulumi.StringPtrInput
	// List of Domain Health Monitors
	HealthMonitors HealthMonitorResponseArrayInput
	// Secure LDAP Settings
	LdapsSettings LdapsSettingsResponsePtrInput
	// Resource location
	Location pulumi.StringPtrInput
	// Resource name
	Name pulumi.StringPtrInput
	// Notification Settings
	NotificationSettings NotificationSettingsResponsePtrInput
	// the current deployment or provisioning state, which only appears in the response.
	ProvisioningState pulumi.StringPtrInput
	// Status of Domain Service instance
	ServiceStatus pulumi.StringPtrInput
	// The name of the virtual network that Domain Services will be deployed on. The id of the subnet that Domain Services will be deployed on. /virtualNetwork/vnetName/subnets/subnetName.
	SubnetId pulumi.StringPtrInput
	// Resource tags
	Tags pulumi.StringMapInput
	// Azure Active Directory tenant id
	TenantId pulumi.StringPtrInput
	// Resource type
	Type pulumi.StringPtrInput
	// Virtual network site id
	VnetSiteId pulumi.StringPtrInput
}

func (DomainServiceState) ElementType() reflect.Type {
	return reflect.TypeOf((*domainServiceState)(nil)).Elem()
}

type domainServiceArgs struct {
	// The name of the Azure domain that the user would like to deploy Domain Services to.
	DomainName *string `pulumi:"domainName"`
	// DomainSecurity Settings
	DomainSecuritySettings *DomainSecuritySettings `pulumi:"domainSecuritySettings"`
	// The name of the domain service.
	DomainServiceName string `pulumi:"domainServiceName"`
	// Resource etag
	Etag *string `pulumi:"etag"`
	// Enabled or Disabled flag to turn on Group-based filtered sync
	FilteredSync *string `pulumi:"filteredSync"`
	// Secure LDAP Settings
	LdapsSettings *LdapsSettings `pulumi:"ldapsSettings"`
	// Resource location
	Location *string `pulumi:"location"`
	// Notification Settings
	NotificationSettings *NotificationSettings `pulumi:"notificationSettings"`
	// The name of the resource group within the user's subscription. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the virtual network that Domain Services will be deployed on. The id of the subnet that Domain Services will be deployed on. /virtualNetwork/vnetName/subnets/subnetName.
	SubnetId *string `pulumi:"subnetId"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a DomainService resource.
type DomainServiceArgs struct {
	// The name of the Azure domain that the user would like to deploy Domain Services to.
	DomainName pulumi.StringPtrInput
	// DomainSecurity Settings
	DomainSecuritySettings DomainSecuritySettingsPtrInput
	// The name of the domain service.
	DomainServiceName pulumi.StringInput
	// Resource etag
	Etag pulumi.StringPtrInput
	// Enabled or Disabled flag to turn on Group-based filtered sync
	FilteredSync pulumi.StringPtrInput
	// Secure LDAP Settings
	LdapsSettings LdapsSettingsPtrInput
	// Resource location
	Location pulumi.StringPtrInput
	// Notification Settings
	NotificationSettings NotificationSettingsPtrInput
	// The name of the resource group within the user's subscription. The name is case insensitive.
	ResourceGroupName pulumi.StringInput
	// The name of the virtual network that Domain Services will be deployed on. The id of the subnet that Domain Services will be deployed on. /virtualNetwork/vnetName/subnets/subnetName.
	SubnetId pulumi.StringPtrInput
	// Resource tags
	Tags pulumi.StringMapInput
}

func (DomainServiceArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*domainServiceArgs)(nil)).Elem()
}