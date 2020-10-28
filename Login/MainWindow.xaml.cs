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

namespace Login
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_OnMouseDown(object sender, MouseButtonEventArgs e) 
        {

        if(e.LeftButton == MouseButtonState.Pressed) 
            {
                DragMove();
            }

        }
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }



        private void textBox_1_Enter(object sender, EventArgs e)

        {

            if (!string.IsNullOrEmpty(username.Text.Trim()))

            {

                username.Text = "";

            }
            

        }


        private void textBox__Enter(object sender, EventArgs e)

        {

            if (string.IsNullOrEmpty(username.Text))

            {

                username.Text = "Username";

            }



        }

        private void PWBox_1_Enter(object sender, EventArgs e)

        {

            if (!string.IsNullOrEmpty(pwBox.Password.Trim()) )

            {

                pwBox.Password = "";

            }


        }


        private void PWWBox__Enter(object sender, EventArgs e)

        {

            if (string.IsNullOrEmpty(pwBox.Password))

            {

                pwBox.Password = "Username";

            }



        }

        private void Login_Click(object sender, RoutedEventArgs e) 
        {
            if(pwBox.Password=="Password123" && username.Text=="Staff")
            {
                var newWindow = new DashBoard();
                newWindow.Show();
                this.Close();
            }
            else 
            {
                var newWindow = new Error();
                newWindow.Show();
                this.Close();
            }
        }
    }
}
