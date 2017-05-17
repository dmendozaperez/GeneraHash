namespace Configuracion_Servicio
{
    partial class Config_Service
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Config_Service));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkremoto = new System.Windows.Forms.CheckBox();
            this.chklocal = new System.Windows.Forms.CheckBox();
            this.txtremoto = new System.Windows.Forms.TextBox();
            this.rdbremoto = new System.Windows.Forms.RadioButton();
            this.rdblocal = new System.Windows.Forms.RadioButton();
            this.txtlocal = new System.Windows.Forms.TextBox();
            this.btnejecutar = new System.Windows.Forms.Button();
            this.chkproduccion = new System.Windows.Forms.RadioButton();
            this.chkdesarrollo = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkremoto);
            this.groupBox1.Controls.Add(this.chklocal);
            this.groupBox1.Controls.Add(this.txtremoto);
            this.groupBox1.Controls.Add(this.rdbremoto);
            this.groupBox1.Controls.Add(this.rdblocal);
            this.groupBox1.Controls.Add(this.txtlocal);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // chkremoto
            // 
            this.chkremoto.AutoSize = true;
            this.chkremoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkremoto.Location = new System.Drawing.Point(457, 69);
            this.chkremoto.Name = "chkremoto";
            this.chkremoto.Size = new System.Drawing.Size(15, 14);
            this.chkremoto.TabIndex = 7;
            this.chkremoto.UseVisualStyleBackColor = true;
            this.chkremoto.CheckedChanged += new System.EventHandler(this.chkremoto_CheckedChanged);
            // 
            // chklocal
            // 
            this.chklocal.AutoSize = true;
            this.chklocal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chklocal.Location = new System.Drawing.Point(457, 24);
            this.chklocal.Name = "chklocal";
            this.chklocal.Size = new System.Drawing.Size(15, 14);
            this.chklocal.TabIndex = 6;
            this.chklocal.UseVisualStyleBackColor = true;
            this.chklocal.CheckedChanged += new System.EventHandler(this.chklocal_CheckedChanged);
            // 
            // txtremoto
            // 
            this.txtremoto.Enabled = false;
            this.txtremoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtremoto.Location = new System.Drawing.Point(102, 67);
            this.txtremoto.Name = "txtremoto";
            this.txtremoto.Size = new System.Drawing.Size(352, 21);
            this.txtremoto.TabIndex = 5;
            this.txtremoto.Text = "http://www.bgr.pe/web_site_electronica/ws_bata.asmx";
            // 
            // rdbremoto
            // 
            this.rdbremoto.AutoSize = true;
            this.rdbremoto.Checked = true;
            this.rdbremoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbremoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbremoto.Location = new System.Drawing.Point(14, 70);
            this.rdbremoto.Name = "rdbremoto";
            this.rdbremoto.Size = new System.Drawing.Size(75, 19);
            this.rdbremoto.TabIndex = 4;
            this.rdbremoto.TabStop = true;
            this.rdbremoto.Text = "Remoto";
            this.rdbremoto.UseVisualStyleBackColor = true;
            this.rdbremoto.CheckedChanged += new System.EventHandler(this.rdbremoto_CheckedChanged);
            // 
            // rdblocal
            // 
            this.rdblocal.AutoSize = true;
            this.rdblocal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdblocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdblocal.Location = new System.Drawing.Point(14, 23);
            this.rdblocal.Name = "rdblocal";
            this.rdblocal.Size = new System.Drawing.Size(60, 19);
            this.rdblocal.TabIndex = 3;
            this.rdblocal.Text = "Local";
            this.rdblocal.UseVisualStyleBackColor = true;
            this.rdblocal.CheckedChanged += new System.EventHandler(this.rdblocal_CheckedChanged);
            // 
            // txtlocal
            // 
            this.txtlocal.Enabled = false;
            this.txtlocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlocal.Location = new System.Drawing.Point(102, 20);
            this.txtlocal.Name = "txtlocal";
            this.txtlocal.Size = new System.Drawing.Size(352, 21);
            this.txtlocal.TabIndex = 2;
            this.txtlocal.Text = "http://10.10.10.208/web_site_electronica/ws_bata.asmx";
            // 
            // btnejecutar
            // 
            this.btnejecutar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnejecutar.Image = global::Configuracion_Servicio.Properties.Resources.b_active;
            this.btnejecutar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnejecutar.Location = new System.Drawing.Point(195, 158);
            this.btnejecutar.Name = "btnejecutar";
            this.btnejecutar.Size = new System.Drawing.Size(75, 23);
            this.btnejecutar.TabIndex = 0;
            this.btnejecutar.Text = "Ejecutar";
            this.btnejecutar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnejecutar.UseVisualStyleBackColor = true;
            this.btnejecutar.Click += new System.EventHandler(this.btnejecutar_Click);
            // 
            // chkproduccion
            // 
            this.chkproduccion.AutoSize = true;
            this.chkproduccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkproduccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkproduccion.Location = new System.Drawing.Point(124, 6);
            this.chkproduccion.Name = "chkproduccion";
            this.chkproduccion.Size = new System.Drawing.Size(107, 17);
            this.chkproduccion.TabIndex = 1;
            this.chkproduccion.TabStop = true;
            this.chkproduccion.Text = "PRODUCCION";
            this.chkproduccion.UseVisualStyleBackColor = true;
            // 
            // chkdesarrollo
            // 
            this.chkdesarrollo.AutoSize = true;
            this.chkdesarrollo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkdesarrollo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkdesarrollo.Location = new System.Drawing.Point(258, 6);
            this.chkdesarrollo.Name = "chkdesarrollo";
            this.chkdesarrollo.Size = new System.Drawing.Size(108, 17);
            this.chkdesarrollo.TabIndex = 2;
            this.chkdesarrollo.TabStop = true;
            this.chkdesarrollo.Text = "DESARROLLO";
            this.chkdesarrollo.UseVisualStyleBackColor = true;
            // 
            // Config_Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(497, 187);
            this.ControlBox = false;
            this.Controls.Add(this.chkdesarrollo);
            this.Controls.Add(this.chkproduccion);
            this.Controls.Add(this.btnejecutar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Config_Service";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracion Servicio";
            this.Load += new System.EventHandler(this.Config_Service_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtremoto;
        private System.Windows.Forms.RadioButton rdbremoto;
        private System.Windows.Forms.RadioButton rdblocal;
        private System.Windows.Forms.TextBox txtlocal;
        private System.Windows.Forms.Button btnejecutar;
        private System.Windows.Forms.CheckBox chkremoto;
        private System.Windows.Forms.CheckBox chklocal;
        private System.Windows.Forms.RadioButton chkproduccion;
        private System.Windows.Forms.RadioButton chkdesarrollo;
    }
}

