   M S B A M L   `   `   `  ����N  JIndividualiUzduotis, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:IndividualiUzduotisIndividualiUzduotis  5   	   -    'IndividualiUzduotis.ChainAnalysisWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:IndividualiUzduotis     5   	   -   5          � Title$  Chain Analysis��5   	   $��341.76��6    $��616.43��60   .��5	      �  � ColumnDefinitions 5
   
   �� 5      .+�5   
   o� $��20��6   $	��Top=�6   .@�5      m� $
��File��6   .@�5      m� -   5        $
��Exit��5      6)   5      m� 5      $
��Help��6   .@�5      m� -   5        $��Help Analysing Chain��5      69   5      5      � 5   
   -   5        $��AnalysisProgressBar��5      $��
10,0,10,35q�61   $��30��6E   $��Bottom=�6Q   �� 5   
   -   5        $��blockchainPath��5      $��
10,51,90,0q�6(    �� TextWrapping$
 Wrap=�6<   $��%APPDATA%\Bitcoin\blocks��6P   $��20��6p   $	��Top=�6|   �� 5   
   $��Blockchain path: ��6   $
��Left=�6,   $��	10,25,0,0q�6G   $	��Top=�6Z   $��26��6r   $	��100��6~   �� 5   
   -   5        $��Browse��5      $��Right=�6"   $��	0,51,10,0q�6>   $	��Top=�6Q   $��75��6i   $��20��6�   �� 5   
   -   5        $��StartAnalysisButton��5      $��Start Analysis��6,   $��
10,0,10,10q�6E   $��20��6u   $��Bottom=�6�   �� 5   
   $��	Resources��6   $��10,127,10,70q�6&   .��5      � .+�5      �� $,��&Maximum amount spent in single output:��6   $
��Left=�6I   $��	10,10,0,0q�6d   $	��Top=�6w   �� 5      -   5        $��
maxOutputs��5      $
��Left=�6,   $��23��6G   $��
300,13,0,0q�6S   $
 Wrap=�6g   $
��5500��6{   $	��Top=�6�   $	��120��6�   5      5      �� 5    
   -	   5         ��Name$ jsonPath��5       $��10,102,90,0q�6$   $
 Wrap=�69   $��Analysis.txt��6M   $��20��6a   $	��Top=�6m   �� 5!   
   $��Save Output JSON path: ��6   $
��Left=�62   $��	10,76,0,0q�6M   $	��Top=�6`   $��26��6x   �� 5"   
   -
   5        $��Browse��5"      $��Right=�6"   $��
0,102,10,0q�6>   $	��Top=�6R   $��75��6j   $��20��6�   5$      5%      