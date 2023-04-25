
namespace capaUsuario
{
    partial class frmViviendaIni
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

        private void InitializeComponent()
        {
            this.pnlAcceso = new System.Windows.Forms.Panel();
            this.listBoxDpto = new System.Windows.Forms.ListBox();
            this.butEliminaDpto = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lstTablaCasa = new System.Windows.Forms.ListBox();
            this.gpr2 = new System.Windows.Forms.GroupBox();
            this.butActDpto = new System.Windows.Forms.Button();
            this.btnDpto = new System.Windows.Forms.Button();
            this.gpr1 = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCasa = new System.Windows.Forms.Button();
            this.pnlAcceso.SuspendLayout();
            this.gpr2.SuspendLayout();
            this.gpr1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAcceso
            // 
            this.pnlAcceso.Controls.Add(this.listBoxDpto);
            this.pnlAcceso.Controls.Add(this.butEliminaDpto);
            this.pnlAcceso.Controls.Add(this.btnEliminar);
            this.pnlAcceso.Controls.Add(this.btnClose);
            this.pnlAcceso.Controls.Add(this.lstTablaCasa);
            this.pnlAcceso.Controls.Add(this.gpr2);
            this.pnlAcceso.Controls.Add(this.gpr1);
            this.pnlAcceso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAcceso.Location = new System.Drawing.Point(0, 0);
            this.pnlAcceso.Name = "pnlAcceso";
            this.pnlAcceso.Size = new System.Drawing.Size(975, 599);
            this.pnlAcceso.TabIndex = 0;
            // 
            // listBoxDpto
            // 
            this.listBoxDpto.BackColor = System.Drawing.Color.DarkGray;
            this.listBoxDpto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDpto.FormattingEnabled = true;
            this.listBoxDpto.ItemHeight = 17;
            this.listBoxDpto.Location = new System.Drawing.Point(11, 335);
            this.listBoxDpto.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxDpto.Name = "listBoxDpto";
            this.listBoxDpto.Size = new System.Drawing.Size(582, 174);
            this.listBoxDpto.TabIndex = 42;
            this.listBoxDpto.SelectedIndexChanged += new System.EventHandler(this.listBoxDpto_SelectedIndexChanged);
            // 
            // butEliminaDpto
            // 
            this.butEliminaDpto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.butEliminaDpto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butEliminaDpto.FlatAppearance.BorderSize = 0;
            this.butEliminaDpto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.butEliminaDpto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butEliminaDpto.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEliminaDpto.ForeColor = System.Drawing.Color.White;
            this.butEliminaDpto.Location = new System.Drawing.Point(607, 472);
            this.butEliminaDpto.Name = "butEliminaDpto";
            this.butEliminaDpto.Size = new System.Drawing.Size(193, 37);
            this.butEliminaDpto.TabIndex = 39;
            this.butEliminaDpto.Text = "Eliminar Departamento";
            this.butEliminaDpto.UseVisualStyleBackColor = false;
            this.butEliminaDpto.Click += new System.EventHandler(this.butEliminaDpto_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(607, 218);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(193, 37);
            this.btnEliminar.TabIndex = 38;
            this.btnEliminar.Text = "Eliminar Casa";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminarCasa_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(16, 529);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(106, 50);
            this.btnClose.TabIndex = 41;
            this.btnClose.Text = "Salir y Almacenar";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lstTablaCasa
            // 
            this.lstTablaCasa.BackColor = System.Drawing.Color.DarkGray;
            this.lstTablaCasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTablaCasa.FormattingEnabled = true;
            this.lstTablaCasa.ItemHeight = 17;
            this.lstTablaCasa.Location = new System.Drawing.Point(11, 81);
            this.lstTablaCasa.Margin = new System.Windows.Forms.Padding(2);
            this.lstTablaCasa.Name = "lstTablaCasa";
            this.lstTablaCasa.Size = new System.Drawing.Size(582, 174);
            this.lstTablaCasa.TabIndex = 40;
            this.lstTablaCasa.SelectedIndexChanged += new System.EventHandler(this.lstTabla_SelectedIndexChanged);
            // 
            // gpr2
            // 
            this.gpr2.Controls.Add(this.butActDpto);
            this.gpr2.Controls.Add(this.btnDpto);
            this.gpr2.Location = new System.Drawing.Point(607, 335);
            this.gpr2.Name = "gpr2";
            this.gpr2.Size = new System.Drawing.Size(356, 146);
            this.gpr2.TabIndex = 3;
            this.gpr2.TabStop = false;
            // 
            // butActDpto
            // 
            this.butActDpto.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.butActDpto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.butActDpto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butActDpto.FlatAppearance.BorderSize = 0;
            this.butActDpto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.butActDpto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butActDpto.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butActDpto.ForeColor = System.Drawing.Color.White;
            this.butActDpto.Location = new System.Drawing.Point(157, 58);
            this.butActDpto.Name = "butActDpto";
            this.butActDpto.Size = new System.Drawing.Size(193, 37);
            this.butActDpto.TabIndex = 39;
            this.butActDpto.Text = "Actualizar Departamento";
            this.butActDpto.UseVisualStyleBackColor = false;
            this.butActDpto.Click += new System.EventHandler(this.butActDpto_Click);
            // 
            // btnDpto
            // 
            this.btnDpto.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnDpto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.btnDpto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDpto.FlatAppearance.BorderSize = 0;
            this.btnDpto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnDpto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDpto.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDpto.ForeColor = System.Drawing.Color.White;
            this.btnDpto.Location = new System.Drawing.Point(157, 0);
            this.btnDpto.Name = "btnDpto";
            this.btnDpto.Size = new System.Drawing.Size(193, 37);
            this.btnDpto.TabIndex = 38;
            this.btnDpto.Text = "Crear Departamento";
            this.btnDpto.UseVisualStyleBackColor = false;
            this.btnDpto.Click += new System.EventHandler(this.btnDpto_Click);
            // 
            // gpr1
            // 
            this.gpr1.Controls.Add(this.btnActualizar);
            this.gpr1.Controls.Add(this.btnCasa);
            this.gpr1.Location = new System.Drawing.Point(607, 81);
            this.gpr1.Name = "gpr1";
            this.gpr1.Size = new System.Drawing.Size(356, 159);
            this.gpr1.TabIndex = 2;
            this.gpr1.TabStop = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(157, 58);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(193, 37);
            this.btnActualizar.TabIndex = 42;
            this.btnActualizar.Text = "Actualizar Casa";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizarCasa_Click);
            // 
            // btnCasa
            // 
            this.btnCasa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.btnCasa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCasa.FlatAppearance.BorderSize = 0;
            this.btnCasa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnCasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCasa.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCasa.ForeColor = System.Drawing.Color.White;
            this.btnCasa.Location = new System.Drawing.Point(157, 0);
            this.btnCasa.Name = "btnCasa";
            this.btnCasa.Size = new System.Drawing.Size(193, 37);
            this.btnCasa.TabIndex = 37;
            this.btnCasa.Text = "Crear Casa";
            this.btnCasa.UseVisualStyleBackColor = false;
            this.btnCasa.Click += new System.EventHandler(this.btnCasa_Click);
            // 
            // frmViviendaIni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(975, 599);
            this.Controls.Add(this.pnlAcceso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmViviendaIni";
            this.Text = "Inicio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FPrincipal_FormClosing);
            this.pnlAcceso.ResumeLayout(false);
            this.gpr2.ResumeLayout(false);
            this.gpr1.ResumeLayout(false);
            this.ResumeLayout(false);

        }



        private System.Windows.Forms.Panel pnlAcceso;
        private System.Windows.Forms.GroupBox gpr2;
        private System.Windows.Forms.GroupBox gpr1;
        private System.Windows.Forms.Button btnDpto;
        private System.Windows.Forms.Button btnCasa;
        private System.Windows.Forms.ListBox lstTablaCasa;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button butEliminaDpto;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button butActDpto;
        private System.Windows.Forms.ListBox listBoxDpto;
    }
}