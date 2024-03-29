//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PcSborka.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Computer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Computer()
        {
            this.Order = new HashSet<Order>();
        }
    
        public int ID { get; set; }
        public Nullable<int> CPUID { get; set; }
        public Nullable<int> MotherBoardID { get; set; }
        public Nullable<int> GraphicCardID { get; set; }
        public Nullable<int> RAMID { get; set; }
        public Nullable<int> CaseID { get; set; }
        public Nullable<int> PowerSupplyID { get; set; }
        public Nullable<int> CoolerID { get; set; }
    
        public virtual Case Case { get; set; }
        public virtual Cooler Cooler { get; set; }
        public virtual CPU CPU { get; set; }
        public virtual GPU GPU { get; set; }
        public virtual MotherBoard MotherBoard { get; set; }
        public virtual PowerSupply PowerSupply { get; set; }
        public virtual RAM RAM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }

        public double SumComponents { get; set; }

        public bool isBuildComputer { get; set; } = false;
        

    }
}
