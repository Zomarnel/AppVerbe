   M S B A M L   `   `   `  ����N  JAppVerbe.ViewModels, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullV>clr-namespace:AppVerbe.ViewModels;assembly=AppVerbe.ViewModelsAppVerbe.ViewModels  5   	   @ <WPFUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WPFUI.WindowWPFUI.Window 5   	   #   WPFUI.Window.DeleteVerbWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U
viewModels>clr-namespace:AppVerbe.ViewModels;assembly=AppVerbe.ViewModels     5   	   ,localclr-namespace:WPFUI.Window     5   	     � WindowStartupLocation$  CenterOwner=�5
   	   $
��11pt(�5   	    � Title$ DeleteVerbWindow��5   	   $	��450��6"   $	��450��6/   .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DataGrid��5   F   $��0��6      	RowHeight$ 40Q�6Y      RowBackground
 �����   AutoGenerateColumns$ False��6�      HeadersVisibility$ Column=�6�      CanUserAddRows$ False��6�   	   CanUserDeleteRows$	 False��6�   "
   VerticalScrollBarVisibility$

 Auto=�6�      CanUserSortColumns$ False��6  ��6    �� *CheckedVerbes+   	CellStyle 5      �� 5       �� 
TargetType*  $System.Windows.Controls.DataGridCell"  6    �� Triggers 5      P� 5       P� Property �@ 
IsSelected P� Value$
 True��68   . �5      ��  �� Property � �� �� Value
 ���� 6<   �� 5       � ��# � ��6;   �� 5       � ��
 ���� 6;   5      5          Columns 5#      4  .System.Windows.Controls.DataGridTemplateColumn  5%      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 40 6)      CellTemplate 5&      �� 5'      .R�5(      ��  d� 	IsChecked 6'   �� *	IsChecked+ �� UpdateSourceTrigger$ PropertyChanged=� � LayoutTransform 5)   "   �� 5*   &    �� ScaleX$ 2Q�65    �� ScaleY$ 2Q�6@   5,      5-      5/      0  *System.Windows.Controls.DataGridTextColumn  51         Header$
 Verb��6%      
IsReadOnly$
 True��52   %   $ * 53   %   -   5        	Verbe��   
FontWeight$ DemiBold"�55   D      FontSize$ 17Q�6Z   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *
Verbe.Name+    	CellStyle  57      �� 58      "  6    .�59      ��  �@�ToolTip 68   �� *Verbe.ToolTipContent+�� 5:       � ��
 �����6;   5;      5>        5@      $
 Time��6%   $
 True��5A   %   $ * 5B   %   $ DemiBold"�5C   E   $ 17Q�6[    6%   �� *Verbe.Temps+  5E      �� 5F      "  6    .�5G      ��  �@�ToolTip 68   �� *Verbe.ToolTipContent+�� 5H       � ��
 �����6;   5I      5K      5M      �� 5O   
   -   5        $��1��5O      $��40��6      ButtonDelete#���   5P      $��Italic$�5Q      $��
UltraBlack"�5R      $��Center=�5T      $��Center=�63   5U      5V      