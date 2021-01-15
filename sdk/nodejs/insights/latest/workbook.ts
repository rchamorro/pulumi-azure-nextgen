// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * An Application Insights workbook definition.
 * Latest API Version: 2020-10-20.
 */
export class Workbook extends pulumi.CustomResource {
    /**
     * Get an existing Workbook resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Workbook {
        return new Workbook(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:insights/latest:Workbook';

    /**
     * Returns true if the given object is an instance of Workbook.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Workbook {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Workbook.__pulumiType;
    }

    /**
     * Workbook category, as defined by the user at creation time.
     */
    public readonly category!: pulumi.Output<string>;
    /**
     * The user-defined name (display name) of the workbook.
     */
    public readonly displayName!: pulumi.Output<string>;
    /**
     * Resource etag
     */
    public readonly etag!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Identity used for BYOS
     */
    public readonly identity!: pulumi.Output<outputs.insights.latest.ManagedIdentityResponse | undefined>;
    /**
     * The kind of workbook. Choices are user and shared.
     */
    public readonly kind!: pulumi.Output<string | undefined>;
    /**
     * Resource location
     */
    public readonly location!: pulumi.Output<string | undefined>;
    /**
     * Azure resource name
     */
    public readonly name!: pulumi.Output<string | undefined>;
    /**
     * Configuration of this particular workbook. Configuration data is a string containing valid JSON
     */
    public readonly serializedData!: pulumi.Output<string>;
    /**
     * ResourceId for a source resource.
     */
    public readonly sourceId!: pulumi.Output<string | undefined>;
    /**
     * BYOS Storage Account URI
     */
    public readonly storageUri!: pulumi.Output<string | undefined>;
    /**
     * Resource tags
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Date and time in UTC of the last modification that was made to this workbook definition.
     */
    public /*out*/ readonly timeModified!: pulumi.Output<string>;
    /**
     * Azure resource type
     */
    public readonly type!: pulumi.Output<string | undefined>;
    /**
     * Unique user id of the specific user that owns this workbook.
     */
    public /*out*/ readonly userId!: pulumi.Output<string>;
    /**
     * Workbook version
     */
    public readonly version!: pulumi.Output<string | undefined>;

    /**
     * Create a Workbook resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: WorkbookArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.category === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'category'");
            }
            if ((!args || args.displayName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'displayName'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if ((!args || args.resourceName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceName'");
            }
            if ((!args || args.serializedData === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'serializedData'");
            }
            inputs["category"] = args ? args.category : undefined;
            inputs["displayName"] = args ? args.displayName : undefined;
            inputs["etag"] = args ? args.etag : undefined;
            inputs["id"] = args ? args.id : undefined;
            inputs["identity"] = args ? args.identity : undefined;
            inputs["kind"] = args ? args.kind : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["resourceName"] = args ? args.resourceName : undefined;
            inputs["serializedData"] = args ? args.serializedData : undefined;
            inputs["sourceId"] = args ? args.sourceId : undefined;
            inputs["storageUri"] = args ? args.storageUri : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["type"] = args ? args.type : undefined;
            inputs["version"] = args ? args.version : undefined;
            inputs["timeModified"] = undefined /*out*/;
            inputs["userId"] = undefined /*out*/;
        } else {
            inputs["category"] = undefined /*out*/;
            inputs["displayName"] = undefined /*out*/;
            inputs["etag"] = undefined /*out*/;
            inputs["identity"] = undefined /*out*/;
            inputs["kind"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["serializedData"] = undefined /*out*/;
            inputs["sourceId"] = undefined /*out*/;
            inputs["storageUri"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["timeModified"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["userId"] = undefined /*out*/;
            inputs["version"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:insights/v20150501:Workbook" }, { type: "azure-nextgen:insights/v20180617preview:Workbook" }, { type: "azure-nextgen:insights/v20201020:Workbook" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(Workbook.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Workbook resource.
 */
export interface WorkbookArgs {
    /**
     * Workbook category, as defined by the user at creation time.
     */
    readonly category: pulumi.Input<string>;
    /**
     * The user-defined name (display name) of the workbook.
     */
    readonly displayName: pulumi.Input<string>;
    /**
     * Resource etag
     */
    readonly etag?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Azure resource Id
     */
    readonly id?: pulumi.Input<string>;
    /**
     * Identity used for BYOS
     */
    readonly identity?: pulumi.Input<inputs.insights.latest.ManagedIdentity>;
    /**
     * The kind of workbook. Choices are user and shared.
     */
    readonly kind?: pulumi.Input<string | enums.insights.latest.Kind>;
    /**
     * Resource location
     */
    readonly location?: pulumi.Input<string>;
    /**
     * Azure resource name
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the Application Insights component resource.
     */
    readonly resourceName: pulumi.Input<string>;
    /**
     * Configuration of this particular workbook. Configuration data is a string containing valid JSON
     */
    readonly serializedData: pulumi.Input<string>;
    /**
     * ResourceId for a source resource.
     */
    readonly sourceId?: pulumi.Input<string>;
    /**
     * BYOS Storage Account URI
     */
    readonly storageUri?: pulumi.Input<string>;
    /**
     * Resource tags
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Azure resource type
     */
    readonly type?: pulumi.Input<string>;
    /**
     * Workbook version
     */
    readonly version?: pulumi.Input<string>;
}
