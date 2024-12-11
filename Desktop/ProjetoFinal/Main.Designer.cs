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
			this.button_led1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label_qualidadeAr = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label_tempAr = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label_humSolo = new System.Windows.Forms.Label();
			this.button_led2 = new System.Windows.Forms.Button();
			this.button_led3 = new System.Windows.Forms.Button();
			this.label_humAr = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button_led1
			// 
			this.button_led1.Location = new System.Drawing.Point(54, 164);
			this.button_led1.Margin = new System.Windows.Forms.Padding(2);
			this.button_led1.Name = "button_led1";
			this.button_led1.Size = new System.Drawing.Size(66, 52);
			this.button_led1.TabIndex = 0;
			this.button_led1.Text = "Toggle LED 1";
			this.button_led1.UseVisualStyleBackColor = true;
			this.button_led1.Click += new System.EventHandler(this.ButtonClickHandler);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(53, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Qualidade Ar";
			// 
			// label_qualidadeAr
			// 
			this.label_qualidadeAr.AutoSize = true;
			this.label_qualidadeAr.Location = new System.Drawing.Point(81, 79);
			this.label_qualidadeAr.Name = "label_qualidadeAr";
			this.label_qualidadeAr.Size = new System.Drawing.Size(13, 13);
			this.label_qualidadeAr.TabIndex = 3;
			this.label_qualidadeAr.Text = "0";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(186, 46);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Temp/Hum Ar";
			// 
			// label_tempAr
			// 
			this.label_tempAr.AutoSize = true;
			this.label_tempAr.Location = new System.Drawing.Point(217, 79);
			this.label_tempAr.Name = "label_tempAr";
			this.label_tempAr.Size = new System.Drawing.Size(13, 13);
			this.label_tempAr.TabIndex = 5;
			this.label_tempAr.Text = "0";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(320, 46);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(79, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "Humidade Solo";
			// 
			// label_humSolo
			// 
			this.label_humSolo.AutoSize = true;
			this.label_humSolo.Location = new System.Drawing.Point(353, 79);
			this.label_humSolo.Name = "label_humSolo";
			this.label_humSolo.Size = new System.Drawing.Size(13, 13);
			this.label_humSolo.TabIndex = 7;
			this.label_humSolo.Text = "0";
			// 
			// button_led2
			// 
			this.button_led2.Location = new System.Drawing.Point(190, 164);
			this.button_led2.Margin = new System.Windows.Forms.Padding(2);
			this.button_led2.Name = "button_led2";
			this.button_led2.Size = new System.Drawing.Size(66, 52);
			this.button_led2.TabIndex = 9;
			this.button_led2.Text = "Toggle LED 2";
			this.button_led2.UseVisualStyleBackColor = true;
			this.button_led2.Click += new System.EventHandler(this.ButtonClickHandler);
			// 
			// button_led3
			// 
			this.button_led3.Location = new System.Drawing.Point(326, 164);
			this.button_led3.Margin = new System.Windows.Forms.Padding(2);
			this.button_led3.Name = "button_led3";
			this.button_led3.Size = new System.Drawing.Size(66, 52);
			this.button_led3.TabIndex = 11;
			this.button_led3.Text = "Toggle LED 3";
			this.button_led3.UseVisualStyleBackColor = true;
			this.button_led3.Click += new System.EventHandler(this.ButtonClickHandler);
			// 
			// label_humAr
			// 
			this.label_humAr.AutoSize = true;
			this.label_humAr.Location = new System.Drawing.Point(217, 97);
			this.label_humAr.Name = "label_humAr";
			this.label_humAr.Size = new System.Drawing.Size(13, 13);
			this.label_humAr.TabIndex = 13;
			this.label_humAr.Text = "0";
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(450, 257);
			this.Controls.Add(this.label_humAr);
			this.Controls.Add(this.button_led3);
			this.Controls.Add(this.button_led2);
			this.Controls.Add(this.label_humSolo);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label_tempAr);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label_qualidadeAr);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button_led1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Main";
			this.Text = "Main";
			this.Load += new System.EventHandler(this.Main_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_led1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label_qualidadeAr;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label_tempAr;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label_humSolo;
		private System.Windows.Forms.Button button_led2;
		private System.Windows.Forms.Button button_led3;
		private System.Windows.Forms.Label label_humAr;
	}
}

