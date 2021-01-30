using DTO.Interfaces;
using DTO.ClientAPI;

namespace DTO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add simple how this architecture base in DTO pattern Work. 

            IClientApi clientApi = new ClientApi();

            clientApi.Connect()
                .Done(responce => {

                    clientApi.GetPlayerData(responce.PlayerStateUpdate.PlayerData.PlayerId);
                
                })
                .Fail(error => { });
        }
    }
}
