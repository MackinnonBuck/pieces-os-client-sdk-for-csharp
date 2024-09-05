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
    /// An Asset Model representing data extracted from an Application connecting a group of data containing one or more Formats. [DAG Compatible - Directed Acyclic Graph Data Structure]  FlattenedAsset prevent Cycles in Reference because all outbound references are strings as opposed to crosspollinated objects.  i.e. FlattenedFormat.preview is Type String, and FlattenedFormat.original is Type String
    /// </summary>
    [DataContract(Name = "FlattenedAsset")]
    public partial class FlattenedAsset : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Mechanism
        /// </summary>
        [DataMember(Name = "mechanism", IsRequired = true, EmitDefaultValue = true)]
        public MechanismEnum Mechanism { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FlattenedAsset" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FlattenedAsset() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FlattenedAsset" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="id">The globally available UID representing the asset in the Database, both locally and in the cloud. (required).</param>
        /// <param name="name">name.</param>
        /// <param name="creator">creator (required).</param>
        /// <param name="created">created (required).</param>
        /// <param name="updated">updated (required).</param>
        /// <param name="synced">synced.</param>
        /// <param name="deleted">deleted.</param>
        /// <param name="formats">formats (required).</param>
        /// <param name="preview">preview (required).</param>
        /// <param name="original">An identifier of the format that is a reference to the original. (required).</param>
        /// <param name="shares">shares.</param>
        /// <param name="mechanism">mechanism (required).</param>
        /// <param name="websites">websites.</param>
        /// <param name="interacted">interacted.</param>
        /// <param name="tags">tags.</param>
        /// <param name="sensitives">sensitives.</param>
        /// <param name="persons">persons.</param>
        /// <param name="curated">This is an optional boolean that will flag that this asset came from a currated collection..</param>
        /// <param name="discovered">discovered.</param>
        /// <param name="activities">activities.</param>
        /// <param name="score">score.</param>
        /// <param name="favorited">favorited.</param>
        /// <param name="pseudo">pseudo.</param>
        /// <param name="annotations">annotations.</param>
        /// <param name="hints">hints.</param>
        /// <param name="anchors">anchors.</param>
        /// <param name="conversations">conversations.</param>
        /// <param name="demo">This will let us know if this asset was generated as a &#39;demo&#39; snippet.</param>
        /// <param name="summaries">summaries.</param>
        public FlattenedAsset(EmbeddedModelSchema schema = default(EmbeddedModelSchema), string id = default(string), string name = default(string), string creator = default(string), GroupedTimestamp created = default(GroupedTimestamp), GroupedTimestamp updated = default(GroupedTimestamp), GroupedTimestamp synced = default(GroupedTimestamp), GroupedTimestamp deleted = default(GroupedTimestamp), FlattenedFormats formats = default(FlattenedFormats), FlattenedPreview preview = default(FlattenedPreview), string original = default(string), FlattenedShares shares = default(FlattenedShares), MechanismEnum mechanism = default(MechanismEnum), FlattenedWebsites websites = default(FlattenedWebsites), GroupedTimestamp interacted = default(GroupedTimestamp), FlattenedTags tags = default(FlattenedTags), FlattenedSensitives sensitives = default(FlattenedSensitives), FlattenedPersons persons = default(FlattenedPersons), bool curated = default(bool), bool discovered = default(bool), FlattenedActivities activities = default(FlattenedActivities), Score score = default(Score), bool favorited = default(bool), bool pseudo = default(bool), FlattenedAnnotations annotations = default(FlattenedAnnotations), FlattenedHints hints = default(FlattenedHints), FlattenedAnchors anchors = default(FlattenedAnchors), FlattenedConversations conversations = default(FlattenedConversations), bool demo = default(bool), FlattenedWorkstreamSummaries summaries = default(FlattenedWorkstreamSummaries))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for FlattenedAsset and cannot be null");
            }
            this.Id = id;
            // to ensure "creator" is required (not null)
            if (creator == null)
            {
                throw new ArgumentNullException("creator is a required property for FlattenedAsset and cannot be null");
            }
            this.Creator = creator;
            // to ensure "created" is required (not null)
            if (created == null)
            {
                throw new ArgumentNullException("created is a required property for FlattenedAsset and cannot be null");
            }
            this.Created = created;
            // to ensure "updated" is required (not null)
            if (updated == null)
            {
                throw new ArgumentNullException("updated is a required property for FlattenedAsset and cannot be null");
            }
            this.Updated = updated;
            // to ensure "formats" is required (not null)
            if (formats == null)
            {
                throw new ArgumentNullException("formats is a required property for FlattenedAsset and cannot be null");
            }
            this.Formats = formats;
            // to ensure "preview" is required (not null)
            if (preview == null)
            {
                throw new ArgumentNullException("preview is a required property for FlattenedAsset and cannot be null");
            }
            this.Preview = preview;
            // to ensure "original" is required (not null)
            if (original == null)
            {
                throw new ArgumentNullException("original is a required property for FlattenedAsset and cannot be null");
            }
            this.Original = original;
            this.Mechanism = mechanism;
            this.Schema = schema;
            this.Name = name;
            this.Synced = synced;
            this.Deleted = deleted;
            this.Shares = shares;
            this.Websites = websites;
            this.Interacted = interacted;
            this.Tags = tags;
            this.Sensitives = sensitives;
            this.Persons = persons;
            this.Curated = curated;
            this.Discovered = discovered;
            this.Activities = activities;
            this.Score = score;
            this.Favorited = favorited;
            this.Pseudo = pseudo;
            this.Annotations = annotations;
            this.Hints = hints;
            this.Anchors = anchors;
            this.Conversations = conversations;
            this.Demo = demo;
            this.Summaries = summaries;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// The globally available UID representing the asset in the Database, both locally and in the cloud.
        /// </summary>
        /// <value>The globally available UID representing the asset in the Database, both locally and in the cloud.</value>
        /// <example>2254f2c8-5797-40e8-ac56-41166dc0e159</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Creator
        /// </summary>
        /// <example>497f6eca-6276-4993-bfeb-53cbbbba6f08</example>
        [DataMember(Name = "creator", IsRequired = true, EmitDefaultValue = true)]
        public string Creator { get; set; }

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
        /// Gets or Sets Synced
        /// </summary>
        [DataMember(Name = "synced", EmitDefaultValue = false)]
        public GroupedTimestamp Synced { get; set; }

        /// <summary>
        /// Gets or Sets Deleted
        /// </summary>
        [DataMember(Name = "deleted", EmitDefaultValue = false)]
        public GroupedTimestamp Deleted { get; set; }

        /// <summary>
        /// Gets or Sets Formats
        /// </summary>
        [DataMember(Name = "formats", IsRequired = true, EmitDefaultValue = true)]
        public FlattenedFormats Formats { get; set; }

        /// <summary>
        /// Gets or Sets Preview
        /// </summary>
        [DataMember(Name = "preview", IsRequired = true, EmitDefaultValue = true)]
        public FlattenedPreview Preview { get; set; }

        /// <summary>
        /// An identifier of the format that is a reference to the original.
        /// </summary>
        /// <value>An identifier of the format that is a reference to the original.</value>
        /// <example>0872ccbf-1d8f-4f46-9028-469794d72761</example>
        [DataMember(Name = "original", IsRequired = true, EmitDefaultValue = true)]
        public string Original { get; set; }

        /// <summary>
        /// Gets or Sets Shares
        /// </summary>
        [DataMember(Name = "shares", EmitDefaultValue = false)]
        public FlattenedShares Shares { get; set; }

        /// <summary>
        /// Gets or Sets Websites
        /// </summary>
        [DataMember(Name = "websites", EmitDefaultValue = false)]
        public FlattenedWebsites Websites { get; set; }

        /// <summary>
        /// Gets or Sets Interacted
        /// </summary>
        [DataMember(Name = "interacted", EmitDefaultValue = false)]
        public GroupedTimestamp Interacted { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public FlattenedTags Tags { get; set; }

        /// <summary>
        /// Gets or Sets Sensitives
        /// </summary>
        [DataMember(Name = "sensitives", EmitDefaultValue = false)]
        public FlattenedSensitives Sensitives { get; set; }

        /// <summary>
        /// Gets or Sets Persons
        /// </summary>
        [DataMember(Name = "persons", EmitDefaultValue = false)]
        public FlattenedPersons Persons { get; set; }

        /// <summary>
        /// This is an optional boolean that will flag that this asset came from a currated collection.
        /// </summary>
        /// <value>This is an optional boolean that will flag that this asset came from a currated collection.</value>
        [DataMember(Name = "curated", EmitDefaultValue = true)]
        public bool Curated { get; set; }

        /// <summary>
        /// Gets or Sets Discovered
        /// </summary>
        [DataMember(Name = "discovered", EmitDefaultValue = true)]
        public bool Discovered { get; set; }

        /// <summary>
        /// Gets or Sets Activities
        /// </summary>
        [DataMember(Name = "activities", EmitDefaultValue = false)]
        public FlattenedActivities Activities { get; set; }

        /// <summary>
        /// Gets or Sets Score
        /// </summary>
        [DataMember(Name = "score", EmitDefaultValue = false)]
        public Score Score { get; set; }

        /// <summary>
        /// Gets or Sets Favorited
        /// </summary>
        [DataMember(Name = "favorited", EmitDefaultValue = true)]
        public bool Favorited { get; set; }

        /// <summary>
        /// Gets or Sets Pseudo
        /// </summary>
        [DataMember(Name = "pseudo", EmitDefaultValue = true)]
        public bool Pseudo { get; set; }

        /// <summary>
        /// Gets or Sets Annotations
        /// </summary>
        [DataMember(Name = "annotations", EmitDefaultValue = false)]
        public FlattenedAnnotations Annotations { get; set; }

        /// <summary>
        /// Gets or Sets Hints
        /// </summary>
        [DataMember(Name = "hints", EmitDefaultValue = false)]
        public FlattenedHints Hints { get; set; }

        /// <summary>
        /// Gets or Sets Anchors
        /// </summary>
        [DataMember(Name = "anchors", EmitDefaultValue = false)]
        public FlattenedAnchors Anchors { get; set; }

        /// <summary>
        /// Gets or Sets Conversations
        /// </summary>
        [DataMember(Name = "conversations", EmitDefaultValue = false)]
        public FlattenedConversations Conversations { get; set; }

        /// <summary>
        /// This will let us know if this asset was generated as a &#39;demo&#39; snippet
        /// </summary>
        /// <value>This will let us know if this asset was generated as a &#39;demo&#39; snippet</value>
        [DataMember(Name = "demo", EmitDefaultValue = true)]
        public bool Demo { get; set; }

        /// <summary>
        /// Gets or Sets Summaries
        /// </summary>
        [DataMember(Name = "summaries", EmitDefaultValue = false)]
        public FlattenedWorkstreamSummaries Summaries { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FlattenedAsset {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Creator: ").Append(Creator).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
            sb.Append("  Synced: ").Append(Synced).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  Formats: ").Append(Formats).Append("\n");
            sb.Append("  Preview: ").Append(Preview).Append("\n");
            sb.Append("  Original: ").Append(Original).Append("\n");
            sb.Append("  Shares: ").Append(Shares).Append("\n");
            sb.Append("  Mechanism: ").Append(Mechanism).Append("\n");
            sb.Append("  Websites: ").Append(Websites).Append("\n");
            sb.Append("  Interacted: ").Append(Interacted).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Sensitives: ").Append(Sensitives).Append("\n");
            sb.Append("  Persons: ").Append(Persons).Append("\n");
            sb.Append("  Curated: ").Append(Curated).Append("\n");
            sb.Append("  Discovered: ").Append(Discovered).Append("\n");
            sb.Append("  Activities: ").Append(Activities).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  Favorited: ").Append(Favorited).Append("\n");
            sb.Append("  Pseudo: ").Append(Pseudo).Append("\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("  Hints: ").Append(Hints).Append("\n");
            sb.Append("  Anchors: ").Append(Anchors).Append("\n");
            sb.Append("  Conversations: ").Append(Conversations).Append("\n");
            sb.Append("  Demo: ").Append(Demo).Append("\n");
            sb.Append("  Summaries: ").Append(Summaries).Append("\n");
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
