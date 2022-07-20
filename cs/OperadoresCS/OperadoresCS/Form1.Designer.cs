namespace OperadoresCS
{
	partial class frmOperadoresCS
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
			this.grpRelacionales = new System.Windows.Forms.GroupBox();
			this.cmbRel = new System.Windows.Forms.ComboBox();
			this.txtRel1 = new System.Windows.Forms.TextBox();
			this.txtRel2 = new System.Windows.Forms.TextBox();
			this.grpLogicos = new System.Windows.Forms.GroupBox();
			this.cmbLog2 = new System.Windows.Forms.ComboBox();
			this.cmbLog1 = new System.Windows.Forms.ComboBox();
			this.cmbLog = new System.Windows.Forms.ComboBox();
			this.grpAritmeticos = new System.Windows.Forms.GroupBox();
			this.cmbArit = new System.Windows.Forms.ComboBox();
			this.txtArit1 = new System.Windows.Forms.TextBox();
			this.txtArit2 = new System.Windows.Forms.TextBox();
			this.grpRelacionales.SuspendLayout();
			this.grpLogicos.SuspendLayout();
			this.grpAritmeticos.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpRelacionales
			// 
			this.grpRelacionales.Controls.Add(this.cmbRel);
			this.grpRelacionales.Controls.Add(this.txtRel1);
			this.grpRelacionales.Controls.Add(this.txtRel2);
			this.grpRelacionales.Font = new System.Drawing.Font("Felix Titling", 8.25F);
			this.grpRelacionales.Location = new System.Drawing.Point(234, 160);
			this.grpRelacionales.Name = "grpRelacionales";
			this.grpRelacionales.Size = new System.Drawing.Size(236, 102);
			this.grpRelacionales.TabIndex = 6;
			this.grpRelacionales.TabStop = false;
			this.grpRelacionales.Text = "Relacionales";
			// 
			// cmbRel
			// 
			this.cmbRel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbRel.FormattingEnabled = true;
			this.cmbRel.Items.AddRange(new object[] {
            ">",
            "<",
            "<=",
            ">=",
            "==",
            "!="});
			this.cmbRel.Location = new System.Drawing.Point(6, 56);
			this.cmbRel.Name = "cmbRel";
			this.cmbRel.Size = new System.Drawing.Size(224, 21);
			this.cmbRel.TabIndex = 2;
			this.cmbRel.SelectedIndexChanged += new System.EventHandler(this.cmbRel_SelectedIndexChanged);
			// 
			// txtRel1
			// 
			this.txtRel1.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRel1.Location = new System.Drawing.Point(6, 30);
			this.txtRel1.Name = "txtRel1";
			this.txtRel1.Size = new System.Drawing.Size(94, 24);
			this.txtRel1.TabIndex = 1;
			// 
			// txtRel2
			// 
			this.txtRel2.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRel2.Location = new System.Drawing.Point(136, 30);
			this.txtRel2.Name = "txtRel2";
			this.txtRel2.Size = new System.Drawing.Size(94, 24);
			this.txtRel2.TabIndex = 0;
			// 
			// grpLogicos
			// 
			this.grpLogicos.Controls.Add(this.cmbLog2);
			this.grpLogicos.Controls.Add(this.cmbLog1);
			this.grpLogicos.Controls.Add(this.cmbLog);
			this.grpLogicos.Font = new System.Drawing.Font("Felix Titling", 8.25F);
			this.grpLogicos.Location = new System.Drawing.Point(404, 52);
			this.grpLogicos.Name = "grpLogicos";
			this.grpLogicos.Size = new System.Drawing.Size(236, 102);
			this.grpLogicos.TabIndex = 5;
			this.grpLogicos.TabStop = false;
			this.grpLogicos.Text = "Logicos";
			// 
			// cmbLog2
			// 
			this.cmbLog2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbLog2.FormattingEnabled = true;
			this.cmbLog2.Items.AddRange(new object[] {
            "False",
            "True"});
			this.cmbLog2.Location = new System.Drawing.Point(146, 30);
			this.cmbLog2.Name = "cmbLog2";
			this.cmbLog2.Size = new System.Drawing.Size(84, 21);
			this.cmbLog2.TabIndex = 4;
			// 
			// cmbLog1
			// 
			this.cmbLog1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbLog1.FormattingEnabled = true;
			this.cmbLog1.Items.AddRange(new object[] {
            "False",
            "True"});
			this.cmbLog1.Location = new System.Drawing.Point(6, 29);
			this.cmbLog1.Name = "cmbLog1";
			this.cmbLog1.Size = new System.Drawing.Size(84, 21);
			this.cmbLog1.TabIndex = 3;
			// 
			// cmbLog
			// 
			this.cmbLog.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbLog.FormattingEnabled = true;
			this.cmbLog.Items.AddRange(new object[] {
            "Not",
            "And",
            "Or",
            "Xor"});
			this.cmbLog.Location = new System.Drawing.Point(6, 56);
			this.cmbLog.Name = "cmbLog";
			this.cmbLog.Size = new System.Drawing.Size(224, 21);
			this.cmbLog.TabIndex = 2;
			this.cmbLog.SelectedIndexChanged += new System.EventHandler(this.cmbLog_SelectedIndexChanged);
			// 
			// grpAritmeticos
			// 
			this.grpAritmeticos.Controls.Add(this.cmbArit);
			this.grpAritmeticos.Controls.Add(this.txtArit1);
			this.grpAritmeticos.Controls.Add(this.txtArit2);
			this.grpAritmeticos.Font = new System.Drawing.Font("Felix Titling", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpAritmeticos.Location = new System.Drawing.Point(62, 52);
			this.grpAritmeticos.Name = "grpAritmeticos";
			this.grpAritmeticos.Size = new System.Drawing.Size(236, 102);
			this.grpAritmeticos.TabIndex = 4;
			this.grpAritmeticos.TabStop = false;
			this.grpAritmeticos.Text = "Aritmeticos";
			// 
			// cmbArit
			// 
			this.cmbArit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbArit.FormattingEnabled = true;
			this.cmbArit.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "\\",
            "Mod",
            "^"});
			this.cmbArit.Location = new System.Drawing.Point(6, 56);
			this.cmbArit.Name = "cmbArit";
			this.cmbArit.Size = new System.Drawing.Size(224, 21);
			this.cmbArit.TabIndex = 2;
			this.cmbArit.SelectedIndexChanged += new System.EventHandler(this.cmbArit_SelectedIndexChanged);
			// 
			// txtArit1
			// 
			this.txtArit1.Location = new System.Drawing.Point(6, 30);
			this.txtArit1.Name = "txtArit1";
			this.txtArit1.Size = new System.Drawing.Size(94, 20);
			this.txtArit1.TabIndex = 1;
			this.txtArit1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtArit1_KeyPress);
			// 
			// txtArit2
			// 
			this.txtArit2.Location = new System.Drawing.Point(136, 30);
			this.txtArit2.Name = "txtArit2";
			this.txtArit2.Size = new System.Drawing.Size(94, 20);
			this.txtArit2.TabIndex = 0;
			this.txtArit2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtArit2_KeyPress);
			// 
			// frmOperadoresCS
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.grpRelacionales);
			this.Controls.Add(this.grpLogicos);
			this.Controls.Add(this.grpAritmeticos);
			this.Name = "frmOperadoresCS";
			this.Text = "Operadores";
			this.Load += new System.EventHandler(this.frmOperadoresCS_Load);
			this.grpRelacionales.ResumeLayout(false);
			this.grpRelacionales.PerformLayout();
			this.grpLogicos.ResumeLayout(false);
			this.grpAritmeticos.ResumeLayout(false);
			this.grpAritmeticos.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		internal System.Windows.Forms.GroupBox grpRelacionales;
		internal System.Windows.Forms.ComboBox cmbRel;
		internal System.Windows.Forms.TextBox txtRel1;
		internal System.Windows.Forms.TextBox txtRel2;
		internal System.Windows.Forms.GroupBox grpLogicos;
		internal System.Windows.Forms.ComboBox cmbLog2;
		internal System.Windows.Forms.ComboBox cmbLog1;
		internal System.Windows.Forms.ComboBox cmbLog;
		internal System.Windows.Forms.GroupBox grpAritmeticos;
		internal System.Windows.Forms.ComboBox cmbArit;
		internal System.Windows.Forms.TextBox txtArit1;
		internal System.Windows.Forms.TextBox txtArit2;
	}
}

