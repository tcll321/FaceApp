   M S B A M L   `   `   `  ���� B  >FaceApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:FaceAppFaceApp      FaceApp.StatisticsCtrl   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     'localclr-namespace:FaceApp     ���#2B86F9.��� 
�����������   �� ImageSource$$  Resources/Statistics_Image.png�� j� Stretch$ UniformToFill=�.+��� -    ��Name$ labelStatistics��$��今日行为统计：��$��15(�$��微软雅黑)�
�������$
��Left=�$��32,8,0,0q�$	��Top=��� -   $ labelHandle��$��	打招呼��$��13(�$��微软雅黑)�
�������$
��Left=�$��	66,50,0,0q�$	��Top=��� -   $ labelHandleCount��$��(次)��$��10(�$��微软雅黑)�
�������$
��Left=�$��119,104,0,0q�$	��Top=�$��27���� -   $ 	labelFall��$��欢迎��$��13(�$��微软雅黑)�
�������$
��Left=�$��
183,50,0,0q�$	��Top=��� -   $ labelFallCount��$��(次)��$��10(�$��微软雅黑)�
�������$
��Left=�$��234,104,0,0q�$	��Top=�$��27���� -    ��Name$ 
textHandle�� �� 
IsReadOnly . 
������ $��Center=�
�������$��25(�$��0q�$
��Bold"�$��Center=�$��66,77,178,23q� �� TextAlignment$ Center=�$��Center=�$��60��$��50������ *StatCtrl.PutHandCount+�� -   $ textFall�� . 
������ $��Center=�
�������$��25(�$��0q�$
��Bold"�$��Center=�$��179,76,71,24q� �� TextWrapping$
 Wrap=�$ Center=�$��Center=�$��60��$��50������ *StatCtrl.PunchCount+