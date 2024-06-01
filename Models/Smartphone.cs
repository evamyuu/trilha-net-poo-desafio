namespace DesafioPOO.Models
{

    /// <summary>
    /// Represents a generic smartphone with basic functionalities.
    /// </summary>
    public abstract class Smartphone
    {
        // Properties

        /// <summary>
        /// Gets the phone number associated with the smartphone.
        /// </summary>
        public string Number { get; protected set; }

        /// <summary>
        /// Gets the model of the smartphone.
        /// </summary>
        protected string Model { get; }

        /// <summary>
        /// Gets the IMEI (International Mobile Equipment Identity) number of the smartphone.
        /// </summary>
        protected string Imei { get; }

        /// <summary>
        /// Gets the memory capacity of the smartphone in gigabytes.
        /// </summary>
        protected int Memory { get; }

        // Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="Smartphone"/> class with the specified number, model, IMEI, and memory.
        /// </summary>
        /// <param name="number">The phone number.</param>
        /// <param name="model">The model of the smartphone.</param>
        /// <param name="imei">The IMEI number.</param>
        /// <param name="memory">The memory capacity in gigabytes.</param>
        /// <exception cref="ArgumentException">Thrown when any parameter is null, whitespace, or invalid.</exception>
        public Smartphone(string number, string model, string imei, int memory)
        {
            if (string.IsNullOrWhiteSpace(number))
                throw new ArgumentException("Invalid number", nameof(number));

            if (string.IsNullOrWhiteSpace(model))
                throw new ArgumentException("Invalid model", nameof(model));

            if (string.IsNullOrWhiteSpace(imei))
                throw new ArgumentException("Invalid IMEI", nameof(imei));

            if (memory <= 0)
                throw new ArgumentException("Invalid memory", nameof(memory));

            Number = number;
            Model = model;
            Imei = imei;
            Memory = memory;
        }

        // Methods

        /// <summary>
        /// Makes a call from the smartphone.
        /// </summary>
        public void MakeCall()
        {
            Console.WriteLine("Making a call...");
        }

        /// <summary>
        /// Turns off the smartphone.
        /// </summary>
        public void TurnOff()
        {
            Console.WriteLine("Turning off...");
        }

        /// <summary>
        /// Receives a call on the smartphone.
        /// </summary>
        public void ReceiveCall()
        {
            Console.WriteLine("Receiving a call...");
        }

        /// <summary>
        /// Installs an application on the smartphone.
        /// This method must be implemented by derived classes.
        /// </summary>
        /// <param name="appName">The name of the application to install.</param>
        public abstract void InstallApp(string appName);
    }
}