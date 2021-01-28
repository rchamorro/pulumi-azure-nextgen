// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * A sql pool resource.
 */
export class SqlPoolsV3 extends pulumi.CustomResource {
    /**
     * Get an existing SqlPoolsV3 resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): SqlPoolsV3 {
        return new SqlPoolsV3(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:synapse/v20200401preview:SqlPoolsV3';

    /**
     * Returns true if the given object is an instance of SqlPoolsV3.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is SqlPoolsV3 {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === SqlPoolsV3.__pulumiType;
    }

    /**
     * The current service level objective name of the sql pool.
     */
    public /*out*/ readonly currentServiceObjectiveName!: pulumi.Output<string>;
    /**
     * Kind of SqlPool.
     */
    public /*out*/ readonly kind!: pulumi.Output<string>;
    /**
     * The geo-location where the resource lives
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * The name of the resource
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The requested service level objective name of the sql pool.
     */
    public /*out*/ readonly requestedServiceObjectiveName!: pulumi.Output<string>;
    /**
     * The sql pool SKU. The list of SKUs may vary by region and support offer.
     */
    public readonly sku!: pulumi.Output<outputs.synapse.v20200401preview.SkuResponse | undefined>;
    /**
     * The Guid of the sql pool.
     */
    public /*out*/ readonly sqlPoolGuid!: pulumi.Output<string>;
    /**
     * The status of the sql pool.
     */
    public /*out*/ readonly status!: pulumi.Output<string>;
    /**
     * SystemData of SqlPool.
     */
    public /*out*/ readonly systemData!: pulumi.Output<outputs.synapse.v20200401preview.SystemDataResponse>;
    /**
     * Resource tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a SqlPoolsV3 resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: SqlPoolsV3Args, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.location === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'location'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if ((!args || args.sqlPoolName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'sqlPoolName'");
            }
            if ((!args || args.workspaceName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'workspaceName'");
            }
            inputs["location"] = args ? args.location : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["sku"] = args ? args.sku : undefined;
            inputs["sqlPoolName"] = args ? args.sqlPoolName : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["workspaceName"] = args ? args.workspaceName : undefined;
            inputs["currentServiceObjectiveName"] = undefined /*out*/;
            inputs["kind"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["requestedServiceObjectiveName"] = undefined /*out*/;
            inputs["sqlPoolGuid"] = undefined /*out*/;
            inputs["status"] = undefined /*out*/;
            inputs["systemData"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["currentServiceObjectiveName"] = undefined /*out*/;
            inputs["kind"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["requestedServiceObjectiveName"] = undefined /*out*/;
            inputs["sku"] = undefined /*out*/;
            inputs["sqlPoolGuid"] = undefined /*out*/;
            inputs["status"] = undefined /*out*/;
            inputs["systemData"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:synapse/v20190601preview:SqlPoolsV3" }, { type: "azure-nextgen:synapse/v20201201:SqlPoolsV3" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(SqlPoolsV3.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a SqlPoolsV3 resource.
 */
export interface SqlPoolsV3Args {
    /**
     * The geo-location where the resource lives
     */
    readonly location: pulumi.Input<string>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The sql pool SKU. The list of SKUs may vary by region and support offer.
     */
    readonly sku?: pulumi.Input<inputs.synapse.v20200401preview.Sku>;
    /**
     * The name of the sql pool.
     */
    readonly sqlPoolName: pulumi.Input<string>;
    /**
     * Resource tags.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The name of the workspace.
     */
    readonly workspaceName: pulumi.Input<string>;
}
