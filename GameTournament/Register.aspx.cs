using System;
using System.Web.UI.HtmlControls;

namespace GameTournament
{
	public partial class Register : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			formSubmit.ServerClick += FormSubmit_ServerClick;
		}

		private void FormSubmit_ServerClick(object sender, EventArgs e)
		{
			(sender as HtmlInputSubmit).Value = "Ouch that hurts";
		}
	}
}