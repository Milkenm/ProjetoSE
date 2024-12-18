using System;

using ProjetoFinal.Properties;

namespace ProjetoFinal
{
	public class ModoAutomatico
	{
		private LedStateManager<Dispositivo> _ledStateManager;

		public event Action<Dispositivo, bool> OnStateChange;

		public bool Enabled { get; set; }

		public ModoAutomatico( LedStateManager<Dispositivo> ledStateManager )
		{
			_ledStateManager = ledStateManager;
		}

		public void Update( DataValues dataValues )
		{
			if ( !Enabled )
			{
				return;
			}

			if ( dataValues.QualidadeAr > Settings.Default.MaxQualidadeAr )
			{
				if ( !_ledStateManager.GetState( Dispositivo.Alarme ) )
				{
					OnStateChange?.Invoke( Dispositivo.Alarme, true );
				}
			}
			else if ( _ledStateManager.GetState( Dispositivo.Alarme ) )
			{
				OnStateChange?.Invoke( Dispositivo.Alarme, false );
			}

			if ( dataValues.HumidadeSolo < Settings.Default.MinHumidadeAr || dataValues.HumidadeAr < Settings.Default.MinHumidadeSolo )
			{
				if ( !_ledStateManager.GetState( Dispositivo.Rega ) )
				{
					OnStateChange?.Invoke( Dispositivo.Rega, true );
				}
			}
			else if ( _ledStateManager.GetState( Dispositivo.Rega ) )
			{
				OnStateChange?.Invoke( Dispositivo.Rega, false );
			}

			if ( dataValues.TemperaturaAr < Settings.Default.MinTemperatura || dataValues.TemperaturaAr > Settings.Default.MaxTemperatura )
			{
				if ( !_ledStateManager.GetState( Dispositivo.AC ) )
				{
					OnStateChange?.Invoke( Dispositivo.AC, true );
				}
			}
			else if ( _ledStateManager.GetState( Dispositivo.AC ) )
			{
				OnStateChange?.Invoke( Dispositivo.AC, false );
			}
		}
	}
}
