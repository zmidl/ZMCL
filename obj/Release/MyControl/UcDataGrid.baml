   M S B A M L   `   `   `  ����   ZMCL    ZMCL.MyControl.UcDataGrid   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -   &   System.Windows.Controls.DataGrid   Name$  	DataGrid1������  �� 
TargetType"  .���  �� Property � �� �� Value$	 Top=���  �@ CanUserSortColumns .  ��  �@ 
IsReadOnly . ��  �@ CanUserResizeColumns .  ��  �@ CanUserResizeRows .  ��  �@ SelectionMode$ Single=���  �@ CanUserReorderColumns .  ��  �@��AlternationCount$ 2����  �@ RowHeaderWidth$ 0Q���  �@ CanUserAddRows . ��  � �� �	#FFFBF8EE��  �@ CanUserResizeColumns .  ��  � �� �#d6c79b��  � ��$ 2q���   �@ HorizontalGridLinesBrush ��  �� Color$ #d6c79b����  �@ VerticalGridLinesBrush �� $ #d6c79b��   ColumnHeaderStyle �� =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  .���  �@J�SnapsToDevicePixels . ��  � ��$ 0����  � ��$ 20����  � �� �#323433��  � ��$ 9(���  �@�Cursor$
 Hand����  � �� ��  �� 
TargetType"  .R���  ��Name$ BackgroundBorder��$��0,1,0,1q����#e6dbba$
��Auto��._�� ����  �� EndPoint$ 0.5,1&�	 �� 
StartPoint$	 0.5,0&�.��� 
 � Color$
 	#FFF6F0D4�� � Offset$ 1Q�� $
 	#FFE6D1BB��$ 0Q� � ColumnDefinitions �� $��* �.+�F�  F�Name$ 	SortArrow��$y�	Collapsed=�"����        �@B     � � @B 	 �� Stretch$
 Fill=�$��2��$��8��$��6��
�������$��0,0,50,0q�$��Center=� J� RenderTransformOrigin$	 1,1&��� $��1�����#d6c79b$��Right=�$��1����  �� Padding$ 5,0,5,0q�$��Center=�$��Center=�$��12(����� $ 0.5,1&�$	 0.5,0&�.��� $
 	#FFFB0202��$ 0.208Q�� $
 	#FF6C0101��$ 1Q�� $
 	#FFF7F7F7��$ 0Q��� $��0,0,0,0q�$��Center=�$��Center=���  � ��$ 25��   	CellStyle �� *  $System.Windows.Controls.DataGridCell"  .���  � �� �� "  .R���  �� TextAlignment$ Center=�$��Center=���  �� Triggers P�  P� Property �@ 
IsSelected P� Value .    RowStyle �� )  #System.Windows.Controls.DataGridRow"  .���  � �� �#F2F2F2��  � ��$ 20����  � ��
 �   � P�  �@ AlternationIndex$ 0��. ���  � �� �� $ 0.5,1&�$	 0.5,0&�.��� $
 	#FFF9EFDA��$ 1Q�� $
 	#FFE6DBBB��$ 0Q���  � �� �� $ 0.5,1&�$	 0.5,0&�.��� $
 	#FFC9A905��$ 0Q�� $
 	#FF7A4107��$ 1Q���  � ��$ 12(�P�  �@ AlternationIndex$ 1��. ���  � �� �� $ 0.5,1&�$	 0.5,0&�.��� $
 	#FFEBE7E7��$ 0Q�� $
 White��$ 1Q���  � �� �� $ 0.5,1&�$	 0.5,0&�.��� $
 	#FF037AFE��$ 0.151Q�� $
 	#FF07357A��$ 1Q�� $
 	#FFF7F7F7��$ 0Q���  � ��$ 12(�P�  �@J�IsMouseOver . . ���  � ��
 �������  � ��
 �����P�  �@ 
IsSelected . . ���  � �� �� $ 0.5,1&�$	 0.5,0&�.��� $
 	#FF5E9C05��$ 0Q�� $
 	#FF7FA845��$ 1Q���  � ��
 �   �