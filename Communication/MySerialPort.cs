using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Windows.Threading;
using System.Windows;

namespace ZMCL.Communication
{
	public class MySerialPort
	{
		#region attribute
		public delegate void MethodReference();

		private MethodReference ReceiveCompleted;

		public SerialPort SerialPortObject { get; set; }

		public string PortName { get; set; }

		public int BaudRate { get; set; }

		public int DataBit { get; set; }

		public Parity ParityBit { get; set; }

		public StopBits StopBit { get; set; }

		public bool askCloseFlag { get; set; }

		public bool receivingFlag { get; set; }
		#endregion

		#region method

		/// <summary>
		/// 空构造函数
		/// </summary>
		public MySerialPort() { }

		/// <summary>
		/// 构造函数重载
		/// </summary>
		/// <param name="portName"></param>
		/// <param name="baudRate"></param>
		/// <param name="dataBit"></param>
		/// <param name="parityBit"></param>
		/// <param name="stopBit"></param>
		/// <param name="receivedAction"></param>
		public MySerialPort(string portName, int baudRate, int dataBit, Parity parityBit, StopBits stopBit, Action receivedAction)
		{
			this.SerialPortObject = new SerialPort(portName, baudRate, parityBit, dataBit, stopBit);

			//this.SerialPortObject.ReceivedBytesThreshold = threshold;

			this.receivingFlag = false;

			this.askCloseFlag = false;

			this.SerialPortObject.DataReceived += SerialPortObject_DataReceived;

			this.ReceiveCompleted = new MethodReference(receivedAction);
		}

		/// <summary>
		/// 构造函数重载
		/// </summary>
		/// <param name="portName"></param>
		/// <param name="baudRate"></param>
		/// <param name="dataBit"></param>
		/// <param name="parityBit"></param>
		/// <param name="stopBit"></param>
		/// <param name="threshold">缓存容量（收到多少量开始触发接收事件）</param>
		/// <param name="receivedAction">接收事件触发后需要做的委托方法</param>
		public MySerialPort(string portName, int baudRate, int dataBit, Parity parityBit, StopBits stopBit, int threshold, Action receivedAction)
		{
			this.CreatNewSerialPort(portName, baudRate, dataBit, ParityBit, stopBit, threshold, receivedAction);
		}

		/// <summary>
		/// 创建一个新的串口对象
		/// </summary>
		/// <param name="portName"></param>
		/// <param name="baudRate"></param>
		/// <param name="dataBit"></param>
		/// <param name="parityBit"></param>
		/// <param name="stopBit"></param>
		/// <param name="threshold">缓存容量（收到多少量开始触发接收事件）</param>
		/// <param name="receivedAction">接收事件触发后需要做的委托方法</param>
		public void CreatNewSerialPort(string portName, int baudRate, int dataBit, Parity parityBit, StopBits stopBit, int threshold, Action receivedAction)
		{
			this.SerialPortObject = new SerialPort(portName, baudRate, parityBit, dataBit, stopBit);

			this.SerialPortObject.ReceivedBytesThreshold = threshold;

			this.receivingFlag = false;

			this.askCloseFlag = false;

			this.SerialPortObject.DataReceived += SerialPortObject_DataReceived;

			this.ReceiveCompleted = new MethodReference(receivedAction);
		}

		public void CreatNewSerialPort(string portName, int baudRate, int dataBit, Parity parityBit, StopBits stopBit, Action receivedAction)
		{
			this.SerialPortObject = new SerialPort(portName, baudRate, parityBit, dataBit, stopBit);

			//this.SerialPortObject.ReceivedBytesThreshold = threshold;

			this.receivingFlag = false;

			this.askCloseFlag = false;

			this.SerialPortObject.DataReceived += SerialPortObject_DataReceived;

			this.ReceiveCompleted = new MethodReference(receivedAction);
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SerialPortObject_DataReceived(object sender, SerialDataReceivedEventArgs e)
		{
			try
			{
				this.ReceiveCompleted();
			}
			catch
			{
				throw new NotImplementedException();
			}
			//
		}

		/// <summary>
		/// get hot port name to collcetion
		/// </summary>
		/// <returns></returns>
		public List<string> GetPortNameList()
		{
			List<string> returnResult = new List<string>(20);

			foreach (string portName in SerialPort.GetPortNames())
			{
				SerialPort temporaryPort = new SerialPort(portName);
				try
				{
					returnResult.Add(portName);

					temporaryPort.Open();
				}
				catch
				{

				}
				finally
				{
					temporaryPort.Close();
				}
			}
			return returnResult;
		}

		/// <summary>
		/// 从串口获得字节数组的方法函数
		/// </summary>
		/// <returns>返回得到的字节数组信息</returns>
		public byte[] GetByteArray()
		{
			int bytes_count = this.SerialPortObject.BytesToRead;

			byte[] resultAarray = new byte[bytes_count];

			if (this.askCloseFlag == true)
			{
				return new byte[] { 0x00, 0x00 };
			}
			else
			{
				try
				{
					this.receivingFlag = true;
				
					this.SerialPortObject.Read(resultAarray, 0, bytes_count);
					
				}
				catch
				{
					this.SerialPortObject.Close();
				}
				finally
				{
					this.receivingFlag = false;
				}
				return resultAarray;
			}
		}

		

		/// <summary>
		/// get single byte from port
		/// </summary>
		/// <param name="size"></param>
		/// <returns></returns>
		public byte GetByte()
		{
			//List<byte> resultList = new List<byte>(size);
			byte result = 0;
			try
			{
				this.receivingFlag = true;

				result = (byte)this.SerialPortObject.ReadByte();
			}
			catch
			{
				this.SerialPortObject.Close();
			}
			finally
			{
				this.receivingFlag = false;
			}
			return result;
		}

		

		/// <summary>
		/// 从串口获取一行字符串信息方法函数
		/// </summary>
		/// <returns>返回字符串信息</returns>
		public string GetStringLine()
		{
			string receive_string = string.Empty;
			if (this.askCloseFlag == true)
			{
				return string.Empty;
			}
			else
			{
				try
				{
					this.receivingFlag = true;

					receive_string = this.SerialPortObject.ReadExisting();
					//this.receive_string = this.serial_port.ReadLine();
				}
				catch
				{
					this.SerialPortObject.Close();
				}
				finally
				{
					this.receivingFlag = false;
				}

				return receive_string;
			}
		}

		/// <summary>
		/// 从串口获取所有字符串信息方法函数
		/// </summary>
		/// <returns></returns>
		public string GetStringAll()
		{
			string result = this.SerialPortObject.ReadExisting();
			this.SerialPortObject.DiscardInBuffer();
			return result;

		}

		/// <summary>
		/// transmit byte list(from parameter) to serial port
		/// </summary>
		/// <param name="byte_list"></param>
		public bool SendByteList(List<byte> byte_list)
		{
			bool success = false;

			if (this.SerialPortObject.IsOpen)
			{
				if (!this.askCloseFlag)
				{
					try
					{
						this.SerialPortObject.Write(byte_list.ToArray(), 0, byte_list.Count);
						success = true;
					}
					catch
					{
						success = false;
					}
					finally
					{
						//this.transmit_flag = false;
					}
				}
				else
				{
					success = false;
				}
			}
			else
			{
				success = false;
			}
			return success;
		}

		/// <summary>
		/// 向串口写入字符串信息
		/// </summary>
		/// <param name="string_style">是否写入换行符号</param>
		public void SendStringLine(SendingStyleEnum string_style, string send_string)
		{
			if (this.askCloseFlag == true)
			{
				return;
			}
			else
			{
				try
				{
					switch (string_style)
					{
						case SendingStyleEnum.Parallel:
						{
							// "\r" = "Enter(0D)" "\n" = "new line(0A)"
							this.SerialPortObject.NewLine = "\r\n";
							this.SerialPortObject.WriteLine(send_string);
							break;
						}
						case SendingStyleEnum.Serial:
						{

							this.SerialPortObject.Write(send_string);
							break;
						}
						default:
						{
							this.SerialPortObject.Write(send_string);
							break;
						}
					}
				}
				finally
				{

				}
			}
		}

		/// <summary>
		/// transmit hex string(from parameter) to serial port
		/// </summary>
		/// <param name="hex_list"></param>
		public void SendHexList(List<string> hex_list)
		{
			if (this.askCloseFlag == true)
			{
				return;
			}
			else
			{
				try
				{
					List<byte> data_list = new List<byte>();

					/*
					MatchCollection range = Regex.Matches(string_data,
						@"(?i)(?<=([a-f0-9]{2})*)[a-f0-9]{2}");

					foreach (Match member in range)
					{
						data_list.Add(byte.Parse(member.Value, System.Globalization.NumberStyles.HexNumber));
					}
					*/

					//Convert.ToString(data, 16).ToUpper()

					foreach (string member in hex_list)
					{
						data_list.Add(byte.Parse(member, System.Globalization.NumberStyles.HexNumber));
					}

					this.SerialPortObject.Write(data_list.ToArray(), 0, data_list.Count);

					//this.sent_bytes_count += data_list.Count;
				}
				finally
				{
					//this.transmit_flag = false;
				}
			}
		}

		/// <summary>
		/// port close method
		/// </summary>
		public bool ClosePort()
		{
			bool result = false;
			try
			{
				this.askCloseFlag = true;

				do
				{
					WpfApplication.DoEvents();
				}
				while (this.receivingFlag == true);

				this.SerialPortObject.Close();

				this.askCloseFlag = false;

				result = true;
			}
			catch
			{
				result = false;
			}
			return result;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public bool OpenPort()
		{
			bool result = false;
			if (this.SerialPortObject.IsOpen == true)
			{
				result = false;
			}
			else
			{
				try
				{
					this.askCloseFlag = false;

					//this.ConfigurePort();

					this.SerialPortObject.Open();

					result = true;
				}
				catch
				{
					return false;
				}
			}
			return result;
		}

		/// <summary>
		/// 
		/// </summary>
		private void ConfigurePort()
		{
			this.SerialPortObject.PortName = this.PortName;
			this.SerialPortObject.BaudRate = this.BaudRate;
			this.SerialPortObject.DataBits = this.DataBit;
			this.SerialPortObject.Parity = this.ParityBit;
			this.SerialPortObject.StopBits = this.StopBit;
		}

		#endregion

		#region class
		public class WpfApplication : Application
		{
			private static DispatcherOperationCallback exitFrameCallback = new DispatcherOperationCallback(ExitFrame);

			public static void DoEvents()
			{
				DispatcherFrame nestedFrame = new DispatcherFrame();

				DispatcherOperation exitOperation = Dispatcher.CurrentDispatcher.BeginInvoke(
							   DispatcherPriority.Background, exitFrameCallback, nestedFrame);
				Dispatcher.PushFrame(nestedFrame);

				if (exitOperation.Status != DispatcherOperationStatus.Completed)
				{
					exitOperation.Abort();
				}
			}
			private static Object ExitFrame(Object state)
			{
				DispatcherFrame frame = state as DispatcherFrame;

				frame.Continue = false;

				return null;
			}
		}
		#endregion


		/// <summary>
		/// string style enum
		/// </summary>
		[Flags]
		public enum SendingStyleEnum
		{
			Parallel,
			Serial
		}
	}
}
