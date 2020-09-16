"use strict";
// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***
Object.defineProperty(exports, "__esModule", { value: true });
const pulumi = require("@pulumi/pulumi");
const utilities = require("../../utilities");
/**
 * Definition of the runbook type.
 */
class Runbook extends pulumi.CustomResource {
    constructor(name, argsOrState, opts) {
        let inputs = {};
        if (!(opts && opts.id)) {
            const args = argsOrState;
            if (!args || args.automationAccountName === undefined) {
                throw new Error("Missing required property 'automationAccountName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.runbookName === undefined) {
                throw new Error("Missing required property 'runbookName'");
            }
            if (!args || args.runbookType === undefined) {
                throw new Error("Missing required property 'runbookType'");
            }
            inputs["automationAccountName"] = args ? args.automationAccountName : undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["draft"] = args ? args.draft : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["logActivityTrace"] = args ? args.logActivityTrace : undefined;
            inputs["logProgress"] = args ? args.logProgress : undefined;
            inputs["logVerbose"] = args ? args.logVerbose : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["publishContentLink"] = args ? args.publishContentLink : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["runbookName"] = args ? args.runbookName : undefined;
            inputs["runbookType"] = args ? args.runbookType : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["creationTime"] = undefined /*out*/;
            inputs["etag"] = undefined /*out*/;
            inputs["jobCount"] = undefined /*out*/;
            inputs["lastModifiedBy"] = undefined /*out*/;
            inputs["lastModifiedTime"] = undefined /*out*/;
            inputs["outputTypes"] = undefined /*out*/;
            inputs["parameters"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["state"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {};
        }
        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azurerm:automation/v20151031:Runbook" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(Runbook.__pulumiType, name, inputs, opts);
    }
    /**
     * Get an existing Runbook resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    static get(name, id, opts) {
        return new Runbook(name, undefined, Object.assign(Object.assign({}, opts), { id: id }));
    }
    /**
     * Returns true if the given object is an instance of Runbook.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    static isInstance(obj) {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Runbook.__pulumiType;
    }
}
exports.Runbook = Runbook;
/** @internal */
Runbook.__pulumiType = 'azurerm:automation/v20180630:Runbook';
//# sourceMappingURL=runbook.js.map