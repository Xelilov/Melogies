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
    
    public partial class RIVER
    {
        public int OBJECTID_1 { get; set; }
        public Nullable<int> OBJECTID { get; set; }
        public Nullable<int> GID { get; set; }
        public string ENG_NAME { get; set; }
        public string TYPE { get; set; }
        public string AZ_NAME { get; set; }
        public Nullable<decimal> LINESIZE { get; set; }
        public string TYPE_AZ { get; set; }
        public string GLOBALID { get; set; }
        public Nullable<decimal> SHAPE_Leng { get; set; }
        public System.Data.Entity.Spatial.DbGeometry Shape { get; set; }
    }
}
