import { test, expect } from '@playwright/test'

test('test navigation to the skills page', async ({ page }) => {
  await page.goto('/')
  await page.getByText('More skills').click()
  await page.waitForURL('**/skills')

  const header = page.locator('h2 .text-2xl')
  await header.waitFor()
  expect(header).toHaveText('Skills')
  expect(page.getByTestId('knowledge-table')).toBeVisible()
})
