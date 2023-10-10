/*
 * Paperless Rest Server
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using PaperlessRestAPI.Converters;

namespace PaperlessRestAPI.Models
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class CreateUISettingsRequestSettingsSavedViews : IEquatable<CreateUISettingsRequestSettingsSavedViews>
    {
        /// <summary>
        /// Gets or Sets WarnOnUnsavedChange
        /// </summary>
        [Required]
        [DataMember(Name = "warn_on_unsaved_change", EmitDefaultValue = true)]
        public bool WarnOnUnsavedChange { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateUISettingsRequestSettingsSavedViews {\n");
            sb.Append("  WarnOnUnsavedChange: ").Append(WarnOnUnsavedChange).Append("\n");
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
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((CreateUISettingsRequestSettingsSavedViews)obj);
        }

        /// <summary>
        /// Returns true if CreateUISettingsRequestSettingsSavedViews instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateUISettingsRequestSettingsSavedViews to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateUISettingsRequestSettingsSavedViews other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return

                    WarnOnUnsavedChange == other.WarnOnUnsavedChange ||

                    WarnOnUnsavedChange.Equals(other.WarnOnUnsavedChange)
                ;
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

                hashCode = hashCode * 59 + WarnOnUnsavedChange.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(CreateUISettingsRequestSettingsSavedViews left, CreateUISettingsRequestSettingsSavedViews right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CreateUISettingsRequestSettingsSavedViews left, CreateUISettingsRequestSettingsSavedViews right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}