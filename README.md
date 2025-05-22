

HEADED=1 dotnet test

dotnet test --settings:chromium.runsettings

<?xml version="1.0" encoding="utf-8"?>
  <RunSettings>
    <Playwright>
      <BrowserName>chromium</BrowserName>
    </Playwright>
  </RunSettings>


### Installing PowerShell on Windows
```Shell
    winget install --id Microsoft.PowerShell --source winget
    bin/Debug/net8.0/playwright.ps1 install
```
### Installing PowerShell on MacOS
```Shell
    brew install --cask powershell
    pwsh bin/Debug/net8.0/playwright.ps1 install
```

dotnet test -- xUnit.MaxParallelThreads=5

PWDEBUG=1 dotnet test --filter "UnitTest1|UnitTest2"