namespace HomeApi.Contracts.Models.Rooms
{
    /// <summary>
    /// Добавляет новую комнату.
    /// </summary>
    public class AddRoomRequest
    {
        public string Name { get; set; }
        public int Area { get; set; }
        public bool GasConnected { get; set; }
        public int Voltage { get; set; }
    }
}