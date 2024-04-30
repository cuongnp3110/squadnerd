//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WE_Project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class account
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public account()
        {
            this.comment = new HashSet<comment>();
            this.idea = new HashSet<idea>();
            this.notification = new HashSet<notification>();
            this.reaction = new HashSet<reaction>();
        }
    
        public int account_id { get; set; }

        [DisplayName("E-mail")]
        [Required(ErrorMessage = "E-mail is required.")]
        [MaxLength(50, ErrorMessage = "The number of characters has been exceeded, the limit is 50 characters")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail is not valid.")]
        public string email { get; set; }

        [DisplayName("Password")]
        [Required(ErrorMessage = "Password is required.")]
        public string password { get; set; }

        [DisplayName("Role")]
        public Nullable<int> state { get; set; }

        [DisplayName("Full name")]
        [MaxLength(50, ErrorMessage = "The number of characters has been exceeded, the limit is 50 characters")]
        public string fname { get; set; }

        [DisplayName("Gender")]
        public Nullable<bool> gender { get; set; }

        [DisplayName("Phone")]
        public Nullable<int> phone { get; set; }

        [DisplayName("Position")]
        public string position { get; set; }

        [DisplayName("Department")]
        public Nullable<int> department_id { get; set; }

        [DisplayName("Avatar")]
        public byte[] img { get; set; }
        public Nullable<bool> isActive { get; set; }

        public virtual department department { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<comment> comment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<idea> idea { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<notification> notification { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reaction> reaction { get; set; }
    }
}