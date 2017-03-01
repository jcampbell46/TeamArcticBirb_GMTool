using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GMTool_jcampbell46
{
    public partial class _default : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SoundPlayer bgMusic = new SoundPlayer();

            bgMusic.SoundLocation = Server.MapPath("Music/08 Black Blade.wav");

            bgMusic.Play();
        }
    }
}