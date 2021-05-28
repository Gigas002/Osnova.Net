namespace Osnova.Net.Enums
{
    public enum NotificationType // TODO: all types
    {
        Like = 2,
        Reply = 4,
        Banned = 8,
        Unpublish = 16,
        Comment = 32,
        System = 64,
        Vacancy = 128,
        Mention = 1024,
        Subscribe = 4096,
        Advertisement = 32768
    }
}
