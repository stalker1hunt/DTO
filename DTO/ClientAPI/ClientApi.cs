using System;
using System.Text.Json;
using DTO.ClientAPI.Requests;
using DTO.Interfaces;
using DTO.Promises;

namespace DTO.ClientAPI
{
    internal class ClientApi : IClientApi
    {
        /// <summary>
        /// Get from the admin panel
        /// </summary>
        private const string SERVER_TOKEN = "d41d8cd98f00b204e9800998ecf8427e";

        public IPromise<CommonResponse> Connect()
        {
            return TalkInternal(new ConnectToServer()
            {
                ServerToken = SERVER_TOKEN
            });
        }

        public IPromise<CommonResponse> GetPlayerData(string playerId)
        {
            return TalkInternal(new GetPlayerData()
            {
                PlayerId = playerId
            });
        }

        public IPromise<CommonResponse> Disconnect()
        {
            return TalkInternal(new DisconnectFromServer()
            {
                ServerToken = SERVER_TOKEN
            });
        }

        public IPromise<CommonResponse> TalkInternal<Rq>(Rq parameters)
        {
            Deferred<CommonResponse> result = Deferred<CommonResponse>.GetFromPool();

            Request request = new Request
            {
                FunctionName = typeof(Rq).Name,
                FunctionParameter = parameters
            };

            ExecuteClientRequest(request,
                response =>
                        {
                            result.Resolve(JsonSerializer.Deserialize<CommonResponse>(response.ToString()));

                            if (response != null)
                                HandlePlayerStateUpdate(response);

                        },
                error =>
                        {
                            result.Reject(error.ToString());
                        });

            return result;
        }


        private void ExecuteClientRequest(Request request, Action<object> response, Action<object> error)
        {
           //TODO 30.01.2021 simple comment for TODO, need add abstract logic fro Execute requests. 
        }

        /// <summary>
        /// Method used to update info when get data. 
        /// </summary>
        /// <param name="playerState">Parced object from server</param>
        private void HandlePlayerStateUpdate(object playerState)
        {
            //TODO 30.01.2021 need add refresh PlayerState logic. 
        }
    }
}
