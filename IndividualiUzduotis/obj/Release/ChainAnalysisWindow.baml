   M S B A M L   `   `   `  ���� N  JIndividualiUzduotis, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:IndividualiUzduotisIndividualiUzduotis  -    'IndividualiUzduotis.ChainAnalysisWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     3local!clr-namespace:IndividualiUzduotis     -     � Title$  Chain Analysis��$��341.76��$��616.43��.���  � ColumnDefinitions �� .+�o� $��20��$	��Top=�.@�m� $
��File��.@�m� -   $
��Exit��m� $
��Help��.@�m� -   $��Help Analysing Chain��� -   $��AnalysisProgressBar��$��
10,0,10,35q�$��30��$��Bottom=��� -   $��blockchainPath��$��
10,51,90,0q� �� TextWrapping$
 Wrap=�$��%APPDATA%\Bitcoin\blocks��$��20��$	��Top=��� $��Blockchain path: ��$
��Left=�$��	10,25,0,0q�$	��Top=�$��26��$	��100���� -   $��Browse��$��Right=�$��	0,51,10,0q�$	��Top=�$��75��$��20���� -   $��StartAnalysisButton��$��Start Analysis��$��
10,0,10,10q�$��20��$��Bottom=��� $��	Resources��$��10,127,10,70q�.��� .+��� $,��&Maximum amount spent in single output:��$
��Left=�$��	10,10,0,0q�$	��Top=��� -   $��
maxOutputs��$
��Left=�$��23��$��
300,13,0,0q�$
 Wrap=�$
��5500��$	��Top=�$	��120���� -	    ��Name$ jsonPath��$��10,102,90,0q�$
 Wrap=�$��Analysis.txt��$��20��$	��Top=��� $��Save Output JSON path: ��$
��Left=�$��	10,76,0,0q�$	��Top=�$��26���� -
   $��Browse��$��Right=�$��
0,102,10,0q�$	��Top=�$��75��$��20��