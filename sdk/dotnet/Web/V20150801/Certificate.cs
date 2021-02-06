// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20150801
{
    /// <summary>
    /// App certificate
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:web/v20150801:Certificate")]
    public partial class Certificate : Pulumi.CustomResource
    {
        /// <summary>
        /// Raw bytes of .cer file
        /// </summary>
        [Output("cerBlob")]
        public Output<string?> CerBlob { get; private set; } = null!;

        /// <summary>
        /// Certificate expiration date
        /// </summary>
        [Output("expirationDate")]
        public Output<string?> ExpirationDate { get; private set; } = null!;

        /// <summary>
        /// Friendly name of the certificate
        /// </summary>
        [Output("friendlyName")]
        public Output<string?> FriendlyName { get; private set; } = null!;

        /// <summary>
        /// Host names the certificate applies to
        /// </summary>
        [Output("hostNames")]
        public Output<ImmutableArray<string>> HostNames { get; private set; } = null!;

        /// <summary>
        /// Specification for the hosting environment (App Service Environment) to use for the certificate
        /// </summary>
        [Output("hostingEnvironmentProfile")]
        public Output<Outputs.HostingEnvironmentProfileResponse?> HostingEnvironmentProfile { get; private set; } = null!;

        /// <summary>
        /// Certificate issue Date
        /// </summary>
        [Output("issueDate")]
        public Output<string?> IssueDate { get; private set; } = null!;

        /// <summary>
        /// Certificate issuer
        /// </summary>
        [Output("issuer")]
        public Output<string?> Issuer { get; private set; } = null!;

        /// <summary>
        /// Kind of resource
        /// </summary>
        [Output("kind")]
        public Output<string?> Kind { get; private set; } = null!;

        /// <summary>
        /// Resource Location
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// Resource Name
        /// </summary>
        [Output("name")]
        public Output<string?> Name { get; private set; } = null!;

        /// <summary>
        /// Certificate password
        /// </summary>
        [Output("password")]
        public Output<string?> Password { get; private set; } = null!;

        /// <summary>
        /// Pfx blob
        /// </summary>
        [Output("pfxBlob")]
        public Output<string?> PfxBlob { get; private set; } = null!;

        /// <summary>
        /// Public key hash
        /// </summary>
        [Output("publicKeyHash")]
        public Output<string?> PublicKeyHash { get; private set; } = null!;

        /// <summary>
        /// Self link
        /// </summary>
        [Output("selfLink")]
        public Output<string?> SelfLink { get; private set; } = null!;

        /// <summary>
        /// App name
        /// </summary>
        [Output("siteName")]
        public Output<string?> SiteName { get; private set; } = null!;

        /// <summary>
        /// Subject name of the certificate
        /// </summary>
        [Output("subjectName")]
        public Output<string?> SubjectName { get; private set; } = null!;

        /// <summary>
        /// Resource tags
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// Certificate thumbprint
        /// </summary>
        [Output("thumbprint")]
        public Output<string?> Thumbprint { get; private set; } = null!;

        /// <summary>
        /// Resource type
        /// </summary>
        [Output("type")]
        public Output<string?> Type { get; private set; } = null!;

        /// <summary>
        /// Is the certificate valid?
        /// </summary>
        [Output("valid")]
        public Output<bool?> Valid { get; private set; } = null!;


        /// <summary>
        /// Create a Certificate resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Certificate(string name, CertificateArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:web/v20150801:Certificate", name, args ?? new CertificateArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Certificate(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:web/v20150801:Certificate", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:web/latest:Certificate"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20160301:Certificate"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20180201:Certificate"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20181101:Certificate"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20190801:Certificate"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20200601:Certificate"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20200901:Certificate"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Certificate resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Certificate Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Certificate(name, id, options);
        }
    }

    public sealed class CertificateArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Raw bytes of .cer file
        /// </summary>
        [Input("cerBlob")]
        public Input<string>? CerBlob { get; set; }

        /// <summary>
        /// Certificate expiration date
        /// </summary>
        [Input("expirationDate")]
        public Input<string>? ExpirationDate { get; set; }

        /// <summary>
        /// Friendly name of the certificate
        /// </summary>
        [Input("friendlyName")]
        public Input<string>? FriendlyName { get; set; }

        [Input("hostNames")]
        private InputList<string>? _hostNames;

        /// <summary>
        /// Host names the certificate applies to
        /// </summary>
        public InputList<string> HostNames
        {
            get => _hostNames ?? (_hostNames = new InputList<string>());
            set => _hostNames = value;
        }

        /// <summary>
        /// Specification for the hosting environment (App Service Environment) to use for the certificate
        /// </summary>
        [Input("hostingEnvironmentProfile")]
        public Input<Inputs.HostingEnvironmentProfileArgs>? HostingEnvironmentProfile { get; set; }

        /// <summary>
        /// Resource Id
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// Certificate issue Date
        /// </summary>
        [Input("issueDate")]
        public Input<string>? IssueDate { get; set; }

        /// <summary>
        /// Certificate issuer
        /// </summary>
        [Input("issuer")]
        public Input<string>? Issuer { get; set; }

        /// <summary>
        /// Kind of resource
        /// </summary>
        [Input("kind")]
        public Input<string>? Kind { get; set; }

        /// <summary>
        /// Resource Location
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Resource Name
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Certificate password
        /// </summary>
        [Input("password")]
        public Input<string>? Password { get; set; }

        /// <summary>
        /// Pfx blob
        /// </summary>
        [Input("pfxBlob")]
        public Input<string>? PfxBlob { get; set; }

        /// <summary>
        /// Public key hash
        /// </summary>
        [Input("publicKeyHash")]
        public Input<string>? PublicKeyHash { get; set; }

        /// <summary>
        /// Name of the resource group
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Self link
        /// </summary>
        [Input("selfLink")]
        public Input<string>? SelfLink { get; set; }

        /// <summary>
        /// App name
        /// </summary>
        [Input("siteName")]
        public Input<string>? SiteName { get; set; }

        /// <summary>
        /// Subject name of the certificate
        /// </summary>
        [Input("subjectName")]
        public Input<string>? SubjectName { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Resource tags
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        /// <summary>
        /// Certificate thumbprint
        /// </summary>
        [Input("thumbprint")]
        public Input<string>? Thumbprint { get; set; }

        /// <summary>
        /// Resource type
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        /// <summary>
        /// Is the certificate valid?
        /// </summary>
        [Input("valid")]
        public Input<bool>? Valid { get; set; }

        public CertificateArgs()
        {
        }
    }
}
