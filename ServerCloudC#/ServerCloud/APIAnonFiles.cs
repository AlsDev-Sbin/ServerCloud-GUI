using HtmlAgilityPack;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ServerCloud.RemoteServerCloud.Model;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerCloud
{
	public class APIAnonFiles : IDisposable
	{
		public async Task<bool> CreateUser(string User, string Pass)
		{
			try
			{
				DeleteUrlCacheEntry("https://anonfiles.com");
				var web = new WebBrowser();
				SuppressWininetBehavior();
				web.Navigate("https://anonfiles.com/logout");

				web.ScriptErrorsSuppressed = false;
				web.Tag = 0;
				var method = new Action(() =>
				{
					if (web.Tag.Equals(0))
					{
						web.Tag = 1;
						web.Navigate("https://anonfiles.com/register");
						web.Refresh(WebBrowserRefreshOption.Completely);
						DeleteUrlCacheEntry("https://anonfiles.com");
						SuppressWininetBehavior();
					} else if (web.Tag.Equals(1))
					{
						var inputName = web.Document.All.GetElementsByName("username").OfType<HtmlElement>().First();
						var inputPass = web.Document.All.GetElementsByName("password").OfType<HtmlElement>().First();
						var inputPassConfirm = web.Document.All.GetElementsByName("password_confirm").OfType<HtmlElement>().First();

						inputName.SetAttribute("value", User);
						inputPass.SetAttribute("value", Pass);
						inputPassConfirm.SetAttribute("value", Pass);

						var bt = web.Document.GetElementsByTagName("input").OfType<HtmlElement>().Last();
						bt.InvokeMember("Click");
						web.Tag = 2;
					} else if (web.Tag.Equals(2))
					{
						web.Tag = 3;
						GC.SuppressFinalize(web);
					}
				});

				web.DocumentCompleted += (s, e) => method();

				while ((int)web.Tag != 3)
					await Task.Delay(80);

				return true;
			} catch
			{
				return false;
			}
		}

		public async Task<string?> GetTokenUser(string User, string Pass)
		{
			string? token = null;
			try
			{
				using (var web = new WebBrowser())
				{
					DeleteUrlCacheEntry("https://anonfiles.com");
					web.ScriptErrorsSuppressed = false;
					web.Tag = 0;
					SuppressWininetBehavior();
					web.Navigate("https://anonfiles.com/login");

					var method = new Action(() =>
					{
						if (web.Tag.Equals(0))
						{
							var inputUser = web.Document.All.GetElementsByName("username").OfType<HtmlElement>().First();
							var inputPass = web.Document.All.GetElementsByName("password").OfType<HtmlElement>().First();
							var bt = web.Document.GetElementsByTagName("input").OfType<HtmlElement>().Last();

							inputUser.SetAttribute("value", User);
							inputPass.SetAttribute("value", Pass);

							bt.InvokeMember("Click");

							web.Tag = 1;
							web.Navigate("https://anonfiles.com/docs/api");
							web.Refresh(WebBrowserRefreshOption.Completely);
						} else if (web.Tag.Equals(1))
						{
							var code = web.Document.GetElementsByTagName("code").OfType<HtmlElement>().First();
							token = code.InnerText;

							web.Tag = 2;
						}
					});

					web.DocumentCompleted += (s, e) => method();

					while ((int)web.Tag != 2)
						await Task.Delay(80);
				}
			} catch { }
			return token;
		}

		public async Task<ModelAPIAnonFiles?> UploadFile(ModelAPIAnonFiles modelApi, string PathFile, string? Token = null)
		{
			string response = "";
			using (var client = new HttpClient())
			{
				client.BaseAddress = new Uri($"https://api.anonfiles.com/upload?token={Token ?? ""}");
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
				using (var part = new MultipartFormDataContent())
				{
					var byteArray = new ByteArrayContent(System.IO.File.ReadAllBytes(PathFile));
					part.Add(byteArray, "file", modelApi.data.file.metadata.name);

					response = await (await client.PostAsync("", part)).Content.ReadAsStringAsync();
				}
			}

			return JsonConvert.DeserializeObject<ModelAPIAnonFiles>(response);
		}

		public async Task DownloadFile(string link, string FileName, Action callback = null)
		{
			await Task.Run(() =>
			{
				var web = new HtmlWeb();
				var doc = web.Load(link);
				var tag_download = doc.GetElementbyId("download-url");
				if (tag_download is not null)
				{
					var download_link = tag_download.GetAttributeValue("href", "");

					var webDownload = new WebClient();
					webDownload.DownloadFile(download_link, FileName);
				}

				if (callback is not null)
					callback();
			});
		}

		public CrawlerDeleteFile DeleteFiles(string user, string pass) =>
			new CrawlerDeleteFile(user, pass);

		public class CrawlerDeleteFile : IDisposable
		{
			WebBrowser? web { get; init; }
			private (string User, string Pass) DataUser { get; set; }

			public CrawlerDeleteFile(string user, string pass)
			{
				DataUser = (user, pass);

				DeleteUrlCacheEntry("https://anonfiles.com");
				web = new WebBrowser();
				web.Tag = 0;
				web.ScriptErrorsSuppressed = true;
				web.DocumentCompleted += (s, e) => DocumentCompleted();
				SuppressWininetBehavior();

				web.Navigate("https://anonfiles.com/login");
				web.Refresh(WebBrowserRefreshOption.Completely);
			}

			private async void DocumentCompleted()
			{
				web.Document.Window.Error += (s, e) => e.Handled = true;

				if (web.Tag.Equals(0))
				{
					var inputUser = web.Document.All.GetElementsByName("username").OfType<HtmlElement>().First();
					var inputPass = web.Document.All.GetElementsByName("password").OfType<HtmlElement>().First();
					var bt = web.Document.GetElementsByTagName("input").OfType<HtmlElement>().Last();

					inputUser.SetAttribute("value", DataUser.User);
					inputPass.SetAttribute("value", DataUser.Pass);

					bt.InvokeMember("Click");

					web.Tag = 1;
				} else if (web.Tag.Equals(1))
				{
					await Task.Delay(500);
					var bt = web.Document.GetElementsByTagName("button").OfType<HtmlElement>().Last();
					bt.InvokeMember("Click");

					web.Tag = 2;
				} else if (web.Tag.Equals(2))
					web.Tag = 1;
			}

			public async Task<bool> DeleteFile(string link)
			{
				return await Task.Run(() =>
				{
					int i = 0;
					while ((int)web.Tag == 0)
					{
						Task.Delay(80);
						i++;
						if (i >= 5000)
							return false;
					}

					web.Navigate($"https://anonfiles.com/account/file/{link}/remove");

					i = 0;
					while ((int)web.Tag != 2)
					{
						Task.Delay(80);
						i++;
						if (i >= 5000)
							return false;
					}

					web.Navigate($"https://anonfiles.com/");
					return true;
				});
			}

			public void Dispose() =>
				GC.SuppressFinalize(this);
		}

		[DllImport("wininet.dll", SetLastError = false)]
		private static extern long DeleteUrlCacheEntry(string lpszUrlName);

		[DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = false)]
		private static extern bool InternetSetOption(int hInternet, int dwOption, IntPtr lpBuffer, int dwBufferLength);

		private static unsafe void SuppressWininetBehavior()
		{
			/* SOURCE: http://msdn.microsoft.com/en-us/library/windows/desktop/aa385328%28v=vs.85%29.aspx
				* INTERNET_OPTION_SUPPRESS_BEHAVIOR (81):
				*      A general purpose option that is used to suppress behaviors on a process-wide basis. 
				*      The lpBuffer parameter of the function must be a pointer to a DWORD containing the specific behavior to suppress. 
				*      This option cannot be queried with InternetQueryOption. 
				*      
				* INTERNET_SUPPRESS_COOKIE_PERSIST (3):
				*      Suppresses the persistence of cookies, even if the server has specified them as persistent.
				*      Version:  Requires Internet Explorer 8.0 or later.
				*/

			int option = (int)3/* INTERNET_SUPPRESS_COOKIE_PERSIST*/;
			int* optionPtr = &option;

			bool success = InternetSetOption(0, 81/*INTERNET_OPTION_SUPPRESS_BEHAVIOR*/, new IntPtr(optionPtr), sizeof(int));
			if (!success)
			{
				MessageBox.Show("Something went wrong !>?");
			}
		}

		/// <summary>
		/// Criar um usuário na plataforma AnonFiles.com.
		/// </summary>
		/// <param name="User"></param>
		/// <param name="Pass"></param>
		/// <returns></returns>
		public void Dispose() =>
			GC.SuppressFinalize(this);
	}
}
