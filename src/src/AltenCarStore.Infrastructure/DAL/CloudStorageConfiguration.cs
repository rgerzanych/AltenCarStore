using System;
using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace AltenCarStore.Infrastructure.DAL
{
    /// <summary>
    /// Custom Entity Framework configuration for an application.
    /// </summary>
    public class CloudStorageConfiguration : DbConfiguration
    {
        public CloudStorageConfiguration()
        {
            // set the maximum number of retries to 1 and the maximum delay to 30 seconds
            SetExecutionStrategy(
                "System.Data.SqlClient",
                () => new SqlAzureExecutionStrategy(1, TimeSpan.FromSeconds(30)));
        }
    }
}
