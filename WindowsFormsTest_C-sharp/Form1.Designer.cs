namespace WindowsFormsTest_C_sharp
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.cmd_abort = new System.Windows.Forms.Button();
			this.txt_Vorname = new System.Windows.Forms.TextBox();
			this.txt_Nachname = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cmd_OK = new System.Windows.Forms.Button();
			this.lbl_AusgabeVorname = new System.Windows.Forms.Label();
			this.lbl_AusgabeNachname = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// cmd_abort
			// 
			this.cmd_abort.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.cmd_abort.Font = new System.Drawing.Font("Monoid NF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmd_abort.Location = new System.Drawing.Point(484, 322);
			this.cmd_abort.Name = "cmd_abort";
			this.cmd_abort.Size = new System.Drawing.Size(185, 80);
			this.cmd_abort.TabIndex = 0;
			this.cmd_abort.Text = "Abbrechen";
			this.cmd_abort.UseVisualStyleBackColor = false;
			this.cmd_abort.Click += new System.EventHandler(this.cmd_abort_Click);
			// 
			// txt_Vorname
			// 
			this.txt_Vorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Vorname.Location = new System.Drawing.Point(138, 146);
			this.txt_Vorname.Name = "txt_Vorname";
			this.txt_Vorname.Size = new System.Drawing.Size(183, 27);
			this.txt_Vorname.TabIndex = 1;
			// 
			// txt_Nachname
			// 
			this.txt_Nachname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Nachname.Location = new System.Drawing.Point(500, 146);
			this.txt_Nachname.Name = "txt_Nachname";
			this.txt_Nachname.Size = new System.Drawing.Size(183, 27);
			this.txt_Nachname.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(26, 148);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "Vorname:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(375, 148);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(103, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Nachname:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(117, 41);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(391, 25);
			this.label3.TabIndex = 5;
			this.label3.Text = "Bitte geben Sie ihre persönlichen Daten ein:";
			// 
			// cmd_OK
			// 
			this.cmd_OK.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.cmd_OK.Font = new System.Drawing.Font("Monoid NF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmd_OK.Location = new System.Drawing.Point(122, 322);
			this.cmd_OK.Name = "cmd_OK";
			this.cmd_OK.Size = new System.Drawing.Size(185, 80);
			this.cmd_OK.TabIndex = 0;
			this.cmd_OK.Text = "OK";
			this.cmd_OK.UseVisualStyleBackColor = false;
			this.cmd_OK.Click += new System.EventHandler(this.cmd_OK_Click);
			// 
			// lbl_AusgabeVorname
			// 
			this.lbl_AusgabeVorname.AutoSize = true;
			this.lbl_AusgabeVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_AusgabeVorname.Location = new System.Drawing.Point(134, 221);
			this.lbl_AusgabeVorname.Name = "lbl_AusgabeVorname";
			this.lbl_AusgabeVorname.Size = new System.Drawing.Size(83, 20);
			this.lbl_AusgabeVorname.TabIndex = 3;
			this.lbl_AusgabeVorname.Text = "Vorname";
			// 
			// lbl_AusgabeNachname
			// 
			this.lbl_AusgabeNachname.AutoSize = true;
			this.lbl_AusgabeNachname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_AusgabeNachname.Location = new System.Drawing.Point(496, 221);
			this.lbl_AusgabeNachname.Name = "lbl_AusgabeNachname";
			this.lbl_AusgabeNachname.Size = new System.Drawing.Size(97, 20);
			this.lbl_AusgabeNachname.TabIndex = 4;
			this.lbl_AusgabeNachname.Text = "Nachname";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(26, 221);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 20);
			this.label4.TabIndex = 3;
			this.label4.Text = "Kontrolle:";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Checked = false;
			this.dateTimePicker1.Enabled = false;
			this.dateTimePicker1.Location = new System.Drawing.Point(12, 12);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(279, 22);
			this.dateTimePicker1.TabIndex = 6;
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// Form1
			// 
			this.AcceptButton = this.cmd_OK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cmd_abort;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lbl_AusgabeNachname);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lbl_AusgabeVorname);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_Nachname);
			this.Controls.Add(this.txt_Vorname);
			this.Controls.Add(this.cmd_OK);
			this.Controls.Add(this.cmd_abort);
			this.Name = "Form1";
			this.Text = "Test-WFA";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button cmd_abort;
		private System.Windows.Forms.TextBox txt_Vorname;
		private System.Windows.Forms.TextBox txt_Nachname;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button cmd_OK;
		private System.Windows.Forms.Label lbl_AusgabeVorname;
		private System.Windows.Forms.Label lbl_AusgabeNachname;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
	}
}

