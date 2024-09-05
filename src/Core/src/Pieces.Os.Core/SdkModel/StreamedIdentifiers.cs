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
    /// This is currently only used within /assets/steam/identifiers &amp;&amp; /conversations/steam/identifiers but can be used with other as well, if we want to expand this class. &amp;&amp; expand the StreamedIdentifier class.
    /// </summary>
    [DataContract(Name = "StreamedIdentifiers")]
    public partial class StreamedIdentifiers : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StreamedIdentifiers" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StreamedIdentifiers() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StreamedIdentifiers" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="iterable">iterable (required).</param>
        public StreamedIdentifiers(EmbeddedModelSchema schema = default(EmbeddedModelSchema), List<StreamedIdentifier> iterable = default(List<StreamedIdentifier>))
        {
            // to ensure "iterable" is required (not null)
            if (iterable == null)
            {
                throw new ArgumentNullException("iterable is a required property for StreamedIdentifiers and cannot be null");
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
        /// Gets or Sets Iterable
        /// </summary>
        [DataMember(Name = "iterable", IsRequired = true, EmitDefaultValue = true)]
        public List<StreamedIdentifier> Iterable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StreamedIdentifiers {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
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
