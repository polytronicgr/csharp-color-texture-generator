using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_color_texture_generator
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button_Generate_Click(object sender, EventArgs e)
		{
			int width = Math.Max(16, int.Parse(textBox_Width.Text));
			int height = Math.Max(16, int.Parse(textBox_Height.Text));
			int rCount = Math.Max(2, Math.Min(255, int.Parse(textBox_R.Text)));
			int gCount = Math.Max(2, Math.Min(255, int.Parse(textBox_G.Text)));
			int bCount = Math.Max(2, Math.Min(255, int.Parse(textBox_B.Text)));
			int taskMax = Math.Max(0, int.Parse(textBox_TaskCount.Text));

			var time = System.DateTime.Now;
			if (taskMax < 2)
				SingleThread(width, height, rCount, gCount, bCount);
			else
				MultiThread(width, height, rCount, gCount, bCount, taskMax);
			var sec = (System.DateTime.Now - time).TotalSeconds;
			System.Diagnostics.Debug.Print(sec.ToString());
		}

		void SingleThread(int width, int height, int rCount, int gCount, int bCount)
		{
			var bitmap = new Bitmap(width, height);
			var bitmapData = bitmap.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
			var lineSize = bitmapData.Stride * height;
			var lineData = new byte[lineSize];

			var path = @"_Outputs\";
			if (!Directory.Exists(path))
				Directory.CreateDirectory(path);
			for (int r = 0; r < rCount; r++)
			{
				int R = Math.Min(255, r * 256 / (rCount - 1));
				var dir2 = "R" + R.ToString("D3");
				var path2 = path + dir2 + @"\";
				if (!Directory.Exists(path2))
					Directory.CreateDirectory(path2);
				for (int g = 0; g < gCount; g++)
				{
					int G = Math.Min(255, g * 256 / (gCount - 1));
					var dir3 = "G" + G.ToString("D3");
					var path3 = path2 + dir3 + @"\";
					if (!Directory.Exists(path3))
						Directory.CreateDirectory(path3);
					for (int b = 0; b < bCount; b++)
					{
						int B = Math.Min(255, b * 256 / (bCount - 1));
						for (int i = 0; i < bitmapData.Stride * height; i += 4)
						{
							lineData[i + 3] = 0xFF;
							lineData[i + 2] = (byte)R;
							lineData[i + 1] = (byte)G;
							lineData[i + 0] = (byte)B;
						}
						Marshal.Copy(lineData, 0, bitmapData.Scan0, bitmapData.Stride * height);

						var dir4 = "B" + B.ToString("D3");
						var path4 = path3 + dir2 + dir3 + dir4 + @".png";
						bitmap.Save(path4);
					}
				}
			}
		}

		void MultiThread(int width, int height, int rCount, int gCount, int bCount, int taskMax)
		{
			var tasks = new Task[taskMax];
			var taskCount = 0;

			var path = @"_Outputs\";
			if (!Directory.Exists(path))
				Directory.CreateDirectory(path);
			for (int r = 0; r < rCount; r++)
			{
				int R = Math.Min(255, r * 256 / (rCount - 1));
				var dir2 = "R" + R.ToString("D3");
				var path2 = path + dir2 + @"\";
				if (!Directory.Exists(path2))
					Directory.CreateDirectory(path2);
				for (int g = 0; g < gCount; g++)
				{
					int G = Math.Min(255, g * 256 / (gCount - 1));
					var dir3 = "G" + G.ToString("D3");
					var path3 = path2 + dir3 + @"\";
					if (!Directory.Exists(path3))
						Directory.CreateDirectory(path3);
					for (int b = 0; b < bCount; b++)
					{
						int B = Math.Min(255, b * 256 / (bCount - 1));
						tasks[taskCount++] = Task.Run(() =>
						{
							var bitmap = new Bitmap(width, height);
							var bitmapData = bitmap.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
							var lineSize = bitmapData.Stride * height;
							var lineData = new byte[lineSize];

							for (int i = 0; i < bitmapData.Stride * height; i += 4)
							{
								lineData[i + 3] = 0xFF;
								lineData[i + 2] = (byte)R;
								lineData[i + 1] = (byte)G;
								lineData[i + 0] = (byte)B;
							}
							Marshal.Copy(lineData, 0, bitmapData.Scan0, bitmapData.Stride * height);

							var dir4 = "B" + B.ToString("D3");
							var path4 = path3 + dir2 + dir3 + dir4 + @".png";
							bitmap.Save(path4);
						});

						if (taskCount == taskMax)
						{
							Task.WaitAll(tasks);
							taskCount = 0;
						}
					}
				}
			}
		}
	}
}
