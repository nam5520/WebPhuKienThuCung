//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebPhuKienThuCung.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PHANQUYEN
    {
        public int MAPQ { get; set; }
        public int MAADMIN { get; set; }
        public string MACHUCNANG { get; set; }
    
        public virtual ADMIN ADMIN { get; set; }
        public virtual CHUCNANG_QUYEN CHUCNANG_QUYEN { get; set; }
    }
}
