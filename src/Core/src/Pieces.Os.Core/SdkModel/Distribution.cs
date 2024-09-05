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
    /// This is a fully referenced version of a Distribution. TODO add additional distributions such as slack, google_chat, ...etc
    /// </summary>
    [DataContract(Name = "Distribution")]
    public partial class Distribution : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Distribution" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Distribution() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Distribution" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="id">id (required).</param>
        /// <param name="share">share (required).</param>
        /// <param name="created">created (required).</param>
        /// <param name="updated">updated (required).</param>
        /// <param name="deleted">deleted.</param>
        /// <param name="mailgun">mailgun.</param>
        /// <param name="github">github.</param>
        public Distribution(EmbeddedModelSchema schema = default(EmbeddedModelSchema), string id = default(string), FlattenedShare share = default(FlattenedShare), GroupedTimestamp created = default(GroupedTimestamp), GroupedTimestamp updated = default(GroupedTimestamp), GroupedTimestamp deleted = default(GroupedTimestamp), MailgunDistribution mailgun = default(MailgunDistribution), GitHubDistribution github = default(GitHubDistribution))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for Distribution and cannot be null");
            }
            this.Id = id;
            // to ensure "share" is required (not null)
            if (share == null)
            {
                throw new ArgumentNullException("share is a required property for Distribution and cannot be null");
            }
            this.Share = share;
            // to ensure "created" is required (not null)
            if (created == null)
            {
                throw new ArgumentNullException("created is a required property for Distribution and cannot be null");
            }
            this.Created = created;
            // to ensure "updated" is required (not null)
            if (updated == null)
            {
                throw new ArgumentNullException("updated is a required property for Distribution and cannot be null");
            }
            this.Updated = updated;
            this.Schema = schema;
            this.Deleted = deleted;
            this.Mailgun = mailgun;
            this.Github = github;
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
        /// Gets or Sets Share
        /// </summary>
        [DataMember(Name = "share", IsRequired = true, EmitDefaultValue = true)]
        public FlattenedShare Share { get; set; }

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
        /// Gets or Sets Mailgun
        /// </summary>
        [DataMember(Name = "mailgun", EmitDefaultValue = false)]
        public MailgunDistribution Mailgun { get; set; }

        /// <summary>
        /// Gets or Sets Github
        /// </summary>
        [DataMember(Name = "github", EmitDefaultValue = false)]
        public GitHubDistribution Github { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Distribution {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Share: ").Append(Share).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  Mailgun: ").Append(Mailgun).Append("\n");
            sb.Append("  Github: ").Append(Github).Append("\n");
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
