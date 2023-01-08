using Entity;

namespace BL
{
    public class BaseBL
    {
        public static IniEntity IEntity = new IniEntity();
        public string GetConnectionString()
        {

            return "Data Source=" + IEntity.DatabaseServer +
                   ";Initial Catalog=" + IEntity.DatabaseName +
                   ";Persist Security Info=True;User ID=" + IEntity.DatabaseLoginID +
                   ";Password=" + IEntity.DatabasePassword +
                   ";Connection Timeout=" + IEntity.TimeoutValues;
        }

    }
}