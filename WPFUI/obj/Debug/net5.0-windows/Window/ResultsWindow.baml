   M S B A M L   `   `   `  ����J  FAppVerbe.Models, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullJ6clr-namespace:AppVerbe.Models;assembly=AppVerbe.ModelsAppVerbe.Models  5   	   @ <WPFUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:WPFUI.CustomConvertersWPFUI.CustomConverters 5   	      WPFUI.ResultsWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Imodels6clr-namespace:AppVerbe.Models;assembly=AppVerbe.Models     5   	   6local$clr-namespace:WPFUI.CustomConverters     5   	   $
��11pt(�5
   	     � WindowStartupLocation$  CenterOwner=�5   	    � Title$ ResultsWindow��5   	   $	��450��6   $	��400��6,    � 	Resources 5      5  /WPFUI.CustomConverters.BooleanToResultConverter   ResultConverter��%   &	          5   
   6)   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��2��6   
�������6"   �� 5   
   -   5         ��Name$ ResultsLabel��5      $��0��6   $��Center=�64   $��20(�6X   $��SemiBold"�6f   &   System.Windows.Controls.DataGrid  5   
   $��1��6      	RowHeight$ 40Q�6       RowBackground
 �����   AutoGenerateColumns$ False��6i   $��10, 0q�6�      HeadersVisibility$ Column=�6�   	   CanUserAddRows$	 False��6�   
   CanUserDeleteRows$
 False��6�   "   VerticalScrollBarVisibility$
 Auto=�6�      CanUserSortColumns$ False��6  ��6I   �� *	Results+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Verb��6%      
IsReadOnly$
 True��5   %      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 5    %      
FontWeight$ DemiBold"�5!   D      FontSize$ 17Q�6Z   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *
Verbe.Name+   	CellStyle 5#      �� 5$       �� 
TargetType*  $System.Windows.Controls.DataGridCell"  6    .�5%      ��  �� Property � �� �� Value
 �����6;   5&      5(        5*      $
 Time��6%   $
 True��5+   %   $ * 5,   %    5-   %   �� *Verbe.Temps+ 5/      �� 50      "  6    .�51      ��  � ��
 �����6;   52      54        56      $ Results:��6%   $
 True��57   %   $
 Auto 58   %    59   %   �� *Result+ �� 	Converter# [   5:      �� 5;      "  6    .�5<      ��  � ��
 ����6;   5=      5?      5A      5B      5C      