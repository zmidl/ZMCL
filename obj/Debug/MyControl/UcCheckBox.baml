   M S B A M L   `   `   `  ����  ZMCL    ZMCL.MyControl.UcCheckBox   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        J� Effect  5      3  -System.Windows.Media.Effects.DropShadowEffect  5   
      ShadowDepth$ 0Q�6      	Direction$	 180Q�6+      
BlurRadius$ 10Q�6;      Color$ 	#FF726B6B��6K   ��5	      �� 5
   
    �� 
TargetType" ��6   .�5      ��  �� Property �@�FocusVisualStyle �� Value 61   Z� �� 5       � ��
 �   �6+   �� 5       � ��$ 1q�60   �� 5       �@�Cursor$
 Hand��6'   �� 5       � ��$ 20��6&   �� 5       � ��$ 12��6'   �� 5       � �� 5      �� 5       �� 
TargetType" ��6&   	 � 	Resources	 5         StoryboardIsChecked
 �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  StoryboardIsCheckedOff��%
  &	        &	 �     �� 5      .��5   "   U� $U
 O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6@   $ 	CheckFlag��6�   .\�5   &     $ 0��6;   $ 17Q�6G     5   &   $ 0:0:0.2��6;   $ 0Q�6M   5   #   5      �� 5      .��5   "   U� $U
 O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6@   $ 	CheckFlag��6�   .\�5   &     $ 0��6;   $ 0Q�6G     5    &   $ 0:0:0.2��6;   $ 17Q�6M   5!   #   5"      5#      .R�5$      ��  �� 
Background
 ����  J� SnapsToDevicePixels .  �� Bullet 5%      (� 5&   "    (� Stretch$
 Fill=�6*   #��z��69   #��z��6Y   .��5'   &   ��  ��Name$ ForegroundPanel��6-   $��1q�6F   $��35��6Z   $��20��6e    �� CornerRadius$ 10��6q   ._�5(   *   �� .+�5+   .   �� $ 	CheckFlag��5,   1   
�������$ 10��5/   1   $��Center=�50   1   $��1q�51   1   $��18��52   1   $��18��6<    J� RenderTransformOrigin$ 0.5,0.5&�53   1   
 �� Top$ 0��6Q    �� Left$
 -0.5��6`   z�54   2   V� 55   6   .~�56   :   �� �� 57   :   �� 58   :   T� 59   :   5:   7     5<   2     5=   6   $ 1Q�6G   $	 180Q�6W   $ 5Q�6g   $ 	#FF726B6B��6v   5?   /   5@   +   5A   '   5B   #   ._�5D      �� #��z��6/   #��z��6r   ��. # z 6�   $��Center=�6�   5E       �� Triggers 5F      P� 5G       P� Property � �� P� Value . . �5I   "   ��  � ��$ 4,0,0,0q�6<   5J      P� 5K       � {� .  . �5M   "   ��  �� 
TargetName$ ForegroundPanel��6)    � ��
 �����6\   5N      P� 5O       �@d�	IsChecked$ FalseY�6;   . �5P   "   �� $ ForegroundPanel��6)    � �� �	#FFAEACAC6\    N� EnterActions 5T   "   �� 5U   &    ��Name$  BeginStoryboardCheckedTrue��66   #��[  6Z   �� 5V   &    �� BeginStoryboardName$! BeginStoryboardCheckedFalse��67   5X      P� 5Y       �@d�	IsChecked$
 TrueY�6;   . �5Z   "   �� $ ForegroundPanel��6)    � �� 5[   &   �� 5\   *    �� EndPoint$ 0.5,1&�6>    � MappingMode$ RelativeToBoundingBox=�6O     �� 
StartPoint$  0.5,0&�6s   .��5]   .   � ! � Color$! 	#FF055F15��6;   " � Offset$" 0Q�6M   � 5^   .   $! 	#FF077429��6;   $" 1Q�6M   5_   +   5a   #    5b   "   �� 5c   &   $! BeginStoryboardCheckedFalse��66   #��[ 6[   �� 5d   &   $  BeginStoryboardCheckedTrue��67   5f      5h      5j      5k      5m      