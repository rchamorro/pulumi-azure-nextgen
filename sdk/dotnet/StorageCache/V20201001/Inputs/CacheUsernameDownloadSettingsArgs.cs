// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.StorageCache.V20201001.Inputs
{

    /// <summary>
    /// Settings for Extended Groups username and group download.
    /// </summary>
    public sealed class CacheUsernameDownloadSettingsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Determines if the certificate should be automatically downloaded. This applies to 'caCertificateURI' only if 'requireValidCertificate' is true.
        /// </summary>
        [Input("autoDownloadCertificate")]
        public Input<bool>? AutoDownloadCertificate { get; set; }

        /// <summary>
        /// The URI of the CA certificate to validate the LDAP secure connection. This field must be populated when 'requireValidCertificate' is set to true.
        /// </summary>
        [Input("caCertificateURI")]
        public Input<string>? CaCertificateURI { get; set; }

        /// <summary>
        /// When present, these are the credentials for the secure LDAP connection.
        /// </summary>
        [Input("credentials")]
        public Input<Inputs.CacheUsernameDownloadSettingsCredentialsArgs>? Credentials { get; set; }

        /// <summary>
        /// Whether or not the LDAP connection should be encrypted.
        /// </summary>
        [Input("encryptLdapConnection")]
        public Input<bool>? EncryptLdapConnection { get; set; }

        /// <summary>
        /// Whether or not Extended Groups is enabled.
        /// </summary>
        [Input("extendedGroupsEnabled")]
        public Input<bool>? ExtendedGroupsEnabled { get; set; }

        /// <summary>
        /// The URI of the file containing group information (in /etc/group file format). This field must be populated when 'usernameSource' is set to 'File'.
        /// </summary>
        [Input("groupFileURI")]
        public Input<string>? GroupFileURI { get; set; }

        /// <summary>
        /// The base distinguished name for the LDAP domain.
        /// </summary>
        [Input("ldapBaseDn")]
        public Input<string>? LdapBaseDn { get; set; }

        /// <summary>
        /// The fully qualified domain name or IP address of the LDAP server to use.
        /// </summary>
        [Input("ldapServer")]
        public Input<string>? LdapServer { get; set; }

        /// <summary>
        /// Determines if the certificates must be validated by a certificate authority. When true, caCertificateURI must be provided.
        /// </summary>
        [Input("requireValidCertificate")]
        public Input<bool>? RequireValidCertificate { get; set; }

        /// <summary>
        /// The URI of the file containing user information (in /etc/passwd file format). This field must be populated when 'usernameSource' is set to 'File'.
        /// </summary>
        [Input("userFileURI")]
        public Input<string>? UserFileURI { get; set; }

        /// <summary>
        /// This setting determines how the cache gets username and group names for clients.
        /// </summary>
        [Input("usernameSource")]
        public InputUnion<string, Pulumi.AzureNextGen.StorageCache.V20201001.UsernameSource>? UsernameSource { get; set; }

        public CacheUsernameDownloadSettingsArgs()
        {
            UsernameSource = "None";
        }
    }
}
