// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Describes a DNS zone.
 * Latest API Version: 2018-05-01.
 */
export class Zone extends pulumi.CustomResource {
    /**
     * Get an existing Zone resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Zone {
        return new Zone(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:network/latest:Zone';

    /**
     * Returns true if the given object is an instance of Zone.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Zone {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Zone.__pulumiType;
    }

    /**
     * The etag of the zone.
     */
    public readonly etag!: pulumi.Output<string | undefined>;
    /**
     * Resource location.
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * The maximum number of record sets that can be created in this DNS zone.  This is a read-only property and any attempt to set this value will be ignored.
     */
    public /*out*/ readonly maxNumberOfRecordSets!: pulumi.Output<number>;
    /**
     * The maximum number of records per record set that can be created in this DNS zone.  This is a read-only property and any attempt to set this value will be ignored.
     */
    public /*out*/ readonly maxNumberOfRecordsPerRecordSet!: pulumi.Output<number>;
    /**
     * Resource name.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The name servers for this DNS zone. This is a read-only property and any attempt to set this value will be ignored.
     */
    public /*out*/ readonly nameServers!: pulumi.Output<string[]>;
    /**
     * The current number of record sets in this DNS zone.  This is a read-only property and any attempt to set this value will be ignored.
     */
    public /*out*/ readonly numberOfRecordSets!: pulumi.Output<number>;
    /**
     * A list of references to virtual networks that register hostnames in this DNS zone. This is a only when ZoneType is Private.
     */
    public readonly registrationVirtualNetworks!: pulumi.Output<outputs.network.latest.SubResourceResponse[] | undefined>;
    /**
     * A list of references to virtual networks that resolve records in this DNS zone. This is a only when ZoneType is Private.
     */
    public readonly resolutionVirtualNetworks!: pulumi.Output<outputs.network.latest.SubResourceResponse[] | undefined>;
    /**
     * Resource tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * The type of this DNS zone (Public or Private).
     */
    public readonly zoneType!: pulumi.Output<string | undefined>;

    /**
     * Create a Zone resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ZoneArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if ((!args || args.zoneName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'zoneName'");
            }
            inputs["etag"] = args ? args.etag : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["registrationVirtualNetworks"] = args ? args.registrationVirtualNetworks : undefined;
            inputs["resolutionVirtualNetworks"] = args ? args.resolutionVirtualNetworks : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["zoneName"] = args ? args.zoneName : undefined;
            inputs["zoneType"] = (args ? args.zoneType : undefined) || "Public";
            inputs["maxNumberOfRecordSets"] = undefined /*out*/;
            inputs["maxNumberOfRecordsPerRecordSet"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["nameServers"] = undefined /*out*/;
            inputs["numberOfRecordSets"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["etag"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["maxNumberOfRecordSets"] = undefined /*out*/;
            inputs["maxNumberOfRecordsPerRecordSet"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["nameServers"] = undefined /*out*/;
            inputs["numberOfRecordSets"] = undefined /*out*/;
            inputs["registrationVirtualNetworks"] = undefined /*out*/;
            inputs["resolutionVirtualNetworks"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["zoneType"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:network/v20150504preview:Zone" }, { type: "azure-nextgen:network/v20160401:Zone" }, { type: "azure-nextgen:network/v20170901:Zone" }, { type: "azure-nextgen:network/v20171001:Zone" }, { type: "azure-nextgen:network/v20180301preview:Zone" }, { type: "azure-nextgen:network/v20180501:Zone" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(Zone.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Zone resource.
 */
export interface ZoneArgs {
    /**
     * The etag of the zone.
     */
    readonly etag?: pulumi.Input<string>;
    /**
     * Resource location.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * A list of references to virtual networks that register hostnames in this DNS zone. This is a only when ZoneType is Private.
     */
    readonly registrationVirtualNetworks?: pulumi.Input<pulumi.Input<inputs.network.latest.SubResource>[]>;
    /**
     * A list of references to virtual networks that resolve records in this DNS zone. This is a only when ZoneType is Private.
     */
    readonly resolutionVirtualNetworks?: pulumi.Input<pulumi.Input<inputs.network.latest.SubResource>[]>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Resource tags.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The name of the DNS zone (without a terminating dot).
     */
    readonly zoneName: pulumi.Input<string>;
    /**
     * The type of this DNS zone (Public or Private).
     */
    readonly zoneType?: pulumi.Input<enums.network.latest.ZoneType>;
}
