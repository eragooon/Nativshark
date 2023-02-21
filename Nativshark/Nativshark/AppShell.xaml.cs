namespace Nativshark;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
	}

    protected override void OnNavigating(ShellNavigatingEventArgs args)
    {
        args.Cancel();
    }
}
