using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

using ProjetoFinal;

namespace SimuladorArduino
{
	public partial class Arduino : Form
	{
		private UDP _udp = new UDP();

		public Arduino()
		{
			InitializeComponent();
		}

		private void Arduino_Load( object sender, EventArgs e )
		{
			_udp.OnDataReceived += HandleReceivedData;
			_udp.StartServer( 12346 );
			_udp.StartClient( new IPEndPoint( IPAddress.Loopback, 12345 ) );
		}

		private void HandleReceivedData( string data )
		{
			Console.WriteLine( data );

			foreach ( var action in data.Split( ';' ) )
			{
				switch ( action )
				{
					case "L1":
						panel_ac.BackColor = Color.OliveDrab;
						break;
					case "D1":
						panel_ac.BackColor = Color.WhiteSmoke;
						break;
					case "L2":
						panel_rega.BackColor = Color.OliveDrab;
						break;
					case "D2":
						panel_rega.BackColor = Color.WhiteSmoke;
						break;
					case "L3":
						panel_alarme.BackColor = Color.OliveDrab;
						break;
					case "D3":
						panel_alarme.BackColor = Color.WhiteSmoke;
						break;
					case "L4":
						panel_luz.BackColor = Color.OliveDrab;
						break;
					case "D4":
						panel_luz.BackColor = Color.WhiteSmoke;
						break;
				}
			}
		}

		private void button_enviar_Click( object sender, EventArgs e )
		{
			var qualidadeAr = Convert.ToSingle( textBox_qualidadeAr.Text );
			var temperatura = Convert.ToSingle( textBox_temperatura.Text );
			var humidade = Convert.ToSingle( textBox_humidade.Text );
			var humidadeSolo = Convert.ToSingle( textBox_humidadeSolo.Text );
			var luminosidade = Convert.ToSingle( textBox_luminosidade.Text );

			var dataValues = $"{humidadeSolo},{humidade},{temperatura},{qualidadeAr},{luminosidade};";
			_udp.AddMessage( dataValues );
		}
	}
}
