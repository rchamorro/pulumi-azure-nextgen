// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * RemoteRenderingAccount Response.
 */
export class RemoteRenderingAccount extends pulumi.CustomResource {
    /**
     * Get an existing RemoteRenderingAccount resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): RemoteRenderingAccount {
        return new RemoteRenderingAccount(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:mixedreality/v20200406preview:RemoteRenderingAccount';

    /**
     * Returns true if the given object is an instance of RemoteRenderingAccount.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is RemoteRenderingAccount {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === RemoteRenderingAccount.__pulumiType;
    }

    /**
     * Correspond domain name of certain Spatial Anchors Account
     */
    public /*out*/ readonly accountDomain!: pulumi.Output<string>;
    /**
     * unique id of certain account.
     */
    public /*out*/ readonly accountId!: pulumi.Output<string>;
    public readonly identity!: pulumi.Output<outputs.mixedreality.v20200406preview.RemoteRenderingAccountResponseIdentity | undefined>;
    /**
     * The geo-location where the resource lives
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * The name of the resource
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Resource tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a RemoteRenderingAccount resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: RemoteRenderingAccountArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.accountName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'accountName'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["accountName"] = args ? args.accountName : undefined;
            inputs["identity"] = args ? args.identity : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["accountDomain"] = undefined /*out*/;
            inputs["accountId"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["accountDomain"] = undefined /*out*/;
            inputs["accountId"] = undefined /*out*/;
            inputs["identity"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:mixedreality/latest:RemoteRenderingAccount" }, { type: "azure-nextgen:mixedreality/v20191202preview:RemoteRenderingAccount" }, { type: "azure-nextgen:mixedreality/v20210101:RemoteRenderingAccount" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(RemoteRenderingAccount.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a RemoteRenderingAccount resource.
 */
export interface RemoteRenderingAccountArgs {
    /**
     * Name of an Mixed Reality Account.
     */
    readonly accountName: pulumi.Input<string>;
    readonly identity?: pulumi.Input<inputs.mixedreality.v20200406preview.RemoteRenderingAccountIdentity>;
    /**
     * The geo-location where the resource lives
     */
    readonly location?: pulumi.Input<string>;
    /**
     * Name of an Azure resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Resource tags.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}
