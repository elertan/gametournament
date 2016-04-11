using System;
using System.Linq;

namespace GameTournament
{
	public partial class Index : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			using (var ctx = new DatabaseContext())
			{
				if (ctx.Users.Count() == 0)
				{
					paragraph.InnerHtml = "There are no users";
				}
				else
				{
					foreach (var user in ctx.Users)
					{
						paragraph.InnerHtml += String.Format("{0} {1} - ", user.Firstname, user.Lastname);
					}
				}
			}
		}
	}
}