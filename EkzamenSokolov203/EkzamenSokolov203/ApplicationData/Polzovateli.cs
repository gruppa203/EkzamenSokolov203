//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EkzamenSokolov203.ApplicationData
{
    using System;
    using System.Collections.Generic;
    
    public partial class Polzovateli
    {
        public int Cod_Polzovatelya { get; set; }
        public string Imya_Polzovatelya { get; set; }
        public string Familiya_Polzovatelya { get; set; }
        public string Login { get; set; }
        public string Parol { get; set; }
        public int Nomer_Roli { get; set; }
    
        public virtual Roli Roli { get; set; }
    }
}
