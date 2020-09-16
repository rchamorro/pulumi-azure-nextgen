"use strict";
// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***
Object.defineProperty(exports, "__esModule", { value: true });
const pulumi = require("@pulumi/pulumi");
const utilities = require("../../utilities");
/**
 * The policy definition.
 */
class PolicyDefinition extends pulumi.CustomResource {
    constructor(name, argsOrState, opts) {
        let inputs = {};
        if (!(opts && opts.id)) {
            const args = argsOrState;
            if (!args || args.policyDefinitionName === undefined) {
                throw new Error("Missing required property 'policyDefinitionName'");
            }
            inputs["description"] = args ? args.description : undefined;
            inputs["displayName"] = args ? args.displayName : undefined;
            inputs["metadata"] = args ? args.metadata : undefined;
            inputs["mode"] = args ? args.mode : undefined;
            inputs["parameters"] = args ? args.parameters : undefined;
            inputs["policyDefinitionName"] = args ? args.policyDefinitionName : undefined;
            inputs["policyRule"] = args ? args.policyRule : undefined;
            inputs["policyType"] = args ? args.policyType : undefined;
            inputs["name"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {};
        }
        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azurerm:authorization/v20180301:PolicyDefinition" }, { type: "azurerm:authorization/v20180501:PolicyDefinition" }, { type: "azurerm:authorization/v20190101:PolicyDefinition" }, { type: "azurerm:authorization/v20190601:PolicyDefinition" }, { type: "azurerm:authorization/v20190901:PolicyDefinition" }, { type: "azurerm:authorization/v20200301:PolicyDefinition" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(PolicyDefinition.__pulumiType, name, inputs, opts);
    }
    /**
     * Get an existing PolicyDefinition resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    static get(name, id, opts) {
        return new PolicyDefinition(name, undefined, Object.assign(Object.assign({}, opts), { id: id }));
    }
    /**
     * Returns true if the given object is an instance of PolicyDefinition.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    static isInstance(obj) {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === PolicyDefinition.__pulumiType;
    }
}
exports.PolicyDefinition = PolicyDefinition;
/** @internal */
PolicyDefinition.__pulumiType = 'azurerm:authorization/v20161201:PolicyDefinition';
//# sourceMappingURL=policyDefinition.js.map