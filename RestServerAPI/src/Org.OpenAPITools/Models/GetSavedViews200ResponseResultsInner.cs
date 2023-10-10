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
    public partial class GetSavedViews200ResponseResultsInner : IEquatable<GetSavedViews200ResponseResultsInner>
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [Required]
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [Required]
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ShowOnDashboard
        /// </summary>
        [Required]
        [DataMember(Name = "show_on_dashboard", EmitDefaultValue = true)]
        public bool ShowOnDashboard { get; set; }

        /// <summary>
        /// Gets or Sets ShowInSidebar
        /// </summary>
        [Required]
        [DataMember(Name = "show_in_sidebar", EmitDefaultValue = true)]
        public bool ShowInSidebar { get; set; }

        /// <summary>
        /// Gets or Sets SortField
        /// </summary>
        [Required]
        [DataMember(Name = "sort_field", EmitDefaultValue = false)]
        public string SortField { get; set; }

        /// <summary>
        /// Gets or Sets SortReverse
        /// </summary>
        [Required]
        [DataMember(Name = "sort_reverse", EmitDefaultValue = true)]
        public bool SortReverse { get; set; }

        /// <summary>
        /// Gets or Sets FilterRules
        /// </summary>
        [Required]
        [DataMember(Name = "filter_rules", EmitDefaultValue = false)]
        public List<GetSavedViews200ResponseResultsInnerFilterRulesInner> FilterRules { get; set; }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [Required]
        [DataMember(Name = "owner", EmitDefaultValue = false)]
        public GetSavedViews200ResponseResultsInnerOwner Owner { get; set; }

        /// <summary>
        /// Gets or Sets UserCanChange
        /// </summary>
        [Required]
        [DataMember(Name = "user_can_change", EmitDefaultValue = true)]
        public bool UserCanChange { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetSavedViews200ResponseResultsInner {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ShowOnDashboard: ").Append(ShowOnDashboard).Append("\n");
            sb.Append("  ShowInSidebar: ").Append(ShowInSidebar).Append("\n");
            sb.Append("  SortField: ").Append(SortField).Append("\n");
            sb.Append("  SortReverse: ").Append(SortReverse).Append("\n");
            sb.Append("  FilterRules: ").Append(FilterRules).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  UserCanChange: ").Append(UserCanChange).Append("\n");
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
            return obj.GetType() == GetType() && Equals((GetSavedViews200ResponseResultsInner)obj);
        }

        /// <summary>
        /// Returns true if GetSavedViews200ResponseResultsInner instances are equal
        /// </summary>
        /// <param name="other">Instance of GetSavedViews200ResponseResultsInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetSavedViews200ResponseResultsInner other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Id == other.Id ||

                    Id.Equals(other.Id)
                ) &&
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) &&
                (
                    ShowOnDashboard == other.ShowOnDashboard ||

                    ShowOnDashboard.Equals(other.ShowOnDashboard)
                ) &&
                (
                    ShowInSidebar == other.ShowInSidebar ||

                    ShowInSidebar.Equals(other.ShowInSidebar)
                ) &&
                (
                    SortField == other.SortField ||
                    SortField != null &&
                    SortField.Equals(other.SortField)
                ) &&
                (
                    SortReverse == other.SortReverse ||

                    SortReverse.Equals(other.SortReverse)
                ) &&
                (
                    FilterRules == other.FilterRules ||
                    FilterRules != null &&
                    other.FilterRules != null &&
                    FilterRules.SequenceEqual(other.FilterRules)
                ) &&
                (
                    Owner == other.Owner ||
                    Owner != null &&
                    Owner.Equals(other.Owner)
                ) &&
                (
                    UserCanChange == other.UserCanChange ||

                    UserCanChange.Equals(other.UserCanChange)
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

                hashCode = hashCode * 59 + Id.GetHashCode();
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();

                hashCode = hashCode * 59 + ShowOnDashboard.GetHashCode();

                hashCode = hashCode * 59 + ShowInSidebar.GetHashCode();
                if (SortField != null)
                    hashCode = hashCode * 59 + SortField.GetHashCode();

                hashCode = hashCode * 59 + SortReverse.GetHashCode();
                if (FilterRules != null)
                    hashCode = hashCode * 59 + FilterRules.GetHashCode();
                if (Owner != null)
                    hashCode = hashCode * 59 + Owner.GetHashCode();

                hashCode = hashCode * 59 + UserCanChange.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(GetSavedViews200ResponseResultsInner left, GetSavedViews200ResponseResultsInner right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(GetSavedViews200ResponseResultsInner left, GetSavedViews200ResponseResultsInner right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}