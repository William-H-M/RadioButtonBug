using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace RadioButtonBug
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private string? _selection;

        [RelayCommand]
        private void ClearSelectionEmpty()
        {
            Selection = string.Empty;
        }

        [RelayCommand]
        private void ClearSelectionNull()
        {
            Selection = null;
        }
    }
}
