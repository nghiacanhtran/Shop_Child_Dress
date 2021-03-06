//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web365Base
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblProductFilter
    {
        public tblProductFilter()
        {
            this.tblProductFilter1 = new HashSet<tblProductFilter>();
            this.tblProduct = new HashSet<tblProduct>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string NameAscii { get; set; }
        public Nullable<int> Number { get; set; }
        public Nullable<int> Parent { get; set; }
        public string Detail { get; set; }
        public Nullable<int> LanguageId { get; set; }
        public string SEOTitle { get; set; }
        public string SEODescription { get; set; }
        public string SEOKeyword { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<System.DateTime> DateUpdated { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<bool> IsShow { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    
        public virtual ICollection<tblProductFilter> tblProductFilter1 { get; set; }
        public virtual tblProductFilter tblProductFilter2 { get; set; }
        public virtual ICollection<tblProduct> tblProduct { get; set; }
    }
}
