namespace SimuladorArduino
{
	partial class Arduino
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel_ac = new System.Windows.Forms.Panel();
			this.panel_rega = new System.Windows.Forms.Panel();
			this.panel_alarme = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox_qualidadeAr = new System.Windows.Forms.TextBox();
			this.textBox_temperatura = new System.Windows.Forms.TextBox();
			this.textBox_humidade = new System.Windows.Forms.TextBox();
			this.textBox_humidadeSolo = new System.Windows.Forms.TextBox();
			this.button_enviar = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// panel_ac
			// 
			this.panel_ac.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel_ac.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel_ac.Location = new System.Drawing.Point(79, 32);
			this.panel_ac.Name = "panel_ac";
			this.panel_ac.Size = new System.Drawing.Size(24, 61);
			this.panel_ac.TabIndex = 0;
			// 
			// panel_rega
			// 
			this.panel_rega.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel_rega.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel_rega.Location = new System.Drawing.Point(208, 32);
			this.panel_rega.Name = "panel_rega";
			this.panel_rega.Size = new System.Drawing.Size(24, 61);
			this.panel_rega.TabIndex = 1;
			// 
			// panel_alarme
			// 
			this.panel_alarme.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel_alarme.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel_alarme.Location = new System.Drawing.Point(337, 32);
			this.panel_alarme.Name = "panel_alarme";
			this.panel_alarme.Size = new System.Drawing.Size(24, 61);
			this.panel_alarme.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(73, 111);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 26);
			this.label1.TabIndex = 2;
			this.label1.Text = "LED 1\r\n(A/C)\r\n";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(201, 111);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 26);
			this.label2.TabIndex = 3;
			this.label2.Text = "LED 2\r\n(Rega)";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(327, 111);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 26);
			this.label3.TabIndex = 4;
			this.label3.Text = "LED 3\r\n(Alarme)";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox_qualidadeAr
			// 
			this.textBox_qualidadeAr.Location = new System.Drawing.Point(204, 168);
			this.textBox_qualidadeAr.Name = "textBox_qualidadeAr";
			this.textBox_qualidadeAr.Size = new System.Drawing.Size(139, 20);
			this.textBox_qualidadeAr.TabIndex = 5;
			// 
			// textBox_temperatura
			// 
			this.textBox_temperatura.Location = new System.Drawing.Point(204, 194);
			this.textBox_temperatura.Name = "textBox_temperatura";
			this.textBox_temperatura.Size = new System.Drawing.Size(139, 20);
			this.textBox_temperatura.TabIndex = 6;
			// 
			// textBox_humidade
			// 
			this.textBox_humidade.Location = new System.Drawing.Point(204, 220);
			this.textBox_humidade.Name = "textBox_humidade";
			this.textBox_humidade.Size = new System.Drawing.Size(139, 20);
			this.textBox_humidade.TabIndex = 7;
			// 
			// textBox_humidadeSolo
			// 
			this.textBox_humidadeSolo.Location = new System.Drawing.Point(204, 246);
			this.textBox_humidadeSolo.Name = "textBox_humidadeSolo";
			this.textBox_humidadeSolo.Size = new System.Drawing.Size(139, 20);
			this.textBox_humidadeSolo.TabIndex = 8;
			// 
			// button_enviar
			// 
			this.button_enviar.Location = new System.Drawing.Point(169, 288);
			this.button_enviar.Name = "button_enviar";
			this.button_enviar.Size = new System.Drawing.Size(107, 23);
			this.button_enviar.TabIndex = 9;
			this.button_enviar.Text = "Enviar Valores";
			this.button_enviar.UseVisualStyleBackColor = true;
			this.button_enviar.Click += new System.EventHandler(this.button_enviar_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(112, 171);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(86, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "Qualidade do Ar:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(140, 223);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(58, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "Humidade:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(101, 249);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(97, 13);
			this.label6.TabIndex = 12;
			this.label6.Text = "Humidade do Solo:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(128, 197);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(70, 13);
			this.label7.TabIndex = 13;
			this.label7.Text = "Temperatura:";
			// 
			// Arduino
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(444, 342);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button_enviar);
			this.Controls.Add(this.textBox_humidadeSolo);
			this.Controls.Add(this.textBox_humidade);
			this.Controls.Add(this.textBox_temperatura);
			this.Controls.Add(this.textBox_qualidadeAr);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel_rega);
			this.Controls.Add(this.panel_alarme);
			this.Controls.Add(this.panel_ac);
			this.Name = "Arduino";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Simulador Arduino";
			this.Load += new System.EventHandler(this.Arduino_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel_ac;
		private System.Windows.Forms.Panel panel_rega;
		private System.Windows.Forms.Panel panel_alarme;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox_qualidadeAr;
		private System.Windows.Forms.TextBox textBox_temperatura;
		private System.Windows.Forms.TextBox textBox_humidade;
		private System.Windows.Forms.TextBox textBox_humidadeSolo;
		private System.Windows.Forms.Button button_enviar;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
	}
}

