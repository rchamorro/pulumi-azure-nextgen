// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

// Export members:
export * from "./account";
export * from "./computePolicy";
export * from "./firewallRule";
export * from "./getAccount";
export * from "./getComputePolicy";
export * from "./getFirewallRule";
export * from "./listAccountSasTokens";

// Export enums:
export * from "../../types/enums/datalakeanalytics/v20151001preview";

// Import resources to register:
import { Account } from "./account";
import { ComputePolicy } from "./computePolicy";
import { FirewallRule } from "./firewallRule";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "azure-nextgen:datalakeanalytics/v20151001preview:Account":
                return new Account(name, <any>undefined, { urn })
            case "azure-nextgen:datalakeanalytics/v20151001preview:ComputePolicy":
                return new ComputePolicy(name, <any>undefined, { urn })
            case "azure-nextgen:datalakeanalytics/v20151001preview:FirewallRule":
                return new FirewallRule(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("azure-nextgen", "datalakeanalytics/v20151001preview", _module)
