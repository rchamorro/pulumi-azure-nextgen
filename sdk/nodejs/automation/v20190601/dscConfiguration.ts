// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Definition of the configuration type.
 */
export class DscConfiguration extends pulumi.CustomResource {
    /**
     * Get an existing DscConfiguration resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): DscConfiguration {
        return new DscConfiguration(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:automation/v20190601:DscConfiguration';

    /**
     * Returns true if the given object is an instance of DscConfiguration.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is DscConfiguration {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === DscConfiguration.__pulumiType;
    }

    /**
     * Gets or sets the creation time.
     */
    public /*out*/ readonly creationTime!: pulumi.Output<string | undefined>;
    /**
     * Gets or sets the description.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * Gets or sets the etag of the resource.
     */
    public /*out*/ readonly etag!: pulumi.Output<string | undefined>;
    /**
     * Gets or sets the job count of the configuration.
     */
    public /*out*/ readonly jobCount!: pulumi.Output<number | undefined>;
    /**
     * Gets or sets the last modified time.
     */
    public /*out*/ readonly lastModifiedTime!: pulumi.Output<string | undefined>;
    /**
     * The Azure Region where the resource lives
     */
    public readonly location!: pulumi.Output<string | undefined>;
    /**
     * Gets or sets verbose log option.
     */
    public readonly logVerbose!: pulumi.Output<boolean | undefined>;
    /**
     * The name of the resource
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Gets the number of compiled node configurations.
     */
    public /*out*/ readonly nodeConfigurationCount!: pulumi.Output<number | undefined>;
    /**
     * Gets or sets the configuration parameters.
     */
    public readonly parameters!: pulumi.Output<{[key: string]: outputs.automation.v20190601.DscConfigurationParameterResponse} | undefined>;
    /**
     * Gets or sets the provisioning state of the configuration.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string | undefined>;
    /**
     * Gets or sets the source.
     */
    public readonly source!: pulumi.Output<outputs.automation.v20190601.ContentSourceResponse | undefined>;
    /**
     * Gets or sets the state of the configuration.
     */
    public /*out*/ readonly state!: pulumi.Output<string | undefined>;
    /**
     * Resource tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * The type of the resource.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a DscConfiguration resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: DscConfigurationArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.automationAccountName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'automationAccountName'");
            }
            if ((!args || args.configurationName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'configurationName'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if ((!args || args.source === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'source'");
            }
            inputs["automationAccountName"] = args ? args.automationAccountName : undefined;
            inputs["configurationName"] = args ? args.configurationName : undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["logProgress"] = args ? args.logProgress : undefined;
            inputs["logVerbose"] = args ? args.logVerbose : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["parameters"] = args ? args.parameters : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["source"] = args ? args.source : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["creationTime"] = undefined /*out*/;
            inputs["etag"] = undefined /*out*/;
            inputs["jobCount"] = undefined /*out*/;
            inputs["lastModifiedTime"] = undefined /*out*/;
            inputs["nodeConfigurationCount"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["state"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["creationTime"] = undefined /*out*/;
            inputs["description"] = undefined /*out*/;
            inputs["etag"] = undefined /*out*/;
            inputs["jobCount"] = undefined /*out*/;
            inputs["lastModifiedTime"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["logVerbose"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["nodeConfigurationCount"] = undefined /*out*/;
            inputs["parameters"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["source"] = undefined /*out*/;
            inputs["state"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:automation/latest:DscConfiguration" }, { type: "azure-nextgen:automation/v20151031:DscConfiguration" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(DscConfiguration.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a DscConfiguration resource.
 */
export interface DscConfigurationArgs {
    /**
     * The name of the automation account.
     */
    readonly automationAccountName: pulumi.Input<string>;
    /**
     * The create or update parameters for configuration.
     */
    readonly configurationName: pulumi.Input<string>;
    /**
     * Gets or sets the description of the configuration.
     */
    readonly description?: pulumi.Input<string>;
    /**
     * Gets or sets the location of the resource.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * Gets or sets progress log option.
     */
    readonly logProgress?: pulumi.Input<boolean>;
    /**
     * Gets or sets verbose log option.
     */
    readonly logVerbose?: pulumi.Input<boolean>;
    /**
     * Gets or sets name of the resource.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Gets or sets the configuration parameters.
     */
    readonly parameters?: pulumi.Input<{[key: string]: pulumi.Input<inputs.automation.v20190601.DscConfigurationParameter>}>;
    /**
     * Name of an Azure Resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Gets or sets the source.
     */
    readonly source: pulumi.Input<inputs.automation.v20190601.ContentSource>;
    /**
     * Gets or sets the tags attached to the resource.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}
