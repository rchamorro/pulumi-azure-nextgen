"use strict";
// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***
Object.defineProperty(exports, "__esModule", { value: true });
const pulumi = require("@pulumi/pulumi");
const utilities = require("../../utilities");
/**
 * The link resource format.
 */
class Link extends pulumi.CustomResource {
    constructor(name, argsOrState, opts) {
        let inputs = {};
        if (!(opts && opts.id)) {
            const args = argsOrState;
            if (!args || args.hubName === undefined) {
                throw new Error("Missing required property 'hubName'");
            }
            if (!args || args.linkName === undefined) {
                throw new Error("Missing required property 'linkName'");
            }
            if (!args || args.participantPropertyReferences === undefined) {
                throw new Error("Missing required property 'participantPropertyReferences'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.sourceEntityType === undefined) {
                throw new Error("Missing required property 'sourceEntityType'");
            }
            if (!args || args.sourceEntityTypeName === undefined) {
                throw new Error("Missing required property 'sourceEntityTypeName'");
            }
            if (!args || args.targetEntityType === undefined) {
                throw new Error("Missing required property 'targetEntityType'");
            }
            if (!args || args.targetEntityTypeName === undefined) {
                throw new Error("Missing required property 'targetEntityTypeName'");
            }
            inputs["description"] = args ? args.description : undefined;
            inputs["displayName"] = args ? args.displayName : undefined;
            inputs["hubName"] = args ? args.hubName : undefined;
            inputs["linkName"] = args ? args.linkName : undefined;
            inputs["mappings"] = args ? args.mappings : undefined;
            inputs["operationType"] = args ? args.operationType : undefined;
            inputs["participantPropertyReferences"] = args ? args.participantPropertyReferences : undefined;
            inputs["referenceOnly"] = args ? args.referenceOnly : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["sourceEntityType"] = args ? args.sourceEntityType : undefined;
            inputs["sourceEntityTypeName"] = args ? args.sourceEntityTypeName : undefined;
            inputs["targetEntityType"] = args ? args.targetEntityType : undefined;
            inputs["targetEntityTypeName"] = args ? args.targetEntityTypeName : undefined;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["tenantId"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {};
        }
        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azurerm:customerinsights/v20170101:Link" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(Link.__pulumiType, name, inputs, opts);
    }
    /**
     * Get an existing Link resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    static get(name, id, opts) {
        return new Link(name, undefined, Object.assign(Object.assign({}, opts), { id: id }));
    }
    /**
     * Returns true if the given object is an instance of Link.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    static isInstance(obj) {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Link.__pulumiType;
    }
}
exports.Link = Link;
/** @internal */
Link.__pulumiType = 'azurerm:customerinsights/v20170426:Link';
//# sourceMappingURL=link.js.map