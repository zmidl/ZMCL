   M S B A M L   `   `   `  ���� ?  ;ZMCL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:ZMCL.MyControl.WhiteGoldZMCL.MyControl.WhiteGold  (    "ZMCL.MyControl.WhiteGold.WG_Slider   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     8local&clr-namespace:ZMCL.MyControl.WhiteGold       � 	Resources   !  SliderThumb.Static.Foreground �� Color $  SliderThumb.MouseOver.Background   SliderThumb.MouseOver.Border " SliderThumb.Pressed.Background  SliderThumb.Pressed.Border # SliderThumb.Disabled.Background  SliderThumb.Disabled.Border ! SliderThumb.Static.Background  SliderThumb.Static.Border 	 SliderThumbHorizontalTop �� 
TargetType � UseLayoutRounding F�Name �� Stretch J� SnapsToDevicePixels �� Triggers P� Property	 P� Value
 �� 
TargetName �� Value �� Property 
 SliderThumbHorizontalBottom (� Stretch �� EndPoint �� 
StartPoint � Color � Offset  SliderThumb.Track.Border   SliderThumb.Track.Background  RepeatButtonTransparent �� 
TargetType �� RadiusX �� RadiusY J� Effect3  -System.Windows.Media.Effects.DropShadowEffect   Color   ShadowDepth   
BlurRadius  RepeatButtonTransparent2   SliderThumbHorizontalDefault   	Direction  SliderHorizontal ��Name � RowDefinitions m�Name m� Fill m� 	Placement �� CornerRadius  ��Name! ��Name
" �� Top# �� Left$ K� ZIndex% �� ElementName& �� Path' �� Right( ]�Name) ]� DecreaseRepeatButton* �� DecreaseLarge+ ]� IncreaseRepeatButton, �� IncreaseLarge- ]� Thumb. n�Name/ � OverridesDefaultStyle  SliderThumbVerticalLeft  SliderThumbVerticalRight  SliderThumbVerticalDefault  SliderVertical0 � ColumnDefinitions��%�!  &	        &	      &	 *     &	 ?     &	 T     &	 i     &	 ~     &	 �     &	 �     &		 �     7  7  7  7  7  7  7  7  &	
 �    7  7  7  7  7  7  &	 _    &	 t    &	 �    &	 �    &	     7  7  7  7  7  7  &	 �    7  7  7  7 	 7 
 &	 ~    7  7  7  7  7  7  7  7  &	 r    7  7  7  7  7  7  7  7  &	 ^    7  7  7  7  7  7  7  7  &	 �    7  7  7  7  7  7  7  �� $ 	#FFE5E5E5���� $ 	#FFDCECFC���� $ 	#FF7Eb4EA���� $ 	#FFDAECFC���� $ 	#FF569DE5���� $ 	#FFF0F0F0���� $ 	#FFD9D9D9���� $ 	#FFF0F0F0���� $ 	#FFACACAC���� " n�.R�� $��Center=� . $��Center=�.+�F� $
 grip�������    ��[ �    ��[ `�S `�S �`�S     �ا ��[ �ا ��[ ��ا ��[ �ا ���ا ����ا �������    ����[ ��[ 	8��  $
 Fill=� . 8�� $��1�� . $��Center=� P�  �@J�IsMouseOver	 . . ��� $

 grip��8   � ���� $

 grip��8   � ��P�  �@n�
IsDragging	 . . ��� $

 grip��8   � ���� $

 grip��8   � ��P�  � {�	 .  . ��� $

 grip��8   � ���� $

 grip��8   � ���� " n�.R�� $��Center=� . $��Center=�.+�(� $
 Fill=�$��20��.��F� $
 grip��O�������  ��� �� ������������J]� �� ��׀��  ��� �� ��	$��5��$��70��$	��120������ $ 0.5,1&�$ 0.5,0&�.��� $ 	#FFA26C00��$ 1Q�� $ 	#FFFFE8BA������ $ 0.5,1&�$ 0.5,0&�.��� $ White��$ 0Q�� $ 	#FFC2C2C2��$ 1Q� P�  �@J�IsMouseOver	 . . ��� $

 grip��8    � ���� $

 grip��8   � ��P�  �@n�
IsDragging	 . . ��� $

 grip��8   � ���� $

 grip��8   � ��P�  � {�	 .  . ��� $

 grip��8   � ���� $

 grip��8   � ���� $ 	#FFD6D6D6���� $ 	#FFE7EAEA���� " ��.���  �@�OverridesDefaultStyle . ��  � ��
 ���� ��  � |� .  ��  � �� .  ��  � �� �� " ��.R��� $��24,-45.5,-40,-1q�$��22��#��z��$ 10��$ 10��   $
 Gray��$ 3Q�$ 3Q����� $ 0.5,1&�$ 0.5,0&�.��� $ 	#FFCFAA00��� $ 	#FFCE8900��$ 1Q��� " ��.���  �@�OverridesDefaultStyle . ��  � ��
 ���� ��  � |� .  ��  � �� .  ��  � �� �� " ��.R��� $��-40,-46,24,0q�$ 10��$ 10��$��22��#��z������ $ 0.5,1&�$ 0.5,0&�.��� $ 	#FFADADAD��$ 0Q�� $ 	#FFDACDB5��$ 1Q��� " n�.R�� $��Center=� . $��Center=�.+�(� $
 Fill=�$	��100��.��F� $
 grip��O�������  ��� �� ������������J]� �� ��׀��  ��� �� ��	$��5��$��70��$	��120��   $	 270Q�$ 15Q�$
 Gray������ $ 0.5,1&�$ 0.5,0&�.��� $ 	#FFA26C00��$ 1Q�� $ 	#FFE8C275������ $ 0.5,1&�$ 0.5,0&�.��� $ White��$ 0Q�� $ 	#FFC2C2C2��$ 1Q�A� $��26��$��30��$��	0,-30,0,0q�$��2������ $ 0.5,1&�$ 0.5,0&�.��� $ 	#FF4878F7��$ 1Q�� $ 	#FF0044F9������ $ 0.5,1&�$ 0.5,0&�.��� $ 	#FFEEDEB4��$ 1Q�� $ 	#FF876200�� P�  �@J�IsMouseOver	 . . ��� $

 grip��8    � ���� $

 grip��8   � ��P�  �@n�
IsDragging	 . . ��� $

 grip��8   � ���� $

 grip��8   � ��P�  � {�	 .  . ��� $

 grip��8   � ���� $

 grip��8   � ���� " ��.R��� $ border��#��z��#��z�� . ._�(� $
 Fill=�.��� ��Z�  �� $
��Auto ��� $
��Auto �#��z���� $
��Auto �.+�m� $ TopTick��# z��$��4��$��0,0,0,2q�$	 Top=�$��0��$y�	Collapsed=�m� $ 
BottomTick��
 �  ��$��4��$��
20,10,20,0q�$ Bottom=�$��2��$y�	Collapsed=��� $ TrackBackground��$��2q�$��11��$��0,-6,0,0q�$��1��$��center=�$	 5.5����Z� ��Z� ._��� $
��0,-1q�$	��500��$��Stretch=���Z� .+��� $  PART_SelectionRange��
�������$	��4.0��$y�Hidden=��� $! Canvas1��$��1��$	��5,5q���Z� .+��� $	��493��$��59��
�������$ 30��   $ 5Q�$ 5Q�$ 	#FFA2A2A2��$	 305Q�A� $��60��$��60��$��10������ $ 0.145,0.202&�$ 
2.36,2.272&�.��� $ Black��� $ White��$ 1Q�A� $��40��$��40��$" 10��$	# 9.5��$��10������ $ 0.737,0.877&�$ -0.177,-0.662&�.��� $ 	#FF757575��$ 0Q�� $ White��$ 1Q�� $	" 9.5��$$ 1��$
��Left=�$	��Top=�$# 30������ $% Canvas1��$& ActualWidth�.+��� $��0,0,60,0q�$
��0,10q�$��41������ $ 0.5,1&�$ 0.5,0&�.��� $ 	#FFBCBCBC��$ 0Q�� $ White��$ 1Q�� $" 0��$$ 1��$
��Left=�$	��Top=�$# 30������ $% Canvas1��$& ActualWidth�.+��� $��0,0,60,0q�$
��0,10q�$��60������ $ 0.5,1&�$ 0.5,0&�.��� $ 	#FFF2F2F2��$ 0Q�� $ 	#FFBCBCBC��$ 1Q�A� $��40��$��40��$" 10��$' 10��$��10������ $ 0.737,0.877&�$ -0.177,-0.662&�.��� $ 	#FF757575��$ 0Q�� $ White��$ 1Q�A� $��60��$��60��$' 0��$��10������ $ 0.145,0.202&�$ 
2.36,2.272&�.��� $ Black��� $ White��$ 1Q�]� $( 
PART_Track��$��1��$��0,10,0,0q�$$ 3��) �� #��Z* 8��  + �� #��Z, 8�� - n� $. Thumb��$��20,-4.5,20,0q�|�.  $��50��$	��100��/ . 8�� $��Center=� P�  �@��TickPlacement$	 TopLeft=�. ��� $
 TopTick�� � y�$ Visible=��� $
 Thumb��8   � ���� $
 TrackBackground�� � ��$ 5,2,5,0q�P�  �@��TickPlacement$	 BottomRight=�. ��� $
 
BottomTick�� � y�$ Visible=��� $
 Thumb��8   � ���� $
 TrackBackground�� � ��$ 5,0,5,2q�P�  �@��TickPlacement$
	 Both=�. ��� $
 TopTick�� � y�$ Visible=��� $
 
BottomTick�� � y�$ Visible=�P�  �@��IsSelectionRangeEnabled	 . . ��� $
 PART_SelectionRange�� � y�$ Visible=�P�  �@J�IsKeyboardFocused	 . . ��� $
 Thumb�� � ��
 ��  ��� " n�.R�� $��Center=� . $��Center=�.+�F� $
 grip���������[ �ا Ӏ�[ �ا `�S `�S �    `�S ��[ ��[ Ӏ�[     ����Ӏ�    ���ا ���ا Ӏ��ا ��[ �ا ��[ �ا 	8��  $
 Fill=�8��  P�  �@J�IsMouseOver	 . . ��� $

 grip��8   � ���� $

 grip��8   � ��P�  �@n�
IsDragging	 . . ��� $

 grip��8   � ���� $

 grip��8   � ��P�  � {�	 .  . ��� $

 grip��8   � ���� $

 grip��8   � ���� " n�.R�� $��Center=� . $��Center=�.+�F� $
 grip������� � �ا � � �ا ��`�S ��`�S Ӏ�`�S  �  � � �     �        �ا �ا �    �ا  � �ا  � �ا 	8��  $
 Fill=�8��  P�  �@J�IsMouseOver	 . . ��� $

 grip��8   � ���� $

 grip��8   � ��P�  �@n�
IsDragging	 . . ��� $

 grip��8   � ���� $

 grip��8   � ��P�  � {�	 .  . ��� $

 grip��8   � ���� $

 grip��8   � ���� " n�.R�� $��Center=� . $��Center=�.+�F� $
 grip��+���� �  � ѠI � ѠI�y� � � �y� 	8��  $
 Fill=�8��  P�  �@J�IsMouseOver	 . . ��� $

 grip��8   � ���� $

 grip��8   � ��P�  �@n�
IsDragging	 . . ��� $

 grip��8   � ���� $

 grip��8   � ��P�  � {�	 .  . ��� $

 grip��8   � ���� $

 grip��8   � ���� " ��.R��� $ border��#��z��#��z��#��z�� . ._�� 0 �� $
��Auto ��� #��z��$
��Auto ��� $
��Auto �.+�m� $ TopTick��$��0��# z��$��0,0,2,0q�$
 Left=�$y�	Collapsed=�$��4��m� $ 
BottomTick��$��2��# z��$��2,0,0,0q�$ Right=�$y�	Collapsed=�$��4���� $ TrackBackground��8��  $��1q�8�� $��1��$��center=�$	��0,5q�$	��4.0��._��� $��-1,-6q�.+��� $  PART_SelectionRange��#��� ��$y�Hidden=�$	��4.0��]� $( 
PART_Track��$��1��) �� #��Z* 8�� + �� #��Z, 8�� - n� $. Thumb��|�.  $��20��/ . 8�� $	��Top=�$��18�� P�  �@��TickPlacement$	 TopLeft=�. ��� $
 TopTick�� � y�$ Visible=��� $
 Thumb��8   � ���� $
 TrackBackground�� � ��$ 2,5,0,5q�P�  �@��TickPlacement$	 BottomRight=�. ��� $
 
BottomTick�� � y�$ Visible=��� $
 Thumb��8   � ���� $
 TrackBackground�� � ��$ 0,5,2,5q�P�  �@��TickPlacement$
	 Both=�. ��� $
 TopTick�� � y�$ Visible=��� $
 
BottomTick�� � y�$ Visible=�P�  �@��IsSelectionRangeEnabled	 . . ��� $
 PART_SelectionRange�� � y�$ Visible=�P�  �@J�IsKeyboardFocused	 . . ��� $
 Thumb�� � ��
 ��  ����� " ��.���  �@�FocusVisualStyle Z� ��  �@��IsPressAndHoldEnabled .  ��  � ��
 ���� ��  � ��
 ���� ��  � ��# [  ��  � ��# [ 1 �� Triggers1 P�  �@��Orientation$	 Vertical=�. ���  � ��# [ 