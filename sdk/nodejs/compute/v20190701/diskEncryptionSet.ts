// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * disk encryption set resource.
 */
export class DiskEncryptionSet extends pulumi.CustomResource {
    /**
     * Get an existing DiskEncryptionSet resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): DiskEncryptionSet {
        return new DiskEncryptionSet(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:compute/v20190701:DiskEncryptionSet';

    /**
     * Returns true if the given object is an instance of DiskEncryptionSet.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is DiskEncryptionSet {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === DiskEncryptionSet.__pulumiType;
    }

    /**
     * The key vault key which is currently used by this disk encryption set.
     */
    public readonly activeKey!: pulumi.Output<outputs.compute.v20190701.KeyVaultAndKeyReferenceResponse | undefined>;
    /**
     * The managed identity for the disk encryption set. It should be given permission on the key vault before it can be used to encrypt disks.
     */
    public readonly identity!: pulumi.Output<outputs.compute.v20190701.EncryptionSetIdentityResponse | undefined>;
    /**
     * Resource location
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * Resource name
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * A readonly collection of key vault keys previously used by this disk encryption set while a key rotation is in progress. It will be empty if there is no ongoing key rotation.
     */
    public /*out*/ readonly previousKeys!: pulumi.Output<outputs.compute.v20190701.KeyVaultAndKeyReferenceResponse[]>;
    /**
     * The disk encryption set provisioning state.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * Resource tags
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Resource type
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a DiskEncryptionSet resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: DiskEncryptionSetArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.diskEncryptionSetName === undefined) {
                throw new Error("Missing required property 'diskEncryptionSetName'");
            }
            if (!args || args.location === undefined) {
                throw new Error("Missing required property 'location'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["activeKey"] = args ? args.activeKey : undefined;
            inputs["diskEncryptionSetName"] = args ? args.diskEncryptionSetName : undefined;
            inputs["identity"] = args ? args.identity : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["name"] = undefined /*out*/;
            inputs["previousKeys"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["activeKey"] = undefined /*out*/;
            inputs["identity"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["previousKeys"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:compute/latest:DiskEncryptionSet" }, { type: "azure-nextgen:compute/v20191101:DiskEncryptionSet" }, { type: "azure-nextgen:compute/v20200501:DiskEncryptionSet" }, { type: "azure-nextgen:compute/v20200630:DiskEncryptionSet" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(DiskEncryptionSet.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a DiskEncryptionSet resource.
 */
export interface DiskEncryptionSetArgs {
    /**
     * The key vault key which is currently used by this disk encryption set.
     */
    readonly activeKey?: pulumi.Input<inputs.compute.v20190701.KeyVaultAndKeyReference>;
    /**
     * The name of the disk encryption set that is being created. The name can't be changed after the disk encryption set is created. Supported characters for the name are a-z, A-Z, 0-9 and _. The maximum name length is 80 characters.
     */
    readonly diskEncryptionSetName: pulumi.Input<string>;
    /**
     * The managed identity for the disk encryption set. It should be given permission on the key vault before it can be used to encrypt disks.
     */
    readonly identity?: pulumi.Input<inputs.compute.v20190701.EncryptionSetIdentity>;
    /**
     * Resource location
     */
    readonly location: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Resource tags
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}
