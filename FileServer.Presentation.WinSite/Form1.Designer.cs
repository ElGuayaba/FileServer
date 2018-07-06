namespace FileServer.Presentation.WinSite
{
	partial class FormaAlumno
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.SaveBtn = new System.Windows.Forms.Button();
			this.IDBox = new System.Windows.Forms.TextBox();
			this.NameBox = new System.Windows.Forms.TextBox();
			this.LastNameBox = new System.Windows.Forms.TextBox();
			this.DNIBox = new System.Windows.Forms.TextBox();
			this.IDLabel = new System.Windows.Forms.Label();
			this.NameLabel = new System.Windows.Forms.Label();
			this.LastNameLabel = new System.Windows.Forms.Label();
			this.DNILabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// SaveBtn
			// 
			this.SaveBtn.Location = new System.Drawing.Point(64, 221);
			this.SaveBtn.Name = "SaveBtn";
			this.SaveBtn.Size = new System.Drawing.Size(85, 25);
			this.SaveBtn.TabIndex = 0;
			this.SaveBtn.Text = "Guardar";
			this.SaveBtn.UseVisualStyleBackColor = true;
			this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
			// 
			// IDBox
			// 
			this.IDBox.Location = new System.Drawing.Point(28, 45);
			this.IDBox.Name = "IDBox";
			this.IDBox.Size = new System.Drawing.Size(159, 20);
			this.IDBox.TabIndex = 1;
			// 
			// NameBox
			// 
			this.NameBox.Location = new System.Drawing.Point(28, 88);
			this.NameBox.Name = "NameBox";
			this.NameBox.Size = new System.Drawing.Size(159, 20);
			this.NameBox.TabIndex = 2;
			// 
			// LastNameBox
			// 
			this.LastNameBox.Location = new System.Drawing.Point(28, 129);
			this.LastNameBox.Name = "LastNameBox";
			this.LastNameBox.Size = new System.Drawing.Size(157, 20);
			this.LastNameBox.TabIndex = 3;
			// 
			// DNIBox
			// 
			this.DNIBox.Location = new System.Drawing.Point(29, 170);
			this.DNIBox.Name = "DNIBox";
			this.DNIBox.Size = new System.Drawing.Size(158, 20);
			this.DNIBox.TabIndex = 4;
			// 
			// IDLabel
			// 
			this.IDLabel.AutoSize = true;
			this.IDLabel.Location = new System.Drawing.Point(26, 29);
			this.IDLabel.Name = "IDLabel";
			this.IDLabel.Size = new System.Drawing.Size(18, 13);
			this.IDLabel.TabIndex = 5;
			this.IDLabel.Text = "ID";
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Location = new System.Drawing.Point(26, 72);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(44, 13);
			this.NameLabel.TabIndex = 6;
			this.NameLabel.Text = "Nombre";
			// 
			// LastNameLabel
			// 
			this.LastNameLabel.AutoSize = true;
			this.LastNameLabel.Location = new System.Drawing.Point(26, 113);
			this.LastNameLabel.Name = "LastNameLabel";
			this.LastNameLabel.Size = new System.Drawing.Size(49, 13);
			this.LastNameLabel.TabIndex = 7;
			this.LastNameLabel.Text = "Apellidos";
			// 
			// DNILabel
			// 
			this.DNILabel.AutoSize = true;
			this.DNILabel.Location = new System.Drawing.Point(26, 154);
			this.DNILabel.Name = "DNILabel";
			this.DNILabel.Size = new System.Drawing.Size(26, 13);
			this.DNILabel.TabIndex = 8;
			this.DNILabel.Text = "DNI";
			// 
			// FormaAlumno
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(212, 258);
			this.Controls.Add(this.DNILabel);
			this.Controls.Add(this.LastNameLabel);
			this.Controls.Add(this.NameLabel);
			this.Controls.Add(this.IDLabel);
			this.Controls.Add(this.DNIBox);
			this.Controls.Add(this.LastNameBox);
			this.Controls.Add(this.NameBox);
			this.Controls.Add(this.IDBox);
			this.Controls.Add(this.SaveBtn);
			this.Name = "FormaAlumno";
			this.Text = "Forma De Alumno";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button SaveBtn;
		private System.Windows.Forms.TextBox IDBox;
		private System.Windows.Forms.TextBox NameBox;
		private System.Windows.Forms.TextBox LastNameBox;
		private System.Windows.Forms.TextBox DNIBox;
		private System.Windows.Forms.Label IDLabel;
		private System.Windows.Forms.Label NameLabel;
		private System.Windows.Forms.Label LastNameLabel;
		private System.Windows.Forms.Label DNILabel;
	}
}

