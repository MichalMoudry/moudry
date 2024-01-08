"""
Module for testing navigation in the app.
"""
from playwright.sync_api import Page, expect


def test_navigation_to_skills_page(page: Page):
    """
    Test scenario covering navigation from main page to skills page.
    """
    page.goto("https://moudry.vercel.app/")
    page.get_by_text("More skills").click()

    expect(page.locator("h2 .text-2xl")).to_have_text("Skills")
    expect(page.get_by_test_id("knowledge-table")).to_be_visible()
    expect(page.get_by_test_id("tools-table")).to_be_visible()
