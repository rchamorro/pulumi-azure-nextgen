// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Registration information.
 * Latest API Version: 2017-06-01.
 */
export class Registration extends pulumi.CustomResource {
    /**
     * Get an existing Registration resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Registration {
        return new Registration(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:azurestack/latest:Registration';

    /**
     * Returns true if the given object is an instance of Registration.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Registration {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Registration.__pulumiType;
    }

    /**
     * Specifies the billing mode for the Azure Stack registration.
     */
    public /*out*/ readonly billingModel!: pulumi.Output<string | undefined>;
    /**
     * The identifier of the registered Azure Stack.
     */
    public /*out*/ readonly cloudId!: pulumi.Output<string | undefined>;
    /**
     * The entity tag used for optimistic concurrency when modifying the resource.
     */
    public /*out*/ readonly etag!: pulumi.Output<string | undefined>;
    /**
     * Location of the resource.
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * Name of the resource.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The object identifier associated with the Azure Stack connecting to Azure.
     */
    public /*out*/ readonly objectId!: pulumi.Output<string | undefined>;
    /**
     * Custom tags for the resource.
     */
    public /*out*/ readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Type of Resource.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a Registration resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: RegistrationArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.registrationName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'registrationName'");
            }
            if ((!args || args.registrationToken === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'registrationToken'");
            }
            if ((!args || args.resourceGroup === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroup'");
            }
            inputs["location"] = args ? args.location : undefined;
            inputs["registrationName"] = args ? args.registrationName : undefined;
            inputs["registrationToken"] = args ? args.registrationToken : undefined;
            inputs["resourceGroup"] = args ? args.resourceGroup : undefined;
            inputs["billingModel"] = undefined /*out*/;
            inputs["cloudId"] = undefined /*out*/;
            inputs["etag"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["objectId"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["billingModel"] = undefined /*out*/;
            inputs["cloudId"] = undefined /*out*/;
            inputs["etag"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["objectId"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:azurestack/v20170601:Registration" }, { type: "azure-nextgen:azurestack/v20200601preview:Registration" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(Registration.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Registration resource.
 */
export interface RegistrationArgs {
    /**
     * Location of the resource.
     */
    readonly location?: pulumi.Input<string | enums.azurestack.latest.Location>;
    /**
     * Name of the Azure Stack registration.
     */
    readonly registrationName: pulumi.Input<string>;
    /**
     * The token identifying registered Azure Stack
     */
    readonly registrationToken: pulumi.Input<string>;
    /**
     * Name of the resource group.
     */
    readonly resourceGroup: pulumi.Input<string>;
}
