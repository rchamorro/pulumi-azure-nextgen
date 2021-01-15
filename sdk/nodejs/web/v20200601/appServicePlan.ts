// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * App Service plan.
 */
export class AppServicePlan extends pulumi.CustomResource {
    /**
     * Get an existing AppServicePlan resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): AppServicePlan {
        return new AppServicePlan(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:web/v20200601:AppServicePlan';

    /**
     * Returns true if the given object is an instance of AppServicePlan.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is AppServicePlan {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === AppServicePlan.__pulumiType;
    }

    /**
     * The time when the server farm free offer expires.
     */
    public readonly freeOfferExpirationTime!: pulumi.Output<string | undefined>;
    /**
     * Geographical location for the App Service plan.
     */
    public /*out*/ readonly geoRegion!: pulumi.Output<string>;
    /**
     * Specification for the App Service Environment to use for the App Service plan.
     */
    public readonly hostingEnvironmentProfile!: pulumi.Output<outputs.web.v20200601.HostingEnvironmentProfileResponse | undefined>;
    /**
     * If Hyper-V container app service plan <code>true</code>, <code>false</code> otherwise.
     */
    public readonly hyperV!: pulumi.Output<boolean | undefined>;
    /**
     * If <code>true</code>, this App Service Plan owns spot instances.
     */
    public readonly isSpot!: pulumi.Output<boolean | undefined>;
    /**
     * Obsolete: If Hyper-V container app service plan <code>true</code>, <code>false</code> otherwise.
     */
    public readonly isXenon!: pulumi.Output<boolean | undefined>;
    /**
     * Kind of resource.
     */
    public readonly kind!: pulumi.Output<string | undefined>;
    /**
     * Resource Location.
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * Maximum number of total workers allowed for this ElasticScaleEnabled App Service Plan
     */
    public readonly maximumElasticWorkerCount!: pulumi.Output<number | undefined>;
    /**
     * Maximum number of instances that can be assigned to this App Service plan.
     */
    public /*out*/ readonly maximumNumberOfWorkers!: pulumi.Output<number>;
    /**
     * Resource Name.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Number of apps assigned to this App Service plan.
     */
    public /*out*/ readonly numberOfSites!: pulumi.Output<number>;
    /**
     * If <code>true</code>, apps assigned to this App Service plan can be scaled independently.
     * If <code>false</code>, apps assigned to this App Service plan will scale to all instances of the plan.
     */
    public readonly perSiteScaling!: pulumi.Output<boolean | undefined>;
    /**
     * Provisioning state of the App Service Environment.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * If Linux app service plan <code>true</code>, <code>false</code> otherwise.
     */
    public readonly reserved!: pulumi.Output<boolean | undefined>;
    /**
     * Resource group of the App Service plan.
     */
    public /*out*/ readonly resourceGroup!: pulumi.Output<string>;
    /**
     * Description of a SKU for a scalable resource.
     */
    public readonly sku!: pulumi.Output<outputs.web.v20200601.SkuDescriptionResponse | undefined>;
    /**
     * The time when the server farm expires. Valid only if it is a spot server farm.
     */
    public readonly spotExpirationTime!: pulumi.Output<string | undefined>;
    /**
     * App Service plan status.
     */
    public /*out*/ readonly status!: pulumi.Output<string>;
    /**
     * App Service plan subscription.
     */
    public /*out*/ readonly subscription!: pulumi.Output<string>;
    /**
     * Resource tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Scaling worker count.
     */
    public readonly targetWorkerCount!: pulumi.Output<number | undefined>;
    /**
     * Scaling worker size ID.
     */
    public readonly targetWorkerSizeId!: pulumi.Output<number | undefined>;
    /**
     * Resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * Target worker tier assigned to the App Service plan.
     */
    public readonly workerTierName!: pulumi.Output<string | undefined>;

    /**
     * Create a AppServicePlan resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: AppServicePlanArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.location === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'location'");
            }
            if ((!args || args.name === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'name'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["freeOfferExpirationTime"] = args ? args.freeOfferExpirationTime : undefined;
            inputs["hostingEnvironmentProfile"] = args ? args.hostingEnvironmentProfile : undefined;
            inputs["hyperV"] = (args ? args.hyperV : undefined) || false;
            inputs["isSpot"] = args ? args.isSpot : undefined;
            inputs["isXenon"] = (args ? args.isXenon : undefined) || false;
            inputs["kind"] = args ? args.kind : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["maximumElasticWorkerCount"] = args ? args.maximumElasticWorkerCount : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["perSiteScaling"] = (args ? args.perSiteScaling : undefined) || false;
            inputs["reserved"] = (args ? args.reserved : undefined) || false;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["sku"] = args ? args.sku : undefined;
            inputs["spotExpirationTime"] = args ? args.spotExpirationTime : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["targetWorkerCount"] = args ? args.targetWorkerCount : undefined;
            inputs["targetWorkerSizeId"] = args ? args.targetWorkerSizeId : undefined;
            inputs["workerTierName"] = args ? args.workerTierName : undefined;
            inputs["geoRegion"] = undefined /*out*/;
            inputs["maximumNumberOfWorkers"] = undefined /*out*/;
            inputs["numberOfSites"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["resourceGroup"] = undefined /*out*/;
            inputs["status"] = undefined /*out*/;
            inputs["subscription"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["freeOfferExpirationTime"] = undefined /*out*/;
            inputs["geoRegion"] = undefined /*out*/;
            inputs["hostingEnvironmentProfile"] = undefined /*out*/;
            inputs["hyperV"] = undefined /*out*/;
            inputs["isSpot"] = undefined /*out*/;
            inputs["isXenon"] = undefined /*out*/;
            inputs["kind"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["maximumElasticWorkerCount"] = undefined /*out*/;
            inputs["maximumNumberOfWorkers"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["numberOfSites"] = undefined /*out*/;
            inputs["perSiteScaling"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["reserved"] = undefined /*out*/;
            inputs["resourceGroup"] = undefined /*out*/;
            inputs["sku"] = undefined /*out*/;
            inputs["spotExpirationTime"] = undefined /*out*/;
            inputs["status"] = undefined /*out*/;
            inputs["subscription"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["targetWorkerCount"] = undefined /*out*/;
            inputs["targetWorkerSizeId"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["workerTierName"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:web/latest:AppServicePlan" }, { type: "azure-nextgen:web/v20150801:AppServicePlan" }, { type: "azure-nextgen:web/v20160901:AppServicePlan" }, { type: "azure-nextgen:web/v20180201:AppServicePlan" }, { type: "azure-nextgen:web/v20190801:AppServicePlan" }, { type: "azure-nextgen:web/v20200901:AppServicePlan" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(AppServicePlan.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a AppServicePlan resource.
 */
export interface AppServicePlanArgs {
    /**
     * The time when the server farm free offer expires.
     */
    readonly freeOfferExpirationTime?: pulumi.Input<string>;
    /**
     * Specification for the App Service Environment to use for the App Service plan.
     */
    readonly hostingEnvironmentProfile?: pulumi.Input<inputs.web.v20200601.HostingEnvironmentProfile>;
    /**
     * If Hyper-V container app service plan <code>true</code>, <code>false</code> otherwise.
     */
    readonly hyperV?: pulumi.Input<boolean>;
    /**
     * If <code>true</code>, this App Service Plan owns spot instances.
     */
    readonly isSpot?: pulumi.Input<boolean>;
    /**
     * Obsolete: If Hyper-V container app service plan <code>true</code>, <code>false</code> otherwise.
     */
    readonly isXenon?: pulumi.Input<boolean>;
    /**
     * Kind of resource.
     */
    readonly kind?: pulumi.Input<string>;
    /**
     * Resource Location.
     */
    readonly location: pulumi.Input<string>;
    /**
     * Maximum number of total workers allowed for this ElasticScaleEnabled App Service Plan
     */
    readonly maximumElasticWorkerCount?: pulumi.Input<number>;
    /**
     * Name of the App Service plan.
     */
    readonly name: pulumi.Input<string>;
    /**
     * If <code>true</code>, apps assigned to this App Service plan can be scaled independently.
     * If <code>false</code>, apps assigned to this App Service plan will scale to all instances of the plan.
     */
    readonly perSiteScaling?: pulumi.Input<boolean>;
    /**
     * If Linux app service plan <code>true</code>, <code>false</code> otherwise.
     */
    readonly reserved?: pulumi.Input<boolean>;
    /**
     * Name of the resource group to which the resource belongs.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Description of a SKU for a scalable resource.
     */
    readonly sku?: pulumi.Input<inputs.web.v20200601.SkuDescription>;
    /**
     * The time when the server farm expires. Valid only if it is a spot server farm.
     */
    readonly spotExpirationTime?: pulumi.Input<string>;
    /**
     * Resource tags.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Scaling worker count.
     */
    readonly targetWorkerCount?: pulumi.Input<number>;
    /**
     * Scaling worker size ID.
     */
    readonly targetWorkerSizeId?: pulumi.Input<number>;
    /**
     * Target worker tier assigned to the App Service plan.
     */
    readonly workerTierName?: pulumi.Input<string>;
}
