# DC Snoop Database Writer
This is a command line tool to populate a PostgreSQL database with voter registration information for use by the [DC Snoop](https://www.dcsnoop.com) website. The code repository for this web application can be found [here](https://github.com/sethpuckett/dc-snoop).

## Setup

* Follow the setup instructions for the DC Snoop web application (above) to create the `dc-snoop` database.
* Update the connection string in `appsettings.json` to match the settings used when PostgreSQL was setup.
* Update the `RegistrationFilePath` value in `appsettings.json` to point to the directory containing the registration data csv files.
* From the command line navigate to the root directory and run `dotnet build` to build the application.
* Navigate to the directory containing the output files, probably `./bin/Debug/netcoreapp1.1/`
* Run the application with `dotnet ./dc-snoop-database-writer.dll`

## Notes

If you do not have the registration data csv files they can be generated using a copy of the PDF supplied by the DCBOE and [this tool](https://github.com/sethpuckett/registration-parser/tree/master/RegistrationParser).
