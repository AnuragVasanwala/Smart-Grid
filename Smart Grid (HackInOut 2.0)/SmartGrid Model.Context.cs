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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SmartGridSQLEntities1 : DbContext
    {
        public SmartGridSQLEntities1()
            : base("name=SmartGridSQLEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CMDeviceInfo> CMDeviceInfoes { get; set; }
        public virtual DbSet<GridInfo> GridInfoes { get; set; }
        public virtual DbSet<GridStatu> GridStatus { get; set; }
        public virtual DbSet<GridPolylineInfo> GridPolylineInfoes { get; set; }
    }
}
