// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Confidential Ledger. Contains the properties of Confidential Ledger Resource.
 */
export class Ledger extends pulumi.CustomResource {
    /**
     * Get an existing Ledger resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Ledger {
        return new Ledger(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:confidentialledger/v20201201preview:Ledger';

    /**
     * Returns true if the given object is an instance of Ledger.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Ledger {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Ledger.__pulumiType;
    }

    /**
     * The Azure location where the Confidential Ledger is running.
     */
    public readonly location!: pulumi.Output<string | undefined>;
    /**
     * Name of the Resource.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Properties of Confidential Ledger Resource.
     */
    public readonly properties!: pulumi.Output<outputs.confidentialledger.v20201201preview.LedgerPropertiesResponse>;
    /**
     * Metadata pertaining to creation and last modification of the resource
     */
    public /*out*/ readonly systemData!: pulumi.Output<outputs.confidentialledger.v20201201preview.SystemDataResponse>;
    /**
     * Additional tags for Confidential Ledger
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * The type of the resource.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a Ledger resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: LedgerArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.ledgerName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'ledgerName'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["ledgerName"] = args ? args.ledgerName : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["properties"] = args ? args.properties : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["name"] = undefined /*out*/;
            inputs["systemData"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["properties"] = undefined /*out*/;
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
        super(Ledger.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Ledger resource.
 */
export interface LedgerArgs {
    /**
     * Name of the Confidential Ledger
     */
    readonly ledgerName: pulumi.Input<string>;
    /**
     * The Azure location where the Confidential Ledger is running.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * Properties of Confidential Ledger Resource.
     */
    readonly properties?: pulumi.Input<inputs.confidentialledger.v20201201preview.LedgerProperties>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Additional tags for Confidential Ledger
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}
