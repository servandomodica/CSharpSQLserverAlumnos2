namespace Proyecto23
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDeCarrerasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDeMateriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDeAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDeInscripcionesAMateriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDeNotasDeAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoDeCarrerasToolStripMenuItem,
            this.mantenimientoDeMateriasToolStripMenuItem,
            this.mantenimientoDeAlumnoToolStripMenuItem,
            this.mantenimientoDeInscripcionesAMateriasToolStripMenuItem,
            this.mantenimientoDeNotasDeAlumnosToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // mantenimientoDeCarrerasToolStripMenuItem
            // 
            this.mantenimientoDeCarrerasToolStripMenuItem.Name = "mantenimientoDeCarrerasToolStripMenuItem";
            this.mantenimientoDeCarrerasToolStripMenuItem.Size = new System.Drawing.Size(301, 22);
            this.mantenimientoDeCarrerasToolStripMenuItem.Text = "Mantenimiento de carreras";
            this.mantenimientoDeCarrerasToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoDeCarrerasToolStripMenuItem_Click);
            // 
            // mantenimientoDeMateriasToolStripMenuItem
            // 
            this.mantenimientoDeMateriasToolStripMenuItem.Name = "mantenimientoDeMateriasToolStripMenuItem";
            this.mantenimientoDeMateriasToolStripMenuItem.Size = new System.Drawing.Size(301, 22);
            this.mantenimientoDeMateriasToolStripMenuItem.Text = "Mantenimiento de materias";
            this.mantenimientoDeMateriasToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoDeMateriasToolStripMenuItem_Click);
            // 
            // mantenimientoDeAlumnoToolStripMenuItem
            // 
            this.mantenimientoDeAlumnoToolStripMenuItem.Name = "mantenimientoDeAlumnoToolStripMenuItem";
            this.mantenimientoDeAlumnoToolStripMenuItem.Size = new System.Drawing.Size(301, 22);
            this.mantenimientoDeAlumnoToolStripMenuItem.Text = "Mantenimiento de alumnos";
            this.mantenimientoDeAlumnoToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoDeAlumnoToolStripMenuItem_Click);
            // 
            // mantenimientoDeInscripcionesAMateriasToolStripMenuItem
            // 
            this.mantenimientoDeInscripcionesAMateriasToolStripMenuItem.Name = "mantenimientoDeInscripcionesAMateriasToolStripMenuItem";
            this.mantenimientoDeInscripcionesAMateriasToolStripMenuItem.Size = new System.Drawing.Size(301, 22);
            this.mantenimientoDeInscripcionesAMateriasToolStripMenuItem.Text = "Mantenimiento de inscripciones a materias";
            this.mantenimientoDeInscripcionesAMateriasToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoDeInscripcionesAMateriasToolStripMenuItem_Click);
            // 
            // mantenimientoDeNotasDeAlumnosToolStripMenuItem
            // 
            this.mantenimientoDeNotasDeAlumnosToolStripMenuItem.Name = "mantenimientoDeNotasDeAlumnosToolStripMenuItem";
            this.mantenimientoDeNotasDeAlumnosToolStripMenuItem.Size = new System.Drawing.Size(301, 22);
            this.mantenimientoDeNotasDeAlumnosToolStripMenuItem.Text = "Mantenimiento de notas de alumnos";
            this.mantenimientoDeNotasDeAlumnosToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoDeNotasDeAlumnosToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDeCarrerasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDeMateriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDeAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDeInscripcionesAMateriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDeNotasDeAlumnosToolStripMenuItem;
    }
}

