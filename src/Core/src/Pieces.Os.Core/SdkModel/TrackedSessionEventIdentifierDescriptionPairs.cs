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
    /// These are all of the available event types that are permitted in an object pair notation.
    /// </summary>
    [DataContract(Name = "TrackedSessionEventIdentifierDescriptionPairs")]
    public partial class TrackedSessionEventIdentifierDescriptionPairs : IValidatableObject
    {
        /// <summary>
        /// The key value pair for an application being opened.
        /// </summary>
        /// <value>The key value pair for an application being opened.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SessionInitializedEnum
        {
            /// <summary>
            /// Enum ASessionHasBeenInitializedAndTheApplicationHasBeenOpened for value: a_session_has_been_initialized_and_the_application_has_been_opened
            /// </summary>
            [EnumMember(Value = "a_session_has_been_initialized_and_the_application_has_been_opened")]
            ASessionHasBeenInitializedAndTheApplicationHasBeenOpened = 1
        }


        /// <summary>
        /// The key value pair for an application being opened.
        /// </summary>
        /// <value>The key value pair for an application being opened.</value>
        [DataMember(Name = "session_initialized", EmitDefaultValue = false)]
        public SessionInitializedEnum? SessionInitialized { get; set; }
        /// <summary>
        /// There was a successful connection locally
        /// </summary>
        /// <value>There was a successful connection locally</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SessionLocalConnectionSucceededEnum
        {
            /// <summary>
            /// Enum OneOrMoreApplicationsHasSuccessfullyConnected for value: one_or_more_applications_has_successfully_connected
            /// </summary>
            [EnumMember(Value = "one_or_more_applications_has_successfully_connected")]
            OneOrMoreApplicationsHasSuccessfullyConnected = 1
        }


        /// <summary>
        /// There was a successful connection locally
        /// </summary>
        /// <value>There was a successful connection locally</value>
        [DataMember(Name = "session_local_connection_succeeded", EmitDefaultValue = false)]
        public SessionLocalConnectionSucceededEnum? SessionLocalConnectionSucceeded { get; set; }
        /// <summary>
        /// There was a failed connection locally
        /// </summary>
        /// <value>There was a failed connection locally</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SessionLocalConnectionFailedEnum
        {
            /// <summary>
            /// Enum OneOrMoreApplicationsHasFailedToConnectLocally for value: one_or_more_applications_has_failed_to_connect_locally
            /// </summary>
            [EnumMember(Value = "one_or_more_applications_has_failed_to_connect_locally")]
            OneOrMoreApplicationsHasFailedToConnectLocally = 1
        }


        /// <summary>
        /// There was a failed connection locally
        /// </summary>
        /// <value>There was a failed connection locally</value>
        [DataMember(Name = "session_local_connection_failed", EmitDefaultValue = false)]
        public SessionLocalConnectionFailedEnum? SessionLocalConnectionFailed { get; set; }
        /// <summary>
        /// If the current application is in the background or not, could also be minimized.
        /// </summary>
        /// <value>If the current application is in the background or not, could also be minimized.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SessionInactiveEnum
        {
            /// <summary>
            /// Enum ASessionIsInactiveBecauseTheApplicationIsNotInTheForeground for value: a_session_is_inactive_because_the_application_is_not_in_the_foreground
            /// </summary>
            [EnumMember(Value = "a_session_is_inactive_because_the_application_is_not_in_the_foreground")]
            ASessionIsInactiveBecauseTheApplicationIsNotInTheForeground = 1
        }


        /// <summary>
        /// If the current application is in the background or not, could also be minimized.
        /// </summary>
        /// <value>If the current application is in the background or not, could also be minimized.</value>
        [DataMember(Name = "session_inactive", EmitDefaultValue = false)]
        public SessionInactiveEnum? SessionInactive { get; set; }
        /// <summary>
        /// If the application has been brought to the forground.
        /// </summary>
        /// <value>If the application has been brought to the forground.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SessionActiveEnum
        {
            /// <summary>
            /// Enum ASessionIsActiveBecauseTheApplicationIsInTheForeground for value: a_session_is_active_because_the_application_is_in_the_foreground
            /// </summary>
            [EnumMember(Value = "a_session_is_active_because_the_application_is_in_the_foreground")]
            ASessionIsActiveBecauseTheApplicationIsInTheForeground = 1
        }


        /// <summary>
        /// If the application has been brought to the forground.
        /// </summary>
        /// <value>If the application has been brought to the forground.</value>
        [DataMember(Name = "session_active", EmitDefaultValue = false)]
        public SessionActiveEnum? SessionActive { get; set; }
        /// <summary>
        /// If the user has closed the application, thus ending the session.
        /// </summary>
        /// <value>If the user has closed the application, thus ending the session.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SessionTerminatedEnum
        {
            /// <summary>
            /// Enum ASessionHasBeenEndedAndTheApplicationHasBeenClosed for value: a_session_has_been_ended_and_the_application_has_been_closed
            /// </summary>
            [EnumMember(Value = "a_session_has_been_ended_and_the_application_has_been_closed")]
            ASessionHasBeenEndedAndTheApplicationHasBeenClosed = 1
        }


        /// <summary>
        /// If the user has closed the application, thus ending the session.
        /// </summary>
        /// <value>If the user has closed the application, thus ending the session.</value>
        [DataMember(Name = "session_terminated", EmitDefaultValue = false)]
        public SessionTerminatedEnum? SessionTerminated { get; set; }
        /// <summary>
        /// A user has signed into this session with a an external account
        /// </summary>
        /// <value>A user has signed into this session with a an external account</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SessionAuthenticatedWithSignInEnum
        {
            /// <summary>
            /// Enum AUserHasSignedIntoThisSessionWithAAnExternalAccount for value: a_user_has_signed_into_this_session_with_a_an_external_account
            /// </summary>
            [EnumMember(Value = "a_user_has_signed_into_this_session_with_a_an_external_account")]
            AUserHasSignedIntoThisSessionWithAAnExternalAccount = 1
        }


        /// <summary>
        /// A user has signed into this session with a an external account
        /// </summary>
        /// <value>A user has signed into this session with a an external account</value>
        [DataMember(Name = "session_authenticated_with_sign_in", EmitDefaultValue = false)]
        public SessionAuthenticatedWithSignInEnum? SessionAuthenticatedWithSignIn { get; set; }
        /// <summary>
        /// A user has signed out of this session
        /// </summary>
        /// <value>A user has signed out of this session</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SessionUnauthenticatedWithSignOutEnum
        {
            /// <summary>
            /// Enum AUserHasSignedOutOfThisSession for value: a_user_has_signed_out_of_this_session
            /// </summary>
            [EnumMember(Value = "a_user_has_signed_out_of_this_session")]
            AUserHasSignedOutOfThisSession = 1
        }


        /// <summary>
        /// A user has signed out of this session
        /// </summary>
        /// <value>A user has signed out of this session</value>
        [DataMember(Name = "session_unauthenticated_with_sign_out", EmitDefaultValue = false)]
        public SessionUnauthenticatedWithSignOutEnum? SessionUnauthenticatedWithSignOut { get; set; }
        /// <summary>
        /// A user did not sign into the session with a dismissal
        /// </summary>
        /// <value>A user did not sign into the session with a dismissal</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SessionUnauthenticatedWithDismissEnum
        {
            /// <summary>
            /// Enum AUserDidNotSignIntoTheSessionWithADismissal for value: a_user_did_not_sign_into_the_session_with_a_dismissal
            /// </summary>
            [EnumMember(Value = "a_user_did_not_sign_into_the_session_with_a_dismissal")]
            AUserDidNotSignIntoTheSessionWithADismissal = 1
        }


        /// <summary>
        /// A user did not sign into the session with a dismissal
        /// </summary>
        /// <value>A user did not sign into the session with a dismissal</value>
        [DataMember(Name = "session_unauthenticated_with_dismiss", EmitDefaultValue = false)]
        public SessionUnauthenticatedWithDismissEnum? SessionUnauthenticatedWithDismiss { get; set; }
        /// <summary>
        /// A user did not sign into the session with a reminder
        /// </summary>
        /// <value>A user did not sign into the session with a reminder</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SessionUnauthenticatedWithRemindEnum
        {
            /// <summary>
            /// Enum AUserDidNotSignIntoTheSessionWithAReminder for value: a_user_did_not_sign_into_the_session_with_a_reminder
            /// </summary>
            [EnumMember(Value = "a_user_did_not_sign_into_the_session_with_a_reminder")]
            AUserDidNotSignIntoTheSessionWithAReminder = 1
        }


        /// <summary>
        /// A user did not sign into the session with a reminder
        /// </summary>
        /// <value>A user did not sign into the session with a reminder</value>
        [DataMember(Name = "session_unauthenticated_with_remind", EmitDefaultValue = false)]
        public SessionUnauthenticatedWithRemindEnum? SessionUnauthenticatedWithRemind { get; set; }
        /// <summary>
        /// Onboarding has been initialized for this session
        /// </summary>
        /// <value>Onboarding has been initialized for this session</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SessionOnboardingInitializedEnum
        {
            /// <summary>
            /// Enum OnboardingHasBeenInitializedForThisSession for value: onboarding_has_been_initialized_for_this_session
            /// </summary>
            [EnumMember(Value = "onboarding_has_been_initialized_for_this_session")]
            OnboardingHasBeenInitializedForThisSession = 1
        }


        /// <summary>
        /// Onboarding has been initialized for this session
        /// </summary>
        /// <value>Onboarding has been initialized for this session</value>
        [DataMember(Name = "session_onboarding_initialized", EmitDefaultValue = false)]
        public SessionOnboardingInitializedEnum? SessionOnboardingInitialized { get; set; }
        /// <summary>
        /// Onboarding has been completed for this session
        /// </summary>
        /// <value>Onboarding has been completed for this session</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SessionOnboardingCompletedEnum
        {
            /// <summary>
            /// Enum OnboardingHasBeenCompletedForThisSession for value: onboarding_has_been_completed_for_this_session
            /// </summary>
            [EnumMember(Value = "onboarding_has_been_completed_for_this_session")]
            OnboardingHasBeenCompletedForThisSession = 1
        }


        /// <summary>
        /// Onboarding has been completed for this session
        /// </summary>
        /// <value>Onboarding has been completed for this session</value>
        [DataMember(Name = "session_onboarding_completed", EmitDefaultValue = false)]
        public SessionOnboardingCompletedEnum? SessionOnboardingCompleted { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackedSessionEventIdentifierDescriptionPairs" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="sessionInitialized">The key value pair for an application being opened..</param>
        /// <param name="sessionLocalConnectionSucceeded">There was a successful connection locally.</param>
        /// <param name="sessionLocalConnectionFailed">There was a failed connection locally.</param>
        /// <param name="sessionInactive">If the current application is in the background or not, could also be minimized..</param>
        /// <param name="sessionActive">If the application has been brought to the forground..</param>
        /// <param name="sessionTerminated">If the user has closed the application, thus ending the session..</param>
        /// <param name="sessionAuthenticatedWithSignIn">A user has signed into this session with a an external account.</param>
        /// <param name="sessionUnauthenticatedWithSignOut">A user has signed out of this session.</param>
        /// <param name="sessionUnauthenticatedWithDismiss">A user did not sign into the session with a dismissal.</param>
        /// <param name="sessionUnauthenticatedWithRemind">A user did not sign into the session with a reminder.</param>
        /// <param name="sessionOnboardingInitialized">Onboarding has been initialized for this session.</param>
        /// <param name="sessionOnboardingCompleted">Onboarding has been completed for this session.</param>
        public TrackedSessionEventIdentifierDescriptionPairs(EmbeddedModelSchema schema = default(EmbeddedModelSchema), SessionInitializedEnum? sessionInitialized = default(SessionInitializedEnum?), SessionLocalConnectionSucceededEnum? sessionLocalConnectionSucceeded = default(SessionLocalConnectionSucceededEnum?), SessionLocalConnectionFailedEnum? sessionLocalConnectionFailed = default(SessionLocalConnectionFailedEnum?), SessionInactiveEnum? sessionInactive = default(SessionInactiveEnum?), SessionActiveEnum? sessionActive = default(SessionActiveEnum?), SessionTerminatedEnum? sessionTerminated = default(SessionTerminatedEnum?), SessionAuthenticatedWithSignInEnum? sessionAuthenticatedWithSignIn = default(SessionAuthenticatedWithSignInEnum?), SessionUnauthenticatedWithSignOutEnum? sessionUnauthenticatedWithSignOut = default(SessionUnauthenticatedWithSignOutEnum?), SessionUnauthenticatedWithDismissEnum? sessionUnauthenticatedWithDismiss = default(SessionUnauthenticatedWithDismissEnum?), SessionUnauthenticatedWithRemindEnum? sessionUnauthenticatedWithRemind = default(SessionUnauthenticatedWithRemindEnum?), SessionOnboardingInitializedEnum? sessionOnboardingInitialized = default(SessionOnboardingInitializedEnum?), SessionOnboardingCompletedEnum? sessionOnboardingCompleted = default(SessionOnboardingCompletedEnum?))
        {
            this.Schema = schema;
            this.SessionInitialized = sessionInitialized;
            this.SessionLocalConnectionSucceeded = sessionLocalConnectionSucceeded;
            this.SessionLocalConnectionFailed = sessionLocalConnectionFailed;
            this.SessionInactive = sessionInactive;
            this.SessionActive = sessionActive;
            this.SessionTerminated = sessionTerminated;
            this.SessionAuthenticatedWithSignIn = sessionAuthenticatedWithSignIn;
            this.SessionUnauthenticatedWithSignOut = sessionUnauthenticatedWithSignOut;
            this.SessionUnauthenticatedWithDismiss = sessionUnauthenticatedWithDismiss;
            this.SessionUnauthenticatedWithRemind = sessionUnauthenticatedWithRemind;
            this.SessionOnboardingInitialized = sessionOnboardingInitialized;
            this.SessionOnboardingCompleted = sessionOnboardingCompleted;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TrackedSessionEventIdentifierDescriptionPairs {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  SessionInitialized: ").Append(SessionInitialized).Append("\n");
            sb.Append("  SessionLocalConnectionSucceeded: ").Append(SessionLocalConnectionSucceeded).Append("\n");
            sb.Append("  SessionLocalConnectionFailed: ").Append(SessionLocalConnectionFailed).Append("\n");
            sb.Append("  SessionInactive: ").Append(SessionInactive).Append("\n");
            sb.Append("  SessionActive: ").Append(SessionActive).Append("\n");
            sb.Append("  SessionTerminated: ").Append(SessionTerminated).Append("\n");
            sb.Append("  SessionAuthenticatedWithSignIn: ").Append(SessionAuthenticatedWithSignIn).Append("\n");
            sb.Append("  SessionUnauthenticatedWithSignOut: ").Append(SessionUnauthenticatedWithSignOut).Append("\n");
            sb.Append("  SessionUnauthenticatedWithDismiss: ").Append(SessionUnauthenticatedWithDismiss).Append("\n");
            sb.Append("  SessionUnauthenticatedWithRemind: ").Append(SessionUnauthenticatedWithRemind).Append("\n");
            sb.Append("  SessionOnboardingInitialized: ").Append(SessionOnboardingInitialized).Append("\n");
            sb.Append("  SessionOnboardingCompleted: ").Append(SessionOnboardingCompleted).Append("\n");
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
