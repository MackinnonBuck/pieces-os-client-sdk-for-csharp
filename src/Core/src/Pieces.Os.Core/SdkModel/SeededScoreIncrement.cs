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
    /// This is the body for a respective scores increment,  This will enable us to know what material we want to increment, all of which are optional, if it is defined we will attempt to increment the material.
    /// </summary>
    [DataContract(Name = "SeededScoreIncrement")]
    public partial class SeededScoreIncrement : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SeededScoreIncrement" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="asset">asset.</param>
        /// <param name="assets">assets.</param>
        /// <param name="website">website.</param>
        /// <param name="websites">websites.</param>
        /// <param name="anchor">anchor.</param>
        /// <param name="anchors">anchors.</param>
        /// <param name="anchorPoint">anchorPoint.</param>
        /// <param name="anchorPoints">anchorPoints.</param>
        /// <param name="annotation">annotation.</param>
        /// <param name="annotations">annotations.</param>
        /// <param name="conversation">conversation.</param>
        /// <param name="conversations">conversations.</param>
        /// <param name="conversationMessage">conversationMessage.</param>
        /// <param name="conversationMessages">conversationMessages.</param>
        /// <param name="share">share.</param>
        /// <param name="shares">shares.</param>
        /// <param name="sensitive">sensitive.</param>
        /// <param name="sensitives">sensitives.</param>
        /// <param name="hint">hint.</param>
        /// <param name="hints">hints.</param>
        /// <param name="person">person.</param>
        /// <param name="persons">persons.</param>
        /// <param name="tag">tag.</param>
        /// <param name="tags">tags.</param>
        /// <param name="workstreamSummary">workstreamSummary.</param>
        /// <param name="workstreamSummaries">workstreamSummaries.</param>
        /// <param name="workstreamEvents">workstreamEvents.</param>
        /// <param name="workstreamEvent">workstreamEvent.</param>
        /// <param name="ranges">ranges.</param>
        /// <param name="range">range.</param>
        /// <param name="workstreamPatternEngineSources">workstreamPatternEngineSources.</param>
        /// <param name="workstreamPatternEngineSource">workstreamPatternEngineSource.</param>
        /// <param name="models">models.</param>
        /// <param name="model">model.</param>
        public SeededScoreIncrement(EmbeddedModelSchema schema = default(EmbeddedModelSchema), SeededScore asset = default(SeededScore), SeededScore assets = default(SeededScore), SeededScore website = default(SeededScore), SeededScore websites = default(SeededScore), SeededScore anchor = default(SeededScore), SeededScore anchors = default(SeededScore), SeededScore anchorPoint = default(SeededScore), SeededScore anchorPoints = default(SeededScore), SeededScore annotation = default(SeededScore), SeededScore annotations = default(SeededScore), SeededScore conversation = default(SeededScore), SeededScore conversations = default(SeededScore), SeededScore conversationMessage = default(SeededScore), SeededScore conversationMessages = default(SeededScore), SeededScore share = default(SeededScore), SeededScore shares = default(SeededScore), SeededScore sensitive = default(SeededScore), SeededScore sensitives = default(SeededScore), SeededScore hint = default(SeededScore), SeededScore hints = default(SeededScore), SeededScore person = default(SeededScore), SeededScore persons = default(SeededScore), SeededScore tag = default(SeededScore), SeededScore tags = default(SeededScore), SeededScore workstreamSummary = default(SeededScore), SeededScore workstreamSummaries = default(SeededScore), SeededScore workstreamEvents = default(SeededScore), SeededScore workstreamEvent = default(SeededScore), SeededScore ranges = default(SeededScore), SeededScore range = default(SeededScore), SeededScore workstreamPatternEngineSources = default(SeededScore), SeededScore workstreamPatternEngineSource = default(SeededScore), SeededScore models = default(SeededScore), SeededScore model = default(SeededScore))
        {
            this.Schema = schema;
            this.Asset = asset;
            this.Assets = assets;
            this.Website = website;
            this.Websites = websites;
            this.Anchor = anchor;
            this.Anchors = anchors;
            this.AnchorPoint = anchorPoint;
            this.AnchorPoints = anchorPoints;
            this.Annotation = annotation;
            this.Annotations = annotations;
            this.Conversation = conversation;
            this.Conversations = conversations;
            this.ConversationMessage = conversationMessage;
            this.ConversationMessages = conversationMessages;
            this.Share = share;
            this.Shares = shares;
            this.Sensitive = sensitive;
            this.Sensitives = sensitives;
            this.Hint = hint;
            this.Hints = hints;
            this.Person = person;
            this.Persons = persons;
            this.Tag = tag;
            this.Tags = tags;
            this.WorkstreamSummary = workstreamSummary;
            this.WorkstreamSummaries = workstreamSummaries;
            this.WorkstreamEvents = workstreamEvents;
            this.WorkstreamEvent = workstreamEvent;
            this.Ranges = ranges;
            this.Range = range;
            this.WorkstreamPatternEngineSources = workstreamPatternEngineSources;
            this.WorkstreamPatternEngineSource = workstreamPatternEngineSource;
            this.Models = models;
            this.Model = model;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Gets or Sets Asset
        /// </summary>
        [DataMember(Name = "asset", EmitDefaultValue = false)]
        public SeededScore Asset { get; set; }

        /// <summary>
        /// Gets or Sets Assets
        /// </summary>
        [DataMember(Name = "assets", EmitDefaultValue = false)]
        public SeededScore Assets { get; set; }

        /// <summary>
        /// Gets or Sets Website
        /// </summary>
        [DataMember(Name = "website", EmitDefaultValue = false)]
        public SeededScore Website { get; set; }

        /// <summary>
        /// Gets or Sets Websites
        /// </summary>
        [DataMember(Name = "websites", EmitDefaultValue = false)]
        public SeededScore Websites { get; set; }

        /// <summary>
        /// Gets or Sets Anchor
        /// </summary>
        [DataMember(Name = "anchor", EmitDefaultValue = false)]
        public SeededScore Anchor { get; set; }

        /// <summary>
        /// Gets or Sets Anchors
        /// </summary>
        [DataMember(Name = "anchors", EmitDefaultValue = false)]
        public SeededScore Anchors { get; set; }

        /// <summary>
        /// Gets or Sets AnchorPoint
        /// </summary>
        [DataMember(Name = "anchorPoint", EmitDefaultValue = false)]
        public SeededScore AnchorPoint { get; set; }

        /// <summary>
        /// Gets or Sets AnchorPoints
        /// </summary>
        [DataMember(Name = "anchorPoints", EmitDefaultValue = false)]
        public SeededScore AnchorPoints { get; set; }

        /// <summary>
        /// Gets or Sets Annotation
        /// </summary>
        [DataMember(Name = "annotation", EmitDefaultValue = false)]
        public SeededScore Annotation { get; set; }

        /// <summary>
        /// Gets or Sets Annotations
        /// </summary>
        [DataMember(Name = "annotations", EmitDefaultValue = false)]
        public SeededScore Annotations { get; set; }

        /// <summary>
        /// Gets or Sets Conversation
        /// </summary>
        [DataMember(Name = "conversation", EmitDefaultValue = false)]
        public SeededScore Conversation { get; set; }

        /// <summary>
        /// Gets or Sets Conversations
        /// </summary>
        [DataMember(Name = "conversations", EmitDefaultValue = false)]
        public SeededScore Conversations { get; set; }

        /// <summary>
        /// Gets or Sets ConversationMessage
        /// </summary>
        [DataMember(Name = "conversationMessage", EmitDefaultValue = false)]
        public SeededScore ConversationMessage { get; set; }

        /// <summary>
        /// Gets or Sets ConversationMessages
        /// </summary>
        [DataMember(Name = "conversationMessages", EmitDefaultValue = false)]
        public SeededScore ConversationMessages { get; set; }

        /// <summary>
        /// Gets or Sets Share
        /// </summary>
        [DataMember(Name = "share", EmitDefaultValue = false)]
        public SeededScore Share { get; set; }

        /// <summary>
        /// Gets or Sets Shares
        /// </summary>
        [DataMember(Name = "shares", EmitDefaultValue = false)]
        public SeededScore Shares { get; set; }

        /// <summary>
        /// Gets or Sets Sensitive
        /// </summary>
        [DataMember(Name = "sensitive", EmitDefaultValue = false)]
        public SeededScore Sensitive { get; set; }

        /// <summary>
        /// Gets or Sets Sensitives
        /// </summary>
        [DataMember(Name = "sensitives", EmitDefaultValue = false)]
        public SeededScore Sensitives { get; set; }

        /// <summary>
        /// Gets or Sets Hint
        /// </summary>
        [DataMember(Name = "hint", EmitDefaultValue = false)]
        public SeededScore Hint { get; set; }

        /// <summary>
        /// Gets or Sets Hints
        /// </summary>
        [DataMember(Name = "hints", EmitDefaultValue = false)]
        public SeededScore Hints { get; set; }

        /// <summary>
        /// Gets or Sets Person
        /// </summary>
        [DataMember(Name = "person", EmitDefaultValue = false)]
        public SeededScore Person { get; set; }

        /// <summary>
        /// Gets or Sets Persons
        /// </summary>
        [DataMember(Name = "persons", EmitDefaultValue = false)]
        public SeededScore Persons { get; set; }

        /// <summary>
        /// Gets or Sets Tag
        /// </summary>
        [DataMember(Name = "tag", EmitDefaultValue = false)]
        public SeededScore Tag { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public SeededScore Tags { get; set; }

        /// <summary>
        /// Gets or Sets WorkstreamSummary
        /// </summary>
        [DataMember(Name = "workstream_summary", EmitDefaultValue = false)]
        public SeededScore WorkstreamSummary { get; set; }

        /// <summary>
        /// Gets or Sets WorkstreamSummaries
        /// </summary>
        [DataMember(Name = "workstream_summaries", EmitDefaultValue = false)]
        public SeededScore WorkstreamSummaries { get; set; }

        /// <summary>
        /// Gets or Sets WorkstreamEvents
        /// </summary>
        [DataMember(Name = "workstream_events", EmitDefaultValue = false)]
        public SeededScore WorkstreamEvents { get; set; }

        /// <summary>
        /// Gets or Sets WorkstreamEvent
        /// </summary>
        [DataMember(Name = "workstream_event", EmitDefaultValue = false)]
        public SeededScore WorkstreamEvent { get; set; }

        /// <summary>
        /// Gets or Sets Ranges
        /// </summary>
        [DataMember(Name = "ranges", EmitDefaultValue = false)]
        public SeededScore Ranges { get; set; }

        /// <summary>
        /// Gets or Sets Range
        /// </summary>
        [DataMember(Name = "range", EmitDefaultValue = false)]
        public SeededScore Range { get; set; }

        /// <summary>
        /// Gets or Sets WorkstreamPatternEngineSources
        /// </summary>
        [DataMember(Name = "workstream_pattern_engine_sources", EmitDefaultValue = false)]
        public SeededScore WorkstreamPatternEngineSources { get; set; }

        /// <summary>
        /// Gets or Sets WorkstreamPatternEngineSource
        /// </summary>
        [DataMember(Name = "workstream_pattern_engine_source", EmitDefaultValue = false)]
        public SeededScore WorkstreamPatternEngineSource { get; set; }

        /// <summary>
        /// Gets or Sets Models
        /// </summary>
        [DataMember(Name = "models", EmitDefaultValue = false)]
        public SeededScore Models { get; set; }

        /// <summary>
        /// Gets or Sets Model
        /// </summary>
        [DataMember(Name = "model", EmitDefaultValue = false)]
        public SeededScore Model { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SeededScoreIncrement {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Asset: ").Append(Asset).Append("\n");
            sb.Append("  Assets: ").Append(Assets).Append("\n");
            sb.Append("  Website: ").Append(Website).Append("\n");
            sb.Append("  Websites: ").Append(Websites).Append("\n");
            sb.Append("  Anchor: ").Append(Anchor).Append("\n");
            sb.Append("  Anchors: ").Append(Anchors).Append("\n");
            sb.Append("  AnchorPoint: ").Append(AnchorPoint).Append("\n");
            sb.Append("  AnchorPoints: ").Append(AnchorPoints).Append("\n");
            sb.Append("  Annotation: ").Append(Annotation).Append("\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("  Conversation: ").Append(Conversation).Append("\n");
            sb.Append("  Conversations: ").Append(Conversations).Append("\n");
            sb.Append("  ConversationMessage: ").Append(ConversationMessage).Append("\n");
            sb.Append("  ConversationMessages: ").Append(ConversationMessages).Append("\n");
            sb.Append("  Share: ").Append(Share).Append("\n");
            sb.Append("  Shares: ").Append(Shares).Append("\n");
            sb.Append("  Sensitive: ").Append(Sensitive).Append("\n");
            sb.Append("  Sensitives: ").Append(Sensitives).Append("\n");
            sb.Append("  Hint: ").Append(Hint).Append("\n");
            sb.Append("  Hints: ").Append(Hints).Append("\n");
            sb.Append("  Person: ").Append(Person).Append("\n");
            sb.Append("  Persons: ").Append(Persons).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  WorkstreamSummary: ").Append(WorkstreamSummary).Append("\n");
            sb.Append("  WorkstreamSummaries: ").Append(WorkstreamSummaries).Append("\n");
            sb.Append("  WorkstreamEvents: ").Append(WorkstreamEvents).Append("\n");
            sb.Append("  WorkstreamEvent: ").Append(WorkstreamEvent).Append("\n");
            sb.Append("  Ranges: ").Append(Ranges).Append("\n");
            sb.Append("  Range: ").Append(Range).Append("\n");
            sb.Append("  WorkstreamPatternEngineSources: ").Append(WorkstreamPatternEngineSources).Append("\n");
            sb.Append("  WorkstreamPatternEngineSource: ").Append(WorkstreamPatternEngineSource).Append("\n");
            sb.Append("  Models: ").Append(Models).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
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
