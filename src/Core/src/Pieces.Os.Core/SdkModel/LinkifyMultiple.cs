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
    /// This is the incoming linkify model.  if access is PRIVATE then please provide and array of users to enable the link for.  Assumption, all assets are already backed up to the cloud. 
    /// </summary>
    [DataContract(Name = "LinkifyMultiple")]
    public partial class LinkifyMultiple : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Access
        /// </summary>
        [DataMember(Name = "access", IsRequired = true, EmitDefaultValue = true)]
        public AccessEnum Access { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkifyMultiple" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LinkifyMultiple() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkifyMultiple" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="assets">This is an array or string that represents an already backed up asset. That will be added to a collection. (required).</param>
        /// <param name="users">this is an array of users..</param>
        /// <param name="access">access (required).</param>
        /// <param name="name">optionally can give the collection a name if you want..</param>
        public LinkifyMultiple(EmbeddedModelSchema schema = default(EmbeddedModelSchema), List<string> assets = default(List<string>), List<SeededUser> users = default(List<SeededUser>), AccessEnum access = default(AccessEnum), string name = default(string))
        {
            // to ensure "assets" is required (not null)
            if (assets == null)
            {
                throw new ArgumentNullException("assets is a required property for LinkifyMultiple and cannot be null");
            }
            this.Assets = assets;
            this.Access = access;
            this.Schema = schema;
            this.Users = users;
            this.Name = name;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// This is an array or string that represents an already backed up asset. That will be added to a collection.
        /// </summary>
        /// <value>This is an array or string that represents an already backed up asset. That will be added to a collection.</value>
        [DataMember(Name = "assets", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Assets { get; set; }

        /// <summary>
        /// this is an array of users.
        /// </summary>
        /// <value>this is an array of users.</value>
        [DataMember(Name = "users", EmitDefaultValue = false)]
        public List<SeededUser> Users { get; set; }

        /// <summary>
        /// optionally can give the collection a name if you want.
        /// </summary>
        /// <value>optionally can give the collection a name if you want.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LinkifyMultiple {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Assets: ").Append(Assets).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
            sb.Append("  Access: ").Append(Access).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
