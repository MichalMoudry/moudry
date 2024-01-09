module internal Settings

open System
open Microsoft.Playwright

/// Default browser context options.
let BrowserContextOptions =
    let baseUrl = Environment.GetEnvironmentVariable("BASE_URL")
    BrowserNewContextOptions(
        BaseURL =
            if baseUrl <> null then
                baseUrl
            else
                "https://moudry.vercel.app"
    )
