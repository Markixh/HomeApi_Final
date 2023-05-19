namespace HomeApi.Data.Queries
{
    /// <summary>
    /// Класс для передачи дополнительных параметров при обновлении комнаты
    /// </summary>
    public class UpdateRoomQuery
    {
        public string NewName { get; }
        public int NewArea { get; }
        public bool NewGasConnected { get; }
        public int NewVoltage { get; }

        public UpdateRoomQuery(string newName, bool newGasConnected, int newArea = 0, int newVoltage = 0)
        {
            NewName = newName;
            NewArea = newArea;
            NewGasConnected = newGasConnected;
            NewVoltage = newVoltage;
        }
    }
}
