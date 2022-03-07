using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GetHTMLCodeAndImgsFromWebPage.Models
{
    public class Link
    {
        
        public bool correctUrl = false;

        public Link()
        {

        }

        public int Id { get; set; }
        public string LinkURL { get; set; }

        public void GetHTMLCodeFromLink(string linkFromUserInput)
        {
            if (Uri.IsWellFormedUriString(linkFromUserInput, UriKind.Absolute))
            {

                correctUrl = true;

                HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(linkFromUserInput);
                myRequest.Method = "GET";
                WebResponse myResponse = myRequest.GetResponse();
                StreamReader sr = new StreamReader(myResponse.GetResponseStream(), System.Text.Encoding.UTF8);
                string htmlCodeFromWeb = sr.ReadToEnd();
                sr.Close();

                myResponse.Close();
                string titleOfWebPageFromMeta = Regex.Match(htmlCodeFromWeb, @"\<title\b[^>]*\>\s*(?<Title>[\s\S]*?)\</title\>",
                    RegexOptions.IgnoreCase).Groups["Title"].Value;

                titleOfWebPageFromMeta = RemoveInvalidChars(titleOfWebPageFromMeta);

                SaveToTxtFileOnDesktop(htmlCodeFromWeb, titleOfWebPageFromMeta);
                SaveImgsAsPictureAndHtml(htmlCodeFromWeb, titleOfWebPageFromMeta, linkFromUserInput);
            }
        }

        public void SaveToTxtFileOnDesktop(string htmlCode, string titleOfWebPage)
        {
            string filePathToSave = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            filePathToSave = filePathToSave + @"\" + titleOfWebPage + "_HTMLCode.txt";

            using StreamWriter writer = new StreamWriter(filePathToSave);
            writer.WriteLine(htmlCode);
        }

        public void SaveImgsAsPictureAndHtml(string htmlCode, string titleOfWebPage, string linkFromUserInput)
        {
            string filePathToSave = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string dirPath = filePathToSave + @"\" + titleOfWebPage;
            Directory.CreateDirectory(dirPath);
            filePathToSave = dirPath + @"\" + titleOfWebPage + "_HTMLImg.txt";
            using StreamWriter writer = new StreamWriter(filePathToSave);
            foreach (Match match in Regex.Matches(htmlCode, "<img.+?src=[\"'](.+?)[\"'].+?>", RegexOptions.IgnoreCase | RegexOptions.Multiline))
            {
                string srcLink = match.Groups[1].Value;
                string imgName = Path.GetFileName(srcLink);
                writer.WriteLine(srcLink);
                using WebClient client = new WebClient();
                try
                {
                    if (srcLink.ToLower().StartsWith("http"))
                    {
                        client.DownloadFileAsync(new Uri(srcLink), dirPath + @"\" + imgName);
                    }
                    else if (linkFromUserInput.EndsWith("/"))
                    {
                        linkFromUserInput = linkFromUserInput.Substring(0, linkFromUserInput.Length - 1);
                        client.DownloadFileAsync(new Uri(linkFromUserInput + srcLink), dirPath + @"\" + imgName);
                    }
                    else
                    {
                        client.DownloadFileAsync(new Uri(linkFromUserInput + srcLink), dirPath + @"\" + imgName);
                    }
                }
                catch (Exception ex)
                {

                }

            }

        }
        public string RemoveInvalidChars(string titleOfWebPageFromMeta)
        {
            return string.Concat(titleOfWebPageFromMeta.Split(Path.GetInvalidFileNameChars()));
        }

    }
}
