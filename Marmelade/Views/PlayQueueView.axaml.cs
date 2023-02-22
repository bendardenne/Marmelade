using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Marmelade;

public partial class PlayQueueView : UserControl
{
    public PlayQueueView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}