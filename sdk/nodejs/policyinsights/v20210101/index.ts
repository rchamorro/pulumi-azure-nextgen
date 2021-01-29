// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

// Export members:
export * from "./attestationAtResource";
export * from "./attestationAtResourceGroup";
export * from "./attestationAtSubscription";
export * from "./getAttestationAtResource";
export * from "./getAttestationAtResourceGroup";
export * from "./getAttestationAtSubscription";

// Export enums:
export * from "../../types/enums/policyinsights/v20210101";

// Import resources to register:
import { AttestationAtResource } from "./attestationAtResource";
import { AttestationAtResourceGroup } from "./attestationAtResourceGroup";
import { AttestationAtSubscription } from "./attestationAtSubscription";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "azure-nextgen:policyinsights/v20210101:AttestationAtResource":
                return new AttestationAtResource(name, <any>undefined, { urn })
            case "azure-nextgen:policyinsights/v20210101:AttestationAtResourceGroup":
                return new AttestationAtResourceGroup(name, <any>undefined, { urn })
            case "azure-nextgen:policyinsights/v20210101:AttestationAtSubscription":
                return new AttestationAtSubscription(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("azure-nextgen", "policyinsights/v20210101", _module)
