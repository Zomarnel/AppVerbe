   M S B A M L   `   `   `  ���� N  JAppVerbe.ViewModels, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullV>clr-namespace:AppVerbe.ViewModels;assembly=AppVerbe.ViewModelsAppVerbe.ViewModels  	 WPFUI   WPFUI.AddVerbWindow   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     U
viewModels>clr-namespace:AppVerbe.ViewModels;assembly=AppVerbe.ViewModels       � WindowStartupLocation$  CenterOwner=�$
��11pt(� � Title$ ADD VERB��$	��500��$	��450�� � 	Resources    BoolenToVisibility��%   &	        �� .���  � RowDefinitions �� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* � � ColumnDefinitions �� $
��Auto ��� $��* �.+��� $��8��$��2��
��������� $��0��$��2��
�������� $��0��$��2�� �� $��* ��� $��* �.+�� $��0�� �� $
��Auto ��� $��* �.+��� $��0��  LabelVerbName#���  $��DemiBold"�$
��12pt(�$��Center=��� -    ��Name$
 Name��$��1��$��25��$��Center=�$
��12pt(�� $��1��$��11q� �� $
��Auto ��� $��* �.+��� $��0��  LabelVerbTime#���  $��DemiBold"�$
��12pt(�$��Center=��� -   $ Temps��$��1��$��25��$��Center=�$
��12pt(��� $��1��$��0��$��10, 0, 0, 0q�$��DemiBold"�$
��12pt(�  LabelFirstPerson#���  $��Center=��� $��2��$��0��$��10, 0, 0, 0q�$��DemiBold"�$
��12pt(�  LabelSecondPerson#���  $��Center=��� $��3��$��0��$��10, 0, 0, 0q�$��DemiBold"�$
��12pt(�  LabelThirdPerson#���  $��Center=��� $��4��$��0��$��10, 0, 0, 0q�$��DemiBold"�$
��12pt(�  LabelFourthPerson#���  $��Center=��� $��5��$��0��$��10, 0, 0, 0q�$��DemiBold"�$
��12pt(�  LabelFifthPerson#���  $��Center=��� $��6��$��0��$��10, 0, 0, 0q�$��DemiBold"�$
��12pt(�  LabelSixthPerson#���  $��Center=��� -   $	 PPS��$��1��$��1��$��25��$��10, 0, 10, 0q�$��Center=�$
��12pt(��� -   $	 DPS��$��2��$��1��$��25��$��10, 0, 10, 0q�$��Center=�$
��12pt(��� -   $	 TPS��$��3��$��1                  ��$��25��$��10, 0, 10, 0q�$��Center=�$
��12pt(��� -   $	 PPP��$��4��$��1��$��25��$��10, 0, 10, 0q�$��Center=�$
��12pt(��� -   $	 DPP��$��5��$��1��$��25��$��10, 0, 10, 0q�$��Center=�$
��12pt(��� -   $	 TPP��$��6��$��1��$��25��$��10, 0, 10, 0q�$��Center=�$
��12pt(�� $��7��$��2�� �� $��* ��� $��* �.+��� -	    ��Name$ AddVerb_Button��$��0�� 	 ButtonAddVerb#��� 	 �� -
   $��1�� 
 ButtonResetVerb#��� 
 