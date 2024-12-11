using System;
using System.Net;
using System.Windows.Forms;

namespace ProjetoFinal
{
	public partial class Main : Form
	{
		private UDP _udp = new UDP();
		private LedStateManager<Button> _ledStateManager = new LedStateManager<Button>();

		public Main()
		{
			InitializeComponent();

			_ledStateManager
				.AddObject(button_led1, "L1", "D1", false)
				.AddObject(button_led2, "L2", "D2", false)
				.AddObject(button_led3, "L3", "D3", false);
		}

		private void Main_Load(object sender, EventArgs e)
		{
			_udp.OnDataReceived += HandleReceivedData;
			_udp.StartServer(12345);
			_udp.StartClient(new IPEndPoint(IPAddress.Parse("255.255.255.255"), 12346));
		}

		private void HandleReceivedData(string data)
		{
			DataParser.TryDeserialize(data, out var dataValues);
			AtualizarValores(dataValues.HumidadeSolo, dataValues.HumidadeAr, dataValues.TemperaturaAr, dataValues.QualidadeAr);
		}

		private void AtualizarValores(float humidadeSolo, float humidadeAr, float temperaturaAr, float qualidadeAr)
		{
			label_humSolo.Text = humidadeSolo.ToString("F1");
			label_humAr.Text = humidadeAr.ToString("F1");
			label_tempAr.Text = temperaturaAr.ToString("F1");
			label_qualidadeAr.Text = qualidadeAr.ToString("F1");
		}

		private void ButtonClickHandler(object sender, EventArgs e)
		{
			var button = (Button)sender;

			_ledStateManager.ToggleState(button);
			var action = _ledStateManager.GetLedAction(button);

			_udp.AddMessage(action);
		}
	}
}
