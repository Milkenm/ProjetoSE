using System.Globalization;

namespace ProjetoFinal
{
	public static class DataParser
	{
		public static bool TryDeserialize( string data, out DataValues parsedData )
		{
			parsedData = default;

			if ( string.IsNullOrEmpty( data ) )
			{
				return false;
			}

			try
			{
				var splitData = data.Split( ';' );
				var latestData = splitData[splitData.Length - 2];
				latestData = latestData.Replace( "\r", "" ).Replace( "\n", "" );
				var dataValues = latestData.Split( ',' );

				if ( dataValues.Length < 4 )
				{
					return false;
				}

				CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

				parsedData.HumidadeSolo = float.Parse( dataValues[0] );
				parsedData.HumidadeAr = float.Parse( dataValues[1] );
				parsedData.TemperaturaAr = float.Parse( dataValues[2] );
				parsedData.QualidadeAr = float.Parse( dataValues[3] );
				parsedData.Luminosidade = float.Parse( dataValues[4] );
				return true;
			}
			catch
			{
				return false;
			}
		}
	}
}
