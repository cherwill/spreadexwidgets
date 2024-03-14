using System.Text;
using Widgets.Providers;

namespace Widgets.Tests.Helpers;

public static class TextRendererTestHelper {
        public static string BuildExpected(params string[] expectedShapes)
        {
            StringBuilder stringBuilder = new();
            stringBuilder.AppendFormat("{0}{1}", FrameProvider.CanvasHeader, Environment.NewLine);

            foreach (string shape in expectedShapes)
            {
                stringBuilder.AppendFormat("{0}{1}", shape, Environment.NewLine);
            }

            stringBuilder.Append(FrameProvider.CanvasFooter);
            return stringBuilder.ToString();
        }

        public static string TextFromStream(Stream stream)
        {
            stream.Seek(0, SeekOrigin.Begin);
            byte[] readBytes = new byte[stream.Length];
            int bytesRead = stream.Read(readBytes, 0, (int)stream.Length);

            return Encoding.ASCII.GetString(readBytes, 0, bytesRead);
        }
}