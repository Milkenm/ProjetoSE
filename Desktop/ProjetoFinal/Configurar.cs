using System;
using System.Windows.Forms;

using ProjetoFinal.Properties;

namespace ProjetoFinal
{
	public partial class Configurar : Form
	{
		public Configurar()
		{
			InitializeComponent();
		}

		private void Configurar_Load( object sender, EventArgs e )
		{
			textBox_qualidadeAr.Text = Settings.Default.MaxQualidadeAr.ToString();
			textBox_minHumidade.Text = Settings.Default.MinHumidadeAr.ToString();
			textBox_minTemperatura.Text = Settings.Default.MinTemperatura.ToString();
			textBox_maxTemperatura.Text = Settings.Default.MaxTemperatura.ToString();
			textBox_minLuminosidade.Text = Settings.Default.MinLuminosidade.ToString();
		}

		private void button_guardar_Click( object sender, EventArgs e )
		{
			Settings.Default.MaxQualidadeAr = Convert.ToSingle( textBox_qualidadeAr.Text );
			Settings.Default.MinHumidadeAr = Convert.ToSingle( textBox_minHumidade.Text );
			Settings.Default.MinTemperatura = Convert.ToSingle( textBox_minTemperatura.Text );
			Settings.Default.MaxTemperatura = Convert.ToSingle( textBox_maxTemperatura.Text );
			Settings.Default.MinLuminosidade = Convert.ToSingle( textBox_minLuminosidade.Text );
			Settings.Default.Save();

			Close();
		}

		private void button_fechar_Click( object sender, EventArgs e )
		{
			Close();
		}
	}
}
