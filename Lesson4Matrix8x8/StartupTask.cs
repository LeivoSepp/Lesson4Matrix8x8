using Windows.ApplicationModel.Background;
using Glovebox.Graphics.Drivers;
using Glovebox.Graphics.Components;

namespace Lesson4Matrix8x8
{
    public sealed class StartupTask : IBackgroundTask
    {
        Ht16K33 driver = new Ht16K33(new byte[] { 0x70 }, Ht16K33.Rotate.None);

        public void Run(IBackgroundTaskInstance taskInstance)
        {
            LED8x8Matrix matrix = new LED8x8Matrix(driver);

            while (true)
            {
                var message = $"Tere, Robootika.COM";
                matrix.ScrollStringInFromRight(message, 70);
            }
        }
    }
}
