// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * IoT Defender settings
 */
export class DefenderSetting extends pulumi.CustomResource {
    /**
     * Get an existing DefenderSetting resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): DefenderSetting {
        return new DefenderSetting(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:iotsecurity/v20210201preview:DefenderSetting';

    /**
     * Returns true if the given object is an instance of DefenderSetting.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is DefenderSetting {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === DefenderSetting.__pulumiType;
    }

    /**
     * Size of the device quota (as a opposed to a Pay as You Go billing model). Value is required to be in multiples of 1000.
     */
    public readonly deviceQuota!: pulumi.Output<number>;
    /**
     * The name of the resource
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Sentinel Workspace Resource Ids
     */
    public readonly sentinelWorkspaceResourceIds!: pulumi.Output<string[]>;
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a DefenderSetting resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: DefenderSettingArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.deviceQuota === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'deviceQuota'");
            }
            if ((!args || args.sentinelWorkspaceResourceIds === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'sentinelWorkspaceResourceIds'");
            }
            inputs["deviceQuota"] = args ? args.deviceQuota : undefined;
            inputs["sentinelWorkspaceResourceIds"] = args ? args.sentinelWorkspaceResourceIds : undefined;
            inputs["name"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["deviceQuota"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["sentinelWorkspaceResourceIds"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(DefenderSetting.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a DefenderSetting resource.
 */
export interface DefenderSettingArgs {
    /**
     * Size of the device quota (as a opposed to a Pay as You Go billing model). Value is required to be in multiples of 1000.
     */
    readonly deviceQuota: pulumi.Input<number>;
    /**
     * Sentinel Workspace Resource Ids
     */
    readonly sentinelWorkspaceResourceIds: pulumi.Input<pulumi.Input<string>[]>;
}
