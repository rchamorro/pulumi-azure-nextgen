// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Private dns zone group resource.
 */
export class PrivateDnsZoneGroup extends pulumi.CustomResource {
    /**
     * Get an existing PrivateDnsZoneGroup resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): PrivateDnsZoneGroup {
        return new PrivateDnsZoneGroup(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:network/v20200601:PrivateDnsZoneGroup';

    /**
     * Returns true if the given object is an instance of PrivateDnsZoneGroup.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is PrivateDnsZoneGroup {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === PrivateDnsZoneGroup.__pulumiType;
    }

    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    public /*out*/ readonly etag!: pulumi.Output<string>;
    /**
     * Name of the resource that is unique within a resource group. This name can be used to access the resource.
     */
    public readonly name!: pulumi.Output<string | undefined>;
    /**
     * A collection of private dns zone configurations of the private dns zone group.
     */
    public readonly privateDnsZoneConfigs!: pulumi.Output<outputs.network.v20200601.PrivateDnsZoneConfigResponse[] | undefined>;
    /**
     * The provisioning state of the private dns zone group resource.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;

    /**
     * Create a PrivateDnsZoneGroup resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: PrivateDnsZoneGroupArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.privateDnsZoneGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'privateDnsZoneGroupName'");
            }
            if ((!args || args.privateEndpointName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'privateEndpointName'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["id"] = args ? args.id : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["privateDnsZoneConfigs"] = args ? args.privateDnsZoneConfigs : undefined;
            inputs["privateDnsZoneGroupName"] = args ? args.privateDnsZoneGroupName : undefined;
            inputs["privateEndpointName"] = args ? args.privateEndpointName : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["etag"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
        } else {
            inputs["etag"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["privateDnsZoneConfigs"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:network/latest:PrivateDnsZoneGroup" }, { type: "azure-nextgen:network/v20200301:PrivateDnsZoneGroup" }, { type: "azure-nextgen:network/v20200401:PrivateDnsZoneGroup" }, { type: "azure-nextgen:network/v20200501:PrivateDnsZoneGroup" }, { type: "azure-nextgen:network/v20200701:PrivateDnsZoneGroup" }, { type: "azure-nextgen:network/v20200801:PrivateDnsZoneGroup" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(PrivateDnsZoneGroup.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a PrivateDnsZoneGroup resource.
 */
export interface PrivateDnsZoneGroupArgs {
    /**
     * Resource ID.
     */
    readonly id?: pulumi.Input<string>;
    /**
     * Name of the resource that is unique within a resource group. This name can be used to access the resource.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * A collection of private dns zone configurations of the private dns zone group.
     */
    readonly privateDnsZoneConfigs?: pulumi.Input<pulumi.Input<inputs.network.v20200601.PrivateDnsZoneConfig>[]>;
    /**
     * The name of the private dns zone group.
     */
    readonly privateDnsZoneGroupName: pulumi.Input<string>;
    /**
     * The name of the private endpoint.
     */
    readonly privateEndpointName: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
}
