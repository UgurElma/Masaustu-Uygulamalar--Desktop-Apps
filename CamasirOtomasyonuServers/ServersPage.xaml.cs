using CommunityToolkit.Maui.Views;
using Student.VeriIslemleri;
using System.Collections.ObjectModel;

namespace Student.Pages;

public partial class ServersPage : Popup
{
    private LoginPage loginPage = new LoginPage();
    private ObservableCollection<Server> Servers { get; set; } = [];
    private ObservableCollection<Server> filteredServers { get; set; } = [];

    public ServersPage()
	{
		InitializeComponent();
        LoaderServers();
	}

    private async void LoaderServers()
    {
        buttonConnect.IsEnabled = false;
        if (Preferences.ContainsKey("ip_adress"))
            Preferences.Remove("ip_adress");
        await GetServers();
    }

    private async Task GetServers()
    {
        string fileId = "1A12Y56CE0tZqxmEz6rriQWMtPwP9VOXm"; // Dosya ID
        string googleDriveUrl = $"https://drive.google.com/uc?export=download&id={fileId}";

        try
        {
            using HttpClient httpClient = new HttpClient
            {
                Timeout = TimeSpan.FromSeconds(1000) // Zaman aþýmý süresi ekleyin
            };

            HttpResponseMessage response = await httpClient.GetAsync(googleDriveUrl);
            if (response.IsSuccessStatusCode)
            {
                Servers.Clear(); // Önceki serverlarý temizliyoruz
                using Stream stream = response.Content.ReadAsStream();
                using StreamReader reader = new(stream);
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Sunucu adý ve IP adresi virgülle ayrýlmýþ, bunlarý alýyoruz
                    var parts = line.Split(',');
                    if (parts.Length > 1)
                    {
                        Servers.Add(new Server(parts[0], parts[1])); // Server nesnesi ekliyoruz
                    }
                }
                collectionServers.ItemsSource = Servers; // CollectionView'e baðlýyoruz
            }
        }
        catch (Exception ex) { Console.WriteLine(ex.StackTrace); }
    }

    private void searchBar_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(searchBar.Text))
        {
            collectionServers.ItemsSource = Servers;
            buttonConnect.IsEnabled = false;
        }
        else
        {
            var filteredList = Servers.Where(s => s.Name.Contains(searchBar.Text, StringComparison.OrdinalIgnoreCase)).ToList();
            filteredServers.Clear();
            foreach (var server in filteredList)
            {
                filteredServers.Add(server);
            }
            collectionServers.ItemsSource = filteredServers;
        }
    }

    private void buttonConnect_Clicked(object sender, EventArgs e)
    {
        Close();
        loginPage.OnLoadPage();
    }

    private void buttonServer_Clicked(object sender, EventArgs e)
    {
        if (sender is Button button)
        {
            foreach (Server server in Servers)
            {
                if (button.Text == server.Name)
                {
                    searchBar.Text = server.Name;
                    buttonConnect.IsEnabled = true;
                    server.OnConnectServer();
                }
            }
        }
    }
}
public class Server
{
    public string Name { get; set; }
    public string IP_Adress { get; set; }

    public Server(string name, string ipAdress)
    {
        Name = name;
        IP_Adress = ipAdress;
    }
    public void OnConnectServer()
    {
        MSSQLConnection.SetIPAdress(IP_Adress);
    }
}