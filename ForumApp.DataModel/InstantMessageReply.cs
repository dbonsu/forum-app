//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ForumApp.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class InstantMessageReply
    {
        public long ID { get; set; }
        public long InstantMessageID { get; set; }
        public string Body { get; set; }
        public System.DateTime CreationDate { get; set; }
        public long ToUser { get; set; }
        public long FromUser { get; set; }
        public Nullable<bool> IsNew { get; set; }
        public Nullable<bool> IsSent { get; set; }
    
        public virtual InstantMessage InstantMessage { get; set; }
    }
}
