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
    
    public partial class EnrollmentStatu
    {
        public int EnrollmentId { get; set; }
        public string EnrollmentStatusCode { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
    
        public virtual Enrollment Enrollment { get; set; }
        public virtual EnrollmentStatusCode EnrollmentStatusCode1 { get; set; }
    }
}