   M S B A M L   `   `   `  ���� N  JAppVerbe.ViewModels, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullV>clr-namespace:AppVerbe.ViewModels;assembly=AppVerbe.ViewModelsAppVerbe.ViewModels  @ <WPFUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WPFUI.WindowWPFUI.Window #   WPFUI.Window.DeleteVerbWindow   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     U
viewModels>clr-namespace:AppVerbe.ViewModels;assembly=AppVerbe.ViewModels     ,localclr-namespace:WPFUI.Window       � WindowStartupLocation$  CenterOwner=�$
��11pt(� � Title$ DeleteVerbWindow��$	��450��$	��450��.���  � RowDefinitions �� $��* ��� $
��Auto �.+�&   System.Windows.Controls.DataGrid  -     Name$ DataGrid��$��0��   	RowHeight$ 40Q�   RowBackground
 �����   AutoGenerateColumns$ False��   HeadersVisibility$ Column=�   CanUserAddRows$ False��	   CanUserDeleteRows$	 False��"
   VerticalScrollBarVisibility$

 Auto=�   CanUserSortColumns$ False������ *CheckedVerbes+   	CellStyle ��  �� 
TargetType*  $System.Windows.Controls.DataGridCell"   �� Triggers P�  P� Property �@ 
IsSelected P� Value$
 True��. ���  �� Property � �� �� Value
 ���� ��  � ��# � ����  � ��
 ����    Columns 4  .System.Windows.Controls.DataGridTemplateColumn  ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 40    CellTemplate �� .R���  d� 	IsChecked �� *	IsChecked+ �� UpdateSourceTrigger$ PropertyChanged=� � LayoutTransform ��  �� ScaleX$ 2Q� �� ScaleY$ 2Q�0  *System.Windows.Controls.DataGridTextColumn     Header$
 Verb��   
IsReadOnly$
 True��$ * -   	Verbe��   
FontWeight$ DemiBold"�   FontSize$ 17Q�1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *
Verbe.Name+    	CellStyle  �� "  .���  �@�ToolTip �� *Verbe.ToolTipContent+��  � ��
 �����  $
 Time��$
 True��$ * $ DemiBold"�$ 17Q� �� *Verbe.Temps+  �� "  .���  �@�ToolTip �� *Verbe.ToolTipContent+��  � ��
 ������� -   $��1��$��40��   ButtonDelete#���   $��Italic$�$��
UltraBlack"�$��Center=�$��Center=�