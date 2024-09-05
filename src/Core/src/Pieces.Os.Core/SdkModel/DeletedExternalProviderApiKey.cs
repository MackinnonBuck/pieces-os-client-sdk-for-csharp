/*
 * Pieces Isomorphic OpenAPI
 *
 * Endpoints for Assets, Formats, Users, Asset, Format, User.
 *
 * The version of the OpenAPI document: 1.0
 * Contact: tsavo@pieces.app
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Pieces.Os.Core.Client.OpenAPIDateConverter;

namespace Pieces.Os.Core.SdkModel
{
    /// <summary>
    /// This is the returnable for the \&quot;\&quot;/external_provider/api_key/delete\&quot; endpoint
    /// </summary>
    [DataContract(Name = "DeletedExternalProviderApiKey")]
    public partial class DeletedExternalProviderApiKey : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeletedExternalProviderApiKey" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeletedExternalProviderApiKey() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeletedExternalProviderApiKey" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="metadata">metadata (required).</param>
        public DeletedExternalProviderApiKey(EmbeddedModelSchema schema = default(EmbeddedModelSchema), Auth0UserMetadata metadata = default(Auth0UserMetadata))
        {
            // to ensure "metadata" is required (not null)
            if (metadata == null)
            {
                throw new ArgumentNullException("metadata is a required property for DeletedExternalProviderApiKey and cannot be null");
            }
            this.Metadata = metadata;
            this.Schema = schema;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", IsRequired = true, EmitDefaultValue = true)]
        public Auth0UserMetadata Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeletedExternalProviderApiKey {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

            /// <summary>
            /// To validate all properties of the instance
            /// </summary>
            /// <param name="validationContext">Validation context</param>
            /// <returns>Validation Result</returns>
            IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
            {
            yield break;
        }
    }

}
