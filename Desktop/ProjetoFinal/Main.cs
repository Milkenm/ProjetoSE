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
			var splitData = data.Split(';');
			var latestData = splitData[splitData.Length - 1];
			var dataValues = latestData.Split(',');

			var humidadeSolo = float.Parse(dataValues[0]);
			var humidadeAr = float.Parse(dataValues[1]);
			var temperaturaAr = float.Parse(dataValues[2]);
			var qualidadeAr = float.Parse(dataValues[3]);

			AtualizarValores(humidadeSolo, humidadeAr, temperaturaAr, qualidadeAr);
		}

		private void AtualizarValores(float humidadeSolo, float humidadeAr, float temperaturaAr, float qualidadeAr)
		{
			label_humSolo.Text = humidadeSolo.ToString();
			label_humAr.Text = humidadeAr.ToString();
			label_tempAr.Text = temperaturaAr.ToString();
			label_qualidadeAr.Text = qualidadeAr.ToString();
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
