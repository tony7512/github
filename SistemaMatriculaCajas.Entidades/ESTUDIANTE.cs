//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaMatriculaCajas.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class ESTUDIANTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ESTUDIANTE()
        {
            this.MATRICULA = new HashSet<MATRICULA>();
            this.RD = new HashSet<RD>();
        }
    
        public int Cod_Estudiante { get; set; }
        public string Ident_Estudiante { get; set; }
        public string Situacion_Acadm { get; set; }
        public string Estado_Acadm { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MATRICULA> MATRICULA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RD> RD { get; set; }
    }
}
