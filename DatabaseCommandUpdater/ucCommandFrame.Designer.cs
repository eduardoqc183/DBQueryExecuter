
namespace DatabaseCommandUpdater
{
    partial class ucCommandFrame
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            this.txtQuery = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.btnCerrar = new Infragistics.Win.Misc.UltraButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuery)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQuery
            // 
            this.txtQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            appearance1.FontData.Name = "Courier New";
            this.txtQuery.Appearance = appearance1;
            this.txtQuery.Location = new System.Drawing.Point(3, 31);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(429, 288);
            this.txtQuery.TabIndex = 0;
            this.txtQuery.Text = "select * from [tablename];";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance2.Image = global::DatabaseCommandUpdater.Properties.Resources.system_close;
            this.btnCerrar.Appearance = appearance2;
            this.btnCerrar.Location = new System.Drawing.Point(357, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Borrar";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // ucCommandFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txtQuery);
            this.Name = "ucCommandFrame";
            this.Size = new System.Drawing.Size(435, 322);
            this.Load += new System.EventHandler(this.ucCommandFrame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtQuery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtQuery;
        private Infragistics.Win.Misc.UltraButton btnCerrar;
    }
}
