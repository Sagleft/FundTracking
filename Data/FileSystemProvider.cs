using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;
using Newtonsoft.Json;

namespace FundTracking.Data
{
	/// <summary>
	/// File System Provider
	/// </summary>
	public class FileSystemProvider
	{
		private string dataPath = "finance.ftf";
		//от bson выйгрыш всего 5%
		//private DataContainer dataContainer = null;
		
		public FileSystemProvider() {
			this.load();
		}
		
//		public static string DecompressString(string input)
//		{
//			//thnx, Lasse Vågsæther Karlsen
//		    byte[] compressed = Convert.FromBase64String(input);
//		    byte[] decompressed = DecompressBytes(compressed);
//		    return Encoding.UTF8.GetString(decompressed);
//		}
//		
//		public static string CompressString(string input)
//		{
//		    byte[] encoded = Encoding.UTF8.GetBytes(input);
//		    byte[] compressed = CompressBytes(encoded);
//		    return Convert.ToBase64String(compressed);
//		}
		
		public static byte[] DecompressBytes(byte[] input)
		{
		    using (var source = new MemoryStream(input))
		    {
		        byte[] lengthBytes = new byte[4];
		        source.Read(lengthBytes, 0, 4);
		
		        var length = BitConverter.ToInt32(lengthBytes, 0);
		        using (var decompressionStream = new GZipStream(source,
		            CompressionMode.Decompress))
		        {
		            var result = new byte[length];
		            decompressionStream.Read(result, 0, length);
		            return result;
		        }
		    }
		}
		
		public static byte[] CompressBytes(byte[] input)
		{
		    using (var result = new MemoryStream())
		    {
		        var lengthBytes = BitConverter.GetBytes(input.Length);
		        result.Write(lengthBytes, 0, 4);
		
		        using (var compressionStream = new GZipStream(result,
		            CompressionMode.Compress))
		        {
		            compressionStream.Write(input, 0, input.Length);
		            compressionStream.Flush();
		
		        }
		        return result.ToArray();
		    }
		}
		
		public DataContainer load() {
			DataContainer dataContainer = null;
			//пока так, не охота пока гору проверок писать
			if(File.Exists(dataPath)) {
				byte[] encoded = File.ReadAllBytes(dataPath);
				byte[] decoded = DecompressBytes(encoded);
				string json = Encoding.UTF8.GetString(decoded);
				//string json = Decompress(File.ReadAllText(dataPath));
				dataContainer = JsonConvert.DeserializeObject<DataContainer>(json);
			} else {
				dataContainer = new DataContainer();
				dataContainer.entrys_list = new List<FundEntry>();
				//string json = JsonConvert.SerializeObject(dataContainer);
				//File.WriteAllText(dataPath, Compress(json));
				save(dataContainer);
			}
			return dataContainer;
		}
		
		public void save(DataContainer container) {
			string json = JsonConvert.SerializeObject(container);
			byte[] encoded = Encoding.UTF8.GetBytes(json);
			//сохранение в бинарном виде
			File.WriteAllBytes(this.dataPath, CompressBytes(encoded));
		}
	}
}
