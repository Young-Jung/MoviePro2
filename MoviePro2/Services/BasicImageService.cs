using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MoviePro2.Services
{
    public class BasicImageService : IImageService
    {
        public string DecodePoster(byte[] poster, string contentType)
        {
            if(poster == null)
            {
                return null;
            }
            var posterImage = Convert.ToBase64String(poster);
            // this is the way Base64 works
            return $"data:{contentType};base64,{posterImage}";
        }

        public async Task<byte[]> EncodeImageURLAsync(string imageURL)
        {
            var client = new HttpClient();

            // it will return image as string
            var response = await client.GetAsync(imageURL);

            Stream stream = await response.Content.ReadAsStreamAsync();
            var ms = new MemoryStream();
            await stream.CopyToAsync(ms);

            return ms.ToArray();
        }

        public async Task<byte[]> EncodePosterAsync(IFormFile poster)
        {
            if(poster == null)
            {
                return null;
            }

            using var ms = new MemoryStream();
            await poster.CopyToAsync(ms);

            return ms.ToArray();
        }

        public string RecordContentType(IFormFile poster)
        {
            if(poster == null)
            { 
                return null;
            }
            return poster.ContentType;
        }
    }
}
