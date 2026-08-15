using Microsoft.Extensions.DependencyInjection;

namespace MauiIssueOnPlatfornResourceDictionary19573;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new AppShell());
    }
}