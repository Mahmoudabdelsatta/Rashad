//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace rashad.MOdel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Item
    {
        public int Item_ID { get; set; }
        public string Item_Name { get; set; }
        public Nullable<double> Quantity { get; set; }
        public Nullable<double> Purchusing_Price { get; set; }
        public Nullable<double> Wholesales_Price { get; set; }
        public Nullable<double> Sector_Price { get; set; }
        public Nullable<int> categori_Id { get; set; }
        public Nullable<double> Total_Price { get; set; }
    
        public virtual category category { get; set; }
    }
}