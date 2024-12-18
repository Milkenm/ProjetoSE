using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
	public class UDP
	{
		private UdpClient _client = new UdpClient( 12346 );
		private Stack<string> _toSend = new Stack<string>();

		public event Action<string> OnDataReceived;

		public void StartServer( ushort localPort )
		{
			var localEndPoint = new IPEndPoint( IPAddress.Any, localPort );

			Task.Run( () =>
			{
				try
				{
					while ( true )
					{
						var receivedBytes = _client.Receive( ref localEndPoint );
						var receivedData = Encoding.UTF8.GetString( receivedBytes );

						OnDataReceived?.Invoke( receivedData );
					}
				}
				catch ( Exception ex )
				{
					Debug.WriteLine( ex.ToString() );
				}
			} );
		}

		public void StartClient( IPEndPoint remoteEndPoint )
		{
			Task.Run( async () =>
			{
				try
				{
					while ( true )
					{
						if ( _toSend.Count > 0 )
						{
							var bytes = Encoding.ASCII.GetBytes( _toSend.Pop() );
							_client.Send( bytes, bytes.Length, remoteEndPoint );
						}

						await Task.Delay( 1000 );
					}
				}
				catch ( Exception ex )
				{
					Debug.WriteLine( ex.ToString() );
				}
			} );
		}

		public void AddMessage( string message )
		{
			_toSend.Push( message );
		}
	}
}
