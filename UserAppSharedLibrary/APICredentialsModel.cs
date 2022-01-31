using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAppSharedLibrary
{
    public class APICredentialsModel
    {
        /// <summary>
        /// The URL for the API calls.
        /// </summary>
        public string URL { get; set; }

        /// <summary>
        /// The email or username used for authentication.
        /// </summary>
        public string EmailUsername { get; set; }

        /// <summary>
        /// The secret key used for authentication.
        /// </summary>
        public string Key { get; set; }



        /// <summary>
        /// The company ID to query. 
        /// Used by the ITG api.
        /// </summary>
        public int CompanyID { get; set; }

        /// <summary>
        /// The App ID of the O365 app with the required access.
        /// Only used by the O365 / Azure API.
        /// </summary>
        /// <example>922dgs30-9add-48d9-9c59-0e1e704890b3</example>
        public string AppID { get; set; }

        /// <summary>
        /// The Tenant ID of the O365 app with the required access.
        /// Only used by the O365 / Azure API.
        /// </summary>
        /// <example>b40797e5-6420-4a9c-b20b-7a1c16b26b54</example>
        public string TenantID { get; set; }

        /// <summary>
        /// The Organization string of the O365 app with the required access.
        /// Only used by the O365 / Azure API.
        /// </summary>
        /// <example>seatosky.onmicrosoft.com</example>
        public string Organization { get; set; }

        /// <summary>
        /// The Location of the O365 service for use.
        /// Currently only used by the Azure Storage Blob API.
        /// </summary>
        /// <example>westus2</example>
        public string Location { get; set; }

        /// <summary>
        /// The thumbprint of the SSL Certificate associated with the 
        /// O365 app with the required access.
        /// Only used by the O365 / Azure API.
        /// </summary>
        /// <example>1DB7ACA90D851E26A84B24EFA40184162D8</example>
        public string CertificateThumbprint { get; set; }



        /// <summary>
        /// The Resource Group to use for connecting to the Storage Blob.
        /// Only used by the Azure Storage Blob API.
        /// </summary>
        public string ResourceGroup { get; set; }

        /// <summary>
        /// The Storage Account to use for connecting to the Storage Blob.
        /// Only used by the Azure Storage Blob API.
        /// </summary>
        public string StorageAccount { get; set; }

        /// <summary>
        /// The Container to use for connecting to the Storage Blob.
        /// Only used by the Azure Storage Blob API.
        /// </summary>
        public string Container { get; set; }

    }
}
