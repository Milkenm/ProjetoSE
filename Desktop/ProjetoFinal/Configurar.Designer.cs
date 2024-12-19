namespace ProjetoFinal
{
	partial class Configurar
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
			this.textBox_minHumidade = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox_minTemperatura = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox_maxTemperatura = new System.Windows.Forms.TextBox();
			this.textBox_qualidadeAr = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.button_guardar = new System.Windows.Forms.Button();
			this.button_fechar = new System.Windows.Forms.Button();
			this.textBox_minLuminosidade = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBox_minHumidade
			// 
			this.textBox_minHumidade.Location = new System.Drawing.Point(167, 42);
			this.textBox_minHumidade.Name = "textBox_minHumidade";
			this.textBox_minHumidade.Size = new System.Drawing.Size(133, 20);
			this.textBox_minHumidade.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(138, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Valor Mínimo de Humidade:";
			// 
			// textBox_minTemperatura
			// 
			this.textBox_minTemperatura.Location = new System.Drawing.Point(167, 68);
			this.textBox_minTemperatura.Name = "textBox_minTemperatura";
			this.textBox_minTemperatura.Size = new System.Drawing.Size(133, 20);
			this.textBox_minTemperatura.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(53, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(108, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Temperatura Mínima:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(52, 97);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(109, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Temperatura Máxima:";
			// 
			// textBox_maxTemperatura
			// 
			this.textBox_maxTemperatura.Location = new System.Drawing.Point(167, 94);
			this.textBox_maxTemperatura.Name = "textBox_maxTemperatura";
			this.textBox_maxTemperatura.Size = new System.Drawing.Size(133, 20);
			this.textBox_maxTemperatura.TabIndex = 3;
			// 
			// textBox_qualidadeAr
			// 
			this.textBox_qualidadeAr.Location = new System.Drawing.Point(167, 16);
			this.textBox_qualidadeAr.Name = "textBox_qualidadeAr";
			this.textBox_qualidadeAr.Size = new System.Drawing.Size(133, 20);
			this.textBox_qualidadeAr.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(75, 19);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(86, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Qualidade do Ar:";
			// 
			// button_guardar
			// 
			this.button_guardar.Location = new System.Drawing.Point(194, 162);
			this.button_guardar.Name = "button_guardar";
			this.button_guardar.Size = new System.Drawing.Size(106, 23);
			this.button_guardar.TabIndex = 4;
			this.button_guardar.Text = "Guardar";
			this.button_guardar.UseVisualStyleBackColor = true;
			this.button_guardar.Click += new System.EventHandler(this.button_guardar_Click);
			// 
			// button_fechar
			// 
			this.button_fechar.Location = new System.Drawing.Point(113, 162);
			this.button_fechar.Name = "button_fechar";
			this.button_fechar.Size = new System.Drawing.Size(75, 23);
			this.button_fechar.TabIndex = 5;
			this.button_fechar.Text = "Fechar";
			this.button_fechar.UseVisualStyleBackColor = true;
			this.button_fechar.Click += new System.EventHandler(this.button_fechar_Click);
			// 
			// textBox_minLuminosidade
			// 
			this.textBox_minLuminosidade.Location = new System.Drawing.Point(167, 120);
			this.textBox_minLuminosidade.Name = "textBox_minLuminosidade";
			this.textBox_minLuminosidade.Size = new System.Drawing.Size(133, 20);
			this.textBox_minLuminosidade.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(48, 123);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(113, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Luminosidade Mínima:";
			// 
			// Configurar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(323, 200);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox_minLuminosidade);
			this.Controls.Add(this.button_fechar);
			this.Controls.Add(this.button_guardar);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox_qualidadeAr);
			this.Controls.Add(this.textBox_maxTemperatura);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox_minTemperatura);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox_minHumidade);
			this.Name = "Configurar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Configurar";
			this.Load += new System.EventHandler(this.Configurar_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox_minHumidade;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox_minTemperatura;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox_maxTemperatura;
		private System.Windows.Forms.TextBox textBox_qualidadeAr;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button_guardar;
		private System.Windows.Forms.Button button_fechar;
		private System.Windows.Forms.TextBox textBox_minLuminosidade;
		private System.Windows.Forms.Label label5;
	}
}