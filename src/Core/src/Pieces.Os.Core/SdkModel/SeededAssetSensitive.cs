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
    /// This is the seededAssetSensitive, this does not have an id yet as we will add it on the server side.  can optionally pass in our mechanism here, as the default will be manual unless specified.  This is different that hte SeededSensitive as this is pre-before the asset has been created.(but added when the asset is created.
    /// </summary>
    [DataContract(Name = "SeededAssetSensitive")]
    public partial class SeededAssetSensitive : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Mechanism
        /// </summary>
        [DataMember(Name = "mechanism", EmitDefaultValue = false)]
        public MechanismEnum? Mechanism { get; set; }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name = "category", IsRequired = true, EmitDefaultValue = true)]
        public SensitiveCategoryEnum Category { get; set; }

        /// <summary>
        /// Gets or Sets Severity
        /// </summary>
        [DataMember(Name = "severity", IsRequired = true, EmitDefaultValue = true)]
        public SensitiveSeverityEnum Severity { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SeededAssetSensitive" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SeededAssetSensitive() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SeededAssetSensitive" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="text">this is the string representative of the sensative piece of data. (required).</param>
        /// <param name="mechanism">mechanism.</param>
        /// <param name="category">category (required).</param>
        /// <param name="severity">severity (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="description">description (required).</param>
        /// <param name="metadata">metadata.</param>
        public SeededAssetSensitive(EmbeddedModelSchema schema = default(EmbeddedModelSchema), string text = default(string), MechanismEnum? mechanism = default(MechanismEnum?), SensitiveCategoryEnum category = default(SensitiveCategoryEnum), SensitiveSeverityEnum severity = default(SensitiveSeverityEnum), string name = default(string), string description = default(string), SensitiveMetadata metadata = default(SensitiveMetadata))
        {
            // to ensure "text" is required (not null)
            if (text == null)
            {
                throw new ArgumentNullException("text is a required property for SeededAssetSensitive and cannot be null");
            }
            this.Text = text;
            this.Category = category;
            this.Severity = severity;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for SeededAssetSensitive and cannot be null");
            }
            this.Name = name;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for SeededAssetSensitive and cannot be null");
            }
            this.Description = description;
            this.Schema = schema;
            this.Mechanism = mechanism;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// this is the string representative of the sensative piece of data.
        /// </summary>
        /// <value>this is the string representative of the sensative piece of data.</value>
        [DataMember(Name = "text", IsRequired = true, EmitDefaultValue = true)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public SensitiveMetadata Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SeededAssetSensitive {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Mechanism: ").Append(Mechanism).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Severity: ").Append(Severity).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
