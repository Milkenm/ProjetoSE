namespace ProjetoFinal
{
    partial class Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.button_ac = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button_rega = new System.Windows.Forms.Button();
			this.button_alarme = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox_qualidadeAr = new System.Windows.Forms.TextBox();
			this.textBox_temperaturaAr = new System.Windows.Forms.TextBox();
			this.textBox_humidadeAr = new System.Windows.Forms.TextBox();
			this.textBox_humidadeSolo = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button_configurar = new System.Windows.Forms.Button();
			this.radio_automatico = new System.Windows.Forms.RadioButton();
			this.radio_manual = new System.Windows.Forms.RadioButton();
			this.button_luz = new System.Windows.Forms.Button();
			this.textBox_luminosidade = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// button_ac
			// 
			this.button_ac.BackColor = System.Drawing.Color.IndianRed;
			this.button_ac.Location = new System.Drawing.Point(6, 95);
			this.button_ac.Margin = new System.Windows.Forms.Padding(2);
			this.button_ac.Name = "button_ac";
			this.button_ac.Size = new System.Drawing.Size(66, 52);
			this.button_ac.TabIndex = 0;
			this.button_ac.Text = "A/C";
			this.button_ac.UseVisualStyleBackColor = false;
			this.button_ac.Click += new System.EventHandler(this.ButtonClickHandler);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(31, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Qualidade do Ar:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(47, 52);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Temperatura:";
			// 
			// button_rega
			// 
			this.button_rega.BackColor = System.Drawing.Color.IndianRed;
			this.button_rega.Location = new System.Drawing.Point(76, 95);
			this.button_rega.Margin = new System.Windows.Forms.Padding(2);
			this.button_rega.Name = "button_rega";
			this.button_rega.Size = new System.Drawing.Size(66, 52);
			this.button_rega.TabIndex = 9;
			this.button_rega.Text = "Rega";
			this.button_rega.UseVisualStyleBackColor = false;
			this.button_rega.Click += new System.EventHandler(this.ButtonClickHandler);
			// 
			// button_alarme
			// 
			this.button_alarme.BackColor = System.Drawing.Color.IndianRed;
			this.button_alarme.Location = new System.Drawing.Point(146, 95);
			this.button_alarme.Margin = new System.Windows.Forms.Padding(2);
			this.button_alarme.Name = "button_alarme";
			this.button_alarme.Size = new System.Drawing.Size(66, 52);
			this.button_alarme.TabIndex = 11;
			this.button_alarme.Text = "Alarme";
			this.button_alarme.UseVisualStyleBackColor = false;
			this.button_alarme.Click += new System.EventHandler(this.ButtonClickHandler);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(59, 78);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 14;
			this.label2.Text = "Humidade:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(20, 104);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(97, 13);
			this.label4.TabIndex = 15;
			this.label4.Text = "Humidade do Solo:";
			// 
			// textBox_qualidadeAr
			// 
			this.textBox_qualidadeAr.Location = new System.Drawing.Point(123, 23);
			this.textBox_qualidadeAr.Name = "textBox_qualidadeAr";
			this.textBox_qualidadeAr.ReadOnly = true;
			this.textBox_qualidadeAr.Size = new System.Drawing.Size(121, 20);
			this.textBox_qualidadeAr.TabIndex = 16;
			// 
			// textBox_temperaturaAr
			// 
			this.textBox_temperaturaAr.Location = new System.Drawing.Point(123, 49);
			this.textBox_temperaturaAr.Name = "textBox_temperaturaAr";
			this.textBox_temperaturaAr.ReadOnly = true;
			this.textBox_temperaturaAr.Size = new System.Drawing.Size(121, 20);
			this.textBox_temperaturaAr.TabIndex = 17;
			// 
			// textBox_humidadeAr
			// 
			this.textBox_humidadeAr.Location = new System.Drawing.Point(123, 75);
			this.textBox_humidadeAr.Name = "textBox_humidadeAr";
			this.textBox_humidadeAr.ReadOnly = true;
			this.textBox_humidadeAr.Size = new System.Drawing.Size(121, 20);
			this.textBox_humidadeAr.TabIndex = 18;
			// 
			// textBox_humidadeSolo
			// 
			this.textBox_humidadeSolo.Location = new System.Drawing.Point(123, 101);
			this.textBox_humidadeSolo.Name = "textBox_humidadeSolo";
			this.textBox_humidadeSolo.ReadOnly = true;
			this.textBox_humidadeSolo.Size = new System.Drawing.Size(121, 20);
			this.textBox_humidadeSolo.TabIndex = 19;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 23);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(37, 13);
			this.label5.TabIndex = 20;
			this.label5.Text = "Modo:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.textBox_luminosidade);
			this.groupBox1.Controls.Add(this.textBox_qualidadeAr);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.textBox_humidadeSolo);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.textBox_humidadeAr);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.textBox_temperaturaAr);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Location = new System.Drawing.Point(11, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(265, 161);
			this.groupBox1.TabIndex = 21;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Sensores";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button_luz);
			this.groupBox2.Controls.Add(this.button_configurar);
			this.groupBox2.Controls.Add(this.radio_automatico);
			this.groupBox2.Controls.Add(this.radio_manual);
			this.groupBox2.Controls.Add(this.button_ac);
			this.groupBox2.Controls.Add(this.button_rega);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.button_alarme);
			this.groupBox2.Location = new System.Drawing.Point(282, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(289, 161);
			this.groupBox2.TabIndex = 22;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Controlos";
			// 
			// button_configurar
			// 
			this.button_configurar.Location = new System.Drawing.Point(197, 13);
			this.button_configurar.Name = "button_configurar";
			this.button_configurar.Size = new System.Drawing.Size(85, 23);
			this.button_configurar.TabIndex = 23;
			this.button_configurar.Text = "Configurar";
			this.button_configurar.UseVisualStyleBackColor = true;
			this.button_configurar.Click += new System.EventHandler(this.button_configurar_Click);
			// 
			// radio_automatico
			// 
			this.radio_automatico.AutoSize = true;
			this.radio_automatico.Location = new System.Drawing.Point(49, 44);
			this.radio_automatico.Name = "radio_automatico";
			this.radio_automatico.Size = new System.Drawing.Size(78, 17);
			this.radio_automatico.TabIndex = 22;
			this.radio_automatico.Text = "Automático";
			this.radio_automatico.UseVisualStyleBackColor = true;
			this.radio_automatico.CheckedChanged += new System.EventHandler(this.radio_automatico_CheckedChanged);
			// 
			// radio_manual
			// 
			this.radio_manual.AutoSize = true;
			this.radio_manual.Checked = true;
			this.radio_manual.Location = new System.Drawing.Point(49, 21);
			this.radio_manual.Name = "radio_manual";
			this.radio_manual.Size = new System.Drawing.Size(60, 17);
			this.radio_manual.TabIndex = 21;
			this.radio_manual.TabStop = true;
			this.radio_manual.Text = "Manual";
			this.radio_manual.UseVisualStyleBackColor = true;
			// 
			// button_luz
			// 
			this.button_luz.BackColor = System.Drawing.Color.IndianRed;
			this.button_luz.Location = new System.Drawing.Point(216, 95);
			this.button_luz.Margin = new System.Windows.Forms.Padding(2);
			this.button_luz.Name = "button_luz";
			this.button_luz.Size = new System.Drawing.Size(66, 52);
			this.button_luz.TabIndex = 24;
			this.button_luz.Text = "Luz";
			this.button_luz.UseVisualStyleBackColor = false;
			this.button_luz.Click += new System.EventHandler(this.ButtonClickHandler);
			// 
			// textBox_luminosidade
			// 
			this.textBox_luminosidade.Location = new System.Drawing.Point(123, 127);
			this.textBox_luminosidade.Name = "textBox_luminosidade";
			this.textBox_luminosidade.ReadOnly = true;
			this.textBox_luminosidade.Size = new System.Drawing.Size(121, 20);
			this.textBox_luminosidade.TabIndex = 20;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(42, 130);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(75, 13);
			this.label6.TabIndex = 21;
			this.label6.Text = "Luminosidade:";
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(582, 185);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sistema de controlo de estufas";
			this.Load += new System.EventHandler(this.Main_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_ac;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button_rega;
		private System.Windows.Forms.Button button_alarme;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox_qualidadeAr;
		private System.Windows.Forms.TextBox textBox_temperaturaAr;
		private System.Windows.Forms.TextBox textBox_humidadeAr;
		private System.Windows.Forms.TextBox textBox_humidadeSolo;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton radio_automatico;
		private System.Windows.Forms.RadioButton radio_manual;
		private System.Windows.Forms.Button button_configurar;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox_luminosidade;
		private System.Windows.Forms.Button button_luz;
	}
}

