using CommunityToolkit.Mvvm.Input;
using SimplerXAMLPlayground.Models;

namespace SimplerXAMLPlayground.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}