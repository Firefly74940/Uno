#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class MenuFlyoutPresenter : global::Windows.UI.Xaml.Controls.ItemsControl
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Controls.Primitives.MenuFlyoutPresenterTemplateSettings TemplateSettings
		{
			get
			{
				throw new global::System.NotImplementedException("The member MenuFlyoutPresenterTemplateSettings MenuFlyoutPresenter.TemplateSettings is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public MenuFlyoutPresenter() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.MenuFlyoutPresenter", "MenuFlyoutPresenter.MenuFlyoutPresenter()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.MenuFlyoutPresenter.MenuFlyoutPresenter()
		// Forced skipping of method Windows.UI.Xaml.Controls.MenuFlyoutPresenter.TemplateSettings.get
	}
}
