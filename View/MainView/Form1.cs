using MetroFramework.Forms;

namespace Logbook.View
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            int num = default;
            panel.Controls.Add(new HeadControl());
            panel.Controls.Add(new StudentControl(++num, "Aliyev Kamran Cemsid"));
            panel.Controls.Add(new StudentControl(++num, "Haciyev Ebdul Hormet"));
            panel.Controls.Add(new StudentControl(++num, "Heydarov Farid Alizamin"));
            panel.Controls.Add(new StudentControl(++num, "Hesenov Elvin Cebrayil"));
            panel.Controls.Add(new StudentControl(++num, "Hesenov Ramiz Azer"));
            panel.Controls.Add(new StudentControl(++num, "İbisov Suleyman Neriman"));
            panel.Controls.Add(new StudentControl(++num, "Haci Ismayilov Vasif"));
            panel.Controls.Add(new StudentControl(++num, "Memmedova Vusale Rafiq"));
        }
    }
}
