
namespace Ejercicio_2
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
            this.btnEnviardatos = new System.Windows.Forms.Button();
            this.btnEnviarregistro = new System.Windows.Forms.Button();
            this.txtMensaje3 = new System.Windows.Forms.TextBox();
            this.txtMensaje2 = new System.Windows.Forms.TextBox();
            this.txtMensaje1 = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnviardatos
            // 
            this.btnEnviardatos.Location = new System.Drawing.Point(453, 323);
            this.btnEnviardatos.Name = "btnEnviardatos";
            this.btnEnviardatos.Size = new System.Drawing.Size(148, 36);
            this.btnEnviardatos.TabIndex = 15;
            this.btnEnviardatos.Text = "Enviar datos";
            this.btnEnviardatos.UseVisualStyleBackColor = true;
            this.btnEnviardatos.Click += new System.EventHandler(this.btnEnviardatos_Click);
            // 
            // btnEnviarregistro
            // 
            this.btnEnviarregistro.Location = new System.Drawing.Point(161, 323);
            this.btnEnviarregistro.Name = "btnEnviarregistro";
            this.btnEnviarregistro.Size = new System.Drawing.Size(139, 36);
            this.btnEnviarregistro.TabIndex = 14;
            this.btnEnviarregistro.Text = "Enviar registro";
            this.btnEnviarregistro.UseVisualStyleBackColor = true;
            this.btnEnviarregistro.Click += new System.EventHandler(this.btnEnviarregistro_Click);
            // 
            // txtMensaje3
            // 
            this.txtMensaje3.Location = new System.Drawing.Point(391, 213);
            this.txtMensaje3.Name = "txtMensaje3";
            this.txtMensaje3.Size = new System.Drawing.Size(252, 22);
            this.txtMensaje3.TabIndex = 13;
            // 
            // txtMensaje2
            // 
            this.txtMensaje2.Location = new System.Drawing.Point(391, 153);
            this.txtMensaje2.Name = "txtMensaje2";
            this.txtMensaje2.Size = new System.Drawing.Size(252, 22);
            this.txtMensaje2.TabIndex = 12;
            // 
            // txtMensaje1
            // 
            this.txtMensaje1.Location = new System.Drawing.Point(391, 91);
            this.txtMensaje1.Name = "txtMensaje1";
            this.txtMensaje1.Size = new System.Drawing.Size(252, 22);
            this.txtMensaje1.TabIndex = 11;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(158, 213);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(65, 17);
            this.lblApellidos.TabIndex = 10;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(158, 153);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(65, 17);
            this.lblNombres.TabIndex = 9;
            this.lblNombres.Text = "Nombres";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(158, 96);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 17);
            this.lblId.TabIndex = 8;
            this.lblId.Text = "ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnviardatos);
            this.Controls.Add(this.btnEnviarregistro);
            this.Controls.Add(this.txtMensaje3);
            this.Controls.Add(this.txtMensaje2);
            this.Controls.Add(this.txtMensaje1);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.lblId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviardatos;
        private System.Windows.Forms.Button btnEnviarregistro;
        private System.Windows.Forms.TextBox txtMensaje3;
        private System.Windows.Forms.TextBox txtMensaje2;
        private System.Windows.Forms.TextBox txtMensaje1;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblId;
    }
}

