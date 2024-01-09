namespace UiTests

open NUnit.Framework
open Microsoft.Playwright.NUnit
open System.Text.RegularExpressions

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

    /// A test case covering a basic scenario of navigating to a SPS page
    /// and validating if projects are displayed.
    [<TestCase("sps", 3)>]
    [<TestCase("vse1", 5)>]
    [<TestCase("vse2", 4)>]
    member this.``Navigate to an education page and count projects`` (pageId: string) projectCount =
        this.Page.GotoAsync("/")
            |> Async.AwaitTask
            |> Async.RunSynchronously
            |> ignore

        this.Page
            .Locator($"xpath=//div[@id='{pageId}']//div[@title='View menu']/button")
            .ClickAsync()
            |> Async.AwaitTask
            |> Async.RunSynchronously

        this.Page.Locator($"xpath=//a[@href='/{pageId}']").ClickAsync()
            |> Async.AwaitTask
            |> Async.RunSynchronously

        this.Expect(this.Page).ToHaveURLAsync(Regex($".*/{pageId}"))
            |> Async.AwaitTask
            |> Async.RunSynchronously

        this.Expect(this.Page.Locator(".project")).ToHaveCountAsync(projectCount)
            |> Async.AwaitTask
            |> Async.RunSynchronously
