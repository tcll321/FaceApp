   M S B A M L   `   `   `  ���� B  >FaceApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:FaceAppFaceApp      FaceApp.TimeCtrl   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     'localclr-namespace:FaceApp     ���#202342  J� OpacityMask
  �����.���  � RowDefinitions �� $	��50* ��� $	��50* � � ColumnDefinitions �� $	��20* ��� $	��50* �.+��� -    ��Name$ 	labelTime��$��	时间：��$��15(�$��0��$��1��$
��Left=�
�������$	��Top=�$��	10,13,0,0q��� -    ��Name$ 	imageTime��$��Resources/Time_Image.png��$
��Left=�$��45��$��	36,20,0,0q�$	��Top=�$��50���� -   $ imageAsk��$��Resources/Visit_Image.png��$
��Left=�$��45��$��	36,10,0,0q�$��1��$	��Top=�$��50���� -   $ labelAsk��$��今日来访：��$��15(�$��1��$
��Left=�
�������$��	10,10,0,0q�$��1��$	��Top=��� -    ��Name$ textBlockTime��$��15(�$��1��$
��Left=�$��	16,43,0,0q�$
��Wrap=�
�������$	��Top=�$	��188������ *TimeCtrl.CurTime+�� -   $ textBlockAskCount��$��15(�$��1��$
��Left=�$��	16,40,0,0q�$
��Wrap=�
�������$	��Top=�$	��188��$��1������ *TimeCtrl.AskCount+