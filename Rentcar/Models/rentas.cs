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
    
public partial class rentas
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public rentas()
    {

        this.inspeccions = new HashSet<inspeccions>();

    }


    public int id { get; set; }

    public Nullable<System.DateTime> fecha_renta { get; set; }

    public Nullable<System.DateTime> fecha_devolucion { get; set; }

    public Nullable<int> monto { get; set; }

    public Nullable<int> dias { get; set; }

    public string comentario { get; set; }

    public Nullable<int> empleado_id { get; set; }

    public Nullable<int> vehiculo_id { get; set; }

    public Nullable<int> cliente_id { get; set; }

    public bool estado { get; set; }



    public virtual clientes clientes { get; set; }

    public virtual empleados empleados { get; set; }

    public virtual vehiculos vehiculos { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<inspeccions> inspeccions { get; set; }

}

}