// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Information about a partner registration.
 */
export class PartnerRegistration extends pulumi.CustomResource {
    /**
     * Get an existing PartnerRegistration resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): PartnerRegistration {
        return new PartnerRegistration(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:eventgrid/v20200401preview:PartnerRegistration';

    /**
     * Returns true if the given object is an instance of PartnerRegistration.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is PartnerRegistration {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === PartnerRegistration.__pulumiType;
    }

    /**
     * List of Azure subscription Ids that are authorized to create a partner namespace
     * associated with this partner registration. This is an optional property. Creating
     * partner namespaces is always permitted under the same Azure subscription as the one used
     * for creating the partner registration.
     */
    public readonly authorizedAzureSubscriptionIds!: pulumi.Output<string[] | undefined>;
    /**
     * The extension of the customer service URI of the publisher.
     */
    public readonly customerServiceUri!: pulumi.Output<string | undefined>;
    /**
     * Location of the resource.
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * URI of the logo.
     */
    public readonly logoUri!: pulumi.Output<string | undefined>;
    /**
     * Long description for the custom scenarios and integration to be displayed in the portal if needed.
     * Length of this description should not exceed 2048 characters.
     */
    public readonly longDescription!: pulumi.Output<string | undefined>;
    /**
     * Name of the resource
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The extension of the customer service number of the publisher. Only digits are allowed and number of digits should not exceed 10.
     */
    public readonly partnerCustomerServiceExtension!: pulumi.Output<string | undefined>;
    /**
     * The customer service number of the publisher. The expected phone format should start with a '+' sign 
     * followed by the country code. The remaining digits are then followed. Only digits and spaces are allowed and its
     * length cannot exceed 16 digits including country code. Examples of valid phone numbers are: +1 515 123 4567 and
     * +966 7 5115 2471. Examples of invalid phone numbers are: +1 (515) 123-4567, 1 515 123 4567 and +966 121 5115 24 7 551 1234 43
     */
    public readonly partnerCustomerServiceNumber!: pulumi.Output<string | undefined>;
    /**
     * Official name of the partner name. For example: "Contoso".
     */
    public readonly partnerName!: pulumi.Output<string | undefined>;
    /**
     * Short description of the partner resource type. The length of this description should not exceed 256 characters.
     */
    public readonly partnerResourceTypeDescription!: pulumi.Output<string | undefined>;
    /**
     * Display name of the partner resource type.
     */
    public readonly partnerResourceTypeDisplayName!: pulumi.Output<string | undefined>;
    /**
     * Name of the partner resource type.
     */
    public readonly partnerResourceTypeName!: pulumi.Output<string | undefined>;
    /**
     * Provisioning state of the partner registration.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * URI of the partner website that can be used by Azure customers to setup Event Grid
     * integration on an event source.
     */
    public readonly setupUri!: pulumi.Output<string | undefined>;
    /**
     * Tags of the resource.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Type of the resource
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * Visibility state of the partner registration.
     */
    public readonly visibilityState!: pulumi.Output<string | undefined>;

    /**
     * Create a PartnerRegistration resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: PartnerRegistrationArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.partnerRegistrationName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'partnerRegistrationName'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["authorizedAzureSubscriptionIds"] = args ? args.authorizedAzureSubscriptionIds : undefined;
            inputs["customerServiceUri"] = args ? args.customerServiceUri : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["logoUri"] = args ? args.logoUri : undefined;
            inputs["longDescription"] = args ? args.longDescription : undefined;
            inputs["partnerCustomerServiceExtension"] = args ? args.partnerCustomerServiceExtension : undefined;
            inputs["partnerCustomerServiceNumber"] = args ? args.partnerCustomerServiceNumber : undefined;
            inputs["partnerName"] = args ? args.partnerName : undefined;
            inputs["partnerRegistrationName"] = args ? args.partnerRegistrationName : undefined;
            inputs["partnerResourceTypeDescription"] = args ? args.partnerResourceTypeDescription : undefined;
            inputs["partnerResourceTypeDisplayName"] = args ? args.partnerResourceTypeDisplayName : undefined;
            inputs["partnerResourceTypeName"] = args ? args.partnerResourceTypeName : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["setupUri"] = args ? args.setupUri : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["visibilityState"] = args ? args.visibilityState : undefined;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["authorizedAzureSubscriptionIds"] = undefined /*out*/;
            inputs["customerServiceUri"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["logoUri"] = undefined /*out*/;
            inputs["longDescription"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["partnerCustomerServiceExtension"] = undefined /*out*/;
            inputs["partnerCustomerServiceNumber"] = undefined /*out*/;
            inputs["partnerName"] = undefined /*out*/;
            inputs["partnerResourceTypeDescription"] = undefined /*out*/;
            inputs["partnerResourceTypeDisplayName"] = undefined /*out*/;
            inputs["partnerResourceTypeName"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["setupUri"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["visibilityState"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:eventgrid/v20201015preview:PartnerRegistration" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(PartnerRegistration.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a PartnerRegistration resource.
 */
export interface PartnerRegistrationArgs {
    /**
     * List of Azure subscription Ids that are authorized to create a partner namespace
     * associated with this partner registration. This is an optional property. Creating
     * partner namespaces is always permitted under the same Azure subscription as the one used
     * for creating the partner registration.
     */
    readonly authorizedAzureSubscriptionIds?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The extension of the customer service URI of the publisher.
     */
    readonly customerServiceUri?: pulumi.Input<string>;
    /**
     * Location of the resource.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * URI of the logo.
     */
    readonly logoUri?: pulumi.Input<string>;
    /**
     * Long description for the custom scenarios and integration to be displayed in the portal if needed.
     * Length of this description should not exceed 2048 characters.
     */
    readonly longDescription?: pulumi.Input<string>;
    /**
     * The extension of the customer service number of the publisher. Only digits are allowed and number of digits should not exceed 10.
     */
    readonly partnerCustomerServiceExtension?: pulumi.Input<string>;
    /**
     * The customer service number of the publisher. The expected phone format should start with a '+' sign 
     * followed by the country code. The remaining digits are then followed. Only digits and spaces are allowed and its
     * length cannot exceed 16 digits including country code. Examples of valid phone numbers are: +1 515 123 4567 and
     * +966 7 5115 2471. Examples of invalid phone numbers are: +1 (515) 123-4567, 1 515 123 4567 and +966 121 5115 24 7 551 1234 43
     */
    readonly partnerCustomerServiceNumber?: pulumi.Input<string>;
    /**
     * Official name of the partner name. For example: "Contoso".
     */
    readonly partnerName?: pulumi.Input<string>;
    /**
     * Name of the partner registration.
     */
    readonly partnerRegistrationName: pulumi.Input<string>;
    /**
     * Short description of the partner resource type. The length of this description should not exceed 256 characters.
     */
    readonly partnerResourceTypeDescription?: pulumi.Input<string>;
    /**
     * Display name of the partner resource type.
     */
    readonly partnerResourceTypeDisplayName?: pulumi.Input<string>;
    /**
     * Name of the partner resource type.
     */
    readonly partnerResourceTypeName?: pulumi.Input<string>;
    /**
     * The name of the resource group within the user's subscription.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * URI of the partner website that can be used by Azure customers to setup Event Grid
     * integration on an event source.
     */
    readonly setupUri?: pulumi.Input<string>;
    /**
     * Tags of the resource.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Visibility state of the partner registration.
     */
    readonly visibilityState?: pulumi.Input<string | enums.eventgrid.v20200401preview.PartnerRegistrationVisibilityState>;
}
