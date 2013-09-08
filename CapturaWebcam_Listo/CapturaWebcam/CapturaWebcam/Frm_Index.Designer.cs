namespace CapturaWebcam
{
    partial class Frm_Index
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Index));
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.pctbox_webcam = new System.Windows.Forms.PictureBox();
            this.btn_capturar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_webcam)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.Location = new System.Drawing.Point(12, 357);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(100, 35);
            this.btn_iniciar.TabIndex = 1;
            this.btn_iniciar.Text = "Iniciar";
            this.btn_iniciar.UseVisualStyleBackColor = true;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_capturar_Click);
            // 
            // pctbox_webcam
            // 
            this.pctbox_webcam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctbox_webcam.Location = new System.Drawing.Point(39, 28);
            this.pctbox_webcam.Name = "pctbox_webcam";
            this.pctbox_webcam.Size = new System.Drawing.Size(300, 300);
            this.pctbox_webcam.TabIndex = 2;
            this.pctbox_webcam.TabStop = false;
            // 
            // btn_capturar
            // 
            this.btn_capturar.Location = new System.Drawing.Point(136, 357);
            this.btn_capturar.Name = "btn_capturar";
            this.btn_capturar.Size = new System.Drawing.Size(100, 35);
            this.btn_capturar.TabIndex = 6;
            this.btn_capturar.Text = "Capturar";
            this.btn_capturar.UseVisualStyleBackColor = true;
            this.btn_capturar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(267, 357);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(100, 35);
            this.btn_guardar.TabIndex = 7;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click_1);
            // 
            // Frm_Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 414);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_capturar);
            this.Controls.Add(this.pctbox_webcam);
            this.Controls.Add(this.btn_iniciar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Index";
            this.Text = "Capturador de Fotografias";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Index_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Index_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_webcam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.PictureBox pctbox_webcam;
        private System.Windows.Forms.Button btn_capturar;
        private System.Windows.Forms.Button btn_guardar;
    }
}

