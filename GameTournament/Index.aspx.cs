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
				if (ctx.ApiUsers.Count() == 0)
				{
					paragraph.InnerHtml = "There are no users";
				}
				else
				{
					foreach (var user in ctx.ApiUsers)
					{
						paragraph.InnerHtml += String.Format("{0} {1} - ", user.ApiUserId, user.ApiUserId);
					}
				}
			}
		}
	}
}