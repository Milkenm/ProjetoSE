namespace ProjetoFinal
{
	public static class DataParser
	{
		public static bool TryDeserialize(string data, out DataValues parsedData)
		{
			parsedData = default;

			if (string.IsNullOrEmpty(data))
			{
				return false;
			}

			try
			{
				var splitData = data.Split(';');
				var latestData = splitData[splitData.Length - 1];
				var dataValues = latestData.Split(',');

				if (dataValues.Length < 4)
				{
					return false;
				}

				parsedData.HumidadeSolo = float.Parse(dataValues[0]);
				parsedData.HumidadeAr = float.Parse(dataValues[1]);
				parsedData.TemperaturaAr = float.Parse(dataValues[2]);
				parsedData.QualidadeAr = float.Parse(dataValues[3]);
				return true;
			}
			catch
			{
				return false;
			}
		}
	}

	public struct DataValues
	{
		public float HumidadeSolo { get; set; }
		public float HumidadeAr { get; set; }
		public float TemperaturaAr { get; set; }
		public float QualidadeAr { get; set; }
	}
}
