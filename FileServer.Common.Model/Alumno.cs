using System;
using System.Collections.Generic;

namespace FileServer.Common.Model
{
    public class Alumno
    {
		public int Id { get; set; }
		public string Nombre { get; set; }
		public string Apellido { get; set; }
		public string Dni { get; set; }
		public Alumno(int Id, string Nombre, string Apellido, string Dni)
		{
			this.Id = Id;
			this.Nombre = Nombre;
			this.Apellido = Apellido;
			this.Dni = Dni;
		}

		public override bool Equals(object obj)
		{
			var alumno = obj as Alumno;
			return alumno != null &&
				   Id == alumno.Id &&
				   Nombre == alumno.Nombre &&
				   Apellido == alumno.Apellido &&
				   Dni == alumno.Dni;
		}

		public override int GetHashCode()
		{
			var hashCode = -1910929195;
			hashCode = hashCode * -1521134295 + Id.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nombre);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Apellido);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Dni);
			return hashCode;
		}
	}
}
