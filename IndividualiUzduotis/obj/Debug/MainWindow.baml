   M S B A M L   `   `   `  ����N  JIndividualiUzduotis, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:IndividualiUzduotisIndividualiUzduotis  5   	   $    IndividualiUzduotis.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:IndividualiUzduotis     5   	     � Title$  Chain Analyser��5   	   $��778.833��6    $
��1035��61   .��5	      �  � ColumnDefinitions 5
   
   �� 5      .+�5   
   o� $��20��6   $	��Top=�6   .@�5      m� $
��File��6   .@�5      m� -   5        $��Import JSON Scan��5      65   m� 5      -   5        $
��Exit��5      6)   5      m� 5      $��Analysis��6   .@�5      m� -   5        $��Analyse Blockchain��5      67   5      m� 5      $
��Help��6   .@�5      m� -   5        $��	View Help��5      6.   5      5      �� 5   
   $��20��6   $��Bottom=�6    .@�5      �� $
��Wrap=�6   $N��H(C) Tomas Vanagas ISKS7    //    Vilniaus Universitetas Kauno fakultetas��6,   5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��blockchainDataGrid��5      $��10,53,10,25q�6-    � 	Resources 5      )  #System.Windows.Controls.DataGridRow �� 
TargetType��%E   '        �� 5      "  6   .�5      -   5        5       5!      5"      �� 5#   
   -   5        $
��Find��5#      $
��Left=�6    $��
941,25,0,0q�6;   $	��Top=�6O   $��76��6g   6r   �� 5$   
   -   5        $��
SearchText��5$      $
��Left=�6$   $��23��6?   $��
816,25,0,0q�6K    �� TextWrapping$
 Wrap=�6_   $��Search Text��6s   $	��Top=�6�   $	��120��6�   �� 5%   
   $(��"Interesting Blocks: 316401, 365977��6   $
��Left=�6=   $��	10,25,0,0q�6X   $	��Top=�6k   5&      5'      