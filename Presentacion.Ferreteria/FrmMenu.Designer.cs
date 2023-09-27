namespace Presentacion.Ferreteria
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.titulo = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.Menu = new System.Windows.Forms.ToolStrip();
            this.OptRefacciones = new System.Windows.Forms.ToolStripButton();
            this.OptHerramientas = new System.Windows.Forms.ToolStripButton();
            this.OptUsuarios = new System.Windows.Forms.ToolStripButton();
            this.titulo.SuspendLayout();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AllowMerge = false;
            this.titulo.AutoSize = false;
            this.titulo.BackColor = System.Drawing.Color.Crimson;
            this.titulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.titulo.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.titulo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.toolStripLabel1});
            this.titulo.Location = new System.Drawing.Point(0, 0);
            this.titulo.Name = "titulo";
            this.titulo.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.titulo.Size = new System.Drawing.Size(884, 60);
            this.titulo.TabIndex = 0;
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.AutoSize = false;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(390, 50);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(116, 57);
            this.toolStripLabel1.Text = "Ferreteria";
            // 
            // Menu
            // 
            this.Menu.AllowMerge = false;
            this.Menu.AutoSize = false;
            this.Menu.BackColor = System.Drawing.Color.Crimson;
            this.Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Menu.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OptRefacciones,
            this.OptHerramientas,
            this.OptUsuarios});
            this.Menu.Location = new System.Drawing.Point(0, 60);
            this.Menu.Name = "Menu";
            this.Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.Menu.Size = new System.Drawing.Size(884, 30);
            this.Menu.TabIndex = 1;
            // 
            // OptRefacciones
            // 
            this.OptRefacciones.Image = ((System.Drawing.Image)(resources.GetObject("OptRefacciones.Image")));
            this.OptRefacciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OptRefacciones.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OptRefacciones.Name = "OptRefacciones";
            this.OptRefacciones.Size = new System.Drawing.Size(78, 27);
            this.OptRefacciones.Text = "Refacciones";
            this.OptRefacciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OptRefacciones.Click += new System.EventHandler(this.OptRefacciones_Click);
            // 
            // OptHerramientas
            // 
            this.OptHerramientas.Image = ((System.Drawing.Image)(resources.GetObject("OptHerramientas.Image")));
            this.OptHerramientas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OptHerramientas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OptHerramientas.Name = "OptHerramientas";
            this.OptHerramientas.Size = new System.Drawing.Size(83, 27);
            this.OptHerramientas.Text = "Herramientas";
            this.OptHerramientas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OptHerramientas.Click += new System.EventHandler(this.OptHerramientas_Click);
            // 
            // OptUsuarios
            // 
            this.OptUsuarios.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.OptUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("OptUsuarios.Image")));
            this.OptUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OptUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OptUsuarios.Name = "OptUsuarios";
            this.OptUsuarios.Size = new System.Drawing.Size(65, 27);
            this.OptUsuarios.Text = "Usuarios";
            this.OptUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OptUsuarios.Click += new System.EventHandler(this.OptUsuarios_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.titulo);
            this.IsMdiContainer = true;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.titulo.ResumeLayout(false);
            this.titulo.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip titulo;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStrip Menu;
        private System.Windows.Forms.ToolStripButton OptRefacciones;
        private System.Windows.Forms.ToolStripButton OptHerramientas;
        private System.Windows.Forms.ToolStripButton OptUsuarios;
    }
}

