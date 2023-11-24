using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TextBox tb = new TextBox { Text="Ваше число: " };
        Label lbl = new Label { Content = "результат да/нет" };
        Button btn = new Button() { Content = "Проверить простое или нет" };

        TextBox tb1 = new TextBox { Text = "Введите строчку: " };
        ComboBox cb = new ComboBox();
        Button btn1 = new Button { Content = "посчитать" };

        CheckBox cb1 = new CheckBox() { Content = "цифры" };
        CheckBox cb2 = new CheckBox() { Content = "заглавные латинские буквы" };
        CheckBox cb3 = new CheckBox() { Content = "прописные латинские буквы" };
        CheckBox cb4 = new CheckBox() { Content="спец символы"};
        Button btn2 = new Button { Content = "сгенерировать надежный пароль" };
        Label lbl2 = new Label { Content = "рандомный пароль" };

        TextBox txt3 = new TextBox() {Text="Число один"};
        TextBox txt4 = new TextBox() { Text = "Число два" };
        RadioButton rd1 = new RadioButton { Content = "сумма" };
        RadioButton rd2 = new RadioButton { Content = "разница" };
        RadioButton rd3 = new RadioButton { Content = "умножение" };
        RadioButton rd4 = new RadioButton { Content = "деление" };
        Button btn3 = new Button { Content = "посчитать" };

        TextBox txt5 = new TextBox() { Text = "Первое" };
        TextBox txt6 = new TextBox() { Text = "Второе" };
        TextBox txt7 = new TextBox() { Text = "Третье" };
        TextBox txt8 = new TextBox() { Text = "Четвертое" };
        TextBox txt9 = new TextBox() { Text = "Пятое" };
        TextBox txt10 = new TextBox() { Text = "Шестое" };
        Button btn4 = new Button { Content = "создать массив" };
        Button btn5 = new Button { Content = "сумма элементов" };
        Button btn6 = new Button { Content = "произведение элементов" };
        Button btn7 = new Button { Content = "мин элемент" };
        Button btn8 = new Button { Content = "макс элемент" };
        public MainWindow()
        {

            InitializeComponent();

            Grid mygrid = new Grid();
            mygrid.ShowGridLines = true;
            mygrid.RowDefinitions.Add(new RowDefinition());
            mygrid.RowDefinitions.Add(new RowDefinition());
            mygrid.RowDefinitions.Add(new RowDefinition());
            mygrid.RowDefinitions.Add(new RowDefinition());
            mygrid.RowDefinitions.Add(new RowDefinition());
            mygrid.RowDefinitions.Add(new RowDefinition());
            mygrid.RowDefinitions.Add(new RowDefinition());
            mygrid.RowDefinitions.Add(new RowDefinition());
            mygrid.RowDefinitions.Add(new RowDefinition());
            mygrid.RowDefinitions.Add(new RowDefinition());
            mygrid.ColumnDefinitions.Add(new ColumnDefinition());
            mygrid.ColumnDefinitions.Add(new ColumnDefinition());
            mygrid.ColumnDefinitions.Add(new ColumnDefinition());
            mygrid.ColumnDefinitions.Add(new ColumnDefinition());

            btn.Click += MyButton_click;
            btn.Margin = new Thickness(5);
            tb.Margin = new Thickness(5);
            lbl.Margin = new Thickness(5);

            Grid.SetRow(tb, 0);
            Grid.SetRow(lbl, 0);
            Grid.SetRow(btn, 1);
            Grid.SetColumn(tb, 0);
            Grid.SetColumn(lbl, 1);
            Grid.SetColumn(btn, 0);

            mygrid.Children.Add(tb);
            mygrid.Children.Add(lbl);
            mygrid.Children.Add(btn);

            tb1.Margin = new Thickness(5);
            cb.Margin = new Thickness(5);
            btn1.Margin=new Thickness(5);

            Grid.SetRow(tb1, 2);
            Grid.SetRow(cb, 3);
            Grid.SetRow(btn1, 4);
            Grid.SetColumn(tb1, 0);
            Grid.SetColumn(cb, 0);
            Grid.SetColumn(btn1, 0);

            mygrid.Children.Add(tb1);
            mygrid.Children.Add(cb);
            mygrid.Children.Add(btn1);

            cb1.Margin = new Thickness(7);
            cb2.Margin = new Thickness(7);
            cb3.Margin = new Thickness(7);
            cb4.Margin = new Thickness(7);
            btn2.Margin = new Thickness(7);
            lbl2.Margin=new Thickness(7);

            Grid.SetRow(cb1, 5);
            Grid.SetRow(cb2, 6);
            Grid.SetRow(cb3, 7);
            Grid.SetRow(cb4, 5);
            Grid.SetRow(btn2, 8);
            Grid.SetRow(lbl2, 9);
            Grid.SetColumn(cb1, 0);
            Grid.SetColumn(cb2, 0);
            Grid.SetColumn(cb3, 0);
            Grid.SetColumn(cb4, 1);
            Grid.SetColumn(btn2, 0);
            Grid.SetColumn(lbl2, 0);

            mygrid.Children.Add(cb1);
            mygrid.Children.Add(cb2);
            mygrid.Children.Add(cb3);
            mygrid.Children.Add(cb4);
            mygrid.Children.Add(btn2);
            mygrid.Children.Add(lbl2);

            txt3.Margin = new Thickness(10);
            txt4.Margin = new Thickness(10);
            rd1.Margin = new Thickness(10);
            rd2.Margin = new Thickness(10);
            rd3.Margin = new Thickness(10);
            rd4.Margin = new Thickness(10);
            btn3.Margin = new Thickness(10);

            Grid.SetRow(txt3, 0); Grid.SetColumn(txt3, 2);
            Grid.SetRow(txt4, 0); Grid.SetColumn(txt4, 3);
            Grid.SetRow(rd1, 1); Grid.SetColumn(rd1, 2);
            Grid.SetRow(rd2, 1); Grid.SetColumn(rd2, 3);
            Grid.SetRow(rd3, 2); Grid.SetColumn(rd3, 2);
            Grid.SetRow(rd4, 2); Grid.SetColumn(rd4, 3);
            Grid.SetRow(btn3, 3); Grid.SetColumn(btn3, 2);

            mygrid.Children.Add(txt3);
            mygrid.Children.Add(txt4);
            mygrid.Children.Add(rd1);
            mygrid.Children.Add(rd2);
            mygrid.Children.Add(rd3);
            mygrid.Children.Add(rd4);
            mygrid.Children.Add(btn3);

            this.Content = mygrid;
        }
        private void MyButton_click(object sender,RoutedEventArgs e)
        {

        }
    }
}
