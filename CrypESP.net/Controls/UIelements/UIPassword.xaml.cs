using System;
using System.Collections.Generic;
using System.IO;
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

namespace CrypESP.net.Controls.UIelements
{
    /// <summary>
    /// Логика взаимодействия для UIPassword.xaml
    /// </summary>
    public partial class UIPassword : UserControl
    {
        string[] s = new string[] { " " };
        BinaryFormatterLib formatterLib = new BinaryFormatterLib();
        Data data = new Data();
        public UIPassword()
        {
            InitializeComponent();
        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (Clipboard.ContainsText() == false)
                    return;
                Clipboard.SetText(TextBoxPass.Text);
            }
            catch (Exception)
            {

                ControlsLib.ERROR("Clipboard ERROR!");
            }
            
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (data == null)
            {
                ControlsLib.ERROR("Data NULL!");
                return;
            }
            data.URL = BoxURL.Text;
            data.PASSWORD = BoxPassw.Text;

            if (data.PASSWORD_save.Trim().Length < 1)
                return;
            formatterLib.Name = $"{str.Replace(data.URL, new string[] { "\\" , "/" , ":" , ";" } , "_")}.dat" ;
            formatterLib.Serialize(data);

        }

        private void BoxPassw_TextChanged(object sender, TextChangedEventArgs e)
        {
            int index_last = BoxPassw.CaretIndex;
            if (!str.IsStr(BoxPassw.Text, s))
            {
                BoxPassw.Text = str.Replace(BoxPassw.Text.Trim(), s);
                BoxPassw.CaretIndex = index_last;
            }
        }

        private void BoxURL_TextChanged(object sender, TextChangedEventArgs e)
        {
            int index_last = BoxURL.CaretIndex;
            if (!str.IsStr(BoxURL.Text, s))
            {
                BoxURL.Text = str.Replace(BoxURL.Text.Trim(), s);
                BoxURL.CaretIndex = index_last;
                
            }


        }

        private void UserControl_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(System.Windows.DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(System.Windows.DataFormats.FileDrop);
                if (!File.Exists(files[0]))
                    return;
                Data data = (Data)formatterLib.Deserialize(files[0]);

                if (data == null)
                {
                    ControlsLib.ERROR("Data NULL!");
                    return;
                       
                }
                    
                

                BoxURL.Text = data.URL;
                BoxPassw.Text = data.PASSWORD;
                TextBoxPass.Text = data.PASSWORD_save;
            }
        }

        private void Border_MouseDown_1(object sender, MouseButtonEventArgs e)
        {

            TextBoxPass.Text = data.PASSWORD_save = PasswordLib.GeneretedNewPass(BoxURL.Text, BoxPassw.Text);
            
        }
    }
}
