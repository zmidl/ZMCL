using System.Windows.Controls;
using System.Windows.Media;
using System.ComponentModel;
using System.Windows;

namespace ZMCL.MyControl
{
	public partial class UcDegitalDisplay : UserControl, INotifyPropertyChanged
	{
		private SolidColorBrush foregroundColor;
		public SolidColorBrush ForegroundColor
		{
			get
			{
				return foregroundColor;
			}
			set
			{
				foregroundColor = value;
				this.NotifyPropertyChanged("ForegroundColor");
			}
		}

		private SolidColorBrush backgroundColor;
		public SolidColorBrush BackgroundColor
		{
			get { return backgroundColor; }
			set { backgroundColor = value; this.NotifyPropertyChanged("BackgroundColor"); }
		}

		public int Value
		{
			get { return (int)GetValue(ValueProperty); }
			set { SetValue(ValueProperty, value); }
		}
		public static readonly DependencyProperty ValueProperty =
			DependencyProperty.Register("Value", typeof(int), typeof(UcDegitalDisplay), new PropertyMetadata(0, new PropertyChangedCallback(Callback)));



		public UcDegitalDisplay()
		{
			InitializeComponent();
			
			this.ForegroundColor = new SolidColorBrush(Color.FromArgb(255, 255, 209, 85));
			this.BackgroundColor = new SolidColorBrush(Color.FromArgb(200,159,139,13));
		}

		private static void Callback(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			UcDegitalDisplay ud = d as UcDegitalDisplay;
			int number = (int)e.NewValue;
			switch (number)
			{
				case 0:
				{
					ud.R00.Fill = ud.BackgroundColor;
					ud.R01.Fill = ud.ForegroundColor;
					ud.R02.Fill = ud.ForegroundColor;
					ud.R03.Fill = ud.ForegroundColor;
					ud.R04.Fill = ud.BackgroundColor;

					ud.R05.Fill = ud.ForegroundColor;
					ud.R06.Fill = ud.BackgroundColor;
					ud.R07.Fill = ud.BackgroundColor;
					ud.R08.Fill = ud.BackgroundColor;
					ud.R09.Fill = ud.ForegroundColor;

					ud.R10.Fill = ud.ForegroundColor;
					ud.R11.Fill = ud.BackgroundColor;
					ud.R12.Fill = ud.BackgroundColor;
					ud.R13.Fill = ud.ForegroundColor;
					ud.R14.Fill = ud.ForegroundColor;

					ud.R15.Fill = ud.ForegroundColor;
					ud.R16.Fill = ud.BackgroundColor;
					ud.R17.Fill = ud.ForegroundColor;
					ud.R18.Fill = ud.BackgroundColor;
					ud.R19.Fill = ud.ForegroundColor;

					ud.R20.Fill = ud.ForegroundColor;
					ud.R21.Fill = ud.ForegroundColor;
					ud.R22.Fill = ud.BackgroundColor;
					ud.R23.Fill = ud.BackgroundColor;
					ud.R24.Fill = ud.ForegroundColor;

					ud.R25.Fill = ud.ForegroundColor;
					ud.R26.Fill = ud.BackgroundColor;
					ud.R27.Fill = ud.BackgroundColor;
					ud.R28.Fill = ud.BackgroundColor;
					ud.R29.Fill = ud.ForegroundColor;

					ud.R30.Fill = ud.BackgroundColor;
					ud.R31.Fill = ud.ForegroundColor;
					ud.R32.Fill = ud.ForegroundColor;
					ud.R33.Fill = ud.ForegroundColor;
					ud.R34.Fill = ud.BackgroundColor;
					break;
				}
				case 1:
				{
					ud.R00.Fill = ud.BackgroundColor;
					ud.R01.Fill = ud.BackgroundColor;
					ud.R02.Fill = ud.ForegroundColor;
					ud.R03.Fill = ud.BackgroundColor;
					ud.R04.Fill = ud.BackgroundColor;

					ud.R05.Fill = ud.BackgroundColor;
					ud.R06.Fill = ud.ForegroundColor;
					ud.R07.Fill = ud.ForegroundColor;
					ud.R08.Fill = ud.BackgroundColor;
					ud.R09.Fill = ud.BackgroundColor;

					ud.R10.Fill = ud.BackgroundColor;
					ud.R11.Fill = ud.BackgroundColor;
					ud.R12.Fill = ud.ForegroundColor;
					ud.R13.Fill = ud.BackgroundColor;
					ud.R14.Fill = ud.BackgroundColor;

					ud.R15.Fill = ud.BackgroundColor;
					ud.R16.Fill = ud.BackgroundColor;
					ud.R17.Fill = ud.ForegroundColor;
					ud.R18.Fill = ud.BackgroundColor;
					ud.R19.Fill = ud.BackgroundColor;

					ud.R20.Fill = ud.BackgroundColor;
					ud.R21.Fill = ud.BackgroundColor;
					ud.R22.Fill = ud.ForegroundColor;
					ud.R23.Fill = ud.BackgroundColor;
					ud.R24.Fill = ud.BackgroundColor;

					ud.R25.Fill = ud.BackgroundColor;
					ud.R26.Fill = ud.BackgroundColor;
					ud.R27.Fill = ud.ForegroundColor;
					ud.R28.Fill = ud.BackgroundColor;
					ud.R29.Fill = ud.BackgroundColor;

					ud.R30.Fill = ud.BackgroundColor;
					ud.R31.Fill = ud.ForegroundColor;
					ud.R32.Fill = ud.ForegroundColor;
					ud.R33.Fill = ud.ForegroundColor;
					ud.R34.Fill = ud.BackgroundColor;
					break;
				}
				case 2:
				{
					ud.R00.Fill = ud.BackgroundColor;
					ud.R01.Fill = ud.ForegroundColor;
					ud.R02.Fill = ud.ForegroundColor;
					ud.R03.Fill = ud.ForegroundColor;
					ud.R04.Fill = ud.BackgroundColor;

					ud.R05.Fill = ud.ForegroundColor;
					ud.R06.Fill = ud.BackgroundColor;
					ud.R07.Fill = ud.BackgroundColor;
					ud.R08.Fill = ud.BackgroundColor;
					ud.R09.Fill = ud.ForegroundColor;

					ud.R10.Fill = ud.BackgroundColor;
					ud.R11.Fill = ud.BackgroundColor;
					ud.R12.Fill = ud.BackgroundColor;
					ud.R13.Fill = ud.BackgroundColor;
					ud.R14.Fill = ud.ForegroundColor;

					ud.R15.Fill = ud.BackgroundColor;
					ud.R16.Fill = ud.BackgroundColor;
					ud.R17.Fill = ud.BackgroundColor;
					ud.R18.Fill = ud.ForegroundColor;
					ud.R19.Fill = ud.BackgroundColor;

					ud.R20.Fill = ud.BackgroundColor;
					ud.R21.Fill = ud.BackgroundColor;
					ud.R22.Fill = ud.ForegroundColor;
					ud.R23.Fill = ud.BackgroundColor;
					ud.R24.Fill = ud.BackgroundColor;

					ud.R25.Fill = ud.BackgroundColor;
					ud.R26.Fill = ud.ForegroundColor;
					ud.R27.Fill = ud.BackgroundColor;
					ud.R28.Fill = ud.BackgroundColor;
					ud.R29.Fill = ud.BackgroundColor;

					ud.R30.Fill = ud.ForegroundColor;
					ud.R31.Fill = ud.ForegroundColor;
					ud.R32.Fill = ud.ForegroundColor;
					ud.R33.Fill = ud.ForegroundColor;
					ud.R34.Fill = ud.ForegroundColor;
					break;
				}
				case 3:
				{
					ud.R00.Fill = ud.ForegroundColor;
					ud.R01.Fill = ud.ForegroundColor;
					ud.R02.Fill = ud.ForegroundColor;
					ud.R03.Fill = ud.ForegroundColor;
					ud.R04.Fill = ud.ForegroundColor;

					ud.R05.Fill = ud.BackgroundColor;
					ud.R06.Fill = ud.BackgroundColor;
					ud.R07.Fill = ud.BackgroundColor;
					ud.R08.Fill = ud.ForegroundColor;
					ud.R09.Fill = ud.BackgroundColor;

					ud.R10.Fill = ud.BackgroundColor;
					ud.R11.Fill = ud.BackgroundColor;
					ud.R12.Fill = ud.ForegroundColor;
					ud.R13.Fill = ud.BackgroundColor;
					ud.R14.Fill = ud.BackgroundColor;

					ud.R15.Fill = ud.BackgroundColor;
					ud.R16.Fill = ud.BackgroundColor;
					ud.R17.Fill = ud.BackgroundColor;
					ud.R18.Fill = ud.ForegroundColor;
					ud.R19.Fill = ud.BackgroundColor;

					ud.R20.Fill = ud.BackgroundColor;
					ud.R21.Fill = ud.BackgroundColor;
					ud.R22.Fill = ud.BackgroundColor;
					ud.R23.Fill = ud.BackgroundColor;
					ud.R24.Fill = ud.ForegroundColor;

					ud.R25.Fill = ud.ForegroundColor;
					ud.R26.Fill = ud.BackgroundColor;
					ud.R27.Fill = ud.BackgroundColor;
					ud.R28.Fill = ud.BackgroundColor;
					ud.R29.Fill = ud.ForegroundColor;

					ud.R30.Fill = ud.BackgroundColor;
					ud.R31.Fill = ud.ForegroundColor;
					ud.R32.Fill = ud.ForegroundColor;
					ud.R33.Fill = ud.ForegroundColor;
					ud.R34.Fill = ud.BackgroundColor;
					break;
				}
				case 4:
				{
					ud.R00.Fill = ud.BackgroundColor;
					ud.R01.Fill = ud.BackgroundColor;
					ud.R02.Fill = ud.BackgroundColor;
					ud.R03.Fill = ud.ForegroundColor;
					ud.R04.Fill = ud.BackgroundColor;

					ud.R05.Fill = ud.BackgroundColor;
					ud.R06.Fill = ud.BackgroundColor;
					ud.R07.Fill = ud.ForegroundColor;
					ud.R08.Fill = ud.ForegroundColor;
					ud.R09.Fill = ud.BackgroundColor;

					ud.R10.Fill = ud.BackgroundColor;
					ud.R11.Fill = ud.ForegroundColor;
					ud.R12.Fill = ud.BackgroundColor;
					ud.R13.Fill = ud.ForegroundColor;
					ud.R14.Fill = ud.BackgroundColor;

					ud.R15.Fill = ud.ForegroundColor;
					ud.R16.Fill = ud.BackgroundColor;
					ud.R17.Fill = ud.BackgroundColor;
					ud.R18.Fill = ud.ForegroundColor;
					ud.R19.Fill = ud.BackgroundColor;

					ud.R20.Fill = ud.ForegroundColor;
					ud.R21.Fill = ud.ForegroundColor;
					ud.R22.Fill = ud.ForegroundColor;
					ud.R23.Fill = ud.ForegroundColor;
					ud.R24.Fill = ud.ForegroundColor;

					ud.R25.Fill = ud.BackgroundColor;
					ud.R26.Fill = ud.BackgroundColor;
					ud.R27.Fill = ud.BackgroundColor;
					ud.R28.Fill = ud.ForegroundColor;
					ud.R29.Fill = ud.BackgroundColor;

					ud.R30.Fill = ud.BackgroundColor;
					ud.R31.Fill = ud.BackgroundColor;
					ud.R32.Fill = ud.BackgroundColor;
					ud.R33.Fill = ud.ForegroundColor;
					ud.R34.Fill = ud.BackgroundColor;
					break;
				}
				case 5:
				{
					ud.R00.Fill = ud.ForegroundColor;
					ud.R01.Fill = ud.ForegroundColor;
					ud.R02.Fill = ud.ForegroundColor;
					ud.R03.Fill = ud.ForegroundColor;
					ud.R04.Fill = ud.ForegroundColor;

					ud.R05.Fill = ud.ForegroundColor;
					ud.R06.Fill = ud.BackgroundColor;
					ud.R07.Fill = ud.BackgroundColor;
					ud.R08.Fill = ud.BackgroundColor;
					ud.R09.Fill = ud.BackgroundColor;

					ud.R10.Fill = ud.ForegroundColor;
					ud.R11.Fill = ud.ForegroundColor;
					ud.R12.Fill = ud.ForegroundColor;
					ud.R13.Fill = ud.ForegroundColor;
					ud.R14.Fill = ud.BackgroundColor;

					ud.R15.Fill = ud.BackgroundColor;
					ud.R16.Fill = ud.BackgroundColor;
					ud.R17.Fill = ud.BackgroundColor;
					ud.R18.Fill = ud.BackgroundColor;
					ud.R19.Fill = ud.ForegroundColor;

					ud.R20.Fill = ud.BackgroundColor;
					ud.R21.Fill = ud.BackgroundColor;
					ud.R22.Fill = ud.BackgroundColor;
					ud.R23.Fill = ud.BackgroundColor;
					ud.R24.Fill = ud.ForegroundColor;

					ud.R25.Fill = ud.ForegroundColor;
					ud.R26.Fill = ud.BackgroundColor;
					ud.R27.Fill = ud.BackgroundColor;
					ud.R28.Fill = ud.BackgroundColor;
					ud.R29.Fill = ud.ForegroundColor;

					ud.R30.Fill = ud.BackgroundColor;
					ud.R31.Fill = ud.ForegroundColor;
					ud.R32.Fill = ud.ForegroundColor;
					ud.R33.Fill = ud.ForegroundColor;
					ud.R34.Fill = ud.BackgroundColor;
					break;
				}
				case 6:
				{
					ud.R00.Fill = ud.BackgroundColor;
					ud.R01.Fill = ud.BackgroundColor;
					ud.R02.Fill = ud.ForegroundColor;
					ud.R03.Fill = ud.ForegroundColor;
					ud.R04.Fill = ud.BackgroundColor;

					ud.R05.Fill = ud.BackgroundColor;
					ud.R06.Fill = ud.ForegroundColor;
					ud.R07.Fill = ud.BackgroundColor;
					ud.R08.Fill = ud.BackgroundColor;
					ud.R09.Fill = ud.BackgroundColor;

					ud.R10.Fill = ud.ForegroundColor;
					ud.R11.Fill = ud.BackgroundColor;
					ud.R12.Fill = ud.BackgroundColor;
					ud.R13.Fill = ud.BackgroundColor;
					ud.R14.Fill = ud.BackgroundColor;

					ud.R15.Fill = ud.ForegroundColor;
					ud.R16.Fill = ud.ForegroundColor;
					ud.R17.Fill = ud.ForegroundColor;
					ud.R18.Fill = ud.ForegroundColor;
					ud.R19.Fill = ud.BackgroundColor;

					ud.R20.Fill = ud.ForegroundColor;
					ud.R21.Fill = ud.BackgroundColor;
					ud.R22.Fill = ud.BackgroundColor;
					ud.R23.Fill = ud.BackgroundColor;
					ud.R24.Fill = ud.ForegroundColor;

					ud.R25.Fill = ud.ForegroundColor;
					ud.R26.Fill = ud.BackgroundColor;
					ud.R27.Fill = ud.BackgroundColor;
					ud.R28.Fill = ud.BackgroundColor;
					ud.R29.Fill = ud.ForegroundColor;

					ud.R30.Fill = ud.BackgroundColor;
					ud.R31.Fill = ud.ForegroundColor;
					ud.R32.Fill = ud.ForegroundColor;
					ud.R33.Fill = ud.ForegroundColor;
					ud.R34.Fill = ud.BackgroundColor;
					break;
				}
				case 7:
				{
					ud.R00.Fill = ud.ForegroundColor;
					ud.R01.Fill = ud.ForegroundColor;
					ud.R02.Fill = ud.ForegroundColor;
					ud.R03.Fill = ud.ForegroundColor;
					ud.R04.Fill = ud.ForegroundColor;

					ud.R05.Fill = ud.BackgroundColor;
					ud.R06.Fill = ud.BackgroundColor;
					ud.R07.Fill = ud.BackgroundColor;
					ud.R08.Fill = ud.BackgroundColor;
					ud.R09.Fill = ud.ForegroundColor;

					ud.R10.Fill = ud.BackgroundColor;
					ud.R11.Fill = ud.BackgroundColor;
					ud.R12.Fill = ud.BackgroundColor;
					ud.R13.Fill = ud.ForegroundColor;
					ud.R14.Fill = ud.BackgroundColor;

					ud.R15.Fill = ud.BackgroundColor;
					ud.R16.Fill = ud.BackgroundColor;
					ud.R17.Fill = ud.ForegroundColor;
					ud.R18.Fill = ud.BackgroundColor;
					ud.R19.Fill = ud.BackgroundColor;

					ud.R20.Fill = ud.BackgroundColor;
					ud.R21.Fill = ud.ForegroundColor;
					ud.R22.Fill = ud.BackgroundColor;
					ud.R23.Fill = ud.BackgroundColor;
					ud.R24.Fill = ud.BackgroundColor;

					ud.R25.Fill = ud.BackgroundColor;
					ud.R26.Fill = ud.ForegroundColor;
					ud.R27.Fill = ud.BackgroundColor;
					ud.R28.Fill = ud.BackgroundColor;
					ud.R29.Fill = ud.BackgroundColor;

					ud.R30.Fill = ud.BackgroundColor;
					ud.R31.Fill = ud.ForegroundColor;
					ud.R32.Fill = ud.BackgroundColor;
					ud.R33.Fill = ud.BackgroundColor;
					ud.R34.Fill = ud.BackgroundColor;
					break;
				}
				case 8:
				{
					ud.R00.Fill = ud.BackgroundColor;
					ud.R01.Fill = ud.ForegroundColor;
					ud.R02.Fill = ud.ForegroundColor;
					ud.R03.Fill = ud.ForegroundColor;
					ud.R04.Fill = ud.BackgroundColor;

					ud.R05.Fill = ud.ForegroundColor;
					ud.R06.Fill = ud.BackgroundColor;
					ud.R07.Fill = ud.BackgroundColor;
					ud.R08.Fill = ud.BackgroundColor;
					ud.R09.Fill = ud.ForegroundColor;

					ud.R10.Fill = ud.ForegroundColor;
					ud.R11.Fill = ud.BackgroundColor;
					ud.R12.Fill = ud.BackgroundColor;
					ud.R13.Fill = ud.BackgroundColor;
					ud.R14.Fill = ud.ForegroundColor;

					ud.R15.Fill = ud.BackgroundColor;
					ud.R16.Fill = ud.ForegroundColor;
					ud.R17.Fill = ud.ForegroundColor;
					ud.R18.Fill = ud.ForegroundColor;
					ud.R19.Fill = ud.BackgroundColor;

					ud.R20.Fill = ud.ForegroundColor;
					ud.R21.Fill = ud.BackgroundColor;
					ud.R22.Fill = ud.BackgroundColor;
					ud.R23.Fill = ud.BackgroundColor;
					ud.R24.Fill = ud.ForegroundColor;

					ud.R25.Fill = ud.ForegroundColor;
					ud.R26.Fill = ud.BackgroundColor;
					ud.R27.Fill = ud.BackgroundColor;
					ud.R28.Fill = ud.BackgroundColor;
					ud.R29.Fill = ud.ForegroundColor;

					ud.R30.Fill = ud.BackgroundColor;
					ud.R31.Fill = ud.ForegroundColor;
					ud.R32.Fill = ud.ForegroundColor;
					ud.R33.Fill = ud.ForegroundColor;
					ud.R34.Fill = ud.BackgroundColor;
					break;
				}
				case 9:
				{
					ud.R00.Fill = ud.BackgroundColor;
					ud.R01.Fill = ud.ForegroundColor;
					ud.R02.Fill = ud.ForegroundColor;
					ud.R03.Fill = ud.ForegroundColor;
					ud.R04.Fill = ud.BackgroundColor;

					ud.R05.Fill = ud.ForegroundColor;
					ud.R06.Fill = ud.BackgroundColor;
					ud.R07.Fill = ud.BackgroundColor;
					ud.R08.Fill = ud.BackgroundColor;
					ud.R09.Fill = ud.ForegroundColor;

					ud.R10.Fill = ud.ForegroundColor;
					ud.R11.Fill = ud.BackgroundColor;
					ud.R12.Fill = ud.BackgroundColor;
					ud.R13.Fill = ud.BackgroundColor;
					ud.R14.Fill = ud.ForegroundColor;

					ud.R15.Fill = ud.BackgroundColor;
					ud.R16.Fill = ud.ForegroundColor;
					ud.R17.Fill = ud.ForegroundColor;
					ud.R18.Fill = ud.ForegroundColor;
					ud.R19.Fill = ud.ForegroundColor;

					ud.R20.Fill = ud.BackgroundColor;
					ud.R21.Fill = ud.BackgroundColor;
					ud.R22.Fill = ud.BackgroundColor;
					ud.R23.Fill = ud.BackgroundColor;
					ud.R24.Fill = ud.ForegroundColor;

					ud.R25.Fill = ud.BackgroundColor;
					ud.R26.Fill = ud.BackgroundColor;
					ud.R27.Fill = ud.BackgroundColor;
					ud.R28.Fill = ud.ForegroundColor;
					ud.R29.Fill = ud.BackgroundColor;

					ud.R30.Fill = ud.BackgroundColor;
					ud.R31.Fill = ud.ForegroundColor;
					ud.R32.Fill = ud.ForegroundColor;
					ud.R33.Fill = ud.BackgroundColor;
					ud.R34.Fill = ud.BackgroundColor;
					break;
				}
				case 10:
				{
					ud.R00.Fill = ud.BackgroundColor;
					ud.R01.Fill = ud.BackgroundColor;
					ud.R02.Fill = ud.BackgroundColor;
					ud.R03.Fill = ud.BackgroundColor;
					ud.R04.Fill = ud.BackgroundColor;

					ud.R05.Fill = ud.BackgroundColor;
					ud.R06.Fill = ud.BackgroundColor;
					ud.R07.Fill = ud.BackgroundColor;
					ud.R08.Fill = ud.BackgroundColor;
					ud.R09.Fill = ud.BackgroundColor;

					ud.R10.Fill = ud.BackgroundColor;
					ud.R11.Fill = ud.BackgroundColor;
					ud.R12.Fill = ud.BackgroundColor;
					ud.R13.Fill = ud.BackgroundColor;
					ud.R14.Fill = ud.BackgroundColor;

					ud.R15.Fill = ud.BackgroundColor;
					ud.R16.Fill = ud.BackgroundColor;
					ud.R17.Fill = ud.BackgroundColor;
					ud.R18.Fill = ud.BackgroundColor;
					ud.R19.Fill = ud.BackgroundColor;

					ud.R20.Fill = ud.ForegroundColor;
					ud.R21.Fill = ud.ForegroundColor;
					ud.R22.Fill = ud.ForegroundColor;
					ud.R23.Fill = ud.ForegroundColor;
					ud.R24.Fill = ud.ForegroundColor;

					ud.R25.Fill = ud.BackgroundColor;
					ud.R26.Fill = ud.BackgroundColor;
					ud.R27.Fill = ud.BackgroundColor;
					ud.R28.Fill = ud.BackgroundColor;
					ud.R29.Fill = ud.BackgroundColor;

					ud.R30.Fill = ud.BackgroundColor;
					ud.R31.Fill = ud.BackgroundColor;
					ud.R32.Fill = ud.BackgroundColor;
					ud.R33.Fill = ud.BackgroundColor;
					ud.R34.Fill = ud.BackgroundColor;
					break;
				}
				case 11:
				{
					ud.R00.Fill = ud.BackgroundColor;
					ud.R01.Fill = ud.BackgroundColor;
					ud.R02.Fill = ud.BackgroundColor;
					ud.R03.Fill = ud.BackgroundColor;
					ud.R04.Fill = ud.BackgroundColor;

					ud.R05.Fill = ud.BackgroundColor;
					ud.R06.Fill = ud.ForegroundColor;
					ud.R07.Fill = ud.ForegroundColor;
					ud.R08.Fill = ud.BackgroundColor;
					ud.R09.Fill = ud.BackgroundColor;

					ud.R10.Fill = ud.BackgroundColor;
					ud.R11.Fill = ud.ForegroundColor;
					ud.R12.Fill = ud.ForegroundColor;
					ud.R13.Fill = ud.BackgroundColor;
					ud.R14.Fill = ud.BackgroundColor;

					ud.R15.Fill = ud.BackgroundColor;
					ud.R16.Fill = ud.BackgroundColor;
					ud.R17.Fill = ud.BackgroundColor;
					ud.R18.Fill = ud.BackgroundColor;
					ud.R19.Fill = ud.BackgroundColor;

					ud.R20.Fill = ud.BackgroundColor;
					ud.R21.Fill = ud.ForegroundColor;
					ud.R22.Fill = ud.ForegroundColor;
					ud.R23.Fill = ud.BackgroundColor;
					ud.R24.Fill = ud.BackgroundColor;

					ud.R25.Fill = ud.BackgroundColor;
					ud.R26.Fill = ud.ForegroundColor;
					ud.R27.Fill = ud.ForegroundColor;
					ud.R28.Fill = ud.BackgroundColor;
					ud.R29.Fill = ud.BackgroundColor;

					ud.R30.Fill = ud.BackgroundColor;
					ud.R31.Fill = ud.BackgroundColor;
					ud.R32.Fill = ud.BackgroundColor;
					ud.R33.Fill = ud.BackgroundColor;
					ud.R34.Fill = ud.BackgroundColor;
					break;
				}
				case 12:
				{
					ud.R00.Fill = ud.BackgroundColor;
					ud.R01.Fill = ud.BackgroundColor;
					ud.R02.Fill = ud.BackgroundColor;
					ud.R03.Fill = ud.BackgroundColor;
					ud.R04.Fill = ud.BackgroundColor;

					ud.R05.Fill = ud.BackgroundColor;
					ud.R06.Fill = ud.BackgroundColor;
					ud.R07.Fill = ud.BackgroundColor;
					ud.R08.Fill = ud.BackgroundColor;
					ud.R09.Fill = ud.BackgroundColor;

					ud.R10.Fill = ud.BackgroundColor;
					ud.R11.Fill = ud.BackgroundColor;
					ud.R12.Fill = ud.BackgroundColor;
					ud.R13.Fill = ud.BackgroundColor;
					ud.R14.Fill = ud.BackgroundColor;

					ud.R15.Fill = ud.BackgroundColor;
					ud.R16.Fill = ud.BackgroundColor;
					ud.R17.Fill = ud.BackgroundColor;
					ud.R18.Fill = ud.BackgroundColor;
					ud.R19.Fill = ud.BackgroundColor;

					ud.R20.Fill = ud.BackgroundColor;
					ud.R21.Fill = ud.BackgroundColor;
					ud.R22.Fill = ud.BackgroundColor;
					ud.R23.Fill = ud.BackgroundColor;
					ud.R24.Fill = ud.BackgroundColor;

					ud.R25.Fill = ud.BackgroundColor;
					ud.R26.Fill = ud.ForegroundColor;
					ud.R27.Fill = ud.ForegroundColor;
					ud.R28.Fill = ud.BackgroundColor;
					ud.R29.Fill = ud.BackgroundColor;

					ud.R30.Fill = ud.BackgroundColor;
					ud.R31.Fill = ud.ForegroundColor;
					ud.R32.Fill = ud.ForegroundColor;
					ud.R33.Fill = ud.BackgroundColor;
					ud.R34.Fill = ud.BackgroundColor;
					break;
				}
				default:
				{
					ud.R00.Fill = ud.BackgroundColor;
					ud.R01.Fill = ud.BackgroundColor;
					ud.R02.Fill = ud.BackgroundColor;
					ud.R03.Fill = ud.BackgroundColor;
					ud.R04.Fill = ud.BackgroundColor;

					ud.R05.Fill = ud.BackgroundColor;
					ud.R06.Fill = ud.BackgroundColor;
					ud.R07.Fill = ud.BackgroundColor;
					ud.R08.Fill = ud.BackgroundColor;
					ud.R09.Fill = ud.BackgroundColor;

					ud.R10.Fill = ud.BackgroundColor;
					ud.R11.Fill = ud.BackgroundColor;
					ud.R12.Fill = ud.BackgroundColor;
					ud.R13.Fill = ud.BackgroundColor;
					ud.R14.Fill = ud.BackgroundColor;

					ud.R15.Fill = ud.BackgroundColor;
					ud.R16.Fill = ud.BackgroundColor;
					ud.R17.Fill = ud.BackgroundColor;
					ud.R18.Fill = ud.BackgroundColor;
					ud.R19.Fill = ud.BackgroundColor;

					ud.R20.Fill = ud.BackgroundColor;
					ud.R21.Fill = ud.BackgroundColor;
					ud.R22.Fill = ud.BackgroundColor;
					ud.R23.Fill = ud.BackgroundColor;
					ud.R24.Fill = ud.BackgroundColor;

					ud.R25.Fill = ud.BackgroundColor;
					ud.R26.Fill = ud.BackgroundColor;
					ud.R27.Fill = ud.BackgroundColor;
					ud.R28.Fill = ud.BackgroundColor;
					ud.R29.Fill = ud.BackgroundColor;

					ud.R30.Fill = ud.BackgroundColor;
					ud.R31.Fill = ud.BackgroundColor;
					ud.R32.Fill = ud.BackgroundColor;
					ud.R33.Fill = ud.BackgroundColor;
					ud.R34.Fill = ud.BackgroundColor;
					break;
				}
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
		public void NotifyPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}