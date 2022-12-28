using Microsoft.AspNetCore.Hosting;

namespace FastFoodMVC.Service
{
    public class ImageControllerService : IImageControllerInterface
    {
        private readonly IWebHostEnvironment _webHost;

        public ImageControllerService(IWebHostEnvironment webHost)
        {
            _webHost = webHost;
        }
        public string SaveImage(IFormFile newFile)
        {
            string uniqueName = string.Empty;
            if (newFile.FileName != null)
            {
                string uplodFolder = Path.Combine(_webHost.WebRootPath, "photos");
                uniqueName = Guid.NewGuid().ToString() + "_" + newFile.FileName;
                string filePath = Path.Combine(uplodFolder, uniqueName);
                FileStream fileStream = new FileStream(filePath, FileMode.Create);
                newFile.CopyTo(fileStream);
                fileStream.Close();
            }

            return uniqueName;
        }
    }
}
