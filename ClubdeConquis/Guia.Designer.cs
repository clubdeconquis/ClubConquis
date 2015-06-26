namespace ClubdeConquis
{
    partial class Guia
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
            this.dTPFecNacG = new System.Windows.Forms.DateTimePicker();
            this.masktxtRutG = new System.Windows.Forms.MaskedTextBox();
            this.txtActivoG = new System.Windows.Forms.TextBox();
            this.txtTelG = new System.Windows.Forms.TextBox();
            this.txtDomG = new System.Windows.Forms.TextBox();
            this.txtApMG = new System.Windows.Forms.TextBox();
            this.txtApPG = new System.Windows.Forms.TextBox();
            this.txtNomG = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dTPFecNacG
            // 
            this.dTPFecNacG.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPFecNacG.Location = new System.Drawing.Point(74, 178);
            this.dTPFecNacG.Name = "dTPFecNacG";
            this.dTPFecNacG.Size = new System.Drawing.Size(100, 20);
            this.dTPFecNacG.TabIndex = 33;
            // 
            // masktxtRutG
            // 
            this.masktxtRutG.Location = new System.Drawing.Point(74, 42);
            this.masktxtRutG.Mask = "000000000";
            this.masktxtRutG.Name = "masktxtRutG";
            this.masktxtRutG.Size = new System.Drawing.Size(100, 20);
            this.masktxtRutG.TabIndex = 32;
            this.masktxtRutG.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.masktxtRutG_MaskInputRejected);
            // 
            // txtActivoG
            // 
            this.txtActivoG.Location = new System.Drawing.Point(74, 232);
            this.txtActivoG.Name = "txtActivoG";
            this.txtActivoG.Size = new System.Drawing.Size(23, 20);
            this.txtActivoG.TabIndex = 31;
            // 
            // txtTelG
            // 
            this.txtTelG.Location = new System.Drawing.Point(74, 205);
            this.txtTelG.Name = "txtTelG";
            this.txtTelG.Size = new System.Drawing.Size(100, 20);
            this.txtTelG.TabIndex = 30;
            // 
            // txtDomG
            // 
            this.txtDomG.Location = new System.Drawing.Point(74, 151);
            this.txtDomG.Name = "txtDomG";
            this.txtDomG.Size = new System.Drawing.Size(100, 20);
            this.txtDomG.TabIndex = 29;
            // 
            // txtApMG
            // 
            this.txtApMG.Location = new System.Drawing.Point(74, 124);
            this.txtApMG.Name = "txtApMG";
            this.txtApMG.Size = new System.Drawing.Size(100, 20);
            this.txtApMG.TabIndex = 28;
            // 
            // txtApPG
            // 
            this.txtApPG.Location = new System.Drawing.Point(74, 97);
            this.txtApPG.Name = "txtApPG";
            this.txtApPG.Size = new System.Drawing.Size(100, 20);
            this.txtApPG.TabIndex = 27;
            // 
            // txtNomG
            // 
            this.txtNomG.Location = new System.Drawing.Point(74, 68);
            this.txtNomG.Name = "txtNomG";
            this.txtNomG.Size = new System.Drawing.Size(100, 20);
            this.txtNomG.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Activo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Tel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Fecha Nac";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Domicilio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "ApellidoM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "ApellidoP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "RUT";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(37, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 35;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Guia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 355);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dTPFecNacG);
            this.Controls.Add(this.masktxtRutG);
            this.Controls.Add(this.txtActivoG);
            this.Controls.Add(this.txtTelG);
            this.Controls.Add(this.txtDomG);
            this.Controls.Add(this.txtApMG);
            this.Controls.Add(this.txtApPG);
            this.Controls.Add(this.txtNomG);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Guia";
            this.Text = "Guia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dTPFecNacG;
        private System.Windows.Forms.MaskedTextBox masktxtRutG;
        private System.Windows.Forms.TextBox txtActivoG;
        private System.Windows.Forms.TextBox txtTelG;
        private System.Windows.Forms.TextBox txtDomG;
        private System.Windows.Forms.TextBox txtApMG;
        private System.Windows.Forms.TextBox txtApPG;
        private System.Windows.Forms.TextBox txtNomG;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}