   M S B A M L   `   `   `  ����A  =Examen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ExamenExamen  5   	       Examen.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Examen     5   	     � Title$  Гостиница��5	   	   $	��450��6   $	��800��6(    � Icon$! /гостиница (1).ico��64   ���	#FFF4E8D3.��5      �  � ColumnDefinitions 5   
   �� 5      $	��51* �6   �� 5      $
��749* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   $��10,10,10,10q�6;   $��2��6P   .+�5      �� $��/гостиница.png��6   $	��100��6,   $��50��68   �� 5      $#��Список клиентов��6   $��18(�5      $
��Bold"�6&   $	��214��68   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ ClientsDataGrid��5       $��1��6      AutoGenerateColumns$ False��69   $��10,10,10,84q�6U   $��2��6j      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn   Header$ Фамилия��6%   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 66   �� *
Familiya+  5!      $ Имя��6%   	 62   �� *Imya+  5"      $ Отчество��6%   	 67   �� *	Otchestvo+5$      �� 5&   
   -   5        $-��'Редактировать данные��5&      $
��Bold"�5'      ���#67BA80$��1��5)   .   $��571,312,10,15q�6>   $��1��6U   �� 5,   
   -   5        $5��/Добавить данные в таблицу��5,      $
��Bold"�5-      ���#67BA80$��1��5/   &   $��359,312,197,15q�66   $��1��6N   51      52      