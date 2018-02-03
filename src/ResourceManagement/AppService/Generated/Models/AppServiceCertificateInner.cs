// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Key Vault container for a certificate that is purchased through Azure.
    /// </summary>
    public partial class AppServiceCertificateInner
    {
        /// <summary>
        /// Initializes a new instance of the AppServiceCertificateInner class.
        /// </summary>
        public AppServiceCertificateInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AppServiceCertificateInner class.
        /// </summary>
        /// <param name="keyVaultId">Key Vault resource Id.</param>
        /// <param name="keyVaultSecretName">Key Vault secret name.</param>
        /// <param name="provisioningState">Status of the Key Vault secret.
        /// Possible values include: 'Initialized',
        /// 'WaitingOnCertificateOrder', 'Succeeded', 'CertificateOrderFailed',
        /// 'OperationNotPermittedOnKeyVault',
        /// 'AzureServiceUnauthorizedToAccessKeyVault', 'KeyVaultDoesNotExist',
        /// 'KeyVaultSecretDoesNotExist', 'UnknownError', 'ExternalPrivateKey',
        /// 'Unknown'</param>
        public AppServiceCertificateInner(string keyVaultId = default(string), string keyVaultSecretName = default(string), KeyVaultSecretStatus? provisioningState = default(KeyVaultSecretStatus?))
        {
            KeyVaultId = keyVaultId;
            KeyVaultSecretName = keyVaultSecretName;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets key Vault resource Id.
        /// </summary>
        [JsonProperty(PropertyName = "keyVaultId")]
        public string KeyVaultId { get; set; }

        /// <summary>
        /// Gets or sets key Vault secret name.
        /// </summary>
        [JsonProperty(PropertyName = "keyVaultSecretName")]
        public string KeyVaultSecretName { get; set; }

        /// <summary>
        /// Gets status of the Key Vault secret. Possible values include:
        /// 'Initialized', 'WaitingOnCertificateOrder', 'Succeeded',
        /// 'CertificateOrderFailed', 'OperationNotPermittedOnKeyVault',
        /// 'AzureServiceUnauthorizedToAccessKeyVault', 'KeyVaultDoesNotExist',
        /// 'KeyVaultSecretDoesNotExist', 'UnknownError', 'ExternalPrivateKey',
        /// 'Unknown'
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public KeyVaultSecretStatus? ProvisioningState { get; private set; }

    }
}