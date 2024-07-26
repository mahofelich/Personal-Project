using PersonalProject.Client.Models;
namespace PersonalProject.Client.Client
{
    public class Imgservice
{
    public bool Uploadimg(ImgModel ic,HttpClient httpClient)
    {
        httpClient.Saveimg.Add(ic);
        httpClient.SaveChanges();
        return true;
    }
}
}
