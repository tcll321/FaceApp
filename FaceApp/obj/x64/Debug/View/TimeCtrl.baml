   M S B A M L   `   `   `  ����B  >FaceApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:FaceAppFaceApp  5          FaceApp.TimeCtrl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:FaceApp     5      ���#202342  J� OpacityMask
  �����.��5      �  � RowDefinitions 5   
   �� 5      $	��50* �6   �� 5      $	��50* �6    � ColumnDefinitions 5   
   �� 5      $	��20* �6   �� 5      $	��50* �6   .+�5   
   �� -   5         ��Name$ 	labelTime��5      $��	时间：��6#   $��15(�61   $��0��6I   $��1��6V   $
��Left=�6f   
�������$	��Top=�6�   $��	10,13,0,0q�6�   �� 5   
   -   5         ��Name$ 	imageTime��5      $��Resources/Time_Image.png��6#   $
��Left=�6E   $��45��6`   $��	36,20,0,0q�6l   $	��Top=�6   $��50��6�   �� 5   
   -   5        $ imageAsk��5      $��Resources/Visit_Image.png��6"   $
��Left=�6E   $��45��6`   $��	36,10,0,0q�6l   $��1��6   $	��Top=�6�   $��50��6�   �� 5   
   -   5        $ labelAsk��5      $��今日来访：��6"   $��15(�62   $��1��6J   $
��Left=�6Z   
�������$��	10,10,0,0q�6�   $��1��6�   $	��Top=�6�   �� 5   
   -   5         ��Name$ textBlockTime��5      $��15(�6+   $��1��6C   $
��Left=�6S   $��	16,43,0,0q�6n   $
��Wrap=�6�   
�������$	��Top=�6�   $	��188��6�   ��6�   �� *TimeCtrl.CurTime+6�   �� 5   
   -   5        $ textBlockAskCount��5      $��15(�6/   $��1��6G   $
��Left=�6W   $��	16,40,0,0q�6r   $
��Wrap=�6�   
�������$	��Top=�6�   $	��188��6�   $��1��6�   ��6�   �� *TimeCtrl.AskCount+6�   5      5      