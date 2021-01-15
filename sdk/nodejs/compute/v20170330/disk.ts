// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Disk resource.
 */
export class Disk extends pulumi.CustomResource {
    /**
     * Get an existing Disk resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Disk {
        return new Disk(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:compute/v20170330:Disk';

    /**
     * Returns true if the given object is an instance of Disk.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Disk {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Disk.__pulumiType;
    }

    /**
     * Disk source information. CreationData information cannot be changed after the disk has been created.
     */
    public readonly creationData!: pulumi.Output<outputs.compute.v20170330.CreationDataResponse>;
    /**
     * If creationData.createOption is Empty, this field is mandatory and it indicates the size of the VHD to create. If this field is present for updates or creation with other options, it indicates a resize. Resizes are only allowed if the disk is not attached to a running VM, and can only increase the disk's size.
     */
    public readonly diskSizeGB!: pulumi.Output<number | undefined>;
    /**
     * Encryption settings for disk or snapshot
     */
    public readonly encryptionSettings!: pulumi.Output<outputs.compute.v20170330.EncryptionSettingsResponse | undefined>;
    /**
     * Resource location
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * A relative URI containing the ID of the VM that has the disk attached.
     */
    public /*out*/ readonly managedBy!: pulumi.Output<string>;
    /**
     * Resource name
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The Operating System type.
     */
    public readonly osType!: pulumi.Output<string | undefined>;
    /**
     * The disk provisioning state.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * The disks and snapshots sku name. Can be Standard_LRS or Premium_LRS.
     */
    public readonly sku!: pulumi.Output<outputs.compute.v20170330.DiskSkuResponse | undefined>;
    /**
     * Resource tags
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * The time when the disk was created.
     */
    public /*out*/ readonly timeCreated!: pulumi.Output<string>;
    /**
     * Resource type
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * The Logical zone list for Disk.
     */
    public readonly zones!: pulumi.Output<string[] | undefined>;

    /**
     * Create a Disk resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: DiskArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.creationData === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'creationData'");
            }
            if ((!args || args.diskName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'diskName'");
            }
            if ((!args || args.location === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'location'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["creationData"] = args ? args.creationData : undefined;
            inputs["diskName"] = args ? args.diskName : undefined;
            inputs["diskSizeGB"] = args ? args.diskSizeGB : undefined;
            inputs["encryptionSettings"] = args ? args.encryptionSettings : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["osType"] = args ? args.osType : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["sku"] = args ? args.sku : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["zones"] = args ? args.zones : undefined;
            inputs["managedBy"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["timeCreated"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["creationData"] = undefined /*out*/;
            inputs["diskSizeGB"] = undefined /*out*/;
            inputs["encryptionSettings"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["managedBy"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["osType"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["sku"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["timeCreated"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["zones"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:compute/latest:Disk" }, { type: "azure-nextgen:compute/v20160430preview:Disk" }, { type: "azure-nextgen:compute/v20180401:Disk" }, { type: "azure-nextgen:compute/v20180601:Disk" }, { type: "azure-nextgen:compute/v20180930:Disk" }, { type: "azure-nextgen:compute/v20190301:Disk" }, { type: "azure-nextgen:compute/v20190701:Disk" }, { type: "azure-nextgen:compute/v20191101:Disk" }, { type: "azure-nextgen:compute/v20200501:Disk" }, { type: "azure-nextgen:compute/v20200630:Disk" }, { type: "azure-nextgen:compute/v20200930:Disk" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(Disk.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Disk resource.
 */
export interface DiskArgs {
    /**
     * Disk source information. CreationData information cannot be changed after the disk has been created.
     */
    readonly creationData: pulumi.Input<inputs.compute.v20170330.CreationData>;
    /**
     * The name of the managed disk that is being created. The name can't be changed after the disk is created. Supported characters for the name are a-z, A-Z, 0-9 and _. The maximum name length is 80 characters.
     */
    readonly diskName: pulumi.Input<string>;
    /**
     * If creationData.createOption is Empty, this field is mandatory and it indicates the size of the VHD to create. If this field is present for updates or creation with other options, it indicates a resize. Resizes are only allowed if the disk is not attached to a running VM, and can only increase the disk's size.
     */
    readonly diskSizeGB?: pulumi.Input<number>;
    /**
     * Encryption settings for disk or snapshot
     */
    readonly encryptionSettings?: pulumi.Input<inputs.compute.v20170330.EncryptionSettings>;
    /**
     * Resource location
     */
    readonly location: pulumi.Input<string>;
    /**
     * The Operating System type.
     */
    readonly osType?: pulumi.Input<enums.compute.v20170330.OperatingSystemTypes>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The disks and snapshots sku name. Can be Standard_LRS or Premium_LRS.
     */
    readonly sku?: pulumi.Input<inputs.compute.v20170330.DiskSku>;
    /**
     * Resource tags
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The Logical zone list for Disk.
     */
    readonly zones?: pulumi.Input<pulumi.Input<string>[]>;
}
