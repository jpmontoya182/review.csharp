using System.Threading;
using System.Threading.Tasks;

namespace Learning.Services
{
    public class QueryDataBase
    {

        public async void GetVersionAsync()
        {
            string result = await GetVersionValue();
            System.Console.WriteLine(result);
        }

        private Task<string> GetVersionValue()
        {
            return Task.Run<string>(() =>
            {
                Thread.Sleep(2000);
                return "it was processed the requiriment";
            });
        }

    }

}