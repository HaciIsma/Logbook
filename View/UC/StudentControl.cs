using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Logbook.View
{
    public partial class StudentControl : UserControl
    {
        Image _1 = Image.FromFile($@"{Directory.GetCurrentDirectory()}\diamond.png");
        Image _2 = Image.FromFile($@"{Directory.GetCurrentDirectory()}\diamond Shadow.png");

        public StudentControl(int id, string fullname)
        {
            InitializeComponent();

            idLabel.Text = id.ToString();
            fullnameLabel.Text = fullname;
        }

        private void pictureBox_Click(object sender, System.EventArgs e)
        {
            PictureBox picture = sender as PictureBox;
            if (picture.Image == _1)
            {
                picture.Image = _2;
            }
            else
            {
                picture.Image = _1;
            }
        }

        private void ClosePic_Click(object sender, System.EventArgs e)
        {
            d1.Image = _2;
            d2.Image = _2;
            d3.Image = _2;
        }

        private void MessagePic_Click(object sender, System.EventArgs e)
        {
            if (messageText.Visible == true)
            {
                messageText.Visible = false;
            }
            else
            {
                messageText.Visible = true;
            }
        }
    }
}
