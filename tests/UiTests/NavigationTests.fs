namespace UiTests

open NUnit.Framework
open Microsoft.Playwright.NUnit

[<Sealed>]
[<Parallelizable(ParallelScope.Self)>]
[<TestFixture>]
type NavigationTests() =
    inherit PageTest()
    override _.ContextOptions() = Settings.BrowserContextOptions

    /// Test scenario covering navigation from main page to skills page.
    [<Test>]
    member this.``Test navigation to skills page`` () =
        async {
            this.Page.GotoAsync("/")
                |> Async.AwaitTask
                |> Async.RunSynchronously
                |> ignore

            do!
                this.Page.GetByText("More skills").ClickAsync() |> Async.AwaitTask
            do!
                this.Expect(
                    this.Page.Locator("h2 .text-2xl")
                ).ToHaveTextAsync("Skills") |> Async.AwaitTask
            let! isKnowledgeTableVisible =
                this.Page.GetByTestId("knowledge-table").IsVisibleAsync()
                |> Async.AwaitTask
            let! isToolsTableVisible =
                this.Page.GetByTestId("tools-table").IsVisibleAsync()
                |> Async.AwaitTask
            
            Assert.Multiple(fun _ -> (
                Assert.That(isKnowledgeTableVisible, Is.True)
                Assert.That(isToolsTableVisible, Is.True)
            ))
        }
