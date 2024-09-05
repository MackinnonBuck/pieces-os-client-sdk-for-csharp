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
    /// This is a dereferenced representation of a sensitive pieces of data.
    /// </summary>
    [DataContract(Name = "FlattenedSensitive")]
    public partial class FlattenedSensitive : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Mechanism
        /// </summary>
        [DataMember(Name = "mechanism", IsRequired = true, EmitDefaultValue = true)]
        public MechanismEnum Mechanism { get; set; }

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
        /// Initializes a new instance of the <see cref="FlattenedSensitive" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FlattenedSensitive() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FlattenedSensitive" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="id">id (required).</param>
        /// <param name="created">created (required).</param>
        /// <param name="updated">updated (required).</param>
        /// <param name="deleted">deleted.</param>
        /// <param name="asset">asset (required).</param>
        /// <param name="text">text (required).</param>
        /// <param name="mechanism">mechanism (required).</param>
        /// <param name="category">category (required).</param>
        /// <param name="severity">severity (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="description">description (required).</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="interactions">This is an optional value that will keep track of the number of times this has been interacted with..</param>
        /// <param name="score">score.</param>
        public FlattenedSensitive(EmbeddedModelSchema schema = default(EmbeddedModelSchema), string id = default(string), GroupedTimestamp created = default(GroupedTimestamp), GroupedTimestamp updated = default(GroupedTimestamp), GroupedTimestamp deleted = default(GroupedTimestamp), ReferencedAsset asset = default(ReferencedAsset), string text = default(string), MechanismEnum mechanism = default(MechanismEnum), SensitiveCategoryEnum category = default(SensitiveCategoryEnum), SensitiveSeverityEnum severity = default(SensitiveSeverityEnum), string name = default(string), string description = default(string), SensitiveMetadata metadata = default(SensitiveMetadata), int interactions = default(int), Score score = default(Score))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for FlattenedSensitive and cannot be null");
            }
            this.Id = id;
            // to ensure "created" is required (not null)
            if (created == null)
            {
                throw new ArgumentNullException("created is a required property for FlattenedSensitive and cannot be null");
            }
            this.Created = created;
            // to ensure "updated" is required (not null)
            if (updated == null)
            {
                throw new ArgumentNullException("updated is a required property for FlattenedSensitive and cannot be null");
            }
            this.Updated = updated;
            // to ensure "asset" is required (not null)
            if (asset == null)
            {
                throw new ArgumentNullException("asset is a required property for FlattenedSensitive and cannot be null");
            }
            this.Asset = asset;
            // to ensure "text" is required (not null)
            if (text == null)
            {
                throw new ArgumentNullException("text is a required property for FlattenedSensitive and cannot be null");
            }
            this.Text = text;
            this.Mechanism = mechanism;
            this.Category = category;
            this.Severity = severity;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for FlattenedSensitive and cannot be null");
            }
            this.Name = name;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for FlattenedSensitive and cannot be null");
            }
            this.Description = description;
            this.Schema = schema;
            this.Deleted = deleted;
            this.Metadata = metadata;
            this.Interactions = interactions;
            this.Score = score;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name = "created", IsRequired = true, EmitDefaultValue = true)]
        public GroupedTimestamp Created { get; set; }

        /// <summary>
        /// Gets or Sets Updated
        /// </summary>
        [DataMember(Name = "updated", IsRequired = true, EmitDefaultValue = true)]
        public GroupedTimestamp Updated { get; set; }

        /// <summary>
        /// Gets or Sets Deleted
        /// </summary>
        [DataMember(Name = "deleted", EmitDefaultValue = false)]
        public GroupedTimestamp Deleted { get; set; }

        /// <summary>
        /// Gets or Sets Asset
        /// </summary>
        [DataMember(Name = "asset", IsRequired = true, EmitDefaultValue = true)]
        public ReferencedAsset Asset { get; set; }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
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
        /// This is an optional value that will keep track of the number of times this has been interacted with.
        /// </summary>
        /// <value>This is an optional value that will keep track of the number of times this has been interacted with.</value>
        [DataMember(Name = "interactions", EmitDefaultValue = false)]
        public int Interactions { get; set; }

        /// <summary>
        /// Gets or Sets Score
        /// </summary>
        [DataMember(Name = "score", EmitDefaultValue = false)]
        public Score Score { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FlattenedSensitive {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  Asset: ").Append(Asset).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Mechanism: ").Append(Mechanism).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Severity: ").Append(Severity).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Interactions: ").Append(Interactions).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
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
