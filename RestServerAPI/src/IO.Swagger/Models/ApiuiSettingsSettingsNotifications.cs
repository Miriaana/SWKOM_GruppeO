/*
 * Paperless Rest Server
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PaperlessRestApi.Models
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class ApiuiSettingsSettingsNotifications : IEquatable<ApiuiSettingsSettingsNotifications>
    {
        /// <summary>
        /// Gets or Sets ConsumerNewDocuments
        /// </summary>
        [Required]

        [DataMember(Name = "consumer_new_documents")]
        public bool? ConsumerNewDocuments { get; set; }

        /// <summary>
        /// Gets or Sets ConsumerSuccess
        /// </summary>
        [Required]

        [DataMember(Name = "consumer_success")]
        public bool? ConsumerSuccess { get; set; }

        /// <summary>
        /// Gets or Sets ConsumerFailed
        /// </summary>
        [Required]

        [DataMember(Name = "consumer_failed")]
        public bool? ConsumerFailed { get; set; }

        /// <summary>
        /// Gets or Sets ConsumerSuppressOnDashboard
        /// </summary>
        [Required]

        [DataMember(Name = "consumer_suppress_on_dashboard")]
        public bool? ConsumerSuppressOnDashboard { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiuiSettingsSettingsNotifications {\n");
            sb.Append("  ConsumerNewDocuments: ").Append(ConsumerNewDocuments).Append("\n");
            sb.Append("  ConsumerSuccess: ").Append(ConsumerSuccess).Append("\n");
            sb.Append("  ConsumerFailed: ").Append(ConsumerFailed).Append("\n");
            sb.Append("  ConsumerSuppressOnDashboard: ").Append(ConsumerSuppressOnDashboard).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((ApiuiSettingsSettingsNotifications)obj);
        }

        /// <summary>
        /// Returns true if ApiuiSettingsSettingsNotifications instances are equal
        /// </summary>
        /// <param name="other">Instance of ApiuiSettingsSettingsNotifications to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiuiSettingsSettingsNotifications other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    ConsumerNewDocuments == other.ConsumerNewDocuments ||
                    ConsumerNewDocuments != null &&
                    ConsumerNewDocuments.Equals(other.ConsumerNewDocuments)
                ) &&
                (
                    ConsumerSuccess == other.ConsumerSuccess ||
                    ConsumerSuccess != null &&
                    ConsumerSuccess.Equals(other.ConsumerSuccess)
                ) &&
                (
                    ConsumerFailed == other.ConsumerFailed ||
                    ConsumerFailed != null &&
                    ConsumerFailed.Equals(other.ConsumerFailed)
                ) &&
                (
                    ConsumerSuppressOnDashboard == other.ConsumerSuppressOnDashboard ||
                    ConsumerSuppressOnDashboard != null &&
                    ConsumerSuppressOnDashboard.Equals(other.ConsumerSuppressOnDashboard)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                if (ConsumerNewDocuments != null)
                    hashCode = hashCode * 59 + ConsumerNewDocuments.GetHashCode();
                if (ConsumerSuccess != null)
                    hashCode = hashCode * 59 + ConsumerSuccess.GetHashCode();
                if (ConsumerFailed != null)
                    hashCode = hashCode * 59 + ConsumerFailed.GetHashCode();
                if (ConsumerSuppressOnDashboard != null)
                    hashCode = hashCode * 59 + ConsumerSuppressOnDashboard.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(ApiuiSettingsSettingsNotifications left, ApiuiSettingsSettingsNotifications right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ApiuiSettingsSettingsNotifications left, ApiuiSettingsSettingsNotifications right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
