using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace registroDestalle.Entidades
{
    class Usuarios
    {
        [Key]
        public int Id { get; set; }
        public int RolId { get; set; }
        public string PermisoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        

        [ForeignKey("RolId")]
        public virtual Roles Rol { get; set; }
    }
}
