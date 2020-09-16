"use strict";
// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***
Object.defineProperty(exports, "__esModule", { value: true });
const pulumi = require("@pulumi/pulumi");
const utilities = require("../../utilities");
function getDscNodeConfiguration(args, opts) {
    if (!opts) {
        opts = {};
    }
    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azurerm:automation/v20151031:getDscNodeConfiguration", {
        "automationAccountName": args.automationAccountName,
        "nodeConfigurationName": args.nodeConfigurationName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}
exports.getDscNodeConfiguration = getDscNodeConfiguration;
//# sourceMappingURL=getDscNodeConfiguration.js.map