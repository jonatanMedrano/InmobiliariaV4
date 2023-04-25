
namespace capaUsuario
{
    partial class frmClsCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNroCli = new System.Windows.Forms.Label();
            this.txtNroCli = new System.Windows.Forms.TextBox();
            this.dtgViewTabla = new System.Windows.Forms.DataGridView();
            this.grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgViewTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.txtNroCli);
            this.grpDatos.Controls.Add(this.lblNroCli);
            this.grpDatos.Controls.SetChildIndex(this.cmbLocalidad, 0);
            this.grpDatos.Controls.SetChildIndex(this.cmbPartido, 0);
            this.grpDatos.Controls.SetChildIndex(this.cmbCalle, 0);
            this.grpDatos.Controls.SetChildIndex(this.txtNombre, 0);
            this.grpDatos.Controls.SetChildIndex(this.txtApellido, 0);
            this.grpDatos.Controls.SetChildIndex(this.txtDni, 0);
            this.grpDatos.Controls.SetChildIndex(this.txtAltura, 0);
            this.grpDatos.Controls.SetChildIndex(this.lblNroCli, 0);
            this.grpDatos.Controls.SetChildIndex(this.txtNroCli, 0);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblNroCli
            // 
            this.lblNroCli.AutoSize = true;
            this.lblNroCli.Location = new System.Drawing.Point(23, 424);
            this.lblNroCli.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNroCli.Name = "lblNroCli";
            this.lblNroCli.Size = new System.Drawing.Size(95, 20);
            this.lblNroCli.TabIndex = 15;
            this.lblNroCli.Text = "Nro. Cliente:";
            // 
            // txtNroCli
            // 
            this.txtNroCli.Location = new System.Drawing.Point(164, 429);
            this.txtNroCli.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNroCli.Name = "txtNroCli";
            this.txtNroCli.Size = new System.Drawing.Size(76, 26);
            this.txtNroCli.TabIndex = 16;
            // 
            // dtgViewTabla
            // 
            this.dtgViewTabla.AllowUserToOrderColumns = true;
            this.dtgViewTabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgViewTabla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgViewTabla.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(235)))), ((int)(((byte)(233)))));
            this.dtgViewTabla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgViewTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgViewTabla.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgViewTabla.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgViewTabla.Location = new System.Drawing.Point(390, 21);
            this.dtgViewTabla.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgViewTabla.Name = "dtgViewTabla";
            this.dtgViewTabla.ReadOnly = true;
            this.dtgViewTabla.RowHeadersWidth = 51;
            this.dtgViewTabla.RowTemplate.Height = 28;
            this.dtgViewTabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgViewTabla.Size = new System.Drawing.Size(682, 470);
            this.dtgViewTabla.TabIndex = 17;
            this.dtgViewTabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgViewInfo_CellContentClick);
            // 
            // frmClsCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 603);
            this.Controls.Add(this.dtgViewTabla);
            this.Name = "frmClsCliente";
            this.Text = "Clientes";
            this.Controls.SetChildIndex(this.grpDatos, 0);
            this.Controls.SetChildIndex(this.btnActualizar, 0);
            this.Controls.SetChildIndex(this.btnIngresar, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnLimpiar, 0);
            this.Controls.SetChildIndex(this.dtgViewTabla, 0);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgViewTabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNroCli;
        private System.Windows.Forms.TextBox txtNroCli;
        private System.Windows.Forms.DataGridView dtgViewTabla;
    }
}