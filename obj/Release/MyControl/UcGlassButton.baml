   M S B A M L   `   `   `  ����   ZMCL"    ZMCL.MyControl.UcGlassButton   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ����   �� 
TargetType"  ��.���  �� Property �@�FocusVisualStyle �� Value Z� ��  �@J�Effect 3  -System.Windows.Media.Effects.DropShadowEffect     Color$ Black��   	Direction$ 12Q�   ShadowDepth$ 1Q�   Opacity$ 10Q���  � �� ��  �� 
StartPoint$	 0,0&� �� EndPoint$	 1,1&�.��� 	 � Color$	 DarkGray��
 � Offset$
 0Q�� $	 	#FFF3F4CE��$	
 0.5Q�� $	 DarkGray��$
 1Q���  � ��$
 auto����  � ��$ 10q���  � ��$
 Bold"���  � ��$
 auto����  � �� �	#FF747474��  � �� ��  �� 
TargetType" ��.R�� #��z��#��z��}�. .+�A�  A�Name$ outerRectangle��$��Stretch=�$��Stretch=�#��z��$��5��
������ A� $ innerRectangle��$��Stretch=�$��Stretch=�
������ $��20��#��z��A� $ 	glassCube��$��Stretch=�$��Stretch=�$��2�� J� Opacity$ 60Q� J� RenderTransformOrigin$ 0.5,0.5&����� $ 0.5,0&�$ 0.5,1&���� $	
 0.0Q�$
	 Gold��� $	
 1.0Q�$
	 Gray������ $	 0,0&�$	 1,1&� �� Opacity$ 60Q�.��� � $	 White��$	
 0.2Q�� $	 Transparent��$	
 0.4Q�� $	 
WhiteSmoke��$	
 0.5Q�� $	 Transparent��$

 0.75Q�� $	 
WhiteSmoke��$	
 0.9Q�� $	 Transparent��$
 1Q�z�V� .~��� ��  J� BitmapEffect �� ]� $!��myContentPresenterDockPanel��.+���  ��Name$ myContentPresenter��$��Center=�$��Center=�#��z��#��z�� �� Triggers :�  :� RoutedEvent$ Button.Click��[���  ��Name$ mouseEnterBeginStoryboard��.���� .��W�  �� 
TargetName$ 	glassCube�� �� TargetProperty$V P(Rectangle.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�	 W� By$
 -0.3X� g� Duration$ 0:0:0.5D�W� $ 	glassCube��$V P(Rectangle.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)�$
 -0.3X�$ 0:0:0.5D�:� $ Mouse.MouseLeave��[��� .���� .��W� $ 	glassCube��$W Q (Rectangle.RenderTransform).(TransformGroup.Children)[1].(RotateTransform.Angle)�	 W� To$ 0X�$ 0:0:0.1D���  �� BeginStoryboardName$ mouseEnterBeginStoryboard��:� $ Mouse.MouseEnter��[��� .���� .��W� $ 	glassCube��$V P(Rectangle.RenderTransform).(TransformGroup.Children)[1].(RotateTransform.Angle)�$	 360X�$ 0:0:0.4D�P�  P� Property �@J�IsMouseOver P� Value . . ���  �� 
TargetName$ outerRectangle��# � �� � ���� $ 	glassCube�� �@J�Opacity$ 1Q��� $ myContentPresenter�� �@J�BitmapEffect ��  �� Radius$ 1Q�P�  �@J�	IsFocused . . ��� $ 	glassCube�� �@J�Opacity$ 1Q��� $ outerRectangle��# � �� � ���� $ 	glassCube�� �@J�Opacity$ 1Q�