using System;
using FileServer.Common.Model;
using FileServer.Infrastructure.Repository.Interfaces;

namespace FileServer.Infrastructure.Repository.Repositories
{
	public class AlumnoRepository : IAlumnoRepository
	{
		public bool Filled(Alumno alumno)
		{
			if (alumno.Id <= 0
				|| String.IsNullOrEmpty(alumno.Nombre)
				|| String.IsNullOrEmpty(alumno.Apellido)
				|| String.IsNullOrEmpty(alumno.Dni))
			{
				return false;
			}
			return true;
		}
		public Alumno Add(Alumno alumno)
		{
			Environment.CurrentDirectory = Environment.GetEnvironmentVariable("VUELING_HOME");
			string path = "Alumno.json";

			FileManager fm = new FileManager();
			fm.FileCreate(path);
			string alumnoJson = fm.JsonSerialize(alumno);
			fm.FileWrite(alumnoJson,path);
			return alumno;
		}
	}
}
