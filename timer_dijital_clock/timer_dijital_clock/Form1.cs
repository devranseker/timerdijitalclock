
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer_dijital_clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int clock = 0, minites = 0, seconds = 0;
        // timer1 , label1 == saniye (seconds)
        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            label1.Text = seconds.ToString();
            if (seconds == 60)
            {
                minites++;
                label2.Text = minites.ToString();
                seconds = 0;
                if (minites == 5)
                {
                    clock = clock + 1;
                    label3.Text = clock.ToString();
                    minites = 0;


                }
            }
            // normalde 60 ama biz o kadar bekleyemeyiz 
          
        }
        

    }
}