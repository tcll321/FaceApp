   M S B A M L   `   `   `  ����B  >FaceApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:FaceAppFaceApp  5          FaceApp.StatisticsCtrl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:FaceApp     5      ���#2B86F9.��5
      � 
���������5   
   �� 5        �� ImageSource$$  Resources/Statistics_Image.png��6    j� Stretch$ UniformToFill=�6F   .+�5   
   �� -   5         ��Name$ labelStatistics��5      $��今日行为统计：��6)   $��15(�6;   $��微软雅黑)�6S   
�������$
��Left=�6�   $��32,8,0,0q�6�   $	��Top=�6�   �� 5   
   -   5        $ labelHandle��5      $��	打招呼��6%   $��13(�63   $��微软雅黑)�6K   
�������$
��Left=�6�   $��	66,50,0,0q�6�   $	��Top=�6�   �� 5   
   -   5        $ labelHandleCount��5      $��(次)��6*   $��10(�68   $��微软雅黑)�6P   
�������$
��Left=�6�   $��119,104,0,0q�6�   $	��Top=�6�   $��27��6�   �� 5   
   -   5        $ 	labelFall��5      $��欢迎��6#   $��13(�60   $��微软雅黑)�6H   
�������$
��Left=�6�   $��
183,50,0,0q�6�   $	��Top=�6�   �� 5   
   -   5        $ labelFallCount��5      $��(次)��6(   $��10(�66   $��微软雅黑)�6N   
�������$
��Left=�6�   $��234,104,0,0q�6�   $	��Top=�6�   $��27��6�   �� 5   
   -   5         ��Name$ 
textHandle��5       �� 
IsReadOnly . 
������ $��Center=�6Q   
�������$��25(�6�   $��0q�6�   $
��Bold"�6�   $��Center=�6�   $��66,77,178,23q�6   �� TextAlignment$ Center=�62  $��Center=�6I  $��60��6d  $��50��6o  ��6�   �� *StatCtrl.PutHandCount+6o  �� 5   
   -   5        $ textFall��5       . 
������ $��Center=�6O   
�������$��25(�6�   $��0q�6�   $
��Bold"�6�   $��Center=�6�   $��179,76,71,24q�6   �� TextWrapping$
 Wrap=�6.  $ Center=�6C  $��Center=�6Z  $��60��6u  $��50��6�  ��6�   �� *StatCtrl.PunchCount+6�  5      5      