using System;

namespace DTO.ClientAPI.Requests
{
    /// <summary>
    /// Request uses for Connect To Server
    /// Properties:
    /// ServerToken - neded for a connection to a specific server 
    /// </summary>
    [Serializable]
    public struct ConnectToServer
    {
        public string ServerToken;
    }
}
