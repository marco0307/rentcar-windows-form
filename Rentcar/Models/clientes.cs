//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Rentcar.Models
{

using System;
    using System.Collections.Generic;
    
public partial class clientes
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public clientes()
    {

        this.rentas = new HashSet<rentas>();

    }


    public int id { get; set; }

    public string full_name { get; set; }

    public string cedula { get; set; }

    public string numero_cr { get; set; }

    public string limite_credito { get; set; }

    public string tipo { get; set; }

    public bool estado { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<rentas> rentas { get; set; }

}

}
