namespace ProyectoDiseñoSoft
{
    partial class Administrador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            linkCerrarSesion = new LinkLabel();
            botonLibro = new Button();
            botonNotificaciones = new Button();
            botonPrestamos = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // linkCerrarSesion
            // 
            linkCerrarSesion.AutoSize = true;
            linkCerrarSesion.Location = new Point(39, 369);
            linkCerrarSesion.Name = "linkCerrarSesion";
            linkCerrarSesion.Size = new Size(116, 25);
            linkCerrarSesion.TabIndex = 6;
            linkCerrarSesion.TabStop = true;
            linkCerrarSesion.Text = "Cerrar Sesión";
            linkCerrarSesion.LinkClicked += linkCerrarSesion_LinkClicked;
            // 
            // botonLibro
            // 
            botonLibro.Location = new Point(88, 143);
            botonLibro.Margin = new Padding(5, 6, 5, 6);
            botonLibro.Name = "botonLibro";
            botonLibro.Size = new Size(250, 58);
            botonLibro.TabIndex = 7;
            botonLibro.Text = "Administrador de Libros";
            botonLibro.UseVisualStyleBackColor = true;
            botonLibro.Click += botonLibro_Click;
            // 
            // botonNotificaciones
            // 
            botonNotificaciones.Location = new Point(300, 245);
            botonNotificaciones.Margin = new Padding(5, 6, 5, 6);
            botonNotificaciones.Name = "botonNotificaciones";
            botonNotificaciones.Size = new Size(250, 58);
            botonNotificaciones.TabIndex = 8;
            botonNotificaciones.Text = "Notificar";
            botonNotificaciones.UseVisualStyleBackColor = true;
            botonNotificaciones.Click += botonNotificaciones_Click;
            // 
            // botonPrestamos
            // 
            botonPrestamos.Location = new Point(506, 143);
            botonPrestamos.Margin = new Padding(5, 6, 5, 6);
            botonPrestamos.Name = "botonPrestamos";
            botonPrestamos.Size = new Size(250, 58);
            botonPrestamos.TabIndex = 9;
            botonPrestamos.Text = "Prestamos";
            botonPrestamos.UseVisualStyleBackColor = true;
            botonPrestamos.Click += botonPrestamos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(312, 39);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(238, 41);
            label1.TabIndex = 65;
            label1.Text = "BIENVENIDO";
            // 
            // Administrador
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 418);
            Controls.Add(label1);
            Controls.Add(botonPrestamos);
            Controls.Add(botonNotificaciones);
            Controls.Add(botonLibro);
            Controls.Add(linkCerrarSesion);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Administrador";
            Text = "Pantalla de Administrador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkCerrarSesion;
        private Button botonLibro;
        private Button botonNotificaciones;
        private Button botonPrestamos;
        private Label label1;
    }
}