   M S B A M L   `   `   `  ���� @  <WPFUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WPFUI.WindowWPFUI.Window  $    WPFUI.Window.CustomizeListMenu   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     ,localclr-namespace:WPFUI.Window       � WindowStartupLocation$  CenterOwner=� � Title$ CustomizeListMenu��$	��450��$	��400��.���  � RowDefinitions �� $��* ��� $��* ��� $��* �.+��� -    ��Name$ AddVerb��$��0��   TitleAddVerb#���   $
��20pt(�$��DemiBold"�����  �� 
TargetType" ��.���  �� Property � �� �� Value
 �  ����  � �� ��  �� 
TargetType" ��.R��� #��z��
���   �$��1q�._��� $��Center=�$��Center=� �� Triggers P� 	 P� Property	 �@J�IsMouseOver
 P� Value$

 True��. ���  � �� �#f5796d�� -   $ 
DeleteVerb��$��1��  TitleDeleteVerb#���  $
��20pt(�$��DemiBold"����� " ��.���  � ��
 � �����  � �� �� " ��.R��� #��z��
���   �$��1q�._��� $��Center=�$��Center=� P� 	 �@J�IsMouseOver$

 True��. ���  � �� �#ffc080�� -   $ 
ModifyVerb��$��2��  TitleModifyVerb#���  $
��20pt(�$��DemiBold"����� " ��.���  � �� �#70be44��  � �� �� " ��.R��� #��z��
���   �$��1q�._��� $��Center=�$��Center=� P� 	 �@J�IsMouseOver$

 True��. ���  � �� �#7dd748