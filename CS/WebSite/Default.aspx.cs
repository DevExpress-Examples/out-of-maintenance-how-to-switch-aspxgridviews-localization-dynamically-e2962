using System;
using System.Threading;
using System.Globalization;
using System.Web;
using DevExpress.Web.ASPxEditors;

public partial class _Default : System.Web.UI.Page {
	protected override void InitializeCulture() {
		SetCulture();
		base.InitializeCulture();
	}

	private void SetCulture() {
		HttpCookie c = Request.Cookies["Lang"];
		if (c == null)
			return;
		string langValue = c.Value;
		if (!String.IsNullOrEmpty(langValue)) {

			Culture = langValue;
			UICulture = langValue;

			Thread.CurrentThread.CurrentCulture =
				CultureInfo.CreateSpecificCulture(langValue);
			Thread.CurrentThread.CurrentUICulture = new
				CultureInfo(langValue);
		}
	}
	protected void combo_Init(object sender, EventArgs e) {
		HttpCookie c = Request.Cookies["Lang"];
		if (c == null)
			return;
		ASPxComboBox cb = (sender as ASPxComboBox);
		cb.Value = c.Value;
		
	}
}
