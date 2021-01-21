// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Represents order contract
 */
export class OrderByName extends pulumi.CustomResource {
    /**
     * Get an existing OrderByName resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): OrderByName {
        return new OrderByName(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:edgeorder/v20201201preview:OrderByName';

    /**
     * Returns true if the given object is an instance of OrderByName.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is OrderByName {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === OrderByName.__pulumiType;
    }

    /**
     * Represents shipping and return address for order
     */
    public readonly addressDetails!: pulumi.Output<outputs.edgeorder.v20201201preview.AddressDetailsResponse>;
    /**
     * The geo-location where the resource lives
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * The name of the resource
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Id of the order collection to which order belongs to
     */
    public /*out*/ readonly orderCollectionId!: pulumi.Output<string>;
    /**
     * Represents order details.
     */
    public readonly orderDetails!: pulumi.Output<outputs.edgeorder.v20201201preview.OrderDetailsResponse>;
    /**
     * Start time of order
     */
    public /*out*/ readonly startTime!: pulumi.Output<string>;
    /**
     * Represents resource creation and update time
     */
    public /*out*/ readonly systemData!: pulumi.Output<outputs.edgeorder.v20201201preview.SystemDataResponse>;
    /**
     * Resource tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a OrderByName resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: OrderByNameArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.addressDetails === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'addressDetails'");
            }
            if ((!args || args.location === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'location'");
            }
            if ((!args || args.orderDetails === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'orderDetails'");
            }
            if ((!args || args.orderName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'orderName'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["addressDetails"] = args ? args.addressDetails : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["orderDetails"] = args ? args.orderDetails : undefined;
            inputs["orderName"] = args ? args.orderName : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["name"] = undefined /*out*/;
            inputs["orderCollectionId"] = undefined /*out*/;
            inputs["startTime"] = undefined /*out*/;
            inputs["systemData"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["addressDetails"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["orderCollectionId"] = undefined /*out*/;
            inputs["orderDetails"] = undefined /*out*/;
            inputs["startTime"] = undefined /*out*/;
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
        super(OrderByName.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a OrderByName resource.
 */
export interface OrderByNameArgs {
    /**
     * Represents shipping and return address for order
     */
    readonly addressDetails: pulumi.Input<inputs.edgeorder.v20201201preview.AddressDetails>;
    /**
     * The geo-location where the resource lives
     */
    readonly location: pulumi.Input<string>;
    /**
     * Represents order details.
     */
    readonly orderDetails: pulumi.Input<inputs.edgeorder.v20201201preview.OrderDetails>;
    /**
     * The name of the order
     */
    readonly orderName: pulumi.Input<string>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Resource tags.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}
