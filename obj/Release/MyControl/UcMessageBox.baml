   M S B A M L   `   `   `  ���� ?  ;ZMCL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ZMCL.MyControlZMCL.MyControl  !    ZMCL.MyControl.UcMessageBox   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     +myclr-namespace:ZMCL.MyControl     -     �Name$
  main�� � Title$ UMessageBox��$	��300��$	��520�� � WindowStyle$
 None=� � 
ResizeMode$ NoResize=� � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�$��0q�
������  � Triggers :�  :� RoutedEvent$ Window.Loaded��.[��� .���� -    g�Name$ sbOpShow��.��W� 	 �� 
TargetName$
	 main��
 �� TargetProperty$
 Opacity� W� From$ 0X�	 W� To$ 1X� g� Duration$ 0:0:0.5D� � 	Resources ��%    .��(�  (� Stretch$
 Fill=�.����  J� Opacity$	 100Q�$	��520��$	��360�� �� CornerRadius$ 8��$��2q����	#FFB9B9B9$��2,2,6,8q� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     Color$ 	#FF8D8D8D��   ShadowDepth$ 10Q�   Opacity$	 0.5Q�   
BlurRadius$ 10Q�   	Direction$	 300Q�����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ 	#FFF7F6E7�� � Offset$ 0Q�� $ 	#FFF3E4D4��$ 1Q�._��� $��Stretch=�.+��� 
 �� Top$ 0��$��50��$��Stretch=�$��0,0,0,2q����	#FFBFBEBE �� Left$ 14��$	��484��    ZMCL.MyControl.UcTextBlock  -     Name$ lblMsg��$
��Wrap=�$
��test��$ 39��$ 67������ $ 0.5,1&�$ 0.5,0&�.��� $ 	#FFD7C9A7��� $ White��$ 1Q�  -   $ lblTitle��$
��test��$	 265��$ 30��z�V� .~���  �� ScaleY$	 0.8Q�  �� ScaleX$	  0.5Q��� �� T� ! T� X$! -56.526Q�" T� Y$" -22.007Q�   ZMCL.MyControl.UcButton  -   #  Name$	# bn1��   ZMCL.MyControl.UcButton$   Click$$ 	bn1_Click��$��确认��$��40��$	��100��% �� Bottom$% 10��& �� Right$& 85��$	 227��$	 290������ $ 0.5,1&�$ 0.5,0&�.��� $ 	#FF787676��$ 0Q�� $ 	#FF835050��$ 1Q�