using System.Threading.Tasks;
using NetCoreTeamCity.Models;

namespace NetCoreTeamCity.Clients
{
    internal interface ITeamCityApiClient
    {
        T Get<T>(string url);
        T Post<T>(string url, T obj);
        T2 Post<T1, T2>(string url, T1 obj);
        T Put<T>(string url, T obj);
        T2 Put<T1, T2>(string url, T1 obj);
        void Delete<T>(string url, T obj);
        Task DownloadAsync(string url, string pathTo);
        
        Task DownloadAsync(Href href, string pathTo);
    }
}