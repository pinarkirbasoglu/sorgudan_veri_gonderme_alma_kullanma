using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace linke_göre_resim
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //soruguyla gelen değişkenin değeri request.quarysting["gelenDeğişkenAdi"] ile alnır string bir değerdir hep.
            int id = Convert.ToInt32(Request.QueryString["id"]);
            //hyperlinkte yönlendirme navigateurl ile hep web2 sayfasına yapıldı dolayısıyla link hep aynı we2px
            //ama biz link yanına id değişkeni atayark anakartta anakart resmi ramde ram resmi hdd de hdd resmi yaptık
            //bunlara kafamızdan isim verdik anakart id =1 hdd id=2 ram id=3 gibi
            //bu alınan id değerine göre de resim linki koyduk id=1 ise anakart,id=2 ise hdd,id=3 ise ram gibi
            switch(id)
            {
                case 1:
                    Image1.ImageUrl = "ana1.jpg";
                    break;
                case 2:
                    Image1.ImageUrl = "hdd1.jpg";
                    break;
                case 3:
                    Image1.ImageUrl = "ram1.jpg";
                    break;
            }
        }
    }
}