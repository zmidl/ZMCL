   M S B A M L   `   `   `  ����  ZMCL"    ZMCL.MyControl.UcGlassButton   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ��5      �� 5   
     �� 
TargetType"  ��6   .�5	      ��  �� Property �@�FocusVisualStyle �� Value 61   Z� �� 5
       �@J�Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$ Black��6'      	Direction$ 12Q�65      ShadowDepth$ 1Q�6D      Opacity$ 10Q�6T   5      �� 5       � �� 5      �� 5       �� 
StartPoint$	 0,0&�6*    �� EndPoint$	 1,1&�6;   .��5      � 	 � Color$	 DarkGray��6'   
 � Offset$
 0Q�68   � 5      $	 	#FFF3F4CE��6'   $	
 0.5Q�69   � 5      $	 DarkGray��6'   $
 1Q�68   5      5      �� 5       � ��$
 auto��6&   �� 5       � ��$ 10q�6'   �� 5       � ��$
 Bold"�6+   �� 5       � ��$
 auto��6'   �� 5       � �� �	#FF7474746+   �� 5       � �� 5      �� 5        �� 
TargetType" ��6&   .R�5!      � #��z��5"   %   #��z��5#   %   }�. .+�5'      A�  A�Name$ outerRectangle��5(   )   $��Stretch=�5)   )   $��Stretch=�5*   )   #��z��5+   )   $��5��5,   )   
������ 5-   )   A� 51      $ innerRectangle��52      $��Stretch=�53      $��Stretch=�54      
������ $��20��56      #��z��57      A� 5;      $ 	glassCube��5<      $��Stretch=�5=      $��Stretch=�5>      $��2��5?       J� Opacity$ 60Q�5A       J� RenderTransformOrigin$ 0.5,0.5&�5C      ��5D   "   �� 5E   &   $ 0.5,0&�6:   $ 0.5,1&�6M   ��5G   .   � $	
 0.0Q�6;   $
	 Gold��6H   � 5H   .   $	
 1.0Q�6;   $
	 Gray��6H   5J   '   ��5L   "   �� 5M   &   $	 0,0&�6:   $	 1,1&�6K    �� Opacity$ 60Q�6Z   .��5N   *   � � 5O   .   $	 White��6;   $	
 0.2Q�6I   � 5P   .   $	 Transparent��6;   $	
 0.4Q�6O   � 5Q   .   $	 
WhiteSmoke��6;   $	
 0.5Q�6N   � 5R   .   $	 Transparent��6;   $

 0.75Q�6O   � 5S   .   $	 
WhiteSmoke��6;   $	
 0.9Q�6N   � 5T   .   $	 Transparent��6;   $
 1Q�6O   5U   +   5V   '   z�5\   "   V� 5]   &   .~�5^   *   �� �� 5_   *   5`   '    J� BitmapEffect 5e   "   �� 5f   &   5h      ]� 5k      $!��myContentPresenterDockPanel��6(   .+�5l   "   ��  ��Name$ myContentPresenter��5m   !   $��Center=�5o   !   $��Center=�5p   !   #��z��5q   !   #��z��5r   !   5s      5t       �� Triggers 5u      :� 5v       :� RoutedEvent$ Button.Click��6+   [�5w   "   �� 5x   &    ��Name$ mouseEnterBeginStoryboard��66   .��5y   *   �� .��5|   .   W�  �� 
TargetName$ 	glassCube��6>    �� TargetProperty$V P(Rectangle.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�5}      	 W� By$
 -0.3X�5       g� Duration$ 0:0:0.5D�6   W� 5�   .   $ 	glassCube��5�   	   $V P(Rectangle.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)�5�      $
 -0.3X�5�      $ 0:0:0.5D�6   5�   +   5�   '   5�      :� 5�      $ Mouse.MouseLeave��6+   [�5�   "   �� 5�   &   .��5�   *   �� .��5�   .   W� $ 	glassCube��6>   $W Q (Rectangle.RenderTransform).(TransformGroup.Children)[1].(RotateTransform.Angle)�5�      	 W� To$ 0X�5�      $ 0:0:0.1D�6$   5�   /   5�   +   5�   '   �� 5�   &    �� BeginStoryboardName$ mouseEnterBeginStoryboard��65   5�      :� 5�      $ Mouse.MouseEnter��6+   [�5�   "   �� 5�   &   .��5�   *   �� .��5�   .   W� $ 	glassCube��6>   $V P(Rectangle.RenderTransform).(TransformGroup.Children)[1].(RotateTransform.Angle)�5�      $	 360X�5�      $ 0:0:0.4D�6   5�   +   5�   '   5�      P� 5�       P� Property �@J�IsMouseOver P� Value . . �5�   "   ��  �� 
TargetName$ outerRectangle��6F   # � ��5�       � ���� 5�   "   $ 	glassCube��6V    �@J�Opacity$ 1Q�6F   6V   �� 5�   "   $ myContentPresenter��6X    �@J�BitmapEffect 5�   &   �� 5�   *    �� Radius$ 1Q�6;   5�   #   5�      P� 5�       �@J�	IsFocused . . �5�   "   �� $ 	glassCube��6V    �@J�Opacity$ 1Q�6F   6V   �� 5�   "   $ outerRectangle��6E   # � ��5�       � ���� 5�   "   $ 	glassCube��6P    �@J�Opacity$ 1Q�6F   6P   5�      5�      5�      5�      5�      