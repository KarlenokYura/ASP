using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_1_b
{
    public partial class _Default : Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            String str = Request["_VIEWSTATE1"];
            Label1.Text = str.ToString() + "[" + str.Length.ToString() + "]";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            String str = Request["_VIEWSTATE2"];
            Label1.Text = str.ToString() + "[" + str.Length.ToString() + "]";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            String str = Request["_VIEWSTATE3"];
            Label1.Text = str.ToString() + "[" + str.Length.ToString() + "]";
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            //создание страницы - 1 раз
            Label3.Text += "-Init-";
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //всегда: 1 раз и при обратной отправке
            if (!Page.IsPostBack)
            {
                Label3.Text += "-LoadA-";
            }
            else
            {
                Label3.Text += "-LoadB-";
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            //обработка событий от элементов управления
            Label3.Text += "-Click-";
        }

        protected void Page_Prerender(object sender, EventArgs e)
        {
            //последнее действие перед преобразованием в html
            Label3.Text += "-Prerender-";
        }

        protected void Page_Unload(object sender, EventArgs e)
        {
            //объекты доступны, но html уже сгенерирован
            Label3.Text += "-Unload-";
        }
        protected void Page_Disposed(object sender, EventArgs e)
        {
            //сборщик мусора
            Label3.Text += "-Disposed-";
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            Label3.Text += "-Check-";
        }
    }
}