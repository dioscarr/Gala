//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.Web.Mvc;
    
    public partial class Home
    {
        public int Id { get; set; }
        public string Header { get; set; }
        [AllowHtml]
        public string Content { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime Modified { get; set; }
        public bool isDeleted { get; set; }
    }
}
