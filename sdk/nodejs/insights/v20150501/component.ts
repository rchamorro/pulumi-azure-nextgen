// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * An Application Insights component definition.
 */
export class Component extends pulumi.CustomResource {
    /**
     * Get an existing Component resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Component {
        return new Component(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:insights/v20150501:Component';

    /**
     * Returns true if the given object is an instance of Component.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Component {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Component.__pulumiType;
    }

    /**
     * Application Insights Unique ID for your Application.
     */
    public /*out*/ readonly appId!: pulumi.Output<string>;
    /**
     * The unique ID of your application. This field mirrors the 'Name' field and cannot be changed.
     */
    public /*out*/ readonly applicationId!: pulumi.Output<string>;
    /**
     * Type of application being monitored.
     */
    public readonly applicationType!: pulumi.Output<string>;
    /**
     * Application Insights component connection string.
     */
    public /*out*/ readonly connectionString!: pulumi.Output<string>;
    /**
     * Creation Date for the Application Insights component, in ISO 8601 format.
     */
    public /*out*/ readonly creationDate!: pulumi.Output<string>;
    /**
     * Disable IP masking.
     */
    public readonly disableIpMasking!: pulumi.Output<boolean | undefined>;
    /**
     * Used by the Application Insights system to determine what kind of flow this component was created by. This is to be set to 'Bluefield' when creating/updating a component via the REST API.
     */
    public readonly flowType!: pulumi.Output<string | undefined>;
    /**
     * The unique application ID created when a new application is added to HockeyApp, used for communications with HockeyApp.
     */
    public readonly hockeyAppId!: pulumi.Output<string | undefined>;
    /**
     * Token used to authenticate communications with between Application Insights and HockeyApp.
     */
    public /*out*/ readonly hockeyAppToken!: pulumi.Output<string>;
    /**
     * Purge data immediately after 30 days.
     */
    public readonly immediatePurgeDataOn30Days!: pulumi.Output<boolean | undefined>;
    /**
     * Indicates the flow of the ingestion.
     */
    public readonly ingestionMode!: pulumi.Output<string | undefined>;
    /**
     * Application Insights Instrumentation key. A read-only value that applications can use to identify the destination for all telemetry sent to Azure Application Insights. This value will be supplied upon construction of each new Application Insights component.
     */
    public /*out*/ readonly instrumentationKey!: pulumi.Output<string>;
    /**
     * The kind of application that this component refers to, used to customize UI. This value is a freeform string, values should typically be one of the following: web, ios, other, store, java, phone.
     */
    public readonly kind!: pulumi.Output<string>;
    /**
     * Resource location
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * Azure resource name
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * List of linked private link scope resources.
     */
    public /*out*/ readonly privateLinkScopedResources!: pulumi.Output<outputs.insights.v20150501.PrivateLinkScopedResourceResponse[]>;
    /**
     * Current state of this component: whether or not is has been provisioned within the resource group it is defined. Users cannot change this value but are able to read from it. Values will include Succeeded, Deploying, Canceled, and Failed.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * Describes what tool created this Application Insights component. Customers using this API should set this to the default 'rest'.
     */
    public readonly requestSource!: pulumi.Output<string | undefined>;
    /**
     * Retention period in days.
     */
    public readonly retentionInDays!: pulumi.Output<number | undefined>;
    /**
     * Percentage of the data produced by the application being monitored that is being sampled for Application Insights telemetry.
     */
    public readonly samplingPercentage!: pulumi.Output<number | undefined>;
    /**
     * Resource tags
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Azure Tenant Id.
     */
    public /*out*/ readonly tenantId!: pulumi.Output<string>;
    /**
     * Azure resource type
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a Component resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ComponentArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.applicationType === undefined) {
                throw new Error("Missing required property 'applicationType'");
            }
            if (!args || args.kind === undefined) {
                throw new Error("Missing required property 'kind'");
            }
            if (!args || args.location === undefined) {
                throw new Error("Missing required property 'location'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.resourceName === undefined) {
                throw new Error("Missing required property 'resourceName'");
            }
            inputs["applicationType"] = args ? args.applicationType : undefined;
            inputs["disableIpMasking"] = args ? args.disableIpMasking : undefined;
            inputs["flowType"] = args ? args.flowType : undefined;
            inputs["hockeyAppId"] = args ? args.hockeyAppId : undefined;
            inputs["immediatePurgeDataOn30Days"] = args ? args.immediatePurgeDataOn30Days : undefined;
            inputs["ingestionMode"] = args ? args.ingestionMode : undefined;
            inputs["kind"] = args ? args.kind : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["requestSource"] = args ? args.requestSource : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["resourceName"] = args ? args.resourceName : undefined;
            inputs["retentionInDays"] = args ? args.retentionInDays : undefined;
            inputs["samplingPercentage"] = args ? args.samplingPercentage : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["appId"] = undefined /*out*/;
            inputs["applicationId"] = undefined /*out*/;
            inputs["connectionString"] = undefined /*out*/;
            inputs["creationDate"] = undefined /*out*/;
            inputs["hockeyAppToken"] = undefined /*out*/;
            inputs["instrumentationKey"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["privateLinkScopedResources"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["tenantId"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["appId"] = undefined /*out*/;
            inputs["applicationId"] = undefined /*out*/;
            inputs["applicationType"] = undefined /*out*/;
            inputs["connectionString"] = undefined /*out*/;
            inputs["creationDate"] = undefined /*out*/;
            inputs["disableIpMasking"] = undefined /*out*/;
            inputs["flowType"] = undefined /*out*/;
            inputs["hockeyAppId"] = undefined /*out*/;
            inputs["hockeyAppToken"] = undefined /*out*/;
            inputs["immediatePurgeDataOn30Days"] = undefined /*out*/;
            inputs["ingestionMode"] = undefined /*out*/;
            inputs["instrumentationKey"] = undefined /*out*/;
            inputs["kind"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["privateLinkScopedResources"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["requestSource"] = undefined /*out*/;
            inputs["retentionInDays"] = undefined /*out*/;
            inputs["samplingPercentage"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["tenantId"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:insights/latest:Component" }, { type: "azure-nextgen:insights/v20180501preview:Component" }, { type: "azure-nextgen:insights/v20200202preview:Component" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(Component.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Component resource.
 */
export interface ComponentArgs {
    /**
     * Type of application being monitored.
     */
    readonly applicationType: pulumi.Input<string>;
    /**
     * Disable IP masking.
     */
    readonly disableIpMasking?: pulumi.Input<boolean>;
    /**
     * Used by the Application Insights system to determine what kind of flow this component was created by. This is to be set to 'Bluefield' when creating/updating a component via the REST API.
     */
    readonly flowType?: pulumi.Input<string>;
    /**
     * The unique application ID created when a new application is added to HockeyApp, used for communications with HockeyApp.
     */
    readonly hockeyAppId?: pulumi.Input<string>;
    /**
     * Purge data immediately after 30 days.
     */
    readonly immediatePurgeDataOn30Days?: pulumi.Input<boolean>;
    /**
     * Indicates the flow of the ingestion.
     */
    readonly ingestionMode?: pulumi.Input<string>;
    /**
     * The kind of application that this component refers to, used to customize UI. This value is a freeform string, values should typically be one of the following: web, ios, other, store, java, phone.
     */
    readonly kind: pulumi.Input<string>;
    /**
     * Resource location
     */
    readonly location: pulumi.Input<string>;
    /**
     * Describes what tool created this Application Insights component. Customers using this API should set this to the default 'rest'.
     */
    readonly requestSource?: pulumi.Input<string>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the Application Insights component resource.
     */
    readonly resourceName: pulumi.Input<string>;
    /**
     * Retention period in days.
     */
    readonly retentionInDays?: pulumi.Input<number>;
    /**
     * Percentage of the data produced by the application being monitored that is being sampled for Application Insights telemetry.
     */
    readonly samplingPercentage?: pulumi.Input<number>;
    /**
     * Resource tags
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}
