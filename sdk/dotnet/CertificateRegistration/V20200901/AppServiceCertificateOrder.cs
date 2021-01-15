// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.CertificateRegistration.V20200901
{
    /// <summary>
    /// SSL certificate purchase order.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:certificateregistration/v20200901:AppServiceCertificateOrder")]
    public partial class AppServiceCertificateOrder : Pulumi.CustomResource
    {
        /// <summary>
        /// Reasons why App Service Certificate is not renewable at the current moment.
        /// </summary>
        [Output("appServiceCertificateNotRenewableReasons")]
        public Output<ImmutableArray<string>> AppServiceCertificateNotRenewableReasons { get; private set; } = null!;

        /// <summary>
        /// &lt;code&gt;true&lt;/code&gt; if the certificate should be automatically renewed when it expires; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// </summary>
        [Output("autoRenew")]
        public Output<bool?> AutoRenew { get; private set; } = null!;

        /// <summary>
        /// State of the Key Vault secret.
        /// </summary>
        [Output("certificates")]
        public Output<ImmutableDictionary<string, Outputs.AppServiceCertificateResponse>?> Certificates { get; private set; } = null!;

        /// <summary>
        /// Last CSR that was created for this order.
        /// </summary>
        [Output("csr")]
        public Output<string?> Csr { get; private set; } = null!;

        /// <summary>
        /// Certificate distinguished name.
        /// </summary>
        [Output("distinguishedName")]
        public Output<string?> DistinguishedName { get; private set; } = null!;

        /// <summary>
        /// Domain verification token.
        /// </summary>
        [Output("domainVerificationToken")]
        public Output<string> DomainVerificationToken { get; private set; } = null!;

        /// <summary>
        /// Certificate expiration time.
        /// </summary>
        [Output("expirationTime")]
        public Output<string> ExpirationTime { get; private set; } = null!;

        /// <summary>
        /// Intermediate certificate.
        /// </summary>
        [Output("intermediate")]
        public Output<Outputs.CertificateDetailsResponse> Intermediate { get; private set; } = null!;

        /// <summary>
        /// &lt;code&gt;true&lt;/code&gt; if private key is external; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// </summary>
        [Output("isPrivateKeyExternal")]
        public Output<bool> IsPrivateKeyExternal { get; private set; } = null!;

        /// <summary>
        /// Certificate key size.
        /// </summary>
        [Output("keySize")]
        public Output<int?> KeySize { get; private set; } = null!;

        /// <summary>
        /// Kind of resource.
        /// </summary>
        [Output("kind")]
        public Output<string?> Kind { get; private set; } = null!;

        /// <summary>
        /// Certificate last issuance time.
        /// </summary>
        [Output("lastCertificateIssuanceTime")]
        public Output<string> LastCertificateIssuanceTime { get; private set; } = null!;

        /// <summary>
        /// Resource Location.
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// Resource Name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Time stamp when the certificate would be auto renewed next
        /// </summary>
        [Output("nextAutoRenewalTimeStamp")]
        public Output<string> NextAutoRenewalTimeStamp { get; private set; } = null!;

        /// <summary>
        /// Certificate product type.
        /// </summary>
        [Output("productType")]
        public Output<string> ProductType { get; private set; } = null!;

        /// <summary>
        /// Status of certificate order.
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// Root certificate.
        /// </summary>
        [Output("root")]
        public Output<Outputs.CertificateDetailsResponse> Root { get; private set; } = null!;

        /// <summary>
        /// Current serial number of the certificate.
        /// </summary>
        [Output("serialNumber")]
        public Output<string> SerialNumber { get; private set; } = null!;

        /// <summary>
        /// Signed certificate.
        /// </summary>
        [Output("signedCertificate")]
        public Output<Outputs.CertificateDetailsResponse> SignedCertificate { get; private set; } = null!;

        /// <summary>
        /// Current order status.
        /// </summary>
        [Output("status")]
        public Output<string> Status { get; private set; } = null!;

        /// <summary>
        /// The system metadata relating to this resource.
        /// </summary>
        [Output("systemData")]
        public Output<Outputs.SystemDataResponse> SystemData { get; private set; } = null!;

        /// <summary>
        /// Resource tags.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// Resource type.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        /// <summary>
        /// Duration in years (must be between 1 and 3).
        /// </summary>
        [Output("validityInYears")]
        public Output<int?> ValidityInYears { get; private set; } = null!;


        /// <summary>
        /// Create a AppServiceCertificateOrder resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public AppServiceCertificateOrder(string name, AppServiceCertificateOrderArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:certificateregistration/v20200901:AppServiceCertificateOrder", name, args ?? new AppServiceCertificateOrderArgs(), MakeResourceOptions(options, ""))
        {
        }

        private AppServiceCertificateOrder(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:certificateregistration/v20200901:AppServiceCertificateOrder", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:certificateregistration/latest:AppServiceCertificateOrder"},
                    new Pulumi.Alias { Type = "azure-nextgen:certificateregistration/v20150801:AppServiceCertificateOrder"},
                    new Pulumi.Alias { Type = "azure-nextgen:certificateregistration/v20180201:AppServiceCertificateOrder"},
                    new Pulumi.Alias { Type = "azure-nextgen:certificateregistration/v20190801:AppServiceCertificateOrder"},
                    new Pulumi.Alias { Type = "azure-nextgen:certificateregistration/v20200601:AppServiceCertificateOrder"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing AppServiceCertificateOrder resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static AppServiceCertificateOrder Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new AppServiceCertificateOrder(name, id, options);
        }
    }

    public sealed class AppServiceCertificateOrderArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// &lt;code&gt;true&lt;/code&gt; if the certificate should be automatically renewed when it expires; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// </summary>
        [Input("autoRenew")]
        public Input<bool>? AutoRenew { get; set; }

        /// <summary>
        /// Name of the certificate order.
        /// </summary>
        [Input("certificateOrderName", required: true)]
        public Input<string> CertificateOrderName { get; set; } = null!;

        [Input("certificates")]
        private InputMap<Inputs.AppServiceCertificateArgs>? _certificates;

        /// <summary>
        /// State of the Key Vault secret.
        /// </summary>
        public InputMap<Inputs.AppServiceCertificateArgs> Certificates
        {
            get => _certificates ?? (_certificates = new InputMap<Inputs.AppServiceCertificateArgs>());
            set => _certificates = value;
        }

        /// <summary>
        /// Last CSR that was created for this order.
        /// </summary>
        [Input("csr")]
        public Input<string>? Csr { get; set; }

        /// <summary>
        /// Certificate distinguished name.
        /// </summary>
        [Input("distinguishedName")]
        public Input<string>? DistinguishedName { get; set; }

        /// <summary>
        /// Certificate key size.
        /// </summary>
        [Input("keySize")]
        public Input<int>? KeySize { get; set; }

        /// <summary>
        /// Kind of resource.
        /// </summary>
        [Input("kind")]
        public Input<string>? Kind { get; set; }

        /// <summary>
        /// Resource Location.
        /// </summary>
        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        /// <summary>
        /// Certificate product type.
        /// </summary>
        [Input("productType", required: true)]
        public Input<Pulumi.AzureNextGen.CertificateRegistration.V20200901.CertificateProductType> ProductType { get; set; } = null!;

        /// <summary>
        /// Name of the resource group to which the resource belongs.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Resource tags.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        /// <summary>
        /// Duration in years (must be between 1 and 3).
        /// </summary>
        [Input("validityInYears")]
        public Input<int>? ValidityInYears { get; set; }

        public AppServiceCertificateOrderArgs()
        {
            AutoRenew = true;
            KeySize = 2048;
            ValidityInYears = 1;
        }
    }
}
