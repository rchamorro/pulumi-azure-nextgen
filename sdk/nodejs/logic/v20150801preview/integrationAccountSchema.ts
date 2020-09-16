// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export class IntegrationAccountSchema extends pulumi.CustomResource {
    /**
     * Get an existing IntegrationAccountSchema resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): IntegrationAccountSchema {
        return new IntegrationAccountSchema(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:logic/v20150801preview:IntegrationAccountSchema';

    /**
     * Returns true if the given object is an instance of IntegrationAccountSchema.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is IntegrationAccountSchema {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === IntegrationAccountSchema.__pulumiType;
    }

    /**
     * The changed time.
     */
    public /*out*/ readonly changedTime!: pulumi.Output<string>;
    /**
     * The content.
     */
    public readonly content!: pulumi.Output<{[key: string]: any} | undefined>;
    /**
     * The content link.
     */
    public /*out*/ readonly contentLink!: pulumi.Output<outputs.logic.v20150801preview.IntegrationAccountContentLinkResponse>;
    /**
     * The content type.
     */
    public readonly contentType!: pulumi.Output<string | undefined>;
    /**
     * The created time.
     */
    public /*out*/ readonly createdTime!: pulumi.Output<string>;
    /**
     * The resource location.
     */
    public readonly location!: pulumi.Output<string | undefined>;
    /**
     * The metadata.
     */
    public readonly metadata!: pulumi.Output<{[key: string]: any} | undefined>;
    /**
     * The resource name.
     */
    public readonly name!: pulumi.Output<string | undefined>;
    /**
     * The schema type.
     */
    public readonly schemaType!: pulumi.Output<string | undefined>;
    /**
     * The resource tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * The target namespace.
     */
    public readonly targetNamespace!: pulumi.Output<string | undefined>;
    /**
     * The resource type.
     */
    public readonly type!: pulumi.Output<string | undefined>;

    /**
     * Create a IntegrationAccountSchema resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: IntegrationAccountSchemaArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.integrationAccountName === undefined) {
                throw new Error("Missing required property 'integrationAccountName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.schemaName === undefined) {
                throw new Error("Missing required property 'schemaName'");
            }
            inputs["content"] = args ? args.content : undefined;
            inputs["contentType"] = args ? args.contentType : undefined;
            inputs["id"] = args ? args.id : undefined;
            inputs["integrationAccountName"] = args ? args.integrationAccountName : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["metadata"] = args ? args.metadata : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["schemaName"] = args ? args.schemaName : undefined;
            inputs["schemaType"] = args ? args.schemaType : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["targetNamespace"] = args ? args.targetNamespace : undefined;
            inputs["type"] = args ? args.type : undefined;
            inputs["changedTime"] = undefined /*out*/;
            inputs["contentLink"] = undefined /*out*/;
            inputs["createdTime"] = undefined /*out*/;
        } else {
            inputs["changedTime"] = undefined /*out*/;
            inputs["content"] = undefined /*out*/;
            inputs["contentLink"] = undefined /*out*/;
            inputs["contentType"] = undefined /*out*/;
            inputs["createdTime"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["metadata"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["schemaType"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["targetNamespace"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:logic/latest:IntegrationAccountSchema" }, { type: "azure-nextgen:logic/v20160601:IntegrationAccountSchema" }, { type: "azure-nextgen:logic/v20180701preview:IntegrationAccountSchema" }, { type: "azure-nextgen:logic/v20190501:IntegrationAccountSchema" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(IntegrationAccountSchema.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a IntegrationAccountSchema resource.
 */
export interface IntegrationAccountSchemaArgs {
    /**
     * The content.
     */
    readonly content?: pulumi.Input<{[key: string]: any}>;
    /**
     * The content type.
     */
    readonly contentType?: pulumi.Input<string>;
    /**
     * The resource id.
     */
    readonly id?: pulumi.Input<string>;
    /**
     * The integration account name.
     */
    readonly integrationAccountName: pulumi.Input<string>;
    /**
     * The resource location.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * The metadata.
     */
    readonly metadata?: pulumi.Input<{[key: string]: any}>;
    /**
     * The resource name.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The resource group name.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The integration account schema name.
     */
    readonly schemaName: pulumi.Input<string>;
    /**
     * The schema type.
     */
    readonly schemaType?: pulumi.Input<string>;
    /**
     * The resource tags.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The target namespace.
     */
    readonly targetNamespace?: pulumi.Input<string>;
    /**
     * The resource type.
     */
    readonly type?: pulumi.Input<string>;
}