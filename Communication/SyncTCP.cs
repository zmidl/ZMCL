using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace ZMCL.Communication
{
	public class SyncTcpServer
	{
		public delegate void MethodReference();

		public MethodReference ReceiveCompleted;

		public int ReceivedLength { get; set; }

		public string ReceivedString { get; set; }

		public byte[] ReceivedBytes { get; set; }

		public string SendingString { get; set; }

		public byte[] SendingBytes { get; set; }

		public int ClientCount { get; set; }

		public int BrokenCount { get; set; }

		protected static TcpListener TcpListenerObject;

		protected BinaryReader BinaryReaderObject;

		protected BinaryWriter BinaryWriterObject;

		public bool InvokeExit { get; set; }

		public bool IsListening_bool { get; set; }

		public SyncTcpServer(string serverIpAddress, int port)
		{
			TcpListenerObject = new TcpListener(new IPEndPoint(IPAddress.Parse(serverIpAddress), port));

			TcpListenerObject.Start();

			this.InvokeExit = false;

			this.ClientCount = 0;

			this.ReceivedLength = 80;

			this.IsListening_bool = true;
		}

		public virtual void Listen(object obj)
		{
			while (this.IsListening_bool)
			{
				TcpClient newTcpClient = TcpListenerObject.AcceptTcpClient();

				this.ClientCount += 1;

				this.InvokeExit = false;

				if (newTcpClient != null)
				{
					NetworkStream networkStream = newTcpClient.GetStream();

					this.BinaryReaderObject = new BinaryReader(networkStream);

					this.BinaryWriterObject = new BinaryWriter(networkStream);

					ThreadPool.QueueUserWorkItem(new WaitCallback(this.Receive));
				}
				else
				{
					this.ClientCount = 0;
				}
			}
		}

		public virtual void Receive(Object newTcpClient)
		{
			while (this.InvokeExit == false)
			{
				try
				{
					this.ReceivedBytes = this.BinaryReaderObject.ReadBytes(80);

					if (this.ReceivedBytes[0] == 0)
					{
						// this.InvokeExit = true;
						break;
					}
					//if (this.ReceivingLock == false)
					//{
					//    ReceiveCompleted();
					//}

					ReceiveCompleted();
				}

				catch
				{
					///System.Windows.Forms.MessageBox.Show(ex.Message + "接收");
					this.ClientCount -= 1;
					this.BrokenCount++;
					//InvokeExit = true;
				}
				finally
				{

				}
			}
		}

		public virtual void Send(byte[] sendingBytes)
		{
			if (InvokeExit == false)
			{
				try
				{
					this.BinaryWriterObject.Write(sendingBytes);

					this.BinaryWriterObject.Flush();

					//this.BinaryWriterObject.Write(BitmapImageToByteArray(Application.StartupPath + @"/img/i1.png"));
				}
				catch (Exception ex)
				{
					this.ClientCount--;
					this.BrokenCount++;
					System.Windows.Forms.MessageBox.Show(ex.Message + "发送");
					this.InvokeExit = true;
				}
			}
		}

		public void StopListening()
		{
			//this.TcpListenerObject.Stop();
			TcpListenerObject.Stop();
		}
	}

	public class SyncTcpClient
	{
		private delegate void MethodReference();
		private MethodReference ReceiveCompleted;
		private MethodReference ReceivingError;
		private MethodReference SendingError;
		private MethodReference ConnectingError;

		private TcpClient TcpClientObject;

		private BinaryReader BinaryReaderObject;

		private BinaryWriter BinaryWriterObject;

		private IPEndPoint RemoteIpEndPoint;

		//private IPEndPoint LocalIpEndPoint;

		private int RemotePort_int;

		private string RemoteIp_string;

		private bool InvokeDisconnect_bool;

		//private byte[] ReceivedBytes_byteArray;

		//private byte[] SendingBytes_byteArray;

		private int ReceivingLength_int;

		public string ReceivedString_string { get; set; }

		private bool IsConnectionSuccess_bool { get; set; }

		public bool IsConnectedFlag_bool { get; set; }

		public SyncTcpClient(string remoteIp, int remotePort, int receivingLength,
		   Action receiveCompleted, Action receivingError, Action sendingError, Action connectingError)
		{
			this.IsConnectedFlag_bool = false;

			this.RemoteIp_string = remoteIp;

			this.RemotePort_int = remotePort;

			this.RemoteIpEndPoint = new IPEndPoint(IPAddress.Parse(this.RemoteIp_string), this.RemotePort_int);

			this.ReceivingLength_int = receivingLength;

			this.ReceiveCompleted = new MethodReference(receiveCompleted);

			this.ReceivingError = new MethodReference(receivingError);

			this.SendingError = new MethodReference(sendingError);

			this.ConnectingError = new MethodReference(connectingError);
		}

		public void ConnectingHost()
		{
			this.TcpClientObject = new TcpClient();

			this.InvokeDisconnect_bool = false;

			this.TcpClientObject.BeginConnect
				(this.RemoteIp_string, this.RemotePort_int, new AsyncCallback
				((IAsyncResult result) =>
				{
					TcpClient client = (TcpClient)result.AsyncState;
					if (client.Connected == true)
					{
						this.IsConnectedFlag_bool = true;
						this.BinaryReaderObject = new BinaryReader(this.TcpClientObject.GetStream());

						this.BinaryWriterObject = new BinaryWriter(this.TcpClientObject.GetStream());

						Thread ReceiveBytesThread = new Thread(new ThreadStart(this.ReceiveBytes));

						ReceiveBytesThread.IsBackground = true;

						ReceiveBytesThread.Start();
					}
					else
					{
						//client.EndConnect(result);
						this.IsConnectedFlag_bool = false;
						this.ConnectingError();
					}
				}), 
				this.TcpClientObject);




			//this.TcpClientObject = new TcpClient();

			//this.InvokeDisconnect_bool = false;
			//try
			//{
			//	// 尝试连接远程主机
			//	this.TcpClientObject.Connect(this.RemoteIpEndPoint);
			//	this.IsConnectedFlag_bool = true;
			//}
			//catch (ArgumentNullException)
			//{
			//	//throw new ArgumentNullException();
			//	this.IsConnectedFlag_bool = false;
			//	this.ConnectingError();
			//	return;
			//}
			//catch (SocketException)
			//{
			//	//throw new SocketException();
			//	this.IsConnectedFlag_bool = false;
			//	this.ConnectingError();
			//	return;
			//}
			//catch (ObjectDisposedException)
			//{
			//	//throw new ObjectDisposedException();
			//	this.IsConnectedFlag_bool = false;
			//	this.ConnectingError();
			//	return;
			//}

			//this.BinaryReaderObject = new BinaryReader(this.TcpClientObject.GetStream());

			//this.BinaryWriterObject = new BinaryWriter(this.TcpClientObject.GetStream());

			//Thread ReceiveBytesThread = new Thread(new ThreadStart(this.ReceiveBytes));
			////Thread ReceiveStringThread = new Thread(new ThreadStart(this.ReceiveString));

			//ReceiveBytesThread.IsBackground = true;
			////ReceiveStringThread.IsBackground = true;

			//ReceiveBytesThread.Start();
			////ReceiveStringThread.Start();
		}

		public bool DisconnectionHost()
		{
			bool result = false;
			try
			{
				this.BinaryReaderObject.Close();
				this.BinaryWriterObject.Close();
				this.TcpClientObject.Close();
				result = true;
			}
			catch
			{

			}
			return result;
		}

		private void ReceiveBytes()
		{

			try
			{

				while (this.InvokeDisconnect_bool == false)
				{
					byte[] buffer = new byte[1024];
					this.BinaryReaderObject.Read(buffer, 0, 1024);
					this.ReceivedString_string = Encoding.UTF8.GetString(buffer);
					this.ReceiveCompleted();
				}
			}
			catch (ArgumentException)
			{
				this.TcpClientObject.Close();
				this.InvokeDisconnect_bool = true;
				this.ReceivingError();
				//throw new ArgumentException();
			}
			catch (IOException)
			{
				this.TcpClientObject.Close();
				this.InvokeDisconnect_bool = true;
				this.ReceivingError();
				//throw new IOException();
			}
			catch (ObjectDisposedException)
			{
				this.TcpClientObject.Close();
				this.InvokeDisconnect_bool = true;
				this.ReceivingError();
				//throw new ObjectDisposedException(string.Format("读取二进制流对象"));
			}
			finally
			{

			}
		}

		private void ReceiveString()
		{
			try
			{
				while (this.InvokeDisconnect_bool == false)
				{
					this.ReceivedString_string = this.BinaryReaderObject.ReadString();
					this.ReceiveCompleted();
				}
			}
			catch (ArgumentException)
			{
				this.TcpClientObject.Close();
				this.InvokeDisconnect_bool = true;
				this.ReceivingError();
				//throw new ArgumentException();
			}
			catch (IOException)
			{
				this.TcpClientObject.Close();
				this.InvokeDisconnect_bool = true;
				this.ReceivingError();
				//throw new IOException();
			}
			catch (ObjectDisposedException)
			{
				this.TcpClientObject.Close();
				this.InvokeDisconnect_bool = true;
				this.ReceivingError();
				//throw new ObjectDisposedException(string.Format("读取二进制流对象"));
			}
			finally
			{

			}
		}

		public void SendBytes(byte[] byteArray)
		{
			if (this.InvokeDisconnect_bool == false)
			{
				try
				{
					//this.SendingBytes = this.StructToBytes();

					this.BinaryWriterObject.Write(byteArray);

					this.BinaryWriterObject.Flush();
					//this.BinaryWriterObject.Write(BitmapImageToByteArray(Application.StartupPath + @"/img/i1.png"));
				}
				catch (IOException)
				{
					this.TcpClientObject.Close();
					this.InvokeDisconnect_bool = true;
					throw new IOException();
				}
				catch (ArgumentNullException)
				{
					this.TcpClientObject.Close();
					this.InvokeDisconnect_bool = true;
					throw new ArgumentNullException();
				}
				finally
				{

				}
			}
		}

		public IPEndPoint GetIp()
		{
			return this.RemoteIpEndPoint;
		}
	}
}
