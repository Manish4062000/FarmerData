namespace FarmerDatas.API.Model.DTO
{
    public class AddRequestDTO
    {
        public int rmcid { get; set; }
        public int Farmerid { get; set; }
        public DateOnly date { get; set; }
        public TimeOnly time { get; set; }

        public int KioskId { get; set; }

        public double weight { get; set; }
    }
}
