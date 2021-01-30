using System;

namespace DTO.ClientAPI.Requests
{
    /// <summary>
    /// Request get actualy player data from server
    /// Properties:
    /// PlayerId - Id player from DB
    /// </summary>
    [Serializable]
    public struct GetPlayerData
    {
        public string PlayerId;
    }
}
