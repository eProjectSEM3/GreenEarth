//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GreenEarth.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public string RollNo { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public Nullable<System.DateTime> JoinDate { get; set; }
        public string Role { get; set; }
        public Nullable<bool> isActive { get; set; }
    }
}
