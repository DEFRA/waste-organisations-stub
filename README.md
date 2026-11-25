# waste-organisations-stub

Core delivery C# ASP.NET backend template.

* [Testing](#testing)
* [Running](#running)
* [Dependabot](#dependabot)


### Docker Compose

A Docker Compose template is in [compose.yml](compose.yml).

A local environment with:

- Localstack for AWS services (S3, SQS)
- Redis
- This service.
- A commented out frontend example.

```bash
docker compose up --build -d
```

A more extensive setup is available in [github.com/DEFRA/cdp-local-environment](https://github.com/DEFRA/cdp-local-environment)

### Testing

Build and run the tests with:

```bash
dotnet build WasteOrganisationsStub.Test/WasteOrganisationsStub.Test.csproj
dotnet test --test-modules WasteOrganisationsStub.Test/bin/Debug/net10.0/WasteOrganisationsStub.Test.dll --no-build
```

### Running

Run CDP-Deployments application:
```bash
dotnet run --project WasteOrganisationsStub --launch-profile Development
```

### SonarCloud

Example SonarCloud configuration are available in the GitHub Action workflows.

### Dependabot

We have added an example dependabot configuration file to the repository. You can enable it by renaming
the [.github/example.dependabot.yml](.github/example.dependabot.yml) to `.github/dependabot.yml`


### About the licence

The Open Government Licence (OGL) was developed by the Controller of Her Majesty's Stationery Office (HMSO) to enable
information providers in the public sector to license the use and re-use of their information under a common open
licence.

It is designed to encourage use and re-use of information freely and flexibly, with only a few conditions.
