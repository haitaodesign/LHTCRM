//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace LHT.CRM.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class CRM_Contact
    {
        public int Id { get; set; }
        public Nullable<int> CId { get; set; }
        public Nullable<System.DateTime> CDate { get; set; }
        public Nullable<int> MId { get; set; }
        public Nullable<System.DateTime> MDate { get; set; }
        public Nullable<int> CusId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string JiGuan { get; set; }
        public string DeptName { get; set; }
        public string Position { get; set; }
        public string Mobile { get; set; }
        public string WX { get; set; }
        public string Email { get; set; }
    }
}
