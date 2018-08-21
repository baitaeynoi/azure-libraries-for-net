// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.BatchAI.Fluent.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Credentials to access a container image in a private repository.
    /// </summary>
    public partial class PrivateRegistryCredentials
    {
        /// <summary>
        /// Initializes a new instance of the PrivateRegistryCredentials class.
        /// </summary>
        public PrivateRegistryCredentials()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PrivateRegistryCredentials class.
        /// </summary>
        /// <param name="username">User name.</param>
        /// <param name="password">Password.</param>
        /// <param name="passwordSecretReference">Password secret
        /// reference.</param>
        public PrivateRegistryCredentials(string username, string password = default(string), KeyVaultSecretReference passwordSecretReference = default(KeyVaultSecretReference))
        {
            Username = username;
            Password = password;
            PasswordSecretReference = passwordSecretReference;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets user name.
        /// </summary>
        /// <remarks>
        /// User name to login to the repository.
        /// </remarks>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets password.
        /// </summary>
        /// <remarks>
        /// User password to login to the docker repository. One of password or
        /// passwordSecretReference must be specified.
        /// </remarks>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets password secret reference.
        /// </summary>
        /// <remarks>
        /// KeyVault Secret storing the password. Users can store their secrets
        /// in Azure KeyVault and pass it to the Batch AI service to integrate
        /// with KeyVault. One of password or passwordSecretReference must be
        /// specified.
        /// </remarks>
        [JsonProperty(PropertyName = "passwordSecretReference")]
        public KeyVaultSecretReference PasswordSecretReference { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Username == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Username");
            }
            if (PasswordSecretReference != null)
            {
                PasswordSecretReference.Validate();
            }
        }
    }
}
