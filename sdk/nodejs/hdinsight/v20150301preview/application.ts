// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * The HDInsight cluster application
 */
export class Application extends pulumi.CustomResource {
    /**
     * Get an existing Application resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Application {
        return new Application(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:hdinsight/v20150301preview:Application';

    /**
     * Returns true if the given object is an instance of Application.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Application {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Application.__pulumiType;
    }

    /**
     * The ETag for the application
     */
    public readonly etag!: pulumi.Output<string | undefined>;
    /**
     * The name of the resource
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The properties of the application.
     */
    public readonly properties!: pulumi.Output<outputs.hdinsight.v20150301preview.ApplicationPropertiesResponse>;
    /**
     * The tags for the application.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * The type of the resource.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a Application resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ApplicationArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.applicationName === undefined) {
                throw new Error("Missing required property 'applicationName'");
            }
            if (!args || args.clusterName === undefined) {
                throw new Error("Missing required property 'clusterName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["applicationName"] = args ? args.applicationName : undefined;
            inputs["clusterName"] = args ? args.clusterName : undefined;
            inputs["etag"] = args ? args.etag : undefined;
            inputs["properties"] = args ? args.properties : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["name"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["etag"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["properties"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:hdinsight/v20180601preview:Application" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(Application.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Application resource.
 */
export interface ApplicationArgs {
    /**
     * The constant value for the application name.
     */
    readonly applicationName: pulumi.Input<string>;
    /**
     * The name of the cluster.
     */
    readonly clusterName: pulumi.Input<string>;
    /**
     * The ETag for the application
     */
    readonly etag?: pulumi.Input<string>;
    /**
     * The properties of the application.
     */
    readonly properties?: pulumi.Input<inputs.hdinsight.v20150301preview.ApplicationProperties>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The tags for the application.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}
