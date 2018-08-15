using System;
using AltenCarStore.Infrastructure.Domain;

namespace AltenCarStore.VehicleStateService.Domain
{
    public class VehicleState : EntityBase
    {
        public DateTime? LastUpdated { get; set; }

        public bool IsConnected => LastUpdated.HasValue && (DateTime.UtcNow - LastUpdated.Value).TotalSeconds < 60;
    }
}
