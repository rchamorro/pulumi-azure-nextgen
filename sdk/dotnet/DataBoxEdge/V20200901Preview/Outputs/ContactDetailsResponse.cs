// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataBoxEdge.V20200901Preview.Outputs
{

    [OutputType]
    public sealed class ContactDetailsResponse
    {
        /// <summary>
        /// The name of the company.
        /// </summary>
        public readonly string CompanyName;
        /// <summary>
        /// The contact person name.
        /// </summary>
        public readonly string ContactPerson;
        /// <summary>
        /// The email list.
        /// </summary>
        public readonly ImmutableArray<string> EmailList;
        /// <summary>
        /// The phone number.
        /// </summary>
        public readonly string Phone;

        [OutputConstructor]
        private ContactDetailsResponse(
            string companyName,

            string contactPerson,

            ImmutableArray<string> emailList,

            string phone)
        {
            CompanyName = companyName;
            ContactPerson = contactPerson;
            EmailList = emailList;
            Phone = phone;
        }
    }
}
