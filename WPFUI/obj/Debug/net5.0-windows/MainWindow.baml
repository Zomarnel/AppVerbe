   M S B A M L   `   `   `  ����N  JAppVerbe.ViewModels, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullV>clr-namespace:AppVerbe.ViewModels;assembly=AppVerbe.ViewModelsAppVerbe.ViewModels  5   	   @ <WPFUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:WPFUI.CustomConvertersWPFUI.CustomConverters 5   	      WPFUI.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U
viewModels>clr-namespace:AppVerbe.ViewModels;assembly=AppVerbe.ViewModels     5   	   6local$clr-namespace:WPFUI.CustomConverters     5   	   -   5        $
��11pt(�5
   	     � Title$  VERBEAPP��5   	   $	��500��6   $	��615��6'    � 	Resources 5      /  )WPFUI.CustomConverters.HalfValueConverter   HalfValueConverter��%   &	          5   
   6#   5      .��5      �  � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��* �6   �� 5      $��30 �6   .+�5   
   o� $��0��6   
�������$
��11pt(�63   .@�5      m�   ChangeLanguageMenu#���  6   $��30��6E   .@�5      m� -   5          LanguageMenuEnglish#���  5       m� CommandParameter$ en��6J   6`   m� 5      -   5          LanguageMenuFrench#���  5      $ fr��6I   6_   m� 5      -   5          LanguageMenuGerman#���  5      $ de��6I   6_   5       m� 5!      -   5          NewListMenu#���  5!      $��30��6V   5"      �� 5$   
   $��2��6   
���   �
�������62   �� 5&   
   $��1��6   
���   �
�������62   �� 5(   
   -   5         ��Name$ 
MainCanvas��5(      $��1��6%   .+�5+      �� -   5         ��Name$ TopRightButton��5+      $|�False��6F   ��5,      �� 5-      .R�5.      F�  F�Name$
 Path��6   
���   ����#1e90ff7���� �� ��р�� ��р����� �� ���������	6K    �� Triggers 5/      P� 50       P� Property �@J�IsMouseOver	 P� Value$
	 True��6=   . �51   "   �� 
 �� 
TargetName$

 Path��6)    �� Property � �� �� Value �#50a5ff6K   52      54      56      �� 58      -   5        $ 
MainButton��58      $|�False��6�    �� Bottom 6B   ��  �� ElementName$ 
MainCanvas�� �� Path$ ActualHeight� �� 	Converter# [  ��59      �� 5:      .R�5;      F� $
 Path��6   
���   �
���  ��7���� �� ��р�� ��р����� �� �� ������	6G    5<      P� 5=       �@J�IsMouseOver$
	 True��6=   . �5>   "   �� $

 Path��6)    � �� �#f5796d6K   5?      5A       �� Right 5D      �� 5E      $ 
MainCanvas��6   $ ActualWidth�67   # [  6J   5G      �� 5I      -	   5        $ BottomLeftButton��5I      $|�False��6J   ��5J      �� 5K      .R�5L      F� $
 Path��6   
���   ����#70be447���� �� ��р�� ��р������ �� ���������	6K    5M      P� 5N       �@J�IsMouseOver$
	 True��6=   . �5O   "   �� $

 Path��6)    � �� �#7dd7486K   5P      5R      5T      �� 5V      -
   5        $ BottomRightButton��5V      $|�False��6K   ��5W      �� 5X      .R�5Y      F� $
 Path��6   
���   ����#ff80007���� �� ��� �����р������ �� ���������	6K    5Z      P� 5[       �@J�IsMouseOver$
	 True��6=   . �5\   "   �� $

 Path��6)    � �� �#ffc0806K   5]      5_      5a      �� 5d      -   5         ��Name$ TopLeftTextBlock��5d   w     LoadListButton#���  6   $
��Bold"�6e    J� IsHitTestVisible$ False��6�   �� 5f      -   5        $ TopRightTextBlock��5f   R     SaveListButton#���  6   $
��Bold"�6@   $ False��6m   �� 5h      -   5        $ BottomRightTextBlock��5h   T     RandomVerbButton#���  6   $
��Bold"�6B   $ False��6r   �� 5j      -   5        $ BottomLeftTextBlock��5j   W    	 CustomizeListButton#��� 	 6   $
��Bold"�6E   $ False��6t   5l      5m      5o      