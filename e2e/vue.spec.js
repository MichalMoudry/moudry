import { test, expect } from '@playwright/test'

test('visits the app root url', async ({ page }) => {
  await page.goto('/')
  await expect(page.locator('h1')).toHaveText('Michal Moudrý')

  await expect(page.locator('id=about-card')).toBeVisible()
  await expect(page.locator('id=work-experience-card')).toBeVisible()
})

test('test navigation to the skills page', async ({ page }) => {
  await page.goto('/')
  await page.getByText('More skills').click()

  expect(page.locator('h2')).toHaveText('Skills')
  expect(page.getByTestId('knowledge-table')).toBeVisible()
})
