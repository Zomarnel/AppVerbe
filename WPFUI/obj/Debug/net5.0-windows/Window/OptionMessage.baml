   M S B A M L   `   `   `  ����	  WPFUI     WPFUI.Window.OptionMessage   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � WindowStartupLocation$  CenterOwner=�5   	   $
��11pt(�5   	    � Title$ Message��5	   	   $	��200��6   $	��250��6&   .��5
      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $��50 �6   .+�5   
   �� ���#5fcbfc$��3��6&   �� 5   
   $��0��6      MessageTitle#���   5      $��Center=�5      $
��Bold"�5      �� 5   
   -   5         ��Name$ MessageLabel��5      $��1��5      $��Center=�5      $��Center=�5      $��
3, 0, 3, 0q�5      
�������5      � 5    
   $��2��6   
�������$��
3, 0, 3, 3q�6/    � ColumnDefinitions 5"      �� 5#      $��* �6#   �� 5$      $��* �6#   .+�5'      �� -   5         ��Name$ NoButton��5'      $��0��5(      $��NO��5)      $��70��5*      $��10, 0, 10, 0q�5,      $��Center=�5-      $��Center=�5.      �� 50      -   5        $ 	YesButton��50      $��1��51      $	��YES��52      $��70��53      $��10, 0, 10, 0q�54      $��Center=�56      $��Center=�57      59      5:      5;      