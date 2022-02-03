namespace ImageToBase64.API.Repository
{
    public class ImageRepository : IImageRepository
    {
        public  string GetImageIntoJSON()
        {
            string path = "D:\\Photo\\Image.jpg";
            byte[] FileByte = File.ReadAllBytes(path);
            string Base64String = Convert.ToBase64String(FileByte);
            return Base64String;
        } 
    }
}
