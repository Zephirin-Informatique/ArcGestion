using ArcGestion.Services;

namespace ArcGestion;

public partial class App : Application
{
    static MockDataStore dataStore;

    public static MockDataStore MockDataStore
    {
        get
        {
            if (dataStore == null)
            {
                dataStore = new MockDataStore(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Gestion.db3"));
            }
            return dataStore;
        }
    }

    public App()
	{
		InitializeComponent();

        DependencyService.Register<MockDataStore>();
        MainPage = new AppShell();
	}
}
