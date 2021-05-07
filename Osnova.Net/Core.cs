using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Osnova.Net.Responses;
using Osnova.Net.Responses.Blocks;

#pragma warning disable 1591

namespace Osnova.Net
{
    public static class Core// : IDisposable, IAsyncDisposable
    {
        #region Constants

        public const string BaseDtfUriString = "https://api.dtf.ru";
        public const string BaseTjournalUriString = "https://api.tjournal.ru";
        public const string BaseVcUriString = "https://api.vc.ru";
        public const string BaseLeonardoUriString = "https://leonardo.osnova.io";

        public const double ApiVersion = 1.9;

        #endregion

        //#region Properties

        //public bool IsDisposed { get; private set; }

        //public HttpClient OsnovaClient { get; private set; } = new HttpClient();

        //public Uri BaseUri { get; private set; }

        //#endregion

        //#region Ctor

        //public Core(WebsiteKind websiteKind, double apiVersion = 1.9)
        //{
        //    BaseUri = GetBaseUri(websiteKind, apiVersion);
        //}

        ///// <summary>
        ///// Calls <see cref="Dispose(bool)"/> on this <see cref="Core"/>
        ///// </summary>
        //~Core() => Dispose(false);

        //#endregion

        //#region Dispose

        ///// <inheritdoc />
        //public void Dispose()
        //{
        //    Dispose(true);
        //    GC.SuppressFinalize(this);
        //}

        ///// <inheritdoc cref="Dispose()"/>
        ///// <param name="disposing">Dispose static fields?</param>
        //protected virtual void Dispose(bool disposing)
        //{
        //    if (IsDisposed) return;

        //    if (disposing)
        //    {
        //        // Occurs only if called by programmer. Dispose static things here
        //    }

        //    OsnovaClient?.Dispose();

        //    IsDisposed = true;
        //}

        ///// <inheritdoc />
        //public ValueTask DisposeAsync()
        //{
        //    try
        //    {
        //        //Dispose();
        //        GC.SuppressFinalize(this);

        //        return default;
        //    }
        //    catch (Exception exception)
        //    {
        //        return ValueTask.FromException(exception);
        //    }
        //}

        //#endregion

        #region Methods

        public static Uri GetBaseUri(WebsiteKind websiteKind, double apiVersion)
        {
            string invariantVersion = apiVersion.ToString(CultureInfo.InvariantCulture);

            var baseString = websiteKind switch
            {
                WebsiteKind.Dtf => BaseDtfUriString,
                WebsiteKind.Tjournal => BaseTjournalUriString,
                WebsiteKind.Vc => BaseVcUriString,
                _ => throw new NotImplementedException()
            };

            return new Uri($"{baseString}/v{invariantVersion}");
        }

        public static async ValueTask DownloadAllEntryImages(HttpClient client, WebsiteKind websiteKind,
                                                             int entryId, string outputPath,
                                                             double apiVersion = ApiVersion,
                                                             IProgress<double> progress = null)
        {
            Directory.CreateDirectory(outputPath);

            var entry = await Entry.GetEntryById(client, websiteKind, entryId, apiVersion).ConfigureAwait(false);

            //var mediaDatas = new List<MediaData>();
            var images = new List<Block>();

            //foreach (Block block in entry.Blocks.Where(block => block.Type == "media"))
            //foreach (Block block in entry.Blocks.Where(block => block.Type == "media"))
            //{
            //    MediaBlockData mediaBlockData = (MediaBlockData)block.GetBlockData();
            //    images.AddRange(mediaBlockData.Items);
            //    //mediaDatas.AddRange(block.GetItems());
            //}

            double counter = 0.0;

            //foreach (MediaData data in mediaDatas)
            //{
            //    var guid = data.Image.Data.Uuid.ToString();
            //    var extension = data.Image.Data.Type;
            //    var itemUri = new Uri($"{BaseLeonardoUriString}/{guid}");

            //    var bytes = await client.GetByteArrayAsync(itemUri).ConfigureAwait(false);
            //    await File.WriteAllBytesAsync(Path.Combine(outputPath, $"{guid}.{extension}"), bytes).ConfigureAwait(false);

            //    // Report progress
            //    counter++;
            //    double percentage = counter / mediaDatas.Count * 100.0;
            //    progress?.Report(percentage);
            //}
        }

        #endregion
    }
}
