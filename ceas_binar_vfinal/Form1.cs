namespace ceas_binar_vfinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DateTime now;
        private void Form1_Load_1(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            oracurenta.Text = DateTime.Now.ToString();
            now = DateTime.Now;
            ceas(now);
        }
        private void ceas(DateTime x)
        {
            //ora 
            int h, h1, h2;
            h = now.Hour;
            h2 = h % 10;
            h /= 10;
            h1 = h % 10;
            //prima cifra a orei
            int a = 0, b = 0, c = 0, d = 0;
            if (h1 == 1)
            {
                a = 0; b = 0; c = 0; d = 1;
            }
            if (h1 == 2)
            {
                a = 0; b = 0; c = 1; d = 0;
            }
            ch1_1.Text = a.ToString();
            ch1_2.Text = b.ToString();
            ch1_3.Text = c.ToString();
            ch1_4.Text = d.ToString();
            //a doua cifra a orei
            a = 0; b = 0; c = 0;
            if (h2 == 0)
            {
                a = 0; b = 0; c = 0; d = 0;
            }
            if (h2 == 1)
            {
                a = 0; b = 0; c = 0; d = 1;
            }
            if (h2 == 2)
            {
                a = 0; b = 0; c = 1; d = 0;
            }
            if (h2 == 3)
            {
                a = 0; b = 0; c = 1; d = 1;
            }
            if (h2 == 4)
            {
                a = 0; b = 1; c = 0; d = 0;
            }
            if (h2 == 5)
            {
                a = 0; b = 1; c = 0; d = 1;
            }
            if (h2 == 6)
            {
                a = 0; b = 1; c = 1; d = 0;
            }
            if (h2 == 7)
            {
                a = 0; b = 1; c = 1; d = 1;
            }
            if (h2 == 8)
            {
                a = 1; b = 0; c = 0; d = 0;
            }
            if (h2 == 9)
            {
                a = 1; b = 0; c = 0; d = 1;
            }
            ch2_1.Text = a.ToString();
            ch2_2.Text = b.ToString();
            ch2_3.Text = c.ToString();
            ch2_4.Text = d.ToString();
            //minut
            int m, m1, m2;
            m = now.Minute;
            m2 = m % 10;
            m /= 10;
            m1 = m % 10;
            //prima cifra a minutului
            a = 0; b = 0; c = 0; d = 0;
            if (m1 == 0)
            {
                a = 0; b = 0; c = 0; d = 0;
            }
            if (m1 == 1)
            {
                a = 0; b = 0; c = 0; d = 1;
            }
            if (m1 == 2)
            {
                a = 0; b = 0; c = 1; d = 0;
            }
            if (m1 == 3)
            {
                a = 0; b = 0; c = 1; d = 1;
            }
            if (m1 == 4)
            {
                a = 0; b = 1; c = 0; d = 0;
            }
            if (m1 == 5)
            {
                a = 0; b = 1; c = 0; d = 1;
            }
            cm1_1.Text = a.ToString();
            cm1_2.Text = b.ToString();
            cm1_3.Text = c.ToString();
            cm1_4.Text = d.ToString();
            //a doua cifra a minutului
            a = 0; b = 0; c = 0;
            if (m2 == 0)
            {
                a = 0; b = 0; c = 0; d = 0;
            }
            if (m2 == 1)
            {
                a = 0; b = 0; c = 0; d = 1;
            }
            if (m2 == 2)
            {
                a = 0; b = 0; c = 1; d = 0;
            }
            if (m2 == 3)
            {
                a = 0; b = 0; c = 1; d = 1;
            }
            if (m2 == 4)
            {
                a = 0; b = 1; c = 0; d = 0;
            }
            if (m2 == 5)
            {
                a = 0; b = 1; c = 0; d = 1;
            }
            if (m2 == 6)
            {
                a = 0; b = 1; c = 1; d = 0;
            }
            if (m2 == 7)
            {
                a = 0; b = 1; c = 1; d = 1;
            }
            if (m2 == 8)
            {
                a = 1; b = 0; c = 0; d = 0;
            }
            if (m2 == 9)
            {
                a = 1; b = 0; c = 0; d = 1;
            }
            cm2_1.Text = a.ToString();
            cm2_2.Text = b.ToString();
            cm2_3.Text = c.ToString();
            cm2_4.Text = d.ToString();
            int s, s1, s2;
            s = now.Second;
            s2 = s % 10;
            s /= 10;
            s1 = s % 10;
            //prima cifra a secundei 
            a = 0; b = 0; c = 0; d = 0;
            if (s1 == 0)
            {
                a = 0; b = 0; c = 0; d = 0;
            }
            if (s1 == 1)
            {
                a = 0; b = 0; c = 0; d = 1;
            }
            if (s1 == 2)
            {
                a = 0; b = 0; c = 1; d = 0;
            }
            if (s1 == 3)
            {
                a = 0; b = 0; c = 1; d = 1;
            }
            if (s1 == 4)
            {
                a = 0; b = 1; c = 0; d = 0;
            }
            if (s1 == 5)
            {
                a = 0; b = 1; c = 0; d = 1;
            }
            cs1_1.Text = a.ToString();
            cs1_2.Text = b.ToString();
            cs1_3.Text = c.ToString();
            cs1_4.Text = d.ToString();
            //a doua cifra a secundei
            a = 0; b = 0; c = 0; d = 0;
            if (s2 == 0)
            {
                a = 0; b = 0; c = 0; d = 0;
            }
            if (s2 == 1)
            {
                a = 0; b = 0; c = 0; d = 1;
            }
            if (s2 == 2)
            {
                a = 0; b = 0; c = 1; d = 0;
            }
            if (s2 == 3)
            {
                a = 0; b = 0; c = 1; d = 1;
            }
            if (s2 == 4)
            {
                a = 0; b = 1; c = 0; d = 0;
            }
            if (s2 == 5)
            {
                a = 0; b = 1; c = 0; d = 1;
            }
            if (s2 == 6)
            {
                a = 0; b = 1; c = 1; d = 0;
            }
            if (s2 == 7)
            {
                a = 0; b = 1; c = 1; d = 1;
            }
            if (s2 == 8)
            {
                a = 1; b = 0; c = 0; d = 0;
            }
            if (s2 == 9)
            {
                a = 1; b = 0; c = 0; d = 1;
            }
            cs2_1.Text = a.ToString();
            cs2_2.Text = b.ToString();
            cs2_3.Text = c.ToString();
            cs2_4.Text = d.ToString();
        }
    }
}