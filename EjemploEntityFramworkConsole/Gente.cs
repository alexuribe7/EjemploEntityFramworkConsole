//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EjemploEntityFramworkConsole
{
    using System;
    using System.Collections.Generic;
    
    public partial class Gente
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public Nullable<int> edad { get; set; }
        public Nullable<int> idSexo { get; set; }
    
        public virtual cSexo cSexo { get; set; }
    }
}
