using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBus.MqApp.Core
{
    public class RetryExecutor
    {
        public async Task ExecuteAsync(Func<Task> action)
        {
            int retries = 3;

            for (int attempt = 1; attempt <= retries; attempt++)
            {
                try
                {
                    await action();
                    return;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Retry {attempt} failed: {ex.Message}");

                    if (attempt == retries)
                        throw;

                    await Task.Delay(1000);
                }
            }
        }
    }

}
