namespace Marmelade.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private PlayQueueViewModel _playQueue = new PlayQueueViewModel();
    public object PlayQueue { get => _playQueue; }
}