namespace irregularVerbs
{
    partial class IrregularsVerbs
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IrregularsVerbs));
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.DtgDatos = new Telerik.WinControls.UI.RadGridView();
            this.TrbSpeed = new Telerik.WinControls.UI.RadTrackBar();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrbSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgDatos
            // 
            this.DtgDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.DtgDatos.Cursor = System.Windows.Forms.Cursors.Default;
            this.DtgDatos.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.DtgDatos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DtgDatos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DtgDatos.Location = new System.Drawing.Point(12, 12);
            // 
            // 
            // 
            this.DtgDatos.MasterTemplate.AllowAddNewRow = false;
            this.DtgDatos.MasterTemplate.AllowColumnReorder = false;
            this.DtgDatos.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.HeaderText = "Traduccion";
            gridViewTextBoxColumn1.Name = "Traduccion";
            gridViewTextBoxColumn1.Width = 84;
            gridViewTextBoxColumn2.HeaderText = "Present";
            gridViewTextBoxColumn2.Name = "Present";
            gridViewTextBoxColumn2.Width = 208;
            gridViewTextBoxColumn3.HeaderText = "Past Simple";
            gridViewTextBoxColumn3.Name = "PastSimple";
            gridViewTextBoxColumn3.Width = 208;
            gridViewTextBoxColumn4.HeaderText = "Past Participle";
            gridViewTextBoxColumn4.Name = "PastParticiple";
            gridViewTextBoxColumn4.Width = 207;
            this.DtgDatos.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.DtgDatos.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.DtgDatos.Name = "DtgDatos";
            this.DtgDatos.ReadOnly = true;
            this.DtgDatos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DtgDatos.ShowGroupPanel = false;
            this.DtgDatos.Size = new System.Drawing.Size(723, 505);
            this.DtgDatos.TabIndex = 1;
            this.DtgDatos.ThemeName = "VisualStudio2012Light";
            this.DtgDatos.RowFormatting += new Telerik.WinControls.UI.RowFormattingEventHandler(this.DtgDatos_RowFormatting);
            this.DtgDatos.CellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.DtgDatos_CellFormatting);
            this.DtgDatos.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.DtgDatos_CellClick);
            // 
            // TrbSpeed
            // 
            this.TrbSpeed.LabelStyle = Telerik.WinControls.UI.TrackBarLabelStyle.TopLeft;
            this.TrbSpeed.Location = new System.Drawing.Point(3, 41);
            this.TrbSpeed.Maximum = 10F;
            this.TrbSpeed.Minimum = -10F;
            this.TrbSpeed.Name = "TrbSpeed";
            this.TrbSpeed.Size = new System.Drawing.Size(189, 43);
            this.TrbSpeed.TabIndex = 3;
            this.TrbSpeed.ThemeName = "VisualStudio2012Light";
            this.TrbSpeed.TickStyle = Telerik.WinControls.Enumerations.TickStyles.TopLeft;
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.TrbSpeed);
            this.radPanel1.Location = new System.Drawing.Point(741, 12);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(195, 101);
            this.radPanel1.TabIndex = 4;
            this.radPanel1.Text = "Speed";
            this.radPanel1.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.radPanel1.ThemeName = "VisualStudio2012Light";
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.label1);
            this.radPanel2.Location = new System.Drawing.Point(744, 119);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(192, 238);
            this.radPanel2.TabIndex = 5;
            this.radPanel2.ThemeName = "VisualStudio2012Light";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 207);
            this.label1.TabIndex = 6;
            this.label1.Text = "Presiona la Palabras para que se reproduzca su pronunciacion";
            // 
            // IrregularsVerbs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 527);
            this.Controls.Add(this.radPanel2);
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.DtgDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IrregularsVerbs";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Irregulars Verbs";
            this.ThemeName = "VisualStudio2012Light";
            this.Load += new System.EventHandler(this.IrregularsVerbs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrbSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private Telerik.WinControls.UI.RadGridView DtgDatos;
        private Telerik.WinControls.UI.RadTrackBar TrbSpeed;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private System.Windows.Forms.Label label1;
    }
}