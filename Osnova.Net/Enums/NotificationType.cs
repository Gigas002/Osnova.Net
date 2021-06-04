namespace Osnova.Net.Enums
{
    /// <summary>
    /// Notification types
    /// </summary>
    public enum NotificationType // TODO: all types
    {
        /// <summary>
        /// Like
        /// </summary>
        Like = 2,
        
        /// <summary>
        /// Reply
        /// </summary>
        Reply = 4,
        
        /// <summary>
        /// Banned
        /// </summary>
        Banned = 8,
        
        /// <summary>
        /// Unpublished entry
        /// </summary>
        Unpublish = 16,
        
        /// <summary>
        /// New comment
        /// </summary>
        Comment = 32,
        
        /// <summary>
        /// System notification
        /// </summary>
        System = 64,
        
        /// <summary>
        /// Vacancy
        /// </summary>
        Vacancy = 128,
        
        /// <summary>
        /// Mentioned somewhere
        /// </summary>
        Mention = 1024,
        
        /// <summary>
        /// New subscriber
        /// </summary>
        Subscribe = 4096,
        
        /// <summary>
        /// Advertisement
        /// </summary>
        Advertisement = 32768
    }
}
