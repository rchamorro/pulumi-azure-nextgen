// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * Domain service.
 */
export class DomainService extends pulumi.CustomResource {
    /**
     * Get an existing DomainService resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): DomainService {
        return new DomainService(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:aad/v20170601:DomainService';

    /**
     * Returns true if the given object is an instance of DomainService.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is DomainService {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === DomainService.__pulumiType;
    }

    /**
     * Deployment Id
     */
    public /*out*/ readonly deploymentId!: pulumi.Output<string>;
    /**
     * Domain Configuration Type
     */
    public readonly domainConfigurationType!: pulumi.Output<string | undefined>;
    /**
     * List of Domain Controller IP Address
     */
    public /*out*/ readonly domainControllerIpAddress!: pulumi.Output<string[]>;
    /**
     * The name of the Azure domain that the user would like to deploy Domain Services to.
     */
    public readonly domainName!: pulumi.Output<string | undefined>;
    /**
     * DomainSecurity Settings
     */
    public readonly domainSecuritySettings!: pulumi.Output<outputs.aad.v20170601.DomainSecuritySettingsResponse | undefined>;
    /**
     * Resource etag
     */
    public readonly etag!: pulumi.Output<string | undefined>;
    /**
     * Enabled or Disabled flag to turn on Group-based filtered sync
     */
    public readonly filteredSync!: pulumi.Output<string | undefined>;
    /**
     * List of Domain Health Alerts
     */
    public /*out*/ readonly healthAlerts!: pulumi.Output<outputs.aad.v20170601.HealthAlertResponse[]>;
    /**
     * Last domain evaluation run DateTime
     */
    public /*out*/ readonly healthLastEvaluated!: pulumi.Output<string>;
    /**
     * List of Domain Health Monitors
     */
    public /*out*/ readonly healthMonitors!: pulumi.Output<outputs.aad.v20170601.HealthMonitorResponse[]>;
    /**
     * Secure LDAP Settings
     */
    public readonly ldapsSettings!: pulumi.Output<outputs.aad.v20170601.LdapsSettingsResponse | undefined>;
    /**
     * Resource location
     */
    public readonly location!: pulumi.Output<string | undefined>;
    /**
     * Resource name
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Notification Settings
     */
    public readonly notificationSettings!: pulumi.Output<outputs.aad.v20170601.NotificationSettingsResponse | undefined>;
    /**
     * the current deployment or provisioning state, which only appears in the response.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * Resource Forest Settings
     */
    public readonly resourceForestSettings!: pulumi.Output<outputs.aad.v20170601.ResourceForestSettingsResponse | undefined>;
    /**
     * Status of Domain Service instance
     */
    public /*out*/ readonly serviceStatus!: pulumi.Output<string>;
    /**
     * Sku Type
     */
    public readonly sku!: pulumi.Output<string | undefined>;
    /**
     * The name of the virtual network that Domain Services will be deployed on. The id of the subnet that Domain Services will be deployed on. /virtualNetwork/vnetName/subnets/subnetName.
     */
    public readonly subnetId!: pulumi.Output<string | undefined>;
    /**
     * Resource tags
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Azure Active Directory Tenant Id
     */
    public /*out*/ readonly tenantId!: pulumi.Output<string>;
    /**
     * Resource type
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * Data Model Version
     */
    public /*out*/ readonly version!: pulumi.Output<number>;
    /**
     * Virtual network site id
     */
    public /*out*/ readonly vnetSiteId!: pulumi.Output<string>;

    /**
     * Create a DomainService resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: DomainServiceArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.domainServiceName === undefined) {
                throw new Error("Missing required property 'domainServiceName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["domainConfigurationType"] = args ? args.domainConfigurationType : undefined;
            inputs["domainName"] = args ? args.domainName : undefined;
            inputs["domainSecuritySettings"] = args ? args.domainSecuritySettings : undefined;
            inputs["domainServiceName"] = args ? args.domainServiceName : undefined;
            inputs["etag"] = args ? args.etag : undefined;
            inputs["filteredSync"] = args ? args.filteredSync : undefined;
            inputs["ldapsSettings"] = args ? args.ldapsSettings : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["notificationSettings"] = args ? args.notificationSettings : undefined;
            inputs["resourceForestSettings"] = args ? args.resourceForestSettings : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["sku"] = args ? args.sku : undefined;
            inputs["subnetId"] = args ? args.subnetId : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["deploymentId"] = undefined /*out*/;
            inputs["domainControllerIpAddress"] = undefined /*out*/;
            inputs["healthAlerts"] = undefined /*out*/;
            inputs["healthLastEvaluated"] = undefined /*out*/;
            inputs["healthMonitors"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["serviceStatus"] = undefined /*out*/;
            inputs["tenantId"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["version"] = undefined /*out*/;
            inputs["vnetSiteId"] = undefined /*out*/;
        } else {
            inputs["deploymentId"] = undefined /*out*/;
            inputs["domainConfigurationType"] = undefined /*out*/;
            inputs["domainControllerIpAddress"] = undefined /*out*/;
            inputs["domainName"] = undefined /*out*/;
            inputs["domainSecuritySettings"] = undefined /*out*/;
            inputs["etag"] = undefined /*out*/;
            inputs["filteredSync"] = undefined /*out*/;
            inputs["healthAlerts"] = undefined /*out*/;
            inputs["healthLastEvaluated"] = undefined /*out*/;
            inputs["healthMonitors"] = undefined /*out*/;
            inputs["ldapsSettings"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["notificationSettings"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["resourceForestSettings"] = undefined /*out*/;
            inputs["serviceStatus"] = undefined /*out*/;
            inputs["sku"] = undefined /*out*/;
            inputs["subnetId"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["tenantId"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["version"] = undefined /*out*/;
            inputs["vnetSiteId"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:aad/latest:DomainService" }, { type: "azure-nextgen:aad/v20170101:DomainService" }, { type: "azure-nextgen:aad/v20200101:DomainService" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(DomainService.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a DomainService resource.
 */
export interface DomainServiceArgs {
    /**
     * Domain Configuration Type
     */
    readonly domainConfigurationType?: pulumi.Input<string>;
    /**
     * The name of the Azure domain that the user would like to deploy Domain Services to.
     */
    readonly domainName?: pulumi.Input<string>;
    /**
     * DomainSecurity Settings
     */
    readonly domainSecuritySettings?: pulumi.Input<inputs.aad.v20170601.DomainSecuritySettings>;
    /**
     * The name of the domain service.
     */
    readonly domainServiceName: pulumi.Input<string>;
    /**
     * Resource etag
     */
    readonly etag?: pulumi.Input<string>;
    /**
     * Enabled or Disabled flag to turn on Group-based filtered sync
     */
    readonly filteredSync?: pulumi.Input<string>;
    /**
     * Secure LDAP Settings
     */
    readonly ldapsSettings?: pulumi.Input<inputs.aad.v20170601.LdapsSettings>;
    /**
     * Resource location
     */
    readonly location?: pulumi.Input<string>;
    /**
     * Notification Settings
     */
    readonly notificationSettings?: pulumi.Input<inputs.aad.v20170601.NotificationSettings>;
    /**
     * Resource Forest Settings
     */
    readonly resourceForestSettings?: pulumi.Input<inputs.aad.v20170601.ResourceForestSettings>;
    /**
     * The name of the resource group within the user's subscription. The name is case insensitive.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Sku Type
     */
    readonly sku?: pulumi.Input<string>;
    /**
     * The name of the virtual network that Domain Services will be deployed on. The id of the subnet that Domain Services will be deployed on. /virtualNetwork/vnetName/subnets/subnetName.
     */
    readonly subnetId?: pulumi.Input<string>;
    /**
     * Resource tags
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}
