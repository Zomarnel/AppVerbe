   M S B A M L   `   `   `  ���� N  JAppVerbe.ViewModels, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullV>clr-namespace:AppVerbe.ViewModels;assembly=AppVerbe.ViewModelsAppVerbe.ViewModels  @ <WPFUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:WPFUI.CustomConvertersWPFUI.CustomConverters    WPFUI.MainWindow   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     U
viewModels>clr-namespace:AppVerbe.ViewModels;assembly=AppVerbe.ViewModels     6local$clr-namespace:WPFUI.CustomConverters     -   $
��11pt(�  � Title$  VERBEAPP��$	��500��$	��615�� � 	Resources /  )WPFUI.CustomConverters.HalfValueConverter   HalfValueConverter��%   &	          .���  � RowDefinitions �� $��30 ��� $��* ��� $��30 �.+�o� $��0��
�������$
��11pt(�.@�m�   ChangeLanguageMenu#���  $��30��.@�m� -     LanguageMenuEnglish#���   m� CommandParameter$ en��m� -     LanguageMenuFrench#���  $ fr��m� -     LanguageMenuGerman#���  $ de��m� -     NewListMenu#���  $��30���� $��2��
���   �
��������� $��1��
���   �
��������� -    ��Name$ 
MainCanvas��$��1��.+��� -    ��Name$ TopRightButton��$|�False������ .R�F�  F�Name$
 Path��
���   ����#1e90ff7���� �� ��р�� ��р����� �� ���������	 �� Triggers P�  P� Property �@J�IsMouseOver	 P� Value$
	 True��. ��� 
 �� 
TargetName$

 Path�� �� Property � �� �� Value �#50a5ff�� -   $ 
MainButton��$|�False�� �� Bottom ��  �� ElementName$ 
MainCanvas�� �� Path$ ActualHeight� �� 	Converter# [  ���� .R�F� $
 Path��
���   �
���  ��7���� �� ��р�� ��р����� �� �� ������	 P�  �@J�IsMouseOver$
	 True��. ��� $

 Path�� � �� �#f5796d �� Right �� $ 
MainCanvas��$ ActualWidth�# [  �� -	   $ BottomLeftButton��$|�False������ .R�F� $
 Path��
���   ����#70be447���� �� ��р�� ��р������ �� ���������	 P�  �@J�IsMouseOver$
	 True��. ��� $

 Path�� � �� �#7dd748�� -
   $ BottomRightButton��$|�False������ .R�F� $
 Path��
���   ����#ff80007���� �� ��� �����р������ �� ���������	 P�  �@J�IsMouseOver$
	 True��. ��� $

 Path�� � �� �#ffc080�� -    ��Name$ TopLeftTextBlock��  LoadListButton#���  $
��Bold"� J� IsHitTestVisible$ False���� -   $ TopRightTextBlock��  SaveListButton#���  $
��Bold"�$ False���� -   $ BottomRightTextBlock��  RandomVerbButton#���  $
��Bold"�$ False���� -   $ BottomLeftTextBlock�� 	 CustomizeListButton#��� 	 $
��Bold"�$ False��