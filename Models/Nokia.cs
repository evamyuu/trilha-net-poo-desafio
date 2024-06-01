namespace DesafioPOO.Models
{
    /// <summary>
    /// Represents a Nokia smartphone.
    /// </summary>
    public class Nokia : Smartphone
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Nokia"/> class with the specified number, model, IMEI, and memory.
        /// </summary>
        /// <param name="number">The phone number.</param>
        /// <param name="model">The model of the Nokia smartphone.</param>
        /// <param name="imei">The IMEI number.</param>
        /// <param name="memory">The memory capacity in gigabytes.</param>
        public Nokia(string number, string model, string imei, int memory)
            : base(number, model, imei, memory)
        {
        }

        /// <summary>
        /// Installs an application on the Nokia smartphone.
        /// </summary>
        /// <param name="appName">The name of the application to install.</param>
        public override void InstallApp(string appName)
        {
            Console.WriteLine($"Installing the app {appName} on {Model}");
        }
    }
}