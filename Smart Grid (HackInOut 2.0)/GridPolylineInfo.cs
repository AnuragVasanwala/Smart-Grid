//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Smart_Grid__HackInOut_2._0_
{
    using System;
    using System.Collections.Generic;
    
    public partial class GridPolylineInfo
    {
        public int Id { get; set; }
        public decimal Latitude1 { get; set; }
        public decimal Longitude1 { get; set; }
        public decimal Latitude2 { get; set; }
        public decimal Longitude2 { get; set; }
        public string AreaName { get; set; }
    
        public virtual GridInfo GridInfo { get; set; }
    }
}
