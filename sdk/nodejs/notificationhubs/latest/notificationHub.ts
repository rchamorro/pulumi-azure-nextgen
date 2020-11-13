// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * Description of a NotificationHub Resource.
 */
export class NotificationHub extends pulumi.CustomResource {
    /**
     * Get an existing NotificationHub resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): NotificationHub {
        return new NotificationHub(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:notificationhubs/latest:NotificationHub';

    /**
     * Returns true if the given object is an instance of NotificationHub.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is NotificationHub {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === NotificationHub.__pulumiType;
    }

    /**
     * The AdmCredential of the created NotificationHub
     */
    public readonly admCredential!: pulumi.Output<outputs.notificationhubs.latest.AdmCredentialResponse | undefined>;
    /**
     * The ApnsCredential of the created NotificationHub
     */
    public readonly apnsCredential!: pulumi.Output<outputs.notificationhubs.latest.ApnsCredentialResponse | undefined>;
    /**
     * The AuthorizationRules of the created NotificationHub
     */
    public readonly authorizationRules!: pulumi.Output<outputs.notificationhubs.latest.SharedAccessAuthorizationRulePropertiesResponse[] | undefined>;
    /**
     * The BaiduCredential of the created NotificationHub
     */
    public readonly baiduCredential!: pulumi.Output<outputs.notificationhubs.latest.BaiduCredentialResponse | undefined>;
    /**
     * The GcmCredential of the created NotificationHub
     */
    public readonly gcmCredential!: pulumi.Output<outputs.notificationhubs.latest.GcmCredentialResponse | undefined>;
    /**
     * Resource location
     */
    public readonly location!: pulumi.Output<string | undefined>;
    /**
     * The MpnsCredential of the created NotificationHub
     */
    public readonly mpnsCredential!: pulumi.Output<outputs.notificationhubs.latest.MpnsCredentialResponse | undefined>;
    /**
     * Resource name
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The RegistrationTtl of the created NotificationHub
     */
    public readonly registrationTtl!: pulumi.Output<string | undefined>;
    /**
     * The sku of the created namespace
     */
    public readonly sku!: pulumi.Output<outputs.notificationhubs.latest.SkuResponse | undefined>;
    /**
     * Resource tags
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Resource type
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * The WnsCredential of the created NotificationHub
     */
    public readonly wnsCredential!: pulumi.Output<outputs.notificationhubs.latest.WnsCredentialResponse | undefined>;

    /**
     * Create a NotificationHub resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: NotificationHubArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.namespaceName === undefined) {
                throw new Error("Missing required property 'namespaceName'");
            }
            if (!args || args.notificationHubName === undefined) {
                throw new Error("Missing required property 'notificationHubName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["admCredential"] = args ? args.admCredential : undefined;
            inputs["apnsCredential"] = args ? args.apnsCredential : undefined;
            inputs["authorizationRules"] = args ? args.authorizationRules : undefined;
            inputs["baiduCredential"] = args ? args.baiduCredential : undefined;
            inputs["gcmCredential"] = args ? args.gcmCredential : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["mpnsCredential"] = args ? args.mpnsCredential : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["namespaceName"] = args ? args.namespaceName : undefined;
            inputs["notificationHubName"] = args ? args.notificationHubName : undefined;
            inputs["registrationTtl"] = args ? args.registrationTtl : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["sku"] = args ? args.sku : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["wnsCredential"] = args ? args.wnsCredential : undefined;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["admCredential"] = undefined /*out*/;
            inputs["apnsCredential"] = undefined /*out*/;
            inputs["authorizationRules"] = undefined /*out*/;
            inputs["baiduCredential"] = undefined /*out*/;
            inputs["gcmCredential"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["mpnsCredential"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["registrationTtl"] = undefined /*out*/;
            inputs["sku"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["wnsCredential"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:notificationhubs/v20140901:NotificationHub" }, { type: "azure-nextgen:notificationhubs/v20160301:NotificationHub" }, { type: "azure-nextgen:notificationhubs/v20170401:NotificationHub" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(NotificationHub.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a NotificationHub resource.
 */
export interface NotificationHubArgs {
    /**
     * The AdmCredential of the created NotificationHub
     */
    readonly admCredential?: pulumi.Input<inputs.notificationhubs.latest.AdmCredential>;
    /**
     * The ApnsCredential of the created NotificationHub
     */
    readonly apnsCredential?: pulumi.Input<inputs.notificationhubs.latest.ApnsCredential>;
    /**
     * The AuthorizationRules of the created NotificationHub
     */
    readonly authorizationRules?: pulumi.Input<pulumi.Input<inputs.notificationhubs.latest.SharedAccessAuthorizationRuleProperties>[]>;
    /**
     * The BaiduCredential of the created NotificationHub
     */
    readonly baiduCredential?: pulumi.Input<inputs.notificationhubs.latest.BaiduCredential>;
    /**
     * The GcmCredential of the created NotificationHub
     */
    readonly gcmCredential?: pulumi.Input<inputs.notificationhubs.latest.GcmCredential>;
    /**
     * Resource location
     */
    readonly location?: pulumi.Input<string>;
    /**
     * The MpnsCredential of the created NotificationHub
     */
    readonly mpnsCredential?: pulumi.Input<inputs.notificationhubs.latest.MpnsCredential>;
    /**
     * The NotificationHub name.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The namespace name.
     */
    readonly namespaceName: pulumi.Input<string>;
    /**
     * The notification hub name.
     */
    readonly notificationHubName: pulumi.Input<string>;
    /**
     * The RegistrationTtl of the created NotificationHub
     */
    readonly registrationTtl?: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The sku of the created namespace
     */
    readonly sku?: pulumi.Input<inputs.notificationhubs.latest.Sku>;
    /**
     * Resource tags
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The WnsCredential of the created NotificationHub
     */
    readonly wnsCredential?: pulumi.Input<inputs.notificationhubs.latest.WnsCredential>;
}
