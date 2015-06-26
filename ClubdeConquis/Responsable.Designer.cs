namespace ClubdeConquis
{
    partial class Responsable
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRutRes = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtTipoRes = new System.Windows.Forms.TextBox();
            this.txtApPRes = new System.Windows.Forms.TextBox();
            this.txtNomRes = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "ApellidoP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "RUT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tipo Res";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Descripcion";
            // 
            // txtRutRes
            // 
            this.txtRutRes.Location = new System.Drawing.Point(74, 34);
            this.txtRutRes.Name = "txtRutRes";
            this.txtRutRes.Size = new System.Drawing.Size(100, 20);
            this.txtRutRes.TabIndex = 50;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(74, 147);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(100, 20);
            this.txtDesc.TabIndex = 49;
            // 
            // txtTipoRes
            // 
            this.txtTipoRes.Location = new System.Drawing.Point(74, 120);
            this.txtTipoRes.Name = "txtTipoRes";
            this.txtTipoRes.Size = new System.Drawing.Size(100, 20);
            this.txtTipoRes.TabIndex = 48;
            // 
            // txtApPRes
            // 
            this.txtApPRes.Location = new System.Drawing.Point(74, 93);
            this.txtApPRes.Name = "txtApPRes";
            this.txtApPRes.Size = new System.Drawing.Size(100, 20);
            this.txtApPRes.TabIndex = 47;
            // 
            // txtNomRes
            // 
            this.txtNomRes.Location = new System.Drawing.Point(74, 64);
            this.txtNomRes.Name = "txtNomRes";
            this.txtNomRes.Size = new System.Drawing.Size(100, 20);
            this.txtNomRes.TabIndex = 46;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(205, 210);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 51;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(41, 210);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 52;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Responsable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 275);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtRutRes);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtTipoRes);
            this.Controls.Add(this.txtApPRes);
            this.Controls.Add(this.txtNomRes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Responsable";
            this.Text = "Responsable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRutRes;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtTipoRes;
        private System.Windows.Forms.TextBox txtApPRes;
        private System.Windows.Forms.TextBox txtNomRes;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}