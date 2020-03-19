using Logbook.View;
using Logbook.View.Interface;
using System;

namespace Logbook.Model
{
    public class MainPresenter
    {
        private readonly IForm view;
        public MainPresenter(IForm view)
        {
            this.view = view;
            view.Adding += View_Adding;
        }

        private void View_Adding(object sender, EventArgs e)
        {
            int num = default;
            view.Panel.Controls.Add(new HeadControl());
            view.Panel.Controls.Add(new StudentControl(++num, "Haciyev Ebdul Hormet"));
            view.Panel.Controls.Add(new StudentControl(++num, "Aliyev Kamran Cemsid"));
            view.Panel.Controls.Add(new StudentControl(++num, "Heydarov Farid Alizamin"));
            view.Panel.Controls.Add(new StudentControl(++num, "Hesenov Elvin Cebrayil"));
            view.Panel.Controls.Add(new StudentControl(++num, "Hesenov Ramiz Azer"));
            view.Panel.Controls.Add(new StudentControl(++num, "İbisov Suleyman Neriman"));
            view.Panel.Controls.Add(new StudentControl(++num, "Haci Ismayilov Vasif"));
            view.Panel.Controls.Add(new StudentControl(++num, "Memmedova Vusale Rafiq"));
        }
    }
}
