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
using System.IO;

namespace WpfExamplePaint
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        enum Modes
        {
            inkMode,
            eraseMode,
            selectionMode
        }
        Modes mode;
        public MainWindow()
        {
            InitializeComponent();

            InitializeApp();
        }

        private void InitializeApp()
        {
            this.inkPaint.EditingMode = InkCanvasEditingMode.Ink;
            this.inkPaint.DefaultDrawingAttributes.Color = Colors.Black;
            this.combobox.SelectedIndex = 0;
            mode = Modes.inkMode;
            
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(mode==Modes.inkMode)
            switch (combobox.SelectedIndex)
            {
                case 0:
                    inkPaint.DefaultDrawingAttributes.Color = Colors.Black;
                    break;
                case 1:
                    inkPaint.DefaultDrawingAttributes.Color = Colors.Red;
                    break;
                case 2:
                    inkPaint.DefaultDrawingAttributes.Color = Colors.DarkGreen;
                    break;
                case 3:
                    inkPaint.DefaultDrawingAttributes.Color = Colors.Blue;
                    break;
            }


        }


        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            mode = Modes.inkMode;
            this.inkPaint.EditingMode = InkCanvasEditingMode.Ink;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            mode = Modes.eraseMode;
            this.inkPaint.EditingMode = InkCanvasEditingMode.EraseByPoint;
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            mode = Modes.selectionMode;
            inkPaint.EditingMode = InkCanvasEditingMode.Select;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
