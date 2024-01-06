// Client code

// Existing Fahrenheit temperature
using Adapter.Temperature.Adaptees;
using Adapter.Temperature.Adapters;
using Adapter.Temperature.Client;
using Adapter.Temperature.Targets;

FahrenheitTemperature fahrenheitTemperature = new FahrenheitTemperature(80.6);

// Adapter to use Fahrenheit temperature as Celsius
ICelsiusTemperature adapter = new FahrenheitToCelsiusAdapter(fahrenheitTemperature);

// Client code can now work with temperatures in Celsius
TemperatureClient temperatureClient = new TemperatureClient();
temperatureClient.DisplayTemperature(adapter);