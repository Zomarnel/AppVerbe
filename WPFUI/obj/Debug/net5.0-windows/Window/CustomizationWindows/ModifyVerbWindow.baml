   M S B A M L   `   `   `  ����J  FAppVerbe.Models, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullJ6clr-namespace:AppVerbe.Models;assembly=AppVerbe.ModelsAppVerbe.Models  5   	   @ <WPFUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:WPFUI.CustomConvertersWPFUI.CustomConverters 5   	   #   WPFUI.Window.ModifyVerbWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Imodels6clr-namespace:AppVerbe.Models;assembly=AppVerbe.Models     5   	   6local$clr-namespace:WPFUI.CustomConverters     5   	     � WindowStartupLocation$  CenterOwner=�5
   	   $
��11pt(�5   	    � Title$ ModifyVerbWindow��5   	   $	��450��6"   $	��450��6/   .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DataGrid��5   G   $��0��6      	RowHeight$ 40Q�6Z      RowBackground
 �����   AutoGenerateColumns$ False��6�      HeadersVisibility$ Column=�6�      CanUserAddRows$ False��6�   	   CanUserDeleteRows$	 False��6�   "
   VerticalScrollBarVisibility$

 Auto=�6�      CanUserSortColumns$ False��6  ��6    �� *AppData.Verbes+   	CellStyle 5      �� 5       �� 
TargetType*  $System.Windows.Controls.DataGridCell"  6    �� Triggers 5      P� 5       P� Property �@ 
IsSelected P� Value$
 True��68   . �5      ��  �� Property � �� �� Value
 ���� 6<   �� 5       � ��# � ��6;   �� 5       � ��
 ���� 6;   5      5         Columns 5!      4  .System.Windows.Controls.DataGridTemplateColumn  5#      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6)      CellTemplate 5$      �� 5%      .R�5&      �� -   5           ButtonModify#���   5&   %   $
��Auto��6N   6[   5'      5)      0  *System.Windows.Controls.DataGridTextColumn  5+         Header$
 Verb��6%      
IsReadOnly$
 True��5,   %   $ * 5-   %   -   5        	Verbe��   
FontWeight$ DemiBold"�5/   >      FontSize$ 17Q�6T   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Name+   	CellStyle 51      �� 52      "  6    .�53      ��  �@�ToolTip 68   �� *ToolTipContent+�� 54       � ��
 �����6;   55      58        5:      $
 Time��6%   $
 True��5;   %   $ * 5<   %   $ DemiBold"�5=   ?   $ 17Q�6U    6%   �� *Temps+ 5?      �� 5@      "  6    .�5A      ��  �@�ToolTip 68   �� *ToolTipContent+�� 5B       � ��
 �����6;   5C      5E      5G      5H      5I      