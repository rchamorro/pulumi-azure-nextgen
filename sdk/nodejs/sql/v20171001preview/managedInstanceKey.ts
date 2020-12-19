// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * A managed instance key.
 */
export class ManagedInstanceKey extends pulumi.CustomResource {
    /**
     * Get an existing ManagedInstanceKey resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ManagedInstanceKey {
        return new ManagedInstanceKey(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:sql/v20171001preview:ManagedInstanceKey';

    /**
     * Returns true if the given object is an instance of ManagedInstanceKey.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ManagedInstanceKey {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ManagedInstanceKey.__pulumiType;
    }

    /**
     * The key creation date.
     */
    public /*out*/ readonly creationDate!: pulumi.Output<string>;
    /**
     * Kind of encryption protector. This is metadata used for the Azure portal experience.
     */
    public /*out*/ readonly kind!: pulumi.Output<string>;
    /**
     * Resource name.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The key type like 'ServiceManaged', 'AzureKeyVault'.
     */
    public readonly serverKeyType!: pulumi.Output<string>;
    /**
     * Thumbprint of the key.
     */
    public /*out*/ readonly thumbprint!: pulumi.Output<string>;
    /**
     * Resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * The URI of the key. If the ServerKeyType is AzureKeyVault, then the URI is required.
     */
    public readonly uri!: pulumi.Output<string | undefined>;

    /**
     * Create a ManagedInstanceKey resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ManagedInstanceKeyArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.keyName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'keyName'");
            }
            if ((!args || args.managedInstanceName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'managedInstanceName'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if ((!args || args.serverKeyType === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'serverKeyType'");
            }
            inputs["keyName"] = args ? args.keyName : undefined;
            inputs["managedInstanceName"] = args ? args.managedInstanceName : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["serverKeyType"] = args ? args.serverKeyType : undefined;
            inputs["uri"] = args ? args.uri : undefined;
            inputs["creationDate"] = undefined /*out*/;
            inputs["kind"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["thumbprint"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["creationDate"] = undefined /*out*/;
            inputs["kind"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["serverKeyType"] = undefined /*out*/;
            inputs["thumbprint"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["uri"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:sql/v20200202preview:ManagedInstanceKey" }, { type: "azure-nextgen:sql/v20200801preview:ManagedInstanceKey" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(ManagedInstanceKey.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a ManagedInstanceKey resource.
 */
export interface ManagedInstanceKeyArgs {
    /**
     * The name of the managed instance key to be operated on (updated or created).
     */
    readonly keyName: pulumi.Input<string>;
    /**
     * The name of the managed instance.
     */
    readonly managedInstanceName: pulumi.Input<string>;
    /**
     * The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The key type like 'ServiceManaged', 'AzureKeyVault'.
     */
    readonly serverKeyType: pulumi.Input<string | enums.sql.v20171001preview.ServerKeyType>;
    /**
     * The URI of the key. If the ServerKeyType is AzureKeyVault, then the URI is required.
     */
    readonly uri?: pulumi.Input<string>;
}
