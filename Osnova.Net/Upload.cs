using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Osnova.Net.Blocks;
using Osnova.Net.Enums;

namespace Osnova.Net
{
    public class Upload
    {
        #region Methods

        #region POST

        #region PostUploaderUpload

        public static Uri GetUploaderUploadUri(WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/uploader/upload");
        }

        public static async ValueTask<HttpResponseMessage> PostUploaderUploadGetResponseAsync(HttpClient client, WebsiteKind websiteKind,
            IEnumerable<byte[]> filesBytes, double apiVersion = Core.ApiVersion)
        {
            var requestContent = new MultipartFormDataContent();

            int index = 0;

            foreach (ByteArrayContent content in filesBytes.Select(bytes => new ByteArrayContent(bytes)))
            {
                requestContent.Add(content, $"file_{index}", $"file_{index}");

                index++;
            }

            var response = await Core.PostToApiAsync(client, GetUploaderUploadUri(websiteKind, apiVersion), requestContent).ConfigureAwait(false);

            Core.DisposeHttpContents(requestContent);

            return response;
        }

        // TODO: IEnumerable<FileInfo> overload
        public static async ValueTask<IEnumerable<Block>> PostUploaderUploadAsync(HttpClient client, WebsiteKind websiteKind, IEnumerable<byte[]> filesBytes,
                                                              double apiVersion = Core.ApiVersion)
        {
            using var response = await PostUploaderUploadGetResponseAsync(client, websiteKind, filesBytes, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<Block>>(response);
        }

        #endregion

        #endregion

        #endregion
    }
}
