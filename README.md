

HEADED=1 dotnet test

dotnet test --settings:chromium.runsettings

<?xml version="1.0" encoding="utf-8"?>
  <RunSettings>
    <Playwright>
      <BrowserName>chromium</BrowserName>
    </Playwright>
  </RunSettings>


dotnet test -- xUnit.MaxParallelThreads=5

PWDEBUG=1 dotnet test --filter "UnitTest1|UnitTest2"