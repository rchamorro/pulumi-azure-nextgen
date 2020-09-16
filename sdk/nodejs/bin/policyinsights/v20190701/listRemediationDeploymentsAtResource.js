"use strict";
// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***
Object.defineProperty(exports, "__esModule", { value: true });
const pulumi = require("@pulumi/pulumi");
const utilities = require("../../utilities");
function listRemediationDeploymentsAtResource(args, opts) {
    if (!opts) {
        opts = {};
    }
    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azurerm:policyinsights/v20190701:listRemediationDeploymentsAtResource", {
        "remediationName": args.remediationName,
        "resourceId": args.resourceId,
        "top": args.top,
    }, opts);
}
exports.listRemediationDeploymentsAtResource = listRemediationDeploymentsAtResource;
//# sourceMappingURL=listRemediationDeploymentsAtResource.js.map