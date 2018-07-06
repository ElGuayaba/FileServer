using System;
using System.Windows.Forms;
using FileServer.Common.Model;
using FileServer.Infrastructure.Repository.Repositories;
using FileServer.Infrastructure.Repository;

namespace FileServer.Presentation.WinSite
{
	public partial class FormaAlumno : Form
	{
		public FormaAlumno()
		{
			InitializeComponent();
		}

		private void SaveBtn_Click(object sender, EventArgs e)
		{
			if (FileManager.IsParseable(IDBox.Text)
				&& !String.IsNullOrEmpty(NameBox.Text)
				&& !String.IsNullOrEmpty(LastNameBox.Text)
				&& !String.IsNullOrEmpty(DNIBox.Text))
			{
				Alumno alumno = new Alumno(Int32.Parse(IDBox.Text), NameBox.Text,
				LastNameBox.Text, DNIBox.Text);
				AlumnoRepository aRepo = new AlumnoRepository();
				aRepo.Add(alumno);
			}else{
				MessageBox.Show("Campos Vacíos o ID");
			}
		}
	}
}
