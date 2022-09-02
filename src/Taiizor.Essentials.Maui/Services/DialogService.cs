using Taiizor.Essentials.Maui.Interfaces;

namespace Taiizor.Essentials.Maui.Services
{
    public class DialogService : IDialogService
    {
        public async Task DisplayConfirm(string title, string message, string cancel)
        {
            await Application.Current.MainPage.DisplayAlert(title, message, cancel);
        }

        public async Task<bool> DisplayConfirm(string title, string message, string accept, string cancel)
        {
            return await Application.Current.MainPage.DisplayAlert(title, message, accept, cancel);
        }

        public async Task<bool> DisplayConfirm(string title, string message, string accept, string cancel, FlowDirection direction)
        {
            return await Application.Current.MainPage.DisplayAlert(title, message, accept, cancel, direction);
        }
    }
}