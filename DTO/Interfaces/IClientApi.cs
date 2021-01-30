using DTO.ClientAPI;

namespace DTO.Interfaces
{
    internal interface IClientApi
    {
        /// <summary>
        /// Connect to server
        /// </summary>
        /// <returns>Common Response include ServerData</returns>
        IPromise<CommonResponse> Connect();

        /// <summary>
        /// Get player data from server
        /// </summary>
        /// <param name="playerId"> Player Id from server</param>
        /// <returns>Common Response include PlayerData</returns>
        IPromise<CommonResponse> GetPlayerData(string playerId);

        /// <summary>
        /// Disconnect from server
        /// </summary>
        IPromise<CommonResponse> Disconnect();

        /// <summary>
        /// Base client send method to server
        /// </summary>
        /// <typeparam name="Rq"></typeparam>
        /// <param name="parameters"></param>
        /// <returns></returns>
        IPromise<CommonResponse> TalkInternal<Rq>(Rq parameters);
    }
}
