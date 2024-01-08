import { test, expect } from '@playwright/test'

test('visits the app root url', async ({ page }) => {
  await page.goto('/')
  await expect(page.locator('h1')).toHaveText('Michal Moudrý')

  await expect(page.locator('id=about-card')).toBeVisible()
  await expect(page.locator('id=work-experience-card')).toBeVisible()
})
