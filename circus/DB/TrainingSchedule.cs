//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace circus.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class TrainingSchedule
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> IdTraining { get; set; }
        public Nullable<int> IdAnimal { get; set; }
    
        public virtual AnimalCell AnimalCell { get; set; }
        public virtual Training Training { get; set; }
    }
}
