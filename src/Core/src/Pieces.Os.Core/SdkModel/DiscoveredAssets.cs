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
    /// This is a plural Model that is used within the bulk upload flow in both cases of a file(&amp;&amp; needing snippitization) as well as if the fragments are passed in and they only need to be clustered.
    /// </summary>
    [DataContract(Name = "DiscoveredAssets")]
    public partial class DiscoveredAssets : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiscoveredAssets" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DiscoveredAssets() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DiscoveredAssets" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="application">application id. (required).</param>
        /// <param name="iterable">This is an iterable of already snippitized snippets that have been clustered.(These are assets that are going to be uploaded or at minimum the assets that we reccommend to upload) (required).</param>
        public DiscoveredAssets(EmbeddedModelSchema schema = default(EmbeddedModelSchema), string application = default(string), List<DiscoveredAsset> iterable = default(List<DiscoveredAsset>))
        {
            // to ensure "application" is required (not null)
            if (application == null)
            {
                throw new ArgumentNullException("application is a required property for DiscoveredAssets and cannot be null");
            }
            this.Application = application;
            // to ensure "iterable" is required (not null)
            if (iterable == null)
            {
                throw new ArgumentNullException("iterable is a required property for DiscoveredAssets and cannot be null");
            }
            this.Iterable = iterable;
            this.Schema = schema;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// application id.
        /// </summary>
        /// <value>application id.</value>
        [DataMember(Name = "application", IsRequired = true, EmitDefaultValue = true)]
        public string Application { get; set; }

        /// <summary>
        /// This is an iterable of already snippitized snippets that have been clustered.(These are assets that are going to be uploaded or at minimum the assets that we reccommend to upload)
        /// </summary>
        /// <value>This is an iterable of already snippitized snippets that have been clustered.(These are assets that are going to be uploaded or at minimum the assets that we reccommend to upload)</value>
        [DataMember(Name = "iterable", IsRequired = true, EmitDefaultValue = true)]
        public List<DiscoveredAsset> Iterable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DiscoveredAssets {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Application: ").Append(Application).Append("\n");
            sb.Append("  Iterable: ").Append(Iterable).Append("\n");
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
