//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace art_shop_core.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class Error
    {
        public int Id { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<System.DateTime> ErrorDate { get; set; }
        public string IpAddress { get; set; }
        public string UserAgent { get; set; }
        public string Exception { get; set; }
        public string Message { get; set; }
        public string Everything { get; set; }
        public string HttpReferer { get; set; }
        public string PathAndQuery { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public System.DateTime ChangedOn { get; set; }
    }
}