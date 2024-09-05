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
    /// This is a Flattened Version of a Tag.
    /// </summary>
    [DataContract(Name = "FlattenedTag")]
    public partial class FlattenedTag : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name = "category", IsRequired = true, EmitDefaultValue = true)]
        public TagCategoryEnum Category { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FlattenedTag" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FlattenedTag() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FlattenedTag" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="id">id (required).</param>
        /// <param name="text">text (required).</param>
        /// <param name="mechanisms">This is a Map&lt;String, MechanismEnum&gt; where the the key is an asset id..</param>
        /// <param name="assets">assets.</param>
        /// <param name="created">created (required).</param>
        /// <param name="updated">updated (required).</param>
        /// <param name="deleted">deleted.</param>
        /// <param name="category">category (required).</param>
        /// <param name="relationship">relationship.</param>
        /// <param name="interactions">This is an optional value that will keep track of the number of times this has been interacted with..</param>
        /// <param name="persons">persons.</param>
        /// <param name="score">score.</param>
        public FlattenedTag(EmbeddedModelSchema schema = default(EmbeddedModelSchema), string id = default(string), string text = default(string), Dictionary<string, MechanismEnum> mechanisms = default(Dictionary<string, MechanismEnum>), FlattenedAssets assets = default(FlattenedAssets), GroupedTimestamp created = default(GroupedTimestamp), GroupedTimestamp updated = default(GroupedTimestamp), GroupedTimestamp deleted = default(GroupedTimestamp), TagCategoryEnum category = default(TagCategoryEnum), Relationship relationship = default(Relationship), int interactions = default(int), FlattenedPersons persons = default(FlattenedPersons), Score score = default(Score))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for FlattenedTag and cannot be null");
            }
            this.Id = id;
            // to ensure "text" is required (not null)
            if (text == null)
            {
                throw new ArgumentNullException("text is a required property for FlattenedTag and cannot be null");
            }
            this.Text = text;
            // to ensure "created" is required (not null)
            if (created == null)
            {
                throw new ArgumentNullException("created is a required property for FlattenedTag and cannot be null");
            }
            this.Created = created;
            // to ensure "updated" is required (not null)
            if (updated == null)
            {
                throw new ArgumentNullException("updated is a required property for FlattenedTag and cannot be null");
            }
            this.Updated = updated;
            this.Category = category;
            this.Schema = schema;
            this.Mechanisms = mechanisms;
            this.Assets = assets;
            this.Deleted = deleted;
            this.Relationship = relationship;
            this.Interactions = interactions;
            this.Persons = persons;
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
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name = "text", IsRequired = true, EmitDefaultValue = true)]
        public string Text { get; set; }

        /// <summary>
        /// This is a Map&lt;String, MechanismEnum&gt; where the the key is an asset id.
        /// </summary>
        /// <value>This is a Map&lt;String, MechanismEnum&gt; where the the key is an asset id.</value>
        [DataMember(Name = "mechanisms", EmitDefaultValue = false)]
        public Dictionary<string, MechanismEnum> Mechanisms { get; set; }

        /// <summary>
        /// Gets or Sets Assets
        /// </summary>
        [DataMember(Name = "assets", EmitDefaultValue = false)]
        public FlattenedAssets Assets { get; set; }

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
        /// Gets or Sets Relationship
        /// </summary>
        [DataMember(Name = "relationship", EmitDefaultValue = false)]
        public Relationship Relationship { get; set; }

        /// <summary>
        /// This is an optional value that will keep track of the number of times this has been interacted with.
        /// </summary>
        /// <value>This is an optional value that will keep track of the number of times this has been interacted with.</value>
        [DataMember(Name = "interactions", EmitDefaultValue = false)]
        public int Interactions { get; set; }

        /// <summary>
        /// Gets or Sets Persons
        /// </summary>
        [DataMember(Name = "persons", EmitDefaultValue = false)]
        public FlattenedPersons Persons { get; set; }

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
            sb.Append("class FlattenedTag {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Mechanisms: ").Append(Mechanisms).Append("\n");
            sb.Append("  Assets: ").Append(Assets).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Relationship: ").Append(Relationship).Append("\n");
            sb.Append("  Interactions: ").Append(Interactions).Append("\n");
            sb.Append("  Persons: ").Append(Persons).Append("\n");
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
