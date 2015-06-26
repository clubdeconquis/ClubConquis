namespace ClubdeConquis
{
    partial class Asistencias
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dTPFecha = new System.Windows.Forms.DateTimePicker();
            this.comboBoxUnidad = new System.Windows.Forms.ComboBox();
            this.gBAs = new System.Windows.Forms.GroupBox();
            this.dGV = new System.Windows.Forms.DataGridView();
            this.mydbDataSet = new ClubdeConquis.mydbDataSet();
            this.integranteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.integranteTableAdapter = new ClubdeConquis.mydbDataSetTableAdapters.integranteTableAdapter();
            this.idIntegranteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutAlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoPatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoMatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkcodApPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkUnidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspectoridInspectorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.gBAs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.integranteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Unidad";
            // 
            // dTPFecha
            // 
            this.dTPFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPFecha.Location = new System.Drawing.Point(38, 28);
            this.dTPFecha.Name = "dTPFecha";
            this.dTPFecha.Size = new System.Drawing.Size(200, 20);
            this.dTPFecha.TabIndex = 4;
            // 
            // comboBoxUnidad
            // 
            this.comboBoxUnidad.FormattingEnabled = true;
            this.comboBoxUnidad.Location = new System.Drawing.Point(428, 28);
            this.comboBoxUnidad.Name = "comboBoxUnidad";
            this.comboBoxUnidad.Size = new System.Drawing.Size(121, 21);
            this.comboBoxUnidad.TabIndex = 6;
            this.comboBoxUnidad.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // gBAs
            // 
            this.gBAs.Controls.Add(this.btnMostrar);
            this.gBAs.Controls.Add(this.dGV);
            this.gBAs.Controls.Add(this.comboBoxUnidad);
            this.gBAs.Controls.Add(this.dTPFecha);
            this.gBAs.Controls.Add(this.label2);
            this.gBAs.Location = new System.Drawing.Point(0, 0);
            this.gBAs.Name = "gBAs";
            this.gBAs.Size = new System.Drawing.Size(640, 492);
            this.gBAs.TabIndex = 7;
            this.gBAs.TabStop = false;
            this.gBAs.Enter += new System.EventHandler(this.gBAs_Enter);
            // 
            // dGV
            // 
            this.dGV.AllowUserToOrderColumns = true;
            this.dGV.AutoGenerateColumns = false;
            this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idIntegranteDataGridViewTextBoxColumn,
            this.rutAlDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoPatDataGridViewTextBoxColumn,
            this.apellidoMatDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.fechaNacDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.activoDataGridViewTextBoxColumn,
            this.fkcodApPDataGridViewTextBoxColumn,
            this.fkUnidadDataGridViewTextBoxColumn,
            this.inspectoridInspectorDataGridViewTextBoxColumn});
            this.dGV.DataSource = this.integranteBindingSource;
            this.dGV.Location = new System.Drawing.Point(6, 103);
            this.dGV.Name = "dGV";
            this.dGV.Size = new System.Drawing.Size(628, 233);
            this.dGV.TabIndex = 7;
            // 
            // mydbDataSet
            // 
            this.mydbDataSet.DataSetName = "mydbDataSet";
            this.mydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // integranteBindingSource
            // 
            this.integranteBindingSource.DataMember = "integrante";
            this.integranteBindingSource.DataSource = this.mydbDataSet;
            // 
            // integranteTableAdapter
            // 
            this.integranteTableAdapter.ClearBeforeFill = true;
            // 
            // idIntegranteDataGridViewTextBoxColumn
            // 
            this.idIntegranteDataGridViewTextBoxColumn.DataPropertyName = "idIntegrante";
            this.idIntegranteDataGridViewTextBoxColumn.HeaderText = "idIntegrante";
            this.idIntegranteDataGridViewTextBoxColumn.Name = "idIntegranteDataGridViewTextBoxColumn";
            // 
            // rutAlDataGridViewTextBoxColumn
            // 
            this.rutAlDataGridViewTextBoxColumn.DataPropertyName = "rutAl";
            this.rutAlDataGridViewTextBoxColumn.HeaderText = "rutAl";
            this.rutAlDataGridViewTextBoxColumn.Name = "rutAlDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidoPatDataGridViewTextBoxColumn
            // 
            this.apellidoPatDataGridViewTextBoxColumn.DataPropertyName = "apellidoPat";
            this.apellidoPatDataGridViewTextBoxColumn.HeaderText = "apellidoPat";
            this.apellidoPatDataGridViewTextBoxColumn.Name = "apellidoPatDataGridViewTextBoxColumn";
            // 
            // apellidoMatDataGridViewTextBoxColumn
            // 
            this.apellidoMatDataGridViewTextBoxColumn.DataPropertyName = "apellidoMat";
            this.apellidoMatDataGridViewTextBoxColumn.HeaderText = "apellidoMat";
            this.apellidoMatDataGridViewTextBoxColumn.Name = "apellidoMatDataGridViewTextBoxColumn";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // fechaNacDataGridViewTextBoxColumn
            // 
            this.fechaNacDataGridViewTextBoxColumn.DataPropertyName = "fechaNac";
            this.fechaNacDataGridViewTextBoxColumn.HeaderText = "fechaNac";
            this.fechaNacDataGridViewTextBoxColumn.Name = "fechaNacDataGridViewTextBoxColumn";
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "tel";
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            // 
            // activoDataGridViewTextBoxColumn
            // 
            this.activoDataGridViewTextBoxColumn.DataPropertyName = "activo";
            this.activoDataGridViewTextBoxColumn.HeaderText = "activo";
            this.activoDataGridViewTextBoxColumn.Name = "activoDataGridViewTextBoxColumn";
            // 
            // fkcodApPDataGridViewTextBoxColumn
            // 
            this.fkcodApPDataGridViewTextBoxColumn.DataPropertyName = "fk_cod_ApP";
            this.fkcodApPDataGridViewTextBoxColumn.HeaderText = "fk_cod_ApP";
            this.fkcodApPDataGridViewTextBoxColumn.Name = "fkcodApPDataGridViewTextBoxColumn";
            // 
            // fkUnidadDataGridViewTextBoxColumn
            // 
            this.fkUnidadDataGridViewTextBoxColumn.DataPropertyName = "fk_Unidad";
            this.fkUnidadDataGridViewTextBoxColumn.HeaderText = "fk_Unidad";
            this.fkUnidadDataGridViewTextBoxColumn.Name = "fkUnidadDataGridViewTextBoxColumn";
            // 
            // inspectoridInspectorDataGridViewTextBoxColumn
            // 
            this.inspectoridInspectorDataGridViewTextBoxColumn.DataPropertyName = "Inspector_idInspector";
            this.inspectoridInspectorDataGridViewTextBoxColumn.HeaderText = "Inspector_idInspector";
            this.inspectoridInspectorDataGridViewTextBoxColumn.Name = "inspectoridInspectorDataGridViewTextBoxColumn";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(474, 56);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 8;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // Asistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 493);
            this.Controls.Add(this.gBAs);
            this.Controls.Add(this.label1);
            this.Name = "Asistencias";
            this.Text = "Asistencias";
            this.Load += new System.EventHandler(this.Asistencias_Load);
            this.gBAs.ResumeLayout(false);
            this.gBAs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.integranteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dTPFecha;
        private System.Windows.Forms.ComboBox comboBoxUnidad;
        private System.Windows.Forms.GroupBox gBAs;
        private System.Windows.Forms.DataGridView dGV;
        private mydbDataSet mydbDataSet;
        private System.Windows.Forms.BindingSource integranteBindingSource;
        private mydbDataSetTableAdapters.integranteTableAdapter integranteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idIntegranteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutAlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoPatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoMatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkcodApPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkUnidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspectoridInspectorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnMostrar;
    }
}