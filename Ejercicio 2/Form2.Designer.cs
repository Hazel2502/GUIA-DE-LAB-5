
namespace Ejercicio_2
{
    partial class Form2
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
            this.txtMensaje3 = new System.Windows.Forms.TextBox();
            this.txtMensaje2 = new System.Windows.Forms.TextBox();
            this.txtMensaje1 = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgdDatos = new System.Windows.Forms.DataGridView();
            this.btnCargardatos = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgdDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMensaje3
            // 
            this.txtMensaje3.Location = new System.Drawing.Point(309, 172);
            this.txtMensaje3.Name = "txtMensaje3";
            this.txtMensaje3.Size = new System.Drawing.Size(252, 22);
            this.txtMensaje3.TabIndex = 19;
            // 
            // txtMensaje2
            // 
            this.txtMensaje2.Location = new System.Drawing.Point(309, 102);
            this.txtMensaje2.Name = "txtMensaje2";
            this.txtMensaje2.Size = new System.Drawing.Size(252, 22);
            this.txtMensaje2.TabIndex = 18;
            // 
            // txtMensaje1
            // 
            this.txtMensaje1.Location = new System.Drawing.Point(309, 43);
            this.txtMensaje1.Name = "txtMensaje1";
            this.txtMensaje1.Size = new System.Drawing.Size(252, 22);
            this.txtMensaje1.TabIndex = 17;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(109, 175);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(65, 17);
            this.lblApellidos.TabIndex = 16;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(109, 107);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(65, 17);
            this.lblNombres.TabIndex = 15;
            this.lblNombres.Text = "Nombres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID";
            // 
            // dgdDatos
            // 
            this.dgdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdDatos.Location = new System.Drawing.Point(112, 243);
            this.dgdDatos.Name = "dgdDatos";
            this.dgdDatos.RowHeadersWidth = 51;
            this.dgdDatos.RowTemplate.Height = 24;
            this.dgdDatos.Size = new System.Drawing.Size(463, 272);
            this.dgdDatos.TabIndex = 20;
            // 
            // btnCargardatos
            // 
            this.btnCargardatos.Location = new System.Drawing.Point(406, 556);
            this.btnCargardatos.Name = "btnCargardatos";
            this.btnCargardatos.Size = new System.Drawing.Size(124, 47);
            this.btnCargardatos.TabIndex = 21;
            this.btnCargardatos.Text = "Cargar datos";
            this.btnCargardatos.UseVisualStyleBackColor = true;
            this.btnCargardatos.Click += new System.EventHandler(this.btnCargardatos_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(599, 556);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(90, 47);
            this.btnCerrar.TabIndex = 22;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 615);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCargardatos);
            this.Controls.Add(this.dgdDatos);
            this.Controls.Add(this.txtMensaje3);
            this.Controls.Add(this.txtMensaje2);
            this.Controls.Add(this.txtMensaje1);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMensaje3;
        private System.Windows.Forms.TextBox txtMensaje2;
        private System.Windows.Forms.TextBox txtMensaje1;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgdDatos;
        private System.Windows.Forms.Button btnCargardatos;
        private System.Windows.Forms.Button btnCerrar;
    }
}