using CommunityToolkit.Mvvm.Input;
using gestionVentas.Models;

namespace gestionVentas.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}