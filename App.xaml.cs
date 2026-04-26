using System.Windows;
using DueskWPF.Services;

namespace DueskWPF;

public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);
        
        // Load saved session
        SessionManager.Instance.LoadSession();
        
        // Set default font
        FrameworkElement.StyleProperty.OverrideMetadata(
            typeof(FrameworkElement),
            new FrameworkPropertyMetadata
            {
                DefaultValue = FindResource(typeof(FrameworkElement))
            });
    }
    
    protected override void OnExit(ExitEventArgs e)
    {
        base.OnExit(e);
        SessionManager.Instance.SaveSession();
    }
}