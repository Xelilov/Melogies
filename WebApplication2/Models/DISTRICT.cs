//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DISTRICT
    {
        public int OBJECTID { get; set; }
        public string NameAU { get; set; }
        public Nullable<decimal> CodeER { get; set; }
        public Nullable<decimal> CodeAU { get; set; }
        public Nullable<short> TypeAU { get; set; }
        public string Subordinat { get; set; }
        public string CadNumbAU { get; set; }
        public Nullable<decimal> SHAPE_Leng { get; set; }
        public System.Data.Entity.Spatial.DbGeometry Shape { get; set; }
    }
}
