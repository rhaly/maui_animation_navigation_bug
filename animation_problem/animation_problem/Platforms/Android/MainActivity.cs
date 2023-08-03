using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Widget;
using Color = Android.Graphics.Color;

namespace animation_problem;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true,
    ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode |
                           ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    private static FrameLayout DecorView => Platform.CurrentActivity.Window.DecorView as FrameLayout;

    protected override void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        DecorView.SetBackgroundColor(Color.Transparent);
    }
}