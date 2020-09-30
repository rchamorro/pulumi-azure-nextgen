// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

/**
 * The policy assignment.
 */
export class PolicyAssignment extends pulumi.CustomResource {
    /**
     * Get an existing PolicyAssignment resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): PolicyAssignment {
        return new PolicyAssignment(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:authorization/v20180301:PolicyAssignment';

    /**
     * Returns true if the given object is an instance of PolicyAssignment.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is PolicyAssignment {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === PolicyAssignment.__pulumiType;
    }

    /**
     * This message will be part of response in case of policy violation.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * The display name of the policy assignment.
     */
    public readonly displayName!: pulumi.Output<string | undefined>;
    /**
     * The policy assignment metadata.
     */
    public readonly metadata!: pulumi.Output<any | undefined>;
    /**
     * The name of the policy assignment.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The policy's excluded scopes.
     */
    public readonly notScopes!: pulumi.Output<string[] | undefined>;
    /**
     * Required if a parameter is used in policy rule.
     */
    public readonly parameters!: pulumi.Output<any | undefined>;
    /**
     * The ID of the policy definition or policy set definition being assigned.
     */
    public readonly policyDefinitionId!: pulumi.Output<string | undefined>;
    /**
     * The scope for the policy assignment.
     */
    public readonly scope!: pulumi.Output<string | undefined>;
    /**
     * The policy sku. This property is optional, obsolete, and will be ignored.
     */
    public readonly sku!: pulumi.Output<outputs.authorization.v20180301.PolicySkuResponse | undefined>;
    /**
     * The type of the policy assignment.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a PolicyAssignment resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: PolicyAssignmentArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.policyAssignmentName === undefined) {
                throw new Error("Missing required property 'policyAssignmentName'");
            }
            if (!args || args.scope === undefined) {
                throw new Error("Missing required property 'scope'");
            }
            inputs["description"] = args ? args.description : undefined;
            inputs["displayName"] = args ? args.displayName : undefined;
            inputs["metadata"] = args ? args.metadata : undefined;
            inputs["notScopes"] = args ? args.notScopes : undefined;
            inputs["parameters"] = args ? args.parameters : undefined;
            inputs["policyAssignmentName"] = args ? args.policyAssignmentName : undefined;
            inputs["policyDefinitionId"] = args ? args.policyDefinitionId : undefined;
            inputs["scope"] = args ? args.scope : undefined;
            inputs["sku"] = args ? args.sku : undefined;
            inputs["name"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["description"] = undefined /*out*/;
            inputs["displayName"] = undefined /*out*/;
            inputs["metadata"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["notScopes"] = undefined /*out*/;
            inputs["parameters"] = undefined /*out*/;
            inputs["policyDefinitionId"] = undefined /*out*/;
            inputs["scope"] = undefined /*out*/;
            inputs["sku"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:authorization/latest:PolicyAssignment" }, { type: "azure-nextgen:authorization/v20151001preview:PolicyAssignment" }, { type: "azure-nextgen:authorization/v20151101:PolicyAssignment" }, { type: "azure-nextgen:authorization/v20160401:PolicyAssignment" }, { type: "azure-nextgen:authorization/v20161201:PolicyAssignment" }, { type: "azure-nextgen:authorization/v20170601preview:PolicyAssignment" }, { type: "azure-nextgen:authorization/v20180501:PolicyAssignment" }, { type: "azure-nextgen:authorization/v20190101:PolicyAssignment" }, { type: "azure-nextgen:authorization/v20190601:PolicyAssignment" }, { type: "azure-nextgen:authorization/v20190901:PolicyAssignment" }, { type: "azure-nextgen:authorization/v20200301:PolicyAssignment" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(PolicyAssignment.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a PolicyAssignment resource.
 */
export interface PolicyAssignmentArgs {
    /**
     * This message will be part of response in case of policy violation.
     */
    readonly description?: pulumi.Input<string>;
    /**
     * The display name of the policy assignment.
     */
    readonly displayName?: pulumi.Input<string>;
    /**
     * The policy assignment metadata.
     */
    readonly metadata?: any;
    /**
     * The policy's excluded scopes.
     */
    readonly notScopes?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Required if a parameter is used in policy rule.
     */
    readonly parameters?: any;
    /**
     * The name of the policy assignment.
     */
    readonly policyAssignmentName: pulumi.Input<string>;
    /**
     * The ID of the policy definition or policy set definition being assigned.
     */
    readonly policyDefinitionId?: pulumi.Input<string>;
    /**
     * The scope for the policy assignment.
     */
    readonly scope: pulumi.Input<string>;
    /**
     * The policy sku. This property is optional, obsolete, and will be ignored.
     */
    readonly sku?: pulumi.Input<inputs.authorization.v20180301.PolicySku>;
}
