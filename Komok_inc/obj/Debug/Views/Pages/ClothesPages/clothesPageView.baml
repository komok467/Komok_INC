   M S B A M L   `   `   `  ����D  @Komok_inc, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:Komok_inc.Views.Pages.ClothesPages"Komok_inc.Views.Pages.ClothesPages  5      8    2Komok_inc.Views.Pages.ClothesPages.clothesPageView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Blocal0clr-namespace:Komok_inc.Views.Pages.ClothesPages     5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
      -   5          N� Title$  clothesPageView��5	         MaterialDesignBody#���   5      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��0.2* �6   �� 5      $��* �6   �� 5      $
��0.2* �6   .+�5   
   � $��0��6   $��0��6   .+�5       �� $��Center=�6   $��5,17,5,13.6q�5!      .+�5"      �� -   5         ��Name$ 	txtSearch��5"      $	��350��5#      $
��Left=�5$      $��15q�5%      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Поиск��5&       % !MaterialDesignFloatingHintTextBox#��[ 5(      5)      5*      � 5+   
   $��0��6   $��1��6   .+�5,      �� 	 �� Orientation$	 
Horizontal=�6   $��Center=�5-      .+�5.      (  "System.Windows.Controls.DatePicker  -   5        
  Name$
 searchInDate��5.      $	��250��5/      $% Дата поступления��50       ( $MaterialDesignFloatingHintDatePicker#��[ 51      �� 52      -   5         ��Name$ buttonSearch��52      $��15q�53      $��Применить��54      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��55      56      �� 57      -   5        $ buttonExport��57      $��Выгрузить��6/   $	��118��6C   $��34��6O   $ 15��6[   58      59      5:      � 5;   
   $��1��6   $��2��6   .+�5<      &   System.Windows.Controls.DataGrid  -   5          Name$ clothesDataView��5<         AutoGenerateColumns .  $��5q�5>         Columns 5?      0  *System.Windows.Controls.DataGridTextColumn  5@      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$
 0.5* 6L   1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding 65   �� *ID+6L     5A      $ Название��6)   $ * 6U    6;   �� *Title+6U     5B      $ Размер��6)   $ * 6R    69   �� *Size+6R     5C      $ Состав��6)   $ * 6W    69   �� *	Structure+6W     5D      $ 
Сезон��6)   $ * 6R    68   �� *Style+6R     5E      $ Страна��6)   $ * 6U    69   �� *	Country+6U     5F      $ 
Бренд��6)   $ * 6R    68   �� *Brend+6R     5G      $ Цена��6)   $ * 6Q    67   �� *Price+6Q     5H      $ Дата��6)   $ * 6P    67   �� *Date+6P     5I      $ Категория��6)   $ * 6Y    6<   �� *
Category+6Y     5J      $ Пол��6)   $ * 6Q    66   �� *Gender+6Q     5K      $ Поставщик��6)   $ * 6^    6<   �� *ProviderTitle+6^   4
  .System.Windows.Controls.DataGridTemplateColumn
  5M      $ Вид��6-   $ * 6:    
  CellTemplate 5N      �� 5O      .R�5P   "   �� ��6(   �� *Photo+5Q      5S      5U      5V      � 5X   
   $��2��6   $��2��6   .+�5Y      �� $	 
Horizontal=�6   $��Center=�5Z      $��Center=�5[      .+�5\      �� -   5        $ 
buttonBack��5\      $��
Назад��5]      $��5q�5^      $ 15��5_      $	��250��5`      5a      �� 5b      -   5        $ buttonCreate��5b      $��Создать��5c      $��5q�5d      $ 15��5e      $	��250��5f      5g      �� 5i      -	   5        $ 
buttonEdit��5i      $ ��Редактировать��5j      $��5q�5k      $ 15��5l      $	��250��5m      5n      �� 5p      -
   5        $ buttonRemove��5p      $��Удалить��5q      $��5q�5r      $ 15��5s      $	��250��5t      5u      5v      5w      5x      5y      