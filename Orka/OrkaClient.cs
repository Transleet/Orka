namespace Orka
{
    public class OrkaClient
    {
        public static OrkaClient Create(Uin uin, OrkaClientConfiguration? configuration)
        {
            var dataPath =configuration?.DataDirectory??Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Orka", "data");
            CreateDataDirectory(dataPath);
            throw new NotImplementedException();
        }

        public static void CreateDataDirectory(string dataDirectory)
        {

        }
        
        public Task LoginAsync()
        {
            throw new NotImplementedException();
        }
    }
}