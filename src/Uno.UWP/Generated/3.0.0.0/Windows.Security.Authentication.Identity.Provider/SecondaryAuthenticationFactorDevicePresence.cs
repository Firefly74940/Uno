#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Security.Authentication.Identity.Provider
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum SecondaryAuthenticationFactorDevicePresence 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Absent,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Present,
		#endif
	}
	#endif
}