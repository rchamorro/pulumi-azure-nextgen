"use strict";
// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***
Object.defineProperty(exports, "__esModule", { value: true });
const pulumi = require("@pulumi/pulumi");
const utilities = require("../../utilities");
function getContainerService(args, opts) {
    if (!opts) {
        opts = {};
    }
    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azurerm:containerservice/v20170701:getContainerService", {
        "containerServiceName": args.containerServiceName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}
exports.getContainerService = getContainerService;
//# sourceMappingURL=getContainerService.js.map