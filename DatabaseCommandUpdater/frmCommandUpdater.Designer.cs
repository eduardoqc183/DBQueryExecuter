
namespace DatabaseCommandUpdater
{
    partial class frmCommandUpdater
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
            this.components = new System.ComponentModel.Container();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("DbInfo", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("DbName");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccionado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoInfo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("IconoEstado");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn17 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Error");
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelAcciones = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ultraGrid1 = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ucTiles = new Infragistics.Win.Misc.UltraTilePanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnAgregarComando = new System.Windows.Forms.Button();
            this.ultraTile1 = new Infragistics.Win.Misc.UltraTile();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.bsConexion = new System.Windows.Forms.BindingSource(this.components);
            this.bsDbs = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelAcciones.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ucTiles)).BeginInit();
            this.ucTiles.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsConexion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDbs)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelAcciones, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.46676F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.53324F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1069, 707);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 62);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "MotorBD:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "MSQL",
            "PGSQL"});
            this.comboBox1.Location = new System.Drawing.Point(18, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Image = global::DatabaseCommandUpdater.Properties.Resources.page_white_connect;
            this.btnConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConnect.Location = new System.Drawing.Point(885, 11);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(157, 36);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "&Conectar";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConexion, "Port", true));
            this.textBox4.Location = new System.Drawing.Point(499, 27);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(112, 20);
            this.textBox4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(496, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Puerto";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConexion, "Password", true));
            this.textBox3.Location = new System.Drawing.Point(381, 27);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.Size = new System.Drawing.Size(112, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConexion, "User", true));
            this.textBox2.Location = new System.Drawing.Point(263, 27);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(112, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "User:";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConexion, "ServerName", true));
            this.textBox1.Location = new System.Drawing.Point(145, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server:";
            // 
            // panelAcciones
            // 
            this.panelAcciones.ColumnCount = 2;
            this.panelAcciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.29445F));
            this.panelAcciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.70555F));
            this.panelAcciones.Controls.Add(this.panel3, 0, 0);
            this.panelAcciones.Controls.Add(this.panel2, 0, 0);
            this.panelAcciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAcciones.Enabled = false;
            this.panelAcciones.Location = new System.Drawing.Point(3, 71);
            this.panelAcciones.Name = "panelAcciones";
            this.panelAcciones.RowCount = 1;
            this.panelAcciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelAcciones.Size = new System.Drawing.Size(1063, 581);
            this.panelAcciones.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ultraGrid1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(526, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(534, 575);
            this.panel3.TabIndex = 2;
            // 
            // ultraGrid1
            // 
            this.ultraGrid1.DataSource = this.bsDbs;
            appearance1.BackColor = System.Drawing.SystemColors.Window;
            appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.ultraGrid1.DisplayLayout.Appearance = appearance1;
            ultraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly;
            ultraGridColumn1.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn1.Header.Caption = "BD";
            ultraGridColumn1.Header.Editor = null;
            ultraGridColumn1.Header.VisiblePosition = 1;
            ultraGridColumn1.Width = 291;
            ultraGridColumn2.FilterOperandStyle = Infragistics.Win.UltraWinGrid.FilterOperandStyle.None;
            ultraGridColumn2.Header.Caption = "";
            ultraGridColumn2.Header.CheckBoxSynchronization = Infragistics.Win.UltraWinGrid.HeaderCheckBoxSynchronization.Band;
            ultraGridColumn2.Header.CheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.Always;
            ultraGridColumn2.Header.Editor = null;
            ultraGridColumn2.Header.VisiblePosition = 0;
            ultraGridColumn2.Width = 67;
            ultraGridColumn3.Header.Editor = null;
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn3.Hidden = true;
            ultraGridColumn3.Width = 37;
            ultraGridColumn4.Header.Caption = "Estado";
            ultraGridColumn4.Header.Editor = null;
            ultraGridColumn4.Header.VisiblePosition = 3;
            ultraGridColumn4.Width = 112;
            appearance2.ImageHAlign = Infragistics.Win.HAlign.Center;
            ultraGridColumn7.CellAppearance = appearance2;
            ultraGridColumn7.FilterOperandStyle = Infragistics.Win.UltraWinGrid.FilterOperandStyle.None;
            ultraGridColumn7.Header.Caption = "";
            ultraGridColumn7.Header.Editor = null;
            ultraGridColumn7.Header.VisiblePosition = 4;
            ultraGridColumn7.Hidden = true;
            ultraGridColumn7.Width = 23;
            ultraGridColumn17.FilterOperandStyle = Infragistics.Win.UltraWinGrid.FilterOperandStyle.None;
            ultraGridColumn17.Header.Editor = null;
            ultraGridColumn17.Header.VisiblePosition = 5;
            ultraGridColumn17.Hidden = true;
            ultraGridColumn17.Width = 78;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4,
            ultraGridColumn7,
            ultraGridColumn17});
            this.ultraGrid1.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.ultraGrid1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ultraGrid1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.True;
            appearance3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance3.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance3.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraGrid1.DisplayLayout.GroupByBox.Appearance = appearance3;
            appearance4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraGrid1.DisplayLayout.GroupByBox.BandLabelAppearance = appearance4;
            this.ultraGrid1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance5.BackColor2 = System.Drawing.SystemColors.Control;
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraGrid1.DisplayLayout.GroupByBox.PromptAppearance = appearance5;
            this.ultraGrid1.DisplayLayout.MaxColScrollRegions = 1;
            this.ultraGrid1.DisplayLayout.MaxRowScrollRegions = 1;
            appearance6.BackColor = System.Drawing.SystemColors.Window;
            appearance6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ultraGrid1.DisplayLayout.Override.ActiveCellAppearance = appearance6;
            appearance7.BackColor = System.Drawing.SystemColors.Highlight;
            appearance7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ultraGrid1.DisplayLayout.Override.ActiveRowAppearance = appearance7;
            this.ultraGrid1.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True;
            this.ultraGrid1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.ultraGrid1.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance8.BackColor = System.Drawing.SystemColors.Window;
            this.ultraGrid1.DisplayLayout.Override.CardAreaAppearance = appearance8;
            appearance9.BorderColor = System.Drawing.Color.Silver;
            appearance9.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.ultraGrid1.DisplayLayout.Override.CellAppearance = appearance9;
            this.ultraGrid1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.ultraGrid1.DisplayLayout.Override.CellPadding = 0;
            this.ultraGrid1.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains;
            this.ultraGrid1.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow;
            appearance10.BackColor = System.Drawing.SystemColors.Control;
            appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance10.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance10.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraGrid1.DisplayLayout.Override.GroupByRowAppearance = appearance10;
            appearance11.TextHAlignAsString = "Left";
            this.ultraGrid1.DisplayLayout.Override.HeaderAppearance = appearance11;
            this.ultraGrid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.ultraGrid1.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance12.BackColor = System.Drawing.SystemColors.Window;
            appearance12.BorderColor = System.Drawing.Color.Silver;
            this.ultraGrid1.DisplayLayout.Override.RowAppearance = appearance12;
            this.ultraGrid1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance13.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ultraGrid1.DisplayLayout.Override.TemplateAddRowAppearance = appearance13;
            this.ultraGrid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ultraGrid1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ultraGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraGrid1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraGrid1.Location = new System.Drawing.Point(0, 0);
            this.ultraGrid1.Name = "ultraGrid1";
            this.ultraGrid1.Size = new System.Drawing.Size(534, 575);
            this.ultraGrid1.TabIndex = 0;
            this.ultraGrid1.Text = "Bases de datos";
            this.ultraGrid1.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.ultraGrid1_InitializeRow);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ucTiles);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(517, 575);
            this.panel2.TabIndex = 1;
            // 
            // ucTiles
            // 
            this.ucTiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTiles.Location = new System.Drawing.Point(0, 0);
            this.ucTiles.Name = "ucTiles";
            this.ucTiles.NormalModeDimensions = new System.Drawing.Size(0, 0);
            this.ucTiles.Size = new System.Drawing.Size(517, 575);
            this.ucTiles.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnCancelar);
            this.panel4.Controls.Add(this.btnExecute);
            this.panel4.Controls.Add(this.btnAgregarComando);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 658);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1063, 46);
            this.panel4.TabIndex = 2;
            // 
            // btnExecute
            // 
            this.btnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExecute.Enabled = false;
            this.btnExecute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecute.Image = global::DatabaseCommandUpdater.Properties.Resources.script_start;
            this.btnExecute.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExecute.Location = new System.Drawing.Point(221, 7);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(130, 33);
            this.btnExecute.TabIndex = 1;
            this.btnExecute.Text = "&Ejecutar";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // btnAgregarComando
            // 
            this.btnAgregarComando.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregarComando.Enabled = false;
            this.btnAgregarComando.Image = global::DatabaseCommandUpdater.Properties.Resources.script_add;
            this.btnAgregarComando.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarComando.Location = new System.Drawing.Point(5, 7);
            this.btnAgregarComando.Name = "btnAgregarComando";
            this.btnAgregarComando.Size = new System.Drawing.Size(210, 33);
            this.btnAgregarComando.TabIndex = 0;
            this.btnAgregarComando.Text = "&Agregar Comando SQL";
            this.btnAgregarComando.UseVisualStyleBackColor = true;
            this.btnAgregarComando.Click += new System.EventHandler(this.button1_Click);
            // 
            // ultraTile1
            // 
            this.ultraTile1.Name = "ultraTile1";
            this.ultraTile1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = global::DatabaseCommandUpdater.Properties.Resources.system_close;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(357, 7);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(148, 33);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancela&r";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // bsConexion
            // 
            this.bsConexion.DataSource = typeof(DatabaseCommandUpdater.ConexionData);
            // 
            // bsDbs
            // 
            this.bsDbs.DataSource = typeof(DatabaseCommandUpdater.DbInfo);
            // 
            // frmCommandUpdater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 707);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmCommandUpdater";
            this.Text = "Schema Updater";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelAcciones.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ucTiles)).EndInit();
            this.ucTiles.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsConexion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDbs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel panelAcciones;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource bsConexion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private Infragistics.Win.Misc.UltraTilePanel ucTiles;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAgregarComando;
        private Infragistics.Win.UltraWinGrid.UltraGrid ultraGrid1;
        private Infragistics.Win.Misc.UltraTile ultraTile1;
        private System.Windows.Forms.BindingSource bsDbs;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnCancelar;
    }
}

