   M S B A M L   `   `   `  ���� J  FAppVerbe.Models, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullJ6clr-namespace:AppVerbe.Models;assembly=AppVerbe.ModelsAppVerbe.Models  @ <WPFUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:WPFUI.CustomConvertersWPFUI.CustomConverters    WPFUI.ResultsWindow   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Imodels6clr-namespace:AppVerbe.Models;assembly=AppVerbe.Models     6local$clr-namespace:WPFUI.CustomConverters     $
��11pt(�  � WindowStartupLocation$  CenterOwner=� � Title$ ResultsWindow��$	��450��$	��400�� � 	Resources 5  /WPFUI.CustomConverters.BooleanToResultConverter   ResultConverter��%   &	          .���  � RowDefinitions �� $
��Auto ��� $��* �.+��� $��2��
��������� -    ��Name$ ResultsLabel��$��0��$��Center=�$��20(�$��SemiBold"�&   System.Windows.Controls.DataGrid  $��1��   	RowHeight$ 40Q�   RowBackground
 �����   AutoGenerateColumns$ False��$��10, 0q�   HeadersVisibility$ Column=�	   CanUserAddRows$	 False��
   CanUserDeleteRows$
 False��"   VerticalScrollBarVisibility$
 Auto=�   CanUserSortColumns$ False������ *	Results+   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$
 Verb��   
IsReadOnly$
 True��   Width5  /System.Windows.Controls.DataGridLengthConverter$ *    
FontWeight$ DemiBold"�   FontSize$ 17Q�1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *
Verbe.Name+   	CellStyle ��  �� 
TargetType*  $System.Windows.Controls.DataGridCell"  .���  �� Property � �� �� Value
 �����  $
 Time��$
 True��$ *  �� *Verbe.Temps+ �� "  .���  � ��
 �����  $ Results:��$
 True��$
 Auto  �� *Result+ �� 	Converter# [   �� "  .���  � ��
 ����