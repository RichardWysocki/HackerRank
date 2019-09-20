using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns.SingletonExample
{
    public class EmailManager
    {
        private readonly ILogBase _logger;

        public EmailManager(ILogBase logger)
        {
            _logger = logger;
        }
        public async Task<bool> SendEmail(string emailAddress)
        {
            _logger.Log($"Starting to write to File: {emailAddress}");

            //Double work to send Email!
            Thread.Sleep(5000);   // i.e. 5 second delay!

            _logger.Log($"End to write to File: {emailAddress}");
            return true;
        }

    }
}
