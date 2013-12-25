using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.Text;

namespace NeurologicTest
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            const int size = 459;
            StringBuilder sb = new StringBuilder(size);
            Random r = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < size; ++i)
            {
                sb.Append('O');
            }
            sb[r.Next(10, sb.Length - 10)] = 'C';
            
            this.tb_findc.Text = sb.ToString();
            //sb = new StringBuilder(size);
            for (int i = 0; i < sb.Length; ++i)
            {
                sb[i] = '9';
                //sb.Append('9');
            }

            sb.Length -= 3;
            sb[r.Next(10, sb.Length - 10)] = '6';


            this.tb_find6.Text = sb.ToString();
            //sb = new StringBuilder(size);
            for (int i = 0; i < sb.Length; ++i)
            {
                sb[i] = 'M';
                //sb.Append('M');
            }
            sb.Length -= 42;
            sb[r.Next(10, sb.Length - 10)] = 'N';

            this.tb_findn.Text = sb.ToString();
        }
    }
}