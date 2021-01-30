using System;

namespace DTO.ClientAPI.Requests
{
    /// <summary>
    /// Request uses for Disconnect from Server
    /// Properties:
    /// ServerToken - needed to disconnect from a specific server
    /// </summary>
    [Serializable]
    public struct DisconnectFromServer
    {
        public string ServerToken;
    }
}
