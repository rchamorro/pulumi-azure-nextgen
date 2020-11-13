// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * The StreamingEndpoint.
 */
export class StreamingEndpoint extends pulumi.CustomResource {
    /**
     * Get an existing StreamingEndpoint resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): StreamingEndpoint {
        return new StreamingEndpoint(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:media/v20180701:StreamingEndpoint';

    /**
     * Returns true if the given object is an instance of StreamingEndpoint.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is StreamingEndpoint {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === StreamingEndpoint.__pulumiType;
    }

    /**
     * The access control definition of the StreamingEndpoint.
     */
    public readonly accessControl!: pulumi.Output<outputs.media.v20180701.StreamingEndpointAccessControlResponse | undefined>;
    /**
     * The name of the AvailabilitySet used with this StreamingEndpoint for high availability streaming.  This value can only be set at creation time.
     */
    public readonly availabilitySetName!: pulumi.Output<string | undefined>;
    /**
     * The CDN enabled flag.
     */
    public readonly cdnEnabled!: pulumi.Output<boolean | undefined>;
    /**
     * The CDN profile name.
     */
    public readonly cdnProfile!: pulumi.Output<string | undefined>;
    /**
     * The CDN provider name.
     */
    public readonly cdnProvider!: pulumi.Output<string | undefined>;
    /**
     * The exact time the StreamingEndpoint was created.
     */
    public /*out*/ readonly created!: pulumi.Output<string>;
    /**
     * The StreamingEndpoint access policies.
     */
    public readonly crossSiteAccessPolicies!: pulumi.Output<outputs.media.v20180701.CrossSiteAccessPoliciesResponse | undefined>;
    /**
     * The custom host names of the StreamingEndpoint
     */
    public readonly customHostNames!: pulumi.Output<string[] | undefined>;
    /**
     * The StreamingEndpoint description.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * The free trial expiration time.
     */
    public /*out*/ readonly freeTrialEndTime!: pulumi.Output<string>;
    /**
     * The StreamingEndpoint host name.
     */
    public /*out*/ readonly hostName!: pulumi.Output<string>;
    /**
     * The exact time the StreamingEndpoint was last modified.
     */
    public /*out*/ readonly lastModified!: pulumi.Output<string>;
    /**
     * The Azure Region of the resource.
     */
    public readonly location!: pulumi.Output<string | undefined>;
    /**
     * Max cache age
     */
    public readonly maxCacheAge!: pulumi.Output<number | undefined>;
    /**
     * The name of the resource.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The provisioning state of the StreamingEndpoint.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * The resource state of the StreamingEndpoint.
     */
    public /*out*/ readonly resourceState!: pulumi.Output<string>;
    /**
     * The number of scale units.  Use the Scale operation to adjust this value.
     */
    public readonly scaleUnits!: pulumi.Output<number>;
    /**
     * Resource tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * The type of the resource.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a StreamingEndpoint resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: StreamingEndpointArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.accountName === undefined) {
                throw new Error("Missing required property 'accountName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.scaleUnits === undefined) {
                throw new Error("Missing required property 'scaleUnits'");
            }
            if (!args || args.streamingEndpointName === undefined) {
                throw new Error("Missing required property 'streamingEndpointName'");
            }
            inputs["accessControl"] = args ? args.accessControl : undefined;
            inputs["accountName"] = args ? args.accountName : undefined;
            inputs["autoStart"] = args ? args.autoStart : undefined;
            inputs["availabilitySetName"] = args ? args.availabilitySetName : undefined;
            inputs["cdnEnabled"] = args ? args.cdnEnabled : undefined;
            inputs["cdnProfile"] = args ? args.cdnProfile : undefined;
            inputs["cdnProvider"] = args ? args.cdnProvider : undefined;
            inputs["crossSiteAccessPolicies"] = args ? args.crossSiteAccessPolicies : undefined;
            inputs["customHostNames"] = args ? args.customHostNames : undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["maxCacheAge"] = args ? args.maxCacheAge : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["scaleUnits"] = args ? args.scaleUnits : undefined;
            inputs["streamingEndpointName"] = args ? args.streamingEndpointName : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["created"] = undefined /*out*/;
            inputs["freeTrialEndTime"] = undefined /*out*/;
            inputs["hostName"] = undefined /*out*/;
            inputs["lastModified"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["resourceState"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["accessControl"] = undefined /*out*/;
            inputs["availabilitySetName"] = undefined /*out*/;
            inputs["cdnEnabled"] = undefined /*out*/;
            inputs["cdnProfile"] = undefined /*out*/;
            inputs["cdnProvider"] = undefined /*out*/;
            inputs["created"] = undefined /*out*/;
            inputs["crossSiteAccessPolicies"] = undefined /*out*/;
            inputs["customHostNames"] = undefined /*out*/;
            inputs["description"] = undefined /*out*/;
            inputs["freeTrialEndTime"] = undefined /*out*/;
            inputs["hostName"] = undefined /*out*/;
            inputs["lastModified"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["maxCacheAge"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["resourceState"] = undefined /*out*/;
            inputs["scaleUnits"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:media/latest:StreamingEndpoint" }, { type: "azure-nextgen:media/v20180330preview:StreamingEndpoint" }, { type: "azure-nextgen:media/v20180601preview:StreamingEndpoint" }, { type: "azure-nextgen:media/v20190501preview:StreamingEndpoint" }, { type: "azure-nextgen:media/v20200501:StreamingEndpoint" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(StreamingEndpoint.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a StreamingEndpoint resource.
 */
export interface StreamingEndpointArgs {
    /**
     * The access control definition of the StreamingEndpoint.
     */
    readonly accessControl?: pulumi.Input<inputs.media.v20180701.StreamingEndpointAccessControl>;
    /**
     * The Media Services account name.
     */
    readonly accountName: pulumi.Input<string>;
    /**
     * The flag indicates if the resource should be automatically started on creation.
     */
    readonly autoStart?: pulumi.Input<boolean>;
    /**
     * The name of the AvailabilitySet used with this StreamingEndpoint for high availability streaming.  This value can only be set at creation time.
     */
    readonly availabilitySetName?: pulumi.Input<string>;
    /**
     * The CDN enabled flag.
     */
    readonly cdnEnabled?: pulumi.Input<boolean>;
    /**
     * The CDN profile name.
     */
    readonly cdnProfile?: pulumi.Input<string>;
    /**
     * The CDN provider name.
     */
    readonly cdnProvider?: pulumi.Input<string>;
    /**
     * The StreamingEndpoint access policies.
     */
    readonly crossSiteAccessPolicies?: pulumi.Input<inputs.media.v20180701.CrossSiteAccessPolicies>;
    /**
     * The custom host names of the StreamingEndpoint
     */
    readonly customHostNames?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The StreamingEndpoint description.
     */
    readonly description?: pulumi.Input<string>;
    /**
     * The Azure Region of the resource.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * Max cache age
     */
    readonly maxCacheAge?: pulumi.Input<number>;
    /**
     * The name of the resource group within the Azure subscription.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The number of scale units.  Use the Scale operation to adjust this value.
     */
    readonly scaleUnits: pulumi.Input<number>;
    /**
     * The name of the StreamingEndpoint.
     */
    readonly streamingEndpointName: pulumi.Input<string>;
    /**
     * Resource tags.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}
