   M S B A M L   `   `   `  ����B  >FaceApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:FaceAppFaceApp  5   	       FaceApp.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:FaceApp     5   	     � Title$  
MainWindow��5   	   $	��700��6   $
��1100��6)    � WindowStyle$ 
ToolWindow=�5	   	    � WindowState$ 	Maximized=�6"   ���#0F132E.��5      �  � RowDefinitions 5   
   �� 5      $��64 �6   �� 5      $
��Auto �6   .+�5   
      FaceApp.MainMenuCtl  $��64��6   $��0��6(      FaceApp.TimeCtrl  5   
   $	��150��6   $	��300��6&   $��19,29,773,435q�62   $��1��6I    � DataContext 6V   �� *
TimeOper+   FaceApp.StatisticsCtrl  5   
   $	��150��6   $	��300��6,   $��19,199,773,265q�68   $��1��6P    6]   �� *
StatOper+   FaceApp.VideoCtrl  5   
   $	��430��6   $	��320��6&   $��1��63   
���   �$��329,29,333,265q�6u    6S   �� *	VideoOper+6u      FaceApp.FaceCtrl  5   
   $	��200��6   $	��180��6&   $��19,369,893,45q�62   $��1��6I    6V   �� *FaceOper.FaceObjOne+  5   
   $	��200��6   $	��180��6&   $��207,369,705,45q�62   $��1��6J    6W   �� *FaceOper.FaceObjTwo+  5   
   $	��200��6   $	��180��6&   $��395,369,517,45q�62   $��1��6J    6W   �� *FaceOper.FaceObjThree+  5   
   $	��200��6   $	��180��6&   $��584,369,328,45q�62   $��1��6J    6W   �� *FaceOper.FaceObjFour+   FaceApp.MapCtrl  5   
   $	��300��6   $	��540��6$   $��1��61   
���   �$��773,29,19,45q�6Q   5      5      