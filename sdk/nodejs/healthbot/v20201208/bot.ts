// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * HealthBot resource definition
 */
export class Bot extends pulumi.CustomResource {
    /**
     * Get an existing Bot resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Bot {
        return new Bot(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:healthbot/v20201208:Bot';

    /**
     * Returns true if the given object is an instance of Bot.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Bot {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Bot.__pulumiType;
    }

    /**
     * The geo-location where the resource lives
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * The name of the resource
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The set of properties specific to Healthbot resource.
     */
    public /*out*/ readonly properties!: pulumi.Output<outputs.healthbot.v20201208.HealthBotPropertiesResponse>;
    /**
     * SKU of the HealthBot.
     */
    public readonly sku!: pulumi.Output<outputs.healthbot.v20201208.SkuResponse>;
    /**
     * Metadata pertaining to creation and last modification of the resource
     */
    public /*out*/ readonly systemData!: pulumi.Output<outputs.healthbot.v20201208.SystemDataResponse>;
    /**
     * Resource tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * The type of the resource.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a Bot resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: BotArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.botName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'botName'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if ((!args || args.sku === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'sku'");
            }
            inputs["botName"] = args ? args.botName : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["sku"] = args ? args.sku : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["name"] = undefined /*out*/;
            inputs["properties"] = undefined /*out*/;
            inputs["systemData"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["properties"] = undefined /*out*/;
            inputs["sku"] = undefined /*out*/;
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
        const aliasOpts = { aliases: [{ type: "azure-nextgen:healthbot/latest:Bot" }, { type: "azure-nextgen:healthbot/v20201020:Bot" }, { type: "azure-nextgen:healthbot/v20201020preview:Bot" }, { type: "azure-nextgen:healthbot/v20201208preview:Bot" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(Bot.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Bot resource.
 */
export interface BotArgs {
    /**
     * The name of the Bot resource.
     */
    readonly botName: pulumi.Input<string>;
    /**
     * The geo-location where the resource lives
     */
    readonly location?: pulumi.Input<string>;
    /**
     * The name of the Bot resource group in the user subscription.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * SKU of the HealthBot.
     */
    readonly sku: pulumi.Input<inputs.healthbot.v20201208.Sku>;
    /**
     * Resource tags.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}
