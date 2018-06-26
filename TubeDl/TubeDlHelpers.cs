﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using YoutubeExtractor;

namespace TubeDl
{
    public static class TubeDlHelpers
    {
        public static string downloadurl;
        public static VideoInfo video;
        public static Stopwatch sw = new Stopwatch();    // The stopwatch which we will be using to calculate the download speed
        public static string customSavePath;

        public static List<DownloadHelper.downloadFile> ldf = new List<DownloadHelper.downloadFile>();

        public static string savePath;
        /// <summary>
        /// file savepath
        /// </summary>
        public static string SavePath
        {
            get { return savePath; }
            set { savePath = value; }
        }

        public static string Extention()
        {
            var ext = TubeDlHelpers.video.Resolution.ToString();
            if (ext == "0")
                return ".mp3";
            else
                return ".Mp4";

        }
        public static string RemoveIllegalPathCharacters(string path)
        {
            string regexSearch = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
            var r = new Regex(string.Format("[{0}]", Regex.Escape(regexSearch)));
            return r.Replace(path, "");
        }

        public static string GetFileSize(Uri uriPath)
        {
            var webRequest = HttpWebRequest.Create(uriPath);
            webRequest.Method = "HEAD";

            using (var webResponse = webRequest.GetResponse())
            {
                var fileSize = webResponse.Headers.Get("Content-Length");
                var fileSizeInMegaByte = View.Size.getlength.GetLengthString(Math.Round(
                    Convert.ToDouble(fileSize)));
                return fileSizeInMegaByte;
            }
        }
    }
}