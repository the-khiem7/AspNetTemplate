FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy only the test project and its dependencies
COPY ["NetTemplate.UnitTest/NetTemplate.UnitTest.csproj", "NetTemplate.UnitTest/"]
COPY ["NetTemplate.Service/NetTemplate.BLL.csproj", "NetTemplate.Service/"]
COPY ["NetTemplate.Data/NetTemplate.DAL.csproj", "NetTemplate.Data/"]

# Restore the test project (which will pull in dependencies)
RUN dotnet restore "NetTemplate.UnitTest/NetTemplate.UnitTest.csproj"

# Copy the rest of the source code
COPY . .

# Create test results directory
RUN mkdir -p /TestResults

# Run tests
ENTRYPOINT ["dotnet", "test", "NetTemplate.UnitTest/NetTemplate.UnitTest.csproj", \
    "--logger:trx", \
    "--results-directory", "/TestResults", \
    "--verbosity", "detailed"] 