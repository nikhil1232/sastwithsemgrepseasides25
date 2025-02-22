using Newtonsoft;
using Newtonsoft.Json;
using System.Web.UI.WebControls;

class Test
{
    public static object Deserialize1(TextBox data)
    {
        return JsonConvert.DeserializeObject(data.Text, new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.None 
        });
    }

    public static object Deserialize2(TextBox data)
    {
        return JsonConvert.DeserializeObject(data.Text, new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.Auto 
        });
    }

    public static object Deserialize3(TextBox data)
    {
        JsonSerializerSettings settings = new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.Auto 
        };
        return JsonConvert.DeserializeObject(data.Text, settings);
    }

    public static object Deserialize4(TextBox data)
    {
        JsonSerializerSettings settings = new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.None 
        };
        return JsonConvert.DeserializeObject(data.Text, settings);
    }

    public static object Deserialize5(TextBox data)
    {
        return JsonConvert.DeserializeObject(data.Text);
    }

}