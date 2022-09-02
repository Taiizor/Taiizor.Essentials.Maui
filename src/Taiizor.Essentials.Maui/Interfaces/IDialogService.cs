namespace Taiizor.Essentials.Maui.Interfaces
{
    public interface IDialogService
    {
        Task DisplayConfirm(string title, string message, string cancel);
        
        Task<bool> DisplayConfirm(string title, string message, string accept, string cancel);
        
        Task<bool> DisplayConfirm(string title, string message, string accept, string cancel, FlowDirection direction);
    }
}