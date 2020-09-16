import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
/**
 * Represents a domain
 */
export declare class Domain extends pulumi.CustomResource {
    /**
     * Get an existing Domain resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Domain;
    /**
     * Returns true if the given object is an instance of Domain.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    static isInstance(obj: any): obj is Domain;
    /**
     * If true then domain will renewed automatically
     */
    readonly autoRenew: pulumi.Output<boolean | undefined>;
    /**
     * Legal agreement consent
     */
    readonly consent: pulumi.Output<outputs.domainregistration.v20150801.DomainPurchaseConsentResponse | undefined>;
    /**
     * Admin contact information
     */
    readonly contactAdmin: pulumi.Output<outputs.domainregistration.v20150801.ContactResponse | undefined>;
    /**
     * Billing contact information
     */
    readonly contactBilling: pulumi.Output<outputs.domainregistration.v20150801.ContactResponse | undefined>;
    /**
     * Registrant contact information
     */
    readonly contactRegistrant: pulumi.Output<outputs.domainregistration.v20150801.ContactResponse | undefined>;
    /**
     * Technical contact information
     */
    readonly contactTech: pulumi.Output<outputs.domainregistration.v20150801.ContactResponse | undefined>;
    /**
     * Domain creation timestamp
     */
    readonly createdTime: pulumi.Output<string | undefined>;
    /**
     * Reasons why domain is not renewable
     */
    readonly domainNotRenewableReasons: pulumi.Output<string[] | undefined>;
    /**
     * Domain expiration timestamp
     */
    readonly expirationTime: pulumi.Output<string | undefined>;
    /**
     * Kind of resource
     */
    readonly kind: pulumi.Output<string | undefined>;
    /**
     * Timestamp when the domain was renewed last time
     */
    readonly lastRenewedTime: pulumi.Output<string | undefined>;
    /**
     * Resource Location
     */
    readonly location: pulumi.Output<string>;
    /**
     * All hostnames derived from the domain and assigned to Azure resources
     */
    readonly managedHostNames: pulumi.Output<outputs.domainregistration.v20150801.HostNameResponse[] | undefined>;
    /**
     * Resource Name
     */
    readonly name: pulumi.Output<string | undefined>;
    /**
     * Name servers
     */
    readonly nameServers: pulumi.Output<string[] | undefined>;
    /**
     * If true then domain privacy is enabled for this domain
     */
    readonly privacy: pulumi.Output<boolean | undefined>;
    /**
     * Domain provisioning state
     */
    readonly provisioningState: pulumi.Output<string | undefined>;
    /**
     * If true then Azure can assign this domain to Web Apps. This value will be true if domain registration status is active and it is hosted on name servers Azure has programmatic access to
     */
    readonly readyForDnsRecordManagement: pulumi.Output<boolean | undefined>;
    /**
     * Domain registration status
     */
    readonly registrationStatus: pulumi.Output<string | undefined>;
    /**
     * Resource tags
     */
    readonly tags: pulumi.Output<{
        [key: string]: string;
    } | undefined>;
    /**
     * Resource type
     */
    readonly type: pulumi.Output<string | undefined>;
    /**
     * Create a Domain resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: DomainArgs, opts?: pulumi.CustomResourceOptions);
    constructor(name: string, state: undefined, opts: pulumi.CustomResourceOptions);
}
/**
 * The set of arguments for constructing a Domain resource.
 */
export interface DomainArgs {
    /**
     * If true then domain will renewed automatically
     */
    readonly autoRenew?: pulumi.Input<boolean>;
    /**
     * Legal agreement consent
     */
    readonly consent?: pulumi.Input<inputs.domainregistration.v20150801.DomainPurchaseConsent>;
    /**
     * Admin contact information
     */
    readonly contactAdmin?: pulumi.Input<inputs.domainregistration.v20150801.Contact>;
    /**
     * Billing contact information
     */
    readonly contactBilling?: pulumi.Input<inputs.domainregistration.v20150801.Contact>;
    /**
     * Registrant contact information
     */
    readonly contactRegistrant?: pulumi.Input<inputs.domainregistration.v20150801.Contact>;
    /**
     * Technical contact information
     */
    readonly contactTech?: pulumi.Input<inputs.domainregistration.v20150801.Contact>;
    /**
     * Domain creation timestamp
     */
    readonly createdTime?: pulumi.Input<string>;
    /**
     * Name of the domain
     */
    readonly domainName: pulumi.Input<string>;
    /**
     * Reasons why domain is not renewable
     */
    readonly domainNotRenewableReasons?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Domain expiration timestamp
     */
    readonly expirationTime?: pulumi.Input<string>;
    /**
     * Resource Id
     */
    readonly id?: pulumi.Input<string>;
    /**
     * Kind of resource
     */
    readonly kind?: pulumi.Input<string>;
    /**
     * Timestamp when the domain was renewed last time
     */
    readonly lastRenewedTime?: pulumi.Input<string>;
    /**
     * Resource Location
     */
    readonly location: pulumi.Input<string>;
    /**
     * All hostnames derived from the domain and assigned to Azure resources
     */
    readonly managedHostNames?: pulumi.Input<pulumi.Input<inputs.domainregistration.v20150801.HostName>[]>;
    /**
     * Resource Name
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Name servers
     */
    readonly nameServers?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * If true then domain privacy is enabled for this domain
     */
    readonly privacy?: pulumi.Input<boolean>;
    /**
     * Domain provisioning state
     */
    readonly provisioningState?: pulumi.Input<string>;
    /**
     * If true then Azure can assign this domain to Web Apps. This value will be true if domain registration status is active and it is hosted on name servers Azure has programmatic access to
     */
    readonly readyForDnsRecordManagement?: pulumi.Input<boolean>;
    /**
     * Domain registration status
     */
    readonly registrationStatus?: pulumi.Input<string>;
    /**
     * &gt;Name of the resource group
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Resource tags
     */
    readonly tags?: pulumi.Input<{
        [key: string]: pulumi.Input<string>;
    }>;
    /**
     * Resource type
     */
    readonly type?: pulumi.Input<string>;
}