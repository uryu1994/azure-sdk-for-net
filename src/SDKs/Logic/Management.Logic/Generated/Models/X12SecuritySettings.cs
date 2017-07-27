// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using Azure;
    using Management;
    using Logic;
    using Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The X12 agreement security settings.
    /// </summary>
    public partial class X12SecuritySettings
    {
        /// <summary>
        /// Initializes a new instance of the X12SecuritySettings class.
        /// </summary>
        public X12SecuritySettings() { }

        /// <summary>
        /// Initializes a new instance of the X12SecuritySettings class.
        /// </summary>
        /// <param name="authorizationQualifier">The authorization
        /// qualifier.</param>
        /// <param name="securityQualifier">The security qualifier.</param>
        /// <param name="authorizationValue">The authorization value.</param>
        /// <param name="passwordValue">The password value.</param>
        public X12SecuritySettings(string authorizationQualifier, string securityQualifier, string authorizationValue = default(string), string passwordValue = default(string))
        {
            AuthorizationQualifier = authorizationQualifier;
            AuthorizationValue = authorizationValue;
            SecurityQualifier = securityQualifier;
            PasswordValue = passwordValue;
        }

        /// <summary>
        /// Gets or sets the authorization qualifier.
        /// </summary>
        [JsonProperty(PropertyName = "authorizationQualifier")]
        public string AuthorizationQualifier { get; set; }

        /// <summary>
        /// Gets or sets the authorization value.
        /// </summary>
        [JsonProperty(PropertyName = "authorizationValue")]
        public string AuthorizationValue { get; set; }

        /// <summary>
        /// Gets or sets the security qualifier.
        /// </summary>
        [JsonProperty(PropertyName = "securityQualifier")]
        public string SecurityQualifier { get; set; }

        /// <summary>
        /// Gets or sets the password value.
        /// </summary>
        [JsonProperty(PropertyName = "passwordValue")]
        public string PasswordValue { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AuthorizationQualifier == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AuthorizationQualifier");
            }
            if (SecurityQualifier == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SecurityQualifier");
            }
        }
    }
}
