   M S B A M L   `   `   `  ����J  FImageToNegative, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ImageToNegativeImageToNegative  5   	        ImageToNegative.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:ImageToNegative     5   	   -   5          �Name$  
MainWIndow��5   	    � Title$ 
MainWindow��5   	   $	��450��6   $	��800��6)    � WindowStartupLocation$ CenterScreen=�65    � WindowStyle$
 None=�6Z   .��5      ]� .+�5   
   o� $	��Top=�6   .@�5      m� $��_File��6   .@�5      m� -   5         m�Name$ miOpen��5      $
��Open��6+   69   m� 5      -   5        $ 
miChangeTo��5      $��Change Image to��6/   .@�5      m� -   5        $ miBinary��5      $��Binary��61   6A   m� 5      -   5        $ miGrayscaled��5      $��
Grayscaled��65   6I   m� 5      -   5        $ 
miNegative��5      $��Negative��63   6E   m� 5      -   5        $ miRed��5      $	��Red��6.   6;   m� 5      -   5        $ miGreen��5      $��Green��60   6?   m� 5      -	   5        $ miBlue��5      $
��Blue��6/   6=   5      m� 5      $��
Mirroring ��6   .@�5      m� -
   5        $ miRightMirroring��5      $��Right mirroring��69   6R   m� 5      -   5        $ miLeftMirroring��5      $��Left mirroring��68   6P   5      m� 5      -   5        $ miSaveAs��5      $��_Save as��6-   6?   �� 5      m� 5      -   5        $ miExit��5      $
��Exit��6+   69   5      5       � 5"   
   $��Bottom=�6   $��24��6'   .+�5#      �� -   5         ��Name$ txbImgLocation��5#      $-��'Please choose option from File menu bar��6.    �� 
IsReadOnly$
 True��6]   $��20(�6o   $��	15 -5 0 0q�6}   $	��Top=�6�   5$      �� 5%   
   -   5         ��Name$ imgOriginal��5%      $
��Fill=�6%   5'      5(      