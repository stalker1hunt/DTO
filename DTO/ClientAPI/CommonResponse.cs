using System;

namespace DTO.ClientAPI
{
    /// <summary>
    /// Bridge struct on DTO
    /// </summary>
    [Serializable]
    public struct CommonResponse
    {
        /// <summary>
        /// Status successed execute function on server
        /// </summary>
        public bool Success;
        /// <summary>
        /// Message log
        /// </summary>
        public string Message;
        /// <summary>
        /// Result execute function on server
        /// </summary>
        public PlayerState PlayerStateUpdate;
    }
}
