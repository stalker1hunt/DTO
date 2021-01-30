using System;

namespace DTO.ClientAPI
{
    [Serializable]
    public struct PlayerState
    {
        public PlayerData PlayerData;
    }

    [Serializable]
    public struct PlayerData
    {
        public string PlayerId;
    }
}
