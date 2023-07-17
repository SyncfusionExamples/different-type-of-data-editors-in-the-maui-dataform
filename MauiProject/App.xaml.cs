namespace MauiProject;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NjA0NzI4QDMyMzAyZTMxMmUzMElnd0owNjFveXpldXBBVW9aQ3BkR2VGQUZRK2doVFZPak92T2VzNm5MR1k9");
		MainPage = new AppShell();
	}
}
