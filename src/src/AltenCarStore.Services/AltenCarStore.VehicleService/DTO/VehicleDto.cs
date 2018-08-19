namespace AltenCarStore.VehicleService.DTO
{
    public class VehicleDto
    {
        public string Id { get; set; }

        public string Vin { get; set; }

        public string RegNumber { get; set; }

        public string OwnerId { get; set; }

        public string OwnerName { get; set; }

        public string OwnerAddress { get; set; }

        public bool IsConnected { get; set; }
    }
}
