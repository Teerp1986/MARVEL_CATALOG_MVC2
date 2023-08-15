using MARVEL2.Models;

namespace MARVEL2.Models.Helper
{
    public static class MCU_Shows
    {
        public static List<MCU_Show> GetAll()
        {
            return new List<MCU_Show>
            {
                new MCU_Show() { Name = "WandaVision"},
                new MCU_Show() { Name = "Falcon and the Winter Soldier"},
                new MCU_Show() { Name = "Loki"},
                new MCU_Show() { Name = "What If...?"},
                new MCU_Show() { Name = "Hawkeye"},
                new MCU_Show() { Name = "Moon Knight"},
                new MCU_Show() { Name = "Ms.Marvel"},
                new MCU_Show() { Name = "I Am Groot"},
                new MCU_Show() { Name = "She-Hulk"},
                new MCU_Show() { Name = "Werewolf By Night"},
                new MCU_Show() { Name = "Secret Invasion"},
            };
        }
    }
}
