"""
Module containing tests for the main page.
"""
from playwright.sync_api import Page, expect


def test_app_root_url(page: Page):
    """
    A test scenario covering navigation to the main page.
    """
    page.goto("https://moudry.vercel.app/")

    expect(page.locator('h1')).to_have_text("Michal Moudrý")
    expect(page.locator('id=about-card')).to_be_visible()
    expect(page.locator('id=work-experience-card')).to_be_visible()
