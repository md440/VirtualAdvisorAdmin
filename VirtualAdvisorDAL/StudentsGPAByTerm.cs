//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VirtualAdvisorDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class StudentsGPAByTerm
    {
        public int TermId { get; set; }
        public string TermAbbreviation { get; set; }
        public string DegreeDescription { get; set; }
        public int StudentId { get; set; }
        public Nullable<decimal> GPA { get; set; }
    }
}
