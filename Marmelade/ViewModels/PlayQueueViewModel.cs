using Avalonia.Media.Imaging;
using Marmelade.ViewModels;
using ReactiveUI;

namespace Marmelade;

public class PlayQueueViewModel : ViewModelBase
{
    private Bitmap? _albumCover = new Bitmap("/home/bdardenn/Pictures/k25p2qm76hn71.jpg");
    public Bitmap? AlbumCover
    {
        get => _albumCover;
        private set => this.RaiseAndSetIfChanged(ref _albumCover, value);
    }
    
}