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
    /// ExportedDatabaseFormat
    /// </summary>
    [DataContract(Name = "ExportedDatabaseFormat")]
    public partial class ExportedDatabaseFormat : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExportedDatabaseFormat" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExportedDatabaseFormat() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExportedDatabaseFormat" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="id">this is the id of the format (required).</param>
        /// <param name="raw">these are bytes. (required).</param>
        public ExportedDatabaseFormat(EmbeddedModelSchema schema = default(EmbeddedModelSchema), string id = default(string), List<int> raw = default(List<int>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for ExportedDatabaseFormat and cannot be null");
            }
            this.Id = id;
            // to ensure "raw" is required (not null)
            if (raw == null)
            {
                throw new ArgumentNullException("raw is a required property for ExportedDatabaseFormat and cannot be null");
            }
            this.Raw = raw;
            this.Schema = schema;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// this is the id of the format
        /// </summary>
        /// <value>this is the id of the format</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// these are bytes.
        /// </summary>
        /// <value>these are bytes.</value>
        [DataMember(Name = "raw", IsRequired = true, EmitDefaultValue = true)]
        public List<int> Raw { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ExportedDatabaseFormat {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Raw: ").Append(Raw).Append("\n");
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
