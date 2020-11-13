// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * Information about managed application definition.
 */
export class ApplicationDefinition extends pulumi.CustomResource {
    /**
     * Get an existing ApplicationDefinition resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ApplicationDefinition {
        return new ApplicationDefinition(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:solutions/v20170901:ApplicationDefinition';

    /**
     * Returns true if the given object is an instance of ApplicationDefinition.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ApplicationDefinition {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ApplicationDefinition.__pulumiType;
    }

    /**
     * The collection of managed application artifacts. The portal will use the files specified as artifacts to construct the user experience of creating a managed application from a managed application definition.
     */
    public readonly artifacts!: pulumi.Output<outputs.solutions.v20170901.ApplicationArtifactResponse[] | undefined>;
    /**
     * The managed application provider authorizations.
     */
    public readonly authorizations!: pulumi.Output<outputs.solutions.v20170901.ApplicationProviderAuthorizationResponse[]>;
    /**
     * The createUiDefinition json for the backing template with Microsoft.Solutions/applications resource. It can be a JObject or well-formed JSON string.
     */
    public readonly createUiDefinition!: pulumi.Output<any | undefined>;
    /**
     * The managed application definition description.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * The managed application definition display name.
     */
    public readonly displayName!: pulumi.Output<string | undefined>;
    /**
     * The identity of the resource.
     */
    public readonly identity!: pulumi.Output<outputs.solutions.v20170901.IdentityResponse | undefined>;
    /**
     * A value indicating whether the package is enabled or not.
     */
    public readonly isEnabled!: pulumi.Output<string | undefined>;
    /**
     * Resource location
     */
    public readonly location!: pulumi.Output<string | undefined>;
    /**
     * The managed application lock level.
     */
    public readonly lockLevel!: pulumi.Output<string>;
    /**
     * The inline main template json which has resources to be provisioned. It can be a JObject or well-formed JSON string.
     */
    public readonly mainTemplate!: pulumi.Output<any | undefined>;
    /**
     * ID of the resource that manages this resource.
     */
    public readonly managedBy!: pulumi.Output<string | undefined>;
    /**
     * Resource name
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The managed application definition package file Uri. Use this element
     */
    public readonly packageFileUri!: pulumi.Output<string | undefined>;
    /**
     * The SKU of the resource.
     */
    public readonly sku!: pulumi.Output<outputs.solutions.v20170901.SkuResponse | undefined>;
    /**
     * Resource tags
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Resource type
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a ApplicationDefinition resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ApplicationDefinitionArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.applicationDefinitionName === undefined) {
                throw new Error("Missing required property 'applicationDefinitionName'");
            }
            if (!args || args.authorizations === undefined) {
                throw new Error("Missing required property 'authorizations'");
            }
            if (!args || args.lockLevel === undefined) {
                throw new Error("Missing required property 'lockLevel'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["applicationDefinitionName"] = args ? args.applicationDefinitionName : undefined;
            inputs["artifacts"] = args ? args.artifacts : undefined;
            inputs["authorizations"] = args ? args.authorizations : undefined;
            inputs["createUiDefinition"] = args ? args.createUiDefinition : undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["displayName"] = args ? args.displayName : undefined;
            inputs["identity"] = args ? args.identity : undefined;
            inputs["isEnabled"] = args ? args.isEnabled : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["lockLevel"] = args ? args.lockLevel : undefined;
            inputs["mainTemplate"] = args ? args.mainTemplate : undefined;
            inputs["managedBy"] = args ? args.managedBy : undefined;
            inputs["packageFileUri"] = args ? args.packageFileUri : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["sku"] = args ? args.sku : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["name"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["artifacts"] = undefined /*out*/;
            inputs["authorizations"] = undefined /*out*/;
            inputs["createUiDefinition"] = undefined /*out*/;
            inputs["description"] = undefined /*out*/;
            inputs["displayName"] = undefined /*out*/;
            inputs["identity"] = undefined /*out*/;
            inputs["isEnabled"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["lockLevel"] = undefined /*out*/;
            inputs["mainTemplate"] = undefined /*out*/;
            inputs["managedBy"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["packageFileUri"] = undefined /*out*/;
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
        const aliasOpts = { aliases: [{ type: "azure-nextgen:solutions/latest:ApplicationDefinition" }, { type: "azure-nextgen:solutions/v20180601:ApplicationDefinition" }, { type: "azure-nextgen:solutions/v20190701:ApplicationDefinition" }, { type: "azure-nextgen:solutions/v20200821preview:ApplicationDefinition" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(ApplicationDefinition.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a ApplicationDefinition resource.
 */
export interface ApplicationDefinitionArgs {
    /**
     * The name of the managed application definition.
     */
    readonly applicationDefinitionName: pulumi.Input<string>;
    /**
     * The collection of managed application artifacts. The portal will use the files specified as artifacts to construct the user experience of creating a managed application from a managed application definition.
     */
    readonly artifacts?: pulumi.Input<pulumi.Input<inputs.solutions.v20170901.ApplicationArtifact>[]>;
    /**
     * The managed application provider authorizations.
     */
    readonly authorizations: pulumi.Input<pulumi.Input<inputs.solutions.v20170901.ApplicationProviderAuthorization>[]>;
    /**
     * The createUiDefinition json for the backing template with Microsoft.Solutions/applications resource. It can be a JObject or well-formed JSON string.
     */
    readonly createUiDefinition?: any;
    /**
     * The managed application definition description.
     */
    readonly description?: pulumi.Input<string>;
    /**
     * The managed application definition display name.
     */
    readonly displayName?: pulumi.Input<string>;
    /**
     * The identity of the resource.
     */
    readonly identity?: pulumi.Input<inputs.solutions.v20170901.Identity>;
    /**
     * A value indicating whether the package is enabled or not.
     */
    readonly isEnabled?: pulumi.Input<string>;
    /**
     * Resource location
     */
    readonly location?: pulumi.Input<string>;
    /**
     * The managed application lock level.
     */
    readonly lockLevel: pulumi.Input<string>;
    /**
     * The inline main template json which has resources to be provisioned. It can be a JObject or well-formed JSON string.
     */
    readonly mainTemplate?: any;
    /**
     * ID of the resource that manages this resource.
     */
    readonly managedBy?: pulumi.Input<string>;
    /**
     * The managed application definition package file Uri. Use this element
     */
    readonly packageFileUri?: pulumi.Input<string>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The SKU of the resource.
     */
    readonly sku?: pulumi.Input<inputs.solutions.v20170901.Sku>;
    /**
     * Resource tags
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}
