import { test, expect } from '@playwright/test'

test('test navigation to the skills page', async ({ page }) => {
  await page.goto('/')
  await page.getByText('More skills').click()

  expect(page.locator('h2')).toHaveText('Skills')
  expect(page.getByTestId('knowledge-table')).toBeVisible()
})
