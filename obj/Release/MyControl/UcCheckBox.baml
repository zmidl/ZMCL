   M S B A M L   `   `   `  ����   ZMCL    ZMCL.MyControl.UcCheckBox   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008       J� Effect  3  -System.Windows.Media.Effects.DropShadowEffect     ShadowDepth$ 0Q�   	Direction$	 180Q�   
BlurRadius$ 10Q�   Color$ 	#FF726B6B������  �� 
TargetType" ��.���  �� Property �@�FocusVisualStyle �� Value Z� ��  � ��
 �   ���  � ��$ 1q���  �@�Cursor$
 Hand����  � ��$ 20����  � ��$ 12����  � �� ��  �� 
TargetType" ��	 � 	Resources	    StoryboardIsChecked
 �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  StoryboardIsCheckedOff��%b  &	        &	 �     �� .��U� $U
 O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�$ 	CheckFlag��.\�  $ 0��$ 17Q�  $ 0:0:0.2��$ 0Q��� .��U� $U
 O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�$ 	CheckFlag��.\�  $ 0��$ 0Q�  $ 0:0:0.2��$ 17Q�.R���  �� 
Background
 ����  J� SnapsToDevicePixels .  �� Bullet (�  (� Stretch$
 Fill=�#��z��#��z��.����  ��Name$ ForegroundPanel��$��1q�$��35��$��20�� �� CornerRadius$ 10��._��� .+��� $ 	CheckFlag��
�������$ 10��$��Center=�$��1q�$��18��$��18�� J� RenderTransformOrigin$ 0.5,0.5&�
 �� Top$ 0�� �� Left$
 -0.5��z�V� .~��� �� �� T�     $ 1Q�$	 180Q�$ 5Q�$ 	#FF726B6B��._��� #��z��#��z����. # z $��Center=� �� Triggers P�  P� Property � �� P� Value . . ���  � ��$ 4,0,0,0q�P�  � {� .  . ���  �� 
TargetName$ ForegroundPanel�� � ��
 �����P�  �@d�	IsChecked$ FalseY�. ��� $ ForegroundPanel�� � �� �	#FFAEACAC N� EnterActions ��  ��Name$  BeginStoryboardCheckedTrue��#��[  ��  �� BeginStoryboardName$! BeginStoryboardCheckedFalse��P�  �@d�	IsChecked$
 TrueY�. ��� $ ForegroundPanel�� � �� ��  �� EndPoint$ 0.5,1&� � MappingMode$ RelativeToBoundingBox=�  �� 
StartPoint$  0.5,0&�.��� ! � Color$! 	#FF055F15��" � Offset$" 0Q�� $! 	#FF077429��$" 1Q� �� $! BeginStoryboardCheckedFalse��#��[ �� $  BeginStoryboardCheckedTrue��