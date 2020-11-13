// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * Resource information.
 */
export class Resource extends pulumi.CustomResource {
    /**
     * Get an existing Resource resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Resource {
        return new Resource(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:resources/v20191001:Resource';

    /**
     * Returns true if the given object is an instance of Resource.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Resource {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Resource.__pulumiType;
    }

    /**
     * The identity of the resource.
     */
    public readonly identity!: pulumi.Output<outputs.resources.v20191001.IdentityResponse | undefined>;
    /**
     * The kind of the resource.
     */
    public readonly kind!: pulumi.Output<string | undefined>;
    /**
     * Resource location
     */
    public readonly location!: pulumi.Output<string | undefined>;
    /**
     * ID of the resource that manages this resource.
     */
    public readonly managedBy!: pulumi.Output<string | undefined>;
    /**
     * Resource name
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The plan of the resource.
     */
    public readonly plan!: pulumi.Output<outputs.resources.v20191001.PlanResponse | undefined>;
    /**
     * The resource properties.
     */
    public readonly properties!: pulumi.Output<any>;
    /**
     * The SKU of the resource.
     */
    public readonly sku!: pulumi.Output<outputs.resources.v20191001.SkuResponse | undefined>;
    /**
     * Resource tags
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Resource type
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a Resource resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ResourceArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.parentResourcePath === undefined) {
                throw new Error("Missing required property 'parentResourcePath'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.resourceName === undefined) {
                throw new Error("Missing required property 'resourceName'");
            }
            if (!args || args.resourceProviderNamespace === undefined) {
                throw new Error("Missing required property 'resourceProviderNamespace'");
            }
            if (!args || args.resourceType === undefined) {
                throw new Error("Missing required property 'resourceType'");
            }
            inputs["identity"] = args ? args.identity : undefined;
            inputs["kind"] = args ? args.kind : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["managedBy"] = args ? args.managedBy : undefined;
            inputs["parentResourcePath"] = args ? args.parentResourcePath : undefined;
            inputs["plan"] = args ? args.plan : undefined;
            inputs["properties"] = args ? args.properties : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["resourceName"] = args ? args.resourceName : undefined;
            inputs["resourceProviderNamespace"] = args ? args.resourceProviderNamespace : undefined;
            inputs["resourceType"] = args ? args.resourceType : undefined;
            inputs["sku"] = args ? args.sku : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["name"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["identity"] = undefined /*out*/;
            inputs["kind"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["managedBy"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["plan"] = undefined /*out*/;
            inputs["properties"] = undefined /*out*/;
            inputs["sku"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:resources/latest:Resource" }, { type: "azure-nextgen:resources/v20151101:Resource" }, { type: "azure-nextgen:resources/v20160201:Resource" }, { type: "azure-nextgen:resources/v20160701:Resource" }, { type: "azure-nextgen:resources/v20160901:Resource" }, { type: "azure-nextgen:resources/v20170510:Resource" }, { type: "azure-nextgen:resources/v20180201:Resource" }, { type: "azure-nextgen:resources/v20180501:Resource" }, { type: "azure-nextgen:resources/v20190301:Resource" }, { type: "azure-nextgen:resources/v20190501:Resource" }, { type: "azure-nextgen:resources/v20190510:Resource" }, { type: "azure-nextgen:resources/v20190701:Resource" }, { type: "azure-nextgen:resources/v20190801:Resource" }, { type: "azure-nextgen:resources/v20200601:Resource" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(Resource.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Resource resource.
 */
export interface ResourceArgs {
    /**
     * The identity of the resource.
     */
    readonly identity?: pulumi.Input<inputs.resources.v20191001.Identity>;
    /**
     * The kind of the resource.
     */
    readonly kind?: pulumi.Input<string>;
    /**
     * Resource location
     */
    readonly location?: pulumi.Input<string>;
    /**
     * ID of the resource that manages this resource.
     */
    readonly managedBy?: pulumi.Input<string>;
    /**
     * The parent resource identity.
     */
    readonly parentResourcePath: pulumi.Input<string>;
    /**
     * The plan of the resource.
     */
    readonly plan?: pulumi.Input<inputs.resources.v20191001.Plan>;
    /**
     * The resource properties.
     */
    readonly properties?: any;
    /**
     * The name of the resource group for the resource. The name is case insensitive.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the resource to create.
     */
    readonly resourceName: pulumi.Input<string>;
    /**
     * The namespace of the resource provider.
     */
    readonly resourceProviderNamespace: pulumi.Input<string>;
    /**
     * The resource type of the resource to create.
     */
    readonly resourceType: pulumi.Input<string>;
    /**
     * The SKU of the resource.
     */
    readonly sku?: pulumi.Input<inputs.resources.v20191001.Sku>;
    /**
     * Resource tags
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}
