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
    /// This is a flattened DAG safe version of a ConversationMessage.
    /// </summary>
    [DataContract(Name = "FlattenedConversationMessage")]
    public partial class FlattenedConversationMessage : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Sentiment
        /// </summary>
        [DataMember(Name = "sentiment", EmitDefaultValue = false)]
        public ConversationMessageSentimentEnum? Sentiment { get; set; }

        /// <summary>
        /// Gets or Sets Role
        /// </summary>
        [DataMember(Name = "role", IsRequired = true, EmitDefaultValue = true)]
        public QGPTConversationMessageRoleEnum Role { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FlattenedConversationMessage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FlattenedConversationMessage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FlattenedConversationMessage" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="id">id (required).</param>
        /// <param name="created">created (required).</param>
        /// <param name="updated">updated (required).</param>
        /// <param name="deleted">deleted.</param>
        /// <param name="model">model.</param>
        /// <param name="fragment">fragment.</param>
        /// <param name="conversation">conversation (required).</param>
        /// <param name="sentiment">sentiment.</param>
        /// <param name="role">role (required).</param>
        /// <param name="score">score.</param>
        /// <param name="annotations">annotations.</param>
        /// <param name="anchors">anchors.</param>
        /// <param name="persons">persons.</param>
        /// <param name="websites">websites.</param>
        public FlattenedConversationMessage(EmbeddedModelSchema schema = default(EmbeddedModelSchema), string id = default(string), GroupedTimestamp created = default(GroupedTimestamp), GroupedTimestamp updated = default(GroupedTimestamp), GroupedTimestamp deleted = default(GroupedTimestamp), Model model = default(Model), FragmentFormat fragment = default(FragmentFormat), ReferencedConversation conversation = default(ReferencedConversation), ConversationMessageSentimentEnum? sentiment = default(ConversationMessageSentimentEnum?), QGPTConversationMessageRoleEnum role = default(QGPTConversationMessageRoleEnum), Score score = default(Score), FlattenedAnnotations annotations = default(FlattenedAnnotations), FlattenedAnchors anchors = default(FlattenedAnchors), FlattenedPersons persons = default(FlattenedPersons), FlattenedWebsites websites = default(FlattenedWebsites))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for FlattenedConversationMessage and cannot be null");
            }
            this.Id = id;
            // to ensure "created" is required (not null)
            if (created == null)
            {
                throw new ArgumentNullException("created is a required property for FlattenedConversationMessage and cannot be null");
            }
            this.Created = created;
            // to ensure "updated" is required (not null)
            if (updated == null)
            {
                throw new ArgumentNullException("updated is a required property for FlattenedConversationMessage and cannot be null");
            }
            this.Updated = updated;
            // to ensure "conversation" is required (not null)
            if (conversation == null)
            {
                throw new ArgumentNullException("conversation is a required property for FlattenedConversationMessage and cannot be null");
            }
            this.Conversation = conversation;
            this.Role = role;
            this.Schema = schema;
            this.Deleted = deleted;
            this.Model = model;
            this.Fragment = fragment;
            this.Sentiment = sentiment;
            this.Score = score;
            this.Annotations = annotations;
            this.Anchors = anchors;
            this.Persons = persons;
            this.Websites = websites;
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
        /// Gets or Sets Model
        /// </summary>
        [DataMember(Name = "model", EmitDefaultValue = false)]
        public Model Model { get; set; }

        /// <summary>
        /// Gets or Sets Fragment
        /// </summary>
        [DataMember(Name = "fragment", EmitDefaultValue = false)]
        public FragmentFormat Fragment { get; set; }

        /// <summary>
        /// Gets or Sets Conversation
        /// </summary>
        [DataMember(Name = "conversation", IsRequired = true, EmitDefaultValue = true)]
        public ReferencedConversation Conversation { get; set; }

        /// <summary>
        /// Gets or Sets Score
        /// </summary>
        [DataMember(Name = "score", EmitDefaultValue = false)]
        public Score Score { get; set; }

        /// <summary>
        /// Gets or Sets Annotations
        /// </summary>
        [DataMember(Name = "annotations", EmitDefaultValue = false)]
        public FlattenedAnnotations Annotations { get; set; }

        /// <summary>
        /// Gets or Sets Anchors
        /// </summary>
        [DataMember(Name = "anchors", EmitDefaultValue = false)]
        public FlattenedAnchors Anchors { get; set; }

        /// <summary>
        /// Gets or Sets Persons
        /// </summary>
        [DataMember(Name = "persons", EmitDefaultValue = false)]
        public FlattenedPersons Persons { get; set; }

        /// <summary>
        /// Gets or Sets Websites
        /// </summary>
        [DataMember(Name = "websites", EmitDefaultValue = false)]
        public FlattenedWebsites Websites { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FlattenedConversationMessage {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  Fragment: ").Append(Fragment).Append("\n");
            sb.Append("  Conversation: ").Append(Conversation).Append("\n");
            sb.Append("  Sentiment: ").Append(Sentiment).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("  Anchors: ").Append(Anchors).Append("\n");
            sb.Append("  Persons: ").Append(Persons).Append("\n");
            sb.Append("  Websites: ").Append(Websites).Append("\n");
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
