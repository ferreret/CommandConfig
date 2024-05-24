using Microsoft.Extensions.Configuration;

// NOTA IMPORTANTE!!!
// En este caso, el orden en que se añaden el arhive de configuración y los secretos de usuario es importante.
// El último valor que se añade es el que prevalece.

IConfigurationBuilder builder = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .AddUserSecrets(typeof(Program).Assembly, optional: true);

IConfigurationRoot configuration = builder.Build();

Console.WriteLine($"I think the password is: {configuration["Password"]}");
