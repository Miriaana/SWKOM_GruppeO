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
    public partial class TagsIdBody : IEquatable<TagsIdBody>
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [Required]

        [DataMember(Name = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Slug
        /// </summary>
        [Required]

        [DataMember(Name = "slug")]
        public string Slug { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [Required]

        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Color
        /// </summary>
        [Required]

        [DataMember(Name = "color")]
        public string Color { get; set; }

        /// <summary>
        /// Gets or Sets TextColor
        /// </summary>
        [Required]

        [DataMember(Name = "text_color")]
        public string TextColor { get; set; }

        /// <summary>
        /// Gets or Sets Match
        /// </summary>
        [Required]

        [DataMember(Name = "match")]
        public string Match { get; set; }

        /// <summary>
        /// Gets or Sets MatchingAlgorithm
        /// </summary>
        [Required]

        [DataMember(Name = "matching_algorithm")]
        public int? MatchingAlgorithm { get; set; }

        /// <summary>
        /// Gets or Sets IsInsensitive
        /// </summary>
        [Required]

        [DataMember(Name = "is_insensitive")]
        public bool? IsInsensitive { get; set; }

        /// <summary>
        /// Gets or Sets IsInboxTag
        /// </summary>
        [Required]

        [DataMember(Name = "is_inbox_tag")]
        public bool? IsInboxTag { get; set; }

        /// <summary>
        /// Gets or Sets DocumentCount
        /// </summary>
        [Required]

        [DataMember(Name = "document_count")]
        public int? DocumentCount { get; set; }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [Required]

        [DataMember(Name = "owner")]
        public int? Owner { get; set; }

        /// <summary>
        /// Gets or Sets Permissions
        /// </summary>
        [Required]

        [DataMember(Name = "permissions")]
        public ApicorrespondentsidPermissions Permissions { get; set; }

        /// <summary>
        /// Gets or Sets SetPermissions
        /// </summary>
        [Required]

        [DataMember(Name = "set_permissions")]
        public ApicorrespondentsidPermissions SetPermissions { get; set; }

        /// <summary>
        /// Gets or Sets PermissionsForm
        /// </summary>
        [Required]

        [DataMember(Name = "permissions_form")]
        public ApicorrespondentsidPermissionsForm PermissionsForm { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TagsIdBody {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  TextColor: ").Append(TextColor).Append("\n");
            sb.Append("  Match: ").Append(Match).Append("\n");
            sb.Append("  MatchingAlgorithm: ").Append(MatchingAlgorithm).Append("\n");
            sb.Append("  IsInsensitive: ").Append(IsInsensitive).Append("\n");
            sb.Append("  IsInboxTag: ").Append(IsInboxTag).Append("\n");
            sb.Append("  DocumentCount: ").Append(DocumentCount).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  SetPermissions: ").Append(SetPermissions).Append("\n");
            sb.Append("  PermissionsForm: ").Append(PermissionsForm).Append("\n");
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
            return obj.GetType() == GetType() && Equals((TagsIdBody)obj);
        }

        /// <summary>
        /// Returns true if TagsIdBody instances are equal
        /// </summary>
        /// <param name="other">Instance of TagsIdBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TagsIdBody other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) &&
                (
                    Slug == other.Slug ||
                    Slug != null &&
                    Slug.Equals(other.Slug)
                ) &&
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) &&
                (
                    Color == other.Color ||
                    Color != null &&
                    Color.Equals(other.Color)
                ) &&
                (
                    TextColor == other.TextColor ||
                    TextColor != null &&
                    TextColor.Equals(other.TextColor)
                ) &&
                (
                    Match == other.Match ||
                    Match != null &&
                    Match.Equals(other.Match)
                ) &&
                (
                    MatchingAlgorithm == other.MatchingAlgorithm ||
                    MatchingAlgorithm != null &&
                    MatchingAlgorithm.Equals(other.MatchingAlgorithm)
                ) &&
                (
                    IsInsensitive == other.IsInsensitive ||
                    IsInsensitive != null &&
                    IsInsensitive.Equals(other.IsInsensitive)
                ) &&
                (
                    IsInboxTag == other.IsInboxTag ||
                    IsInboxTag != null &&
                    IsInboxTag.Equals(other.IsInboxTag)
                ) &&
                (
                    DocumentCount == other.DocumentCount ||
                    DocumentCount != null &&
                    DocumentCount.Equals(other.DocumentCount)
                ) &&
                (
                    Owner == other.Owner ||
                    Owner != null &&
                    Owner.Equals(other.Owner)
                ) &&
                (
                    Permissions == other.Permissions ||
                    Permissions != null &&
                    Permissions.Equals(other.Permissions)
                ) &&
                (
                    SetPermissions == other.SetPermissions ||
                    SetPermissions != null &&
                    SetPermissions.Equals(other.SetPermissions)
                ) &&
                (
                    PermissionsForm == other.PermissionsForm ||
                    PermissionsForm != null &&
                    PermissionsForm.Equals(other.PermissionsForm)
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
                if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                if (Slug != null)
                    hashCode = hashCode * 59 + Slug.GetHashCode();
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                if (Color != null)
                    hashCode = hashCode * 59 + Color.GetHashCode();
                if (TextColor != null)
                    hashCode = hashCode * 59 + TextColor.GetHashCode();
                if (Match != null)
                    hashCode = hashCode * 59 + Match.GetHashCode();
                if (MatchingAlgorithm != null)
                    hashCode = hashCode * 59 + MatchingAlgorithm.GetHashCode();
                if (IsInsensitive != null)
                    hashCode = hashCode * 59 + IsInsensitive.GetHashCode();
                if (IsInboxTag != null)
                    hashCode = hashCode * 59 + IsInboxTag.GetHashCode();
                if (DocumentCount != null)
                    hashCode = hashCode * 59 + DocumentCount.GetHashCode();
                if (Owner != null)
                    hashCode = hashCode * 59 + Owner.GetHashCode();
                if (Permissions != null)
                    hashCode = hashCode * 59 + Permissions.GetHashCode();
                if (SetPermissions != null)
                    hashCode = hashCode * 59 + SetPermissions.GetHashCode();
                if (PermissionsForm != null)
                    hashCode = hashCode * 59 + PermissionsForm.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(TagsIdBody left, TagsIdBody right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TagsIdBody left, TagsIdBody right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
