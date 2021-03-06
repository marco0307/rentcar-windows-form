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
    
public partial class vehiculos
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public vehiculos()
    {

        this.rentas = new HashSet<rentas>();

    }


    public int id { get; set; }

    public string descripcion { get; set; }

    public string chasis { get; set; }

    public string motor { get; set; }

    public string placa { get; set; }

    public Nullable<int> anio { get; set; }

    public Nullable<int> tipo_vehiculo_id { get; set; }

    public Nullable<int> marca_id { get; set; }

    public Nullable<int> modelo_id { get; set; }

    public Nullable<int> combustible_id { get; set; }

    public bool estado { get; set; }

    public string vehiculo { get; set; }



    public virtual combustibles combustibles { get; set; }

    public virtual marcas marcas { get; set; }

    public virtual modelos modelos { get; set; }

    public virtual tipovehiculos tipovehiculos { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<rentas> rentas { get; set; }

}

}
