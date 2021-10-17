using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDetalle.Entidades
{
    public class RolesDetalle
    {
        [Key]
        public int Id { get; set; }
        public int RolId { get; set; }
        public int PermisoId { get; set; }
        public bool esAsignado { get; set; }

        public RolesDetalle()
        {
            Id = 0;
            RolId = 0;
            PermisoId = 0;
            esAsignado = false;
        }
        public RolesDetalle(int rolId, int permisoId, bool asignado)
        {
            Id = 0;
            RolId = rolId;
            PermisoId = permisoId;
            esAsignado = asignado;
        }
    }
}
