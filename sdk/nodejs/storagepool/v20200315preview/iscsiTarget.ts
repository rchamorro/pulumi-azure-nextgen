// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * Payload for iSCSI Target Create or Update requests.
 */
export class IscsiTarget extends pulumi.CustomResource {
    /**
     * Get an existing IscsiTarget resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): IscsiTarget {
        return new IscsiTarget(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:storagepool/v20200315preview:IscsiTarget';

    /**
     * Returns true if the given object is an instance of IscsiTarget.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is IscsiTarget {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === IscsiTarget.__pulumiType;
    }

    /**
     * The name of the resource
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * State of the operation on the resource
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * Operational status of the Disk pool
     */
    public /*out*/ readonly status!: pulumi.Output<string>;
    /**
     * iSCSI target iqn (iSCSI Qualified Name); example: iqn.2005-03.org.iscsi:server
     */
    public readonly targetIqn!: pulumi.Output<string>;
    /**
     * list of iSCSI target portal groups
     */
    public readonly tpgs!: pulumi.Output<outputs.storagepool.v20200315preview.TargetPortalGroupResponse[]>;
    /**
     * The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a IscsiTarget resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: IscsiTargetArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.diskPoolName === undefined) {
                throw new Error("Missing required property 'diskPoolName'");
            }
            if (!args || args.iscsiTargetName === undefined) {
                throw new Error("Missing required property 'iscsiTargetName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.targetIqn === undefined) {
                throw new Error("Missing required property 'targetIqn'");
            }
            if (!args || args.tpgs === undefined) {
                throw new Error("Missing required property 'tpgs'");
            }
            inputs["diskPoolName"] = args ? args.diskPoolName : undefined;
            inputs["iscsiTargetName"] = args ? args.iscsiTargetName : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["targetIqn"] = args ? args.targetIqn : undefined;
            inputs["tpgs"] = args ? args.tpgs : undefined;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["status"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["status"] = undefined /*out*/;
            inputs["targetIqn"] = undefined /*out*/;
            inputs["tpgs"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(IscsiTarget.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a IscsiTarget resource.
 */
export interface IscsiTargetArgs {
    /**
     * The name of the Disk Pool.
     */
    readonly diskPoolName: pulumi.Input<string>;
    /**
     * The name of the iSCSI target.
     */
    readonly iscsiTargetName: pulumi.Input<string>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * iSCSI target iqn (iSCSI Qualified Name); example: iqn.2005-03.org.iscsi:server
     */
    readonly targetIqn: pulumi.Input<string>;
    /**
     * list of iSCSI target portal groups
     */
    readonly tpgs: pulumi.Input<pulumi.Input<inputs.storagepool.v20200315preview.TargetPortalGroup>[]>;
}