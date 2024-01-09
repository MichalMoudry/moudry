namespace UiTests

open NUnit.Framework
open Microsoft.Playwright.NUnit

[<Sealed>]
[<Parallelizable(ParallelScope.Self)>]
[<TestFixture>]
type MainTests() =
    inherit PageTest()
    override _.ContextOptions() = Settings.BrowserContextOptions

    /// A test scenario covering navigation to the main page.
    [<Test>]
    member this.``Test app root url`` () =
        async {
            this.Page.GotoAsync("/")
                |> Async.AwaitTask
                |> Async.RunSynchronously
                |> ignore

            this.Expect(this.Page.Locator("h1")).ToHaveTextAsync("Michal Moudrý")
                |> Async.AwaitTask
                |> Async.RunSynchronously
            
            this.Expect(this.Page.Locator("id=about-card")).ToBeVisibleAsync()
                |> Async.AwaitTask
                |> Async.RunSynchronously
            
            this.Expect(this.Page.Locator("id=work-experience-card")).ToBeVisibleAsync()
                |> Async.AwaitTask
                |> Async.RunSynchronously
        }
