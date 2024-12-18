using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace ProjetoFinal
{
	public partial class Main : Form, ILedController
	{
		private UDP _udp = new UDP();
		private LedStateManager<Dispositivo> _ledStateManager;
		private ModoAutomatico _modoAutomatico;

		private DataValues _lastDataValues;

		public Main()
		{
			InitializeComponent();

			_ledStateManager = new LedStateManager<Dispositivo>()
				.AddObject( Dispositivo.AC, "L1", "D1", false )
				.AddObject( Dispositivo.Rega, "L2", "D2", false )
				.AddObject( Dispositivo.Alarme, "L3", "D3", false );

			_modoAutomatico = new ModoAutomatico( _ledStateManager );
			_modoAutomatico.OnStateChange += ModoAutomaticoStateChange;
		}

		private void Main_Load( object sender, EventArgs e )
		{
			_udp.OnDataReceived += HandleReceivedData;
			_udp.StartServer( 12345 );
			_udp.StartClient( new IPEndPoint( IPAddress.Parse( "255.255.255.255" ), 12346 ) );
		}

		private void HandleReceivedData( string data )
		{
			DataParser.TryDeserialize( data, out var dataValues );
			_modoAutomatico.Update( dataValues );
			AtualizarValores( dataValues.HumidadeSolo, dataValues.HumidadeAr, dataValues.TemperaturaAr, dataValues.QualidadeAr );
			_lastDataValues = dataValues;
		}

		private void AtualizarValores( float humidadeSolo, float humidadeAr, float temperaturaAr, float qualidadeAr )
		{
			Invoke( new Action( () =>
			{
				textBox_humidadeSolo.Text = humidadeSolo.ToString( "F1" );
				textBox_humidadeAr.Text = humidadeAr.ToString( "F1" );
				textBox_temperaturaAr.Text = temperaturaAr.ToString( "F1" );
				textBox_qualidadeAr.Text = qualidadeAr.ToString( "F1" );
			} ) );
		}

		private void button_configurar_Click( object sender, EventArgs e )
		{
			var configurar = new Configurar();
			configurar.ShowDialog();
		}

		private void ButtonClickHandler( object sender, EventArgs e )
		{
			var button = (Button)sender;

			Dispositivo dispositivo;
			if ( button == button_ac )
			{
				dispositivo = Dispositivo.AC;
			}
			else if ( button == button_rega )
			{
				dispositivo = Dispositivo.Rega;
			}
			else if ( button == button_alarme )
			{
				dispositivo = Dispositivo.Alarme;
			}
			else
			{
				return;
			}

			SetEstado( dispositivo, !_ledStateManager.GetState( dispositivo ) );
		}

		public void SetEstado( Dispositivo dispositivo, bool ativado )
		{
			if ( ativado )
			{
				Ligar( dispositivo );
			}
			else
			{
				Desligar( dispositivo );
			}

			AtualizarCorBotoes();
		}

		public void Ligar( Dispositivo dispotivo )
		{
			_ledStateManager.SetState( dispotivo, true );
			var onState = _ledStateManager.GetLedAction( dispotivo );
			_udp.AddMessage( onState + ";" );
		}

		public void Desligar( Dispositivo dispotivo )
		{
			_ledStateManager.SetState( dispotivo, false );
			var offState = _ledStateManager.GetLedAction( dispotivo );
			_udp.AddMessage( offState + ";" );
		}

		private void radio_automatico_CheckedChanged( object sender, EventArgs e )
		{
			_modoAutomatico.Enabled = radio_automatico.Checked;

			button_ac.Enabled = !radio_automatico.Checked;
			button_rega.Enabled = !radio_automatico.Checked;
			button_alarme.Enabled = !radio_automatico.Checked;

			if ( _modoAutomatico.Enabled )
			{
				_modoAutomatico.Update( _lastDataValues );
			}
		}

		private void AtualizarCorBotoes()
		{
			foreach ( Dispositivo dispositivo in Enum.GetValues( typeof( Dispositivo ) ) )
			{
				Button button;
				if ( dispositivo == Dispositivo.AC )
				{
					button = button_ac;
				}
				else if ( dispositivo == Dispositivo.Rega )
				{
					button = button_rega;
				}
				else if ( dispositivo == Dispositivo.Alarme )
				{
					button = button_alarme;
				}
				else
				{
					continue;
				}

				button.BackColor = _ledStateManager.GetState( dispositivo ) ? Color.OliveDrab : Color.IndianRed;
			}
		}

		public void ModoAutomaticoStateChange( Dispositivo dispotivo, bool ativado )
		{
			SetEstado( dispotivo, ativado );
		}
	}
}
