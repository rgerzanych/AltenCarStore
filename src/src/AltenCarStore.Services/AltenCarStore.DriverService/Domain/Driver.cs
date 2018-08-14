using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AltenCarStore.Infrastructure.Domain;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace AltenCarStore.DriverService.Domain
{
    public class Driver : EntityBase
    {
        public string Name { get; set; }
    }
}
