   M S B A M L   `   `   `  ���� J  FAppVerbe.Models, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullJ6clr-namespace:AppVerbe.Models;assembly=AppVerbe.ModelsAppVerbe.Models  @ <WPFUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:WPFUI.CustomConvertersWPFUI.CustomConverters #   WPFUI.Window.ModifyVerbWindow   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Imodels6clr-namespace:AppVerbe.Models;assembly=AppVerbe.Models     6local$clr-namespace:WPFUI.CustomConverters       � WindowStartupLocation$  CenterOwner=�$
��11pt(� � Title$ ModifyVerbWindow��$	��450��$	��450��.���  � RowDefinitions �� $��* �.+�&   System.Windows.Controls.DataGrid  -     Name$ DataGrid��$��0��   	RowHeight$ 40Q�   RowBackground
 �����   AutoGenerateColumns$ False��   HeadersVisibility$ Column=�   CanUserAddRows$ False��	   CanUserDeleteRows$	 False��"
   VerticalScrollBarVisibility$

 Auto=�   CanUserSortColumns$ False������ *AppData.Verbes+   	CellStyle ��  �� 
TargetType*  $System.Windows.Controls.DataGridCell"   �� Triggers P�  P� Property �@ 
IsSelected P� Value$
 True��. ���  �� Property � �� �� Value
 ���� ��  � ��# � ����  � ��
 ����    Columns 4  .System.Windows.Controls.DataGridTemplateColumn  ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto    CellTemplate �� .R��� -      ButtonModify#���   $
��Auto��0  *System.Windows.Controls.DataGridTextColumn     Header$
 Verb��   
IsReadOnly$
 True��$ * -   	Verbe��   
FontWeight$ DemiBold"�   FontSize$ 17Q�1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Name+   	CellStyle �� "  .���  �@�ToolTip �� *ToolTipContent+��  � ��
 �����  $
 Time��$
 True��$ * $ DemiBold"�$ 17Q� �� *Temps+ �� "  .���  �@�ToolTip �� *ToolTipContent+��  � ��
 �����