//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APIProyectoSC_601
{
    using System;
    using System.Collections.Generic;
    
    public partial class Proveedores
    {
        public long ID_Proveedor { get; set; }
        public string Nombre_Proveedor { get; set; }
        public string Apellido_Proveedor { get; set; }
        public string Cedula_Proveedor { get; set; }
        public string Direccion_Exacta { get; set; }
        public int Estado_Proveedor { get; set; }
        public long Empresa { get; set; }
    
        public virtual Empresa Empresa1 { get; set; }
        public virtual Estado Estado { get; set; }
    }
}
