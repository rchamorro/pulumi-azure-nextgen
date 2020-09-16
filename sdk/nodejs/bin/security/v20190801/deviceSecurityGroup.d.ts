import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
/**
 * The device security group resource
 */
export declare class DeviceSecurityGroup extends pulumi.CustomResource {
    /**
     * Get an existing DeviceSecurityGroup resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): DeviceSecurityGroup;
    /**
     * Returns true if the given object is an instance of DeviceSecurityGroup.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    static isInstance(obj: any): obj is DeviceSecurityGroup;
    /**
     * The allow-list custom alert rules.
     */
    readonly allowlistRules: pulumi.Output<outputs.security.v20190801.AllowlistCustomAlertRuleResponse[] | undefined>;
    /**
     * The deny-list custom alert rules.
     */
    readonly denylistRules: pulumi.Output<outputs.security.v20190801.DenylistCustomAlertRuleResponse[] | undefined>;
    /**
     * Resource name
     */
    readonly name: pulumi.Output<string>;
    /**
     * The list of custom alert threshold rules.
     */
    readonly thresholdRules: pulumi.Output<outputs.security.v20190801.ThresholdCustomAlertRuleResponse[] | undefined>;
    /**
     * The list of custom alert time-window rules.
     */
    readonly timeWindowRules: pulumi.Output<outputs.security.v20190801.TimeWindowCustomAlertRuleResponse[] | undefined>;
    /**
     * Resource type
     */
    readonly type: pulumi.Output<string>;
    /**
     * Create a DeviceSecurityGroup resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: DeviceSecurityGroupArgs, opts?: pulumi.CustomResourceOptions);
    constructor(name: string, state: undefined, opts: pulumi.CustomResourceOptions);
}
/**
 * The set of arguments for constructing a DeviceSecurityGroup resource.
 */
export interface DeviceSecurityGroupArgs {
    /**
     * The allow-list custom alert rules.
     */
    readonly allowlistRules?: pulumi.Input<pulumi.Input<inputs.security.v20190801.AllowlistCustomAlertRule>[]>;
    /**
     * The deny-list custom alert rules.
     */
    readonly denylistRules?: pulumi.Input<pulumi.Input<inputs.security.v20190801.DenylistCustomAlertRule>[]>;
    /**
     * The name of the device security group. Note that the name of the device security group is case insensitive.
     */
    readonly deviceSecurityGroupName: pulumi.Input<string>;
    /**
     * The identifier of the resource.
     */
    readonly resourceId: pulumi.Input<string>;
    /**
     * The list of custom alert threshold rules.
     */
    readonly thresholdRules?: pulumi.Input<pulumi.Input<inputs.security.v20190801.ThresholdCustomAlertRule>[]>;
    /**
     * The list of custom alert time-window rules.
     */
    readonly timeWindowRules?: pulumi.Input<pulumi.Input<inputs.security.v20190801.TimeWindowCustomAlertRule>[]>;
}