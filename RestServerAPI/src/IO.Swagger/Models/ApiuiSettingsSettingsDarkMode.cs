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
    public partial class ApiuiSettingsSettingsDarkMode : IEquatable<ApiuiSettingsSettingsDarkMode>
    {
        /// <summary>
        /// Gets or Sets UseSystem
        /// </summary>
        [Required]

        [DataMember(Name = "use_system")]
        public bool? UseSystem { get; set; }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [Required]

        [DataMember(Name = "enabled")]
        public string Enabled { get; set; }

        /// <summary>
        /// Gets or Sets ThumbInverted
        /// </summary>
        [Required]

        [DataMember(Name = "thumb_inverted")]
        public string ThumbInverted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiuiSettingsSettingsDarkMode {\n");
            sb.Append("  UseSystem: ").Append(UseSystem).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  ThumbInverted: ").Append(ThumbInverted).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ApiuiSettingsSettingsDarkMode)obj);
        }

        /// <summary>
        /// Returns true if ApiuiSettingsSettingsDarkMode instances are equal
        /// </summary>
        /// <param name="other">Instance of ApiuiSettingsSettingsDarkMode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiuiSettingsSettingsDarkMode other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    UseSystem == other.UseSystem ||
                    UseSystem != null &&
                    UseSystem.Equals(other.UseSystem)
                ) &&
                (
                    Enabled == other.Enabled ||
                    Enabled != null &&
                    Enabled.Equals(other.Enabled)
                ) &&
                (
                    ThumbInverted == other.ThumbInverted ||
                    ThumbInverted != null &&
                    ThumbInverted.Equals(other.ThumbInverted)
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
                if (UseSystem != null)
                    hashCode = hashCode * 59 + UseSystem.GetHashCode();
                if (Enabled != null)
                    hashCode = hashCode * 59 + Enabled.GetHashCode();
                if (ThumbInverted != null)
                    hashCode = hashCode * 59 + ThumbInverted.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(ApiuiSettingsSettingsDarkMode left, ApiuiSettingsSettingsDarkMode right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ApiuiSettingsSettingsDarkMode left, ApiuiSettingsSettingsDarkMode right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
