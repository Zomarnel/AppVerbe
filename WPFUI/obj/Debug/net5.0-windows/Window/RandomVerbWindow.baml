   M S B A M L   `   `   `  ����J  FAppVerbe.Models, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullJ6clr-namespace:AppVerbe.Models;assembly=AppVerbe.ModelsAppVerbe.Models  5   	   	 WPFUI   WPFUI.RandomVerbWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Imodels6clr-namespace:AppVerbe.Models;assembly=AppVerbe.Models     5   	     � WindowStartupLocation$  CenterOwner=�5	   	   $
��11pt(�5
   	    � Title$
 TEST��5   	   $	��500��6   $	��450��6#    � 	Resources 5         BoolenToVisibility��%   &	        �� 5   
   6'   5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5       $��* �6   .+�5#   
   �� $��1��6   $��7��6   $��2��6/   
������6C   �� 5%   
   $��0��6   $��8��6   $��2��6/   
���   �$
��0.25q�6W    K� ZIndex$ 99��6n   � 5(   
   $��0��6   $��2��6   
������� 5)      �� 5*      $��* �6#   �� 5+      $��* �6#   .+�5.      �� $��0��6   $��Center=�5/      $��Center=�62   $
��Bold"�50   )   $��20(�6;   ��6   �� *Name+6;   �� 52      $��1��6   
�������$��Center=�53      $��Center=�62   $
��Bold"�54   *   $��20(�6<   ��6   �� *Temps+6<   55      �� 58   
   -   5         ��Name$ LBPPS��58   �   $��1��6   $��10q�6   $��0��6)   $��DemiBold"�69   $
��12pt(�6O     LabelFirstPerson#���  6_   $��Center=�6�   �� 59   
   -   5        $ LBDPS��59   �   $��2��6   $��10q�6   $��0��6)   $��DemiBold"�69   $
��12pt(�6O     LabelSecondPerson#���  6_   $��Center=�6�   �� 5:   
   -   5        $ LBTPS��5:   �   $��3��6   $��10q�6   $��0��6)   $��DemiBold"�69   $
��12pt(�6O     LabelThirdPerson#���  6_   $��Center=�6�   �� 5;   
   -   5        $ LBPPP��5;   �   $��4��6   $��10q�6   $��0��6)   $��DemiBold"�69   $
��12pt(�6O     LabelFourthPerson#���  6_   $��Center=�6�   �� 5<   
   -   5        $ LBDPP��5<   �   $��5��6   $��10q�6   $��0��6)   $��DemiBold"�69   $
��12pt(�6O     LabelFifthPerson#���  6_   $��Center=�6�   �� 5=   
   -   5        $ LBTPP��5=   �   $��6��6   $��10q�6   $��0��6)   $��DemiBold"�69   $
��12pt(�6O     LabelSixthPerson#���  6_   $��Center=�6�   �� 5@   
   -   5         ��Name$	 PPS��5B      $��1��5@      $��1��6   $��0, 0, 10, 0q�5A      $��25��5C      $��Center=�5D      $
��12pt(�5E      5F      �� 5H   
   -   5        $	 DPS��5J      $��2��5H      $��1��6   $��0, 0, 10, 0q�5I      $��25��5K      $��Center=�5L      $
��12pt(�5M      5N      �� 5O   
   -	   5        $	 TPS��5Q      $��3��5O      $��1��6   $��0, 0, 10, 0q�5P      $��25��5R      $��Center=�5S      $
��12pt(�5T      5U      �� 5V   
   -
   5        $	 PPP��5X      $��4��5V      $��1��6   $��0, 0, 10, 0q�5W      $��25��5Y      $��Center=�5Z      $
��12pt(�5[      5\      �� 5]   
   -   5        $	 DPP��5_      $��5��5]      $��1��6   $��0, 0, 10, 0q�5^      $��25��5`      $��Center=�5a      $
��12pt(�5b      5c      �� 5d   
   -   5        $	 TPP��5f      $��6��5d      $��1��6   $��0, 0, 10, 0q�5e      $��25��5g      $��Center=�5h      $
��12pt(�5i      5j      � 5n   
   $��7��6   $��2��6   .+�5o      �� -   5          ButtonConfirm#���  5o      5p      5q      5s      5u      