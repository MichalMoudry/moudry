import { test, expect } from '@playwright/test'

test('test navigation to the skills page', async ({ page }) => {
  await page.goto('/')
  await page.getByText('More skills').click()
  await page.waitForURL('**/skills')

  expect(page.locator('h2 .text-2xl')).toHaveText('Skills')
  expect(page.getByTestId('knowledge-table')).toBeVisible()
})
