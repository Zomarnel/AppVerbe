   M S B A M L   `   `   `  ����@  <WPFUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WPFUI.WindowWPFUI.Window  5   	   $    WPFUI.Window.CustomizeListMenu   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:WPFUI.Window     5   	     � WindowStartupLocation$  CenterOwner=�5   	    � Title$ CustomizeListMenu��5	   	   $	��450��6#   $	��400��60   .��5
      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ AddVerb��5      $��0��5         TitleAddVerb#���   5      $
��20pt(�5      $��DemiBold"�5      ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value
 �  ��63   �� 5       � �� 5      �� 5       �� 
TargetType" ��6.   .R�5   "   �� #��z��6)   
���   �$��1q�6g   ._�5   &   �� $��Center=�67   $��Center=�6T   5    #   5!      5#       �� Triggers 5$      P� 5%      	 P� Property	 �@J�IsMouseOver
 P� Value$

 True��69   . �5&      ��  � �� �#f5796d6;   5'      5)      5+      �� 5.   
   -   5        $ 
DeleteVerb��5.      $��1��50        TitleDeleteVerb#���  51      $
��20pt(�52      $��DemiBold"�53      ��55      �� 56      " ��6   .�57      ��  � ��
 � ���63   �� 58       � �� 59      �� 5:      " ��6.   .R�5;   "   �� #��z��6)   
���   �$��1q�6g   ._�5<   &   �� $��Center=�67   $��Center=�6T   5=   #   5>      5@       5A      P� 5B      	 �@J�IsMouseOver$

 True��69   . �5C      ��  � �� �#ffc0806;   5D      5F      5H      �� 5J   
   -   5        $ 
ModifyVerb��5J      $��2��5L        TitleModifyVerb#���  5M      $
��20pt(�5N      $��DemiBold"�5O      ��5P      �� 5Q      " ��6   .�5R      ��  � �� �#70be4463   �� 5S       � �� 5T      �� 5U      " ��6.   .R�5V   "   �� #��z��6)   
���   �$��1q�6g   ._�5W   &   �� $��Center=�67   $��Center=�6T   5X   #   5Y      5[       5\      P� 5]      	 �@J�IsMouseOver$

 True��69   . �5^      ��  � �� �#7dd7486;   5_      5a      5c      5d      5e      