// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

/**
 * Information about packet capture session.
 */
export class PacketCapture extends pulumi.CustomResource {
    /**
     * Get an existing PacketCapture resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): PacketCapture {
        return new PacketCapture(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:network/latest:PacketCapture';

    /**
     * Returns true if the given object is an instance of PacketCapture.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is PacketCapture {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === PacketCapture.__pulumiType;
    }

    /**
     * Number of bytes captured per packet, the remaining bytes are truncated.
     */
    public readonly bytesToCapturePerPacket!: pulumi.Output<number | undefined>;
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    public /*out*/ readonly etag!: pulumi.Output<string>;
    /**
     * A list of packet capture filters.
     */
    public readonly filters!: pulumi.Output<outputs.network.latest.PacketCaptureFilterResponse[] | undefined>;
    /**
     * Name of the packet capture session.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The provisioning state of the packet capture session.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * The storage location for a packet capture session.
     */
    public readonly storageLocation!: pulumi.Output<outputs.network.latest.PacketCaptureStorageLocationResponse>;
    /**
     * The ID of the targeted resource, only VM is currently supported.
     */
    public readonly target!: pulumi.Output<string>;
    /**
     * Maximum duration of the capture session in seconds.
     */
    public readonly timeLimitInSeconds!: pulumi.Output<number | undefined>;
    /**
     * Maximum size of the capture output.
     */
    public readonly totalBytesPerSession!: pulumi.Output<number | undefined>;

    /**
     * Create a PacketCapture resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: PacketCaptureArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.networkWatcherName === undefined) {
                throw new Error("Missing required property 'networkWatcherName'");
            }
            if (!args || args.packetCaptureName === undefined) {
                throw new Error("Missing required property 'packetCaptureName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.storageLocation === undefined) {
                throw new Error("Missing required property 'storageLocation'");
            }
            if (!args || args.target === undefined) {
                throw new Error("Missing required property 'target'");
            }
            inputs["bytesToCapturePerPacket"] = args ? args.bytesToCapturePerPacket : undefined;
            inputs["filters"] = args ? args.filters : undefined;
            inputs["networkWatcherName"] = args ? args.networkWatcherName : undefined;
            inputs["packetCaptureName"] = args ? args.packetCaptureName : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["storageLocation"] = args ? args.storageLocation : undefined;
            inputs["target"] = args ? args.target : undefined;
            inputs["timeLimitInSeconds"] = args ? args.timeLimitInSeconds : undefined;
            inputs["totalBytesPerSession"] = args ? args.totalBytesPerSession : undefined;
            inputs["etag"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
        } else {
            inputs["bytesToCapturePerPacket"] = undefined /*out*/;
            inputs["etag"] = undefined /*out*/;
            inputs["filters"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["storageLocation"] = undefined /*out*/;
            inputs["target"] = undefined /*out*/;
            inputs["timeLimitInSeconds"] = undefined /*out*/;
            inputs["totalBytesPerSession"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:network/v20160901:PacketCapture" }, { type: "azure-nextgen:network/v20161201:PacketCapture" }, { type: "azure-nextgen:network/v20170301:PacketCapture" }, { type: "azure-nextgen:network/v20170601:PacketCapture" }, { type: "azure-nextgen:network/v20170801:PacketCapture" }, { type: "azure-nextgen:network/v20170901:PacketCapture" }, { type: "azure-nextgen:network/v20171001:PacketCapture" }, { type: "azure-nextgen:network/v20171101:PacketCapture" }, { type: "azure-nextgen:network/v20180101:PacketCapture" }, { type: "azure-nextgen:network/v20180201:PacketCapture" }, { type: "azure-nextgen:network/v20180401:PacketCapture" }, { type: "azure-nextgen:network/v20180601:PacketCapture" }, { type: "azure-nextgen:network/v20180701:PacketCapture" }, { type: "azure-nextgen:network/v20180801:PacketCapture" }, { type: "azure-nextgen:network/v20181001:PacketCapture" }, { type: "azure-nextgen:network/v20181101:PacketCapture" }, { type: "azure-nextgen:network/v20181201:PacketCapture" }, { type: "azure-nextgen:network/v20190201:PacketCapture" }, { type: "azure-nextgen:network/v20190401:PacketCapture" }, { type: "azure-nextgen:network/v20190601:PacketCapture" }, { type: "azure-nextgen:network/v20190701:PacketCapture" }, { type: "azure-nextgen:network/v20190801:PacketCapture" }, { type: "azure-nextgen:network/v20190901:PacketCapture" }, { type: "azure-nextgen:network/v20191101:PacketCapture" }, { type: "azure-nextgen:network/v20191201:PacketCapture" }, { type: "azure-nextgen:network/v20200301:PacketCapture" }, { type: "azure-nextgen:network/v20200401:PacketCapture" }, { type: "azure-nextgen:network/v20200501:PacketCapture" }, { type: "azure-nextgen:network/v20200601:PacketCapture" }, { type: "azure-nextgen:network/v20200701:PacketCapture" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(PacketCapture.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a PacketCapture resource.
 */
export interface PacketCaptureArgs {
    /**
     * Number of bytes captured per packet, the remaining bytes are truncated.
     */
    readonly bytesToCapturePerPacket?: pulumi.Input<number>;
    /**
     * A list of packet capture filters.
     */
    readonly filters?: pulumi.Input<pulumi.Input<inputs.network.latest.PacketCaptureFilter>[]>;
    /**
     * The name of the network watcher.
     */
    readonly networkWatcherName: pulumi.Input<string>;
    /**
     * The name of the packet capture session.
     */
    readonly packetCaptureName: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The storage location for a packet capture session.
     */
    readonly storageLocation: pulumi.Input<inputs.network.latest.PacketCaptureStorageLocation>;
    /**
     * The ID of the targeted resource, only VM is currently supported.
     */
    readonly target: pulumi.Input<string>;
    /**
     * Maximum duration of the capture session in seconds.
     */
    readonly timeLimitInSeconds?: pulumi.Input<number>;
    /**
     * Maximum size of the capture output.
     */
    readonly totalBytesPerSession?: pulumi.Input<number>;
}
